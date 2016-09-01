using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordMLReportExample
{
    static class Replacer
    {
        public static BookmarksPair[] GetBookmarks(string filename)
        {
            var templateFile = new FileInfo(filename);

            if (templateFile.Exists)
            {
                using (var documentStream = templateFile.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.Read))
                {
                    using (var document = WordprocessingDocument.Open(documentStream, true))
                    {
                        var bookmarks = GetBookmarks(document.MainDocumentPart, "").ToArray();
                        return bookmarks;
                    }
                }
            }

            return new BookmarksPair[] { };
        }

        public static void ReplaceAndSave(string filenameSource, string filenameDestination, string bookmarkName, string value)
        {
            var templateFile = new FileInfo(filenameSource);

            if (templateFile.Exists)
            {
                var tempFile = templateFile.CopyTo(Path.GetTempFileName(), true);

                using (var documentStream = tempFile.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.Read))
                {
                    using (var document = WordprocessingDocument.Open(documentStream, true))
                    {
                        var bookmarks = GetBookmarks(document.MainDocumentPart, "");

                        BookmarksPair pair = bookmarks.FirstOrDefault(x => x.Start.Name == bookmarkName);

                        if (pair != null)
                        {
                            ReplaceBookmarkContent(pair, value);
                        }

                    }
                }

                tempFile.MoveTo(filenameDestination);
            }
        }

        private static IEnumerable<BookmarksPair> GetBookmarks(MainDocumentPart documentPart, string prefix)
        {
            var starts = documentPart.Document.Descendants<BookmarkStart>();
            var ends = documentPart.Document.Descendants<BookmarkEnd>();

            var result = from start in starts
                         join end in ends on (string)start.Id equals (string)end.Id
                         where ((string)start.Name).StartsWith(prefix)
                         where start.Parent == end.Parent // Закладки, находящиеся внутри общего элемента
                         select new BookmarksPair(start, end);
            return result;
        }

        private static void ReplaceBookmarkContent(BookmarksPair bookmarksPair, string value)
        {
            CleanContentBetweenBookmarks(bookmarksPair);

            Run run = new Run(new Text(value));

            bookmarksPair.Start.InsertAfterSelf(run);
        }

        private static void CleanContentBetweenBookmarks(BookmarksPair bookmarksPair)
        {
            List<OpenXmlElement> elements = new List<OpenXmlElement>();
            OpenXmlElement element = bookmarksPair.Start.NextSibling();

            while (element != null)
            {
                if (element == bookmarksPair.End) break;

                elements.Add(element);

                element = element.NextSibling();
            }

            foreach (var item in elements)
            {
                item.Remove();
            }
        }


        public class BookmarksPair
        {
            public BookmarkStart Start { get; private set; }
            public BookmarkEnd End { get; private set; }

            public BookmarksPair(BookmarkStart start, BookmarkEnd end)
            {
                this.Start = start;
                this.End = end;
            }
        }
    }
}

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordMLReportExample
{
    class Replacer : IDisposable
    {
        private string mFileName;

        public Replacer(string filename)
        {

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public static BookmarksPair[] GetBookmarks(string filename)
        {
            var templateFile = new FileInfo(filename);

            using (var documentStream = templateFile.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.Read))
            {
                using (var document = WordprocessingDocument.Open(documentStream, true))
                {
                    var bookmarks = GetBookmarks(document.MainDocumentPart, "").ToArray();
                    return bookmarks;
                }
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

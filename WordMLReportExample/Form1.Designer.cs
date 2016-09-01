namespace WordMLReportExample
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSelectTemplateFile = new System.Windows.Forms.Button();
            this.textBoxTemplateFileName = new System.Windows.Forms.TextBox();
            this.buttonShowBookmarks = new System.Windows.Forms.Button();
            this.listBoxBookmarks = new System.Windows.Forms.ListBox();
            this.textBoxTextValue = new System.Windows.Forms.TextBox();
            this.buttonReplaceAndSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSelectTemplateFile
            // 
            this.buttonSelectTemplateFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSelectTemplateFile.AutoSize = true;
            this.buttonSelectTemplateFile.Location = new System.Drawing.Point(3, 3);
            this.buttonSelectTemplateFile.Name = "buttonSelectTemplateFile";
            this.buttonSelectTemplateFile.Size = new System.Drawing.Size(115, 23);
            this.buttonSelectTemplateFile.TabIndex = 0;
            this.buttonSelectTemplateFile.Text = "Select template file...";
            this.buttonSelectTemplateFile.UseVisualStyleBackColor = true;
            this.buttonSelectTemplateFile.Click += new System.EventHandler(this.buttonSelectTemplateFile_Click);
            // 
            // textBoxTemplateFileName
            // 
            this.textBoxTemplateFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTemplateFileName.Location = new System.Drawing.Point(124, 4);
            this.textBoxTemplateFileName.Name = "textBoxTemplateFileName";
            this.textBoxTemplateFileName.ReadOnly = true;
            this.textBoxTemplateFileName.Size = new System.Drawing.Size(399, 20);
            this.textBoxTemplateFileName.TabIndex = 1;
            // 
            // buttonShowBookmarks
            // 
            this.buttonShowBookmarks.AutoSize = true;
            this.buttonShowBookmarks.Location = new System.Drawing.Point(3, 32);
            this.buttonShowBookmarks.Name = "buttonShowBookmarks";
            this.buttonShowBookmarks.Size = new System.Drawing.Size(99, 23);
            this.buttonShowBookmarks.TabIndex = 2;
            this.buttonShowBookmarks.Text = "Show bookmarks";
            this.buttonShowBookmarks.UseVisualStyleBackColor = true;
            this.buttonShowBookmarks.Click += new System.EventHandler(this.buttonShowBookmarks_Click);
            // 
            // listBoxBookmarks
            // 
            this.listBoxBookmarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxBookmarks.FormattingEnabled = true;
            this.listBoxBookmarks.IntegralHeight = false;
            this.listBoxBookmarks.Location = new System.Drawing.Point(124, 32);
            this.listBoxBookmarks.Name = "listBoxBookmarks";
            this.listBoxBookmarks.Size = new System.Drawing.Size(399, 263);
            this.listBoxBookmarks.TabIndex = 3;
            // 
            // textBoxTextValue
            // 
            this.textBoxTextValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTextValue.Location = new System.Drawing.Point(124, 302);
            this.textBoxTextValue.Name = "textBoxTextValue";
            this.textBoxTextValue.Size = new System.Drawing.Size(399, 20);
            this.textBoxTextValue.TabIndex = 1;
            // 
            // buttonReplaceAndSave
            // 
            this.buttonReplaceAndSave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonReplaceAndSave.AutoSize = true;
            this.buttonReplaceAndSave.Location = new System.Drawing.Point(3, 301);
            this.buttonReplaceAndSave.Name = "buttonReplaceAndSave";
            this.buttonReplaceAndSave.Size = new System.Drawing.Size(115, 23);
            this.buttonReplaceAndSave.TabIndex = 2;
            this.buttonReplaceAndSave.Text = "Replace and Save...";
            this.buttonReplaceAndSave.UseVisualStyleBackColor = true;
            this.buttonReplaceAndSave.Click += new System.EventHandler(this.buttonReplaceAndSave_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.listBoxBookmarks, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonShowBookmarks, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonReplaceAndSave, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTextValue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonSelectTemplateFile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTemplateFileName, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(526, 327);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 327);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "WordML Replace Demo";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectTemplateFile;
        private System.Windows.Forms.TextBox textBoxTemplateFileName;
        private System.Windows.Forms.Button buttonShowBookmarks;
        private System.Windows.Forms.ListBox listBoxBookmarks;
        private System.Windows.Forms.TextBox textBoxTextValue;
        private System.Windows.Forms.Button buttonReplaceAndSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}


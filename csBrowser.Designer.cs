namespace csBrowser
{
    partial class csBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            WebView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            UrlText = new TextBox();
            UrlList = new ListBox();
            ((System.ComponentModel.ISupportInitialize)WebView21).BeginInit();
            SuspendLayout();
            // 
            // WebView21
            // 
            WebView21.AllowExternalDrop = true;
            WebView21.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            WebView21.CreationProperties = null;
            WebView21.DefaultBackgroundColor = Color.White;
            WebView21.Location = new Point(12, 29);
            WebView21.Name = "WebView21";
            WebView21.Size = new Size(1067, 609);
            WebView21.TabIndex = 0;
            WebView21.ZoomFactor = 1D;
            // 
            // UrlText
            // 
            UrlText.Dock = DockStyle.Top;
            UrlText.Location = new Point(0, 0);
            UrlText.Name = "UrlText";
            UrlText.Size = new Size(1201, 23);
            UrlText.TabIndex = 1;
            UrlText.TextChanged += urlText_TextChanged;
            UrlText.KeyDown += urlText_KeyDown;
            // 
            // UrlList
            // 
            UrlList.Dock = DockStyle.Right;
            UrlList.FormattingEnabled = true;
            UrlList.ItemHeight = 15;
            UrlList.Location = new Point(1085, 23);
            UrlList.Name = "UrlList";
            UrlList.Size = new Size(116, 627);
            UrlList.TabIndex = 2;
            // 
            // csBrowser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 650);
            Controls.Add(UrlList);
            Controls.Add(UrlText);
            Controls.Add(WebView21);
            Name = "csBrowser";
            Text = "csBrowser";
            ((System.ComponentModel.ISupportInitialize)WebView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 WebView21;
        private TextBox UrlText;
        private ListBox UrlList;
    }
}
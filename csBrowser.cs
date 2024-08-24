using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace csBrowser
{
    public partial class csBrowser : Form
    {
        public csBrowser()
        {
            InitializeComponent();
            InitializeWebView();
        }

        private async void InitializeWebView()
        {
            string strUrl;
            await WebView21.EnsureCoreWebView2Async(null);

            strUrl = "https://www.google.com";

            WebView21.CoreWebView2.Navigate(strUrl);  // 初期ページを設定
            UrlText.Text = strUrl;

            // NavigationCompletedイベントハンドラを追加
            WebView21.CoreWebView2.NavigationCompleted += CoreWebView2_NavigationCompleted;
        }

        private void urlText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string url = UrlText.Text;

                // URLが空でない場合にリストボックスの一番上に追加
                if (!string.IsNullOrWhiteSpace(url))
                {
                    AddUrlToList(url);
                    WebView21.CoreWebView2.Navigate(url);  // WebView2を更新
                    UrlText.Clear();  // テキストボックスをクリア
                }

                e.Handled = true;  // イベントを処理済みに設定する（オプション）
                e.SuppressKeyPress = true;  // エンターキーの「音」を抑制（オプション）
            }
        }

        private void urlText_TextChanged(object sender, EventArgs e)
        {
        }

        private void AddUrlToList(string url)
        {
            // URLをリストボックスの一番上に追加
            UrlList.Items.Insert(0, url);

            // リストボックスの項目数が50を超えた場合、最も古いエントリを削除
            if (UrlList.Items.Count > 50)
            {
                UrlList.Items.RemoveAt(UrlList.Items.Count - 1);  // 最後の項目（古い項目）を削除
            }
        }

        private void CoreWebView2_NavigationCompleted(object? sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            // UIスレッドで更新する
            this.Invoke(new Action(() =>
            {
                // 現在のURLを取得してurlTextに表示
                UrlText.Text = WebView21.CoreWebView2.Source;

                string url = UrlText.Text;

                // URLが空でない場合にリストボックスの一番上に追加
                if (!string.IsNullOrWhiteSpace(url))
                {
                    AddUrlToList(url);
                }
            }));
        }
    }
}

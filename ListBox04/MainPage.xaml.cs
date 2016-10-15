using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページのアイテム テンプレートについては、http://go.microsoft.com/fwlink/?LinkId=234238 を参照してください

namespace ListBox04
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.createListItem();
        }
        
        private void createListItem()
        {
            // ListItemに項目を追加し、ListBoxのDataContextにセット
            List<string> listItem = new List<string>();
            listItem.Add("項目1");
            listItem.Add("項目2");
            listItem.Add("項目3");
            listBoxName.DataContext = listItem;
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // 選択された複数項目を取得する
            var list = listBoxName.SelectedItems;

            // 選択項目をテキストブロックに出力する
            String selectItems = String.Join(" ", list);
            textBlockName.Text = "選択項目：" + selectItems;

        }
    }
}

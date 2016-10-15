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

namespace ComboBox03
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
            // ListItemに項目を追加し、ComboBoxのDataContextにセット
            List<string> listItem = new List<string>();
            listItem.Add("項目1");
            listItem.Add("項目2");
            listItem.Add("項目3");
            comboBox.DataContext = listItem;
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // 選択された項目のIndexとItemを出力
            textBlockName.Text = "Index:" + comboBox.SelectedIndex.ToString()
                               + "\nItem: "+ comboBox.SelectedItem.ToString();
        }
    }
}

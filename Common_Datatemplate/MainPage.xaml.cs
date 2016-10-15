using Common.DataModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Common_Datatemplate
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.createItems();
        }

        private void createItems()
        {
            // ListViewで表示するデータを追加する
            var items = new ObservableCollection<AddressDataSource>();

            items.Add(new AddressDataSource("220-8110",
                                   "横浜市西区みなとみらい2-2-1",
                                   "ランド マーク"));

            items.Add(new AddressDataSource("231-0023",
                                   "横浜市中区山下町279",
                                   "山下 こうえん"));

            items.Add(new AddressDataSource("231-0002",
                                   "横浜市中区海岸通1-1-4",
                                   "大 さんばし"));

            // ListViewコントロールにデータをセットする
            listViewName.ItemsSource = items;
        }

    }
}

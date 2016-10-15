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

namespace ListView06
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
            // 変数itemsに表示するデータを追加する
            var items = new ObservableCollection<SampleDataSource>();


            items.Add(new SampleDataSource("/Common/Images/image1.png",
                                   "Title1",
                                   "Subtitle1",
                                   "Description1"));

            items.Add(new SampleDataSource("/Common/Images/image2.png",
                                   "Title2",
                                   "Subtitle2",
                                   "Description2"));

            items.Add(new SampleDataSource("/Common/Images/image3.png",
                                   "Title3",
                                   "Subtitle3",
                                   "Description3"));

            items.Add(new SampleDataSource("/Common/Images/image4.png",
                                   "Title4",
                                   "Subtitle4",
                                   "Description4"));

            items.Add(new SampleDataSource("/Common/Images/image5.png",
                                   "Title5",
                                   "Subtitle5",
                                   "Description5"));

            // ListViewコントロールにデータをセットする
            listViewName.ItemsSource = items;

        }
    }
}

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

namespace Common_Parent
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // 親要素の表示
            textBlockName1.Text = button1Name.Parent.ToString();

            // VisualTreeHelperクラスで取得
            DependencyObject parent = VisualTreeHelper.GetParent(button1Name);
            textBlockName1.Text += "\n<VisualTreeHelperクラスで取得>\n" + parent.ToString(); 
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            // 子要素の数を取得
            int children = VisualTreeHelper.GetChildrenCount(stackPanelName);
            String msg = children.ToString() + "個\n";

            // 子要素の一覧表示
            var childrenControl = stackPanelName.Children;
            foreach (Object item in childrenControl)
            {
                msg += item.ToString() + "\n";
            }
            textBlockName2.Text = msg;
        }

    }
}

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

namespace Common_Tap
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

        private void rect_Tapped(object sender, TappedRoutedEventArgs e)
        {
            textBlockName.Text = "タップされました";
        }

        private void rect_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            textBlockName.Text = "右タップされました";
        }

        private void rect_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            textBlockName.Text = "ダブルタップされました";
        }

        private void rect_Holding(object sender, HoldingRoutedEventArgs e)
        {
            textBlockName.Text = "ホールドされました";
        }

    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページのアイテム テンプレートについては、http://go.microsoft.com/fwlink/?LinkId=234238 を参照してください

namespace Common_Key
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Boolean ctrlFlg = false;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void textBoxName_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            textBlockName1.Text = "keyUpしました\n";
        }

        private void textBoxName_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            textBlockName1.Text = "keyDownしました";
            textBlockName2.Text= e.Key.ToString() 
                                + "(" + e.KeyStatus.ScanCode +")"
                                + "が入力されました";
        }

        private void stackPanel_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == VirtualKey.Control) ctrlFlg = true;
            else if (ctrlFlg)
            {
                textBlockName3.Text = "ショートカットキーが押されました [Ctrl]+" + e.Key.ToString();
            }
        }
    }
}
﻿using System;
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

namespace Common_Pointer
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

        private void rect_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            textBlockName.Text = "ポインターが入りました";
        }

        private void rect_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            textBlockName.Text = "ポインターが出ました";
        }

        private void rect_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            textBlockName.Text = "ポインターが動きました";
        }

        private void rect_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            textBlockName.Text = "ポインターが押されました";
        }

        private void rect_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            textBlockName.Text = "ポインターが離されました";
        }
    }
}

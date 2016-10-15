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

namespace MediaElement02
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

        private void play_Click(object sender, RoutedEventArgs e)
        {
            // 再生
            mediaElement2.Play();
        }

        private void pause_Click(object sender, RoutedEventArgs e)
        {
            // 中断
            mediaElement2.Pause();
        }

        private void stop_Click(object sender, RoutedEventArgs e)
        {
            // 停止
            mediaElement2.Stop();
        }

        private void mute_Click(object sender, RoutedEventArgs e)
        {
            // 消音
            mediaElement2.IsMuted = true;
        }

        private void slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            // 音量
            mediaElement2.Volume = e.NewValue;
        }
    }
}

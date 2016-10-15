using System;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace Common.DataModel
{
    public class SampleDataSource
    {
        private static Uri _baseUri = new Uri("ms-appx:///");
        private ImageSource _image;

        public string Title { get; private set; }
        public string Subtitle { get; private set; }
        public string Description { get; private set; }
        public string ImagePath { get; private set; }

        public SampleDataSource(String imagePath, String title, String subtitle, String description)
        {
            this.ImagePath = imagePath;
            this.Title = title;
            this.Subtitle = subtitle;
            this.Description = description;
        }

        public ImageSource Image
        {
            // 画像のファイルパスからビットマップイメージを取得する
            get
            {
                this._image = new BitmapImage(new Uri(_baseUri, this.ImagePath));
                return this._image;
            }

            set { this.Image = value; }
        }

    }

}

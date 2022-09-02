using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace TicTakToe
{
    public enum ImageType
    {
        Empty,
        O,
        X
    }
    internal class Images
    {
        public readonly static ImageSource Empty = LoadImage("Empty.png");
        public readonly static ImageSource O = LoadImage("O.png");
        public readonly static ImageSource X = LoadImage("X.png");
        private static ImageSource LoadImage(string fileName)
        {
            return new BitmapImage(new Uri($"assets/{fileName}", UriKind.Relative));
        }
    }
}

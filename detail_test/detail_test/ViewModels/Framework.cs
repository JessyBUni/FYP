using System;
using Xamarin.Forms;

namespace detail_test.ViewModels
{
    static class Framework
    {
        public static readonly Thickness PagePadding;

        public struct TitleFont
        {
            public static readonly String size ="22";
            public static readonly Color colour= Xamarin.Forms.Color.FromRgb(148, 59, 19);
            public static readonly String style = "Bold";
        };
        public static readonly TitleFont Title;

        public struct HeaderFont
        {
            public static readonly String size = "Medium";
            public static readonly Color colour = Xamarin.Forms.Color.FromRgb(224, 76, 6);
        };
        public static readonly HeaderFont Header;

        public struct TextFont
        {
            public static readonly String size = "Small";
            public static readonly Color colour = Xamarin.Forms.Color.FromRgb(51, 10, 130);
        };
        public static readonly TextFont Text;

        public static readonly Color BackgroundColour = Xamarin.Forms.Color.FromRgb(224, 66, 6);
        public static readonly string BackgroundImage = "background.png";

        public static readonly Color PrimaryColour = Xamarin.Forms.Color.FromRgb(224, 76, 6);
        public static readonly Color SecondaryColour = Xamarin.Forms.Color.FromRgb(148, 59, 19);
        public static readonly Color ContrastColour = Xamarin.Forms.Color.FromRgb(90, 230, 29);
        public static readonly Color Complementary1Colour = Xamarin.Forms.Color.FromRgb(51, 10, 130);
        public static readonly Color Complementary2Colour = Xamarin.Forms.Color.FromRgb(51, 10, 130);

        public static readonly Color ForegroundColour = Color.Brown;

        static Framework()
        {

        }
    }
}

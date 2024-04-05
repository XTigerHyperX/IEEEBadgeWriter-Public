using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace IEEEBadgeWriter
{
    internal class Designer
    {
        public static int Names;

        public static async Task LoadNames(string path)
        {
            int i = 0;
            var lines = File.ReadLines(path);

            foreach (var line in lines)
            {
                Names++;
            }
        }

        public static async Task draw(string img , string text , string output , int x , int y , float size , string fontx)
        {
            SKBitmap bm = SKBitmap.Decode($@"{img}");
            using (SKCanvas canvas = new SKCanvas(bm))
            {
                SKTypeface font = SKTypeface.FromFile(fontx);


                SKPaint paint = new SKPaint
                {
                    Color = SKColors.Black,
                    TextSize = size,
                    Typeface = font,
                    TextAlign = SKTextAlign.Center
                };


                SKRect bounds = new SKRect();
                paint.MeasureText(text, ref bounds);

                var textWidth = paint.MeasureText(text);
                canvas.DrawText(text, bm.Width / 2, y, paint);
            }

            string filename = @$"{output}{text}.jpg";
            using (var image = SKImage.FromBitmap(bm))
            using (var data = image.Encode(SKEncodedImageFormat.Jpeg, 100))
            {
                using (var stream = File.OpenWrite(filename))
                {
                    data.SaveTo(stream);
                }
            }
        }
    }
}

using System.Drawing;
using System.Drawing.Imaging;

Bitmap bitMap = new Bitmap(1024, 1024);

using (Graphics graphics = Graphics.FromImage(bitMap))
{
    using (Font myFont = new Font("Times new Roman", 34))
    {
        graphics.Clear(Color.White);
        graphics.DrawImage(Image.FromFile("newsletter.png"),new Point(0,0));
        graphics.DrawString($"Hello World!\nWelcome to my\nKingdom", myFont, Brushes.Black, new PointF(512f, 512f));
    }
}
Console.WriteLine("1. Save as Jpeg - 2. Save as PNG\n");
var answer = Console.ReadKey();

switch (answer.Key)
{
    case ConsoleKey.D1:
        bitMap.Save("news.jpeg", ImageFormat.Jpeg);
        break;

    case ConsoleKey.D2:
        bitMap.Save("news.png", ImageFormat.Png);
        break;

    default:
        bitMap.Save("news.png", ImageFormat.Png);
        break;
}
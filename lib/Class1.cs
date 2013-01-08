using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
namespace lib
{
    public class ScreenShot
    {
       

        PixelFormat pixelFormat = PixelFormat.Format32bppArgb;
        public void Capture()
        {
          Bitmap  bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);

        }
    }
}

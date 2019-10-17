using Svg;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DehysRPD
{
    class SvgLoader
    {
        private static Size maximumSize;

        public static Bitmap GetBitmapFromSVG(string filePath, Size imageSize)
        {
            maximumSize = imageSize;







            SvgDocument document = GetSvgDocument(filePath);

            Bitmap bmp = document.Draw();
            return bmp;
        }

        public static SvgDocument GetSvgDocument(string filePath)
        {
            SvgDocument document = SvgDocument.Open(filePath);
            return AdjustSize(document);
        }

        private static SvgDocument AdjustSize(SvgDocument document)
        {
            if (document.Height > maximumSize.Height)
            {
                document.Width = (int)((document.Width / (double)document.Height) * maximumSize.Height);
                document.Height = maximumSize.Height;
            }
            return document;
        }
    }
}

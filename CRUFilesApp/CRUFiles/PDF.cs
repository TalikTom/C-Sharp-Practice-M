using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUFiles
{

    public class TextToPdfConverter
    {
        public void ConvertTextToPdf(string fileName, string pdfOutput)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

          
            string text = File.ReadAllText(fileName);


            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Courier New", 12, XFontStyle.Regular);


            using (MemoryStream stream = new MemoryStream())
            {

                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(text);
                }

                gfx.DrawString(text, font, XBrushes.Black, new XRect(50, 50, page.Width, page.Height), XStringFormats.TopLeft);
            }


            document.Save(pdfOutput);


            document.Close();
        }

    }

}

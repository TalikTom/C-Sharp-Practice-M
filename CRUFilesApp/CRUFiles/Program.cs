﻿//create txt file
//read txt file
//update txt file
//copy one file to another
/* --------------------------*/
//PDFsharp


using CRUFiles;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;
using System.Text;
using System.IO;

namespace CRUFilesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ------------------------------------------------------------------ */
            /* StreamWriter/StreamReader */
            /* ------------------------------------------------------------------ */

            string data;
            StreamReader reader = null;
            StreamWriter writer = null;
            string fileName = $"C:\\Users\\student\\Documents\\Luka\\test2.txt";
            try
            {
                reader = new StreamReader(fileName);
                
                data = reader.ReadLine();

                //keep reading data until there is no more
                while (data != null)
                {
                    Console.WriteLine(data);
                    data = reader.ReadLine();
                }
                reader.Close();
                writer = new StreamWriter(fileName);
                writer.WriteLine(@"
          _____                   _______                   _____                   _______         
         /\    \                 /::\    \                 /\    \                 /::\    \        
        /::\____\               /::::\    \               /::\____\               /::::\    \       
       /::::|   |              /::::::\    \             /::::|   |              /::::::\    \      
      /:::::|   |             /::::::::\    \           /:::::|   |             /::::::::\    \     
     /::::::|   |            /:::/~~\:::\    \         /::::::|   |            /:::/~~\:::\    \    
    /:::/|::|   |           /:::/    \:::\    \       /:::/|::|   |           /:::/    \:::\    \   
   /:::/ |::|   |          /:::/    / \:::\    \     /:::/ |::|   |          /:::/    / \:::\    \  
  /:::/  |::|___|______   /:::/____/   \:::\____\   /:::/  |::|   | _____   /:::/____/   \:::\____\ 
 /:::/   |::::::::\    \ |:::|    |     |:::|    | /:::/   |::|   |/\    \ |:::|    |     |:::|    |
/:::/    |:::::::::\____\|:::|____|     |:::|    |/:: /    |::|   /::\____\|:::|____|     |:::|    |
\::/    / ~~~~~/:::/    / \:::\    \   /:::/    / \::/    /|::|  /:::/    / \:::\    \   /:::/    / 
 \/____/      /:::/    /   \:::\    \ /:::/    /   \/____/ |::| /:::/    /   \:::\    \ /:::/    /  
             /:::/    /     \:::\    /:::/    /            |::|/:::/    /     \:::\    /:::/    /   
            /:::/    /       \:::\__/:::/    /             |::::::/    /       \:::\__/:::/    /    
           /:::/    /         \::::::::/    /              |:::::/    /         \::::::::/    /     
          /:::/    /           \::::::/    /               |::::/    /           \::::::/    /      
         /:::/    /             \::::/    /                /:::/    /             \::::/    /       
        /:::/    /               \::/____/                /:::/    /               \::/____/        
        \::/    /                 ~~                      \::/    /                 ~~              
         \/____/                                           \/____/                                  
                                                                                                  
");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);

            }
            finally
            {
               
                writer.Close();
            }



            /* ------------------------------------------------------------------ */
            /* TxtToPDFConverter */
            /* ------------------------------------------------------------------ */

            //string fileName = $"C:\\Users\\student\\Documents\\Luka\\test2.txt";

            //string pdfOutput = $"C:\\Users\\student\\Documents\\Luka\\pdfOutput.pdf";

            //TextToPdfConverter converter = new TextToPdfConverter();
            //converter.ConvertTextToPdf(fileName, pdfOutput);


            //simpleCreatePDF();


            //createTxtFSSW();


            //FileStreamWrite();


            //StreamWriterWrite();


            //FileStreamRead();


            //StreamReaderText();


            //FileStreamCopy();
        }

        /* ------------------------------------------------------------------ */
        /* Hardcoded create PDF */
        /* ------------------------------------------------------------------ */

        static void simpleCreatePDF()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            Console.WriteLine("Generating PDF...");

            // Create a new PDF document
            var document = new PdfDocument();
            document.Info.Title = "Created with PDFsharp";

            // Create an empty page
            var page = document.AddPage();

            // Get an XGraphics object for drawing
            var gfx = XGraphics.FromPdfPage(page);

            // Create a font
            var font = new XFont("Arial", 20, XFontStyle.BoldItalic);

            // Draw the text
            gfx.DrawString("Hello, World!", font, XBrushes.Black,
            new XRect(0, 0, page.Width, page.Height),
            XStringFormats.Center);

            // Save the document...
            string fileName = $"C:\\Users\\student\\Documents\\Luka\\test2.pdf";
            document.Save(fileName);
            Console.WriteLine("PDF Generated!");
        }


        /* ------------------------------------------------------------------ */
        /* Create .txt file using FileStream and StreamWriter */
        /* ------------------------------------------------------------------ */

        static void createTxtFSSW()
        {
            // Create a string array with the lines of text
            string[] lines = { "First line", "Second line", "Third line" };

            // Set a variable to the Documents path.
            string docPath = $"C:\\Users\\student\\Documents\\Luka";


            if (!Directory.Exists(docPath))
            {
                Directory.CreateDirectory(docPath);
            }

            string fileLocation = Path.Combine(docPath, "WriteLines3.txt");


            if (!File.Exists(fileLocation))
            {
                FileStream stream = File.Create(fileLocation);

                stream.Flush();
                stream.Close();

            }



            using (FileStream stream = new FileStream(fileLocation, FileMode.Open))
            {
                StreamWriter writer = new StreamWriter(stream);
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                }
                writer.Close();

            }
        }


        /* ------------------------------------------------------------------ */
        /* Filestream copy from one file to another */
        /* ------------------------------------------------------------------ */

        static void FileStreamCopy()
        {
            string fileName1 = $"C:\\Users\\student\\Documents\\Luka\\test.txt"; ;
            using var fs = new FileStream(fileName1, FileMode.Open);

            string fileName2 = $"C:\\Users\\student\\Documents\\Luka\\test2.txt";
            using var fs2 = new FileStream(fileName2, FileMode.OpenOrCreate);

            fs.CopyTo(fs2);

            Console.WriteLine("File copied");
        }


        /* ------------------------------------------------------------------ */
        /* StreamReader read text */
        /* ------------------------------------------------------------------ */


        static void StreamReaderText()
        {
            string fileName2 = $"C:\\Users\\student\\Documents\\Luka\\test2.txt";

            using FileStream fs2 = File.OpenRead(fileName2);
            using var sr = new StreamReader(fs2);

            string line;

            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }


        /* ------------------------------------------------------------------ */
        /* Filestream read text */
        /* ------------------------------------------------------------------ */

        static void FileStreamRead()
        {
            string fileName1 = $"C:\\Users\\student\\Documents\\Luka\\test.txt";

            using FileStream fs1 = File.OpenRead(fileName1);

            // The buf is a byte array into which we read the data from the file.
            byte[] buf = new byte[1024];
            int c;

            while ((c = fs1.Read(buf, 0, buf.Length)) > 0)
            {
                Console.WriteLine(Encoding.UTF8.GetString(buf, 0, c));
            }
        }


        /* ------------------------------------------------------------------ */
        /* StreamWriter write text */
        /* ------------------------------------------------------------------ */


        static void StreamWriterWrite()
        {
            string fileName = $"C:\\Users\\student\\Documents\\Luka\\test2.txt";

            using FileStream fs = File.Create(fileName);
            using StreamWriter sr = new StreamWriter(fs);

            sr.WriteLine("testing2000");

            Console.WriteLine("done");
        }


        /* ------------------------------------------------------------------ */
        /* FileStream write text */
        /* ------------------------------------------------------------------ */


        static void FileStreamWrite()
        {
            string fileName = $"C:\\Users\\student\\Documents\\Luka\\test.txt";

            using FileStream fs = File.OpenWrite(fileName);

            var data = "testooooing";
            byte[] bytes = Encoding.UTF8.GetBytes(data);

            fs.Write(bytes, 0, bytes.Length);

        }

    }
}

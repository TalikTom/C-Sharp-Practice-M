//create txt file
//read txt file
//update txt file
//copy one file to another


using System.Text;

namespace CRUFilesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Create a string array with the lines of text
            //string[] lines = { "First line", "Second line", "Third line" };

            //// Set a variable to the Documents path.
            //string docPath = $"C:\\Users\\student\\Documents\\Luka";


            //if (!Directory.Exists(docPath))
            //    {
            //    Directory.CreateDirectory(docPath);
            //}


            //string fileLocation = Path.Combine(docPath, "WriteLines.txt");


            //using (FileStream stream = new FileStream(fileLocation,FileMode.Open))
            //{
            //    StreamWriter writer = new StreamWriter(stream);
            //    foreach (string line in lines)
            //    writer.WriteLine(line);
            //    writer.Close();
            //    writer.Flush();
            //}   


            // FileStream write text

            //string fileName = $"C:\\Users\\student\\Documents\\Luka\\test.txt";

            //using FileStream fs = File.OpenWrite(fileName);

            //var data = "testing";
            //byte[] bytes = Encoding.UTF8.GetBytes(data);

            //fs.Write(bytes, 0, bytes.Length);


            // C# FileStream write text with StreamWriter

            string fileName = $"C:\\Users\\student\\Documents\\Luka\\test2.txt";

            using FileStream fs = File.Create(fileName);
            using StreamWriter sr = new StreamWriter(fs);

            sr.WriteLine("testing2");

            Console.WriteLine("done");

        }
    }
}

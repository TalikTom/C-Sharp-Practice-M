//create txt file
//read txt file
//update txt file
//copy one file to another


namespace CRUFilesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a string array with the lines of text
            string[] lines = { "First line", "Second line", "Third line" };

            // Set a variable to the Documents path.
            string docPath = $"C:\\Users\\student\\Documents\\Luka";


            if (!Directory.Exists(docPath))
                {
                Directory.CreateDirectory(docPath);
            }



            //Console.WriteLine(docPath);

            //// Write the string array to a new file named "WriteLines.txt".
            //using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt")))
            //{
            //    foreach (string line in lines)
            //        outputFile.WriteLine(line);
            //}
        }
    }
}

namespace CollectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string path = @"C:\\Users\\Admin\\Documents\\Projects";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            WriteToFile(Path.Combine(path, "Myfile2.txt"));
            Console.WriteLine("completed");
            void WriteToFile(string path)
            {
                FileStream stream = new FileStream(path, FileMode.Create);

                StreamWriter writer = new StreamWriter(stream);


                writer.WriteLine("completed");
                writer.Close();   // flushes and closes
                stream.Close();
            }


        }
    }
}

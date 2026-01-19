
using System;
using System.IO;
using System.Text.Json;

namespace FileOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string baseDir = @"C:\Users\Admin\Downloads\FileOps";
            if (!Directory.Exists(baseDir))
            {
                Directory.CreateDirectory(baseDir);
            }

            string textFilePath = Path.Combine(baseDir, "kavi.txt");
            string jsonFilePath = Path.Combine(baseDir, "main.txt");

            var program = new Program();

            // 1) Text write & read
            program.WriteToFile(textFilePath);
            program.ReadFromFile(textFilePath);

            // 2) JSON write
            program.WriteJSONObjectToFile(jsonFilePath);

            // 3) JSON read (deserialize)
            program.ReadJSONfromFile(jsonFilePath);

            Console.WriteLine("\nAll operations completed. Press any key to exit...");
            Console.ReadKey();
        }

        void WriteToFile(string path)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path)!);

                using (var stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
                using (var writer = new StreamWriter(stream))
                {
                    writer.WriteLine("Hey there");
                }

                Console.WriteLine($"[WriteToFile] Wrote text to: {path}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[WriteToFile] Error: {ex.Message}");
            }
        }

        void ReadFromFile(string path)
        {
            try
            {
                if (!File.Exists(path))
                {
                    Console.WriteLine($"[ReadFromFile] File not found: {path}");
                    return;
                }

                using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
                using (var reader = new StreamReader(stream))
                {
                    string content = reader.ReadToEnd();
                    Console.WriteLine("[ReadFromFile] File content:");
                    Console.WriteLine(content);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ReadFromFile] Error: {ex.Message}");
            }
        }

        void WriteAndReadFromFile(string path)
        {
            try
            {
                using (var stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
                using (var writer = new StreamWriter(stream))
                using (var reader = new StreamReader(stream))
                {
                    // Write something
                    writer.WriteLine("This is a combined write + read operation.");
                    writer.Flush();

                    // Move the pointer to the beginning to read
                    stream.Seek(0, SeekOrigin.Begin);

                    string content = reader.ReadToEnd();
                    Console.WriteLine("[WriteAndReadFromFile] Content just written:");
                    Console.WriteLine(content);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[WriteAndReadFromFile] Error: {ex.Message}");
            }
        }

        void WriteJSONObjectToFile(string path)
        {
            try
            {
                var employee = new Employee
                {
                    Id = 101,
                    EmpName = "kaviee",
                    Address = "chennai"
                };

                var options = new JsonSerializerOptions
                {
                    WriteIndented = true // pretty print JSON
                };

                string jsonData = JsonSerializer.Serialize(employee, options);

                Directory.CreateDirectory(Path.GetDirectoryName(path)!);

                using (var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
                using (var writer = new StreamWriter(fileStream))
                {
                    writer.Write(jsonData);
                }

                Console.WriteLine($"[WriteJSONObjectToFile] JSON written to: {path}");
                Console.WriteLine(jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[WriteJSONObjectToFile] Error: {ex.Message}");
            }
        }

        void ReadJSONfromFile(string path)
        {
            try
            {
                if (!File.Exists(path))
                {
                    Console.WriteLine($"[ReadJSONfromFile] File not found: {path}");
                    return;
                }

                using (var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
                using (var reader = new StreamReader(fileStream))
                {
                    string jsonData = reader.ReadToEnd();
                    if (string.IsNullOrWhiteSpace(jsonData))
                    {
                        Console.WriteLine("[ReadJSONfromFile] File is empty.");
                        return;
                    }

                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };

                    Employee? employee = JsonSerializer.Deserialize<Employee>(jsonData, options);

                    if (employee is null)
                    {
                        Console.WriteLine("[ReadJSONfromFile] Failed to deserialize JSON into Employee.");
                        return;
                    }

                    Console.WriteLine("[ReadJSONfromFile] Deserialized Employee object:");
                    Console.WriteLine($"  Id      : {employee.Id}");
                    Console.WriteLine($"  EmpName : {employee.EmpName}");
                    Console.WriteLine($"  Address : {employee.Address}");
                }
            }
            catch (JsonException jex)
            {
                Console.WriteLine($"[ReadJSONfromFile] JSON parse error: {jex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ReadJSONfromFile] Error: {ex.Message}");
            }
        }
    }

    
}

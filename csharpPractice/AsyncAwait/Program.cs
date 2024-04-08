using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace AsyncExamples
{
    class Program
    {
        static void Main()
        {
            Task task = new Task(CallMethod);
            task.Start();
            task.Wait();
            Console.ReadLine();
        }

        static async void CallMethod()
        {
            var folderPath = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;

            var filePath1 = Path.Combine(folderPath, "file1.txt");
            var filePath2 = Path.Combine(folderPath, "file2.txt");
            //Task<int> task = ReadFile(filePath);

            Task<int>[] tasks = new Task<int>[2];


            tasks[0] = ReadFileAsync(filePath1);
            tasks[1] = ReadFileAsync(filePath2);

            Console.WriteLine(" Other Work 1");
            Console.WriteLine(" Other Work 2");
            Console.WriteLine(" Other Work 3");

            int[] lengths = await Task.WhenAll(tasks);

            //var length = await task;
            Console.WriteLine(" Total length: " + lengths[0]);
            Console.WriteLine(" Total length: " + lengths[1]);

            Console.WriteLine(" After work 1");
            Console.WriteLine(" After work 2");
        }

        static async Task<int> ReadFileAsync(string file)
        {
            var length = 0;

            Console.WriteLine(" File reading is stating");
            using (var reader = new StreamReader(file))
            {
                // Reads all characters from the current position to the end of the stream asynchronously    
                // and returns them as one string.    
                var s = await reader.ReadToEndAsync();

                length = s.Length;
            }
            Console.WriteLine(" File reading is completed");
            return length;
        }
    }
}
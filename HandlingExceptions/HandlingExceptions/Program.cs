using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\Lesson22\Examples.txt");
                Console.WriteLine(content);
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Make sure the name of the file is named correctly: Example.txt");
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(@"Make sure the directory C:\Lesson22 exists");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was a problem");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // code to finalize setting objects to null, closing database connections
                Console.WriteLine("Closing application now...");
            }
            Console.ReadLine();
        }
    }
}

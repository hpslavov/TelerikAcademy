using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _03.ReadFileContents
{
    class ReadFile
    {
        //Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
        //Find in MSDN how to use System.IO.File.ReadAllText(…).
        //Be sure to catch all possible exceptions and print user-friendly error messages.
        public static void Read(string path)
        {
            try
            {
                string file = File.ReadAllText(path);
                Console.WriteLine(file);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);   
            }
            catch(PathTooLongException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(NotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        
        }
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Hristo\\Desktop\\Method.txt";
            Read(path);
            

        }
    }
}

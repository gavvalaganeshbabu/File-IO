using System;

namespace FIle_IO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reading File using FILE _ IO ");
            Console.WriteLine("Welcome to File IO Operations");
            string path = @"C:\Users\Admin\Myfile.txt";
            Console.WriteLine("Enter 1: To check whether the file exists or not");
            Console.WriteLine("Enter 2: To Read all lines in file by using ReadAllLines method");
            Console.WriteLine("Enter 3: To Read all lines in file by using ReadAllText method");
            Console.WriteLine("Enter 4: To copy a file from cource to destination");
            Console.WriteLine("Enter 5: To delete a file (FileText1)");
            Console.WriteLine("Enter 6: To read the file from StreamReader class");
            Console.WriteLine("Enter 7: To write the file using StreamWriter class");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    File_IO.FileExists(path);
                    break;
                case 2:
                    File_IO.ReadAllLinesInFile();
                    break;
                case 3:
                    File_IO.ReadAllTextInFile();
                    break;
                case 4:
                    File_IO.CopyFile();
                    break;
                case 5:
                    File_IO.DeleteFile();
                    break;
                case 6:
                    File_IO.ReadFromStreamReader();
                    break;
                case 7:
                    File_IO.WriteUsingStreamWriter();
                    break;

                default:
                    Console.WriteLine("Enter a valid option!!!");
                    break;
            }
        }
    }

}

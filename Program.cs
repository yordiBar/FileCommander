using System;

namespace FileCommander
{
    class Program
    {
        static void Main(string[] args)
        {
            //get filename
            //get srcpath
            //set outpath
            //set new folder name
            Console.WriteLine("Please enter new folder name...");
            string destFolder = Console.ReadLine();
            string fileName = "test.txt";
            string srcPath = @"C:\Users\IMB_Polareyez\Desktop\TestFolder";
            string destPath = @"C:\Users\IMB_Polareyez\Desktop\TestFolder";
            string fullDestPath = destPath + destFolder;
            
            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(srcPath, fileName);
            string destFile = System.IO.Path.Combine(fullDestPath, fileName);

            // To copy a folder's contents to a new location:
            // Create a new target folder.
            // If the directory already exists, this method does not create a new directory.
            System.IO.Directory.CreateDirectory(fullDestPath);

            System.IO.File.Copy(sourceFile, destFile, true);

            if (System.IO.Directory.Exists(srcPath))
            {
                string[] files = System.IO.Directory.GetFiles(srcPath);

                foreach (var s in files)
                {
                    fileName = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(destPath, fileName);
                    System.IO.File.Copy(s, destFile, true);
                }
            }
            else
            {
                Console.WriteLine("Source path does not exist!");
            }

            // Keep console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

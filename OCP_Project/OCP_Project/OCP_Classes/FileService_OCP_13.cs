using System;
namespace SolidProject1_211229013.OCP_Classes
{
	public class FileService_OCP_13
	{
        public static bool FileControl(string FileName)
        {
            bool control = File.Exists(FileName);
            if (control) Console.WriteLine("File Found.");
            else Console.WriteLine("File not found.\nTransaction Terminated.");
            return control;
        }


        public static List<int> ReadingFile(string FileName)
        {
            StreamReader sr = new StreamReader(FileName);
            List<int> ProductsIDList = new List<int>();
            for (int i = 0; i <= 50; i++) ProductsIDList.Add(int.Parse(sr.ReadLine()));
            sr.Close();
            Console.WriteLine("File read and transferred to list.");
            return ProductsIDList;
        }
    }
}


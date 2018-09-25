using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileIO

{
   public class Program
    {
      public static void Main(string[] args)
        {
            string userInput;
            Console.WriteLine("Enter a number.");
            userInput = Console.ReadLine();
            File.WriteAllText("D:\\Documents\\FileIO\\log.txt", userInput);
            
            string fileRead = File.ReadAllText("D:\\Documents\\FileIO\\log.txt");
            Console.WriteLine(fileRead);
            Console.Read();
        }

    }
}

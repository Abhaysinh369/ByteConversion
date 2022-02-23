using System;

namespace Conversion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool shouldRepeat = true;
            string schoice;
            Console.WriteLine("Hello Users How are You?!");
            Console.WriteLine("Lets Start...");

           
           
            
                Console.WriteLine("This program converts Storage Sizes between Bytes and Megabytes,Gigabytes and Terabytes .\n");
                Console.WriteLine("Which do you want to convert:");
            Console.WriteLine("Enter an integer Number:");
            string sinputu = Console.ReadLine();
            int inputu = Convert.ToInt32(sinputu);


            while (shouldRepeat)
            {
                
                Console.WriteLine("1. Megabytes to Bytes");
                Console.WriteLine("2. Gigabytes to Megabytes\n");
                Console.WriteLine("3. Terabytes to Gigabytes\n");
                Console.WriteLine("4. Exit\n");
                Console.Write("Enter your Choitce:");
                schoice = Console.ReadLine();
                var isNumeric = int.TryParse(schoice, out _);
                if(isNumeric == true)
                {
                    switch (schoice)
                    {
                        case "1":
                            ByteConversion.ConvertMegabytestoBytes(inputu);
                            isNumeric = false;
                            break;
                        case "2":
                            ByteConversion.ConvertGigabytestoMegaBytes(inputu);
                            isNumeric = false;
                            break;
                        case "3":
                            ByteConversion.ConvertTerabytestoGigaBytes(inputu);
                            isNumeric = false;
                            break;
                        case "4":
                            shouldRepeat = false;
                            isNumeric = false;
                            break;
                    }
                }
            }
        }
    }
}

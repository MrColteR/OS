using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS
{
    class Program
    {
        static void Main(string[] args)
        {
            int biasCount = 0;
            bool errorBias = true;
            Console.Write("Введите виртуальный адрес - ");
            string fullNumber = Console.ReadLine();
            
            while (errorBias)
            {
                Console.Write("Введите смещение - ");
                string userBias = Console.ReadLine();
                bool biasRight = int.TryParse(userBias, out int biasLocal);
                if (biasRight)
                {
                    if (biasLocal < fullNumber.Length)
                    {
                        biasCount = biasLocal;
                        errorBias = false;
                    }
                    else
                    {
                        Console.WriteLine("Смещение больше виртуальный адрес");
                    }
                    
                }
                else Console.WriteLine("Вы ввели не число");
            }
            string physicalAddress = fullNumber.Substring(0, fullNumber.Length - biasCount);
            string bias = fullNumber.Substring(fullNumber.Length - biasCount);
            //Console.WriteLine(physicalAddress);
            //Console.WriteLine(bias);
            
            string virtualAddress = new string(physicalAddress.ToCharArray().Reverse().ToArray());
            //Console.WriteLine(virtualAddress);
            Console.Clear();
            Console.WriteLine($"Виртуальный адрес {physicalAddress} смещение {bias}");
            Console.WriteLine($"Физический адрес  {virtualAddress} смещение {bias}");
            Console.ReadKey();
        }
    }
}

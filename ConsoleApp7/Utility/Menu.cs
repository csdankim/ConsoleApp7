using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7.Utility
{
    class Menu
    {
        public int Print()
        {
            string[] names = Enum.GetNames(typeof(MenuOptions));
            int[] values = (int[]) Enum.GetValues(typeof(MenuOptions));

            int length = names.Length;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Press {0} for {1}", values[i], names[i]);
            }
            Console.Write("Enter your choice => ");
            
            int choice = Convert.ToInt32(Console.ReadLine());

            return choice;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[1];
            string[] families = new string[1];
            string[] phones = new string[1];
            while (true)
            {
                Console.Clear();
                for (int i = 0; i < phones.Length; i++)
                {
                    Console.WriteLine($"{names[i]}\t{families[i]}\t{phones[i]}");
                }
                Console.WriteLine("-----------------------");
                Console.Write("Name:");
                var newName = Console.ReadLine();
                AddToArray(ref names, newName);

                Console.Write("Family:");
                var newFamily = Console.ReadLine();
                AddToArray(ref families, newFamily);

                Console.Write("Phone:");
                var newPhone = Console.ReadLine();
                AddToArray(ref phones, newPhone);
            }

        }

        static void AddToArray(ref string[] array, string newValue)
        {
            if (array[0] != null)//اگر خانه اول آرایه پر بود
            {
                string[] newArray = new string[array.Length + 1];

                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[i];
                }
                newArray[newArray.Length - 1] = newValue;
                array = newArray;
            }
            else//اگر خانه ااول آرایه خالی بود

            {
                array[0] = newValue;
            }
            
        }

        static void RemoveFromArray(ref string[] array, string valueToRemove)
        {
            var newArray = new string[array.Length - 1];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[i] != valueToRemove)
                {
                    newArray[j++] = array[i];
                }
            }
            array = newArray;
        }
    }
}

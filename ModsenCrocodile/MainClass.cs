using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ModsenCrocodile
{
    internal class MainClass
    {
        static void Main()
        {
            int age = 0;
            double weight = 0.0, length = 0.0;
            string name = "", gender = "";

            int choice, menu_choice = 0;

            CrocodileService crocodileService = new CrocodileService();

            do
            {
                Write(ref name, ref weight, ref length, ref age, ref gender);

                crocodileService.AddCrocodile(new Crocodile(name, weight, length, age, gender));

                Console.WriteLine("\nЖелаете добавить еще одного крокодила?\n" + "[Нет] - 0, [Да] - 1");

                choice = int.Parse(Console.ReadLine());

                Console.Clear();

            } while (choice == 1);

            while (menu_choice != 5)
            {
                Console.Clear();

                Console.WriteLine("1. Показать список всех крокодилов\n" +
                                  "2. Показать крокодилов, длина которых превышает n метров\n" +
                                  "3. Показать информацию о самом старом крокодиле\n" +
                                  "4. Показать информацию о самом тяжелом крокодиле\n" +
                                  "5. Выход");

                Console.Write("\nВыберите пункт меню: ");
                menu_choice = int.Parse(Console.ReadLine());

                switch (menu_choice)
                {
                    case 1:
                        {
                            Console.WriteLine("\nСписок всех крокодилов: ");
                            crocodileService.DisplayAllCrocodiles();

                            Console.ReadKey();

                            break;
                        }

                    case 2:
                        {
                            double n;

                            Console.Write("\nВывести крокодилов, длина которых превышает: ");
                            n = double.Parse(Console.ReadLine());

                            Console.WriteLine($"\nКрокодилы превышающие {n} м: ");
                            crocodileService.DisplayCrocodilesLongerThan(n);

                            Console.ReadKey();

                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("\nСамый старый крокодил: ");
                            crocodileService.DisplayOldestCrocodile();

                            Console.ReadKey();

                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("\nСамый тяжелый крокодил: ");
                            crocodileService.DisplayHeaviestCrocodile();

                            Console.ReadKey();

                            break;
                        }

                    case 5:
                        {
                            Environment.Exit(0);

                            break;
                        }

                    default:
                        {
                            Console.WriteLine("\nВыберите пукт меню!");

                            Console.ReadKey();

                            break;
                        }
                }

            }
            Console.ReadKey();
        }
        static void Write(ref string name, ref double weight, ref double length, ref int age, ref string gender)
        {
            Console.Write("Введите имя крокодила: ");
            name = Console.ReadLine();
            bool isInt = false;
            foreach (char c in name)
            {
                if (char.IsDigit(c))
                {
                    isInt = true;
                    break;
                }
            }
            if (isInt) { Console.WriteLine("Введите имя крокодила!"); Console.ReadKey(); Environment.Exit(0); }

            Console.Write("Введите вес крокодила: ");
            if (double.TryParse(Console.ReadLine(), out weight)) {}
                else { Console.WriteLine("Введите вес крокодила!"); Console.ReadKey(); Environment.Exit(0); }

            Console.Write("Введите длину крокодила: ");
            if (double.TryParse(Console.ReadLine(), out length)) {}
                else { Console.WriteLine("Введите длину крокодила!"); Console.ReadKey(); Environment.Exit(0); }

            Console.Write("Введите возраст крокодила: ");
            if (int.TryParse(Console.ReadLine(), out age)) {}
                else { Console.WriteLine("Введите возраст крокодила!"); Console.ReadKey(); Environment.Exit(0); }

            Console.Write("Введите пол крокодила: ");
            gender = Console.ReadLine();
            bool iisInt = false;
            foreach (char c in gender)
            {
                if (char.IsDigit(c))
                {
                    iisInt = true;
                    break;
                }
            }
            if (iisInt) { Console.WriteLine("Введите пол крокодила!"); Console.ReadKey(); Environment.Exit(0); }
        }        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._6._1_HW_03_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Необходимо создать метод, который заполняет данные с клавиатуры по пользователю(возвращает кортеж):
            //Имя;
            //Фамилия;
            //Возраст;
            //Наличие питомца;
            //Если питомец есть, то запросить количество питомцев;
            //Если питомец есть, вызвать метод, принимающий на вход количество питомцев и возвращающий массив их кличек(заполнение с клавиатуры);
            //Запросить количество любимых цветов;
            //Вызвать метод, который возвращает массив любимых цветов по их количеству(заполнение с клавиатуры);
            //Сделать проверку, ввёл ли пользователь корректные числа: возраст, количество питомцев, количество цветов в отдельном методе;
            //Требуется проверка корректного ввода значений и повтор ввода, если ввод некорректен;
            //Корректный ввод: ввод числа типа int больше 0.
            //Метод, который принимает кортеж из предыдущего шага и показывает на экран данные.
            //Вызов методов из метода Main.

            (string Name, string LastName, int Age, string[] AnimalName, string[] Colors) User = EnterDataUser();
            DisplayUser(User);

            Console.ReadKey();


        }
        //заполняем данные о человеке
        static (string Name, string LastName, int Age, string[] AnimalName, string[] Colors) EnterDataUser()
        {

            (string Name, string LastName, int Age, string[] AnimalName, string[] Colors) User ;
            Console.WriteLine("Введите имя: ");
            User.Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию: ");
            User.LastName = Console.ReadLine();
            
            string strAge;
            int intAge;
            do
            {
                Console.WriteLine("Введите возраст: ");
                strAge = Console.ReadLine();

            } while (CheckNum(strAge,out intAge));
            User.Age = intAge;

            Console.WriteLine("Наличие питомца: Да/Нет");
            var isAnimal = Console.ReadLine();
            if (isAnimal == "Да") 
            {
                string countAni;
                int countAnimal;
                
                do
                {
                    Console.WriteLine("Сколько у вас питомцев: ");
                    countAni = Console.ReadLine();

                } while (CheckNum(countAni, out countAnimal));

                User.AnimalName = EnterAnimalName(countAnimal);
            }
            else 
            {

                User.AnimalName = null;
            }

          
            string countCol;
            int countColor;

            do
            {
                Console.WriteLine("Введите количество любимых цветов: ");
                countCol = Console.ReadLine();

            } while (CheckNum(countCol, out countColor));

            User.Colors = EnterFavColor(countColor);

            return User;
        }
        //проверка правильности ввода числа
        static bool CheckNum(string number, out int num)
        {
            if (int.TryParse(number, out int intnum))
            {
                // если результат число, тогда проверяем больше нуля или меньше
                if(intnum > 0)
                {
                    num = intnum;
                    return false;
                }
                else // возраст, количество животных, количество цветов не может быть нулевым значением
                {
                    Console.WriteLine("Значение  не может быть нулевым или отрицательным. Поптробуйте еще раз.");
                    num = 0;
                    return true;
                }
            }
            else // если результат не число
            {
                Console.WriteLine("Вы ввели некорректные данные. Введите значение цифрами.");
                num = 0;
                return true;

            }


        }
        //ввод кличек животных
        static string[] EnterAnimalName(int count)
        {
            var names = new string[count];
            for (int i = 0 ; i < names.Length ; i++)
            {
                Console.WriteLine($"Введите кличку {i+1} животного: ");
                names[i] = Console.ReadLine();
            }

            return names;
        }
        //ввод любимых цветов
        static string[] EnterFavColor(int count)
        {
            var colors = new string[count];
            for(int i = 0 ; i < count; i++)
            {
                Console.WriteLine($"Укажите какой {i+1} цвет: ");
                colors[i] = Console.ReadLine();
            }

            return colors;
        }
        //вывод перечисления на экран
        static void DisplayUser((string Name, string LastName, int Age, string[] AnimalName, string[] Colors) User)
        {
            Console.WriteLine();
            Console.WriteLine("_______________________________________");
            Console.WriteLine();
            var userForPrint = User;
            Console.WriteLine($"Имя: { userForPrint.Name}");
            Console.WriteLine($"Фамилия: { userForPrint.LastName}");
            Console.WriteLine($"Возраст: { userForPrint.Age}");
            if(userForPrint.AnimalName != null && userForPrint.AnimalName.Length > 0)
            {
                Console.WriteLine("Клички домашних питомцев: ");
                for (int i = 0; i < userForPrint.AnimalName.Length; i++)
                {
                    Console.WriteLine($"{i+1} - " + userForPrint.AnimalName[i]);
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Домашние питомцы отсутствуют.") ;
                Console.WriteLine();
            }
            Console.WriteLine("Любимые цвета: ");

            for (int i = 0; i < userForPrint.Colors.Length; i++)
            {
                
                Console.WriteLine($"{i + 1} - " + userForPrint.Colors[i]);
            }
            
        }

    }
}

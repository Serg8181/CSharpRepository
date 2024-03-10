/*Необходимо разработать методику анкетирования пользователей.
Требуется сохранять информацию: об имени пользователя, фамилии, логине, длине логина,
наличии/отсутствии у пользователя питомца, возрасте пользователя, трех любимых цветах пользователя.*/

using System;


class MainClass
{

    static void Main(string[] args)
    {
        //Задание 4.5.1
        //Задайте кортеж User, который описывает необходимую информацию.

        (string Name,string LastName,string Login,int LenLogin, bool isAnimal,double Age,string[] UserColor) User;    

        for (int i = 0; i < 3 ; i++)
        {
            //Задание 4.5.2
            //Заполните кортеж User значениями с клавиатуры для полей: имя пользователя, фамилия, логин.

            Console.WriteLine("Введите имя пользователя: ");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию пользователя: ");
            User.LastName = Console.ReadLine();

            Console.WriteLine("Введите логин: ");
            User.Login = Console.ReadLine();

            //Задание 4.5.3
            //Вычислите длину логина пользователя.
            User.LenLogin = User.Login.Length;

            //Задание 4.5.4
            //Напишите условие, которое устанавливает значение ИСТИНА в поле наличие/ отсутствие животных,
            //если пользователь вводит "Да", и ЛОЖЬ при любом другом варианте.
            Console.WriteLine("Есть ли у вас животные? Да или Нет");
            if (Console.ReadLine() == "Да")
            {
                User.isAnimal = true;
                
            }
            else
            {
                User.isAnimal = false;
            }
            //Задание 4.5.5
            // Напишите код для ввода возраста пользователя и трех его любимых цветов.

            Console.WriteLine("Введите возраст пользователя: ");
            User.Age = System.Convert.ToDouble(Console.ReadLine());


            User.UserColor = new string[3];
            Console.WriteLine("Введите три любимых цвета пользователя: ");
            for (int j = 0; j < 3; j++)
            {
                User.UserColor[j] = Console.ReadLine();
            }

            //Задание 4.5.6
            //Сделайте так, чтобы опрос повторялся для трех пользователей.

        }

    }

}

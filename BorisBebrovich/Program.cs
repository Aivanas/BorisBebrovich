namespace BorisBebrovich
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Добро пожаловать сюда! Если вы гангстер, перестаньте им быть потому что при неверном вводе программе кранты.");
            Console.WriteLine("Приятного использования ;)");
            choosing();
        }

        static void choosing()
        {
            Console.WriteLine("Итак есть четыре сту... кхм... программы:");
            Console.WriteLine("Программа 1: Игра 'Угадай число'");
            Console.WriteLine("Программа 2: Таблица умножения");
            Console.WriteLine("Программа 3: Вывод делителей числа");
            Console.WriteLine("Программа 4: закрыть программу (да, это реально)");
            Console.WriteLine("Что выберешь ты? (Введи пожалуйста НОМЕР операции)");
            int choosed = Convert.ToInt32(Console.ReadLine());

            if (choosed == 1)
            {
                game();
            }

            else if (choosed == 2)
            {
                table();
            }

            else if (choosed == 3)
            {
                split();
            }

            else if (choosed == 4)
            {
                exit();
            }
        }
        static void game()
        {
            Console.WriteLine("Если решите что с вас хватит, напишите любое число после 100");
            Random random = new Random();
            int randomed = (random.Next(100));
            bool booled = true;
            int i = 1;
            while (booled == true)
            {
                Console.WriteLine("Вводите число: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == randomed)
                {
                    Console.WriteLine("Поздравляю, вы выиграли ничего. УРА! УРА! УРА!");
                    Console.WriteLine("Вы попытались " + i + " раз. Неплохо, возможно....");
                    Console.WriteLine("---------------------");
                    choosing();
                }

                else if (num > 100)
                {
                    Console.WriteLine("---------------------");
                    Console.WriteLine("Вы попытались " + i + " раз. Жду сгущёнку!");
                    Console.WriteLine();
                    choosing();
                    booled = false;
                }

                else
                {
                    Console.WriteLine("Вы проиграли! С вас банка сгущёнки разработчику!");
                    Console.WriteLine("---------------------");
                    i++;
                }

                
            }

        }

        static void table()
        {
            int[,] array = new int[10, 10];
            Console.WriteLine();
            
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    array[i, j] = j * i;
                    
                }
                
            }

            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            choosing();
        }

        static void split()
        {
            Console.WriteLine("Введите число пжпжпж: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= num)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Делится на " + i);
                    i++;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine();
            choosing();

            
        }

        static void exit()
        {
            Console.WriteLine(" Ба Ба Ба Бе Бе Бе");
        }


    }
}
namespace FinalTaskModule5
{
    internal class Program
    {
        static bool Check(string Num)
        {
            int result;
            int.TryParse(Num, out result);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static string[] NickName(int CountPet)
        {
            string[] nickName = new string[CountPet];
            for (int i = 0; i < CountPet; i++)
            {
                Console.WriteLine("Введите кличку питомца {0}", i + 1);
                nickName[i] = Console.ReadLine();
            }
            return nickName;

        }

        static string[] FavColors(int favColors)
        {
            string[] favсolors = new string[favColors];
            for (int i = 0; i < favColors; i++)
            {
                Console.WriteLine("Введите Ваш Любимый цвет {0}", i + 1);
                favсolors[i] = Console.ReadLine();
            }
            return favсolors;

        }
        static (string name, string lastName, string age, bool hasPet, string[] arraypets, string[] arrayfavcolors) questionnaire()
        {
            (string name, string lastName, string age, bool hasPet, string[] arraypets, string[] arrayfavcolors) quiz;

            int countPet;
            int favColors;
            string favColorsCheck;
            string countPetsCheck;

            Console.Write("Введите имя: ");
            quiz.name = Console.ReadLine();

            Console.Write("Введите фамилию: ");
            quiz.lastName = Console.ReadLine();

            do
            {
                Console.Write("Введите возраст: ");
                quiz.age = Console.ReadLine();
            }
            while (!Check(quiz.age));


            Console.Write("Есть ли у вас питомец (Да или Нет)? ");
            if (Console.ReadLine() == "Да")
            {
                quiz.hasPet = true;
                do
                {
                    Console.Write("Сколько у вас питомецев? ");
                    countPetsCheck = Console.ReadLine();
                    Console.WriteLine("\n");

                } while (!Check(countPetsCheck));

                countPet = int.Parse(countPetsCheck);
                quiz.arraypets = NickName(countPet);

            }
            else
            {
                quiz.hasPet = false;
                quiz.arraypets = new string[0];
            }

            do
            {
                Console.Write("\nВведите количество любимых цветов: ");
                favColorsCheck = Console.ReadLine();
                Console.WriteLine("\n");

            } while (!Check(favColorsCheck));

            favColors = int.Parse(favColorsCheck);
            quiz.arrayfavcolors = FavColors(favColors);


            return quiz;
        }
        static void OutputToTheScreen()
        {

            var result = questionnaire();
            Console.WriteLine("\nОтлично! Спасибо, что ответили на наши вопросы!) Вот что у нас получилось:");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("\nВаше имя - {0}\nВаша фамилия - {1}\nВаш возраст - {2}", result.name, result.lastName, result.age);
            if (result.hasPet)
            {
                if (result.arraypets.Length > 1)
                {
                    Console.Write("\nУ вас есть замечательные питомцы! ");
                }
                else
                {
                    Console.Write("\nУ вас есть замечательный питомец! ");
                }
                
                for (int i = 0; i < result.arraypets.Length; i++)
                {
                    if (i == result.arraypets.Length - 1)
                    {
                        Console.Write(result.arraypets[i] + "!");
                        break;
                    }
                    Console.Write(result.arraypets[i] + ", ");
                }
            }
            else
            {
                Console.WriteLine("\nУ вас нет питомца!(");
            }
            if (result.arrayfavcolors.Length > 1)
            {
                Console.Write("\nВаши любимые цвета: ");
            }
            else
            {
                Console.Write("\nВаш любимый цвет: ");
            }

            for (int i = 0; i < result.arrayfavcolors.Length; i++)
            {
                if (i == result.arrayfavcolors.Length - 1)
                {
                    Console.Write(result.arrayfavcolors[i] + "!");
                    break;
                }
                Console.Write(result.arrayfavcolors[i] + ", ");
            }
            Console.WriteLine("\n--------------------------------------------------------------");

        }

        static void Main(string[] args)
        {
            OutputToTheScreen();
        }




    }
}

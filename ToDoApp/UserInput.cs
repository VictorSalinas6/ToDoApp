using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public static class UserInput
    {
        public static int MenuInput(string optionString)
        {

            switch (optionString)
            {
                case "1":
                    return 1;
                case "2":
                    return 2;
                case "3":
                    return 3;
                case "4":
                    return 4;
                case "5":
                    return 5;
                case "6":
                    return 6;
                default:
                    Console.WriteLine("Please enter a correct option!");
                    Console.WriteLine();
                    return 0;
            }
        }

        public static int CheckFirst(int choice)
        {
            int answer = choice;
            if (ListOfToDos.ToDos.Count == 0 && choice != 1 && choice != 6 && choice != 0)
            {
                Menus.FirstCreate();
                answer = 1;
            }

            return answer;
        }

        public static string ToDoInput()
        {
            Console.ForegroundColor = ConsoleColor.White;
            var answer = Console.ReadLine().ToLower();
            bool check = false;
            bool checkEmpty = false;
            bool checkLength = false;

            while (!check)
            {
                if (string.IsNullOrEmpty(answer))
                {
                    check = false;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Check your input, don't leave this field empty");
                    Console.WriteLine("Please try again!");
                    Console.ForegroundColor = ConsoleColor.White;
                    answer = Console.ReadLine().ToLower();
                }
                else if (answer.Length > 30)
                {
                    check = false;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("The name can't be that long! (Max 30 char)");
                    Console.WriteLine("Please try again!");
                    Console.ForegroundColor = ConsoleColor.White;
                    answer = Console.ReadLine().ToLower();
                }
                else
                {
                    check = true;
                }
            }

            if (answer.Length > 1)
                answer = char.ToUpper(answer[0]) + answer.Substring(1);
            else
                answer = char.ToUpper(answer[0]).ToString();

            Console.ForegroundColor = ConsoleColor.Blue;

            return answer;
        }

        public static string ToDoInputDescription()
        {
            Console.ForegroundColor = ConsoleColor.White;
            var answer = Console.ReadLine();

            while (string.IsNullOrEmpty(answer))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Check your input, don't leave this field empty");
                Console.WriteLine("Please try again!");
                Console.ForegroundColor = ConsoleColor.White;
                answer = Console.ReadLine();
            }

            if (answer.Length > 1)
                answer = char.ToUpper(answer[0]) + answer.Substring(1);
            else
                answer = char.ToUpper(answer[0]).ToString();

            Console.ForegroundColor = ConsoleColor.Blue;

            return answer;
        }
        public static int CheckInList()
        {
            string answer;
            int num = 0;
            bool check = false;

            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                answer = Console.ReadLine();

                if (answer.ToLower() == "cancel")
                {
                    Console.Clear();
                    ToDosApp.Start();
                }

                try
                {
                    num = int.Parse(answer);
                    check = true;
                }
                catch (FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Please enter the number of the Id!");
                }

                if (check)
                {
                    if (num > ListOfToDos.ToDos.Count)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Please enter a correct Id");
                        check = false;
                    }
                }
            } while (check == false);

            num--;

            Console.ForegroundColor = ConsoleColor.Blue;

            return num;
        }

        public static bool YesOrNoChecker()
        {

            bool finalA = true;
            bool check = false;

            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                var answer = Console.ReadLine().ToLower();
                switch (answer)
                {
                    case "y":
                    case "yes":
                    case "ye":
                        finalA = true;
                        check = false;
                        break;
                    case "n":
                    case "no":
                        finalA = false;
                        check = false;
                        break;
                    default:
                        check = true;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Please enter [Y]es or [N]o.");
                        break;
                }
            } while (check);

            Console.ForegroundColor = ConsoleColor.Blue;

            return finalA;
        }
    }
}

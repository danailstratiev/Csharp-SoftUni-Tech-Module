using System;

namespace _4._3_English_name_of_last_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
                        
            Console.WriteLine(NameOfLastDigit(number)); 

        }
        static string NameOfLastDigit(int number)
        {
            number = Math.Abs(number);
            var lastdigit = number % 10;
            string nameofDigit = "";
            switch (lastdigit)
            {
                case 1:
                    nameofDigit = "one";
                    break;
                case 2:
                    nameofDigit = "two";
                    break;
                case 3:
                    nameofDigit = "three";
                    break;
                case 4:
                    nameofDigit = "four";
                    break;
                case 5:
                    nameofDigit = "five";
                    break;
                case 6:
                    nameofDigit = "six";
                    break;
                case 7:
                    nameofDigit = "seven";
                    break;
                case 8:
                    nameofDigit = "eight";
                    break;
                case 9:
                    nameofDigit = "nine";
                    break;
                case 0:
                    nameofDigit = "null";
                    break;
            }

            return nameofDigit;
        }


    }
}

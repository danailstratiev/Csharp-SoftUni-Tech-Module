using System;
using System.Collections.Generic;


namespace Exercise_4_Password_validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string passWord = Console.ReadLine();


            if (IsLongEnogh(passWord) == true && HasTwoDigits(passWord) == true && OnlyLettersAndDigits(passWord) == true)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {            
                if (IsLongEnogh(passWord) == false)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }                
                if (OnlyLettersAndDigits(passWord) == false)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (HasTwoDigits(passWord) == false)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }
        static bool IsLongEnogh (string password)
        {
            string pass = password;
            bool isLong = false;

            if (pass.Length <= 10 && pass.Length >= 6)
            {
                isLong = true;
            }
            else
            {
                isLong = false;
            }
            return isLong;            
        }
        static bool HasTwoDigits (string password)
        {
            string pass = password;
            bool digitsNum = false;
            int sum = 0;

            foreach (char symbol in pass)
            {
                if (symbol >= 48 && symbol <= 57)
                {
                    sum++;
                }
            }
            if (sum >= 2)
            {
                digitsNum = true;
            }
            else
            {
                digitsNum = false;
            }
            return digitsNum;
        }
        static bool OnlyLettersAndDigits(string password)
        {
            string pass = password;
            bool hasLettersAndDigits = false;

            foreach (char symbol in pass)
            {
                if (((int)symbol >= 48 && (int)symbol <= 57) || ((int)symbol >= 65 && (int)symbol <= 90)
                    || ((int)symbol >= 97 && (int)symbol <= 122))
                {
                    hasLettersAndDigits = true;
                }
                else
                {
                    hasLettersAndDigits = false;
                    break;
                }
            }
            return hasLettersAndDigits;
        }
    }
}

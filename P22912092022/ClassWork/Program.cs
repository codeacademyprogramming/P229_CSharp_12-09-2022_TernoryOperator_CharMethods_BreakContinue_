using System;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //double num1 = 11;
            //double num2 = 16;
            //double num3 = 11;

            //double sum = SumOfTwoBigNumOfThreeNums(num1, num2, num3);
            //Console.WriteLine(sum);
            #endregion

            #region Task 2
            Console.WriteLine(Calculate(456, 65, '/'));
            #endregion

            byte age = 51;

            //Console.WriteLine(age < 18 ? "Genc" : age > 18 &&  age < 40 ? "Orta" : age > 50 ? "Qoca" : "");

            //char symbol = '1';

            //bool check = char.IsDigit(symbol);

            //char.IsWhiteSpace(' ');

            //if (check == true)
            //{
            //    Console.WriteLine("Reqemdir \n");
            //}

            //if (char.IsUpper(symbol))
            //{
            //    Console.WriteLine("boyuk herif");
            //}else
            //{
            //    Console.WriteLine("Kcik Herf");
            //}

            //string word = "Hello P133";
            ////char symbold = word[0];
            ////Console.WriteLine(word.Length);
            //Console.WriteLine(word.Length);

            //CheckString(word);

            //string name = "Hamid 4564 Mammadov";

            //int count = 0;

            //for (int i = 0; i < name.Length; i++)
            //{
            //    if (char.IsLetter(name[i]))
            //    {
            //        continue;
            //    }

            //    count++;
            //}

            byte[] numbers = { 5,7,15,12};
            //numbers[5] = 123;

            int[] numbers2 = new int[5];
            numbers2[0] = 654;
            numbers2[1] = 654;
            numbers2[3] = 654;

            int[] numbers3 = new int[] { 56,565,6,4};

            int[] numbers4 = { };
            int[] numbers5 = new int[0];

            int num = numbers3[3];
            numbers3[3] = 56456;

            string[] words = { };
            char[] arr = { };

            Console.WriteLine(num);
            Console.WriteLine(numbers3[3]);


        }

        static void CheckString(string str)
        {
            int digitcount = 0;
            int lettercount = 0;

            for (int i = 0; i < str.Length; i++)
            {
                char symbol = str[i];

                if (char.IsLetter(symbol))
                {
                    lettercount++;
                }
                else if (char.IsDigit(symbol))
                {
                    digitcount++;
                }
            }

            Console.WriteLine($"Daxil Edilen Stringde {digitcount} qeder reqem ve {lettercount} qeder herf var");
        }


        #region Task 1
        //Uc Dene Double Type-na Parametr Qebul Edib Bu Uc Parametr Arasinda En Boyuk 2
        //parametri Tapib Cemini Hesablayan Ve Geri Qaytaran Method YAZINNNNNN

        static double SumOfTwoBigNumOfThreeNums(double a, double b, double c)
        {
            double result = 0;

            if (a < b && a < c)
            {
                result = b + c;
            }
            else if (b < a && b < c)
            {
                result = a + c;
            }
            else if (c < a && c < b)
            {
                result = a + b;
            }
            else
            {
                Console.WriteLine("Daxil Olunan ededler Arasinda Beraberlik Var");
            }

            return result;
        }
        #endregion

        #region Task 2
        //Calculate Adinda Method Yazirsiniz. Bu Methodun 3 dene Parametri 2
        //reqem biri simvol / * + - Daxil Olunan reqemler simvola emaliyyat edir neticeni qaytarir

        static double Calculate(double num1, double num2, char symbol)
        {
            double result = 0;

            switch (symbol)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Duzgun Operator Gonder");
                    break;
            }

            //if(symbol == '+')
            //{

            //}
            //else if (symbol == '-')
            //{

            //}
            //else if (symbol == '*')
            //{

            //}
            //else if (symbol == '/')
            //{

            //}
            //else
            //{

            //}

            return result;
        }

        #endregion

        #region Task 3
        //BiggestNum Method 3 reqem qebul edir bu deyer arasinda en
        //boyuyunu tapib qaytarir, eyni adda 4 ve 5  parametrli
        //method yazirsiniz eyni mentiqde 4 parametrli arasinda da en
        //boyunu tapuir ve 5 parametrli arasindada Mesele Method Overloadingi Duzgun Isletmek

        static int BiggestNum(int a, int b, int c)
        {
            //if (a > b && a > c)
            //{
            //    return a;
            //}
            //else if (b > a && b > c)
            //{
            //    return b;
            //}
            //else if (c > a && c > b)
            //{
            //    return c;
            //}

            //Console.WriteLine("Beraberlik Var");
            //return 0;

            return a > b && a > c ? a : b > a && b > c ? b : c > a && c > b ? c : 0;
        }

        static int BiggestNum(int a, int b, int c, int d)
        {
            int max = BiggestNum(a, b, c);

            return max > d ? max : d;

            //if(max > d)
            //{
            //    return max;
            //}else
            //{ 
            //      return d;
            //}

            //return d;
        }

        static int BiggestNum(int a, int b, int c, int d, int e)
        {
            int max = BiggestNum(a, b, c, d);

            if (max > e)
            {
                return max;
            }

            return e;
        }
        #endregion
    }
}

using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;

namespace Assignment_Session03

{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 - Write a program that allows the user to enter a number then print it.

            //Console.Write("Enter The Number ");
            //int.TryParse(Console.ReadLine(), out int Num);
            //Console.WriteLine($"The Number = {Num}");

            #endregion

            #region Q2 - Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen


            //Console.Write("Enter The Number ");
            //string input = Console.ReadLine();

            //if (int.TryParse(input, out int output))
            //{
            //	Console.WriteLine($"The Number = {output}");


            //}
            //else
            //{

            //	Console.WriteLine("Invalid Number ");


            //}

            #endregion

            #region Q3 - Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen


            //double x = 1.3456;
            //double y = 2.5678;
            //Console.WriteLine(x + y);//3.9134 overflow 
            //         Console.WriteLine(x * y);//  3.45523168
            //         Console.WriteLine(x / y);//0.5240283511176882


            #endregion

            #region Q4 - Write C# program that Extract a substring from a given string.

            //Console.Write("Enter String : ");
            //String Str = Console.ReadLine();
            //string subStr = Str.Substring(0, 2);
            //Console.Write(subStr);


            #endregion

            #region Q5 - Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

            //int x = 10;
            //int y = x ;
            //Console.WriteLine(x);
            //Console.WriteLine(y);// y = x =10
            //// after modify
            //x = 20;
            //Console.WriteLine(x);// x= 20
            //Console.WriteLine(y);
            //// value of y = x before update 
            //// value type take copy of value and add in stack
            #endregion

            #region Q6 - Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen

            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = arr1;
            //Console.WriteLine(arr1[0]);
            //Console.WriteLine(arr2[0]);
            //// any change about arry while affect to anthor






            #endregion

            #region Q7 - Write C# program that take two string variables and print them as one variable 
            //Console.Write("Enter Str1 :");
            //string str1 = Console.ReadLine();
            //Console.Write("Enter Str1 :");
            //string str2 = Console.ReadLine();

            //string str3 = str1 + " " + str2;
            //Console.WriteLine(str3);

            #endregion

            #region Q8 - Write a program that calculates the simple interest given the principal amount, rate of interest, and time
            // Note :  The formula for simple interest is Interest = (principal * rate * time ) /100.

            //int principal = 10000; int rate = 10;int time = 1;
            //int interest = (principal * rate * time) / 100;
            //Console.WriteLine(interest);



            #endregion

            #region Q9 - Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. 
            // Note: The formula for BMI is BMI = (Weight) / (Height * Height)


            //Console.Write("Enter The Weight : ");
            //double weight = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter The Height : ");
            //double height = Convert.ToDouble(Console.ReadLine());

            //double BMI = (weight) / (height /100);
            //Console.WriteLine(BMI);





            #endregion

            #region Q10 - Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result.
            ///that below 10 degrees is "Just Cold"
            ///above 30 degrees is "Just Hot"
            ///anything else is "Just Good"
            /////
            //Console.Write("Enter the temperature: ");
            //int temperature = Convert.ToInt32(Console.ReadLine());

            //string result;

            //if (temperature > 30)
            //{
            //    result = "Too Hot";
            //}
            //else if (temperature < 15)
            //{
            //    result = "Too Cold";
            //}
            //else
            //{
            //    result = "Just Good";
            //}

            //Console.WriteLine($"The temperature is: {result}");


            #endregion

            #region Q11  Write a program that takes the date from the user and displays it in various formats using string interpolation.
            ///Ex:
            ///Today’s date : 20 , 11 , 2001
            ///Today's date : 20 / 11 / 2001
            ///Today's date : 20 – 11 – 2001
            ///
            //Console.Write("Enter a date (yyyy-MM-dd): ");
            //DateTime userDate = DateTime.Parse(Console.ReadLine());

            //Console.WriteLine($"Original format: {userDate}");
            //Console.WriteLine($"Short date: {userDate:MM/dd/yyyy}");
            //Console.WriteLine($"Long date: {userDate:dddd, MMMM dd, yyyy}");


            #endregion

            #region Q12 - Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            ///Example(1)
            ///Input: 12
            ///Output: Yes
            ///Example(2)
            ///Input: 9
            ///Output: No
            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number % 3 == 0 && number % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

            #endregion

            #region Q13 - Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            ///Example(1)
            ///Input: -5
            ///Output: negative
            ///Example(2)
            ///Input: 10
            ///Output: positive
            ///  
            //Console.Write("Enter an integer: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number < 0)
            //{
            //    Console.WriteLine("Negative");
            //}
            //else
            //{
            //    Console.WriteLine("Positive");
            //}


            #endregion

            #region Q14 - Write a program that takes 3 integers from the user then prints the max element and the min element.
            ///Example(1)
            ///Input: 7,8,5
            ///Output:
            ///max element = 8
            ///min element = 5
            ///Example(2)
            ///Input: 3 6 9
            ///Outputs:
            ///Max element = 9
            ///Min element = 3
            //Console.Write("Enter the first integer: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the second integer: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the third integer: ");
            //int num3 = Convert.ToInt32(Console.ReadLine());

            //int max = Math.Max(num1, Math.Max(num2,num3));
            //int min = Math.Min(num1, Math.Min(num2, num3));

            //Console.WriteLine($"The max num is: {max}");
            //Console.WriteLine($"The min num is: {min}");













            #endregion

            #region Q15 - Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.Write("Enter an integer: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("The number is Even.");
            //}
            //else
            //{
            //    Console.WriteLine("The number is Odd.");
            //}

            #endregion

            #region Q16 - Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            ///Example(1)
            ///Input: O
            ///Output: vowel
            ///Example(2)
            ///Input: b
            ///Output: Consonant
            ///

            //===========
            //Console.Write("Enter a character: ");
            //char inputChar = Convert.ToChar(Console.ReadLine());

            //if (inputChar == 'a' || inputChar == 'e' || inputChar == 'i' || inputChar == 'o' || inputChar == 'u')
            //{
            //    Console.WriteLine("Vowel");
            //}
            //else  
            //{
            //    Console.WriteLine("Consonant");
            //}


            #endregion

            #region Q17 - Write a program to input the month number and print the number of days in that month.
            /// Example
            /// Input: Month Number: 1
            /// Output: Days in Month: 31
            /// 

            Console.Write("Enter the month num: ");
            int month = Convert.ToInt32(Console.ReadLine());

            int days;

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Days in Month: 31");
                    break;

                case 4: 
                case 6: 
                case 9: 
                case 11:
                    Console.WriteLine("Days in Month: 30");
                    break;
                case 2:
                    Console.WriteLine("Days in Month: 28");
                    break;


                    #endregion

            }
        }
    }
}

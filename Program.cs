using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 15;
            printPrimeNumbers(a, b);

            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("The sum of the series is: " + r1);


            long n2 = 15;
            long r2 = decimalToBinary(n2);
            Console.WriteLine("Binary conversion of the decimal number " + n2 + " is: " + r2);


            long n3 = 1111;
            long r3 = binaryToDecimal(n3);
            Console.WriteLine("Decimal conversion of the binary number " + n3 + " is: " + r3);


            int n4 = 5;
            printTriangle(n4);

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);

            Console.ReadLine();

            // The said assignment helped me in refreshing my knowledge of some of the basic concepts like loops.
        }

        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                int n, i, c;// initializing integers value n, i ,c
                for (n = x; n <= y; n++) // This for loop first take the value of x as n then checks rhe condition that the value must be less than equal to y and if it satisfy then it will repeat untill it unsatisfy that condition
                {
                    c = 0;
                    // Also in final result it will display total prime number between  'x' and 'y'.
                    for (i = 2; i <= n / 2; i++)
                    {
                        if (n % i == 0) // if will check this condition that n will divide by i and if remainder is 0 then it will enter this loop
                        {
                            c++; // c will increment
                            break;
                        }
                    }
                    if (c == 0 && n != 1) // this if comment c must be equal to 0 and also checks n not equal to 1 and if it passes both condition then it will write.
                        Console.Write("{0} ", n);
                }
                Console.Write("\n"); // for space
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()"); // to catch exception
            }
        }

        public static double getSeriesResult(int n)
        {
            try
            {
                int i, sum = 0; // two integers are created i and sum
                int x = 1;// Set x=1
                for (i = 1; i <= n; i++)// the loop will iterate from number "1". than satisfy this condition i should be less than n, then it will increase untill it unsatisfy this condition 
                {
                    sum = sum + x;//adding variable "sum" with "x" 
                    x = (x) + 1; // increasing value of x by 1
                }
                return Convert.ToDouble(sum); // returning sum method
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }

            return 0;
        }

        public static long decimalToBinary(long n)
        {
            try
            {
                int m = Convert.ToInt32(n); // It will convert to Integer.
                string result;

                result = ""; // pass an empty 
                // This while loop will run till num is greater than 1
                // I have taken a variable 'remainder' which will store remainder value after dividing num with 2. After that I will store remainder value adding into another variable 'result'.
                while (m > 1)
                {
                    int remainder = m % 2; // to check remainder
                    result = Convert.ToString(remainder) + result; // to add previous result to current one 
                    m /= 2;
                }
                result = Convert.ToString(m) + result; // adding last element through which it will exit while loop
                return Convert.ToInt64(result);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing decimalToBinary()");
                return 0;


            }
        }

        public static long binaryToDecimal(long n)
        {
            long dinl = 0, binl = 1, rem; // Created three long datatype and set din1=0 and bin1=1
            try
            {
                while (n > 0) // while loop will check condition for value n
                {
                    rem = n % 10;               //taking  the value in unit digit 
                    dinl = (dinl + rem) * binl;  //calculating decimal value
                    n = n / 10;
                    binl = binl * 2;  // Converting in decimal
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            }

            return dinl; // returning the value
        }

        public static void printTriangle(int n)
        {
            try
            {
                int sp, x; // created two integers sp and x
                for (int i = 1; i <= n; i++) // this for loop will start will i=1 and than check the condition i should be less than n and than i will increase upto the condition will unsatisfy. 
                {
                    for (sp = 1; sp <= (n - i); sp++) //iterating  
                        Console.Write(" ");
                    for (x = 1; x <= i; x++) //incrementing the value  
                        Console.Write('*'); //printing 
                    for (x = (i - 1); x >= 1; x--) //decrementing the value  
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static void computeFrequency(int[] a)
        {
            try
            {
                int n = a.Length;

                Boolean[] b = new Boolean[n];
                Console.WriteLine("Computed Frequency is:");
                for (int i = 0; i < n; i++)
                {
                    if (b[i] == true)
                        continue;
                    int counter = 1;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (a[i] == a[j])
                        {
                            b[j] = true;    // if the value satisfy
                            counter++;     //increment the counter
                        }

                    }

                    Console.WriteLine(a[i] + "  :  " + counter);
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }

    }
}

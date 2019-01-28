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

            // The said assignment helped me in refreshing my knowledge of some of the basic concepts like loops and other conditional statements 
            // Also the assignment has helped i getting good hands-on with the visual studio
        }

        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                int n, i, c;// initialisation by defining integers value n, i ,c
                for (n = x; n <= y; n++) //x and y are the values 
                {
                    c = 0;
                    //the loop will check whether the number 'n' is divisible by any number between 2 and half of the number n. If it will be divisible then it will increment the counter 
                    // Also in final result it will display total prime number between  'x' and 'y'.
                    for (i = 2; i <= n / 2; i++)
                    {
                        if (n % i == 0)
                        {
                            c++;
                            break;
                        }
                    }
                    if (c == 0 && n != 1)
                        Console.Write("{0} ", n);
                }
                Console.Write("\n");
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
        }

        public static double getSeriesResult(int n)
        {
            try
            {
                int i, sum = 0;
                int x = 1;// Set x=1
                for (i = 1; i <= n; i++)// the loop will iterate from number "1".
                {
                    sum = sum + x;//adding variable "sum" with "x" 
                    x = (x) + 1;
                }
                return Convert.ToDouble(sum);
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
                // It will convert to Integer.
                int m = Convert.ToInt32(n);
                string result;

                result = "";
                // This while loop will run till num is greater than 1
                // I have taken a variable 'remainder' which will store remainder value after dividing num with 2. After that I will store remainder value adding into another variable 'result'.
                while (m > 1)
                {
                    int remainder = m % 2;
                    result = Convert.ToString(remainder) + result;
                    m /= 2;
                }
                result = Convert.ToString(m) + result;
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
            long dinl = 0, binl = 1, rem;
            try
            {
                while (n > 0)
                {
                    rem = n % 10;               //taking  the value in unit digit 
                    dinl = (dinl + rem) * binl;  //calculating decimal value
                    n = n / 10;
                    binl = binl * 2;
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            }

            return dinl;
        }

        public static void printTriangle(int n)
        {
            try
            {
                int sp, x;
                for (int i = 1; i <= n; i++)
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

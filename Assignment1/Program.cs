using System;
using System.Diagnostics;

namespace Assignment1
{
    class Program
    {
        public static void Main()
        {
            int a = 5, b = 25;
            printPrimeNumbers(a, b);
           

            double n1 = 5;
            double r1 = getSeriesResult(n1);
            Debug.WriteLine("The sum of the series is: " + r1);


            int n4 = 5;
            printTriangle(n4);

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);

        }

        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                // To calculate prime number from x to y
                while (x <= y)
                    
                {
                    int flag = 0;
                    // 1 is not a prime number and hence started from 2. (x/2) --> would give all possible multiples of a number 
                    for (int i = 2; i <= x / 2  ; i = i +1 )
                    {
                        // A prime number is a whole number greater than 1 whose only factors are 1 and itself
                        if (x%i == 0)
                        {
                            Debug.WriteLine(x + "is not a prime number");
                             flag = 1;
                            break;
                        }
                        
                    }
                    //A prime number is a whole number greater than 1 whose only factors are 1 and itself
                    if (flag == 0)
                    {
                        Debug.WriteLine(x + "is a  prime number");
                        
                    }
                    x++;
                    
                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
        }
       
        public static double getSeriesResult(double n)
        {
            double Sum_Series = 0;
            double Series = 0;
            try
            {
                double factorial = 0;
                //Formula to caluclate Series Result 1/2 – 2!/3 + 3!/4 – 4!/5 --- n 
                for (int SR = 1; SR <= n; SR++)
                {
                    int F = SR + 1;
                    //To call Fact()
                    factorial = Fact(SR);
                    Series = factorial / F;
                    // If the Value is even then Series has to be subtracted 
                    if ( SR %2 == 0)
                    {
                        Sum_Series = Sum_Series - Series;
                    }
                    // If the value is odd, Series has to be added
                    else
                    {
                        Sum_Series = Sum_Series + Series;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }
            // To return Sum_series to the main function
            return Sum_Series;
        }
        //To define a method and call in the function getSeriesResult()
        private static int Fact(int n)
        {
            int f = 1;
            try
            {
                // To calculate factorial . for eg : 4! = 4*3*2*1
                for (int d = 1; d <= n; d++)
                {
                    f = f * d;
                    
                    
                }
                
            }
            catch
            {
                Console.WriteLine("Exception occured while computing Factorial()");
            }
            return f;
        }

        public static void printTriangle(int n)
        {
            try
            {
                // To loop the lines from 0 to n-1 
                for (int a = 0; a < n; a++)
                {
                    // To leave spaces on the left side
                    for (int j = 1; j <= n - a; j++)
                        Debug.Write(" ");
                    // 2 * a -1 is to print odd number of stars
                    for (int j = 1; j <= 2 * a - 1; j++)
                        Debug.Write("*");
                        Debug.Write("\n");
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static void computeFrequency(int[] a)
        {
            int temp_arr = 0;
            int temp_arr1 = 0;
            int count = 0;
            int Frequency = 0;
            int Flag = 0;
            try
                
            {
                
                for (int arr = 0; arr < a.Length; arr++)
                {
                    // To sort the array to make it easier and fast comparison
                    Array.Sort(a);                    
                    temp_arr = a[arr];
                    // To count the first edge case
                    if (arr == 0)
                    {
                        Flag = 1;
                        count = count + 1;
                    }
                    // To count cases where previous value and current value are same except first edge case
                    if(temp_arr == temp_arr1 || Flag != 1)
                    {
                         count = count + 1;                       
                    }
                    // To populate count when previous and current values are not same and exclude first edge case
                    else
                     if (temp_arr != temp_arr1  && temp_arr1 != 0 )
                    {
                        Frequency = count;
                        count = 1;
                         Debug.WriteLine("Number: " + temp_arr1 + " Frequency: "  + Frequency);                      
                    }
                    // Moving the current value to temp_arr1 to compare with next value
                    temp_arr1 = temp_arr;                
                }
                // To display the final edge case
                Frequency = count;
                Debug.WriteLine("Number: " + temp_arr1 + " Frequency: " + Frequency);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }
    }
}

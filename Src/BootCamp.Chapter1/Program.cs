using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace hw5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = { 1, 2, 3, 4, 5 };
            int[] numbers2 = { 9, 12, 11, 10, 13 };
            Console.WriteLine(" ASCENDING ORDERS ");
            Console.WriteLine("Original array:");
            PrintArray(numbers1);
            AscendingOrder1(numbers1);
            Console.WriteLine("Original array:");
            PrintArray(numbers2);
            AscendingOrder2(numbers2);
            Console.WriteLine(" ");

            Console.WriteLine(" DESCENDING ORDERS ");
            Console.WriteLine("Original array:");
            PrintArray(numbers1);
            DescendingOrder1(numbers1);
            Console.WriteLine("Original array:");
            PrintArray(numbers2);
            DescendingOrder2(numbers2);
            Console.WriteLine(" ");

            Console.WriteLine(" ARRAYS WITHOUT FIRST NUMBERS ");
            Console.WriteLine("Original array:");
            PrintArray(numbers1);
            RemoveFirstNumber1(numbers1);
            Console.WriteLine("Original array:");
            PrintArray(numbers2);
            RemoveFirstNumber2(numbers2);
            Console.WriteLine(" ");

            Console.WriteLine(" ARRAYS WITHOUT LAST NUMBERS ");
            Console.WriteLine("Original array:");
            PrintArray(numbers1);
            RemoveLastNumber1(numbers1);
            Console.WriteLine("Original array:");
            PrintArray(numbers2);
            RemoveLastNumber2(numbers2);
            Console.WriteLine(" ");

        }
        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
        }
        private static void AscendingOrder1(int[] numbers1)
        {
            for (int i = 1; i < numbers1.Length; i++)
            {
                int c = numbers1[i]; // c as in current number
                int p = i - 1;       // p as in previous index

                while (p >= 0 && numbers1[p] > c)
                {
                    numbers1[p + 1] = numbers1[p];
                    p--;
                }

                numbers1[p + 1] = c;
            }
            Console.WriteLine("Sorted array 'numbers1' in ascending order:");
            PrintArray(numbers1);
        }
        private static void AscendingOrder2(int[] numbers2)
        {
            for (int i = 1; i < numbers2.Length; i++)
            {
                int c = numbers2[i]; // c as in current number
                int p = i - 1;       // p as in previous index

                while (p >= 0 && numbers2[p] > c)
                {
                    numbers2[p + 1] = numbers2[p];
                    p--;
                }

                numbers2[p + 1] = c;
            }

            Console.WriteLine("Sorted array 'numbers2' in ascending order:");
            PrintArray(numbers2);
        }
        private static void DescendingOrder1(int[] numbers1)
        {
            for (int i = 1; i < numbers1.Length; i++)
            {
                int c = numbers1[i]; // c as in current number
                int p = i - 1;       // p as in previous index

                while (p >= 0 && numbers1[p] < c)
                {
                    numbers1[p + 1] = numbers1[p];
                    p--;
                }

                numbers1[p + 1] = c;
            }
            Console.WriteLine("Sorted array 'numbers1' in descending order:");
            PrintArray(numbers1);
        }
        private static void DescendingOrder2(int[] numbers2)
        {
            for (int i = 1; i < numbers2.Length; i++)
            {
                int c = numbers2[i]; // c as in current number
                int p = i - 1;       // p as in previous index

                while (p >= 0 && numbers2[p] < c)
                {
                    numbers2[p + 1] = numbers2[p];
                    p--;
                }

                numbers2[p + 1] = c;
            }

            Console.WriteLine("Sorted array 'numbers2' in descending order:");
            PrintArray(numbers2);
        }
        private static int[] RemoveFirstNumber1(int[] numbers1)
        {
            Console.WriteLine($"Array 'numbers1' without first number: ");
            if (numbers1.Length > 0)
            {
                int[] newArray = new int[numbers1.Length - 1];

                for (int i = 0; i < newArray.Length; i++)
                {
                    newArray[i] = numbers1[i + 1];
                }
                return newArray;
            }
            else
            {
                Console.WriteLine("Array is empty. Cannot remove the frist element.");
                return null;
            }
        }
        private static int[] RemoveFirstNumber2(int[] numbers2)
        {
            Console.WriteLine($"Array 'numbers2' without first number: ");
            if (numbers2.Length > 0)
            {
                int[] newArray = new int[numbers2.Length - 1];

                for (int i = 0; i < newArray.Length; i++)
                {
                    newArray[i] = numbers2[i + 1];
                }
                return newArray;
            }
            else
            {
                Console.WriteLine("Array is empty. Cannot remove the frist element.");
                return null;
            }
        }
        private static int[] RemoveLastNumber1(int[] numbers1)
        {
            Console.WriteLine($"Array 'numbers1' without the last number: ");
            if (numbers1.Length > 0)
            {
                int[] newArray = new int[numbers1.Length - 1];

                for (int i = 0; i < newArray.Length; i++)
                {
                    newArray[i] = numbers1[i];
                }

                return newArray;
            }
            else
            {
                Console.WriteLine("Array 'numbers1' is empty. Cannot remove the last element.");
                return null;
            }
        }
        private static int[] RemoveLastNumber2(int[] numbers2)
        {
            Console.WriteLine($"Array 'numbers2' without the last number: ");
            if (numbers2.Length > 0)
            {
                int[] newArray = new int[numbers2.Length - 1];

                for (int i = 0; i < newArray.Length; i++)
                {
                    newArray[i] = numbers2[i];
                }

                return newArray;
            }
            else
            {
                Console.WriteLine("Array 'numbers2' is empty. Cannot remove the last element.");
                return null;
            }
        }

        /* chatgpt:
        private static int[] InsertAtStart(int[] array, int element)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[0] = element;
            Array.Copy(array, 0, newArray, 1, array.Length);
            return newArray;
        }
        private static int[] InsertAtEnd(int[] array, int element)
        {
            int[] newArray = new int[array.Length + 1];
            Array.Copy(array, newArray, array.Length);
            newArray[newArray.Length - 1] = element;
            return newArray;
        }
        private static int[] InsertAtIndex(int[] array, int index, int element)
        {
            if (index >= 0 && index <= array.Length)
            {
                int[] newArray = new int[array.Length + 1];
                Array.Copy(array, 0, newArray, 0, index);
                newArray[index] = element;
                Array.Copy(array, index, newArray, index + 1, array.Length - index);
                return newArray;
            }
            else
            {
                Console.WriteLine($"Invalid index {index}. Cannot insert element.");
                return array;
            }
            */
    }

}

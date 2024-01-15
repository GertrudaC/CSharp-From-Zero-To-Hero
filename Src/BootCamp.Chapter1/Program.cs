using System;
namespace hw5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = { 1, 2, 3, 4, 5 };
            int[] numbers2 = { 9, 12, 11, 10, 13 };
            Console.WriteLine("ASCENDING ORDERS");
            Console.WriteLine("Original array:");
            PrintArray(numbers1);
            AscendingOrder(numbers1);
            Console.WriteLine("Original array:");
            PrintArray(numbers2);
            AscendingOrder(numbers2);
            Console.WriteLine();

            Console.WriteLine("DESCENDING ORDERS");
            Console.WriteLine("Original array:");
            PrintArray(numbers1);
            DescendingOrder(numbers1);
            Console.WriteLine("Original array:");
            PrintArray(numbers2);
            DescendingOrder(numbers2);
            Console.WriteLine();

            Console.WriteLine("ARRAYS WITHOUT FIRST NUMBERS");
            Console.WriteLine("Original array:");
            PrintArray(numbers1);
            RemoveFirstNumber(numbers1);
            Console.WriteLine("Original array:");
            PrintArray(numbers2);
            RemoveFirstNumber(numbers2);
            Console.WriteLine();

            Console.WriteLine("ARRAYS WITHOUT LAST NUMBERS");
            Console.WriteLine("Original array:");
            PrintArray(numbers1);
            RemoveLastNumber(numbers1);
            Console.WriteLine("Original array:");
            PrintArray(numbers2);
            RemoveLastNumber(numbers2);
            Console.WriteLine();

            Console.WriteLine("ARRAYS WITH NUMBERS INSERTED AT START");
            int[] s1 = InsertAtStart(numbers1, 4);
            PrintArray(s1);
            int[] s2 = InsertAtStart(numbers2, 2);
            PrintArray(s2);

            Console.WriteLine("ARRAYS WITH NUMBERS INSERTED AT END");
            int[] e1 = InsertAtEnd(numbers1, 10);
            PrintArray(e1);
            int[] e2 = InsertAtEnd(numbers2, 18);
            PrintArray(e2);

            Console.WriteLine("ARRAYS WITH NUMBERS INSERTED AT INDEX");
            int[] i1 = InsertAtIndex(numbers1, 2, 4);
            PrintArray(i1);
            int[] i2 = InsertAtIndex(numbers2, 1, 3);
            PrintArray(i2);




            Console.ReadLine();
        }
        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
        }
        private static void AscendingOrder(int[] numbers)
        {
            int n = numbers.Length; // naujas kintamasis n, kuris apskaičiuoja masyvo ilgį
            for (int i = 0; i < n - 1; i++) // išorinis ciklas lygina ir sukeičia gretimus elementus, kol didžiausias nesurikiuotas elementas yra masyvo gale
            {
                for (int j = 0; j < n - i - 1; j++) // vidinis ciklas iteruoja per nesurikiuotą masyvo dalį, palygindamas gretimus elementus
                {
                    if (numbers[j] > numbers[j + 1]) // patikrina, ar dabartinis elementas yra didesnis už kitą elementą. Jei taip, tai dabartinis elementas yra ne tvarkoje, ir juos reikia sukeisti
                    {
                        // sukeičiami j su j+1
                        int keitimas = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = keitimas;
                    }
                }
                Console.WriteLine("Sorted array in ascending order:");
                PrintArray(numbers);
            }
        }
        private static void DescendingOrder(int[] numbers)
        {
            int n = numbers.Length; // naujas kintamasis n, kuris apskaičiuoja masyvo ilgį
            for (int i = 0; i < n - 1; i++) // išorinis ciklas lygina ir sukeičia gretimus elementus, kol didžiausias nesurikiuotas elementas yra savo vietoje
            {
                for (int j = 0; j < n - i - 1; j++) // vidinis ciklas iteruoja per nesurikiuotą masyvo dalį, palygindamas gretimus elementus ir juos sukeičia, jei reikia
                {
                    if (numbers[j] > numbers[j + 1]) // patikrina, ar dabartinis elementas yra mažesnis už kitą elementą. Jei taip, tai dabartinis elementas yra ne tvarkoje, ir juos reikia sukeisti
                    {
                        // sukeičiami j su j+1
                        int keitimas = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = keitimas;
                    }
                }
                Console.WriteLine("Sorted array in descending order:");
                PrintArray(numbers);
            }
        }
        private static int[] RemoveFirstNumber(int[] numbers)
        {
            Console.WriteLine("Array without the first number: ");
            if (numbers.Length > 0) // patikrina ar masyvas netuščias
            {
                int[] newArray = new int[numbers.Length - 1]; // sukuria naują masyvą, kuris yra vienu elementu mažesnis, nei senas masyvas

                for (int i = 1; i < numbers.Length; i++) // ciklas, kuris iteruoja per sena masyvą iki jo pabaigos, pradedant nuo antrojo elemento
                {
                    newArray[i - 1] = numbers[i]; // kopijuoja kiekvieną elementą iš seno masyvo į naują
                }

                PrintArray(newArray); // atspausdina naują masyvą, be pirmojo elemento
                return newArray;
            }
            else
            {
                Console.WriteLine("Array is empty. Cannot remove the first element."); // jei nėra pirmo elemento masyve, tai grąžina null 
                return null;
            }
        }
        private static int[] RemoveLastNumber(int[] numbers)
        {
            Console.WriteLine("Array without the last number: ");
            if (numbers.Length > 0) // patikrina ar masyvas netuščias
            {
                int[] newArray = new int[numbers.Length - 1]; // sukuria naują masyvą, kuris yra vienu elementu mažesnis, nei senas masyvas

                for (int i = 0; i < newArray.Length; i++) // ciklas, kuris iteruoja per naują masyvą
                {
                    newArray[i] = numbers[i]; // kopijuoja kiekvieną elementą iš seno masyvo į naują
                }

                PrintArray(newArray); // atspausdina naują masyvą, be paskutinio elemento
                return newArray;
            }
            else
            {
                Console.WriteLine("Array is empty. Cannot remove the last element."); // jei nėra paskutinio elemento masyve, tai grąžina null
                return null;
            }
        }
        private static int[] InsertAtStart(int[] array, int element)
        {
            return InsertAtIndex(array, 0, element); // naudoja metodą InsertAtIndex, kuriame panaudoja seną masyvą, nurodytą indeksą (0) ir elementą
        }

        private static int[] InsertAtEnd(int[] array, int element)
        {
            return InsertAtIndex(array, array.Length, element); // naudoja metodą InsertAtIndex, kuriame panaudoja seną masyvą, naujo masyvo ilgį ir elementą.
        }

        private static int[] InsertAtIndex(int[] array, int index, int element)
        {
            if (index >= 0 && index <= array.Length) // patikrina ar indeksas yra tarp reikiamų ribų, t.y. indeksas turi būti tarp 0 ir masyvo ilgio skaičiaus.
            {
                int[] newArray = new int[array.Length + 1]; // sukuria naują masyvą, kuris yra vienu elementu didesnis (kad būtų galima įterpti naują elementą)

                for (int i = 0; i < index; i++)
                {
                    newArray[i] = array[i]; // nukopijuoja elementus iš seno masyvo į naują, prieš parenkant specifinį indeksą
                }

                newArray[index] = element; // įterpia naują elementą į nurodytą indeksą naujame masyve

                for (int i = index; i < array.Length; i++)
                {
                    newArray[i + 1] = array[i]; // kopijuoja elementus iš seno masyvo į naują masyvą po nurodyto indekso
                }

                return newArray; // grąžina naują masyvą su įterptu elementu
            }
            else
            {   // jei netinkamas indexas, tai spausdina error tekstą ir grąžiną seną masyvą
                Console.WriteLine($"Invalid index {index}. Cannot insert element.");
                return array;
            }
        }

    }
}

using hw4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace hw3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 zmogus = new Class1();
            zmogus.Function1();
            Class1.Function2();
            string namesurname = GetNameSurname();
            int age = GetAge();
            double weight = GetWeight();
            double height = GetHeight();
            double bmi = GetBMI(weight, height);
            Console.WriteLine($"{namesurname} is {age} years old, his/her weight is {weight} kg and his/her height is {height} m.");
            Console.WriteLine($"{namesurname} body-mass index (BMI) is  {bmi} .");
        }
        private static string GetNameSurname()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine();
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname))
            {
                Console.WriteLine("Name cannot be empty");
                return "-";
            }
            return name + " " + surname;
        }

        private static int GetAge()
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (string.IsNullOrEmpty(age))
            {
                Console.WriteLine($"{age} is not a valid number.");
                return -1;
            }
            return age;
        }
        private static double GetWeight()
        {
            Console.Write("Enter your weight (in kg): ");
            double weight = Convert.ToDouble(Console.ReadLine());
            if (string.IsNullOrEmpty(weight))
            {
                Console.WriteLine($"{weight} is not a valid number.");
                return -1;
            }
            return weight;
        }
        private static double GetHeight()
        {
            Console.Write("Enter your height (in m): ");
            double height = Convert.ToDouble(Console.ReadLine());
            if (string.IsNullOrEmpty(height))
            {
                Console.WriteLine($"{height} is not a valid number.");
                return -1;
            }
            return height;
        }
        private static double GetBMI(double weight, double height)
        {
            double bmi = weight / (height * height);
            if (height <= 0 || weight <= 0)
            {
                Console.WriteLine($"Failed calculating BMI. Reason: \"Height cannot be equal or less than zero, but was {height}.\"\r\n\"Weight cannot be equal or less than zero, but was {weight}.\"");
                return -1;
            }
            return bmi;
        }
    }
}

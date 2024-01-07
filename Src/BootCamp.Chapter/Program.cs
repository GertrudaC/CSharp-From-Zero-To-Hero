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
            string namesurname = GetNameSurname();
            int age = GetAge();
            double weight = GetWeight();
            double height = GetHeight();
            double bmi = GetBMI(weight, height);
            Console.WriteLine($"{namesurname} is {age} years old, his/her weight is {weight} kg and his/her height is {height} m.");
            Console.WriteLine($"{namesurname} body-mass index (BMI) is  {bmi} .");
            Console.ReadLine();
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
            string InputAge = (Console.ReadLine());
            int age = Convert.ToInt32(InputAge);
            if (string.IsNullOrEmpty(InputAge))
            {
                Console.WriteLine($"{InputAge} is not a valid number.");
                return -1;
            }
            return age;
        }
        private static double GetWeight()
        {
            Console.Write("Enter your weight (in kg): ");
            string InputWeight = (Console.ReadLine());
            double weight = Convert.ToDouble(InputWeight);
            if (string.IsNullOrEmpty(InputWeight))
            {
                Console.WriteLine($"{InputWeight} is not a valid number.");
                return -1;
            }
            return weight;
        }
        private static double GetHeight()
        {
            Console.Write("Enter your height (in m): ");
            string InputHeight = (Console.ReadLine());
            double height = Convert.ToDouble(InputHeight);
            if (string.IsNullOrEmpty(InputHeight))
            {
                Console.WriteLine($"{InputHeight} is not a valid number.");
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

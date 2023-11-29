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
        }
        public static string GetNameSurname()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine();
            return name + " " + surname;
        }

        public static int GetAge()
        {
            Console.Write("Enter your age: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static double GetWeight()
        {
            Console.Write("Enter your weight (in kg): ");
            return Convert.ToDouble(Console.ReadLine());
        }
        public static double GetHeight()
        {
            Console.Write("Enter your height (in m): ");
            return Convert.ToDouble(Console.ReadLine());
        }
        public static double GetBMI(double weight, double height)
        {
            double bmi = weight / (height * height);
            return bmi;
        }
    }
}

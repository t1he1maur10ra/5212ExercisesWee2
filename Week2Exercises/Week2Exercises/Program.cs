using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make 2 variables to use throughput the app
            float num1, num2;

            /*----- Task 1A -----*/
            MutilplyNums();

            /*----- Task 1B -----*/
            //Ask the user for 2 numbers and store them in variables.
            Console.WriteLine("Task 1B");
            Console.WriteLine("Please enter a number: ");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            num2 = float.Parse(Console.ReadLine());
            //Display the result to the user by calling the method and passing it num1 & num2
            Console.WriteLine("{0} x {1} = {2}", num1, num2, MultiplyNumsExtended(num1, num2));
            //Leave this part.
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();

            /*----- Task 1C -----*/
            //Ask the user for 2 numbers and store them in variables.
            Console.WriteLine("Task 1C");
            Console.WriteLine("Please enter a number: ");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            num2= float.Parse(Console.ReadLine());
            //Create an instance of the math class because its not public
            Math mathClassInstance = new Math();
            //Display the multiplication result to the user by calling the instance and passing it num1 & num2
            Console.WriteLine("{0} x {1} = {2}", num1, num2, mathClassInstance.MultiplyNums(num1, num2));
            //Leave this part.
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();

            /*----- Task 1D -----*/
            Console.WriteLine("Task 1D");
            //Display the division result to the user by calling the instance and passing it num1 & num2
            Console.WriteLine("{0} / {1} = {2}", num1, num2, mathClassInstance.DivideNums(num1, num2));
            //Display the addition result to the user by calling the instance and passing it num1 & num2
            Console.WriteLine("{0} + {1} = {2}", num1, num2, mathClassInstance.AddNums(num1, num2));
            //Display the subtraction result to the user by calling the instance and passing it num1 & num2
            Console.WriteLine("{0} - {1} = {2}", num1, num2, mathClassInstance.SubtractNums(num1, num2));
            //Leave this part.
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }

        /*----- Task 1A -----*/
        static void MutilplyNums()
        {
            //Ask the user for 2 numbers and store them in variables.
            Console.WriteLine("Task 1A");
            Console.WriteLine("Please enter a number: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            float num2 = float.Parse(Console.ReadLine());

            //Display the result of the 2 numbers multiplied.
            Console.WriteLine($"{num1} x {num2} = {num1 * num2}");

            //Leave this part.
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        /*----- Task 1B -----*/
        static float MultiplyNumsExtended (float _num1, float _num2)
        {
            return _num1 * _num2;
        }
    }

    /*----- Task 1C -----*/
    class Math
    {
        public float MultiplyNums(float _num1, float _num2)
        {
            return _num1 * _num2;
        }

        /*----- Task 1D -----*/
        public float DivideNums(float _num1, float _num2)
        {
            return _num1 / _num2;
        }
        public float AddNums(float _num1, float _num2)
        {
            return _num1 + _num2;
        }
        public float SubtractNums(float _num1, float _num2)
        {
            return _num1 - _num2;
        }
    }
}

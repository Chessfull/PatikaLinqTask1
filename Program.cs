using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaLinqTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ▼ Creating List with random 10 numbers ▼
            List<int> numberList = new List<int>();
            Random random = new Random();
            for(int i = 1; i <= 10; i++)
            {
                int randomNumber= random.Next(-15, 22);
                numberList.Add(randomNumber);
            }

            // ▼ Even Numbers ▼
            Console.WriteLine("Even Numbers:");
            List<int> evenNumbers = numberList.Where(I => I % 2 == 0).ToList();
            evenNumbers.ForEach(Console.WriteLine);

            // ▼ Odd Numbers ▼
            Console.WriteLine("Odd Numbers:");
            List<int> oddNumbers = numberList.Where(I => I % 2 != 0).ToList();
            oddNumbers.ForEach(Console.WriteLine);

            // ▼ Negative Numbers ▼
            Console.WriteLine("Negative Numbers:");
            List<int> negativeNumbers = numberList.Where(I => I< 0).ToList();
            negativeNumbers.ForEach(Console.WriteLine);

            // ▼ Positive Numbers ▼
            Console.WriteLine("Positive Numbers:");
            List<int> positiveNumbers = numberList.Where(I => I > 0).ToList();
            positiveNumbers.ForEach(Console.WriteLine);

            // ▼ Bigger than 15 and less than 22 ▼
            Console.WriteLine("Numbers bigger than 15 and less than 22:");
            List<int> filterNumber=numberList.Where(I => I > 15&&I<22).ToList();
            filterNumber.ForEach(Console.WriteLine);

            // ▼ Square of each numbers in list ▼
            Console.WriteLine("Square of each numbers in list:");
            List<double> squareNumbers=numberList.Select(I => Math.Pow(I,2)).ToList();
            List<double> orderedList=squareNumbers.OrderBy(number=>number).ToList();
            orderedList.ForEach(Console.WriteLine);
        }
    }
}

using System;

namespace EvenArray

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any number greater than zero: ");
            int count = int.Parse(Console.ReadLine());

            int[] result = GetFirstEvenNumbers(count);

            Console.WriteLine("Your numbers: ");

            foreach (var item in result)
            {
                Console.Write(item.ToString() + " ");
            }
        }

        public static int[] GetFirstEvenNumbers(int count)
        {
            int[] array = new int[count];
            int evenNumber = 2;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = evenNumber;
                evenNumber += 2;
            }

            return array;
        }
    }
}

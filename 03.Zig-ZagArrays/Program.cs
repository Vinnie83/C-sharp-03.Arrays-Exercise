namespace _03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            bool isFirstSelected = true;
            string[] arr1 = new string[n]; 
            string[] arr2 = new string[n]; 

            for (int i = 0; i < n; i++)
            {
                string numbers = Console.ReadLine();

                string[] numbersAsArray = numbers.Split(" ");

                if (isFirstSelected)
                {
                    arr1[i] = numbersAsArray[0];
                    arr2[i] = numbersAsArray[1];

                }
                else
                {
                    arr1[i] = numbersAsArray[1];
                    arr2[i] = numbersAsArray[0];
                }

                isFirstSelected = !isFirstSelected;

            }

            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine(string.Join(" ", arr2));

        }
    }
}
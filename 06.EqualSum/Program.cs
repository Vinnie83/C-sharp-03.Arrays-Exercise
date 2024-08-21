namespace _06.EqualSum
{
    internal class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                index = -1;
                int leftSum = 0;
                int rightSum = 0;

                for (int j = i - 1; j >= 0; j--)
                {
                    leftSum += arr[j];
                    
                }

                for (int j = i + 1; j < arr.Length; j++)
                {
                    rightSum += arr[j];
                }

                if (leftSum == rightSum)
                {
                    index = i;
                    break;
                }
                
            }
            if (index != -1)
            { 
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("no");
            }


        }
    }
}
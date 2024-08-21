namespace _02.CommonElements
{
    internal class Program
    {
        static void Main()
        {

            string input1 = Console.ReadLine();
            string[] arr1 = input1.Split();

            string input2 = Console.ReadLine();
            string[] arr2 = input2.Split();


            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr1[j] == arr2[i])
                    {
                        Console.Write($"{arr1[j]} ");
                        break;
                    }

                }
                
            }

            
        }
    }
}
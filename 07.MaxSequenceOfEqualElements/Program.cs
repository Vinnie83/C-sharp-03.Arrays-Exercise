namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main()
        {
            string[] symbols = Console.ReadLine().Split();
            int bestSum = 0;
            string bestSumSymbols = "";            
               
            
            for (int i = symbols.Length - 1; i >= 0 ; i--)
            {

                int sum = 1;

                for (int j = i - 1; j >= 0; j--)
                {

                    if (symbols[i] == symbols[j])
                    {
                        sum++;
                        if (bestSum <= sum)
                        {
                            bestSum = sum;
                            bestSumSymbols = symbols[i];
                        }
                        
                    }
                    else
                    {
                        break;
                    }
                }


            }

            for (int i = 0; i < bestSum ; i++)
            { 
                Console.Write($"{bestSumSymbols} ");

            }
            

        }
    }
}
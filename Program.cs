namespace Challenge4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This app with inform you how many occurance of each distinct element occur in an array");
            Console.WriteLine("Input number of elements in array");
            int elements = Convert.ToInt32(Console.ReadLine());
            string[] userArray = new string[elements];
            for (int i = 0; i < elements; i++)
            {
                Console.WriteLine($"Input element for index {i}");
                userArray[i] = Console.ReadLine(); 
            }

            Dictionary<string, int> frequencyCounter = new Dictionary<string, int>();
            int k = 0;
            for (int i = 0;i < elements; i++)
            {
                
                    if (frequencyCounter.ContainsKey(userArray[i]))
                    {
                        frequencyCounter[userArray[i]]++;
                    }
                    else
                    {
                        frequencyCounter.Add(userArray[i], 1);
                    }

                
            }

            foreach (KeyValuePair<string, int> kvp in frequencyCounter)
            {
                Console.WriteLine($"{kvp.Key} occurs {kvp.Value} time(s)");
            }

        }
    }
}

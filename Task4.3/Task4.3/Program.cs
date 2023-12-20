namespace Task4._3;

class Program
{
    static void Main(string[] args)
    {
        List<int> num = new List<int>();
        try
        {
            
            do
            {

                int num1 = '\0';
               
                Console.WriteLine("Enter the number in my list :");
                num1 = Convert.ToInt32(Console.ReadLine());
                
                if (num.Contains(num1))
                {
                     throw new Exception("Duplicate numbers found in the list.");
                }
                
                num.Add(num1);

                Console.WriteLine($"{num1} add the number  to list");
            } while (true);
           
        }
           
      
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        
    }
}


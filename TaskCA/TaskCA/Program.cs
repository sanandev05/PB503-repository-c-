namespace TaskCA
{
    internal class Program
    {
        // SANAN HUSEYNOV 
        static void Main(string[] args)
        {
            Console.WriteLine("1-100 3-e ve 5-e bölünenler:");
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i);
                }

            }


            Console.Write("\nBalinizi daxil edin:");
            int av = Convert.ToInt32(Console.ReadLine());
           

           
            if (av < 65)
            {
                Console.WriteLine("Kesildin");
            }
            else if (av > 64 && av < 86)
            {
                Console.WriteLine("Adi Diplom");
            }
            else if (av > 85 && av < 96)
            {
                Console.WriteLine("Şeref Diplomu");
            }
            else
            {
                Console.WriteLine("Yüksek Şeref Diplomu");
            }

        }
    }
}

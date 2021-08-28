using System;

namespace AKUc101

{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many students?");
            int ST = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i<=ST;i++)
            {
                Console.WriteLine("Name");
                var Name = Console.ReadLine();

                Console.WriteLine("Degree");
                int De = Convert.ToInt32(Console.ReadLine());


                if (De >= 60)
                {
                    Console.WriteLine( "Passed");

                }
                else
                {
                    Console.WriteLine( "Failed");
                }
            }


            



            








        }
    }
}

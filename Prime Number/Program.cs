

namespace Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            long NumberInt,Result,Index=0;

            System.Console.WriteLine("         ========================SHOW PRIME NUMBER========================");

            System.Console.WriteLine();

            System.Console.Write
                ("Please Enter Number: ");

            NumberInt=System.Convert.ToInt64
                (System.Console.ReadLine());

            System.Console.WriteLine();

            for (int i = 1; i <= NumberInt; i++)
            {
                Result = NumberInt % i;

                if (Result==0)
                {
                    Index=Index+1;

                    System.Console.WriteLine("Separable is:" + i);

                    System.Console.WriteLine();
                }                

            }

            if (Index > 2)
            {

                System.Console.WriteLine
                    ("The number " + NumberInt + " is not Prime Number");

                System.Console.WriteLine();
            }
            else
            {

                System.Console.WriteLine
                    ("The number " + NumberInt + " is Prime Number");

                System.Console.WriteLine();

            }

            

            System.Console.Write
                ("Please [ENTER] To Exit... ");

            System.Console.ReadLine();
        }
    }
}

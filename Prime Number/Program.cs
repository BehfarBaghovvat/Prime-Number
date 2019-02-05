

namespace Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            long numberInt,result,index=0;

            System.Console.WriteLine("         ========================SHOW PRIME NUMBER========================");

            System.Console.WriteLine();

            System.Console.Write
                ("Please Enter Number: ");

            numberInt=System.Convert.ToInt64
                (System.Console.ReadLine());

            System.Console.WriteLine();

            for (int i = 1; i <= numberInt; i++)
            {
                result = numberInt % i;

                if (result==0)
                {
                    index=index+1;

                    System.Console.WriteLine("Separable is:" + i);

                    System.Console.WriteLine();
                }                

            }

            if (index > 2)
            {

                System.Console.WriteLine
                    ("The number " + numberInt + " is not Prime Number");

                System.Console.WriteLine();
            }
            else
            {

                System.Console.WriteLine
                    ("The number " + numberInt + " is Prime Number");

                System.Console.WriteLine();

            }           

            System.Console.Write
                ("Please [ENTER] To Exit... ");

            System.Console.ReadLine();
        }
    }
}

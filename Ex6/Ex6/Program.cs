namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double i, fat;


            Console.WriteLine("Digite um número inteiro: ");

            fat = Convert.ToDouble(Console.ReadLine());

            i = fat;

            while (i > 1)
            {
                i = i - 1;
                fat = fat * i;
            };


            if (fat > 0)
            {
                Console.WriteLine(fat);
            }
            else if (fat == 0)
            {
                Console.WriteLine("1");
            }

            else
            {
                Console.WriteLine("Digite um número positivo!");
            }
            Console.ReadKey();



        }
    }
}

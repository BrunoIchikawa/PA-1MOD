namespace EX8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, i, n;
            n1 = 0;
            n2 = 1;
            n = 20;

            Console.Write(n1 + " " + n2 + " ");


            for (i = 0; i < n;i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }

        }
    }
}

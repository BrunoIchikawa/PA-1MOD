namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Digite a idade do atleta:");
            int idade = int.Parse(Console.ReadLine());

            string categoria;

            if (idade >= 5 && idade <= 10)
            {
                categoria = "Infantil";
            }
            else if (idade >= 11 && idade <= 15)
            {
                categoria = "Juvenil";
            }
            else if (idade >= 16 && idade <= 20)
            {
                categoria = "Júnior";
            }
            else if (idade >= 21 && idade <= 25)
            {
                categoria = "Profissional";
            }
            else
            {
                categoria = "Categoria não encontrada";
            }

            Console.WriteLine($"O atleta de {idade} anos está na categoria {categoria}.");
        }
    }

}

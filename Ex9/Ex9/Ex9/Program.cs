namespace Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int mes;

            Console.WriteLine("Digite um número de 1 a 12:");
            mes = Convert.ToInt32(Console.ReadLine());

            string nomeMes;
            switch (mes)
            {
                case 1:
                    nomeMes = "Janeiro";
                    break;
                case 2:
                    nomeMes = "Fevereiro";
                    break;
                case 3:
                    nomeMes = "Março";
                    break;
                case 4:
                    nomeMes = "Abril";
                    break;
                case 5:
                    nomeMes = "Maio";
                    break;
                case 6:
                    nomeMes = "Junho";
                    break;
                case 7:
                    nomeMes = "Julho";
                    break;
                case 8:
                    nomeMes = "Agosto";
                    break;
                case 9:
                    nomeMes = "Setembro";
                    break;
                case 10:
                    nomeMes = "Outubro";
                    break;
                case 11:
                    nomeMes = "Novembro";
                    break;
                case 12:
                    nomeMes = "Dezembro";
                    break;
                case 13:
                    nomeMes = "fAZ O L kkkkkkk";
                    break;
                default:
                    nomeMes = "Mes invalido";
                    break;
            }
            Console.WriteLine(nomeMes);
        }
    }
}

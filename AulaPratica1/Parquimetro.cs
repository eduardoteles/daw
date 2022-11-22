
static class Parquimetro
{
    private static void Main(string[] args)
    {
        const double min = 0.25;
        const double max = 2;
        double saldo = 0;
        string escolha;
        Boolean finish = false;

        Console.WriteLine("Introduza a moeda");
        saldo = saldo + double.Parse(Console.ReadLine());
        while (finish==false)
        {
            Console.WriteLine("Deseja introduzir mais moedas (S/N)?");
            escolha = Console.ReadLine();
            if (escolha == "N")
            {
                if(saldo > min && saldo <max)
                {
                    Console.WriteLine("O seu bilhete tem o saldo de {0} euros", saldo);
                    finish = true;
                }
                else
                {
                    Console.WriteLine("O valor tem de ser > 0.25€ e até 2€. Recolha o seu troco");
                    finish = true;
                }
            }
            else if(escolha == "S" && finish==false)
            {
                Console.WriteLine("Introduza a moeda");
                saldo = saldo + double.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Decida-se!!");
            }
        }
    }
}
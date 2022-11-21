/*
    * Escreva um programa para verificar se o número de entrada é par ou ímpar.
*/
static class Exercicio12
{
    private static void Main(string[] args)
    {
        string userInput1;
        int number;

        Console.WriteLine("Por favor introduza um número:");
        userInput1 = Console.ReadLine();

        //Conversão de tipo de dados: string para int
        number = int.Parse(userInput1);

        //Um número é par, se a divisão por 2 produz resto 0
        if(number%2 == 0)
        {
            Console.WriteLine("O número introduzido é par");
        }
        else
        {
            Console.WriteLine("O número introduzido é ímpar");
        }
        //Alternativas para simplificar a verificação condicional?
    }
}
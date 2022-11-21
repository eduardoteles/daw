/*
    * Solicita a introdução de um número
    * Devolve o número introduzido dividido por 2
*/
static class Exercicio3
{
    private static void Main(string[] args)
    {
        string userInput;
        int number;

        Console.WriteLine("Por favor introduza um número:");
        userInput = Console.ReadLine();

        //Conversão de tipo de dados: string para int
        number = int.Parse(userInput);

        //Output
        Console.WriteLine(number / 2);
    }
}
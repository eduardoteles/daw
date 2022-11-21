/*
    * Solicita a introdução de dois números
    * Devolve a soma, a diferença, o produto, o quociente e o resto da divisão.
*/
static class Exercicio5
{
    private static void Main(string[] args)
    {
        string userInput1;
        string userInput2;

        int number1;
        int number2;

        Console.WriteLine("Por favor introduza o primeiro número:");
        userInput1 = Console.ReadLine();

        Console.WriteLine("Por favor introduza o segundo número:");
        userInput2 = Console.ReadLine();

        //Conversão de tipo de dados: string para int
        number1 = int.Parse(userInput1);
        number2 = int.Parse(userInput2);

        //Output
        Console.WriteLine("A soma dos números é " + (number1 + number2));
        Console.WriteLine("A diferença dos números é " + (number1 - number2));
        Console.WriteLine("O produto dos números é " + (number1 * number2));
        Console.WriteLine("O quociente dos números é " + (number1 / number2));
        Console.WriteLine("O resto da divisão dos números é " + (number1 % number2));
    }
}
/*
    * Solicita a introdução de dois números
    * Devolve a soma dos números introduzidos
*/
static class Exercicio4
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
        int sum = number1 + number2;

        //Output
        Console.WriteLine("A soma de " + number1 + " e " + number2 + " é " + (number1+number2));
        //Alternativa
        //Console.WriteLine("A soma de {0} e {1} é {2}", number1, number2, sum);
    }
}
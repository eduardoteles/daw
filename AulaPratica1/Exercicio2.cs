//Escreve as operações aritméticas descritas no exercício 2
static class Exercicio2
{
    private static void Main(string[] args)
    {
        int number1 = 7;
        int number2 = 3;
        int number3 = 5;
        double decimalNumber1 = 7.0;
        double decimalNumber2 = 7.0;

        Console.WriteLine(number1 + number2);
        Console.WriteLine(number1 - number2);
        Console.WriteLine(number1 * number2);
        Console.WriteLine(number1 / number1);
        Console.WriteLine(decimalNumber1 / decimalNumber2);
        Console.WriteLine(number1 % number2);
        Console.WriteLine(number1 + number2 * number3);
        Console.WriteLine((number1 + number2) * number3);
    }
}
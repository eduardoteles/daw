/*
    * Escreva um programa que retorne o número de faltas que pode dar no curso.
    * Dica: deverá frequentar 90% das aulas
*/
static class Exercicio10
{
    private static void Main(string[] args)
    {
        string userInput1;
        int numberClasses;

        Console.WriteLine("Por favor introduza quantas aulas constam da unidade curricular:");
        userInput1 = Console.ReadLine();

        //Conversão de tipo de dados: string para int
        numberClasses = int.Parse(userInput1);

        //Output
        Console.WriteLine("Poderá realizar um máximo de " + (numberClasses - ((90 * numberClasses) / 100)) + " falta(s)!");
    }
}
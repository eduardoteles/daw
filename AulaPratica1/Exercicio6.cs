/*
    * Solicita a introdução do raio de um círculo
    * calcula a sua área e volume (πr2) (4/3) πr3. Defina PI como constante.
*/
static class Exercicio6
{
    private static void Main(string[] args)
    {
        string userInput1;
        int radius;
        const double Pi = Math.PI;

        Console.WriteLine("Por favor introduza o raio do círculo:");
        userInput1 = Console.ReadLine();

        //Conversão de tipo de dados: string para int
        radius = int.Parse(userInput1);
        
        //verificação
        while(radius < 0)
        {
            Console.WriteLine("Por favor introduza o raio do círculo:");
            userInput1 = Console.ReadLine();
            radius = int.Parse(userInput1);
        }
        Console.WriteLine("A área do círculo é " + Pi * (radius * radius));

        //Output
        //Console.WriteLine("A área do círculo é " + Pi * (radius * radius));
        //Console.WriteLine("O volume do círculo é " + (4/3) * (Pi*(radius * radius * radius)));
        //Alternativas utilizando a class Math e método Pow(potência)
        //Console.WriteLine("A área do círculo é " + Pi * Math.Pow(radius,2));
        //Console.WriteLine("O volume do círculo é " + (4 / 3) * (Pi * Math.Pow(radius, 3)));
    }
}
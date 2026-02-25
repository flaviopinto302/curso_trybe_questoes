class Program
{
    static void Main()
    {
        Console.Write("Digite uma palavra: ");
        string entrada = Console.ReadLine().ToLower().Replace(" ", "");

        string reverso = new string(entrada.Reverse().ToArray());

        if (entrada == reverso)
            Console.WriteLine("É um palíndromo!");
        else
            Console.WriteLine("Não é um palíndromo.");
    }
}

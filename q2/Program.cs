class JogoAdivinhacao
{
    static void Main()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 1001); // número entre 1 e 1000
        int tentativa;

        Console.WriteLine("Tente adivinhar o número entre 1 e 1000.");

        do
        {
            Console.Write("\nDigite sua tentativa: ");
            tentativa = int.Parse(Console.ReadLine());

            int diferenca = Math.Abs(numeroSecreto - tentativa);

            if (tentativa == numeroSecreto)
            {
                Console.WriteLine("Parabéns! Você acertou!");
                break;
            }
            else
            {
                if (diferenca > 100)
                    Console.WriteLine("Muito distante!");
                else if (diferenca > 50)
                    Console.WriteLine("Distante!");
                else
                    Console.WriteLine("Perto!");

                Console.WriteLine(tentativa < numeroSecreto ? "O número é MAIOR." : "O número é MENOR.");
            }

        } while (true);
    }
}

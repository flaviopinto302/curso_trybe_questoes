class Program
{
    static void Main()
    {
        string palavra = "banana";
        char[] resposta = new string('_', palavra.Length).ToCharArray();
        List<char> letrasErradas = new List<char>();
        int tentativas = 6;

        while (tentativas > 0 && new string(resposta) != palavra)
        {
            Console.Clear();
            Console.WriteLine("Palavra: " + string.Join(" ", resposta));
            Console.WriteLine("Tentativas restantes: " + tentativas);
            Console.WriteLine("Letras erradas: " + string.Join(", ", letrasErradas));
            Console.Write("Digite uma letra: ");
            char letra = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (palavra.Contains(letra))
            {
                for (int i = 0; i < palavra.Length; i++)
                    if (palavra[i] == letra)
                        resposta[i] = letra;
            }
            else
            {
                if (!letrasErradas.Contains(letra))
                {
                    letrasErradas.Add(letra);
                    tentativas--;
                }
            }
        }

        if (new string(resposta) == palavra)
            Console.WriteLine("Parabéns! Você acertou: " + palavra);
        else
            Console.WriteLine("Você perdeu! A palavra era: " + palavra);
    }
}

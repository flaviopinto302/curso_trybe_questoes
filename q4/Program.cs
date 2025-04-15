class Program
{
    static void Main()
    {
        List<Aluno> alunos = new List<Aluno>();
        string continuar;

        do
        {
            Console.Write("Nome do aluno: ");
            string nome = Console.ReadLine();

            Console.Write("Nota do aluno: ");
            double nota = double.Parse(Console.ReadLine());

            alunos.Add(new Aluno { Nome = nome, Nota = nota });

            Console.Write("Deseja adicionar outro aluno? (s/n): ");
            continuar = Console.ReadLine().ToLower();
        } while (continuar == "s");

        double media = alunos.Average(a => a.Nota);

        Console.WriteLine($"\nMédia da turma: {media:F2}");
        Console.WriteLine("Alunos acima da média:");

        foreach (var aluno in alunos.Where(a => a.Nota > media))
            Console.WriteLine($"{aluno.Nome} - Nota: {aluno.Nota}");
    }
}

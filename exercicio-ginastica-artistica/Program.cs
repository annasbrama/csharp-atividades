//Em uma competição de ginástica artística a pontuação de um(a) ginasta é dada pela soma de sua nota de partida com a nota de execução dada pela banca de jurados.
//Faça um programa que receba o nome do(a) ginasta, a nota de partida e a nota de execução. Exiba a nota final.

double notaPartida, notaExecucao, resultado;

Console.WriteLine("Nome da ginasta: ");
string ginasta = Console.ReadLine()!;
Console.WriteLine("Nota de partida: ");
notaPartida = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Nota de execução: ");
notaExecucao = Convert.ToDouble(Console.ReadLine()!);
resultado = notaPartida + notaExecucao;
Console.WriteLine($"A {ginasta} teve {resultado:N3} como sua nota final!");
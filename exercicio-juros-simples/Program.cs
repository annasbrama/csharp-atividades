//Calcule o montante final de um investimento a juros simples.
decimal c, i, t, j, m;

Console.WriteLine("Olá. Qual será o valor do seu investimento? ");
c = Convert.ToDecimal(Console.ReadLine()!);
Console.WriteLine("Qual taxa de juros você deseja");
i = Convert.ToDecimal(Console.ReadLine()!);
Console.WriteLine("E quanto tempo que pretende que renda o investimento?");
t = Convert.ToDecimal(Console.ReadLine()!);
j = c * (i / 100) * t;
m = c + j;
Console.WriteLine($"O juros fica em {j:N2} e o montante fica em {m:N2}.");
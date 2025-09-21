//Média Aritmética - Receba três números, converter as entradas em números (int, decimal, double?) e realizar a média em 3.
decimal num1, num2, num3, media;
Console.WriteLine("Vamos criar a média da soma de três números. Digite o primeiro número: ");
num1 = Convert.ToDecimal(Console.ReadLine()!);
Console.WriteLine("Digite o segundo número: ");
num2 = Convert.ToDecimal(Console.ReadLine()!);
Console.WriteLine("Digite o terceiro número: ");
num3 = Convert.ToDecimal(Console.ReadLine()!);
media = (num1 + num2 + num3) / 3;
Console.WriteLine($"A média dos três números é {media:N1}!");
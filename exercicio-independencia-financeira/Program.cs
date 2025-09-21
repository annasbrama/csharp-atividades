//Faça um programa que calcule quanto dinheiro é necessário possuir em um investimento para conseguir sua independência financeira com dividendos (ou seja, os dividendos deverão pagar todos os seus custos). Receba os gastos mensais e o rendimento dos dividendos (dividend yield). O valor necessário investido para receber X reais de dividendo todo mês com Y% de dividend yield é X ÷ (Y ÷ 100).

decimal gastos, dividendo, investimento;

Console.WriteLine("Quais são os gastos mensais? ");
gastos = Convert.ToDecimal(Console.ReadLine()!);
Console.WriteLine("E quais são os rendimentos mensais? ");
dividendo = Convert.ToDecimal(Console.ReadLine()!);
investimento = gastos / (dividendo / 100);

Console.WriteLine($"Com o valor de {gastos} e com o rendimento de {dividendo}, o valor do investimento terá que ser de {investimento:N3}");
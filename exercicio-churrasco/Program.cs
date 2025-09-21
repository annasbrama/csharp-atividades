// Faça um programa que calcule a quantidade de itens necessários para um churrasco a partir da quantidade de adultos (que consomem e que não consomem bebidas alcoólicas) e de crianças.
// Item 	          Por adulto 	Por criança
// Carne 	              400g 	        200g
// Acompanhamentos 	      200g 	        200g
// Cerveja 	               2l 	         --
// Refrigerante 	      500ml 	    500ml
// Água 	              400ml 	    400ml

// Estime cerveja e refrigerantes de acordo com a indicação de consumo dos adultos. Estime refrigerante para todas as crianças. Estime água para todos.

int adultos, criancas, pessoas, adultosSemAlcool, adultosComAlcool;
double carne, cerveja, agua, refrigerante, acompanhamentos;

Console.WriteLine("Quantos adultos consomem alcóol? ");
adultosComAlcool = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("Quantos adultos NÃO consomem alcóol? ");
adultosSemAlcool = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("Quantas crianças virão ao churrasco? ");
criancas = Convert.ToInt32(Console.ReadLine()!);

adultos = adultosComAlcool + adultosSemAlcool;
pessoas = adultos + criancas;

carne = 0.4 * adultos + 0.2 * criancas;
acompanhamentos = 0.2 * pessoas;
cerveja = 2 * adultosComAlcool;
agua = 0.4 * pessoas;
refrigerante = 0.5 * (adultosSemAlcool + criancas);

Console.WriteLine("O necessário para as compras serão: ");
Console.WriteLine($"Carne: {carne:N1}kg");
Console.WriteLine($"Acompanhamentos: {acompanhamentos:N1}kg");
Console.WriteLine($"Cerveja: {cerveja:N1}l");
Console.WriteLine($"Água: {agua:N1}l");
Console.WriteLine($"Refrigerante: {refrigerante:N1}l");
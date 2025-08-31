string nome = "Anna";
string sobrenome = "Sbrama";

// concatenação por operador
string nomeCompleto = nome + " " + sobrenome;
Console.WriteLine(nomeCompleto);

//concatenação com método Concat
string nomeConcat = String.Concat(nome, " ", sobrenome);
Console.BackgroundColor = (ConsoleColor)4;
Console.WriteLine(nomeConcat);
Console.ResetColor();

// interpolação
string nomeInter = $"{nome} {sobrenome}";
Console.BackgroundColor = (ConsoleColor)5;
Console.WriteLine(nomeInter);
Console.ResetColor();

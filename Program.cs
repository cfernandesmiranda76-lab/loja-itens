Console.WriteLine("Olá jogador!");

Console.WriteLine ("--------------------------------------------------");

Console.WriteLine ("Quantidade de moeda: ");
int moedas = int.Parse (Console.ReadLine ());

Console.WriteLine ("-------------------- COMPRAS --------------------");

Console.WriteLine ("-Cada poção custa 15 moedas");
Console.WriteLine();
Console.WriteLine ("Quantidade de poções: ");
int pocoes = int.Parse (Console.ReadLine ());

int valorPocao = 15;
Console.WriteLine ($"ValorTotal: {pocoes * valorPocao}");

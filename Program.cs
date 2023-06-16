
Console.WriteLine("--- Tabuada ---");

Console.Write("Digite qualquer número positivo para calcular a tabuada: ");
int tab = int.Parse(Console.ReadLine()!);

Console.WriteLine($"A tabuada do valor ({tab}) é:");

for (int i = 1; i <=10; i++ )
{
    int resultado = tab * i;
    Console.WriteLine($"{tab} x {i} = {resultado}");

}

Console.WriteLine("Pressione ENTER para continuar...");
Console.ReadLine();
return;

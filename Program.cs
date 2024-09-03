int num1, num2;
Console.WriteLine("--- Divisão exata/resto ---");


Console.WriteLine("Entre com o primeiro número: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Entre com o segundo número: ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 % num2 == 0)
{
    Console.WriteLine("Divisão Exata");
}
else
{
    Console.WriteLine("Divisão Não Exata");
}


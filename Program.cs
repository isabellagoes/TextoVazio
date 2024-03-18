Console.WriteLine("-------------------- Texto Vazio --------------------\n");

Console.Write("Digite um texto a fim de avaliá-lo como vazio ou não: ");
string texto = Console.ReadLine()!;

Console.WriteLine("\nFalse: Texto");
Console.WriteLine("True: Vazio\n");

Console.WriteLine(String.IsNullOrEmpty(texto.Trim()));
// See https://aka.ms/new-console-template for more information
using ConsoleApp;

Console.WriteLine("Presione una tecla");
Console.ReadKey();

var obj = new Metodos();
await obj.EnviarPostAsync();
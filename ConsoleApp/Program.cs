// See https://aka.ms/new-console-template for more information
using ConsoleApp;
using Entidades;

Console.WriteLine("Presione una tecla");
Console.ReadKey();

var meodos = new Metodos();
 await meodos.EnviarMail();

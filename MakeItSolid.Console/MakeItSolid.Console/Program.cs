using MakeItSolid.Console;
using System.Diagnostics;

namespace MakeItSolid
{
    class Program
    {
        static void Main(string[] args)
        {
            string optionControl = "0";
            do
            {
                System.Console.WriteLine("Escolha uma opção: \n 0 - Sair \n 1- SRP");
                optionControl = System.Console.ReadLine();
                System.Console.Clear();

                switch (optionControl)
                {
                    case "1":

                        #region Using Code For Single Responsibility Principle
                        Journal j = new Journal();
                        j.AddEntry("I cried Today");
                        j.AddEntry("I ate a bug");
                        System.Console.WriteLine(j);

                        var p = new Persistence();
                        var filename = @"C:\Users\87018\Source\Repos\MakeItSolid\MakeItSolid.Console\MakeItSolid.Console\Single Responsibility Principle\journal.txt";
                        p.SaveToFile(j, filename);
                        Process.Start(filename);
                        #endregion
                        break;

                    case "0":
                        System.Console.WriteLine("Saindo...");
                        break;

                    default:
                        System.Console.WriteLine("Opção Inválida");
                        break;
                }

                System.Console.ReadKey();
                System.Console.Clear();
            }
            while (optionControl != "0");
        }
    }
}

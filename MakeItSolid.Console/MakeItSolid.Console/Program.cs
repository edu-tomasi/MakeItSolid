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
                System.Console.WriteLine("Escolha uma opção: \n 0- Sair \n 1- SRP \n 2- OCP");
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

                    case "2":
                        #region Using Code For Open-Close Principle
                        var apple = new Product("Apple", Color.Green, Size.Small);
                        var tree = new Product("Tree", Color.Green, Size.Large);
                        var house = new Product("House", Color.Blue, Size.Large);
                        Product[] products = { apple, tree, house };
                        var pf = new ProductFilter();
                        System.Console.WriteLine("Green Products (Old):");
                        foreach (var product in pf.FilterByColor(products, Color.Green))
                        {
                            System.Console.WriteLine($" - {product.Name} is green;");
                        }
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

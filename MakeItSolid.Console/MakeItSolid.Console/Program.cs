using MakeItSolid.Console;
using System.Diagnostics;

namespace MakeItSolid
{
    class Program
    {
        static public int Area(Rectangle r) => r.Width * r.Height;
        static void Main(string[] args)
        {
            string optionControl = "0";
            do
            {
                System.Console.WriteLine("Escolha uma opção: \n 0- Sair \n 1- SRP \n 2- OCP \n 3- LSP \n 4- ISP");
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
                        //var pf = new ProductFilter();
                        var bf = new BetterFilter();
                        System.Console.WriteLine("Green Products (New):");
                        //foreach (var product in pf.FilterByColor(products, Color.Green))
                        foreach (var product in bf.Filter(products, new ColorSpecification(Color.Green)))
                        {
                            System.Console.WriteLine($" - {product.Name} is green;");
                        }

                        System.Console.WriteLine("Large Blue Item: ");
                        foreach (var product in bf.Filter(products, new AndSpecification<Product>(new ColorSpecification(Color.Blue), new SizeSpecification(Size.Large))))
                        {
                            System.Console.WriteLine($" - {product.Name} is big and blue");
                        }
                        #endregion
                        break;

                    case "3":
                        #region Using Code for Liskov Substitution Principle
                        Rectangle rc = new Rectangle(2, 3);
                        System.Console.WriteLine($"{rc} has area {Area(rc)}");

                        Square sq = new Square();
                        sq.Width = 4;
                        System.Console.WriteLine($"{sq} has area {Area(sq)}");
                        #endregion
                        break;

                    case "4":
                        #region Using Code for Interface Segregation Principle
                        MultiFunctionMachine mf = new MultiFunctionMachine(new Printer(), new Scanner());
                        Document doc = new Document();
                        mf.Print(doc);
                        mf.Scan(doc);
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

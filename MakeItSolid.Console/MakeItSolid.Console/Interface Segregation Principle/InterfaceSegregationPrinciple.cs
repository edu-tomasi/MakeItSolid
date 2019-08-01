﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeItSolid
{
    public class Document
    {

    }

    public interface IMachine
    {
        void Print(Document d);
        void Scan(Document d);
        void Fax(Document d);
    }

    public interface IPrinter
    {
        void Print(Document d);
    }

    public interface IScanner
    {
        void Scan(Document d);
    }

    public interface IMultiFunctionDevice : IScanner, IPrinter
    {

    }

    public class OldFashionedPrinter : IPrinter
    {
        public void Print(Document d)
        {
            //
        }
    }

    public class PhotoCopier : IScanner, IPrinter
    {
        public void Print(Document d)
        {
            throw new NotImplementedException();
        }

        public void Scan(Document d)
        {
            throw new NotImplementedException();
        }
    }

    public class Printer : IPrinter
    {
        public void Print(Document d)
        {
            System.Console.WriteLine($"Printing document: {nameof(d)}.");
        }
    }

    public class Scanner : IScanner
    {
        public void Scan(Document d)
        {
            System.Console.WriteLine($"Scanning document: {nameof(d)}.");
        }
    }

    public class MultiFunctionMachine : IMultiFunctionDevice
    {
        private IPrinter printer;
        private IScanner scanner;

        public MultiFunctionMachine(IPrinter printer, IScanner scanner)
        {
            if (printer == null)
            {
                throw new ArgumentNullException(paramName: nameof(printer));
            }
            if (scanner == null)
            {
                throw new ArgumentNullException(paramName: nameof(scanner));
            }

            this.printer = printer;
            this.scanner = scanner;
        }

        public void Print(Document d)
        {
            printer.Print(d);
        }

        public void Scan(Document d)
        {
            scanner.Scan(d);
        }
    }
}

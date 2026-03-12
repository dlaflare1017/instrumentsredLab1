using System;

namespace DocumentFactoryMethodSystem
{
    abstract class Document
    {
        public abstract void Open();
        public abstract void Save();
        public abstract void Close();
    }

    class WordDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("Открыт Word-документ");
        }

        public override void Save()
        {
            Console.WriteLine("Сохранён Word-документ");
        }

        public override void Close()
        {
            Console.WriteLine("Закрыт Word-документ");
        }
    }

    class PdfDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("Открыт PDF-документ");
        }

        public override void Save()
        {
            Console.WriteLine("Сохранён PDF-документ");
        }

        public override void Close()
        {
            Console.WriteLine("Закрыт PDF-документ");
        }
    }

    class ExcelDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("Открыт Excel-документ");
        }

        public override void Save()
        {
            Console.WriteLine("Сохранён Excel-документ");
        }

        public override void Close()
        {
            Console.WriteLine("Закрыт Excel-документ");
        }
    }

    // Creator
    abstract class DocumentCreator
    {
        public abstract Document FactoryMethod();
    }

    // ConcreteCreatorA
    class WordDocumentCreator : DocumentCreator
    {
        public override Document FactoryMethod()
        {
            return new WordDocument();
        }
    }

    // ConcreteCreatorB
    class PdfDocumentCreator : DocumentCreator
    {
        public override Document FactoryMethod()
        {
            return new PdfDocument();
        }
    }

    // ConcreteCreatorC
    class ExcelDocumentCreator : DocumentCreator
    {
        public override Document FactoryMethod()
        {
            return new ExcelDocument();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DocumentCreator creator;
            Document document;

            creator = new WordDocumentCreator();
            document = creator.FactoryMethod();
            document.Open();
            document.Save();
            document.Close();

            Console.WriteLine();

            creator = new PdfDocumentCreator();
            document = creator.FactoryMethod();
            document.Open();
            document.Save();
            document.Close();

            Console.WriteLine();

            creator = new ExcelDocumentCreator();
            document = creator.FactoryMethod();
            document.Open();
            document.Save();
            document.Close();
        }
    }
}
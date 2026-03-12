using System;

abstract class Document
{
    public string Name { get; }

    protected Document(string name)
    {
        Name = name;
    }

    public abstract void Open();
    public abstract void Save();
    public abstract void Close();
}

// Конкретные классы документов
class WordDocument : Document
{
    public WordDocument(string name) : base(name) { }

    public override void Open() => Console.WriteLine($"Открытие Word документа: {Name}");
    public override void Save() => Console.WriteLine($"Сохранение Word документа: {Name}");
    public override void Close() => Console.WriteLine($"Закрытие Word документа: {Name}");
}

class PdfDocument : Document
{
    public PdfDocument(string name) : base(name) { }

    public override void Open() => Console.WriteLine($"Открытие PDF документа: {Name}");
    public override void Save() => Console.WriteLine($"Сохранение PDF документа: {Name}");
    public override void Close() => Console.WriteLine($"Закрытие PDF документа: {Name}");
}

class ExcelDocument : Document
{
    public ExcelDocument(string name) : base(name) { }

    public override void Open() => Console.WriteLine($"Открытие Excel документа: {Name}");
    public override void Save() => Console.WriteLine($"Сохранение Excel документа: {Name}");
    public override void Close() => Console.WriteLine($"Закрытие Excel документа: {Name}");
}
enum DocumentType
{
    Word,
    Pdf,
    Excel
}

// Фабрика документов порождающий паттерн
static class DocumentFactory
{
    public static Document CreateDocument(DocumentType type, string name)
    {
        switch (type)
        {
            case DocumentType.Word:
                return new WordDocument(name);
            case DocumentType.Pdf:
                return new PdfDocument(name);
            case DocumentType.Excel:
                return new ExcelDocument(name);
            default:
                throw new ArgumentOutOfRangeException(nameof(type), "Неизвестный тип документа");
        }
    }
}

// Пример использования
class Program
{
    static void Main(string[] args)
    {
        Document doc1 = DocumentFactory.CreateDocument(DocumentType.Word, "Отчёт.docx");
        Document doc2 = DocumentFactory.CreateDocument(DocumentType.Pdf, "Презентация.pdf");
        Document doc3 = DocumentFactory.CreateDocument(DocumentType.Excel, "Таблица.xlsx");

        doc1.Open();
        doc1.Save();
        doc1.Close();

        Console.WriteLine();

        doc2.Open();
        doc2.Save();
        doc2.Close();

        Console.WriteLine();

        doc3.Open();
        doc3.Save();
        doc3.Close();
    }
}
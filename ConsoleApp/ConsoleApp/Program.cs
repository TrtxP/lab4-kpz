using ClassLibraryBehavioralPatterns.ChainOfResponsibility;
using ClassLibraryBehavioralPatterns.Memento;
using ClassLibraryBehavioralPatterns.Observer;
using ClassLibraryStructurePatterns.Composite.Classes;
using ClassLibraryStructurePatterns.Composite.Enums;
using DesignPatterns.Mediator;
using System.Text;
class Program
{
    static void Main()
    {
        // Демонстрування роботи шаблону ланцюжка обов'язків

        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine(new string('-', 50));
        Console.WriteLine("Демонстрація роботи шаблону ланцюжка обов'язків");
        Console.WriteLine(new string('-', 50));

        var level1 = new AutoInformerHandler();
        var level2 = new BillingHandler();
        var level3 = new TechHandler();
        var level4 = new ExpertHandler();

        level1.SetNext(level2).SetNext(level3).SetNext(level4);

        while(true)
        {
            Console.WriteLine("Пройдіть опитування пропозицій вибору операцій\n(Щоб почати натисніть Enter або введіть exit для виходу)\n");
            Console.Write(">>> ");

            string? request = Console.ReadLine();

            if (request?.ToLower() == "exit")
            {
                break;
            }

            if (request == "")
            {
                level1.Handle();
            }
        }

        Console.WriteLine(new string('-', 50));

        // Демонстрування шаблону посередник

        Console.WriteLine("Демонстрація роботи шаблону посередник");

        Console.WriteLine(new string('-', 50));

        var runway = new Runway();

        var aircraft1 = new Aircraft("Boeing 747", 80);
        var aircraft2 = new Aircraft("Airbus A320", 100);

        var center = new CommandCentre(new[] { runway }, new[] { aircraft1, aircraft2 });

        aircraft1.Land();
        aircraft2.Land();
        aircraft1.TakeOff();
        aircraft2.Land();

        if (runway.CheckIsActive())
        {
            Console.WriteLine($"Runway status: Busy");
        } else
        {
            Console.WriteLine($"Runway status: Free");
        }

        Console.WriteLine(new string('-', 50));

        // Демонстрування роботи шаблону спостерігач

        Console.WriteLine("Демонстрація роботи шаблону спостерігач");

        Console.WriteLine(new string('-', 50));

        var sender = new ConsoleEventListener();

        var span = new LightElementNode("span", DisplayType.Block, ClosingType.Normal);

        span.AddEventListener("click", sender);
        span.Click();

        var div = new LightElementNode("div", DisplayType.Block, ClosingType.Normal);
        div.AddEventListener("mouseover", sender);
        div.MouseOver();

        Console.WriteLine(new string('-', 50));

        // Демонстрування роботи шаблону стратегія

        Console.WriteLine("Демонстрація роботи шаблону стратегія");

        Console.WriteLine(new string('-', 50));

        var image = new LightImageNode();

        while (true)
        {
            Console.WriteLine("Виберіть спосіб задання джерелу зображення:\n1. URL\n2. Шлях до файлу\n3. Вихід");

            string? input = Console.ReadLine();

            if (input == "3")
            {
                break;
            }

            switch (input)
            {
                case "1":
                    Console.Write("Введіть URL зображення: ");
                    string? url = Console.ReadLine();
                    if (!string.IsNullOrEmpty(url))
                    {
                        image.SetSrc(url);
                        image.Load();
                        Console.WriteLine($"Зображення завантажено з URL: \n{image.OuterHTML()}");
                    }
                    break;
                case "2":
                    Console.Write("Введіть шлях до файлу зображення: ");
                    string? filePath = Console.ReadLine();
                    if (!string.IsNullOrEmpty(filePath))
                    {
                        image.SetSrc(filePath);
                        image.Load();
                        Console.WriteLine($"Зображення завантажено з файлового шляху: \n{image.OuterHTML()}");
                    }
                    break;
                default:
                    Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                    break;
            }
        }

        Console.WriteLine(new string('-', 50));

        // Демонстрування роботи шаблону мементо

        Console.WriteLine("Демонстрація роботи шаблону мементо");

        Console.WriteLine(new string('-', 50));

        var editor = new TextEditor();
        var history = new EditorHistory(editor);

        editor.Write("Hello, World!");
        history.Save();
        Console.WriteLine($"Current content: {editor.GetContent()}");
        history.Save();
        editor.Write(" This is a new line.");
        Console.WriteLine($"Current content: {editor.GetContent()}");
        history.Undo();
        history.Undo();
        Console.WriteLine($"After undo: {editor.GetContent()}");

        Console.WriteLine(new string('-', 50));
    }
}
 
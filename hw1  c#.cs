//Task1

public class Device
{
    protected string name;
    protected string description;

    public Device(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public virtual void Sound()
    {
    }

    public void Show()
    {
        Console.WriteLine("название устройства: " + name);
    }
    public void Desc()
    {
        Console.WriteLine("описание устройства: " + description);
    }
}

public class Kettle : Device
{
    public Kettle(string name, string description) : base(name, description) {}

    public override void Sound()
    {
        Console.WriteLine("(звук чайника)");
    }
}

public class Microwave : Device
{
    public Microwave(string name, string description) : base(name, description) {}

    public override void Sound()
    {
        Console.WriteLine("(звук микроволновки)");
    }
}


class Program
{
    static void Main(string[] args)
    {
        Device kettle = new Kettle("чайник", "электро чайник");
        Device microwave = new Microwave("микроволновка", "микроволновка 3000");
        kettle.Show();
        kettle.Sound();
        kettle.Desc();
        Console.WriteLine();
        microwave.Show();
        microwave.Sound();
        microwave.Desc();
    }
}






//Task2
//
// public class MusicalInstrument
// {
//     protected string name;
//     protected string description;
//     protected string history;
//
//     public MusicalInstrument(string name, string description, string history)
//     {
//         this.name = name;
//         this.description = description;
//         this.history = history;
//     }
//
//     public virtual void Sound(){}
//
//     public void Show()
//     {
//         Console.WriteLine("Название музыкального инструмента: " + name);
//     }
//
//     public void Desc()
//     {
//         Console.WriteLine("Описание музыкального инструмента: " + description);
//     }
//
//     public void History()
//     {
//         Console.WriteLine("История создания музыкального инструмента: " + history);
//     }
// }
//
// public class Violin : MusicalInstrument
// {
//     public Violin(string name, string description, string history) : base(name, description, history) { }
//
//     public override void Sound()
//     {
//         Console.WriteLine("Скрип-скрип (звук скрипки)");
//     }
// }
//
// public class Trombone : MusicalInstrument
// {
//     public Trombone(string name, string description, string history) : base(name, description, history) { }
//
//     public override void Sound()
//     {
//         Console.WriteLine("Тррррр (звук тромбона)");
//     }
// }
//
// public class Ukulele : MusicalInstrument
// {
//     public Ukulele(string name, string description, string history) : base(name, description, history) { }
//
//     public override void Sound()
//     {
//         Console.WriteLine("(звук укулеле)");
//     }
// }
//
// public class Cello : MusicalInstrument
// {
//     public Cello(string name, string description, string history) : base(name, description, history) { }
//
//     public override void Sound()
//     {
//         Console.WriteLine("(звук виолончели)");
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         MusicalInstrument violin = new Violin("Скрипка", "деревянный струнный инструмент", "Скрипка была известна еще в средние века");
//         MusicalInstrument trombone = new Trombone("Тромбон", "медный духовой инструмент", "Тромбон развился из средневекового медного музыкального инструмента");
//         MusicalInstrument ukulele = new Ukulele("Укулеле", "гавайский струнный инструмент", "Укулеле стало популярным в начале 20 века");
//         MusicalInstrument cello = new Cello("Виолончель", "большой струнный инструмент", "Виолончель развилась из старинного музыкального инструмента гамбы");
//
//         violin.Show();
//         violin.Sound();
//         violin.Desc();
//         violin.History();
//
//         Console.WriteLine();
//
//         trombone.Show();
//         trombone.Sound();
//         trombone.Desc();
//         trombone.History();
//
//         Console.WriteLine();
//
//         ukulele.Show();
//         ukulele.Sound();
//         ukulele.Desc();
//         ukulele.History();
//
//         Console.WriteLine();
//
//         cello.Show();
//         cello.Sound();
//         cello.Desc();
//         cello.History();
//     }
// }

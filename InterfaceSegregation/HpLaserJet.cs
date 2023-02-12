namespace InterfaceSegregation;

public class HpLaserJet : IPrinter, IFaxContent, IScanner
{
    public void PrintGray(string content)
    {
        Console.WriteLine("Hp laser jet print gray");
    }

    public void PrintColor(string content)
    {
        Console.WriteLine("Hp laser jet print color");    }

    public void Scan(string content)
    {
        Console.WriteLine("Hp laser jet print scan");
    }

    public void Fax(string content)
    {
        Console.WriteLine("Hp laser jet print fax");
    }
}
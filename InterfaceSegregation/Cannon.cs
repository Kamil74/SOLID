namespace InterfaceSegregation;

public class Cannon : IPrinter, IFaxContent
{
  

    public void PrintGray(string content)
    {
        Console.WriteLine("Cannon  print gray");
    }

    public void PrintColor(string content)
    {
        Console.WriteLine("Cannon  print color");
    }

    public void Scan(string content)
    {
        Console.WriteLine("Cannon  print scan");
    }


    public void Fax(string content)
    {
        Console.WriteLine("Cannon  print fax");
    }
}
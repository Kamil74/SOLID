namespace InterfaceSegregation;

public interface IPrinter
{
    void PrintGray(string content);
    void PrintColor(string content);
    void Scan(string content);
    void Fax(string content);
}

public interface IScanner
{
    void Scan(string content);
}

public interface IFaxContent
{
    void Fax(string content);
}
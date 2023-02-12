namespace LiskovSubstitution;

public class RubberDuck : Duck
{
    public override void Swim()
    {
        Console.WriteLine("Rubber duck swim");
    }

    public override void Quack()
    {
        Console.WriteLine("Rubber duck quack");
    }
    public override void Flay()
    {
        Console.WriteLine("Rubber duck flies");
    }
    
}
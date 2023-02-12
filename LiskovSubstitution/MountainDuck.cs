namespace LiskovSubstitution;

public class MountainDuck : Duck
{
    public override void Swim()
    {
        Console.WriteLine("Mountain duck swim");
    }
    public override void Quack()
    {
        Console.WriteLine("Mountain duck quack");
    }
    public override void Flay()
    {
        Console.WriteLine("Mountain duck flies");
    }

   
}
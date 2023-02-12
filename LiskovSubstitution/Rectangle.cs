namespace LiskovSubstitution;

public class Rectangle
{
    protected int _width;
    protected int _height;

    public virtual void SetWidth(int width)
    {
        _width = width;
    }

    public virtual void SetHeight(int height)
    {
        _height = height;
    }
}
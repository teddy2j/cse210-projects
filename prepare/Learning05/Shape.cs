using System.Drawing;

public class Shape
{
    private string _color;
    public string GetColor()
    {
        return _color;
    }
    public Shape(string color)
    {
        _color=color;
    }
    public virtual float GetArea()
    {
        float area = -1;
        return area;
    }


}
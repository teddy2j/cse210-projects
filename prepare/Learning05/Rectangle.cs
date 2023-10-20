public class Rectangle : Shape
{
    private float _sideA;
    private float _sideB;
    public Rectangle(string color, float sideA, float sideB) : base(color)    
    {
        _sideA = sideA;
        _sideB = sideB;
    }
    public override float GetArea()
    {
        return _sideA * _sideB;
    }

}
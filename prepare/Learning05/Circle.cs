class Circle: Shape
{
    
    double _radio;
    public Circle(string color, double radio):base(color)
    {
        _radio = radio;
    }
    public override double GetArea()
    {
        return 2 * Math.PI * _radio * _radio;
    }
}
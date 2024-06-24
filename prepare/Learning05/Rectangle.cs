class Rectangle: Shape
{
    double _length;
    double _width;
    public Rectangle(string color, double len, double width):base(color)
    {
        _length = len;
        _width = width;
    }
    public override double GetArea()
    {
        return _length * _width;
    }
}
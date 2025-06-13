class Square : Shapes
{
    private double _width;

    public Square(double width, string color) : base(color)
    {
        _width = width;
    }
    public override double GetArea()
    {
        return _width * _width;
    }
}
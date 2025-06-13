class Rectangule : Shapes
{
    private double _length;
    private double _width;

    public Rectangule(double length, double width, string color) : base(color)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}
namespace Otus_lesson_18;

public struct Rectangle : ICalculableArea
{
    public int A { get; set; }
    public int B { get; set; }
    public Point StartPoint { get; set; }

    public Rectangle(int a, int b, Point c)
    {
        A = a;
        B = b;
        StartPoint = c;
    }
    
    public double GetArea()
    {
        return A * B;
    }

    public override string ToString()
    {
        return $"({A}, {B}, {StartPoint})";
    }
namespace Otus_lesson_18;

// Реализуйте структуры Point, Circle и Rectangle.
// Добавьте методы для вычисления площади кругов и прямоугольников.
// Выведите информацию о созданных фигурах и их площади в консоль.

public struct Circle :ICalculableArea
{
    public Point center { get; set; }
    public int radius { get; set; }

    public Circle(Point center, int radius)
    {
        this.center = center;
        this.radius = radius;
    }
    
    public double GetArea()
    {
        return Math.PI * radius * radius;
    }
}
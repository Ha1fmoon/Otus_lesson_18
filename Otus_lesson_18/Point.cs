namespace Otus_lesson_18;

// Реализуйте структуры Point, Circle и Rectangle.
// Добавьте методы для вычисления площади кругов и прямоугольников.
// Выведите информацию о созданных фигурах и их площади в консоль.

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}
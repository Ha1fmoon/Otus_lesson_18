namespace Otus_lesson_18;

// Реализуйте структуры Point, Circle и Rectangle.
// Добавьте методы для вычисления площади кругов и прямоугольников.
// Выведите информацию о созданных фигурах и их площади в консоль.

class Program
{
    static void Main(string[] args)
    {
        var point = new Point(10, 20);
        var circle = new Circle(15, 20);
        var rectangle = new Rectangle(10, 20, 30);

        Console.WriteLine(point);
        
    }
}
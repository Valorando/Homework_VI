/*Создайте абстрактный класс "Фигура" (Shape) со следующими свойствами:

Абстрактное свойство "Площадь" (Area) типа double (только для чтения).
Абстрактное свойство "Периметр" (Perimeter) типа double (только для чтения).
От абстрактного класса "Фигура" унаследуйте классы "Прямоугольник" (Rectangle) и "Круг" (Circle).

В классе "Прямоугольник" добавьте следующие поля и методы:

Поля "Ширина" (Width) и "Высота" (Height) типа double.
Переопределенные свойства "Площадь" и "Периметр" для расчета значений на основе полей "Ширина" и "Высота".
Метод "ToString()" для вывода информации о прямоугольнике в виде строки.
В классе "Круг" добавьте следующие поля и методы:

Поле "Радиус" (Radius) типа double.
Переопределенные свойства "Площадь" и "Периметр" для расчета значений на основе поля "Радиуса".
Метод "ToString()" для вывода информации о круге в виде строки.
Создайте класс "Треугольник" (Triangle), который также наследует класс "Фигура" и имеет поля и методы аналогичные классам "Прямоугольник" и "Круг", с учетом особенностей треугольников.

В основной программе создайте массив объектов типа "Фигура" и заполните его экземплярами классов "Прямоугольник", "Круг" и "Треугольник".

Напишите метод "PrintShapesInfo", который принимает массив объектов типа "Фигура" и выводит информацию о каждой фигуре, используя метод "ToString()".

В основной программе вызовите метод "PrintShapesInfo" и передайте ему массив объектов.*/

abstract class Shape
{
     public virtual double Area { get; }
     public virtual double Perimeter { get; }

}

class Rectangle : Shape
{
    double Width;
    double Height;

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double Area
    {
        get { return Width * Height; }
    }
    public override double Perimeter
    {
        get { return 2 * (Width * Height); }
    }

    public void ToString()
    {
        Console.WriteLine($"Название: Прямоугольник. Ширина: {Width} см. Высота: {Height} см. Площадь: {Area} см''. Периметр: {Perimeter} см. ");
    }


}

class Circle : Shape
{
    double Radius;

    public Circle (double radius)
    {
        Radius = radius;
    }

    public override double Area
    {
        get { return 3.14 * Radius * Radius; }
    }

    public override double Perimeter
    {
        get { return 2 * 3.14 * Radius; }
    }

    public void ToString()
    {
        Console.WriteLine($"Название: Круг. Радиус: {Radius} см. Площадь: {Area} cм''. Периметр: {Perimeter} см.");
    }
}

class Triangle : Shape
{
    double Side_A;
    double Side_B;
    double Side_C;

    public Triangle(double side_a, double side_b, double side_c)
    {
        Side_A = side_a;
        Side_B = side_b;
        Side_C = side_c;
    }


    public override double Perimeter
    {
        get { return Side_A + Side_B + Side_C; }
    }
    public override double Area
    {
        get { return Math.Sqrt(Perimeter / 2 * (Perimeter / 2 - Side_A) * (Perimeter / 2 - Side_B) * (Perimeter / 2 - Side_C)); }
    }


    public void ToString()
    {
        Console.WriteLine($"Название: Треугольник. Сторона А: {Side_A} см. Сторона В: {Side_B} см. Сторона С: {Side_C} см. Площадь: {Area} cм''. Периметр: {Perimeter} см.");
    }
}


class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle(4,5);
        Circle circle = new Circle(10);
        Triangle triangle = new Triangle(12,24,10);
   
        Shape[] arr = new Shape[3] {rectangle, circle, triangle };

        void PrintShapesInfo(Shape[] arr)
        {
            rectangle.ToString();
            Console.WriteLine();
            circle.ToString();
            Console.WriteLine();
            triangle.ToString();
        }

        PrintShapesInfo( arr = new Shape[3] { rectangle, circle, triangle });

    }
   




        
    
}


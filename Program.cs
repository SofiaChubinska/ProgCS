using System;
/*Варіант 3:

1. Створіть інтерфейс ITask з методами void Execute() та void Complete().
Реалізуйте його у класі Task, що містить назву завдання.

2. Створіть абстрактний клас Figure з методом double CalculateVolume().
Створіть класи Cube та Sphere, які успадковують Figure та перекривають метод.

3. Створіть клас BankAccount, який реалізує інтерфейс IComparable для порівняння рахунків за балансом.

4. Перевантажте оператор == для класу Person, що порівнює два об'єкти за ім'ям та віком.*/

using System;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Runtime.Intrinsics;

/*// 1. Створення інтерфейсу ITask
public interface ITask
{
    void Execute();
    void Complete();
}

// Реалізація інтерфейсу ITask у класі Task
public class Task : ITask
{
    private string taskName;

    public Task(string name)
    {
        taskName = name;
    }

    public void Execute()
    {
        Console.WriteLine("Task '{0}' is being executed.", taskName);
    }

    public void Complete()
    {
        Console.WriteLine("Task '{0}' is completed.", taskName);
    }
}

// 2. Створення абстрактного класу Figure
public abstract class Figure
{
    public abstract double CalculateVolume();
}

// Клас Cube, який успадковує Figure
public class Cube : Figure
{
    private double sideLength;

    public Cube(double length)
    {
        sideLength = length;
    }

    public override double CalculateVolume()
    {
        return Math.Pow(sideLength, 3);
    }
}

// Клас Sphere, який успадковує Figure
public class Sphere : Figure
{
    private double radius;

    public Sphere(double r)
    {
        radius = r;
    }

    public override double CalculateVolume()
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
    }
}

// 3. Клас BankAccount, який реалізує інтерфейс IComparable
public class BankAccount : IComparable<BankAccount>
{
    public string AccountHolder { get; set; }
    public double Balance { get; set; }

    public int CompareTo(BankAccount other)
    {
        if (other == null)
            return 1;

        // Порівнюємо за балансом
        return this.Balance.CompareTo(other.Balance);
    }
}

// 4. Перевантаження оператора == для класу Person
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public static bool operator ==(Person person1, Person person2)
    {
        if (ReferenceEquals(person1, person2))
            return true;

        if (person1 is null || person2 is null)
            return false;

        return person1.Name == person2.Name && person1.Age == person2.Age;
    }

    public static bool operator !=(Person person1, Person person2)
    {
        return !(person1 == person2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // 1. Використання інтерфейсу ITask
        ITask task1 = new Task("Task 1");
        task1.Execute();
        task1.Complete();

        // 2. Використання класів Cube та Sphere
        Cube cube = new Cube(5);
        Sphere sphere = new Sphere(4);

        Console.WriteLine("Volume of Cube: " + cube.CalculateVolume());
        Console.WriteLine("Volume of Sphere: " + sphere.CalculateVolume());

        // 3. Використання класу BankAccount
        BankAccount account1 = new BankAccount { AccountHolder = "John", Balance = 1600 };
        BankAccount account2 = new BankAccount { AccountHolder = "Jane", Balance = 1500 };

        Console.WriteLine("Comparison result: " + account1.CompareTo(account2));

        // 4. Перевірка перевантаження оператора ==
        Person person1 = new Person { Name = "Alice", Age = 25 };
        Person person2 = new Person { Name = "Alice", Age = 25 };
        Person person3 = new Person { Name = "Bob", Age = 30 };

        Console.WriteLine("Equality check: " + (person1 == person2)); // true
        Console.WriteLine("Equality check: " + (person1 == person3)); // false
    }
}
*/
/*Варіант 1:

1. Створіть інтерфейс IVehicle, що містить метод void Drive(). 
Реалізуйте цей інтерфейс у класах Car та Motorcycle.

2. Створіть абстрактний клас Shape з методом CalculateArea(). 
Створіть клас Rectangle, що успадковує Shape, і реалізуйте метод для обчислення площі прямокутника.

3. Створіть клас Employee, що успадковує Person і реалізує 
інтерфейси IComparable для порівняння за зарплатою та ICloneable для створення копії.

4. Перевантажте оператор + для класу Vector, що додає два вектори.*/
/*
class Vector
{
    public int V1 { get; set; }
    public int V2 { get; set; }

    public static Vector operator +(Vector v1,Vector v2)
    {
        return new Vector { V1 = v1.V1 + v1.V2, V2 = v2.V1 + v2.V2 };
    }
    public override string ToString()
    {
        return "(" + V1 + ", " + V2 + ")";
    }
}
public interface IVehicle
{
    void Drive();
}
class Car : IVehicle
{
    public string Name;

    public Car(string name)
    {
        Name = name;
    }

    public void Drive()
    {
        Console.WriteLine($"The car name: {Name} was drove");
    }

}

class Motocycle : IVehicle
{
    public string Color;

    public Motocycle(string color)
    {
        Color = color;
    }
    public void Drive()
    {
        Console.WriteLine($"The Vehicle color is: {Color} was drove");
    }
}

abstract class Shape
{
    public abstract void CalculateArea();
}

class Rectangle:Shape
{
    public int A;
    public int B;

    public Rectangle(int a, int b)
    {
        A = a;
        B = b;
    }

    public override void CalculateArea() {

        int square = A * B;
        Console.WriteLine($"The square of rectangle is: {square}");
    }
}

// Оголошення інтерфейсу IComparable для порівняння за зарплатою
interface IComparable
{
    int CompareTo(object obj);
}

// Оголошення інтерфейсу ICloneable для створення копії
interface ICloneable
{
    object Clone();
}

// Базовий клас Person
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

// Клас Employee, який успадковує Person та реалізує інтерфейси IComparable та ICloneable
class Employee : Person, IComparable, ICloneable
{
    public double Salary { get; set; }

    public Employee(string name, int age, double salary) : base(name, age)
    {
        Salary = salary;
    }

    // Реалізація методу CompareTo для порівняння за зарплатою
    public int CompareTo(object obj)
    {
        if (obj == null)
            return 1;

        Employee otherEmployee = obj as Employee;
        if (otherEmployee != null)
            return Salary.CompareTo(otherEmployee.Salary);
        else
            throw new ArgumentException("Object is not an Employee");
    }

    // Реалізація методу Clone для створення копії
    public object Clone()
    {
        return new Employee(Name, Age, Salary);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Приклад використання класу Employee
        Employee emp1 = new Employee("John", 30, 50000);
        Employee emp2 = new Employee("Alice", 35, 60000);

        // Порівняння за зарплатою
        if (emp1.CompareTo(emp2) < 0)
            Console.WriteLine(emp1.Name + " has a lower salary than " + emp2.Name);
        else if (emp1.CompareTo(emp2) > 0)
            Console.WriteLine(emp1.Name + " has a higher salary than " + emp2.Name);
        else
            Console.WriteLine(emp1.Name + " has the same salary as " + emp2.Name);

        // Створення копії працівника
        Employee emp1Copy = (Employee)emp1.Clone();
        Console.WriteLine("Copy of emp1: " + emp1Copy.Name + ", " + emp1Copy.Age + ", " + emp1Copy.Salary);

        Vector vector1 = new Vector { V1 = 2, V2 = 3 };
        Vector vector2 = new Vector { V1 = 6, V2 = 7 };

        Vector result = vector1 + vector2;

        Console.WriteLine(result);
    }
}*/

/*Варіант 2:

1. Створіть інтерфейс IAnimal, що містить метод void Speak(). Реалізуйте цей інтерфейс у класах Dog та Cat.

2. Створіть абстрактний клас Shape з віртуальним методом double CalculateArea(). Створіть класи Circle, Rectangle та Triangle, які успадковують Shape та перекривають метод.

3. Створіть клас Manager та Developer, які успадковують абстрактний клас Employee з віртуальним методом CalculateSalary().

4. Створіть власний індексатор для класу Matrix, який дозволяє звертатися до елементів матриці за індексами.*/

/*завдання 4*/
/*
class Matrix
{
    private int[] array = new int[8];

    public int this[int index]
    {
        get { return array[index]; }
        set { array[index] = value; }
    }
}



abstract class Employee
{
    public virtual double CalculateSalary()
    { return 0; }
        
}
class Manager:Employee
{
    public int SalaryByOneHours = 50;
    public int HoursOfWork;

    public Manager(int salaryByOneHours, int hoursOfWork)
    {
        SalaryByOneHours = salaryByOneHours;
        HoursOfWork = hoursOfWork;
    }
    public override double CalculateSalary()
    {
        return HoursOfWork * SalaryByOneHours;
    }
}

class Developer:Employee
{
    public int SalaryByOneHours = 40;
    public int HoursOfWork;

    public Developer(int salaryByOneHours, int hoursOfWork)
    {
        SalaryByOneHours = salaryByOneHours;
        HoursOfWork = hoursOfWork;
    }
    public override double CalculateSalary()
    {
        return HoursOfWork * SalaryByOneHours;
    }
}




class Circle : Shape
{
    public int Radius { get; set; }
    public Circle(int radius)
    {
        Radius = radius;
    }
    public override double CalculateArea()
    {
        return Math.PI*Radius*Radius;
    }
}

class Rectangle: Shape
{
    public int Width { get; set; }
    public int Height { get; set; }
    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }
    public override double CalculateArea()
    {
        return Width*Height;
    }
}

class Triangle: Shape
{
    public int A { get; set; }
    public int B { get; set; }

    public Triangle(int a, int b)
    {
        A = a;
        B = b;
    }

    public override double CalculateArea()
    {
        return 1 / 2 * A * B;
    }
}




public interface IAnimal
{
    void Speak();
}

abstract class Shape
{
    public abstract double CalculateArea();
}
class Dog:IAnimal
{
    public string Name { get; set; }
    public Dog(string name)
    {
        Name = name;
    }
    public void Speak()
    {
        Console.WriteLine($"Dog said Hav: {Name}");
    }
}


class Cat:IAnimal
{
    public void Speak()
    {
        Console.WriteLine($"Dog said Hav:");
    }
}

class Program
{
    static void Main()
    {
        Matrix matrix = new Matrix();
        matrix[0] = 1;
        matrix[1] = 8;
        matrix[2] = 0;
        matrix[3] = 3;
        int value = matrix[1];
        Console.WriteLine($"Value of matrix[1]: {value}");
    }
}*/
/*Створіть інтерфейс ILogger з методом void Log(string message).
 * Реалізуйте його у класах FileLogger та ConsoleLogger.
 * 
 * Створіть абстрактний клас Animal з методами void Eat() та void Sleep().
 * Створіть класи Dog та Cat, що успадковують Animal та реалізують методи.
 * 
 * Створіть клас Student з властивістю GPA та реалізуйте в ньому інтерфейс IComparable для порівняння студентів за середнім балом.
 * 
 * Створіть методи розширення для типу String, які дозволяють перетворювати рядок у верхній та нижній регістри.*/
static class StrExtention
{
    public static string to_upper(this string msg)
    {
        return msg.ToUpper();
    }

    public static string to_lower(this string msg)
    {
        return msg.ToLower();
    }
}

class Student : IComparable<Student>
{
    public string GPA { get; set; }

    public int CompareTo(Student other)
    {
        return GPA.CompareTo(other.GPA);
    }
}
abstract class Animal
{
    public abstract void Eat();
    public abstract void Sleep();
}

class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("The dog Eat");
    }

    public override void Sleep()
    {
        Console.WriteLine("The dog Sleep");
    }

}

class Cat : Animal
{
    public override void Eat()
    {
        Console.WriteLine("The cat Eat");
    }

    public override void Sleep()
    {
        Console.WriteLine("The cat Sleep");
    }
}
public interface ILogger
{
    void Log(string message);
}

class FileLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine("Hello");
    }
}

class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine("Word");
    }
}

class Program
{
    static void Main()
    {
        FileLogger fileLogger = new FileLogger();
        ConsoleLogger consoleLogger = new ConsoleLogger();

        fileLogger.Log("Message for file logger");
        consoleLogger.Log("Message for console logger");

        Dog dog = new Dog();
        Cat cat = new Cat();

        cat.Eat();
        cat.Sleep();
        dog.Sleep();
        dog.Eat();

        Student student1 = new Student { GPA = "76879" };
        Student student2 = new Student { GPA = "76878" };
        Console.WriteLine(student1.CompareTo(student2));
        string message = "Hello World";

        string upperCaseMessage = message.to_upper();
        Console.WriteLine(upperCaseMessage);

        string lowerCaseMessage = message.to_lower();
        Console.WriteLine(lowerCaseMessage);

    }


}

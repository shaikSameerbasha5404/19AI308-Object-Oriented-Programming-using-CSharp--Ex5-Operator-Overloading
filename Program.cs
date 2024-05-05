using System;

class MyClass
{
    private int value;

    // Default constructor
    public MyClass()
    {
        this.value = 0;
    }

    // Parameterized constructor
    public MyClass(int value)
    {
        this.value = value;
    }

    // Getter for value
    public int GetValue()
    {
        return value;
    }

    // Overloading equality operator
    public static bool operator ==(MyClass obj1, MyClass obj2)
    {

        // Check if either of the objects is null
        if (obj1 is null || obj2 is null)
            return false;

        // Compare the values of the objects
        return obj1.value == obj2.value;
    }

    // Overloading inequality operator
    public static bool operator !=(MyClass obj1, MyClass obj2)
    {
        return !(obj1 == obj2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass obj1 = new MyClass(10);
        MyClass obj2 = new MyClass(); // Using default constructor
        MyClass obj3 = new MyClass(10);

        // Check equality
        Console.WriteLine("Are obj1 and obj2 equal? " + (obj1 == obj2));
        Console.WriteLine("Are obj1 and obj3 equal? " + (obj1 == obj3));
    }
}

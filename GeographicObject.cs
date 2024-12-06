using System;

public abstract class GeographicObject
{
    public int X { get; set; }
    public int Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    // Віртуальний метод для отримання інформації
    public virtual void GetInfo()
    {
        Console.WriteLine($"Name: {Name}, Description: {Description}, Coordinates: ({X}, {Y})");
    }
}

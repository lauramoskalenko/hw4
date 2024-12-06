public interface IGeographicObject
{
    int X { get; set; }
    int Y { get; set; }
    string Name { get; set; }
    string Description { get; set; }

    void GetInfo();
}

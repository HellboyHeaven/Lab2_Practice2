namespace GpsNavigation;

public class Waypoint
{
    public string Name { get;}

    public Coordinates Coordinates { get; }
    public (double, double) GetCoordinates() => (Coordinates.Latitude, Coordinates.Longitude);

    public Waypoint(string name, double latitude, double longitude)
    {
        Name = name;
        Coordinates = new Coordinates(latitude, longitude);
    }


    public void Deconstruct(out double latitude, out double longitude)
    {
        latitude = Coordinates.Latitude;
        longitude = Coordinates.Longitude;
    }
}

public record Coordinates(double Latitude, double Longitude);
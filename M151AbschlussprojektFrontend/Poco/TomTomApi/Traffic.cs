public class Traffic
{
    public List<Incident> incidents { get; set; }
}

public class Event
{
    public int code { get; set; }
    public string description { get; set; }
}

public class Point
{
    public int location { get; set; }
    public int? offset { get; set; }
}

public class Tmc
{
    public string countryCode { get; set; }
    public string tableNumber { get; set; }
    public string tableVersion { get; set; }
    public string direction { get; set; }
    public List<Point> points { get; set; }
}

public class Properties
{
    public string id { get; set; }
    public int iconCategory { get; set; }
    public int magnitudeOfDelay { get; set; }
    public DateTime startTime { get; set; }
    public DateTime? endTime { get; set; }
    public string from { get; set; }
    public string to { get; set; }
    public double length { get; set; }
    public int delay { get; set; }
    public List<string> roadNumbers { get; set; }
    public string timeValidity { get; set; }
    public List<Event> events { get; set; }
    public object aci { get; set; }
    public Tmc tmc { get; set; }
}

public class Geometry
{
    public string type { get; set; }
    public List<List<double>> coordinates { get; set; }
}

public class Incident
{
    public string type { get; set; }
    public Properties properties { get; set; }
    public Geometry geometry { get; set; }
}

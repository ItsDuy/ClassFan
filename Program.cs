namespace ClassFan;
public class Fan
{
    public const int SLOW = 1;
    public const int MEDIUM = 2;
    public const int FAST = 3;
    private int speed;
    private bool on;
    private double radius;
    private string color;
    public Fan()
    {
        speed = SLOW;
        on = false;
        radius = 5;
        color = "blue";
    }

    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public bool On
    {
        get { return on; }
        set { on = value; }
    }

    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public override string ToString()
    {
        if (on)
        {
            return $"Fan is on: Speed = {speed}, Color = {color}, Radius = {radius}";
        }
        else
        {
            return $"Fan is off: Color = {color}, Radius = {radius}";
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Fan fan1 = new Fan();
        fan1.Speed = Fan.FAST;
        fan1.Radius = 10;
        fan1.Color = "yellow";
        fan1.On = true;
        Fan fan2 = new Fan();
        fan2.Speed = Fan.MEDIUM;
        fan2.Radius = 5;
        fan2.Color = "blue";
        fan2.On = false;
        Console.WriteLine(fan1.ToString());
        Console.WriteLine(fan2.ToString());
    }
}

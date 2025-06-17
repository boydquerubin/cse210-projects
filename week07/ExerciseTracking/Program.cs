using System;

class Activity
{
    protected string date;
    protected int minutes;

    public Activity(string date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    public virtual double GetDistance() => 0;
    public virtual double GetSpeed() => 0;
    public virtual double GetPace() => 0;

    public virtual string GetSummary()
    {
        return $"{date} {this.GetType().Name} ({minutes} min): Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace {GetPace():0.0} min per mile";
    }
}

class Running : Activity
{
    private double distance;

    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        this.distance = distance;
    }

    public override double GetDistance() => distance;
    public override double GetSpeed() => distance / minutes * 60;
    public override double GetPace() => minutes / distance;
}

class Cycling : Activity
{
    private double speed;

    public Cycling(string date, int minutes, double speed) : base(date, minutes)
    {
        this.speed = speed;
    }

    public override double GetDistance() => speed * minutes / 60;
    public override double GetSpeed() => speed;
    public override double GetPace() => 60 / speed;
}

class Swimming : Activity
{
    private int laps;

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        this.laps = laps;
    }

    public override double GetDistance() => laps * 50 / 1000.0 * 0.62;
    public override double GetSpeed() => GetDistance() / minutes * 60;
    public override double GetPace() => minutes / GetDistance();
}
class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
         var activities = new List<Activity>
        {
            new Running("03 Nov 2022", 30, 3.0),
            new Cycling("03 Nov 2022", 45, 15.0),
            new Swimming("03 Nov 2022", 40, 30)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
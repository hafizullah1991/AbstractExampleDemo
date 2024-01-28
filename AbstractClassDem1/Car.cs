namespace ConsoleUI;

internal class Car : Vehicle
{
    public bool HasTrunk { get; set; } = true;



    // Implementation of the Start method for a Car
    public override void DriveAbstract()
    {
        Console.WriteLine($"{Make}  very expensive(it's car class)");
    }
}
namespace Backend;

public abstract class GeometricFigure
{
    //Fields

    //Constructors

    //Properties

    public string Name { get; set; } = null!;

    //Public Methods

    public abstract decimal GetArea();

    public abstract decimal GetPerimeter();

    public override string ToString()
    {
        return $"{ Name,-14} => Area.....: { GetArea(),14:N5}    Perimeter: { GetPerimeter (),12:N5}\t";
    }

    //Private Methods
}

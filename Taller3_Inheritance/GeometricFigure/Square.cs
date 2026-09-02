namespace Backend;

public class Square : GeometricFigure
{
    //Fields

    private decimal _a;

    //Constructors

    public Square(string name, decimal a)
    {
        Name = name;
        A = a;
    }

    //Properties

    public decimal A 
    { 
        get => _a; 
        set => _a = ValidateA(value); 
    
    }

    //Public Methods

    public override decimal GetArea()
    {
        decimal area = (decimal)Math.Pow((double) A, 2);
        return area;
    }

    public override decimal GetPerimeter()
    {
        decimal perimeter = 4 * A;
        return perimeter;
    }
    //Private Methods

    private decimal ValidateA(decimal a)
    {
        if (a < 0)
        {
            throw new Exception($"The side length: {a}, is not valid."); ;
        }

        else
        {
            return a;
        }

    }

}

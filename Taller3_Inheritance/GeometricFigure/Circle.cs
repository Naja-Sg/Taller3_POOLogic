namespace Backend;

public class Circle : GeometricFigure

{
    //Fields

    private decimal _r;


    //Constructors

    public Circle(string name, decimal r)
    {
        Name = name;
        R = r; //Generated constructor with Propertie instead of Field, as we'll be validating the propertie
    }


    //Properties

    public decimal R 
    { 
        get => _r; 
        set => _r = ValidateR(value); 
    }


    //Public methods
    public override decimal GetArea()
    {
        decimal area = (decimal) Math.PI * (decimal) Math.Pow ((double)R, 2);// R is decimal, so I cast it to double for the Math.Pow to work, then the result is casted back to Decimal, and Match.PI too so I can multiply them
        return area;
    }

    public override decimal GetPerimeter()
    {
        decimal perimeter = 2 * (decimal)Math.PI * R;
        return perimeter;
    }


    //Private Methods

    private decimal ValidateR (decimal radious)
    {
        if (radious < 0)
        {
            throw new Exception($"The radious: {radious}, is not valid."); ;
        }

        else
        {
            return radious;
        }

    }
}

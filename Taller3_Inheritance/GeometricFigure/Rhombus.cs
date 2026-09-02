using System;
using System.Collections.Generic;
using System.Text;

namespace Backend;

public class Rhombus : Square
{
    //Fields

    private decimal _d1;
    private decimal _d2;

    //Constructors
    public Rhombus(string name, decimal a, decimal d1, decimal d2) : base(name, a)
    {
        D1 = d1;
        D2 = d2;
        A = a;
    }

    //Properties

    public decimal D1
    {
        get => _d1;
        set => _d1 = ValidateD1(value);
    }
    public decimal D2
    {
        get => _d2;
        set => _d2 = ValidateD1(value);
    }

    //Public Methods

    public override decimal GetArea()
    {
        decimal area = (D1 *  D2)/2;
        return area;
    }

    public override decimal GetPerimeter()
    {
        decimal perimeter = 4 * A;
        return perimeter;
    }

    //Private Methods

    private decimal ValidateD1(decimal d1)
    {
        if (d1 < 0)
        {
            throw new Exception($"The side length: {d1}, is not valid."); ;
        }

        else
        {
            return d1;
        }

    }

    private decimal ValidateD2(decimal d2)
    {
        if (d2 < 0)
        {
            throw new Exception($"The side length: {d2}, is not valid."); ;
        }

        else
        {
            return d2;
        }

    }
}

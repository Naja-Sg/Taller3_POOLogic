namespace PrimeFactors;

public class PrimeFactorization
{
    //Fields

    private int _number;


    //Constructors

    public PrimeFactorization(int number)
    {
        Number = number;
    }


    //Properties

    public int Number 
    { 
        get => _number; 
        set => _number = value; 
    }

    //PublicMethods

    public List<int> toList(int number) // I get a list of all the numbers that compound Number, starting in 1
    {
        List<int> listNumber = new List<int>();

        for (int f = 2; f <= number; f++) // fila
        {
            listNumber.Add(f);

        }

        return listNumber;
    }


    public List<int> toDivisorsList(int number, List<int> list) // I get a list from all the divisors of the number from the previous list
    {
        List<int> divisors = new List<int>();

        foreach (int value in list) 
        {
            if ( number % value == 0)
            {
                divisors.Add(value);
            }
         
        }

        return divisors;
    }

    public List<int> toPrimeFactors(int number, List<int> list) // I get a list from all the divisors of the number from the previous list
    {
        List<int> primeFactors = new List<int>();

        foreach (int value in list) 
        {
            while (number % value == 0)
            {
                primeFactors.Add(value);
                number = number / value;
            }

        }

        return primeFactors;
    }

    public override string ToString ()
    {
        List<int> numeros = toList(Number);
        List<int> primeFactors = toPrimeFactors(Number, numeros);
        string factoresUnidos = string.Join(" x ", primeFactors);
        return $"{Number} = {factoresUnidos}";
    }



    //PrivateMethods
}

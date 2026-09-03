using PrimeFactors;
using Utilities_Shared;

var answer = String.Empty;
var options = new List<string> { "s", "n" };


do
{
    var number = ConsoleExtensions.GetInt("Ingrese el número a descomponer: ");

    PrimeFactorization obj = new PrimeFactorization(number);

    List<int> list = obj.toList(number);
    List<int> primeFactors = obj.toPrimeFactors(number, list);
    string factors = obj.ToString ();

    Console.WriteLine(factors);


    do
    {
        answer = ConsoleExtensions.GetValidOptions("Deseas continuar (S)í, (N)o?", options);

    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
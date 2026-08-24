using Utilities_Shared;

var answer = String.Empty;
var options = new List<string> { "s", "n" };


do
{



    do
    {
        answer = ConsoleExtensions.GetValidOptions("Deseas continuar (S)í, (N)o?", options);

    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
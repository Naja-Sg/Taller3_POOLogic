using Utilities_Shared;

var answer = String.Empty;
var options = new List<string> { "s", "n" };
var sumatoria = 0;


var order = ConsoleExtensions.GetInt("Ingrese el order de la matriz: ");
int[,] matriz = new int[order, order];

do
{


    for (int f = 0; f < order; f++) // filas
    {
        for (int c = 0; c < order; c++) // columnas. Recorrido por filas
        {
            matriz [f, c] = (f + 1) - c;
            Console.Write($"{matriz[f, c]}  ");
        }

        Console.Write("\n");

    }

    for (int f = 0; f < order; f++) 
    {
        for (int c = 0; c < order; c++) {



        }

    }

    Console.WriteLine($"La sumatoria es: {sumatoria}");



    do
    {
        answer = ConsoleExtensions.GetValidOptions("Deseas continuar (S)í, (N)o?", options);

    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

const int coeff = 0;
const int constanta = 1;
const int X_coord = 0;
const int Y_coord = 1;
const int Line1 = 1;
const int Line2 = 2;

double[] lineData1 = InputLineData(Line1);
double[] lineData2 = InputLineData(Line2);

if (ValidateLines(lineData, lineData2))
{
    double[] coard = FindCoords(lineData1, lineData2);
    Console.Write($"Точка пересечения уравнений y={lineData1[coeff]}*x+{lineData1[constanta]} и y={lineData2[coeff]}*x+{lineData2[constanta]}");
    Console.WriteLine($" имеет координаты ({coord[X_coord]},{coord[Y_coord]})");
}

double Prompt(string message)
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

double[] InputLineData(int numberOfLine)
{
    double[] LineData = new double[2];
    lineData[coeff] = Prompt($"Введите коэффициент для {numberOfLine} прямой >");
    return lineData;
}

double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[X_coord] = lineData1[constanta] - lineData2[constanta] / (lineData2[coeff] - lineData1[coeff]);
    coord[Y_coord] = lineData1[constanta] * coord[X_coord] + lineData1[constanta];
    return coord;
}

bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if (lineData1[coeff] == lineData2[coeff])
    {
        lineData1[constanta] == lineData2[constanta];
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}

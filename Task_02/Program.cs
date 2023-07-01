// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

const int coefficient = 0;
const int constant = 1;
const int x_coord = 0;
const int y_coord = 1;
const int line1 = 1;
const int line2 = 2;

double[] lineData1 = InputLineData(line1);
double[] lineData2 = InputLineData(line2);

if (ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    Console.Write($"The point of intersection of the equations y={lineData1[coefficient]}*x+{lineData1[constant]}"
    +$" and y={lineData2[coefficient]}*x+{lineData2[constant]} ");
    Console.WriteLine($" has coordinates ({coord[x_coord]}; {coord[y_coord]})");
}

double Prompt(string message)                  // ввод числа
{
    System.Console.Write(message);           // вывести сообщение
    string value = Console.ReadLine();       // считывает строку в консоли
    double result = Convert.ToDouble(value); // преобразует строку в число
    return result;                           // возвращает результат
}

double[] InputLineData(int numberOfLine)     // ввод данных по прямым
{
    double[] lineData = new double[2];
    lineData[coefficient] = Prompt($"Input coefficient k for {numberOfLine} line > ");
    lineData[constant] = Prompt($"Input constant b for {numberOfLine} line > ");
    return lineData;
}

double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord [x_coord] = (lineData2[constant] - lineData1[constant]) / (lineData1[coefficient] - lineData2[coefficient]);
    coord [y_coord] = (lineData1[coefficient] * coord[x_coord] + lineData1[constant]);
    return coord;
}

bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if (lineData1[coefficient] == lineData2[coefficient])
    {
        if (lineData1[constant] == lineData2[constant])
        {
            Console.WriteLine("These lines match");
            return false;
        }
        else
        {
        Console.WriteLine("These lines are parallel");
        return false;
        }
    }
        return true;
}

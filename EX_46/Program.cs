// Написать программу масштабирования фигуры
int k = -2; //4 0.5
string peaks = "(0,0) (2,0) (2,2) (0,2)"
                .Replace("(", "")
                .Replace(")", "");
System.Console.WriteLine(peaks);

var data = peaks.Split(" ")
                .Select(item => item.Split(','))
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
                .Select(point => (point.x * k, point.y * k))
                .ToArray();
for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
}

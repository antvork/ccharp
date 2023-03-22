string NumberRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumberRec(a + 1, b);
    else return String.Empty;
}
Console.WriteLine(NumberRec(1, 10));

string NumberRec1(int a, int b)
{
    if (b >= a) return $"{b} "+ NumberRec1(a, b -1);
    else return String.Empty;
}
Console.WriteLine(NumberRec1(1, 10));
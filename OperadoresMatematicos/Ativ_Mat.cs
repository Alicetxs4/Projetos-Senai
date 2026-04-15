int x = 4;
int x1 = 9;
int x2 = 5;

bool xResult;

xResult = (((2 + 5) * 3) + x + 5)< x1;
Console.WriteLine(xResult);

xResult = ((((2 + 5) * 3) + (x + 5)) < x1) == (x == 6 + x2 * 2);
Console.WriteLine(xResult);

xResult = (((3 * 6) + x - 3) < x2);
Console.WriteLine(xResult);

xResult = ((7 * 8) > (x + 4)) && (x + 4 > x1) && (x != 2 + x2 * 9);
Console.WriteLine(xResult);


Console.WriteLine("enter num1");
int numb1 = int.Parse(Console.ReadLine());

Console.WriteLine("enter num2");
int numb2 = int.Parse(Console.ReadLine());

var total = Add(numb1, numb2);
Console.WriteLine("The Total is: " + total);

static int Add(int number1, int number2)
{
    var total = number1 + number2;
    return total;
}
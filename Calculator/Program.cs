

//Console.WriteLine("enter num1");
//int numb1 = int.Parse(Console.ReadLine());

//Console.WriteLine("enter num2");
//int numb2 = int.Parse(Console.ReadLine());

//var total = Add(numb1, numb2);
//Console.WriteLine("The Total is: " + total);

Console.WriteLine("enter num1");
double numb1 =  Convert.ToDouble(Console.ReadLine()); 

Console.WriteLine("enter num2");
double numb2 = double.Parse(Console.ReadLine());

var total = Sub(numb1 , numb2);
Console.WriteLine($"The Result is: {total}");

static int Add(int number1, int number2)
{
    var total = number1 + number2;
    return total;
}

static double Sub(double number1, double number2)
{
    var total = number1 - number2;
   return total;
}
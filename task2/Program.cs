int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num1sqare = num1 * num1;
if (num1sqare == num2) 
{
    Console.WriteLine("Да является");
}
else
{
    Console.WriteLine("Нет.не является");
}

//bool оператор правда или ложь
//Console.Writeline(num1sqare ? "да" : "нет");
//чтобы перевести один тип данных в другой используется parse

int num = int.Parse(Console.ReadLine());
int result = num * num;
//если нужно возвести число в степень int result = Math.Pow(num, 5);
Console.WriteLine(result);
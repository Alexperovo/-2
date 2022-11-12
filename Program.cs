// Напишете программу, которая на вход принимает два числа и выдает, какое число боольше, а какое меньше.
Console.WriteLine("Эта программ определяет какое из чисел больше");
Console.Write("Введите 1 число: ");
int num = Convert.ToInt32(Console.ReadLine ());

Console.Write("Введите 2 число: ");
int num1 = Convert.ToInt32(Console.ReadLine ());
// вводные получены
if (num > num1)
{ 
    Console.Write ("Большее число ");
    Console.Write(num);
}
else if (num < num1)
{
    Console.Write ("Большее число ");
    Console.Write(num1);
}

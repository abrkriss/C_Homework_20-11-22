void Zadacha25()
{
    //Используя определение степени числа, 
    //напишите цикл, который принимает на вход два натуральных числа (A и B) и 
    //возводит число A в степень B.

    Console.WriteLine("Введите число x");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число y");
    int y = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine($"{x} ^ {y}" + "\t = " + Math.Pow(x, y));
}
Zadacha25();
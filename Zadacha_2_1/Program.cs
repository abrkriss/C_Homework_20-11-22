void Zadacha27()
{
    //Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

    Console.Write("Введите число : ");
    int number = Convert.ToInt32(Console.ReadLine());

    int SumNumber(int number)
    {

        int counter = Convert.ToString(number).Length;
        int res = 0;
        int adv = 0;

        for (int i = 0; i < counter; i++)
        {
            adv = number - number % 10;
            res = res + (number - adv);
            number = number / 10;
        }
        return res;
    }

    int sumNumber = SumNumber(number);
    Console.WriteLine("Сумма цифр в числе: " + sumNumber);
}
Zadacha27();
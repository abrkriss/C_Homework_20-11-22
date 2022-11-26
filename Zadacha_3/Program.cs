int[] nums = { 0, 8, -2, 4, 6, 2, 1, 7 };


int temp;
if (nums.Length == 8)
{
for (int i = 0; i < nums.Length - 1; i++)
{
    for (int n = i + 1; n < nums.Length; n++)
    {
        if (nums[i] > nums[n])
        {
            temp = nums[i];
            nums[i] = nums[n];
            nums[n] = temp;
        }
    }
}

Console.WriteLine("Вывод отсортированного массива");
for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}
}
else
{
    Console.WriteLine("Массив меньше 8 значений");
}
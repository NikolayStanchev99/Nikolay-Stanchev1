int[] nums1 = { 1, 2, 3, 4, 5, 6, 7, 9 };
int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int sum = 0;
for (int i = 0; i < nums.Length; i++)
{
    sum += nums[i];
    if (sum == nums1[i])
    {
        Console.WriteLine("Да!");
    }
    else
    {
        Console.WriteLine("Не!");

    }
}
// поиск индекса заданного числа в массиве
int[] array = { 11, 21, 352, 4, 55, 64, 4, 88, 93 };
int n = array.Length;
int find = 4; // заданное число
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    index++;
}









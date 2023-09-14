// максимум из 9 чисел
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (result < arg2) result = arg2;
    if (result < arg3) result = arg3;
    return result;
}
int[] array = { 11, 21, 352, 45, 55, 64, 74, 88, 93 };
int max = Max(
Max(array[0], array[1], array[2]),
Max(array[3], array[4], array[5]),
Max(array[6], array[7], array[8]));


//int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
System.Console.WriteLine(max);
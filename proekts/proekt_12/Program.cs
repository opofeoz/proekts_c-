//методы
//вид 1 не чего не принимает, ни чего не возвращает.
// void Method1()
// {
//     System.Console.WriteLine("My name is ...");
// }
// Method1();

//вид 2 принимает аргументы (переменные) , ни чего не возвращает.
// void Method2(string msg)
// {
//     System.Console.WriteLine(msg);
// }
// Method2("my name ...");
// System.Console.WriteLine();

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         System.Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21(msg: "my name ...", count: 4);

//вид 3 не чего не принимает , что то возвращают.

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year=Method3();
// System.Console.WriteLine(year);

//вид 4 что то принимают , что то возвращают.

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "wteu ");
// System.Console.WriteLine(res);

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "wteu ");
// System.Console.WriteLine(res);


// таблица умножения 

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         System.Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     System.Console.WriteLine();
// }

//задача. дан текст. в тексте нужно заменить все пробелы черточками,
// маленькие "к" заменить большими "К",
// а большие "С" заменить маленькими "с".


string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";


string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}"; //если есть совпадение, то меняем символ
        else result = result + $"{text[i]}"; //если есть нет совпадения, то оставляем старый символ
    }
    return result;
}

string newText = Replace(text, ' ', '|');
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(newText, 'к', 'К');
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(newText, 'с', 'С');
System.Console.WriteLine(newText);



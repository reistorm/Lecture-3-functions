// Виды функций
// Вид 1 - ничего не принимают, ничего не возвращают
// Вид 2 - что-то принимают, ничего не возвращают
// Вид 2 - ничего не принимают, что-то возвращают
// Вид 3 - что-то принимают, что-то возвращают

// Вид 1 
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();

// Вид 2

void Method2(string msg) // принимает аргументы
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

// или чтобы текст повторялся определенное количество раз

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4);

// чтобы было точно понятно какому аргументу, какое значение присвоить
// count msg можно писать в любом порядке в выводе
// void Method21(string msg, int count) 
//{
//   int i = 0;
//    while (i < count)
//    {
//        Console.WriteLine(msg);
//        i++;
//    }
//}
//Method21(msg: "Текст", count: 4); 

// Вид 3
// обязательно нужно указать тип данных, 
// которые мы возвращаем

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Вид 4

string Method4(int count, string c) // строку с будем компоновать друг за дружкой много раз
{
    int i = 0;
    string result = String.Empty;     // result - переменная, в которую будем класть конечный результат. Изначально она пустая, т.е. в нее кладем String.Empty   
    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}
string res = Method4(10, "asdf ");  // 10 - количество повторений, в кавычках - любой текст

Console.WriteLine(res);


// Вид 4 с циклом for 

string Method41(int count, string c) // строку с будем компоновать друг за дружкой много раз
{
    string result1 = String.Empty;     // result - переменная, в которую будем класть конечный результат. Изначально она пустая, т.е. в нее кладем String.Empty   
    for (int i = 0; i < count; i++)
    {
        result1 = result1 + c;
    }
    return result1;
}
string res1 = Method41(10, "asdf ");  // 10 - количество повторений, в кавычках - любой текст

Console.WriteLine(res);

// Цикл в цикле - пример: таблица умножения

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}

// Задача 
// В тексте нужно все пробелы заменить черточками, 
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с"

string text = " - Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + " вы вы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwert"
//             01234
// s[3] // r    условно это вид 4 

string Replace(string text, char oldValue, char newValue) //text - входной текст. oldValue - старое значение. на newValue будем менять 
{
    string result = String.Empty; // инициализация пустой строки
    int length = text.Length;   // получаем длину строки (показывает количество символов в строке)
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}"; // если текущий элемент строки совпадет с новым значением, то поменяем его на новое значение
        else result = result + $"{text[i]}"; // в результат добавляем текущий 
    }
    return result;

}

string newText = Replace(text, ' ', '|'); 
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);



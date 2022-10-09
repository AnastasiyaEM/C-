// 1-я группа методов (ничего не возвращают и ничего не принимают)

void Methhod1()
{
    Console.WriteLine("Автор:,,,,");
}
// нет аргументов, может что то показывать на экарне:

Merthod1();


//Метод 2. Ничего не возвращает, но может принимать 

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст соодщения");  //Выдается ровно то, что написано в консоли

void Method21(string msg, int count)
{
    i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4); // Через запятую указывается сколько раз мы хотим увидеть данное сообщение
Method21(count: 4, msg: "новый текст"); // именнованный аргумент

// 3 группа. Что то возвращают, но ничего не принимают.

int Method3()
{
    return DataTime.Now.Year;// работа
}
int year = Method3();// результат работы
Console.WriteLine(year);// 

//4 группа. которые тчо то принимают и что то возвращают

string Method4(int count, string c); // Возвращение строкой
{
    int i = 0;
    string result = ""; // String.Empty - означает, что строка результата изначально пуста
    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);

// Цикл for

string Method4(int count, string c); // Возвращение строкой
{
    for (i = 0; i < count; i++)
        string result = ""; // String.Empty - означает, что строка результата изначально пуста
    {
        result = result + c;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);


// Цикл в цикле 
// Вывод таблицы умножения на экран 

for (int i = 2; 1 <= 10; i++) //таблица умножения начинается с 2-х
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {i} * {i}");
    }
    Console.WriteLine(); // После проведенного цикла, делается искуственный разрыв для красоты - пустая строка 
}

// В тексте надо заменить пробелы черточками, 
//малеькие буквы "к" заменить большими "К", 
// а большие "С" заменить маленькими "с"

string text = "Природа с красоты своей"
+ "Покрова снять не позволяет"
+ "И ты машинами не вынудишь у ней,"
+ "Чего твой дух не угадает.";

// string s = "qwerty"
//             012
// s[3] //r  (третий индекс в кверти)

string RepLace(string text, char oldVaLue, char newVaLue);
{
    string result = String.Empty;

    int lengh = text.Length;
    for (i = 0; i < lengh; i++)
    {
        if (text[i] == oldValue) result = result + $"{newVaLue}";//Если результат совпал с тем значение, которое мы хотим заменить, то кладем в него новое значение
        else result = result + $"{text[i]}"; //Если совпадений не обнаружено, то в результат добавляем то значение, что и  было
    }
    return result;
}
string newText = RepLace(text, " ", "|");
Console.WriteLine(newText);

newText = RepLace(newText, "k", "K");
Console.WriteLine(newText);

// Упорядочиваение данных внутри массива
// Алгоритм сортировки методом выбора

// 1. Найти позицию мин эл-та в неотсортиров части массива
// 2. Произвести обмен этого значение со значением первой неотсортир/позиции
// 3. Повторять пока есть не отсортиров. эл-ты

int[] arr = { 1, 5, 7, 2, 1, 6, 9 };

void PrintArray(int[] array) //вывод массива строкой
{
    int count = array.Length;

    for (int i = 0; i < count; i++) ;
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//Упорядочевание массива

void SelectionSort(int[] array);
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = 1;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);



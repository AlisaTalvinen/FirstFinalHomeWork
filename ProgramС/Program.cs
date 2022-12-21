//Для ввода массива пользователем раскоментировать строки 48-53.
//для работы с готовым массивом раскоментировать строки 57-59.

/*
string[] CreateStringArray(int size)//метод для создания массива строк пользователем
{
    string[] array = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element of array: ");
        array[i] = Console.ReadLine();
    }
    return array;
}


string[] CreateNewArrayThreeOrLessCharacters(string[] array)//метод для создания из массива нового массива с длиной элементов 3 и менее символов
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        if (array[i].Length <= 3)
            count++;
    
    string[] newArray = new string[count];
    for (int i = 0, j = 0; i < array.GetLength(0); i++)
        {
            if (array[i].Length <= 3)
            {
                newArray[j] = array[i];
                j++;
            }
        }
    return newArray;
}


void ShowStringArray(string[] array)//метод для вывода в терминал массива строк
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

/*
Console.Write("Input size of array: ");
int num = Convert.ToInt32(Console.ReadLine());
string[] myArray = CreateStringArray(num);
ShowStringArray(myArray);
string[] miniArray = CreateNewArrayThreeOrLessCharacters(myArray);
ShowStringArray(miniArray);
*/

/*
string[] readyArray = {"alisa", "be", "talvinen", "2020", "the", "one", "!"};
string[] miniArray = CreateNewArrayThreeOrLessCharacters(readyArray);
ShowStringArray(miniArray);
*/
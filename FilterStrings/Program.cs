// Задача: Написать программу на языке c#, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", ":-)"] ->["2", "^-)"]
// ["1234", "1567", "-2", "computer science"] ->{
// "-2"]
// ["Russia", "Denmark", "Kazan"] -> []

// The code consists of three methods: ArrayCheck, FillResultArray, and PrintArray.

string[] inputArray = { "hello", "2", "world", ":-)", "1234", "1567", "Rus", "-2", "computer science", "Russia", "Denmark", "Kazan", "GB", "GBU" };

int count = ArrayCheck(inputArray);
string[] resultArray = new string[count];

// Array Check takes an array of strings as input and counts the number of elements with a length of three or less. 

int ArrayCheck(string[] inputArray)
{
    int count = 0;
    for (int i = 0; i < inputArray.Length;)
    {
        if (inputArray[i].Length <= 3)
        {
            count++;
            i++;
        }
        else
        {
            i++;
        }
    }
    return count;
}

// FillResultArray takes the input array and an empty result array as input and fills the result array with the elements from the input array that have a length of three or less.
void FillResultArray(string[] inputArray, string[] resultArray)
{
    int count = resultArray.Length;
    for (int i = 0; i < inputArray.Length;)
    {
        if (inputArray[i].Length <= 3 && count > 0)
        {
            resultArray[resultArray.Length - count] = inputArray[i];
            count--;
            i++;
        }
        else
        {
            i++;
        }
    }
}

// PrintArray takes the result array as input and prints it out in a formatted string.
void PrintArray(string[] resultArray)
{
    Console.Write("[");
    for (int i = 0; i < resultArray.Length; i++)
    {
        if (i == resultArray.Length - 1)
        {
            Console.Write($"\"{resultArray[i]}\"");
        }
        else
        {
            Console.Write($"\"{resultArray[i]}\", ");
        }
    }
    Console.WriteLine("]");
}

FillResultArray(inputArray, resultArray);
PrintArray(resultArray);

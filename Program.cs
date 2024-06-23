// Задача: Написать программу, которая из имеющегося 
// массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно 
// массивами.

// Примеры:
// ["Hello", "2", "world", ":-)"] → ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] → ["-2"]
// ["Russia", "Denmark", "Kazan"] → []

string[] GetStringArrayFromConsoleString (string stringFromConsole) // делаем из введённой строки массив
{
    string[] stringArray = stringFromConsole.Split(";"); // вычленяем из введенной строки элементы массива (разделитель - точка с запятой)
    return stringArray;
}

string[] GetNewArray(string[] startArray) // делаем новый массив из старого с учетом условия
{
	string[] resultArray = new string[startArray.Length]; //создаем новый массив, по длине равный старому
	int countOfShortElements = 0; // вводим счетчик элементов, длина которых не больше трех символов
	
	for (int i = 0; i < startArray.Length; i++)
	    {
	    if(startArray[i].Length <= 3)
	    {
	    	resultArray[countOfShortElements] = startArray[i];
	    	countOfShortElements++;
	    }
	    }
	Array.Resize(ref resultArray, countOfShortElements); // корректируем длину нового массива, обрубая его конец
	
	return resultArray;
}

void PrintArray(string[] array) // функция вывода массива
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}

Console.WriteLine("Введите массив строк, разделяя элементы массива точкой с запятой: "); // ввод массива через консоль
string inStringSimvol = Console.ReadLine(); // считываем введенную строку
string[] arraySimvol = GetStringArrayFromConsoleString(inStringSimvol); // 

Console.WriteLine("Введенный массив строк: "); // отображение полученного массива
PrintArray(GetStringArrayFromConsoleString(inStringSimvol));
Console.WriteLine();

Console.WriteLine("Новый массив, состоящий из элементов с длиной менее трех символов: "); // вывод нового массива с учетом заданного условия
PrintArray(GetNewArray(arraySimvol));
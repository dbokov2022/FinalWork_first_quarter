// Задача:
// Написать программу, которая из меющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. 


string[] SearchDataLengthInArray(string arr, int n)
{
  string[] newArray = arr.Split(",");

  for (int i = 0; i < newArray.Length; i++)
  {    
    if (newArray[i].Length > n)
        newArray[i] = string.Empty;  // заменяем элемент пустой строкой
  }
  newArray = newArray.Where(x => !string.IsNullOrEmpty(x)).ToArray();  // отбрасываем пустые элементы массива
  return newArray;  
}

int n =  3; // из условия задачи длина элементов меньше либо равна 3 символа
Console.WriteLine("Введите первоначальный массив элементов, разделяя их между собой запятой");
string startArray = Console.ReadLine() ?? "";

string[] endArray = SearchDataLengthInArray(startArray, n);
Console.WriteLine($"Новый массив из строк, длина которых меньше либо равна 3 символа: [{string.Join(", ", endArray)}]"); 
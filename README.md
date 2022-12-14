# FinalWork_first_quarter


# Контрольная работа по итогам 1 четверти

## Условие задачи

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.  
<br />



## Алгоритм решения задачи

Алгоритм решения представлен на блок-схеме:  
   <br />
   ![Блок-схема](Algoritm.png 'Блок-схема алгоритма')


## Текстовое описание решения:


1. Создаем метод для поиска элементов, длина которых меньше или равна длине, заданной в условиях задачи:

   ```c#
   string[] SearchDataLengthInArray(string arr, int n)
   ```

   1.1. Создаем новый массив, элементами которого будут строки, полученные из исходного массива по заданному разделителю (запятой):

   ```c#
   string[] newArray = arr.Split(",");
   ```

   1.2 В цикле проверяем длину каждого элемента из нового массива и, в случае, если длина > n, заменяем элемент пустой строкой:

   ```c#
    for (int i = 0; i < newArray.Length; i++)
    {    
        if (newArray[i].Length > n)
            newArray[i] = string.Empty;  // заменяем элемент пустой строкой
    }
   ```

   1.3 Отбрасываем пустые элементы массива:

   ```c#
   newArray = newArray.Where(x => !string.IsNullOrEmpty(x)).ToArray();
   ```

   1.4 Возвращаем полученный массив:

   ```c#
   return newArray;  
   ```



## 2. Основной код программы:

2.1. Иницииируем переменную n и присваиваем ей значение:
```c#
int n = 3; // из условия задачи длина элементов меньше либо равна 3 символа
```

2.2. Выводим предложение пользователю ввести первоначальный массив:
```c#
Console.WriteLine("Введите первоначальный массив элементов, разделяя их между собой запятой");
```

2.3. Вызываем ранее написанный метод поиска и замены данных в массиве:
```c#
string[] endArray = SearchDataLengthInArray(startArray, n);
```

2.4. Выводим итоговый массив в консоль:

```c#
Console.WriteLine($"Новый массив из строк, длина которых меньше либо равна 3 символа: [{string.Join(", ", endArray)}]"); 
```


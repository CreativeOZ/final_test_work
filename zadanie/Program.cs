// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Console.Clear();

string[] array= {"hello", "7", "world", ":-)"};
string[] new_array = new string [array.Length];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        new_array[count] = array[i];
        count++;
    }
}
for (int i = 0; i <= count; i++)
{
    Console.Write(new_array[i] + " ");
}
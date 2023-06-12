 /*1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []  */


string[] FillMass(string[] input, int countElements)
{
    string[] mass = new string[countElements];
    for(int i = 0, j = 0; i < input.Length && j < mass.Length; i++)
    {
        if(input[i].Length < 4)
        {
            mass[j] = input[i];
            j++;
        }
    }
    return mass;
} 


string[] input = new string [] { "Hello", "2", "world", ":-)"};
int countElements = 0;

for(int i = 0; i < input.Length; i++)
{
    if(input[i].Length < 4)
    {
        countElements++;
    }
}
 string[] result;
 
 if(countElements > 0)
 {
    result = FillMass(input, countElements);
 }
 else
 {
    result = new string[0];
 }

for(int i = 0; i < result.Length; i++)
{
    Console.Write($"{result[i]} ");
}
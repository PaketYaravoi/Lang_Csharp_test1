# Lang_Csharp_test1
 1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []  

# Описание решения задачи теста №1:

1) Входные данные создаются на старте алгоритма
2) Считаем колличество элементов в массиве у которых длина меньше 4 (за одно узнаем длину для нашего вновь созданного массива)
3) Если элементов больше 0 то вызываем функцию FillMass, А если меньше создаем пустой массив
4) Внутри функции FillMass копируем элементы с длиной меньше 4 в новый массив
5) Выводим данные в консоль.

int[] array = { 1, 12, 31, 4, 18, 15, 16, 17, 18 };

int n = array.Length; // возвращает длину - кол-во элементов массива
int find = 18;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        System.Console.WriteLine(index);
        break; //прерывает цикл, если найдено первое нужное значение
    }
    // index = index + 1
    index++;
}

//Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//Результат запишите в новом массиве.

Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string elements = Console.ReadLine();
int[] baseArray = GetArrayFromString(elements);

Console.WriteLine(String.Join(" ", ResultArray(baseArray)));

int[] GetArrayFromString(string stringArray)
{
string[] nums = stringArray.Split();
int[] res = new int[nums.Length];

for (int i = 0; i < nums.Length; i++)
{
res[i] = int.Parse(nums[i]);
}
return res;
}

int[] ResultArray(int[] array)
{
int[] result = new int[array.Length / 2 + array.Length % 2];
for (int i = 0; i < result.Length; i++)
{
if (i == array.Length - 1 - i) result[i] = array[i];
else result[i] = array[i] * array[array.Length - 1 - i];
}
return result;
}
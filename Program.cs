
string[] initialArray = { "one", "1", "three", ")_90909", "five", "six", "seven", "eight", "nine", "ten" };


int newArraySize = 0;
foreach (string str in initialArray)
{
    if (str.Length <= 3)
    {
        newArraySize++;
    }
}

string[] newArray = new string[newArraySize];
int index = 0;
foreach (string str in initialArray)
{
    if (str.Length <= 3)
    {
        newArray[index] = str;
        index++;
    }
}

Console.WriteLine("Новый массив строк, длина которых меньше или равна 3 символам:");
foreach (string str in newArray)
{
    Console.WriteLine(str);
}
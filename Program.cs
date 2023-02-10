
string[] createStringArray(int size)
{
    string[] arr = new string[size];
    fillStringArray(arr);
    return arr;
}

void printArray(string[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine("]");
}

void fillStringArray(string[] arr)
{
    int ind = 0;
    while (ind < arr.Length)
    {
        string temp;
        System.Console.Write($"enter {ind + 1} string: ");
        temp = Console.ReadLine();
        while (temp == "")
        {
            System.Console.Write($"enter {ind} string: ");
        }
        arr[ind] = temp;
        ind++;
    }
}

string[] createArrayOfShortWords(int wordLength, string[] arr)
{
    int newLength = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= wordLength)
            newLength++;
    }

    string[] newArr = new string[newLength];
    newLength = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= wordLength)
        {
            newArr[newLength] = arr[i];
            newLength++;
        }
    }
    return newArr;
}

int size = new Random().Next(1, 10);
System.Console.WriteLine($"Please enter {size} words:");
string[] arr = createStringArray(size);
printArray(arr);
int wordLength = 3;

string[] shortArr = createArrayOfShortWords(wordLength, arr);
printArray(shortArr);
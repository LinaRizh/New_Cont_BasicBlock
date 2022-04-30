using static System.Console;

string [] Array = new string [] {"привет","111","кот","солнце","2","сон", "787", "gytrer7", "905", "gh", "880"};

int kolich(string [] ar)
{
    int count = 0;
        for (int i=0; i<Array.Length; i++)
            {
                if (Array[i].Length<4) {count++;}
            }
    return count;
}

void SmallStr (string [] arr, string[] arr2)
{
    int j = 0;
    for (int i =0; i<arr.Length; i++)
    {
        if (arr[i].Length<4)
        {
            arr2[j]= arr[i];
            j++;
        }
    }
}

int a = kolich(Array);
string [] new_array = new string [a];
SmallStr(Array,new_array);
WriteLine(string.Join(" ", new_array));
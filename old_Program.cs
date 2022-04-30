using static System.Console;
string [] Array = new string [] {"привет","111","кот","солнце","2","сон"};
int j = 0;
string s = String.Empty;
string [] new_array = new string [Array.Length];
for (int i =0; i<Array.Length; i++)
{
    if (Array[i].Length<4)
    {
        new_array[j] = Array[i];
        Write($"{new_array[j]} ");     // если не удалять эту строку, код сработает корректно при любом наборе данных
    }
}
WriteLine();

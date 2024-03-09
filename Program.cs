Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
string[] array = new string[n];
int countStrMinLength = 0;
int range = 3;
int pos = 0;

string itemString(){
    Random res = new Random(); 
    String str = "abcdefghijklmnopqrstuvwxyz0123456789 )(''[];/.=+-#&*@$%^?!~"; 
    int size = res.Next(10);
    String randomstring = ""; 

    for (int i = 0; i < size; i++) 
    { 
        int x = res.Next(str.Length); 
        randomstring = randomstring + str[x]; 
    } 
    return randomstring;
}

for (int i = 0; i < array.Length; i++) {
    string newStr = itemString();
    int strLength = newStr.Length;
    if(strLength <= range) {
        countStrMinLength++;
    }
    array[i] = newStr;
}

string[] resultArr = new string[countStrMinLength];
for (int i = 0; i < array.Length; i++) {
    if(array[i].Length <= range && pos < countStrMinLength) {
        resultArr[pos] = array[i];
        pos++;
    }
}

Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Конечный массив: [{string.Join(", ", resultArr)}]");
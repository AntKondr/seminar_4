Console.Clear();
Console.Write("Seminar_4 task_27\n\n");

int digits_sum(string num){
    int sum = 0;
    for (int i = 0; i < num.Length; i++){
        sum += Convert.ToInt32($"{num[i]}");
    }
    return sum;
}

Console.Write("input number: ");
Console.Write($"sum of digits of number = {digits_sum(Console.ReadLine())}");
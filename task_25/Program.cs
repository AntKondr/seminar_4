Console.Clear();
Console.Write("Seminar_4 task_25\n\n");

double pow(double num, int rate){
    double res = 1;
    int count = 0;
    while (count < rate){
        res = res * num;
        count += 1;
    }
    return res;
}

Console.Write("input number: ");
double number = Convert.ToDouble(Console.ReadLine());

Console.Write("input power: ");
int power = Convert.ToInt32(Console.ReadLine());

Console.Write($"{number} in {power} power = {pow(number, power)}");
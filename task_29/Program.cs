Console.Clear();
Console.Write("Seminar_4 task_29\n\n");

int clamp(int num){
    if (num > 200){
        num = 200;
        Console.Write("height exceeds the max, height set at 200\n");
        return num;
    }
    else if (num < 40){
        num = 40;
        Console.Write("height less than 40, height set at 40\n");
        return num;
    }
    else {
        return num;
    }
}

int place_in_line(int[] line, int height){
    for (int i = 0; i < line.Length; i++){
        if (height > line[i]){
            return i + 1;
        }
    }
    return line.Length + 1;
}

Console.Write("input schoolboys amount: ");
int schoolboys_amount = Convert.ToInt32(Console.ReadLine());

while (schoolboys_amount < 5 | schoolboys_amount > 100){
    Console.Write("input correct schoolboys amount: ");
    schoolboys_amount = Convert.ToInt32(Console.ReadLine());
}
Console.Write("\n");

int[] heights = new int[schoolboys_amount];

for (int i = 0; i < heights.Length; i++){
    Console.Write($"input schoolboys{i + 1} height: ");
    heights[i] = clamp(Convert.ToInt32(Console.ReadLine()));
    Console.Write("\n");
}

Console.Write("input height of Petka: ");
int petka_height = clamp(Convert.ToInt32(Console.ReadLine()));
Console.Write("\n");

Console.Write($"Petka must stand on {place_in_line(heights, petka_height)} place");
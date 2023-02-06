Console.Clear();
Console.Write("Seminar_4 task_add_1\n\n");

void print_array(int[] array){
    Console.Write("[");
    for (int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]}, ");
    }
    Console.Write("\b\b]\n");
}

int[] scroll(int[] array, int k){
    k = k % array.Length;
    if (k == 0){
        return array;
    }
    else if (k > 0){
        int[] new_array = new int[array.Length];
        k = array.Length - k;
        for (int i = 0; i < array.Length; i++){
            new_array[i] = array[k];
            k += 1;
            if (k == array.Length){
                k = 0;
            }
        }
        return new_array;
    }
    else {
        int[] new_array = new int[array.Length];
        k = k * (-1);
        for (int i = 0; i < array.Length; i++){
            new_array[i] = array[k];
            k += 1;
            if (k == array.Length){
                k = 0;
            }
        }
        return new_array;
    }
}

Console.Write("input item amount: ");
int amount = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[amount];
for (int i = 0; i < arr.Length; i++){
    arr[i] = new Random().Next(1, 10);
}
Console.Write("array ->  ");
print_array(arr);

Console.Write("input k: ");
int k = Convert.ToInt32(Console.ReadLine());

Console.Write("scroll -> ");
print_array(scroll(arr, k));
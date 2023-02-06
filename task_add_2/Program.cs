Console.Clear();
Console.Write("Seminar_4 task_add_2\n\n");

void print_array(int[] array){
    Console.Write("[");
    for (int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]}, ");
    }
    Console.Write("\b\b]\n");
}

bool is_simple(int num){
    for (int divider = 2; divider < ((num / 2) + 1); divider++){
        if ((num % divider) == 0){
            return false;
        }
    }
    return true;
}

int[] all_simple_nums(int num){
    int count = 0;
    for (int i = 2; i < num; i++){
        if (is_simple(i)){
            count += 1;
        }
    }
    int[] simples = new int[count];
    int index = 0;
    for (int i = 2; i < num; i++){
        if (is_simple(i)){
            simples[index] = i;
            index += 1;
        }
    }
    return simples;
}

int[] two_simp_slags(int num){
    int[] two_nums = new int[2];
    int[] all_simples = all_simple_nums(num);
    bool stop = false;
    for (int i = 0; i < all_simples.Length; i++){
        for (int j = 0; j < all_simples.Length; j++){
            if (all_simples[i] + all_simples[j] == num){
                two_nums[0] = all_simples[i];
                two_nums[1] = all_simples[j];
                stop = true;
                break;
            }
        }
        if (stop){
            break;
        }
    }
    return two_nums;
}

Console.Write("input number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"{num} -> ");
print_array(two_simp_slags(num));
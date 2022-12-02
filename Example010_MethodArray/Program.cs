Console.Clear();

int[] array = {4, 8, 87, 54, 89, 88, 24, 89, 95};
int n = array.Length;
int find = 89;
int index = 0;

while (index < n) {
    if (array[index] == find) {
        Console.WriteLine(index);
        break;
    }
    index++;
}
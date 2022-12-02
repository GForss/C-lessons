Console.Clear();

vold FillArray(int[] collection) {
    int length = collection.Length;
    int index = 0;
    while (index < length) {
        collection[index] = new Random().Next(1, 12);
        index++;
    }
}

int[] array = new int[10];
//int n = 10;
int[] arr = { 2, 3, 4, 5, 8, 35, 1, 3, 8, 5 };
int i = 0;

while(i < arr.Length) {
    if(arr[i] % 2 == 0) {
        System.Console.Write($"{arr[i]} ");
    }
    i++;
}
//Напишите программу, которая задаёт массив из 
//8 элементов и выводит их на экран.
int[] arr_a(int length_arr){
    int[] arr = new int[length_arr];
    for(int i = 0; i < arr.Length; i ++){
    arr[i] =  new Random().Next(100);
    Console.Write($"{arr[i]}, ");
}
    return arr;
}
Console.WriteLine("Введите число : ");

int num = int.Parse(Console.ReadLine()!);
Console.Write("[");
int[] d = arr_a(num);
Console.Write("]");

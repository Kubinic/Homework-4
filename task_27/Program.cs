/* Напишите программу, которая принимает 
на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
Console.WriteLine("Введите число : ");
int numb = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNumbers(numb));


int SumNumbers( int numb){
    int sum = 0;
int digit = 0;
for (int i = 1; numb > 0; i++){
    digit = numb % 10;
sum += digit;
numb /= 10;
}
return sum;
}


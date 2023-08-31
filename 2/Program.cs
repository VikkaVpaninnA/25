// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
int getNumber (){
    Console.WriteLine("Введите число ");
    int T = Convert.ToInt32(Console.ReadLine());
    return T;
}

int Sum(int number){
    int N=number;
    int T=0;
    while (N>0)
    {
        T=T+N%10;
        N=N/10;
    }
    return T;

}
int number=getNumber();
int T=Sum(number);
Console.WriteLine($"{T}");

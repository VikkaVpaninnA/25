// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int getNumber (){
    Console.WriteLine("Введите число А");
    int numberA = Convert.ToInt32(Console.ReadLine());
    return numberA;
    
}
int getNumber2 (){
    Console.WriteLine("Введите число В");
    int numberB = Convert.ToInt32(Console.ReadLine());
    return numberB;
}
int getВegree (int numberA,int numberB){
    int A=numberA;
    int B=numberB;
    int c=1;
    for (int i = 0; i < B; i++)
    {
        c *= A;
    }
    return c;
}
int number=getNumber();
int number2=getNumber2();
int c=getВegree(number,number);
Console.WriteLine($"{c}");
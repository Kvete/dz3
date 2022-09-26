/*
Задача 19
Напишите программу, которая принимает на вход число 
и проверяет является ли оно палиндромом
*/
Console.WriteLine("введите число");
int number=Convert.ToInt32(Console.ReadLine());
int count=0, chislo=number, flag=0;//подсчет цифр в числе

while (chislo>0)
{
    chislo=chislo/10;
    count++;
}

int[] array =new int [count];

for (int i=1; i<=count; i++)
{
    array[count-i]=number%10;
    number=number/10;
}

for (int i=0; i<=count/2; i++)
{
    if (array[i]==array[count-i-1])
    {
        flag=1;
    }
    else 
    {
        flag=0;
    }
    
    break;
}
if (flag==0)
{   
    Console.WriteLine("не полином");
}
else
{
   Console.WriteLine("полином"); 
}

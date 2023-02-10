/*Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */
int number = GetNumber();

int GetNumber()
{
 Console.WriteLine("Введите пятизначное число:");
 int number = Convert.ToInt32(Console.ReadLine());
 return number;
}


 int firstDigit(int num1)
 {
 num1 = number / 10000;
 return num1;
 }
 
  int secondDigit(int num2)
  {
  num2 = (number / 1000) % 10;
  return num2;
  }

   int fourthDigit(int num4)
   {
   num4 = (number / 10) % 10;
   return num4;
   }
 
    int fifthDigit (int num5)
    {
    num5 = number % 10;
    return num5;
    }

int GetResult()
{
    if (firstDigit == fifthDigit && secondDigit == fourthDigit)
    {
    Console.WriteLine("Является палиндромом");
    }
    else Console.WriteLine("Не является полиндромом");
return number;
}

GetResult();

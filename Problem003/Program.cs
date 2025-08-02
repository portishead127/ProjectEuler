//Ans - 6857

long num = 600851475143;

int currentDivisor = 3;

do{
 if(num % currentDivisor == 0) num = num/currentDivisor;
 else currentDivisor = currentDivisor += 2;
}while(num != 1);

Console.Write(currentDivisor);
Console.Read();

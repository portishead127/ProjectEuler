//4613732
int sum = 2;
bool numExceeded = false;
Fibonnaci(1,2);

Console.Write(sum);
Console.Read();

void Fibonnaci(int first, int second){
  int tempSum = first + second;
  if(tempSum > 4000000 || numExceeded){
    numExceeded = true;
    return;
  }
  if(tempSum % 2 == 0) sum += tempSum;
  Fibonnaci(second, tempSum);
}

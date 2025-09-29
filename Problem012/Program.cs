int targetDivisors = 500;
long currentTriangleNum = 1;
while(numOfDivisors(currentTriangleNum) <= targetDivisors) currentTriangleNum = currentTriangleNum + currentTriangleNum + 1;
Console.WriteLine(currentTriangleNum);

int numOfDivisors(long n){
  int divisors = 0;
  int count = 1;
  while(count < n){
    if(n % count == 0) divisors++;
    count++;
  }
  return divisors;
}

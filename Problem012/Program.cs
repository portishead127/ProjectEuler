//76576500
int targetDivisors = 500;
long currentTriangleNum = 0; 

for(int i = 1; ; i++){
  currentTriangleNum += i;
  if(numOfDivisors(currentTriangleNum) >= targetDivisors){
    Console.WriteLine(currentTriangleNum);
    return;
  }
}


int numOfDivisors(long n){
  double sqrt = Math.Sqrt(n);
  int divisors = 0;
  for(int i = 1; i < sqrt; i++){
    if(n % i == 0){
      divisors += 2;
    }
  }
  if(sqrt * sqrt == n) divisors++;
  return divisors;
}

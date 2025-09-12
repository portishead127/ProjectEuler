//Ans - 142913828922

int target = 2000000;

long sum = 0;
for(long i = 2; i < target; i++){
  if(IsPrime(i)) sum += i;
}

Console.WriteLine(sum);

bool IsPrime(long num){
  double sqrNum = Math.Floor(Math.Sqrt(num));
 
  for (int i = 2; i <= sqrNum; i++){
    if(num % i == 0) return false;
  }
  return true;
}

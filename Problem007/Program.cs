//Ans - 104743
//This solution is probably very bare bones

int targetPrime = 10001;
int primesFound = 0;
int numBeingChecked = 1;//First prime

while(primesFound != targetPrime){
  numBeingChecked++;
  bool currentNumIsPrime = IsPrime(numBeingChecked);

  if(currentNumIsPrime){
    primesFound++;
  }
}

Console.WriteLine(numBeingChecked);


bool IsPrime(int num){
  int sqrtOfNum = (int)Math.Floor(Math.Sqrt(num));
  for(int i = 2; i <= sqrtOfNum; i++){
    if(num % i == 0) return false;
  }
  return true;
}

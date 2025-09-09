//Ans - 25164150

int target = 100;
int sumOfSquares = SumOfSquares();
int squareOfSum = SquareOfSum();

int SumOfSquares(){
  int total = 0;
  for(int i = 1; i <= target; i++){
    total += i *i;
  }
  return total;
} 

int SquareOfSum(){
  int total = 0;
  for(int i = 1; i <= target; i++){
    total += i;
  }
  return total * total;
}

int ans = squareOfSum - sumOfSquares;
Console.WriteLine(ans);


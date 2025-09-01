int target = 100;

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

Console.WriteLine("Sum of squares: " + SumOfSquares());
Console.WriteLine("Square of sum: " + SquareOfSum());


//Finding pythag triplets
//a^2 + b^2 = c^2
//Some triplet where a + b + c = 1000
int maxC = 1000;

for(double a = 1; a < maxC; a++){
  for(double b = 1; b < maxC; b++){
    double cSquared = a*a + b*b;
    if(isPerfectSquare(cSquared)){
      CheckEligibility(a,b,Math.Sqrt(cSquared));
    }
  }
}

bool isPerfectSquare(double num){
  double root = Math.Sqrt(num);
  if(Math.Round(root) == root) return true;
  return false;
}

void CheckEligibility(double a, double b, double c){
  if(a + b + c == 1000) {
    Console.WriteLine(a*b*c);
  }
}


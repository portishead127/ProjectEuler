//There is absolutely no chance this is the fastest way to find this
//Ans - 906609

int maxPalindrome = -1;

for(int i = 100; i < 1000; i++){
  for(int j = 100; j < 1000; j++){
    int prod = i * j;
    if(isPalindromic(prod) && prod > maxPalindrome) maxPalindrome = prod;
  }
}

Console.Write(maxPalindrome);

bool isPalindromic(int num){
  char[] digits = num.ToString().ToCharArray();
  bool palindromic = true;
  for(int i = 0; i < digits.Length/2; i++){
    if(digits[i] != digits[digits.Length - 1 - i]) palindromic = false;
  }
  return palindromic;
}

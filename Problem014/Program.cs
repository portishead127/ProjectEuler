int maxStartingNum = 1000000;
int max = 0;

for(int i = 1; i < maxStartingNum; i++){
  int num = i;
  while(num > 1){
    if(num % 2 == 0) num = evenMethod(num);
    else num = oddMethod(num);

    if(num > max) max = num;
  }
}

Console.WriteLine(max);

int evenMethod(int num){
  return num/2;
}

int oddMethod(int num){
  return (3 * num) + 1;
}

#include <iostream>

int MAX_NUMBER = 1000000;

int collatz(unsigned long input) {
  int chainLength = 0;
  do {
    chainLength++;

    if (input % 2 == 0) {
      input /= 2;
    } else {
      input = (3 * input) + 1;
    }
  } while (input != 1);
  return chainLength;
}

int main(int argc, char *argv[]) {
  int longestChain = 0;
  unsigned long longestChainValue = 0;
  for (int i = 1; i < MAX_NUMBER; i++) {
    int chain = collatz(i);
    if (chain > longestChainValue) {
      longestChain = i;
      longestChainValue = chain;
    }
  }
  std::cout << longestChain << std::endl;
  return 0;
}

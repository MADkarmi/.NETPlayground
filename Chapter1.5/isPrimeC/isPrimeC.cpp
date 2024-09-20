#include <stdbool.h>

extern "C" __declspec(dllexport) bool  IsPrimeC(int x);

  bool IsPrimeC(int x)
  {
    int i;
    for (i = 2; i <= x - 1; i++)
    {
      if (x % i == 0)
      {
        return false;
      }
    }
    if (i == x)
      return true;

    return false;
  }
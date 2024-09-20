#include <windows.h>
#include <stdio.h>

int main()
{
	typedef bool (__stdcall *IsPrime)(int);
	
	HMODULE library = LoadLibrary("isPrimeC.dll");
	if (library == NULL)
	{
		printf("brak biblioteki");
		return 1;
	}
	IsPrime isPrime = (IsPrime)GetProcAddress(library, "IsPrimeC");
	if (isPrime == NULL)
	{
		printf("brak funkcji");
		return 1;
	}

	printf("%d", isPrime(5));
}
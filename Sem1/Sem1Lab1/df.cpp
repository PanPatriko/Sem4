#include <stdio.h>
#include<math.h>
int main()
{
    float a,b,c,wynik,wynikk,d,e,obwod,pole;
	printf("Podaj bok a trojkata");
		scanf("%f", &a);
	printf("Podaj bok b trojkata");
		scanf("%f", &b);
    printf("Podaj bok c trojkata");
		scanf("%f", &c);
		printf("Podaj bok a prostokata");
		scanf("%f", &d);
		printf("Podaj bok b prostokata");
		scanf("%f", &e);
	wynik = sqrt((a+b+c)*(-a+b+c)*(a-b+c)*(a+b-c))/4; //obliczanie pola
    printf("Pole trojkata jest rowne %f \n", wynik); // zmienna pole pojawi sie w miejscu %f a \n oznacza przejscie do nowej linii
	wynikk = a+b+c; //obliczanie obwodu
	printf("Obwod trojkata jest rowny %f \n", wynikk);
	obwod = 2*(d+e);
	 printf("Obwod prostokata jest rowny %f \n", obwod);
	 pole=d*e;
	 printf("Pole prostokata jest rowne %f \n", pole);
	return 0;

}

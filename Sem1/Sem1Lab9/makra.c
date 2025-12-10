#include <stdlib.h>
#include <stdio.h>
#include "plik.h"

int main()
{
    int x,a,b;
    float aa,bb,r,P,O,h,d;
    do
    {
    printf("1.Wyznacz max\n");
    printf("2.Wyznacz min\n");
    printf("3.Oblicz avg\n");
    printf("4.Oblicz pole i obwod kola\n");
    printf("5.Oblicz przekatna kwadratu\n");
    printf("6.Oblicz wysokosc i pole powierzchni trojkata rownobocznego\n");
    printf("7.Koniec\n");
    scanf("%d",&x);
    system("cls");
    if(x==1)
    {
        printf("Podaj dwie liczby\n");
        scanf("%d",&a);
        scanf("%d",&b);
        printf("MAX = %d\n",MAX(a,b));
    }
    if(x==2)
    {
        printf("Podaj dwie liczby\n");
        scanf("%d",&a);
        scanf("%d",&b);
        printf("MIN = %d\n",MIN(a,b));
    }
    if(x==3)
    {
        printf("Podaj dwie liczby\n");
        scanf("%f",&aa);
        scanf("%f",&bb);
        a=aa;
        b=bb;
        printf("AVG liczb %d i %d to %f\n",a,b,AVG(aa,bb));
    }
    if(x==4)
    {
        printf("Podaj promien kola\n");
        scanf("%f",&r);
        P=r*r*PI;
        O=2*PI*r;
        printf("Pole wynosi %f\nObwod wynosi %f\n",P,O);
    }
    if(x==5)
    {
        printf("Podaj dlugosc boku\n");
        scanf("%f",&aa);
        d=aa*SQRT2;
        printf("Przekatna wynosi %f\n",d);
    }
    if(x==6)
    {
        printf("Podaj dlugosc boku\n");
        scanf("%f",&aa);
        h=(aa*SQRT3)/2;
        P=(aa*aa*SQRT3)/4;
        printf("Wysokosc wynosi %f\nPole wynosi %f\n",h,P);
    }
    }while(x!=7);
}


#include <stdio.h>
#include <stdlib.h>
float pole_prostokata(float a,float b)
{
    return a*b;
}
float pole_prostopadloscianu(float a,float b,float h)
{
    float podstawa,bok_a,bok_b;
    podstawa=pole_prostokata(a,b);
    bok_a=pole_prostokata(a,h);
    bok_b=pole_prostokata(b,h);
    return (podstawa*2)+(bok_a*2)+(bok_b*2);
}
float objetosc_prostopadloscianu(float a,float b,float h)
{
        return a*b*h;
}
float objetosc_ostroslupa(float a,float h)
{
    float podstawa=pole_prostokata(a,a);
    return podstawa*h/3;
}
int main()
{
    int menu;
    float a,b,h;
    do
    {
        printf("1.Pole prostokata\n");
        printf("2.Pole kwadratu\n");
        printf("3.Pole powierzchni calkowitej prostopadloscianu\n");
        printf("4.Pole powierzchni calkowitej szescianu\n");
        printf("5.Objetosc prostopadloscianu\n");
        printf("6.Objetosc szescianu\n");
        printf("7.Objetosc piramidy\n");
        printf("8.Objetosc piramidy schodkowej\n");
        printf("9.Koniec\n");
        scanf("%d",&menu);
        system("cls");
        switch(menu)
        {
            case 1:
                printf("Podaj bok a\n");
                scanf("%f",&a);
                printf("Podaj bok b\n");
                scanf("%f",&b);
                printf("Pole prostokata wynosi %f\n",pole_prostokata(a,b));
            break;
            case 2:
                printf("Podaj bok kwadratu\n");
                scanf("%f",&a);
                printf("Pole kwadratu wynosi %f\n",pole_prostokata(a,a));
            break;
            case 3:
                printf("Podaj bok a podstawy\n");
                scanf("%f",&a);
                printf("Podaj bok b podstawy\n");
                scanf("%f",&b);
                printf("Podaj wysokosc prostopadloscianu\n");
                scanf("%f",&h);
                printf("Pole calkowite prostopadloscianu wynosi %f\n",pole_prostopadloscianu(a,b,h));

            break;
            case 4:
                printf("Podaj dlugosc krawedzi\n");
                scanf("%f",&a);
                printf("Pole calkowite szecianu wynosi %f\n",pole_prostopadloscianu(a,a,a));
            break;
            case 5:
                printf("Podaj bok a podstawy\n");
                scanf("%f",&a);
                printf("Podaj bok b podstawy\n");
                scanf("%f",&b);
                printf("Podaj wysokosc prostopadloscianu\n");
                scanf("%f",&h);
                printf("Objetosc prostopadloscianu wynosi %f\n",objetosc_prostopadloscianu(a,b,h));
            break;
            case 6:
                printf("Podaj dlugosc krawedzi\n");
                scanf("%f",&a);
                printf("Objetosc szecianu wynosi %f\n",objetosc_prostopadloscianu(a,a,a));
            break;
            case 7:
                printf("Podaj dlugosc podstawy\n");
                scanf("%f",&a);
                printf("Podaj wysokosc piramidy\n");
                scanf("%f",&h);
                printf("Objetosc piramidy wynosi %f\n",objetosc_ostroslupa(a,h));
            break;
            case 8:
u
            break;
            case 9:
                menu=9;
            break;
            default:
                 printf("Nie ma takiej opcji\n");
            break;
        }
    }
    while(menu!=9);
    return 0;
}

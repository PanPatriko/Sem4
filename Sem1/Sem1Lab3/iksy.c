#include <stdio.h>
int main()
{
int x;
    do
    {
        printf("1.X-Poziomo\n2.X-Pionowo\n3.X-Prostokat\n4.X-PoziomoOdKrawedzi\n5.X-PionowoOdKrawedzi\n6.X-Piramida\n7.X-PustyProstokat\n8.Koniec\nWybierz Opcje:");
        scanf("%d",&x);
        if(x==1)
        {
            int dlugosc,i;
            printf("Podaj dlugosc");
            scanf("%d",&dlugosc);
            for(i=0;i<dlugosc;i++)
            {
                printf("x");
            }
            printf("\n");
        }
        if(x==2)
        {
            int dlugosc,i;
            printf("Podaj dlugosc");
            scanf("%d",&dlugosc);
            for(i=0;i<dlugosc;i++)
            {
                printf("x\n");
            }
            printf("\n");
        }
        if(x==3)
        {
            int wys,szer,i,j;
            printf("Podaj wysokosc");
            scanf("%d",&wys);
            printf("Podaj szerokosc");
            scanf("%d",&szer);
            for(j=0;j<wys;j++)
            {
               for(i=0;i<szer;i++)
                {
                    printf("x");

                }
                printf("\n");
            }
        }
        if(x==4)
        {
            int lewo,gora,dlugosc,i,j,k;
            printf("Podaj odleglosc z lewej");
            scanf("%d",&lewo);
            printf("Podaj ogleglosc z gory");
            scanf("%d",&gora);
            printf("Podaj dlugosc");
            scanf("%d",&dlugosc);
            for(i=0;i<gora;i++)
            {
                printf("\n");
            }
            for(j=0;j<lewo;j++)
            {
                printf(" ");
            }
            for(k=0;k<dlugosc;k++)
            {
                printf("x");
            }
            printf("\n");
         }
         if(x==5)
         {
            int lewo,gora,dlugosc,i,j,k;
            printf("Podaj odleglosc z lewej");
            scanf("%d",&lewo);
            printf("Podaj ogleglosc z gory");
            scanf("%d",&gora);
            printf("Podaj dlugosc");
            scanf("%d",&dlugosc);
            for(i=0;i<gora;i++)
            {
                printf("\n");
            }

            for(k=0;k<dlugosc;k++)
            {
                for(j=0;j<lewo;j++)
                {
                printf(" ");
                }
                printf("x\n");
            }
         }
         if(x==6)
         {
            int x,i,k;
            printf("Podaj liczbe pieter");
            scanf("%d",&x);
            for (i=1; i<=x; i++)
                {
                    for (k=1; k<=i; k++)
                        {
                            printf("x");
                        }
                    printf("\n");
                }

         }
         if(x==7)
         {
           int wys,szer,i,j;
            printf("Podaj wysokosc");
            scanf("%d",&wys);
            printf("Podaj szerokosc");
            scanf("%d",&szer);
            for(i=0;i<szer;i++)//gora
                {
                    printf("x");
                }

            for(j=2;j<wys;j++)
                {
                    printf("\n");
                    printf("x");
                    for(i=3;i<=szer;i++)
                        {
                            printf(" ");
                            if(i==szer)
                                {
                                    printf("x");
                                }
                        }

                }
                printf("\n");
            for(i=0;i<szer;i++)//dol
                {
                    printf("x");
                }
            printf("\n");
         }
    }
    while(x<8);
}

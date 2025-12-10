#include <stdio.h>
#include <stdlib.h>
int main()
{
    int tablica[100][100];
    int dx,wyb,y,x,i,j,suma,przekatna,wiersz,kolumna,liczba,szerokosc;
    do
    {
        printf("1.Podaj rozmiar tablicy\n");
        printf("2.Wype³nij tablice podana liczba\n");
        printf("3.Wyswietl tablice\n");
        printf("4.Wprowadz liczbe(x,y)\n");
        printf("5.Wypelnij wiersz kolejnymi liczbami\n");
        printf("6.Wypelnij kolumne kolejnymi liczbami\n");
        printf("7.Wypelnij tablice kolejnymi liczbami\n");
        printf("8.Sumy w wierszach\n");
        printf("9.Sumy w kolumnach\n");
        printf("10.Sumy po przekatnych\n");
        printf("11.Koniec\n");
        scanf("%d",&wyb);
        system("cls");
        switch(wyb)
        {
        case 1:
            printf("Podaj liczbe wierszy: ");
            scanf("%d",&wiersz);
            printf("Podaj liczbe kolumn: ");
            scanf("%d",&kolumna);

        break;
        case 2:
            printf("Podaj liczbe:");
            scanf("%d",&liczba);

            for(i=0;i<wiersz;i++)
            {
                for(j=0;j<kolumna;j++)
                {
                    tablica[i][j]=liczba;
                }
                tablica[i][j]=liczba;
            }
        break;
        case 3:

            for(i=0;i<wiersz;i++)
            {
                for(j=0;j<kolumna;j++)
                {
                    if(tablica[i][j]<10)
                    {
                        printf("%d   ",tablica[i][j]);
                    }
                    else if(tablica[i][j]<100)
                    {
                       printf("%d  ",tablica[i][j]);
                    }
                    else
                    {
                        printf("%d ",tablica[i][j]);
                    }
                }
                printf("\n");
            }
        break;
        case 4:
            printf("Podaj liczbe\n");
            scanf("%d",&liczba);
            printf("Podaj wiersz\n");
            scanf("%d",&x);
            printf("Podaj kolumne\n");
            scanf("%d",&y);
            tablica[x-1][y-1]=liczba;
        break;

        case 5:

            printf("Podaj liczbe\n");
            scanf("%d",&liczba);
            printf("Podaj wiersz\n");
            scanf("%d",&x);
            for(i=0;i<kolumna;i++)
            {
                tablica[x-1][i]=liczba;
                ++liczba;
            }
        break;
        case 6:
            printf("Podaj liczbe\n");
            scanf("%d",&liczba);
            printf("Podaj kolumne\n");
            scanf("%d",&x);
            for(i=0;i<wiersz;i++)
            {
                tablica[i][x-1]=liczba;
                ++liczba;
            }
        break;
        case 7:
            printf("Podaj liczbe\n");
            scanf("%d",&liczba);
            for(i=0;i<wiersz;i++)
            {
                for(j=0;j<kolumna;j++)
                {
                    tablica[i][j]=liczba;
                    ++liczba;
                }
                tablica[i][j]=liczba;

            }
        break;
        case 8:
            suma=0;

            for(i=0;i<wiersz;i++)
            {
                for(j=0;j<kolumna;j++)
                {

                    suma=suma+tablica[i][j];

                }
                printf("Suma wiersza %d wynosi:%d\n",i+1,suma);
                suma=0;
            }
        break;
        case 9:
            suma=0;

            for(i=0;i<kolumna;i++)
            {
                for(j=0;j<wiersz;j++)
                {

                    suma=suma+tablica[j][i];

                }
                printf("Suma kolumny %d wynosi:%d\n",i+1,suma);
                suma=0;
            }

        break;
        case 10:

            i=0;
            j=0;
            przekatna=0;
            dx=0;

            if(wiersz<=kolumna)
            {
            szerokosc=wiersz;
            }
            else
            {
            szerokosc=kolumna;
            }
                while(dx<=szerokosc-1)
                {
                    przekatna=przekatna+tablica[i][j];
                    ++i;
                    ++j;
                    dx++;
                }
                printf("Suma przekatnej 1 wynosi:%d\n",przekatna);

                przekatna=0;
                i=wiersz-1;
                j=0;
                dx=0;

                while(dx<=szerokosc-1)
                {
                    przekatna=przekatna+tablica[i][j];
                    --i;
                    ++j;
                    dx++;
                }

                printf("Suma przekatnej 2 wynosi:%d\n",przekatna);


                przekatna=0;
                i=0;
                j=kolumna-1;
                dx=0;
                if(wiersz!=kolumna)
                {
                while(dx<=szerokosc-1)
                {
                    przekatna=przekatna+tablica[i][j];
                    ++i;
                    --j;
                    ++dx;
                }
                printf("Suma przekatnej 3 wynosi:%d\n",przekatna);

                przekatna=0;
                i=wiersz-1;
                j=kolumna-1;
                dx=0;

                while(dx<=szerokosc-1)
                {
                    przekatna=przekatna+tablica[i][j];
                    --i;
                    --j;
                    dx++;
                }
                printf("Suma przekatnej 4 wynosi:%d\n",przekatna);
                }
        break;
        }
    }while(wyb!=11);
}


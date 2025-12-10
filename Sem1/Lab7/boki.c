#include <stdio.h>
int main()
{
int x,boki,i,j,nbok,obwod,nr;
int tablica[100];
boki=0;
do
{

    printf("1.Wprowadz boki\n2.Wyswietl boki\n3.Oblicz obwod\n4.Wyswietl bok nr\n5.Podmien bok\n6.Dopisz bok\n7.Wstaw bok\n8.Usun bok\n9.Koniec\n");
    scanf("%d",&x);
    system("cls");
    switch(x)
    {
        case 1:
            printf("Podaj ilosc bokow");
            scanf("%d",&boki);
            printf("Podaj boki\n");
            for(i=0;i<boki;i++)
            {
                printf("Bok %d: ",i+1);
                scanf("%d",&tablica[i]);
            }

        break;
        case 2:
            for(i=0;i<boki;i++)
            {
                printf("Bok[%d]=%d\n",i+1,tablica[i]);
            }
        break;
        case 3:
            obwod=0;
            for(i=0;i<boki;i++)
            {
            obwod=obwod+tablica[i];
            }
            printf("Obwod wynosi:%d\n",obwod);
        break;
        case 4:
            printf("Podaj nr boku");
            scanf("%d",&nr);
            printf("Bok %d wynosi %d\n",nr,tablica[nr-1]);
        break;
        case 5:
            printf("Podaj nr boku");
            scanf("%d",&nr);
            printf("Podaj nowy bok");
            scanf("%d",&tablica[nr-1]);
        break;
        case 6:
            printf("Podaj bok\n");
            scanf("%d",&tablica[boki]);
            boki=boki+1;
        break;
        case 7:

        break;
        case 8:
            if(boki==0)
            {
                printf("Nie wprowadziles bokow\n");
            }
            else
            {


                printf("Podaj bok\n");
                scanf("%d",&nr);
                for(i=nr-1;i<=boki;i++)
                {
                    tablica[nr-1]=tablica[nr];
                    ++nr;

                }
                --boki;
            }
        break;
        case 9:
            return 0;
        break;
        default:
            printf("Nie ma takiej opcji\n");
        break;
    }
}while(x!=9);
}

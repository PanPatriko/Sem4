#include <stdio.h>
#include <stdlib.h>
int spr(xd)
{
if(xd==0)
{
    printf("Nie wprowadziles bokow\n");
    return 0;
}
else
{
return 1;
}
}
int main()
{
int x,boki,i,obwod,nr,bok;
int * tablica=NULL;
boki=0;
do
{

    printf("1.Wprowadz boki\n");
    printf("2.Wyswietl boki\n");
    printf("3.Oblicz obwod\n");
    printf("4.Wyswietl bok nr\n");
    printf("5.Podmien bok\n");
    printf("6.Dopisz bok\n");
    printf("7.Wstaw bok\n");
    printf("8.Usun bok\n");
    printf("9.Koniec\n");
    scanf("%d",&x);
    system("cls");
    switch(x)
    {
        case 1:
            if(boki!=0)
            {
               free(tablica);
            }
            printf("Podaj ilosc bokow");
            scanf("%d",&boki);
            tablica = /*(int*)*/ malloc(boki * sizeof(*tablica));
            printf("Podaj boki\n");
            for(i=0;i<boki;i++)
            {
                printf("Bok %d: ",i+1);
                scanf("%d",&tablica[i]);
            }
        break;
        case 2:
            x=spr(boki);
            if(x==0)
            {
                break;
            }
            else
            {
                for(i=0;i<boki;i++)
                {
                printf("Bok[%d]=%d\n",i+1,tablica[i]);
                }
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
            x=spr(boki);
            if(x==0)
            {
            break;
            }
            else
            {
                printf("Podaj nr boku");
                scanf("%d",&nr);
                if(nr>boki)
                {
                    printf("Nie ma takiego boku.Wybierz mniejsza wartosc\n");
                    scanf("%d",&nr);
                }

            }
            printf("Bok %d wynosi %d\n",nr,tablica[nr-1]);
        break;
        case 5:
             x=spr(boki);
            if(x==0)
            {
                break;
            }
            else
            {
                printf("Podaj nr boku");
                scanf("%d",&nr);
                printf("Podaj nowy bok");
                scanf("%d",&tablica[nr-1]);
            }
        break;
        case 6:
            x=spr(boki);
            if(x==0)
            {
                break;
            }
            else
            {
            printf("Podaj bok\n");
            boki=boki+1;

            tablica =  realloc(tablica,boki * sizeof(*tablica));
            scanf("%d",&tablica[boki-1]);
            }

        break;
        case 7:
            x=spr(boki);
            if(x==0)
            {
                break;
            }
            else
            {
                ++boki;
                tablica =  realloc(tablica,boki * sizeof(*tablica));
                printf("Gdzie chcesz wstawic bok\n");
                scanf("%d",&nr);
                printf("Podaj bok\n");
                scanf("%d",&bok);
                for(i=boki-1;i>nr-1;i--)
                {
                    tablica[i]=tablica[i-1];
                }
                tablica[nr-1]=bok;

            }
        break;
        case 8:
            x=spr(boki);
            if(x==0)
            {
                break;
            }
            else
            {

                printf("Podaj bok\n");
                scanf("%d",&nr);
                for(i=nr-1;i<boki;i++)
                {
                    tablica[i]=tablica[i+1];
                }
                --boki;
                tablica = realloc(tablica,boki * sizeof(*tablica));
            }
        break;
        default:
            printf("Nie ma takiej opcji\n");
        break;
    }

}while(x!=9);
return 0;
}

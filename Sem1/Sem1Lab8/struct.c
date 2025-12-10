#include <stdio.h>
#include <stdlib.h>
typedef struct osoba
{
    char imie[30];
    char nazwisko[30];
    int rok_ur;
}os;
os dodaj_osobe()
{
     os a;
     printf("Podaj imie\n");
     scanf("%s", a.imie);
     printf("Podaj nazwisko\n");
     scanf("%s", a.nazwisko);
     printf("Podaj rok urodzenia\n");
     scanf("%d", &a.rok_ur);
     return a;
}
void wyswietl_osobe(os b)
{
    printf("Imie: %s\n",b.imie);
    printf("Nazwisko: %s\n",b.nazwisko);
    printf("Rok urodzenia: %d\n",b.rok_ur);
}
os zmien_imie(os a)
{

    printf("Podaj nowe imie\n");
    scanf("%s", a.imie);
    return a;
}
os zmien_nazwisko(os a)
{
    printf("Podaj nowe nazwisko\n");
    scanf("%s", a.nazwisko);
    return a;
}
os zmien_rok(os a)
{
    printf("Podaj nowy rok urodzenia\n");
    scanf("%d", &a.rok_ur);
    return a;
}

int main()
{

    os a[100];
    int osoby=0;
    int wybor;
    int x;
    do
    {

        printf("1.Zapisz osobe\n");
        printf("2.Wyswietl osobe\n");
        printf("3.Modyfikuj imie\n");
        printf("4.Modyfikuj nazwisko\n");
        printf("5.Modyfikuj rok\n");
        printf("6.Koniec\n");
        scanf("%d",&x);
        system("cls");
        if(x==1)
        {
            a[osoby]=dodaj_osobe();
            osoby++;
        }
        if(x==2)
        {
            printf("Wybierz osobe\n");
            scanf("%d",&wybor);
            wyswietl_osobe(a[wybor-1]);
        }
        if(x==3)
        {
            printf("Wybierz osobe dla ktorej chcesz zmienic imie\n");
            scanf("%d",&wybor);
            a[wybor-1]=zmien_imie(a[wybor-1]);
        }
        if(x==4)
        {
            printf("Wybierz osobe dla ktorej chcesz zmienic nazwisko\n");
            scanf("%d",&wybor);
            a[wybor-1]=zmien_nazwisko(a[wybor-1]);
        }
        if(x==5)
        {
            printf("Wybierz osobe dla ktorej chcesz zmienic rok urodzenia\n");
            scanf("%d",&wybor);
            a[wybor-1]=zmien_rok(a[wybor-1]);
        }
    }
    while(x!=6);
}

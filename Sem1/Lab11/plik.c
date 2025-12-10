#include <stdio.h>
#include <stdlib.h>
#include <string.h>

void zapisz_tekst()
{
    FILE * plik;
    plik = fopen("tekst.txt","w");
    char tekst[100]={[99]'\0'};
    printf("Wpisz tekst\n");
    scanf(" %[^\n]s",tekst);
    fprintf(plik,"%s",tekst);
    fclose(plik);
}
void wczytaj_tekst()
{
    FILE * plik;
    char tekst[100]={[99]'\0'};
    plik = fopen("tekst.txt", "r");
    if (plik == NULL)
    {
        perror("Blad");
    }
    else
    {
        fscanf(plik,"%[^\n]s",tekst);
        printf("%s\n",tekst);
        fclose(plik);
    }
}
void dopisz_tekst()
{
    FILE * plik;
    char tekst[100]={[99]'\0'};

    plik = fopen("tekst.txt", "a");
    printf("Wpisz tekst\n");
    scanf(" %[^\n]s",tekst);
    fprintf(plik,"\n%s",tekst);
    fclose(plik);
}
void wczytaj_caly_tekst()
{
    FILE * plik;
    char tekst[100]={[99]'\0'};
    plik = fopen("tekst.txt", "r");
    if (plik == NULL)
    {
        perror("Blad");
    }
    else
    {
        int nr=1;
        while (!feof(plik))
        {
            fscanf(plik, " %[^\n]s", tekst);
            printf("Linia %d: %s\n", nr++, tekst);
        }
    fclose(plik);
    }
}
void wczytaj_n_linie()
{
    FILE * plik;
    char tekst[100]={[99]'\0'};
    plik = fopen("tekst.txt", "r");
    if (plik == NULL)
    {
        perror("Blad");
    }
    else
    {
        int linia,nr;
        printf("Ktora linie wyswietlic?\n");
        scanf("%d",&linia);
         while (!feof(plik))
        {

            fscanf(plik, " %[^\n]s", tekst);
            ++nr;
            if(nr==linia)
            {
                printf("Linia %d: %s\n", linia, tekst);
            }

        }
    }
}
void wczytaj_nm_linie()
{
    FILE * plik;
    char tekst[100]={[99]'\0'};
    plik = fopen("tekst.txt", "r");
    if (plik == NULL)
    {
        perror("Blad");
    }
    else
    {
        int n,m,nr;
        printf("Podaj linie n\n");
        scanf("%d",&n);
        printf("Ktora linie m?\n");
        scanf("%d",&m);
         while (!feof(plik))
        {

            fscanf(plik, " %[^\n]s", tekst);
            ++nr;
            if(nr>=n&&nr<=m)
            {
                printf("Linia %d: %s\n", nr, tekst);
            }
        }
    }
}

int main()
{
    int x;

    do
    {
        printf("1.Zapisanie 1 linii tekstu\n");
        printf("2.Odczytanie 1 linii tekstu\n");
        printf("3.Dopisz 1 linie tekstu\n");
        printf("4.Wyswietl wszystkie linie tekstu\n");
        printf("5.Wyswietl n-ta linie tekstu\n");
        printf("6.Ustaw sciezke do pliku\n");
        printf("7.Wyswietl linie od n do m\n");
        printf("8.Koniec\n");
        scanf("%d",&x);
        system("cls");
        if(x==1)
        {
            zapisz_tekst();
        }
        if(x==2)
        {
            wczytaj_tekst();
        }
        if(x==3)
        {
            dopisz_tekst();
        }
        if(x==4)
        {
            wczytaj_caly_tekst();
        }
        if(x==5)
        {
            wczytaj_n_linie();
        }
         if(x==6)
        {

        }
        if(x==7)
        {
            wczytaj_nm_linie();
        }
    }while(x!=8);
}

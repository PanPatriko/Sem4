#include <stdio.h>
#include <stdlib.h>
void zapisz()
{
    int n,i;
    int liczby[100];
    FILE * plik;
    plik=fopen("tekst.bin","wb");
    printf("Podaj ilosc liczb\n");
    scanf("%d",&n);
    for(i=0;i<n;i++)
    {
        scanf("%d",&liczby[i]);
    }
    fwrite(liczby,4,n,plik);
    fclose(plik);
}
void wczytaj_n()
{
    int n,i,dlugosc;
    int liczby[100];
    FILE * plik;
    plik=fopen("tekst.bin","rb");
    if (plik == NULL)
    {
        perror("Blad");
    }
    else
    {
        fseek(plik, 0, SEEK_END);   // non-portable
        dlugosc=ftell(plik);
        printf("W pliku znajduje sie %d liczb.\n",dlugosc/4);
        printf("Ile liczb chcesz wyswietlic?\n");
        scanf("%d",&n);

        while(n>(dlugosc/4))
        {
        printf("Nie ma tylu liczb. Wybierz mniejsza ilosc.\n");
        scanf("%d",&n);
        }
        system("cls");
        rewind(plik);
        fread(liczby,4,n,plik);

        for(i=0;i<n;i++)
        {
            printf("%d\n",liczby[i]);
        }
    }
    fclose(plik);
}
void wczytaj_all()
{
    int i,dlugosc;
    int liczby[100];
    FILE * plik;
    plik=fopen("tekst.bin","rb");
    if (plik == NULL)
    {
        perror("Blad");
    }
    else
    {
        fseek(plik, 0, SEEK_END);   // non-portable
        dlugosc=ftell(plik);
        rewind(plik);
        fread(liczby,4,dlugosc/4,plik);
        for(i=0;i<dlugosc/4;i++)
        {
            printf("%d\n",liczby[i]);
        }
    }
    fclose(plik);
}
void wczytaj_n_liczbe()
{
    int n,dlugosc;
    int liczby[1];
    FILE * plik;
    plik=fopen("tekst.bin","rb");
    if (plik == NULL)
    {
        perror("Blad");
    }
    else
    {

        fseek(plik, 0, SEEK_END);   // non-portable
        dlugosc=ftell(plik);
        printf("W pliku znajduje sie %d liczb.\n",dlugosc/4);
        printf("Ktora liczbe chcesz wyswietlic?\n");
        scanf("%d",&n);
        while(n>(dlugosc/4))
        {
        printf("Wybierz mniejsza wartosc.\n");
        scanf("%d",&n);
        }
        system("cls");
        fseek(plik,n*4-4,SEEK_SET);
        fread(liczby,4,1,plik);
        printf("%d\n",liczby[0]);

    }
    fclose(plik);
}
void dopisz_n()
{
    int i,n;
    int liczby[100];
    FILE * plik;
    plik=fopen("tekst.bin","ab");
    printf("Podaj ile liczb chcesz dopisac.\n");
    scanf("%d",&n);
    for(i=0;i<n;i++)
    {
        scanf("%d",&liczby[i]);
    }
    fwrite(liczby,4,n,plik);
    fclose(plik);
}
void wczytaj_n_ostatnich()
{

    int n,i,dlugosc;
    int liczby[100];
    FILE * plik;
    plik=fopen("tekst.bin","rb");
    if (plik == NULL)
    {
        perror("Blad");
    }
    else
    {
        fseek(plik, 0, SEEK_END);   // non-portable
        dlugosc=ftell(plik);
        printf("W pliku znajduje sie %d liczb.\n",dlugosc/4);
        printf("Ile liczb chcesz wyswietlic?\n");
        scanf("%d",&n);

        while(n>(dlugosc/4))
        {
        printf("Nie ma tylu liczb. Wybierz mniejsza ilosc.\n");
        scanf("%d",&n);
        }
        system("cls");

        fseek(plik, -n*4, SEEK_END);

        fread(liczby,4,n,plik);
        //
        for(i=0;i<n;i++)
        {
            printf("%d\n",liczby[i]);
        }
    }
    fclose(plik);
}
void podmien_n()
{
    int n,nowa,dlugosc;
    int liczby[1];


    FILE * plik;

    plik=fopen("tekst.bin","r+b");
    if (plik == NULL)
    {
        perror("Blad");
    }
    else
    {
        fseek(plik, 0, SEEK_END);   // non-portable
        dlugosc=ftell(plik);
        printf("W pliku znajduje sie %d liczb.\n",dlugosc/4);
        printf("Ktora liczbe chcesz zmienic?.\n");
        scanf("%d",&n);
        while(n>dlugosc/4)
        {
            printf("Nie ma takiej liczby.Wybierz mniejsza wartosc.\n");
            scanf("%d",&n);
        }
        printf("Podaj nowa wartosc.\n");
        scanf("%d",&nowa);

        fseek(plik,n*4-4,SEEK_SET);
        fread(liczby,4,1,plik);
        liczby[0]=nowa;
        fseek(plik,n*4-4,SEEK_SET);
        fwrite(liczby,4,1,plik);
    }
    fclose(plik);
}
int main()
{
    int x;
    do
    {
    printf("1.Zapisz n liczb do pliku\n");
    printf("2.Odczytaj n liczb z pliku\n");
    printf("3.Odczytaj wszytkie liczby z pliku\n");
    printf("4.Odczytaj n-ta liczbe z pliku\n");
    printf("5.Dopisz n liczb do pliku\n");
    printf("6.Podmien n-ta liczbe z pliku\n");
    printf("7.Odczytaj n ostatnich liczb z pliku\n");
    printf("8.Koniec\n");
    scanf("%d",&x);
    system("cls");
    if(x==1)
    {
        zapisz();
    }
     if(x==2)
    {
        wczytaj_n();
    }
     if(x==3)
    {
        wczytaj_all();
    }
     if(x==4)
    {
        wczytaj_n_liczbe();
    }
     if(x==5)
    {
        dopisz_n();
    }
     if(x==6)
    {
        podmien_n();
    }
     if(x==7)
    {
        wczytaj_n_ostatnich();
    }
    }
    while(x!=8);
    return 0;
}

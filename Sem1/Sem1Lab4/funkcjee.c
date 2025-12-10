#include <stdio.h>

void menu()
{
    printf("\n1.Linia\n2.Linia Wysrodkowana\n3.Prostokat Dolarow\n4.Kwadrat Wysrodkowany\n5.Trojkat Gwiazdek\n6.Choinka\n7.Koniec\n");
}
void line(int dl,char znak)
{
    int i;
    for(i=0;i<dl;i++)
    {
        printf("%c",znak);
    }
}
void liniasrodek(int szer,int dl,char znak)
{
    int j,srodek;
    srodek=(szer-dl)/2;
    for(j=0;j<srodek;j++)
    {
        printf(" ");
    }
    line(dl,znak);
}
void prostokat(int szer,int wys)
{
    int i;
    for(i=0;i<wys;i++)
    {
        line(szer,'$');
        printf("\n");
    }
}
void kwadrat(int szer,int bok,int znak)
{
    int i;
    for(i=0;i<bok;i++)
    {
        liniasrodek(szer,bok,znak);
        printf("\n");
    }
}
void trojkatgwiazd(int wys)
{
    int i,dl=1,szer;
    szer=wys*2;
    for(i=0;i<wys;i++)
    {
        liniasrodek(szer,dl,'*');
        dl=dl+2;
        printf("\n");

    }
}
void choinka(int ilosc,int wys)
{
    int i,szer;
    szer=wys*2;
    for(i=0;i<ilosc;i++)
    {
    trojkatgwiazd(wys);
    }
    kwadrat(szer,3,'*');
}
int main()
{
int x,dl,szer,wys,ilosc;
char znak;
    do
    {



        menu();
        scanf("%d",&x);
        switch(x)
        {
            case 1:
                printf("Podaj znak\n");
                scanf(" %c",&znak);
                printf("Podaj dlugosc\n");
                scanf("%d",&dl);

                line(dl,znak);
            break;
            case 2:
                printf("Podaj szerokosc ekranu\n");
                scanf("%d",&szer);
                printf("Podaj znak\n");
                scanf(" %c",&znak);
                printf("Podaj dlugosc\n");
                scanf("%d",&dl);
                liniasrodek(szer,dl,znak);
            break;
            case 3:
                printf("Podaj szerokosc\n");
                scanf("%d",&szer);
                printf("Podaj wysokosc\n");
                scanf("%d",&wys);
                prostokat(szer,wys);

            break;
            case 4:
                printf("Podaj szerokosc ekranu\n");
                scanf("%d",&szer);
                printf("Podaj bok kwadratu\n");
                scanf("%d",&dl);
                printf("Podaj znak");
                scanf(" %c",&znak);
                kwadrat(szer,dl,znak);
            break;
            case 5:
                printf("Podaj wysokosc trojkata\n");
                scanf("%d",&wys);
                trojkatgwiazd(wys);
            break;
            case 6:
                printf("Podaj ilosc trojkatow\n");
                scanf("%d",&ilosc);
                printf("Podaj wysokosc trojkata\n");
                scanf("%d",&wys);
                choinka(ilosc,wys);
            break;
        }

    }
    while(x!=7);
}



#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <conio.h>
void wypelnij_plansze(char pole[11][11])
{
    int i,j;
    for(i=0;i<=11;i++)
    {
        for(j=0;j<=11;j++)
        {
            pole[i][j]='.';
        }
    }
}
void rysuj_plansze(char pole[11][11],int czykomp)
{
    pole[0][0]  = 0;
    pole[0][1]  = '0';
    pole[0][2]  = '1';
    pole[0][3]  = '2';
    pole[0][4]  = '3';
    pole[0][5]  = '4';
    pole[0][6]  = '5';
    pole[0][7]  = '6';
    pole[0][8]  = '7';
    pole[0][9]  = '8';
    pole[0][10] = '9';
    pole[1][0]  = '0';
    pole[2][0]  = '1';
    pole[3][0]  = '2';
    pole[4][0]  = '3';
    pole[5][0]  = '4';
    pole[6][0]  = '5';
    pole[7][0]  = '6';
    pole[8][0]  = '7';
    pole[9][0]  = '8';
    pole[10][0]='9';
    int i,j;
    if(czykomp==0)
    {
        for(i=0;i<11;i++)
        {
            for(j=0;j<11;j++)
            {
                printf(" %c",pole[i][j]);
            }
            if(i==0)printf(" X");
            printf("\n");
            if(i==10)printf(" Y\n");
        }
    }
    else
    {
        for(i=0;i<11;i++)
        {
            for(j=0;j<11;j++)
            {
                if(pole[i][j]=='O')
                {
                    printf(" .");
                }
                else
                {
                    printf(" %c",pole[i][j]);
                }

            }
            if(i==0)printf(" X");
            printf("\n");
            if(i==10)printf(" Y\n");
        }
    }

}
void ustaw4maszt(char pole[11][11],int czykomp)
{
    int x,y,xd,blad;
    if (czykomp==0)
    {


    printf("Podaj koordynaty 4-masztowca\n");
    printf("Podaj plaszczyzne statku\nPoziomo>0\nPionowo>1\n");
    scanf("%d",&xd);
    while(xd>1)
    {
        printf("Blad\n");
        scanf("%d",&xd);
    }
    if(xd==1)
    {
        do
        {
            blad=0;
            printf("Podaj x\n");
            scanf("%d",&x);
            if(x>9||x<0)
            {
                printf("Blad-statek poza plansza\n");
                blad=1;
            }
            printf("Podaj y\n");
            scanf("%d",&y);

            if(y>6||y<0)
            {
                printf("Blad-statek poza plansza\n");
                blad=1;
            }
        }while(blad==1);
        pole[y+1][x+1]='O';
        pole[y+2][x+1]='O';
        pole[y+3][x+1]='O';
        pole[y+4][x+1]='O';
    }
    if(xd==0)
    {
        do
        {
            blad=0;
            printf("Podaj x\n");
            scanf("%d",&x);
            if(x>6||x<0)
            {
                printf("Blad-statek poza plansza\n");
                blad=1;
            }
            printf("Podaj y\n");
            scanf("%d",&y);
            if(y>9||y<0)
            {
                printf("Blad-statek poza plansza\n");
                blad=1;
            }
        }while(blad==1);
        pole[y+1][x+1]='O';
        pole[y+1][x+2]='O';
        pole[y+1][x+3]='O';
        pole[y+1][x+4]='O';
    }
    }
    else
    {
    srand(time( NULL ));
    xd=rand()%2;
    if(xd==1)
    {
        x=rand()%10;
        y=rand()%7;
        pole[y+1][x+1]='O';
        pole[y+2][x+1]='O';
        pole[y+3][x+1]='O';
        pole[y+4][x+1]='O';
    }
    if(xd==0)
    {
        x=rand()%7;
        y=rand()%10;
        pole[y+1][x+1]='O';
        pole[y+1][x+2]='O';
        pole[y+1][x+3]='O';
        pole[y+1][x+4]='O';
    }
    }
}
void ustaw3maszt(char pole[11][11],int czykomp)
{
    int x,y,xd,i,blad;
    if(czykomp==0)
    {


    printf("Podaj koordynaty 3-masztowca\n");
    printf("Podaj plaszczyzne statku\nPoziomo>0\nPionowo>1\n");
    scanf("%d",&xd);
    while(xd>1)
    {
        printf("Blad\n");
        scanf("%d",&xd);
    }
    if(xd==1)
    {
        do
        {
            blad=0;
            printf("Podaj x\n");
            scanf("%d",&x);
            if(x>9||x<0)
            {
                printf("Blad-statek poza plansza\n");
                blad=1;

            }
            printf("Podaj y\n");
            scanf("%d",&y);
            if(y>7||y<0)
            {
                printf("Blad-statek poza plansza\n");
                blad=1;
            }
            for(i=0;i<5;i++)
            {
                if(pole[y+i][x]=='O')
                {
                    printf("Blad-Za blisko innego statku\n");
                    blad=1;
                    break;
                }
                if(pole[y+i][x+1]=='O')
                {
                    printf("Blad-Za blisko innego statku\n");
                    blad=1;
                    break;
                }
                if(pole[y+i][x+2]=='O')
                {
                    printf("Blad-Za blisko innego statku\n");
                    blad=1;
                    break;
                }
            }

        }while(blad==1);
        pole[y+1][x+1]='O';
        pole[y+2][x+1]='O';
        pole[y+3][x+1]='O';

        }
        if(xd==0)
        {
            do
            {
            blad=0;
            printf("Podaj x\n");
            scanf("%d",&x);
            if(x>7||x<0)
            {
                printf("Blad-statek poza plansza\n");
                blad=1;

            }
            printf("Podaj y\n");
            scanf("%d",&y);
            if(y>9||y<0)
            {
                printf("Blad-statek poza plansza\n");
                blad=1;

            }
            for(i=0;i<5;i++)
            {
                if(pole[y][x+i]=='O')
                {
                    printf("Blad-Za blisko innego statku\n");
                    blad=1;
                    break;
                }
                if(pole[y+1][x+i]=='O')
                {
                    printf("Blad-Za blisko innego statku\n");
                    blad=1;
                    break;
                }
                if(pole[y+2][x+i]=='O')
                {
                    printf("Blad-Za blisko innego statku\n");
                    blad=1;
                    break;
                }
            }


            }while(blad==1);
            pole[y+1][x+1]='O';
            pole[y+1][x+2]='O';
            pole[y+1][x+3]='O';

        }
    }
    else
    {
     xd=rand()%2;

    if(xd==1)
    {

        do
        {
            x=rand()%10;
            y=rand()%8;
            blad=0;
            for(i=0;i<5;i++)
            {
                if(pole[y+i][x]=='O')
                {
                    blad=1;
                    break;
                }
                if(pole[y+i][x+1]=='O')
                {
                    blad=1;
                    break;
                }
                if(pole[y+i][x+2]=='O')
                {
                    blad=1;
                    break;
                }
            }
        }while(blad==1);
        pole[y+1][x+1]='O';
        pole[y+2][x+1]='O';
        pole[y+3][x+1]='O';

    }
    if(xd==0)
    {
        do
        {
            x=rand()%8;
            y=rand()%10;
            blad=0;
            for(i=0;i<5;i++)
            {
                if(pole[y][x+i]=='O')
                {
                    blad=1;
                    break;
                }
                if(pole[y+1][x+i]=='O')
                {
                    blad=1;
                    break;
                }
                if(pole[y+2][x+i]=='O')
                {
                    blad=1;
                    break;
                }
            }
        }while(blad==1);
        pole[y+1][x+1]='O';
        pole[y+1][x+2]='O';
        pole[y+1][x+3]='O';
    }
    }
}
void ustaw2maszt(char pole[11][11],int czykomp)
{
    int x,y,xd,i,blad;
    if(czykomp==0)
    {


    printf("Podaj koordynaty 2-masztowca\n");
    printf("Podaj plaszczyzne statku\nPoziomo>0\nPionowo>1\n");
    scanf("%d",&xd);
    while(xd>1||x<0)
    {
        printf("Blad\n");
        scanf("%d",&xd);
    }
    if(xd==1)
    {
        do
        {
            blad=0;
            printf("Podaj x\n");
            scanf("%d",&x);
            if(x>9||x<0)
            {
                printf("Blad-statek poza plansza\n");
                blad=1;

            }
            printf("Podaj y\n");
            scanf("%d",&y);
            if(y>8||y<0)
            {
                printf("Blad-statek poza plansza\n");
                blad=1;
            }
            for(i=0;i<4;i++)
            {
                if(pole[y+i][x]=='O')
                {
                    printf("Blad-Za blisko innego statku\n");
                    blad=1;
                    break;
                }
                    if(pole[y+i][x+1]=='O')
                {
                    printf("Blad-Za blisko innego statku\n");
                    blad=1;
                    break;
                }
                if(pole[y+i][x+2]=='O')
                {
                    printf("Blad-Za blisko innego statku\n");
                    blad=1;
                    break;
                }
            }

        }while(blad==1);
        pole[y+1][x+1]='O';
        pole[y+2][x+1]='O';


        }
        if(xd==0)
        {
            do
            {
            blad=0;
            printf("Podaj x\n");
            scanf("%d",&x);
            if(x>8||x<0)
            {
                printf("Blad-statek poza plansza\n");
                blad=1;

            }
            printf("Podaj y\n");
            scanf("%d",&y);
            if(y>9||y<0)
            {
                printf("Blad-statek poza plansza\n");
                blad=1;

            }
            for(i=0;i<4;i++)
            {
                if(pole[y][x+i]=='O')
                {
                    printf("Blad-Za blisko innego statku\n");
                    blad=1;
                    break;
                }
                if(pole[y+1][x+i]=='O')
                {
                    printf("Blad-Za blisko innego statku\n");
                    blad=1;
                    break;
                }
                if(pole[y+2][x+i]=='O')
                {
                    printf("Blad-Za blisko innego statku\n");
                    blad=1;
                    break;
                }
            }


            }while(blad==1);
            pole[y+1][x+1]='O';
            pole[y+1][x+2]='O';

        }
    }
    else
    {
    xd=rand()%2;

    if(xd==1)
    {

        do
        {
            x=rand()%10;
            y=rand()%9;
            blad=0;
            for(i=0;i<4;i++)
            {
                if(pole[y+i][x]=='O')
                {
                    blad=1;
                    break;
                }
                if(pole[y+i][x+1]=='O')
                {
                    blad=1;
                    break;
                }
                if(pole[y+i][x+2]=='O')
                {
                    blad=1;
                    break;
                }
            }
        }while(blad==1);
        pole[y+1][x+1]='O';
        pole[y+2][x+1]='O';
    }
    if(xd==0)
    {
        do
        {
            x=rand()%9;
            y=rand()%10;
            blad=0;
            for(i=0;i<4;i++)
            {
                if(pole[y][x+i]=='O')
                {
                    blad=1;
                    break;
                }
                if(pole[y+1][x+i]=='O')
                {
                    blad=1;
                    break;
                }
                if(pole[y+2][x+i]=='O')
                {
                    blad=1;
                    break;
                }
            }
        }while(blad==1);
        pole[y+1][x+1]='O';
        pole[y+1][x+2]='O';
    }
    }
}
void ustaw1maszt(char pole[11][11],int czykomp)
{
    int x,y,i,blad;
    if(czykomp==0)
    {



    printf("Podaj koordynaty 1-masztowca\n");
    do
    {
        blad=0;
        printf("Podaj x\n");
        scanf("%d",&x);
        if(x>9||x<0)
        {
            printf("Blad-statek poza plansza\n");
            blad=1;
        }
        printf("Podaj y\n");
        scanf("%d",&y);
        if(y>9||y<0)
        {
            printf("Blad-statek poza plansza\n");
            blad=1;
        }
        for(i=0;i<3;i++)
        {
            if(pole[y+i][x]=='O')
            {
                printf("Blad-Za blisko innego statku\n");
                blad=1;
                break;
            }
            if(pole[y+i][x+1]=='O')
            {
                printf("Blad-Za blisko innego statku\n");
                blad=1;
                break;
            }
            if(pole[y+i][x+2]=='O')
            {
                printf("Blad-Za blisko innego statku\n");
                blad=1;
                break;
            }
        }






    }while(blad==1);
    pole[y+1][x+1]='O';
    }
    else
    {
    do
    {
        x=rand()%10;
        y=rand()%10;
        blad=0;
        for(i=0;i<3;i++)
        {
            if(pole[y+i][x]=='O')
            {
                blad=1;
                break;
            }
            if(pole[y+i][x+1]=='O')
            {
                blad=1;
                break;
            }
            if(pole[y+i][x+2]=='O')
            {
                blad=1;
                break;
            }
        }
    }while(blad==1);
    pole[y+1][x+1]='O';
    }
}

int main()
{
    char pole1[11][11];
    char pole2[11][11];
    int menu,x,y,trafienie,trafienie2,x1,y1,koniec,wynik;
    char  nick[25];
    FILE * plik;


    do
    {
        printf("1.Nowa gra\n");
        printf("2.Wyniki\n");
        printf("3.Koniec\n");
        scanf("%d",&menu);
        system("cls");
        switch(menu)
        {
        case 1:
           // printf("Wybierz poziom trudnosci\n");
            system("cls");
            wypelnij_plansze(pole1);
            wypelnij_plansze(pole2);
            rysuj_plansze(pole1,0);
            ustaw4maszt(pole1,0);
            rysuj_plansze(pole1,0);
            ustaw3maszt(pole1,0);
            rysuj_plansze(pole1,0);
            ustaw3maszt(pole1,0);
            rysuj_plansze(pole1,0);
            ustaw2maszt(pole1,0);
            rysuj_plansze(pole1,0);
            ustaw2maszt(pole1,0);
            rysuj_plansze(pole1,0);
            ustaw2maszt(pole1,0);
            rysuj_plansze(pole1,0);
            ustaw1maszt(pole1,0);
            rysuj_plansze(pole1,0);
            ustaw1maszt(pole1,0);
            rysuj_plansze(pole1,0);
            ustaw1maszt(pole1,0);
            rysuj_plansze(pole1,0);
            ustaw1maszt(pole1,0);
            rysuj_plansze(pole1,0);
            ustaw4maszt(pole2,1);
            ustaw3maszt(pole2,1);
            ustaw3maszt(pole2,1);
            ustaw2maszt(pole2,1);
            ustaw2maszt(pole2,1);
            ustaw2maszt(pole2,1);
            ustaw1maszt(pole2,1);
            ustaw1maszt(pole2,1);
            ustaw1maszt(pole2,1);
            ustaw1maszt(pole2,1);

            trafienie=0;
            trafienie2=0;
            koniec=0;
            wynik=0;

            srand(time(NULL));
            do
            {
                printf("Plansza przeciwnika\n");
                rysuj_plansze(pole2,1);
                printf("Kapitanie gdzie strzelac?\nPodaj X\n");
                scanf("%d",&x);
                while(x>9||x<0)
                {
                    printf("Blad-Wybierz x z przedzialu 0-9\n");
                    scanf("%d",&x);
                }
                printf("Podaj Y\n");
                scanf("%d",&y);
                while(y>9||y<0)
                {
                    printf("Blad-Wybierz y z przedzialu 0-9\n");
                    scanf("%d",&y);
                }
                if(pole2[y+1][x+1]=='*'||pole2[y+1][x+1]=='X')
                {
                    printf("Kapitanie zmarnowalismy strzal\n");
                    wynik=wynik-5;
                }
                if(pole2[y+1][x+1]=='O')
                {
                    trafienie++;
                    wynik=wynik+10;
                    printf("Trafiony\n");
                    pole2[y+1][x+1]='X';
                }
                if(pole2[y+1][x+1]=='.')
                {
                    wynik=wynik-5;
                    printf("Pudlo\n");
                    pole2[y+1][x+1]='*';
                }
                printf("Plansza przeciwnika\n");
                rysuj_plansze(pole2,1);
                printf("Wcisnij dowolny klawisz aby przeciwnik oddal strzal\n");
                getch();


                x1=rand()%10;
                y1=rand()%10;
                printf("Przeciwnik oddal strzal w X %d,Y %d\n",x1,y1);
                if(pole1[y1+1][x1+1]=='.'||pole1[y1+1][x1+1]=='X'||pole1[y1+1][x1+1]=='*')
                {
                    printf("Przeciwnik spudlowal\n");
                    pole1[y1+1][x1+1]='*';
                }
                if(pole1[y1+1][x1+1]=='O')
                {
                    trafienie2++;
                    printf("Przeciwnik trafil\n");
                    pole1[y1+1][x1+1]='X';
                }
                printf("Twoja plansza\n");
                rysuj_plansze(pole1,0);
                printf("Trafienia gracza %d\n",trafienie);
                printf("Trafienia przeciwnika %d\n",trafienie2);
                printf("Wcisnij dowolny klawisz aby oddac strzal\n");
                getch();
                if(trafienie==4)
                {
                    koniec=1;

                }
                if(trafienie2==20)
                {
                    koniec=1;
                }

            }while(koniec<1);
            if(trafienie==4)
            {
               printf("Wygrales\nZapisz swoj wynik\nPodaj nick\n");
               scanf(" %[^\n]s",nick);
               plik=fopen("wynik.txt","a");
               fprintf(plik,"%s %d\n",nick,wynik);
               fclose(plik);



            }
            else
            {
                  printf("Przegrales\n");
            }





 //////////////////////////////////////////////





        break;
        case 2:
            plik=fopen("wynik.txt","r");
            if (plik == NULL)
            {
                perror("Blad- Nie ma jeszcze zadnych wynikow\n");
            }
            else
            {


                printf("WYNIKI\n");
                while (!feof(plik))
                {
                    fscanf(plik," %[^\n]",nick);
                    printf("%s\n",nick);
                }
            }
            fclose(plik);
            printf("___________\n");

        break;
        case 3:
        return 0;
        break;
        default:
            printf("Nie ma takiej opcji\n");
        break;
        }
    }while(menu!=3);
    return 0;
}


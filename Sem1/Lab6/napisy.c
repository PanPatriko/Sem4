#include <stdio.h>
#include <stdlib.h>
#include <string.h>
int main()
{
    int x;
    char napis1[30]={[29]'\0'};
    char napis2[30]={[29]'\0'};
    do
    {

        printf("1.Wprowadz napis 1\n");
        printf("2.Wprowadz napis 2\n");
        printf("3.Wyswietl napis1\n");
        printf("4.Wyswietl napis2\n");
        printf("5.napis1 = napis1 + napis2\n");
        printf("6.napis 1 = napis 2\n");
        printf("7.Wyswietl alfabetycznie\n");
        printf("8.Zamien spacje na podkreslenie\n");
        printf("9.Zamien male litery na duze\n");
        printf("10.Koniec\n");
        scanf("%d",&x);
        system("cls");
        if(x==1)
        {
            int i;
            for(i=0;i<29;i++)
            {
                napis1[i]=0;
            }
            printf("Wprowadz napis1\n");
            scanf(" %[^\n]s",napis1);

        }
        if(x==2)
        {
            printf("Wprowadz napis2\n");
            scanf(" %[^\n]s",napis2);
        }
        if(x==3)
        {

            printf("%s\n",napis1);
        }
        if(x==4)
        {
            printf("%s\n",napis2);
        }
        if(x==5)
        {
            napis1[strlen(napis1)]=' ';
            strcat(napis1,napis2);
        }
        if(x==6)
        {
            strcpy(napis1,napis2);
        }
        if(x==7)
        {
            int i=0;
            while(napis1[i]==napis2[i])
            {
            ++i;
            }

            if(napis1[i]<napis2[i])
            {
                printf("%s\n",napis1);
                printf("%s\n",napis2);
            }
            else{
                 printf("%s\n",napis2);
                 printf("%s\n",napis1);
            }
        }
        if(x==8)
        {
            int i,j;
            for(i=0;i<strlen(napis1);i++)
            {
                if(napis1[i]==32)
                {
                    napis1[i]=95;
                }
            }
            for(j=0;j<strlen(napis2);j++)
            {
                if(napis2[j]==32)
                {
                    napis2[j]=95;
                }
            }
        }
        if(x==9)
        {
            int i;
            for(i=0;i<strlen(napis1);i++)
            {
                if((napis1[i]<123)&&(napis1[i]>96))
                {
                napis1[i]=napis1[i]-32;
                }

            }
        }
    }
    while(x!=10);
}

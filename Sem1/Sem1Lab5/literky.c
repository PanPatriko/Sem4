#include <stdio.h>
int main()
{
    int x,i,male,duze;
    char zdanie,literka;
    x=0;
    do
    {
        duze=0;
        male=0;
        i=0;
        printf("1.Policz litery\n2.Policz 'a'\n3.Policz samogloski\n4.Policz wybrana litere\n5.Policz male i wielkie litery\n6.Koniec\n");
        scanf("%d", &x);

        switch(x)
        {
            case 1:
                printf("Podaj zdanie\n");
                do
                {
                    scanf(" %c",&zdanie);
                    i++;
                }
                while(zdanie!='.');
                printf("Liczba liter: %d\n",i-1);
            break;
            case 2:
                printf("Podaj zdanie\n");
                 do
                {
                    scanf(" %c",&zdanie);
                    if(zdanie=='a')
                    {
                        i++;
                    }
                }
                while(zdanie!='.');

                printf("Liczba liter a: %d\n",i);
            break;
            case 3:
                printf("Podaj zdanie\n");
                 do
                {
                    scanf(" %c",&zdanie);
                    if((zdanie=='a')||(zdanie=='e')||(zdanie=='i')||(zdanie=='o')||(zdanie=='u')||(zdanie=='y'))
                    {
                        i++;
                    }
                }
                while(zdanie!='.');

                printf("Liczba samoglosek: %d\n",i);
            break;
            case 4:
                printf("Podaj litere do policzenia\n");
                scanf(" %c",&literka);
                printf("Podaj zdanie\n");

                do
                {

                    scanf(" %c",&zdanie);
                    if(literka==zdanie)
                    {
                        i++;
                    }

                }
                while(zdanie!='.');
                printf("Liczba liter %c w zdaniu: %d\n",literka,i);

            break;
            case 5:
                printf("Podaj zdanie\n");
                do
                {

                    scanf("%c",&zdanie);
                    if((zdanie>96)&&(zdanie<123))
                    {
                        male++;
                    }
                    if((zdanie>64)&&(zdanie<91))
                    {
                        duze++;
                    }


                }
                while(zdanie!='.');
                printf("Male litery: %d\nDuze litery: %d\n",male,duze);
            break;
            case 6:
            return 0;

        }
    }while(x!=6);
}

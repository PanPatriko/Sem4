#include <stdio.h>
int main()
{
int x,y;
do
{
    printf("1. Opcja 1\n");
    printf("2. Opcja 2\n");
    printf("3. Opcja 3\n");
    printf("4. Koniec\n");
    printf("Wybierz opcje:");
    scanf("%d",&x);
    if((x==1)||(x==2)||(x==3))
    {
        do
        {
            printf("1. Opcja %da\n",x);
            printf("2. Opcja %db\n",x);
            printf("3. Opcja %dc\n",x);
            printf("4. Powrot\n");
            printf("5. Koniec\n");
            printf("Wybierz opcje:");
            scanf("%d",&y);

            if(y==1)
            {
                printf("Wybrales opcje %da\n",x);
            }
            if(y==2)
            {
                printf("Wybrales opcje %db\n",x);
            }
            if(y==3)
            {
                printf("Wybrales opcje %dc\n",x);
            }
        }
        while(y<4);
        if(y==4)
        {
            x=0;
        }

        if(y==5)
        {
            return 0;
        }
    }

}
while(x<4);
}




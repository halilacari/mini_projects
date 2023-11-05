#include <stdio.h>

#include <stdbool.h>



void asal_carpanlar(int);



int main(){



int sayi;



printf("Bir sayi giriniz-> "); scanf("%d",&sayi);



asal_carpanlar(sayi);



return 0;}



void asal_carpanlar(int sayi){

int i, n=sayi, us=0;

for(i=2;n>1;i++){

 		us=0;

 		while (n%i==0){

us++;

n=n/i;

 }

 if(us!=0)

 printf("%d^%d ",i,us);}

}
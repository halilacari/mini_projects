#include <stdio.h>



int main(){

int i,j,k,satir,p=97,sayi ,harf;char m;





printf("Satir sayisi giriniz.-> ");scanf("%d",&satir);



sayi=1;



harf=satir-1;



for(i=0; i< satir; i++){

for(j=0 ; j<harf;j++){

m=p+j;

printf("%2c",m);

}

for(j=satir; j>=satir-i; j--){



printf("%2d",j);

}

printf("\n");

harf--;

sayi++;

p++;

}





return(0);}

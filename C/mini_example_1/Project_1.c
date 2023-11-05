#include <stdio.h>



int main() {

int sayi;

printf("1-256 arasindaki 3 ve 4 e tam bolunen ancak 7ye tam bolunemeyen sayilar:\n\n");

for(sayi=1;sayi<=256;sayi++){

if ((sayi%3==0) && (sayi%4==0) && (sayi%7!=0))

printf("%d\n",sayi);}

return 0;

}
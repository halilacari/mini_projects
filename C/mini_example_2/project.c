#include <stdio.h>

#include <math.h>

float mesafe(float,float,float,float);

int main() {

int k,l,m,i,j;float N[10],x[5],y[5],matris[5][5];



k=0;

for(i=0;i<=4;i++)

{printf("P%d noktasini giriniz(x%d,y%d).-> ",i,i,i);scanf("%f%f",&N[k],&N[k+1]);

 	k=k+2;

}

printf("\n\n koordinatlar dizisi:\n\n");

 for(i=0;i<=9;i++)

printf("%.2f ",N[i]);



for(i=0;i<=4;i++)

{x[i]=N[2*i];

 y[i]=N[2*i+1];}



{for(i=0;i<=3;i++)

{for(j=i+1;j<=4;j++)

{matris[j][i]= mesafe(x[j],x[i],y[j],y[i]);

}

}

}printf("\n\nmatris dizisi:\n\n");



k=0;

for (m=1;m<=4;m++)

{

for(l=1;l<=m;l++)

{	if(matris[m][k]!=0)

 	printf("-%.2f- ",matris[m][k]);

  	k++;

}

k=0;

printf("\n");

}

return 0;}



 float mesafe(float x1,float x2,float y1,float y2){

 	float sonucx,sonucy,sonucxy;

 sonucx=pow(x1-x2,2);

 sonucy=pow(y1-y2,2);

 sonucxy=pow(sonucx+sonucy,0.5);

 return sonucxy;}
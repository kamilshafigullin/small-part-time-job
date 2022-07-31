#include

#include

#include

#include "Interfs.h"

#include "function.h"

#define LOWORD(T) ((unsigned short)(T))

#define HIWORD(T) ((unsigned short)(T>>16))

#define MAKELONG(a,b) ((((unsigned long)(a))<<16)+b)

#define S 32

/*addition*/

void add(unsigned short add_a[], unsigned short add_b[],unsigned short add_c[], int add_l_a_b)

{unsigned long T;

unsigned short d;

d=0;

for(int i=0; i<=(add_l_a_b-1); i++)

{T=(unsigned long)add_a[i]+(unsigned long)add_b[i]+d;

add_c[i]=LOWORD(T);

d=HIWORD(T);}

add_c[add_l_a_b]=d;}

void sub(unsigned short sub_a[], unsigned short sub_b[],unsigned short sub_c[], int sub_l_a_b)

{unsigned long T;

unsigned short d;

d=0;

for(int i=0; i<=(sub_l_a_b-1); i++)

{T=(unsigned long)sub_a[i]-(unsigned long)sub_b[i]-d;

sub_c[i]=LOWORD(T);

if(HIWORD(T)==0) d=0;

else d=1;}

sub_c[sub_l_a_b]=d;}

/*multiplication c=a*b*/

void mul(unsigned short mul_a[], unsigned short mul_b[],unsigned short mul_c[],int mul_l_a, int mul_l_b)

{unsigned long T;

unsigned short d;

for(int z=0; z<=(mul_l_a-1); z++)

{mul_c[z]=0;}

for(int i=0; i<=(mul_l_a-1); i++)

{d=0;

for(int j=0; j<=(mul_l_b-1); j++)

{T=(unsigned long) mul_c[i+j]+(unsigned long) mul_a[i]*(unsigned long) mul_b[j]+d;

mul_c[i+j]=LOWORD(T);

d=HIWORD(T);}

mul_c[i+mul_l_b]=d;}}

/*c=(a*b) mod m*/

void mul_mod(unsigned short mm_a[], unsigned short mm_b[], unsigned short mm_n[], unsigned short mm_ost[], unsigned short w1[], int mm_l_a_b_n, int t)

{unsigned short *mm_d;

mm_d=new(unsigned short[mm_l_a_b_n+t]);

mul(mm_a, mm_b, mm_d, mm_l_a_b_n, t);

Div(mm_d, mm_n, w1, mm_ost, mm_l_a_b_n*2, mm_l_a_b_n);}

/*c=a(exp b) mod n*/

void exp_mod(unsigned short exp_mod_a[], unsigned short exp_mod_b[], unsigned short exp_mod_n[], unsigned short exp_mod_c[], unsigned short w1[], int exp_mod_l_a_n, int exp_mod_l_b)

{
    unsigned short *exp_mod_c_dop;

    exp_mod_c_dop=new(unsigned short[exp_mod_l_a_n]);

int e;

for(int l=1; l<=(exp_mod_l_a_n-1); l++)

{
    exp_mod_c[l]=0;

exp_mod_c_dop[l]=0;
}

exp_mod_c_dop[0]=1;

exp_mod_c[0]=1;

for(e=(16*exp_mod_l_b-1); e>=0; e--)

{mul_mod(exp_mod_c, exp_mod_c, exp_mod_n, exp_mod_c_dop, w1, exp_mod_l_a_n, exp_mod_l_a_n);

if(exp_mod_b[e/16] & (1<<(e%16)))

{mul_mod(exp_mod_a, exp_mod_c_dop, exp_mod_n, exp_mod_c, w1, exp_mod_l_a_n, exp_mod_l_a_n);}

else

{for(int h=0; h<=exp_mod_l_a_n-1; h++)

{exp_mod_c[h]=exp_mod_c_dop[h];}}}}


/*сравнение*/

int comp (unsigned short a[], unsigned short p[], int S1)

{int x=1;

for(int i=0; i!=S1; i++)

{if (a[i]!=p[i]) x=0;}

if(x==0) return 1;

else return 0;}

/*чтение из файла*/

int file_read(unsigned short t[], long curpos, int sz)

{FILE *fp;

unsigned short k;

fp=fopen("initial data.txt","r");

for(int i=0;i

{fseek(fp,curpos,SEEK_SET);

fscanf(fp,"%x",&k);

t[i]=k;

curpos=curpos+5;}

fclose(fp);

return curpos;}

/*запись в файл*/

int file_write(unsigned short t[], long curpos, int sz)

{FILE *fp;

fp=fopen("signature.txt","w");

for(int i=0;i

fclose(fp);

return curpos;}

unsigned short sign[S];

int main()

{FILE *fp1;

unsigned short p[S];

unsigned short a[S];

unsigned short q[S/2];

unsigned short x[S/2];

unsigned short m[S/2];

unsigned short k[S/2];

unsigned short y[S];

long curpos=3;

long cp=file_read(p,curpos,S);

curpos=cp+7;

cp=file_read(a,curpos,S);

curpos=cp+7;

cp=file_read(q,curpos,S/2);

curpos=cp+7;

cp=file_read(x,curpos,S/2);

curpos=cp+7;

cp=file_read(m,curpos,S/2);

curpos=cp+7;

cp=file_read(k,curpos,S/2);

curpos=cp+7;

cp=file_read(y,curpos,S);

char symb;

int c;

printf("------------------------------------------------------------\n");

printf("|Select action: |\n");

printf("|1.Serial calling rountines \"Get signature\" and \"Verify signature\". |\n");

printf("|2.Get signature |\n");

printf("|3.Verify signature |\n");

printf("|Press 0 to exit |\n");

printf("----------------------------------------------------------\n\n");

do

{symb=getch();

c=atoi(&symb);

int rs;

switch(c)

{case 0:

return 0;

case 1:

signature(p,a,q,x,m,k,sign);

file_write(sign, 0, S);

rs=verify(p,a,q,y,m,sign);

fp1=fopen("verification result.txt","w+");

if(fp1==NULL) printf("Error: couldn't open file");

if(rs==0) fprintf(fp1, "Verification successful: u=r', signature is authentic\n");

else fprintf(fp1, "WARNING: verification unsuccessful: u!=r', signature is non-authentic\n");

printf("Operations complete. Result of operation writed to \"verification result.txt\"\n");

fclose(fp1);

break;

case 2:

signature(p,a,q,x,m,k,sign);

file_write(sign, 0, S);

printf("Operation complete. Result of operation writed to \"signature.txt\"\n");

break;

case 3:

verify(p,a,q,y,m,sign);

rs=verify(p,a,q,y,m,sign);

if(rs==0) fprintf(fp1, "Verification successful: u=r', signature is authentic\n");

else fprintf(fp1, "WARNING: verification unsuccessful: u!=r', signature is non-authentic\n");

printf("Operation complete. Result of operation writed to \"verification result.txt\"\n");

break;

default: printf("Wrong number. Try again\n"); break;}}

while(1);}

Function.cpp

#include "function.h"

#include "INTERFS.h"

void signature(unsigned short sign_p[], unsigned short sign_a[], unsigned short sign_q[], unsigned short sign_x[], unsigned short sign_m[], unsigned short sign_k[], unsigned short sign[])

{
unsigned short w[S*2];

unsigned short res[S];

unsigned short result[S];

unsigned short tmp[S/2];

unsigned short tmp1[S/2];

unsigned short sum[S+1];

unsigned short s[S+1];

exp_mod(sign_a,sign_k,sign_p,res,w,S,S/2);

Div(res,sign_q,result,tmp,S,S/2);

mul(sign_x,tmp,res,S/2,S/2);

mul(sign_k,sign_m,result,S/2,S/2);

add(res,result,sum,S);

Div(sum,sign_q,s,tmp1,S,S/2);

for(int i=S/2-1, j=S-1; i>=0; i--, j--)

{sign[j]=tmp[i];

sign[j-16]=tmp1[i];}}


int verify(unsigned short p[],unsigned short a[],unsigned short q[],unsigned short y[], unsigned short m[],unsigned short sign[])

{unsigned short v[16];

unsigned short q_2[16];

unsigned short w[S];

unsigned short s[S/2];

unsigned short tmp[S];

unsigned short tmp_[S];

unsigned short tmp_1[S*2];

unsigned short tmp_2[S*2];

unsigned short tmp1[S/2];

unsigned short z1[S/2];

unsigned short z2[S/2];

unsigned short r_[S/2];

for(int i=S/2-1; i>=0; i--) q_2[i]=q[i];

q_2[0]=q_2[0]-0x0002;

exp_mod(m,q_2,q,v,w,S/2,S/2);

for(int b=S/2-1, j=S-1; b>=0; b--, j--)

{s[b]=sign[b];

r_[b]=sign[j];}

mul(s,v,w,S/2,S/2);

Div(w,q,tmp,z1,S,S/2);

sub(q,r_,tmp1,S/2);

mul(tmp1,v,w,S/2,S/2);

Div(w,q,tmp,z2,S,S/2);

exp_mod(a,z1,p,tmp,w,S,S/2);

exp_mod(y,z2,p,tmp_,w,S,S/2);

mul(tmp,tmp_,tmp_1,S,S);

Div(tmp_1,p,tmp_2,tmp,S*2,S);

Div(tmp,q,tmp_,s,S,S/2);

return comp(s,r_,S/2);}


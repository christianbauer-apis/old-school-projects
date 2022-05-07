/*
An application that uses for loops to creates lines of asterisks in descendng and ascending order
*/

public class triangles{
public static void main( String args[]){
int asterisk=11;
int spaces=10;


while ( asterisk != 0)
{
for(int i = asterisk; i<=10; i++){
System.out.print("*");
}
System.out.println();
asterisk--;
}


while ( asterisk != 11)
{
for (int i = asterisk; i<=10; i++){
System.out.print("*");
}
System.out.println();
asterisk++;
}


if(asterisk==11)
asterisk=1;
while( asterisk != 11 && spaces != 0){

for (int i= spaces; i<=10; i++){
System.out.print(" ");
}
for (int i = asterisk; i<=10; i++){
System.out.print("*");
}

System.out.println();


asterisk++;
spaces--;
}

while (asterisk !=0 && spaces !=10){
for (int i= spaces; i<=10; i++){
System.out.print(" ");
}
for (int i = asterisk; i<=10; i++){
System.out.print("*");
}

System.out.println();


asterisk--;
spaces++;
}
}
}
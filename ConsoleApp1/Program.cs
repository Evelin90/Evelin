/*
Console.WriteLine("Hello World"); //:)
Console.WriteLine("A kezdetek kezdete");
/* 
  
  a titkos üzenet
  
// el van rejtve

int n = 42;
int n2 = 245;
int n3 = -566;
int n4 = 0;

int number;     // Deklarálás
number= 55;     // Definíció

Console.WriteLine(number);

int a = 3, b = 9, c = 12;

int i1 = a + b;
int i2 = a - b;
int i3 = a * b;
int i4 = a / b;
int i5 = 17 / 3;
int i6 = 17 % 3;    //Modulo az osztás maradéka
int i7 = -b;

int x, y, z;

x = 5;
y = 3;
z = x+ y;
z = 2;

z = z + x;
z += x;     // z értékét megnöveljük x-el


int a = 3, b = 7, c = 2;
int i1 = a + b * c;
int i2= (a + b) * c;

float f = 55.33f;   // az f jelöli, hogy lebegő pontos (32 bit)
double d = 55.77;   // (64 bit)

string st = "a kankalin éjszaka virágzik";

bool b = true;
bool b2 = false;

int i3 = (int)f;    // Explicit kasztolás
float f2 = (float) i1;  //Implicit kasztolás

string st2 =i3.ToString();
string st3 = "67";
string i4 = int.Parse(st3);
Console.WriteLine(i4);

Console.WriteLine("Írj be egy számot:");
string st4 = Console.ReadLine();
int i5 = int.Parse(st4);
Console.WriteLine("Ennek duplája:");
Console.WriteLine(i5 * 2);

Console.WriteLine("Ennek duplája:" + i5*2);

string st5 = "AAA" + "BBB"



Console.WriteLine("Írj be egy számot!");
string st = Console.ReadLine();
Console.WriteLine("Írj be egy másik számot!");
string st2 = Console.ReadLine();

int i1 = int.Parse(st);
int i2 = int.Parse(st2);

int summa = i1 + i2;
int difference = i1 - i2;
int product = i1 * i2;
float qoutient = (float) i1 / i2;


Console.WriteLine("Összeg: " + summa);
Console.WriteLine("Különbség: " + difference);
Console.WriteLine("Szorzat: " + product);
Console.WriteLine("Hányados: " + qoutient);


using System.ComponentModel.Design.Serialization;
using System.Diagnostics.SymbolStore;

bool b1 = false;
bool b2 = true;

int i1 = 3, i2 = 7;
bool b3 = i1 == i2;
bool b4 = i1 > i2;
bool b5 = i1 < i2;
bool b6 = i1 >= i2;
bool b7 = i1 <= i2;

string st1 = "Alma";
string st2 = "Körte";

bool b10= st1 == st2;
bool b11= st1 != st2;


Console.WriteLine(b3);

int ammo = 7;
bool haveAmmo = ammo > 0;
bool haveWeapon = true;

bool canShoot = haveAmmo && haveWeapon; // && és

int airJumpCount = 0;
bool canJumpInAir = airJumpCount> 0;
bool grounded = true;
bool canJump = grounded || canJumpInAir;    // || vagy

bool islegBroken = false;
bool isRaining = true;
bool cantGoOut = islegBroken || isRaining;

bool canGoOut = !canGoOut;
bool canGoOut = !(islegBroken || isRaining);


Console.WriteLine("Írj be egy számot: ");
string st = Console.ReadLine();
int number = int.Parse(st);

bool isEven;    // Páros-e?
isEven = number % 2 == 0;

if (isEven) //ctrl+k+d olvashatóra berendezi
{
    Console.WriteLine("Páros");
}
else
{
    Console.WriteLine("Páratlan");
}

if (number > 0)
{
    Console.WriteLine("Pozitív");
}
else if (number < 0)
{
    Console.WriteLine("Negatív");
 }
else
{
    Console.WriteLine("Nulla");
}

//ctrl+R+E átnevezés
string pairity = isEven ? "páros" : "páratlan"; //feltételes operátor feltétel ha igaz : ha hamis

int i = 0

while (i<10)
{
    Console.WriteLine(i);
    i++;
}



using System.Globalization;

int numb = 1;
bool numb / 3 

if (numb )
{ Console.WriteLine(numb);
    numb++;
}
else
{ numb++; }

int i = 1
while(int<=10)
    { Console.WriteLine(i * 3);
    i++;
}

while (i<=30)
{
    Console.WriteLine(i);
    i += 3;
}

for (int j = 1; j <= 10; j++)   // változó definiálás, bool, növelés
{
    Console.WriteLine( j * 3);
}
*/

for (int k =1; k < 10; k++)
{
    Console.WriteLine(k + " x 1 =" + k);
}
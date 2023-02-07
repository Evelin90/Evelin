/*

double a = Math.Pow(2,6);   //hatvány
double aa = Math.Sqrt(9);   //négyzetgyök

float b = Math.Abs(12.4f);  // abszolútérték

float c = Math.Max(7,4);    // a nagyobbikat kiadja
float d = Math.Min(7,4);    // a kisebbiket adja ki

float e = Math.Sign(-10);   //előjel függvény

double f = Math.Ceiling(45.05); //plafon, felfelé kerekít
double g = Math.Floor(467.75);  //padló, lefelé kerekít
double h = Math.Round(33.6);    // sima kerekítés

float number = 12.544f;
float b = Math.Abs(number);
float c = Math.Sign(number);
float n1 = b * c;

 

float a1 = Abs(-13.5f);

float Abs(float num)    //kimeneti típus függvénynév (paraméter)
{
    float result = num;

    if (num < 0)
        result = -num;

    return result;
}

float Max(float a, float b)
{
    if (a < b)
    {
        return b;
    }
   
    return a;
}


float Sign(float num)
{
    if (num < 0)
    {
        return -1;
    }
    else
    {
        return 1;
    }
}


void MyMethod(int n)
{
    for (int i = 0; i <= n; i++)
    {
    Console.WriteLine(i); 
    }
}
*/


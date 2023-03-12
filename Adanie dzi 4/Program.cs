// zadanie dz 5 liczba 2482


using System.Diagnostics.Metrics;

int number = 2482;
string numberAsstring = number.ToString();
char[] letters = numberAsstring.ToArray();

int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;


foreach (char letter in letters) 
{
    if (letter == '0')
    {
        counter0++;
    }
    else if (letter == '1') 
    {
        counter1++;
    }
    else if (letter =='2')
    {
        counter2++;
    }
    else if (letter == '3')
    {
        counter3++;
    }
    else if (letter == '4')
    {
        counter1++;
    }
    else if (letter == '5')
    {
        counter2++;
    }
    else if (letter == '6')
    {
        counter3++;
    }
    else if (letter == '7')
    {
        counter1++;
    }
    else if (letter == '8')
    {
        counter2++;
    }
    else if (letter == '9')
    {
        counter3++;
    }

}
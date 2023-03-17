string word  = "mammamiaa";
char[] letters = word.ToArray();

var lettera = 0;
var letterb = 0;
var letterm = 0;


foreach (char letter in letters)
{
    if (lettera == 'a')
    {
        lettera++;
    }
    else if (letterb == 'b')
    {
        letterb++;
    }
    else if (letterm == 'm')
    {
        letterm++;
    }
    
}
Console.WriteLine("Ile w słowie " + word);
Console.WriteLine("znajduje się liter:");

Console.WriteLine("Dla a = " + lettera);
Console.WriteLine("Dla b = " + letterb);
Console.WriteLine("Dla m = " + letterm);
  
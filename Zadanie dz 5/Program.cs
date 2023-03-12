// zadanie dzi 5

int number = 24899;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();
int[] lettersSum = new int[10];

List<string> numberIn = new List<string>();
numberIn.Add("0");
numberIn.Add("1");
numberIn.Add("2");
numberIn.Add("3");
numberIn.Add("4");
numberIn.Add("5");
numberIn.Add("6");
numberIn.Add("7");
numberIn.Add("8");
numberIn.Add("9");

foreach (var numb in numberIn)
{

}
for (int i = 0; i < 10; i++)
{
    int counter = 0;
    foreach (char letter in letters)
    {
        int charInNumber = letter - '0';
        if (charInNumber == i)
        {
            counter++;
        }
    }
    Console.WriteLine(i + "-" + counter);
}



// zadanie dzien 6

using System;
using System.ComponentModel.Design;

Employee e1 = new Employee(" Adam" , " Sowa" , 25);
Employee e2 = new Employee(" Ada", " Sawa", 22);
Employee e3 = new Employee(" Ad", " So", 20);

e1.AddScore(2);
e1.AddScore(2);
e1.AddScore(2);
e1.AddScore(2);
e1.AddScore(2);
var result = e1.Resulte;


e2.AddScore(1);
e2.AddScore(1);
e2.AddScore(1);
e2.AddScore(1);
e2.AddScore(1);
var result2 = e2.Resulte;


e3.AddScore(4);
e3.AddScore(2);
e3.AddScore(4);
e3.AddScore(4);
e3.AddScore(4);
var result3 = e3.Resulte;


if (result > result2)
{
    if (result > result3)
    {
        Console.WriteLine("Osoba" + e1.Name + "" + e1.Surname + " wiek" + e1.Age + " lat" + " uzyskala punktow" + result + " co daje 1 miejscw");
    }
    else if (result2 > result && result2 > result3)
    {
        Console.WriteLine("2");
    }
    else if (result3 > result && result3 > result2)
    {
        Console.WriteLine("Osoba" + e3.Name + "" + e3.Surname + " wiek" + e3.Age + " lat" + " uzyskala punktow" + result3 + " co daje 1 miejscw");
    }
}

        
  


using System.Linq;


List<string> heroesList = new List<string> { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };


// Query syntax
//query syntax can be used with 'join' and more compplex stuff (but method syntax is almost always preferred)

var queryResult2 = from h in heroesList
                   where h.Contains("a") //where is for condition (like if) return the elements with that condition
                   select $"{h} contains an 'a'"; //select can change an element like here it puts it in a string

// Method syntax
//method syntax should always be used when possible

var queryResult = heroesList
    .Where(h => h.Count() > 0); //.Select() is not needed here as we don't need to change the element.  -> we just filter the list



Console.WriteLine($"queryResult has {queryResult.Count()} elements");

foreach (string s in queryResult2)
{
    Console.WriteLine(s);
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonKorrektur
{
    internal class Person
    {
        // Erstelle ein Programm in dem ein User seinen Namen angeben kann
        // Erstelle zudem eine Klasse Person mit den Feldern; Name, Alter und Beruf
        // DIe Klasse hat zudem auch zwei Methoden, einmal die Methode <Begruessung> die den User mit seinem Namen begrüsst und sich selbst vorstellt.
        // Die zweite Methode heißt <Infos> und gibt im Format Name:... Alter:... Beruf: ... die Informationen über das jeweilige Objekt aus (Person)
        // Erstelle aus der Klasse Person zwei Objekte und befülle die Felder.
        // Erstelle dnan ein Menü wo man auf jedes Objekt zugreifen kann und die Methoden von diesen Objekten ausführen kann. 

        public string Name;
        public int Alter;
        public string Beruf;


        public Person(string wert1, int wert2, string wert3) 
        { 
            Name = wert1;
            Alter = wert2;
            Beruf = wert3;
        }


        public void Begruessung(string userName) 
        {
            Console.WriteLine($"Hallo {userName}, ich bin {Name}.");
        }

        public void Infos()
        {
            Console.WriteLine($"Name: {Name}\nAlter: {Alter}\nBeruf: {Beruf}");
        }



    }
}

using ws_vs2022.src.Entities;
using static System.Console;

class Program{
    static void Main(string[] args){

    Knight knight = new Knight("Arus", 23, "Knight");
    Wizard wizard = new Wizard("Janica", 23, "White Wizard");
    Ninja ninja = new Ninja("Wedge", 45, "Ninja");
    BlackWizard blackWizard = new BlackWizard("Topapa", 75, "Black Wizard");

    WriteLine(knight.Attack(7));
    WriteLine(wizard.Attack(7));
    WriteLine(ninja.Attack(10));
    WriteLine(blackWizard.Attack(63));
    }
}
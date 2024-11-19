

class Program
{
    static void Main(string[] args)
    {
        //instantie
        Persoon p1 = new Persoon();
        p1.naam = "Armando";
        p1.leeftijd =22;
        p1.haarkleur = "Bruin";
        Persoon p2 = new Persoon();
        p2.naam="Sam";
        p2.leeftijd = 20;
        p2.haarkleur="Donkerblond";
        //Arrays zijn snel, maar hebben een vaste lengte
        // Persoon[] personenArray  =[p,p2];
        //Lists zijn slomer maar kunnen groeien en smaller worden
        List<Persoon> personen = [];
        //vraag om 3 gebruikers hun gegevens
        for(int i=0;i<3;i++){
            MaakPersoon(personen);
        }
        Console.Clear();
        foreach(Persoon p in personen ){
            p.PrintPersoon();
        }

        

        
        
    }
    static void MaakPersoon(List<Persoon> lijst){
        
            Persoon persoon = new Persoon();
            Console.WriteLine("vul je naam in:");
            persoon.naam = Console.ReadLine();
            Console.WriteLine("vul je leeftijd in:");
            persoon.leeftijd = int.Parse(Console.ReadLine());
            Console.WriteLine("vul je haarkleur in:");
            persoon.haarkleur = Console.ReadLine();
            lijst.Add(persoon);
        
    }
   
   
}
//Class is niks anders dan een blauwdruk, voor wat een object gaat zijn
class Persoon{
    //members/fields
    public string naam; //lege string
    public int leeftijd;//0
    public string haarkleur;//lege string

    //methodes/functions
    //methode/functie die niks terug geeft maar code uit voert oftewel 'void' 
    public void PrintPersoon(){
            Console.WriteLine($"Naam: {naam}, Leeftijd: {leeftijd}, Haarkleur: {haarkleur}");

    }
}

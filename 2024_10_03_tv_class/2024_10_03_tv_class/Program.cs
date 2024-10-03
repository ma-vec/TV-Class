// See https://aka.ms/new-console-template for more information
class TV {
    string risoluzione;
    string marca;
    string modello;
    bool stato;
    int canale;
    int volume;

    void accendi() {
        stato=true;
    }
    void spegni() {
        stato=false;
    }
    int setCanale(int nuovoCanale) {
        canale=nuovoCanale;
        if (canale==nuovoCanale) {          //Controllo degli errori
            return canale;
        } else {
            return -1;
        }
    }
    int setVolume(int nuovoVolume)
    {
        volume = nuovoVolume;
        if (volume == nuovoVolume)      //Controllo degli errori
        {
            return volume;
        }
        else
        {
            return -1;
        }
    }

    static void Main(string[] args)
    {
        TV s1 = new TV();
        TV s2 = new TV();

        s1.accendi();
        s1.setCanale(5);
        s1.setVolume(3);
        s2.accendi();
        s2.setCanale(10);
        s2.setVolume(10);
        Console.WriteLine("SCHERMO 1\nStato: " + s1.stato + "\nCanale: " + s1.canale + "\nVolume: " + s1.volume);
        Console.WriteLine("\nSCHERMO 2\nStato: " + s2.stato + "\nCanale: " + s2.canale + "\nVolume: " + s2.volume);
    }
}


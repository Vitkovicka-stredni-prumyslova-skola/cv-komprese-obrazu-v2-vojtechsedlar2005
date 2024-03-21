using System;
using System.Collections.Generic;namespace Komprese
{
    public class KompreseObrazu{

        public static void Main (String [] args){
        
        //Cesta k testovacímu souboru
        String testFilePath = @"C:\Users\VojtěchSedlář\github-classroom\Vitkovicka-stredni-prumyslova-skola\cv-komprese-obrazu-v2-vojtechsedlar2005\KompreseObrazu\CSV\obr1-10.csv";
        
        //vytvoření instance třídy Obrazek
        Obrazek inputCSV = new Obrazek(testFilePath);
        List<int> unikatniBarvy = inputCSV.PaletaBarevObrazku();
        Dictionary<int, int> colorCounts = new Dictionary<int, int>();
        

        foreach (int color in unikatniBarvy)
            {
                int count = inputCSV.PocetUnikatnichBarev(color);
                colorCounts.Add(color, count);
            }
        //Test metody, která spočítá počet řádků vstupního obrázku
        Console.WriteLine("Počet vertikálních řádků {0}",inputCSV.CountLines(testFilePath));
        
        //Test metody, která spočítá počet symbolů vstupního obrázku v prvním řádku
        Console.WriteLine("Počet horizontální řádků {0}",inputCSV.CountSymbolInLine(testFilePath));

        inputCSV.vypisImg();
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Unikátní barvy: ");
        foreach(int element in unikatniBarvy){
            Console.Write($"{element}, ");
        }


        Console.WriteLine("-----------------------------------");
            foreach (var kvp in colorCounts)
            {
                Console.WriteLine($"Barva: {kvp.Key}, Počet výskytů: {kvp.Value}");
            }
    }

    }
    
    
}
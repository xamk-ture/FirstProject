namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tehtävä 1: Tulosta "Hello World!"

            //Tehtävä 2: Kysy käyttäjältä nimi ja tulosta "Terve, <name>!"

            //Tehtävä 3: Poista nimestä turhat välilyönnit

            //Tehtävä 4: Muuta nimen ensimmäinen kirjain isoksi ja muut pieniksi käyttämällä CapitalizeFirstLetter funktiota

            //Tehtävä 5: Kysy käyttäjältä sukunimi omaan muuttujaan ja tulosta "Terve, <firstName> <lastName>!"
            //Tulosta käyttäjän nimi kolmella eri tavalla, käyttäen eri string tekniikoita
            //Katso esimerkkiä SecondProject\Program.cs

            //Tehtävä 6: Kommentoi koodi selventämään, että mitä se tekee

        }

        private static string CapitalizeFirstLetter(string? inputString)
        {
            /*inputString.First().ToString().ToUpper(): Ottaa ensimmäisen merkin inputString-merkkijonosta, 
             * muuttaa sen takaisin merkkijonoksi char tyyppisestä muuttujasta ja muuttaa sen isoksi kirjaimeksi (eli alkukirjaimeksi).

             inputString.Substring(1).ToLower(): Ottaa inputString-merkkijonon loput merkit ensimmäisen merkin jälkeen ja muuttaa ne pieniksi kirjaimiksi.
             Lopuksi yllä mainitut kaksi osaa yhdistetään yhteen merkkijonoon käyttäen + -operaattoria.
             Koodin tulos on, että inputString-merkkijonon ensimmäinen kirjain muutetaan isoksi kirjaimeksi ja kaikki muut merkit pieniksi kirjaimiksi. 
             Esimerkiksi jos inputString oli alun perin "hELLo", sen arvo koodin suorittamisen jälkeen on "Hello".*/

            inputString = inputString.First().ToString().ToUpper() + inputString.Substring(1).ToLower();
            return inputString;
        }


    }
}
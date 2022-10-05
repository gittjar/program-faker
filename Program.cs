using Faker;

internal class Program
{
    private static void Main(string[] args)
    {
/*
        asennettu NuGet Gallery VS Codeen
        ja haetaan NuGet Gallerylla Faker.net ohjelmakoodi
        + liitetään se tähän ohjelmaan

        HUOM! using Faker;

        TEHTÄVÄNANTO:
        Tee C# ohjelma, joka tulostaa konsoliin 3:n kuvitteellisen henkilön tiedot:

        Nimi ja Sukunimi
        Osoite
        Henkilötunnus (kirjain ja 8 numeroa, esim  A 5652 3342)

        FAKERIN KENTTÄMÄÄRITTELYT:
        https://github.com/oriches/faker-cs/blob/master/README.markdown
*/
        
        for (int i = 0; i < 3; i++)
        {        
        // määrittelyt alla           
        var name = Name.FullName();
        var address = Address.StreetAddress();
        var city = Address.City();
        var ukNhs = Identification.UkNhsNumber();

        Console.WriteLine($"Hei! {name}, osoitteesta {address}, {city}.");
        Console.WriteLine($"Henkilötunnuksesi on: {ukNhs}.");
        Console.WriteLine("");
        }



    }
}
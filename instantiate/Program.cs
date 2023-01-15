namespace instantiate;
class Talo{
    public bool TarvitaankoLammitysta(double arvo){
    //public static bool TarvitaankoLammitysta(double arvo){
        bool paluu = true;
        if(arvo > 10.0){
            paluu = false;
        }
        return paluu;
    }
}

class Program
{
    static void Main(string[] args)
    {
        //1. ei toimi
        //Console.WriteLine( "Tarvitaanko: " + Talo.TarvitaankoLammitysta(18.8) );

        //2. toimii
        Talo talo1 = new Talo();
        Console.WriteLine( "Tarvitaanko: " + talo1.TarvitaankoLammitysta(18.8) );
    
        //miksi?
        // muuta metodi static:iksi -> public static bool TarvitaankoLammitysta(double arvo){
        // ja aja 1. uudelleen
    }
}

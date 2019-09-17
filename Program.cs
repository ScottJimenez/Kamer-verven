using System;

namespace Oefeningen_thuis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            const double _MINUUT = 60;
            const double _UUR = _MINUUT * 60;
            double _uren, _minuut;
            double _Lengte, _Breedte, _Hoogte, _TijdM2, _Tijdmuur, _oppervlakte;
            //Input
            Console.WriteLine("Geef de lengte van de kamer in meter:");
             _Lengte = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geef de Breedte van de kamer in meter:");
             _Breedte = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geef de hoogte van de kamer in meter:");
             _Hoogte = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hoelang duurt het om 1m² te schilderen in seconde:");
             _TijdM2 = Convert.ToDouble(Console.ReadLine());

            //Bewerking
            _oppervlakte = (_Breedte * _Hoogte) + (_Lengte * _Hoogte);
            //Tijd
            _Tijdmuur = _oppervlakte * _TijdM2;

            _uren = _Tijdmuur / _UUR;
            _Tijdmuur %= _UUR;

            _minuut = _Tijdmuur / _MINUUT;
            _Tijdmuur %= _MINUUT;
            //Output
            Console.WriteLine("Je zal " + _uren.ToString("0.0 uren") + " : " + _minuut.ToString("0.0 minuten") + " : " + _Tijdmuur.ToString("0.0 seconde") + " over doen.");
            Console.ReadLine();



        }
    }
}

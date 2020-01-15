using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolokwiumPoprawa
{
    class EBook
    {

        private DateTime _dataOstatniegoZakupu;
        private double _cenaStandardowa;
        private double _obnizka;


        readonly string _autor;
        readonly string _tytul;
        readonly DateTime _dataWydania;

        public DateTime DataOstatniegoZakupu
        {
            get { return _dataOstatniegoZakupu; }
            set
            {
                if (value.Date < _dataOstatniegoZakupu.Date)
                    Console.WriteLine("Wartosc mniejsza od poprzedniej wartosci");
                else _dataOstatniegoZakupu = value;
            }
        }

        public double CenaStandardowa
        {
            get { return _cenaStandardowa; }
            set
            {
                if (value > 0) _cenaStandardowa = value;
                else Console.WriteLine("Cos nie tak z cena standardowa");


            }
        }

        public double Obnizka
        {
            get { return _obnizka; }
            set
            {
                if (value <= 100 && value > 0) _obnizka = value;
                else Console.WriteLine("Cos nie tak z obnizka");

            }
        }

        private double _aktualnaCena;

        public EBook(string autor, string tytul, DateTime dataWydania, DateTime dataOstatniegoZakupu, double cenaStandardowa, double obnizka)
        {
            _autor = autor;
            _tytul = tytul;
            _dataWydania = dataWydania;
            DataOstatniegoZakupu = dataOstatniegoZakupu;
            CenaStandardowa = cenaStandardowa;
            Obnizka = obnizka;
        }

        public double AktualnaCena
        {
            get { return _aktualnaCena = CenaStandardowa * ((100 - Obnizka) / 100); ; }
            set { _aktualnaCena = CenaStandardowa * ((100 - Obnizka) / 100); }

        }
    }
}

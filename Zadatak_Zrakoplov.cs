using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zrakoplov
{
    internal class Zrakoplov1
    {
        static void Main(string[] args)
        {
            Zrakoplov zrakoplov = new Zrakoplov();

            zrakoplov.setnaziv("Airbus");
            zrakoplov.setSnagaMotora(2000);
            zrakoplov.setDosegLeta(6000);


            Console.WriteLine("Naziv zrakoplova: " + zrakoplov.getnaziv() + "\n"
                + "Snaga motora: " + zrakoplov.getSnagaMotora() + "kw" + "\n"
                + "Doseg Leta: " + zrakoplov.getDosegLeta() + "km" +  "\n");

            Zrakoplov zrakoplov1 = new Zrakoplov("Cesna SkyCatcher", 75, 870);

            Zrakoplov zrakoplov2 = new Zrakoplov("Pilatus", 1200, 1333);

            Console.WriteLine(zrakoplov1.ToString());

            Console.WriteLine(zrakoplov2.ToString());

            Console.ReadKey();
        }
    }

    class Zrakoplov
    {
        String naziv;
        int dosegLeta;
        double snagaMotora;

        public override string ToString()
        {
            string ispis = "Naziv zrakoplova: " + this.getnaziv()
                + "\n" + "Snaga motora: " + this.getSnagaMotora() + "kw" + "\n"
                + "DosegLeta: " + this.getDosegLeta() + "km" +  "\n";
            return ispis;
        }
        public Zrakoplov()
        {

        }

        public Zrakoplov(String naziv, int dosegLeta, double snagaMotora)
        {
            this.naziv = naziv;
            this.dosegLeta = dosegLeta;
            this.snagaMotora = snagaMotora;
        }



        public void setnaziv(String naziv)
        {
            this.naziv = naziv;
        }
        public String getnaziv()
        {
            return this.naziv;
        }
        public void setDosegLeta(int dosegLeta)
        {
            this.dosegLeta = dosegLeta;
        }
        public int getDosegLeta()
        {
            return this.dosegLeta;
        }
        public void setSnagaMotora(double snagaMotora)
        {
            this.snagaMotora = snagaMotora;
        }
        public double getSnagaMotora()
        {
            return this.snagaMotora;
        }
    }
}
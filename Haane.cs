using System;
using System.Collections.Generic;
using System.Text;

namespace Hoone
{
    public class Hoone
    {
        public int Pindala { get; set; }
        public Uks uks;

        public Uks GetUks()
        {
            return uks;
        }


        public Hoone(int pindala = 200)
        {
            Pindala = pindala;


        }

        public void NaitaInfo()
        {
            Console.WriteLine($"Mina olen maja, minu pindala on {Pindala} m2");
            //Console.WriteLine("Minu maja suurus on {0}", Suurus);
        }


    }

    public class Uks
    {
        public string Color { get; set; }

        public Uks(string color = "sinine")
        {
            Color = color;
        }

        public void NaitaInfo()
        {
            Console.WriteLine($"Mina olen uks, minu värv on {Color}");
        }
    }

    public class EraMaja : Hoone
    {
        
        public EraMaja(int pindala = 50) : base(pindala)
        {
        }

        public string Suurus
        {
            get
            {
                var suurus = "";
                if (Pindala <= 25)
                {
                    suurus = "vaike maja";
                }
                else if (Pindala <= 50)
                {
                    suurus = "keskmine maja";
                }
                else if (Pindala <= 75)
                {
                    suurus = "suur maja";
                }
                else
                {
                    suurus = "liiga suur maja";
                }
                return suurus;
            }

        }

        public void NaitaINFO()
        {
            Console.WriteLine("Minu maja suurus on {0}", Suurus);
        }
    }

    public class Inimene
    {
        private string nimi;
        public Hoone hoone { get; set; }
        //public EraMaja eramaja { get; set; }

        public Inimene(string nimi)
        {
            this.nimi = nimi;
        }

        public void NaitaInfo()
        {
            Console.WriteLine($"Mina olen inimene, nimu nimi on {nimi}");
            Console.WriteLine("Hoone info:");
            hoone.NaitaInfo();
            //eramaja.NaitaINFO();
            Console.WriteLine("Ukse info:");
            hoone.GetUks().NaitaInfo();
        }
    }
}

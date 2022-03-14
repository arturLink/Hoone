using System;

namespace Hoone
{
    class Program
    {
        static void Main(string[] args)
        {
            EraMaja majake = new EraMaja();
            Inimene mees = new Inimene("Juku");
            majake.uks = new Uks("must");
            mees.hoone = majake;
            majake.NaitaINFO();
            mees.NaitaInfo();
        }
    }
}

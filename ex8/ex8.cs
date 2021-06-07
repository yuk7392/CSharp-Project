using System;

namespace ex8
{
    class Mile
    {

        public double distance;
        public Mile(double distance)
        {
            this.distance = distance;

        }

        public static implicit operator Mile(double d)
        {
            Mile m = new Mile(d);
            return m;

        }

        public static explicit operator Kilometer(Mile m)
        {
            return m.distance * 1.609;

        }

    }

    class Kilometer
    {
        public double distance;
        public Kilometer(double distance)
        {

            this.distance = distance;
        }
        public static implicit operator Kilometer(double d)
        {

            Kilometer k = new Kilometer(d);
            return k;
        }

        public static explicit operator Mile(Kilometer k)
        {
            return k.distance / 1.609;

        }

    }



    class ex8
    {
        static void Main(string[] args)
        {
            Kilometer k = new Kilometer(100.0);
            Mile m;
            m = (Mile)k;
            Console.WriteLine("{0}km = {1} mile", k.distance, m.distance);
            m = 65.0;
            k = (Kilometer)m;
            Console.WriteLine("{0} mile = {1} km", m.distance, k.distance);
        }
    }
}

using System;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            singleton obj = singleton.initialize;
        }
    }

    public class singleton
    {
        //make the constructor private so that this class cannot be
        //instantiated
        private singleton() {}
        private static singleton instance;
        //create and Get only object one object
        public static singleton initialize
        {
            get
            {
                if (instance == null)
                {
                    instance = new singleton();
                }
                return instance;
            }
        }
    }

}

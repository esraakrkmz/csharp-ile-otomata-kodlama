using System;

namespace abdensonra
{
    class Program
    {
        static void Main(string[] args)
        {
            //içerisinde de bulunduran stringleri kabul eden otomata(otomatanın alfabesi a,b,c,d,e,f,g,h,i,k)
            string s1 = "abcdfgh";

            int[,] q = new int[3, 10];
            int state = 0;
            q[0, 3] = 1;
            q[1, 4] = 2;
           
            for (int i = 0; i < 10; i++)
            {
                q[2, i] = 2;

            }
           
            for (int i = 0; i < s1.Length; i++)
            {
                state = q[state, s1[i] - 'a'];
                
            }
            if (state == 2) Console.WriteLine("kabul edildi");
            else { Console.WriteLine("kabul edilmedi"); }


        }
    }
}

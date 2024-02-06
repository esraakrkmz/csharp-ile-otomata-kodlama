using System;

namespace Mediumyazısıotomataörneği1
{
    class Program
    {
        static void Main(string[] args)
        {
            //arka arkaya iki tane bir gelen bit dizgilerini kabul eden otomata kodu
            string s1 = "010100101";

            int state = 0;
            int[,]q= new int[3, 2];
            q[0, 0] = 0;
            q[0, 1] = 1;
            q[1, 0] = 0;
            q[1, 1] = 2;
            q[2, 0] = 2;
            q[2, 1] = 2;
            for (int i = 0; i < s1.Length; i++)
            {
                state = q[state, s1[i]-'0'];
            }
            if(state == 2)
            {
                Console.WriteLine("kabul edildi");
            }
            else
            {
                Console.WriteLine("kabul edilmedi");
            }



        }
    }
}

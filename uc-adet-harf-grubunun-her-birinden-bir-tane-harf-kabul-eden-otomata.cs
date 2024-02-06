using System;

namespace otoörnegi
{
    class Program
    {
        static void Main(string[] args)
        {
            //abc , def , ghi şekilinde üç adet harf grubumuz bulunsun bunların içinden sadece birer harf kabul
            //eden otomata kodu
            string s = "adh";
            int[,] q = new int[4,10];
            int state = 0;
            q[0, 0] = 1;
            q[0, 1] = 1;
            q[0, 2] = 1;
            for (int i = 3; i < 9; i++)
            {
                q[0, i] = 3;
            }
            for (int i = 0; i < 9; i++)
            {
                q[1, i] = 3;
            }
            q[1,3] = 2 ;
            q[1,4] = 2;
            q[1, 5] = 2;

            q[2, 6] = 0;
            q[2, 7] = 0;
            q[2, 8] = 0;
            for (int i = 0; i < 9; i++)
            {
                q[2, i] = 3;
            }



            for (int i = 0; i < 9; i++)
            {
                q[3, i] = 3;
            }
            for (int i = 0; i < s.Length; i++)
            {
                state = q[state, s[i] - 'a'];
            }
            if (state==3)
            {
                Console.WriteLine("bulundu");
            }
           else
            {
                Console.WriteLine("bulunmadı");
            }

        }
    }
}

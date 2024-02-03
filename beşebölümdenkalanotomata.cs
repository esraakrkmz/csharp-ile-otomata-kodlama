using System;

namespace otomatakodu
{
    class Program
    {
        static void Main(string[] args)
        {
            //ikilik sayı sisteminde sonsuz uzunlukta tanımlanan bir sayının onluk sayı sistemine göre beşe böşümünden kalanın iki olduğu dfayı kodlaynız.

            Console.WriteLine("İkilik sayı sistemine göre bir sayı giriniz.(ör.10001001 gibi)");
            string sayı = Console.ReadLine();
            int[,]q= new int[5, 2];
            int state = 0;
            q[0, 0] = 0;
            q[0, 1] = 1;
            q[1, 0] = 2;
            q[1, 1] = 3;
            q[2, 0] = 4;
            q[2, 1] = 0;
            q[3, 0] = 1;
            q[4, 0] = 3;
            q[4, 1] = 4;
            for (int i = 0; i < sayı.Length; i++)
            {
                state = q[state, sayı[i] - '0'];

            }
            if (state != 3)
            {
                Console.WriteLine("kabul edilmedi");
            }
            else
            {
                Console.WriteLine("kabul edildi");
            }



        }
    }
}

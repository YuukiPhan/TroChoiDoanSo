using System;

namespace DoanSo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int soCanDoan = random.Next(100, 1000); // Số máy tính sinh ra
            int soLanDoan = 0;

            Console.WriteLine("Chao mung ban den voi tro choi!");
            Console.WriteLine("may tinh da nghi ra mot so có ba chu so tu 100 den 999.");

            while (soLanDoan < 7)
            {
                Console.Write("moi ban doan so : ");
                int soDoan = int.Parse(Console.ReadLine());

                string phanHoi = KiemTraSoDoan(soCanDoan, soDoan);
                Console.WriteLine(phanHoi);

                if (phanHoi == "+++")
                {
                    Console.WriteLine("chuc mung ban da doan dung!");
                    break;
                }

                soLanDoan++;
            }

            if (soLanDoan == 7)
            {
                Console.WriteLine("ban da het luot doan. so can doan la: " + soCanDoan);
            }
        }

        static string KiemTraSoDoan(int soCanDoan, int soDoan)
        {
            string phanHoi = "";
            char[] soCanDoanChar = soCanDoan.ToString().ToCharArray();
            char[] soDoanChar = soDoan.ToString().ToCharArray();

            for (int i = 0; i < 3; i++)
            {
                if (soDoanChar[i] == soCanDoanChar[i])
                {
                    phanHoi += "+";
                }
                else if (soCanDoanChar.Contains(soDoanChar[i]))
                {
                    phanHoi += "?";
                }
            }

            return phanHoi;
        }
    }
}

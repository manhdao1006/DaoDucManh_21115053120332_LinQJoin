using System;

namespace DaoDucManh_21115053120332_LinQJoin
{
    class Program
    {
        static List list;
        static void Menu()
        {
            try
            {
                Console.WriteLine("Nhap tu 1 - 7 de thuc hien cac chuc nang sau:");
                Console.WriteLine("1. Hien thi luong cao nhat");
                Console.WriteLine("2. Hien thi luong thap nhat");
                Console.WriteLine("3. Hien thi luong trung binh");
                Console.WriteLine("4. GroupJoin");
                Console.WriteLine("5. LeftJoin");
                Console.WriteLine("6. Hien thi tuoi cao nhat");
                Console.WriteLine("7. Hien thi tuoi thap nhat");
                int menu = 0;
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        {
                            list.GetMaxSalary();
                            break;
                        }
                    case 2:
                        {
                            list.GetMinSalary();
                            break;
                        }
                    case 3:
                        {
                            list.GetAverageSalary();
                            break;
                        }
                    case 4:
                        {
                            list.GetGroupJoin();
                            break;
                        }
                    case 5:
                        {
                            list.GetLeftJoin();
                            break;
                        }
                    case 6:
                        {
                            list.GetMaxAge();
                            break;
                        }
                    case 7:
                        {
                            list.GetMinAge();
                            break;
                        }
                    default:
                        Console.WriteLine("Yeu cau nhap chuc nang cua menu tu 1 - 7");
                        Menu();
                        break;
                }
            }
            catch (Exception ex)
            {
                Menu();
            }
        }
        static void Main(string[] args)
        {
            list = new List();
            char c = 'y';
            while (c == 'y')
            {
                Menu();
                Console.WriteLine("\nNhap ky tu 'y' de tro ve menu hoac ky tu bat ky de thoat");
                c = Convert.ToChar(Console.ReadLine().ToLower());
            }
            Console.ReadKey();
        }
    }
}

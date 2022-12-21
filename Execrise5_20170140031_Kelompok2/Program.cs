using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execrise5_20170140031_Kelompok2
{

    class Program
    {
        static void Main(string[] args)
        {
            Stacks st = new Stacks();
            st.Mulai();
        }
    }

    class Antrian
    {
        public string nama;
        public Antrian next;
        public Antrian(string n, Antrian d)
        {
            nama = n;
            next = d;
        }
    }

    class Stacks
    {
        Antrian depan;
        Antrian belakang;
        public Stacks()
        {
            depan = null;
            belakang = null;
        }
        bool Antrian_Kosong()
        {
            if (depan == null)
                return (true);
            else
                return (false);
        }

        public void masukkan(string nama)
        {
            Antrian baru;
            baru = new Antrian(nama, null);
            if (depan == null)
            {
                depan = baru;
                belakang = baru;
            }
            else
            {
                belakang.next = baru;
                belakang = belakang.next;
            }

            Console.WriteLine("\nmasuk" + nama + " dalam antrian.");
        }

        public void keluarkan()
        {
            Console.WriteLine("\nAntrian Selesai: " + depan.nama);
            depan = depan.next;
        }

        public void display()
        {
            Antrian sementara;
            if (Antrian_Kosong())
                Console.WriteLine("\ntidak ada antrian");
            else
            {
                Console.WriteLine();
                for (sementara = depan; sementara != null; sementara = sementara.next)
                {
                    Console.WriteLine(sementara.nama);
                }
                Console.WriteLine();
            }
        }
        public void Mulai()
        {
            Stacks s = new Stacks();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1. tambah Element.");
                Console.WriteLine("2. Hapus Element");
                Console.WriteLine("3. Tampilkan");
                Console.WriteLine("4. Keluar");
                Console.Write("\npilihan: ");
                string sInput = Console.ReadLine();
                char ch = Convert.ToChar(sInput == "" ? "0" : sInput);
                Pilihan(ch);
            }

            void Pilihan(char ch)
            {
                switch (ch)
                {
                    case '1':
                        Console.Write("\nTulis sebuah Nama: ");
                        string num = Console.ReadLine();
                        s.masukkan(num);
                        break;
                    case '2':
                        if (s.Antrian_Kosong())
                        {
                            Console.WriteLine("\nIsi kosong");
                            break;
                        }
                        s.keluarkan();
                        break;
                    case '3':
                        s.display();
                        break;
                    case '4':
                        return;
                    default:
                        Console.WriteLine("\nSalah Pilih");
                        break;
                }
            }
        }
    }
}

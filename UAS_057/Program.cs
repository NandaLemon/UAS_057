using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UAS_057
{
    class Node
    {
        public int NomorBuku;
        public string judulBuku;
        public string NamaPengarang;
        public int TahunTerbit;
        public Node next;
    }
    class List
    {
        Node START;
        public List()
        {
            START = null;
        }
        public void addNote()
        {
            int NomorBuku;
            string judulBuku;
            string NamaPengarang;
            int TahunTerbit;
            Console.Write("\nMasukkan nomor buku: ");
            NomorBuku = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nMasukkan Judul Buku:");
            judulBuku = Console.ReadLine();
            Console.Write("\nMasukkan Nama Pengarang:");
            NamaPengarang = Console.ReadLine();
            Console.Write("\nMasukkan Tahun Terbit:");
            TahunTerbit = Convert.ToInt32(Console.ReadLine());
            Node newnode = new Node();
            newnode.NomorBuku = NomorBuku;
            newnode.judulBuku = judulBuku;
            newnode.NamaPengarang = NamaPengarang;
            newnode.TahunTerbit = TahunTerbit;

            if (START == null || NomorBuku <= START.NomorBuku)
            {
                if ((START! = null) && (NomorBuku == START.NomorBuku))
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed\n");
                    return;
                }
                newnode.next = START;
                START = newnode;
                return;
            }
            Node previous, current;
            previous = START;
            current = START;

            while ((current! = null) && (NomorBuku >= current.NomorBuku))
            {
                if (NomorBuku ==current.NomorBuku)
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed\n");
                    return;
                }
                previous = current;
                current = current.next;
            }
            public bool delNode(int rollNo)
            {
                Node previous, current;
                previous = current = null;
                if (Search(rollNo, ref previous, ref current) == false)
                    return false;
                previous.next = current.next;
                if (current == START)
                    START = START.next;
                return true;

            }
            public bool Search(int rollNo,ref Node previous,ref Node current)
            {
                previous = START;
                current = START;
                while ((current != null) && (rollNo ! = current.TahunTerbit))
                {
                    previous = current;
                    current = current.next;

                }
                if (current == null)
                    return false
                else
                    return true;
            }
        }
    }
    
}



//2.double linklist
//3.oprasi Pop and Push
//4.insert dan delete
//5.a = 5 || b = postorder Traversal : 25 20 10 5 2 22 12  8 15 36 30 28 40 38  48 45 50
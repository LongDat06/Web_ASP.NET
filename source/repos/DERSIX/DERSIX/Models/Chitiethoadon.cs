using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DERSIX.Models
{
    public class Chitiethoadon
    {
        private int idchitiethoa;
        private int mahoadon;
        private String idsp;
        private int soluong;
        private int gia;
       
        public Chitiethoadon() { }
        public Chitiethoadon(int idchitiethoa, int mahoadon, string idsp, int soluong, int gia)
        {
            this.Idchitiethoa = idchitiethoa;
            this.Mahoadon = mahoadon;
            this.Idsp = idsp;
            this.Soluong = soluong;
            this.Gia = gia;
        }

        public int Idchitiethoa { get => idchitiethoa; set => idchitiethoa = value; }
        public int Mahoadon { get => mahoadon; set => mahoadon = value; }
        public string Idsp { get => idsp; set => idsp = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Gia { get => gia; set => gia = value; }
    }
}

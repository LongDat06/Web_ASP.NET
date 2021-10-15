using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DERSIX.Models
{
    public class Hoadon
    {
        private int idhoadon;
        private string name;
        private string email;
        private int phone;
        private string diachi;
        private int tongtien;

        public Hoadon() { }
        public Hoadon(int idhoadon, string name, string email, int phone, string diachi, int tongtien)
        {
            this.Idhoadon = idhoadon;
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
            this.Diachi = diachi;
            this.Tongtien = tongtien;
        }

        public int Idhoadon { get => idhoadon; set => idhoadon = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public int Phone { get => phone; set => phone = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }

        public static implicit operator Hoadon(List<Hoadon> v)
        {
            throw new NotImplementedException();
        }
    }
}

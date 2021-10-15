using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DERSIX.Models
{
    public class StoreContext
    {
        private readonly IConfiguration configuration;

        public string ConnectionString { get; set; }//biết thành viên 

        public StoreContext(string connectionString) //phuong thuc khoi tao
        {
            this.ConnectionString = connectionString;
        }
        private MySqlConnection GetConnection() //lấy connection 
        {
            return new MySqlConnection(ConnectionString);
        }
        public List<Product> GetProduct()
        {
            List<Product> list = new List<Product>();
            using (MySqlConnection conn = GetConnection())
            {
               
                conn.Open();
                string query = "select * from sanpham";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Product()
                        {
                            Id = reader["id"].ToString(),
                            Name_products = reader["Nameproducts"].ToString(),
                            Price = Convert.ToInt32(reader["price"]),
                            Img = reader["img"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        

        public int GetKhachhang(string Username, string Password)
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "select * from dangky where UserName = '"+ Username + "' and Pass = '" + Password + "'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        count++;
                       
                    }
                }
            }
            return count;
        }
        public int Checkkhachhang(string Username1, string Email1)
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "select * from dangky where UserName = '" + Username1 + "'  or Email = '" + Email1 + "'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        count++;

                    }
                }
            }
            return count;
        }
        public int Insert_khachhang(khachhang k)
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "insert into dangky(UserName,Email,Pass) values (@UserName, @Email,@Pass) ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserName", k.Username.ToString());
                cmd.Parameters.AddWithValue("@Email", k.Email.ToString());
                cmd.Parameters.AddWithValue("@Pass", k.Pass.ToString());
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }
        public Product Product_id(string id)
        {
            Product cart_item = new Product();
            
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "select * from sanpham where id = '"+id+"'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) {
                        cart_item.Id = id;
                        cart_item.Name_products = reader["Nameproducts"].ToString();
                        cart_item.Price = Convert.ToInt32(reader["price"]);
                        cart_item.Img = reader["img"].ToString();
                    }
                }
               
                
            }
            return cart_item;
        }
        public int Insert_hoadon(Hoadon h)
        {
            int count = 0;
         
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "insert into hoadon(Name,Email,Phone,diachi,Tongtien) values (@Name, @Email,@Phone,@diachi,@Tongtien) ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", h.Name.ToString());
                cmd.Parameters.AddWithValue("@Email", h.Email.ToString());
                cmd.Parameters.AddWithValue("@Phone", Convert.ToInt32(h.Phone));
                cmd.Parameters.AddWithValue("@diachi", h.Diachi.ToString());
                cmd.Parameters.AddWithValue("@Tongtien", Convert.ToInt32(h.Tongtien));
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }
        public int Insert(List<Cart> k,Hoadon h)
        {
            int Numrd;
            Random rd = new Random();
            Numrd = rd.Next(1, 999);
            var sumall = 0;
            var sum = 0;
            
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "insert into hoadon(idhoadon,Name,Email,Phone,diachi,Tongtien) values (@Idhoadon,@Name, @Email,@Phone,@diachi,@Tongtien) ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idhoadon", Convert.ToInt32(Numrd));
                cmd.Parameters.AddWithValue("@Name", h.Name.ToString());
                cmd.Parameters.AddWithValue("@Email", h.Email.ToString());
                cmd.Parameters.AddWithValue("@Phone", Convert.ToInt32(h.Phone));
                cmd.Parameters.AddWithValue("@diachi", h.Diachi.ToString());
                cmd.Parameters.AddWithValue("@Tongtien", Convert.ToInt32(h.Tongtien));
                sumall = Convert.ToInt32(h.Tongtien);
                cmd.ExecuteNonQuery();
                string query1 = "insert into chitiethoadon(mahoadon,idsp,soluong,gia) values (@Mahoadon, @Idsp,@Soluong,@Gia) ";
                foreach (var item in k)
                {
                    
                    MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                    cmd1.Parameters.AddWithValue("@Mahoadon", Convert.ToInt32(Numrd));
                    cmd1.Parameters.AddWithValue("@Idsp", item.Product.Id.ToString());
                    cmd1.Parameters.AddWithValue("@Soluong", Convert.ToInt32(item.Quantity));
                    cmd1.Parameters.AddWithValue("@Gia", Convert.ToInt32(item.Product.Price));
                    sum += Convert.ToInt32(item.Product.Price);
                    cmd1.ExecuteNonQuery();
                }
                

            }
            if(sum == sumall)
            {
                return 1;
            }
            
            return 0;
        }
        public List<Hoadon> CheckDonhang(string Email)
        {

            List<Hoadon> list1 = new List<Hoadon>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
               
                string query = "select * from hoadon where  Email = '" + Email + "'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list1.Add(new Hoadon()

                        {
                            Idhoadon = Convert.ToInt32(reader["idhoadon"]),
                            Name = reader["Name"].ToString(),
                            Phone = Convert.ToInt32(reader["Phone"]),
                            Diachi = reader["diachi"].ToString(),
                            Tongtien = Convert.ToInt32(reader["Tongtien"]),
                        });
                    }
                }

            }
            return list1;
        }
        public List<Chitiethoadon> chitiethoadon(int id)
        {

            List<Chitiethoadon> list1 = new List<Chitiethoadon>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                string query = "select * from chitiethoadon where  mahoadon = '" + id + "'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list1.Add(new Chitiethoadon()

                        {
                            Idchitiethoa = Convert.ToInt32(reader["idchitiethoa"]),
                            Idsp = reader["idsp"].ToString(),
                            Soluong = Convert.ToInt32(reader["soluong"]),
                            Gia = Convert.ToInt32(reader["gia"]),
                        });
                    }
                }

            }
            return list1;
        }
        public List<Product> detail_product(string id)
        {
            List<Product> list = new List<Product>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "select * from sanpham where id = '" + id + "' ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Product()
                        {
                            Id = reader["id"].ToString(),
                            Name_products = reader["Nameproducts"].ToString(),
                            Price = Convert.ToInt32(reader["price"]),
                            Img = reader["img"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public List<Hoadon> Gethoadon()
        {

            List<Hoadon> list1 = new List<Hoadon>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                string query = "select * from hoadon ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list1.Add(new Hoadon()

                        {
                            Idhoadon = Convert.ToInt32(reader["idhoadon"]),
                            Name = reader["Name"].ToString(),
                            Email = reader["Email"].ToString(),
                            Phone = Convert.ToInt32(reader["Phone"]),
                            Diachi = reader["diachi"].ToString(),
                            Tongtien = Convert.ToInt32(reader["Tongtien"]),
                        });
                    }
                }

            }
            return list1;
        }
        public int xoa_hoadon(int id)
        {
            int count = 0;

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "delete from chitiethoadon where mahoadon = '"+ id +"' ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                string query1 = "delete from hoadon where idhoadon = '" + id + "' ";
                MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                cmd1.ExecuteNonQuery();
                count++;
            }
            return count;
            
        }
        public int xoa_cthoadon(int id)
        {
            int count = 0;
            var tongtien = 0;
            var Tongtien = 0;
            var idhoadon = 0;
            
            
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "select soluong,gia,mahoadon from chitiethoadon where idchitiethoa = '" + id + "' ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    var Soluong = Convert.ToInt32(reader["soluong"]);
                    var Gia = Convert.ToInt32(reader["gia"]);
                    idhoadon = Convert.ToInt32(reader["mahoadon"]);
                    tongtien = Soluong * Gia;
                        
                }

                string query2 = "select Tongtien from hoadon where idhoadon = '" + idhoadon + "' ";
                MySqlCommand cmd2 = new MySqlCommand(query2, conn);
                cmd2.ExecuteNonQuery();
                using (var reader = cmd2.ExecuteReader())
                {
                    reader.Read();
                    Tongtien = Convert.ToInt32(reader["Tongtien"]);
                    
                }
                var sum = Tongtien - tongtien;
                var a = 0;
                string query1 = "delete from chitiethoadon where idchitiethoa = '" + id + "' ";
                MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                cmd1.ExecuteNonQuery();

                

                string query3 = "update hoadon set Tongtien ='"+ sum +"' where idhoadon = '"+ idhoadon +"' ";
                MySqlCommand cmd3 = new MySqlCommand(query3, conn);
                cmd3.ExecuteNonQuery();
                count++;
            }
            return count;
        }
        public List<Hoadon> Sreach(string sreach)
        {
            using (MySqlConnection conn = GetConnection())
            {
                List<Hoadon> list1 = new List<Hoadon>();
                conn.Open();
                string query = "select * from hoadon where idhoadon LIKE '%" + sreach + "%'  or Name LIKE '%" + sreach + "%' or Email LIKE '%" + sreach + "%' or Phone LIKE '%" + sreach + "%'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list1.Add(new Hoadon()

                        {
                            Idhoadon = Convert.ToInt32(reader["idhoadon"]),
                            Name = reader["Name"].ToString(),
                            Email = reader["Email"].ToString(),
                            Phone = Convert.ToInt32(reader["Phone"]),
                            Diachi = reader["diachi"].ToString(),
                            Tongtien = Convert.ToInt32(reader["Tongtien"]),
                        });
                    }
                }
                return list1;
            }
        }
        public List<Product> Sreach1(string sreach)
        {
            using (MySqlConnection conn = GetConnection())
            {
                List<Product> list1 = new List<Product>();
                conn.Open();
                string query = "select * from sanpham where id LIKE '%" + sreach + "%'  or Nameproducts LIKE '%" + sreach + "%' or price LIKE '%" + sreach + "%'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list1.Add(new Product()

                        {
                            Id = reader["id"].ToString(),
                            Name_products = reader["Nameproducts"].ToString(),
                            Price = Convert.ToInt32(reader["price"]),
                            Img = reader["img"].ToString(),

                        });
                    }
                }
                return list1;
            }
        }
        public List<Product> lipsick_product(string abc)
        {
            using (MySqlConnection conn = GetConnection())
            {
                List<Product> list = new List<Product>();
                conn.Open();
                string query = "select * from sanpham where id LIKE '%" + abc + "%'  ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Product()
                        {
                            Id = reader["id"].ToString(),
                            Name_products = reader["Nameproducts"].ToString(),
                            Price = Convert.ToInt32(reader["price"]),
                            Img = reader["img"].ToString()
                        });
                    }
                }
                return list;
            }
        }
        public int xoa_sanpham(int id)
        {
            int count = 0;

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "delete from sanpham where id = '" + id + "' ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;

        }
        public int Them_sanpham(Product h)
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "insert into sanpham(id,Nameproducts,price,img) values (@id,@Nameproducts,@price,@img) ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", h.Id.ToString());
                cmd.Parameters.AddWithValue("@Nameproducts", h.Name_products.ToString());
                cmd.Parameters.AddWithValue("@price", Convert.ToInt32(h.Price));
                cmd.Parameters.AddWithValue("@img", h.Img.ToString());
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }
        public List<Product> sreachProduct(string sreach)
        {
            using (MySqlConnection conn = GetConnection())
            {
                List<Product> list1 = new List<Product>();
                conn.Open();
                string query = "select * from sanpham where id LIKE '%" + sreach + "%'  or Nameproducts LIKE '%" + sreach + "%' or price LIKE '%" + sreach + "%'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list1.Add(new Product()

                        {
                            Id = reader["id"].ToString(),
                            Name_products = reader["Nameproducts"].ToString(),
                            Price = Convert.ToInt32(reader["price"]),
                            Img = reader["img"].ToString(),

                        });
                    }
                }
                return list1;
            }
        }

    }
}

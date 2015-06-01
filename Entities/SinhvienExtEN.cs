using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesExt
{
   public class SinhvienExtEN
    {

        public int Id { get; set; }
        public string Hoten { get; set; }
        public string Diachi { get; set; }
        public int Tuoi { get; set; }
        public void setValue(SinhvienExtEN aSinhvien)
        {
            this.Id = aSinhvien.Id;
            this.Hoten = aSinhvien.Hoten;
            this.Diachi = aSinhvien.Diachi;
            this.Tuoi = aSinhvien.Tuoi;
        }
        public SinhvienExtEN ConvertToContent()
        {
            SinhvienExtEN aSinhvien = new SinhvienExtEN();
            aSinhvien.Id = this.Id;
            aSinhvien.Hoten = this.Hoten;
            aSinhvien.Diachi = this.Diachi;
            aSinhvien.Tuoi = this.Tuoi;
            return aSinhvien;
        } 
    }
}


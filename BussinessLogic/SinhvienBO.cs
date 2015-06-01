using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Core.Objects;
using System.Configuration;
using System.Linq;
using EntitiesExt;
using DataAccess;

namespace Bussiness
{
   
    public class SinhvienBO
    {
        DatabaseDA aDatabaseDA = new DatabaseDA();
        #region view
        public List<Sinhvien> Sel_ByAll()
        {

            return aDatabaseDA.Sinhvien.ToList();

        }
        #endregion
        #region  [them sua xoa]
        public int  Ins(Sinhvien aSinhvien)
        {
            try 
	            {	   
                aDatabaseDA.Sinhvien.Add(aSinhvien);
                 return aDatabaseDA.SaveChanges();
		
	            }
	            catch (Exception ex)
	            {
		
		            throw new  Exception(string.Format("SinhvienBo.Ins{0}",ex.Message));
	            }
          }
        public int Upd(Sinhvien aSinhvien)
        {
            try
            {
                aDatabaseDA.Sinhvien.AddOrUpdate(aSinhvien);
                return aDatabaseDA.SaveChanges();

            }
            catch (Exception ex)
            {

                throw new Exception(string.Format("SinhvienBo.Up{0}", ex.Message));
            }
        }
         public int Dele(Sinhvien aSinhvien)
        {
            try
            {
                aDatabaseDA.Sinhvien.Remove(aSinhvien);
                return aDatabaseDA.SaveChanges();

            }
            catch (Exception ex)
            {

                throw new Exception(string.Format("SinhvienBo.Dele{0}", ex.Message));
            }
        }
        #endregion
    }
}

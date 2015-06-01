using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Core.Objects;
using System.Configuration;
using System.Linq;
using DataAccess;
using EntitiesExt;

namespace BussinessLogic
{
    public  class PermitsBO
    {

        DatabaseDA aDatabaseDA = new DatabaseDA();


        public List<vw_PermitsViewAll> GetAllInfoLogin_Ext_ByUsername(string Username)
        {
            try
            {
                return aDatabaseDA.vw_PermitsViewAll.Where(a => a.SystemUsers_Username == Username).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SystemUsersDA_GetPermitViewAll_ByUsername: {0}", ex.Message));
            }
        }

        public List<vw_PermitsViewAll> GetAllInfoLogin_ByUsername(string UserName)
        {
            try
            {
                return aDatabaseDA.vw_PermitsViewAll.Where(p => p.SystemUsers_Username == UserName).Where(p => p.SystemUsers_Disable == false).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SystemUsersDA_GetAllInfoLogin_ByUsername: {0}", ex.Message));
            }
        }

		public List<Permits> Sel()
        {
            try
            {
                return aDatabaseDA.Permits.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitsBO.Sel:{0}", ex.Message));
            }
        }
		public List<Permits> Sel(bool Disable)
        {
            try
            {
                return aDatabaseDA.Permits.Where(z => z.Disable == Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitsBO.Sel:{0}", ex.Message));
            }
        }
        public List<Permits> Sel_ByType(int Type)
        {
            try
            {
                return aDatabaseDA.Permits.Where(p => p.Type == Type).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitsBO.Sel_ByType:{0}", ex.Message));
            }
        }
        public List<Permits> Sel_ByType(int Type, bool Disable)
        {
            try
            {
                return aDatabaseDA.Permits.Where(p => p.Type == Type).Where(z => z.Disable == Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitsBO.Sel_ByType:{0}", ex.Message));
            }
        }

        
     
        public List<Permits> Sel_ByStatus(int Status)
        {
            try
            {
                return aDatabaseDA.Permits.Where(p => p.Status == Status).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitsBO.Sel_ByStatus:{0}", ex.Message));
            }
        }
        public List<Permits> Sel_ByStatus(int Status, bool Disable)
        {
            try
            {
                return aDatabaseDA.Permits.Where(p => p.Status == Status).Where(z => z.Disable == Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitsBO.Sel_ByStatus:{0}", ex.Message));
            }
        }

        public List<Permits> Sel_ByType_ByStatus(int Type, int Status)
        {
            try
            {
                return aDatabaseDA.Permits.Where(c => c.Type == Type).Where(p => p.Status == Status).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitsBO.Sel_ByType_ByStatus:{0}", ex.Message));
            }
        }
        public List<Permits> Sel_ByType_ByStatus_ByDisable(int Type, int Status, bool Disable)
        {
            try
            {
                return aDatabaseDA.Permits.Where(c => c.Type == Type).Where(p => p.Status == Status).Where(z => z.Disable == Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitsBO.Sel_ByType_ByStatus:{0}", ex.Message));
            }
        }

      
        
        public int Del()
        {
            try
            {
                List<Permits> aTemp = aDatabaseDA.Permits.ToList();
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.Permits.RemoveRange(aTemp);
                    return aDatabaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitsBO.Del: {0}", ex.Message));
            }
        }
		
       
        public int Upd_Status_ByID(int ID, int NewStatus) 
        {
            try
            {
                List<Permits> aListPermits = aDatabaseDA.Permits.Where(b => b.ID == ID).ToList();
                if (aListPermits.Count > 0) 
                {
                   
                        aListPermits[0].Status = NewStatus;
                        aDatabaseDA.Permits.AddOrUpdate(aListPermits[0]);
                        return aDatabaseDA.SaveChanges();
                    
                }
                return 0;
            }
            catch (Exception ex) 
            {
                throw new Exception(String.Format("Upd_Status_ByID:{0}", ex.Message));
            }
        }
        
        public int Upd_Type_ByID(int ID, int NewType) 
        {
            try
            {
                List<Permits> aListPermits = aDatabaseDA.Permits.Where(b => b.ID == ID).ToList();
                if (aListPermits.Count > 0) 
                {
                   
                        aListPermits[0].Type = NewType;
                        aDatabaseDA.Permits.AddOrUpdate(aListPermits[0]);
                        return aDatabaseDA.SaveChanges();
                    
                }
                return 0;
               
            }
            catch (Exception ex) 
            {
                throw new Exception(String.Format("Upd_Type_ByID:{0}", ex.Message));
            }
        }

        
        public int Upd_Disable_ByID(int ID,bool NewDisable) 
        {
            try
            {
                List<Permits> aListPermits = aDatabaseDA.Permits.Where(b => b.ID == ID).ToList();
                if (aListPermits.Count > 0) 
                {
                   
                        aListPermits[0].Disable = NewDisable;
                        aDatabaseDA.Permits.AddOrUpdate(aListPermits[0]);
                        return aDatabaseDA.SaveChanges();
                    
                }
                return 0;
            }
            catch (Exception ex) 
            {
                throw new Exception(String.Format("Upd_Disable_ByID:{0}", ex.Message));
            }
        }
		
		public int Del_ByID(Int32 ID)
        {
            try
            {
                List<Permits> aTemp = aDatabaseDA.Permits.Where(p=>p.ID == ID).ToList();
           
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.Permits.Remove(aTemp[0]);
                    return aDatabaseDA.SaveChanges();
                }
                else
                {
                    throw new Exception(String.Format("PermitsBO.Del_ByID: {0}", "Không tìm thấy Permits có ID = " + ID));
                }

            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitsBO.Del: {0}", ex.Message));
            }
        }
		
        public int Del_By_ListID(List<int> aListID)
        {
            try
            {
                List<Permits> aTemp = aDatabaseDA.Permits.Where(p => aListID.Contains(int.Parse(p.ID.ToString()))).ToList();
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.Permits.RemoveRange(aTemp);
                    return aDatabaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitsBO.Del_By_ListID: {0}", ex.Message));
            }
        }

        public  Permits Sel_ByID(Int32 ID)
        {
            try
            {
                Permits aPermits = aDatabaseDA.Permits.Where(b => b.ID == ID).ToList()[0];
              
                    return aPermits;
               
                
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitsBO.Sel: {0}", ex.Message));
            }
        }
        


        //#######################################################
        //NgocBM

        public int Ins(Permits aPermits)
        {
            try
            {
                aDatabaseDA.Permits.AddOrUpdate(aPermits);
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitsBO.Ins: {0}", ex.Message));
            }
        }
        public int Ins(ref List<Permits> aListPermits)
        {
            try
            {
                aListPermits = aDatabaseDA.Permits.AddRange(aListPermits).ToList();
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitsBO.Ins: {0}", ex.Message));
            }
        }
        public int Upd(List<Permits> aListPermits)
        {
            try
            {
                aDatabaseDA.Permits.AddOrUpdate(aListPermits.ToArray());
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitsBO.Ins: {0}", ex.Message));
            }
        }
        public int Upd(Permits aPermits)
        {
            try
            {
                aDatabaseDA.Permits.AddOrUpdate(aPermits);
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitsBO.Upd: {0}", ex.Message));
            }
        }

        public int Del(List<Permits> aListPermits)
        {
            try
            {
                aDatabaseDA.Permits.RemoveRange(aListPermits);
                return aDatabaseDA.SaveChanges();
                

            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitsBO.Del: {0}", ex.Message));
            }
        }

     
        //NgocBM

    }
}


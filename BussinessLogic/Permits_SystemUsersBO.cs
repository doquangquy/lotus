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
    public  class Permits_SystemUsersBO
    {

        DatabaseDA aDatabaseDA = new DatabaseDA();
        

		public List<Permits_SystemUsers> Sel()
        {
            try
            {
                return aDatabaseDA.Permits_SystemUsers.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Permits_SystemUsersBO.Sel:{0}", ex.Message));
            }
        }
		public List<Permits_SystemUsers> Sel(bool Disable)
        {
            try
            {
                return aDatabaseDA.Permits_SystemUsers.Where(z => z.Disable == Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Permits_SystemUsersBO.Sel:{0}", ex.Message));
            }
        }
        public List<Permits_SystemUsers> Sel_ByType(int Type)
        {
            try
            {
                return aDatabaseDA.Permits_SystemUsers.Where(p => p.Type == Type).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Permits_SystemUsersBO.Sel_ByType:{0}", ex.Message));
            }
        }
        public List<Permits_SystemUsers> Sel_ByType(int Type, bool Disable)
        {
            try
            {
                return aDatabaseDA.Permits_SystemUsers.Where(p => p.Type == Type).Where(z => z.Disable == Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Permits_SystemUsersBO.Sel_ByType:{0}", ex.Message));
            }
        }

        
     
        public List<Permits_SystemUsers> Sel_ByStatus(int Status)
        {
            try
            {
                return aDatabaseDA.Permits_SystemUsers.Where(p => p.Status == Status).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Permits_SystemUsersBO.Sel_ByStatus:{0}", ex.Message));
            }
        }
        public List<Permits_SystemUsers> Sel_ByStatus(int Status, bool Disable)
        {
            try
            {
                return aDatabaseDA.Permits_SystemUsers.Where(p => p.Status == Status).Where(z => z.Disable == Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Permits_SystemUsersBO.Sel_ByStatus:{0}", ex.Message));
            }
        }

        public List<Permits_SystemUsers> Sel_ByType_ByStatus(int Type, int Status)
        {
            try
            {
                return aDatabaseDA.Permits_SystemUsers.Where(c => c.Type == Type).Where(p => p.Status == Status).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Permits_SystemUsersBO.Sel_ByType_ByStatus:{0}", ex.Message));
            }
        }
        public List<Permits_SystemUsers> Sel_ByType_ByStatus_ByDisable(int Type, int Status, bool Disable)
        {
            try
            {
                return aDatabaseDA.Permits_SystemUsers.Where(c => c.Type == Type).Where(p => p.Status == Status).Where(z => z.Disable == Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Permits_SystemUsersBO.Sel_ByType_ByStatus:{0}", ex.Message));
            }
        }

      
        
        public int Del()
        {
            try
            {
                List<Permits_SystemUsers> aTemp = aDatabaseDA.Permits_SystemUsers.ToList();
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.Permits_SystemUsers.RemoveRange(aTemp);
                    return aDatabaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Permits_SystemUsersBO.Del: {0}", ex.Message));
            }
        }
		
       
        public int Upd_Status_ByID(int ID, int NewStatus) 
        {
            try
            {
                List<Permits_SystemUsers> aListPermits_SystemUsers = aDatabaseDA.Permits_SystemUsers.Where(b => b.ID == ID).ToList();
                if (aListPermits_SystemUsers.Count > 0) 
                {
                   
                        aListPermits_SystemUsers[0].Status = NewStatus;
                        aDatabaseDA.Permits_SystemUsers.AddOrUpdate(aListPermits_SystemUsers[0]);
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
                List<Permits_SystemUsers> aListPermits_SystemUsers = aDatabaseDA.Permits_SystemUsers.Where(b => b.ID == ID).ToList();
                if (aListPermits_SystemUsers.Count > 0) 
                {
                   
                        aListPermits_SystemUsers[0].Type = NewType;
                        aDatabaseDA.Permits_SystemUsers.AddOrUpdate(aListPermits_SystemUsers[0]);
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
                List<Permits_SystemUsers> aListPermits_SystemUsers = aDatabaseDA.Permits_SystemUsers.Where(b => b.ID == ID).ToList();
                if (aListPermits_SystemUsers.Count > 0) 
                {
                   
                        aListPermits_SystemUsers[0].Disable = NewDisable;
                        aDatabaseDA.Permits_SystemUsers.AddOrUpdate(aListPermits_SystemUsers[0]);
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
                List<Permits_SystemUsers> aTemp = aDatabaseDA.Permits_SystemUsers.Where(p=>p.ID == ID).ToList();
           
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.Permits_SystemUsers.Remove(aTemp[0]);
                    return aDatabaseDA.SaveChanges();
                }
                else
                {
                    throw new Exception(String.Format("Permits_SystemUsersBO.Del_ByID: {0}", "Không tìm thấy Permits_SystemUsers có ID = " + ID));
                }

            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Permits_SystemUsersBO.Del: {0}", ex.Message));
            }
        }
		
        public int Del_By_ListID(List<int> aListID)
        {
            try
            {
                List<Permits_SystemUsers> aTemp = aDatabaseDA.Permits_SystemUsers.Where(p => aListID.Contains(int.Parse(p.ID.ToString()))).ToList();
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.Permits_SystemUsers.RemoveRange(aTemp);
                    return aDatabaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Permits_SystemUsersBO.Del_By_ListID: {0}", ex.Message));
            }
        }

        public  Permits_SystemUsers Sel_ByID(Int32 ID)
        {
            try
            {
                Permits_SystemUsers aPermits_SystemUsers = aDatabaseDA.Permits_SystemUsers.Where(b => b.ID == ID).ToList()[0];
              
                    return aPermits_SystemUsers;
               
                
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Permits_SystemUsersBO.Sel: {0}", ex.Message));
            }
        }
        
        public int Upd_Status_ByID(int ID, int NewStatus) 
        {
            try
            {
                List<Permits_SystemUsers> aListPermits_SystemUsers = aDatabaseDA.Permits_SystemUsers.Where(b => b.ID == ID).ToList();
                if (aListPermits_SystemUsers.Count > 0) 
                {
                   
                        aListPermits_SystemUsers[0].Status = NewStatus;
                        aDatabaseDA.Permits_SystemUsers.AddOrUpdate(aListPermits_SystemUsers[0]);
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
                List<Permits_SystemUsers> aListPermits_SystemUsers = aDatabaseDA.Permits_SystemUsers.Where(b => b.ID == ID).ToList();
                if (aListPermits_SystemUsers.Count > 0) 
                {
                   
                        aListPermits_SystemUsers[0].Type = NewType;
                        aDatabaseDA.Permits_SystemUsers.AddOrUpdate(aListPermits_SystemUsers[0]);
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
                List<Permits_SystemUsers> aListPermits_SystemUsers = aDatabaseDA.Permits_SystemUsers.Where(b => b.ID == ID).ToList();
                if (aListPermits_SystemUsers.Count > 0) 
                {
                   
                        aListPermits_SystemUsers[0].Disable = NewDisable;
                        aDatabaseDA.Permits_SystemUsers.AddOrUpdate(aListPermits_SystemUsers[0]);
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
                List<Permits_SystemUsers> aTemp = aDatabaseDA.Permits_SystemUsers.Where(p=>p.ID == ID).ToList();
           
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.Permits_SystemUsers.Remove(aTemp[0]);
                    return aDatabaseDA.SaveChanges();
                }
                else
                {
                    throw new Exception(String.Format("Permits_SystemUsersBO.Del_ByID: {0}", "Không tìm thấy Permits_SystemUsers có ID = " + ID));
                }

            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Permits_SystemUsersBO.Del: {0}", ex.Message));
            }
        }
		
        public int Del_By_ListID(List<int> aListID)
        {
            try
            {
                List<Permits_SystemUsers> aTemp = aDatabaseDA.Permits_SystemUsers.Where(p => aListID.Contains(int.Parse(p.ID.ToString()))).ToList();
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.Permits_SystemUsers.RemoveRange(aTemp);
                    return aDatabaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Permits_SystemUsersBO.Del_By_ListID: {0}", ex.Message));
            }
        }

        public  Permits_SystemUsers Sel_ByID(Int32 ID)
        {
            try
            {
                Permits_SystemUsers aPermits_SystemUsers = aDatabaseDA.Permits_SystemUsers.Where(b => b.ID == ID).ToList()[0];
              
                    return aPermits_SystemUsers;
               
                
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Permits_SystemUsersBO.Sel: {0}", ex.Message));
            }
        }
        


        //#######################################################
        //NgocBM

        public int Ins(Permits_SystemUsers aPermits_SystemUsers)
        {
            try
            {
                aDatabaseDA.Permits_SystemUsers.AddOrUpdate(aPermits_SystemUsers);
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Permits_SystemUsersBO.Ins: {0}", ex.Message));
            }
        }
        public int Ins(ref List<Permits_SystemUsers> aListPermits_SystemUsers)
        {
            try
            {
                aListPermits_SystemUsers = aDatabaseDA.Permits_SystemUsers.AddRange(aListPermits_SystemUsers).ToList();
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Permits_SystemUsersBO.Ins: {0}", ex.Message));
            }
        }
        public int Upd(List<Permits_SystemUsers> aListPermits_SystemUsers)
        {
            try
            {
                aDatabaseDA.Permits_SystemUsers.AddOrUpdate(aListPermits_SystemUsers.ToArray());
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Permits_SystemUsersBO.Ins: {0}", ex.Message));
            }
        }
        public int Upd(Permits_SystemUsers aPermits_SystemUsers)
        {
            try
            {
                aDatabaseDA.Permits_SystemUsers.AddOrUpdate(aPermits_SystemUsers);
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Permits_SystemUsersBO.Upd: {0}", ex.Message));
            }
        }

        public int Del(List<Permits_SystemUsers> aListPermits_SystemUsers)
        {
            try
            {
                aDatabaseDA.Permits_SystemUsers.RemoveRange(aListPermits_SystemUsers);
                return aDatabaseDA.SaveChanges();
                

            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Permits_SystemUsersBO.Del: {0}", ex.Message));
            }
        }

     
        //NgocBM

    }
}


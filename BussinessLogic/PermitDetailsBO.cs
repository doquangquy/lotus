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
    public  class PermitDetailsBO
    {

        DatabaseDA aDatabaseDA = new DatabaseDA();
        

		public List<PermitDetails> Sel()
        {
            try
            {
                return aDatabaseDA.PermitDetails.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitDetailsBO.Sel:{0}", ex.Message));
            }
        }
		public List<PermitDetails> Sel(bool Disable)
        {
            try
            {
                return aDatabaseDA.PermitDetails.Where(z => z.Disable == Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitDetailsBO.Sel:{0}", ex.Message));
            }
        }
        public List<PermitDetails> Sel_ByType(int Type)
        {
            try
            {
                return aDatabaseDA.PermitDetails.Where(p => p.Type == Type).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitDetailsBO.Sel_ByType:{0}", ex.Message));
            }
        }
        public List<PermitDetails> Sel_ByType(int Type, bool Disable)
        {
            try
            {
                return aDatabaseDA.PermitDetails.Where(p => p.Type == Type).Where(z => z.Disable == Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitDetailsBO.Sel_ByType:{0}", ex.Message));
            }
        }

        
     
        public List<PermitDetails> Sel_ByStatus(int Status)
        {
            try
            {
                return aDatabaseDA.PermitDetails.Where(p => p.Status == Status).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitDetailsBO.Sel_ByStatus:{0}", ex.Message));
            }
        }
        public List<PermitDetails> Sel_ByStatus(int Status, bool Disable)
        {
            try
            {
                return aDatabaseDA.PermitDetails.Where(p => p.Status == Status).Where(z => z.Disable == Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitDetailsBO.Sel_ByStatus:{0}", ex.Message));
            }
        }

        public List<PermitDetails> Sel_ByType_ByStatus(int Type, int Status)
        {
            try
            {
                return aDatabaseDA.PermitDetails.Where(c => c.Type == Type).Where(p => p.Status == Status).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitDetailsBO.Sel_ByType_ByStatus:{0}", ex.Message));
            }
        }
        public List<PermitDetails> Sel_ByType_ByStatus_ByDisable(int Type, int Status, bool Disable)
        {
            try
            {
                return aDatabaseDA.PermitDetails.Where(c => c.Type == Type).Where(p => p.Status == Status).Where(z => z.Disable == Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitDetailsBO.Sel_ByType_ByStatus:{0}", ex.Message));
            }
        }

      
        
        public int Del()
        {
            try
            {
                List<PermitDetails> aTemp = aDatabaseDA.PermitDetails.ToList();
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.PermitDetails.RemoveRange(aTemp);
                    return aDatabaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitDetailsBO.Del: {0}", ex.Message));
            }
        }
		
       
        public int Upd_Status_ByID(int ID, int NewStatus) 
        {
            try
            {
                List<PermitDetails> aListPermitDetails = aDatabaseDA.PermitDetails.Where(b => b.ID == ID).ToList();
                if (aListPermitDetails.Count > 0) 
                {
                   
                        aListPermitDetails[0].Status = NewStatus;
                        aDatabaseDA.PermitDetails.AddOrUpdate(aListPermitDetails[0]);
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
                List<PermitDetails> aListPermitDetails = aDatabaseDA.PermitDetails.Where(b => b.ID == ID).ToList();
                if (aListPermitDetails.Count > 0) 
                {
                   
                        aListPermitDetails[0].Type = NewType;
                        aDatabaseDA.PermitDetails.AddOrUpdate(aListPermitDetails[0]);
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
                List<PermitDetails> aListPermitDetails = aDatabaseDA.PermitDetails.Where(b => b.ID == ID).ToList();
                if (aListPermitDetails.Count > 0) 
                {
                   
                        aListPermitDetails[0].Disable = NewDisable;
                        aDatabaseDA.PermitDetails.AddOrUpdate(aListPermitDetails[0]);
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
                List<PermitDetails> aTemp = aDatabaseDA.PermitDetails.Where(p=>p.ID == ID).ToList();
           
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.PermitDetails.Remove(aTemp[0]);
                    return aDatabaseDA.SaveChanges();
                }
                else
                {
                    throw new Exception(String.Format("PermitDetailsBO.Del_ByID: {0}", "Không tìm thấy PermitDetails có ID = " + ID));
                }

            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitDetailsBO.Del: {0}", ex.Message));
            }
        }
		
        public int Del_By_ListID(List<int> aListID)
        {
            try
            {
                List<PermitDetails> aTemp = aDatabaseDA.PermitDetails.Where(p => aListID.Contains(int.Parse(p.ID.ToString()))).ToList();
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.PermitDetails.RemoveRange(aTemp);
                    return aDatabaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitDetailsBO.Del_By_ListID: {0}", ex.Message));
            }
        }

        public  PermitDetails Sel_ByID(Int32 ID)
        {
            try
            {
                PermitDetails aPermitDetails = aDatabaseDA.PermitDetails.Where(b => b.ID == ID).ToList()[0];
              
                    return aPermitDetails;
               
                
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitDetailsBO.Sel: {0}", ex.Message));
            }
        }
        


        //#######################################################
        //NgocBM

        public int Ins(PermitDetails aPermitDetails)
        {
            try
            {
                aDatabaseDA.PermitDetails.AddOrUpdate(aPermitDetails);
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitDetailsBO.Ins: {0}", ex.Message));
            }
        }
        public int Ins(ref List<PermitDetails> aListPermitDetails)
        {
            try
            {
                aListPermitDetails = aDatabaseDA.PermitDetails.AddRange(aListPermitDetails).ToList();
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitDetailsBO.Ins: {0}", ex.Message));
            }
        }
        public int Upd(List<PermitDetails> aListPermitDetails)
        {
            try
            {
                aDatabaseDA.PermitDetails.AddOrUpdate(aListPermitDetails.ToArray());
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitDetailsBO.Ins: {0}", ex.Message));
            }
        }
        public int Upd(PermitDetails aPermitDetails)
        {
            try
            {
                aDatabaseDA.PermitDetails.AddOrUpdate(aPermitDetails);
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitDetailsBO.Upd: {0}", ex.Message));
            }
        }

        public int Del(List<PermitDetails> aListPermitDetails)
        {
            try
            {
                aDatabaseDA.PermitDetails.RemoveRange(aListPermitDetails);
                return aDatabaseDA.SaveChanges();
                

            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("PermitDetailsBO.Del: {0}", ex.Message));
            }
        }

     
        //NgocBM

    }
}


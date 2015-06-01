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
    public  class ConfigsBO
    {

        DatabaseDA aDatabaseDA = new DatabaseDA();

        public Configs Sel_ByAccessKey(string Key)
        {
            try
            {
                List<Configs> aListConfigs = aDatabaseDA.Configs.Where(c => c.AccessKey == Key).ToList();
                if (aListConfigs.Count > 0)
                {
                    return aListConfigs[0];
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ConfigsDA_GetByKey: {0}", ex.Message));
            }
        }
		public List<Configs> Sel()
        {
            try
            {
                return aDatabaseDA.Configs.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ConfigsBO.Sel:{0}", ex.Message));
            }
        }
		public List<Configs> Sel(bool Disable)
        {
            try
            {
                return aDatabaseDA.Configs.Where(z => z.Disable == Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ConfigsBO.Sel:{0}", ex.Message));
            }
        }
        public List<Configs> Sel_ByType(int Type)
        {
            try
            {
                return aDatabaseDA.Configs.Where(p => p.Type == Type).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ConfigsBO.Sel_ByType:{0}", ex.Message));
            }
        }
        public List<Configs> Sel_ByType(int Type, bool Disable)
        {
            try
            {
                return aDatabaseDA.Configs.Where(p => p.Type == Type).Where(z => z.Disable == Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ConfigsBO.Sel_ByType:{0}", ex.Message));
            }
        }

        
     
        public List<Configs> Sel_ByStatus(int Status)
        {
            try
            {
                return aDatabaseDA.Configs.Where(p => p.Status == Status).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ConfigsBO.Sel_ByStatus:{0}", ex.Message));
            }
        }
        public List<Configs> Sel_ByStatus(int Status, bool Disable)
        {
            try
            {
                return aDatabaseDA.Configs.Where(p => p.Status == Status).Where(z => z.Disable == Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ConfigsBO.Sel_ByStatus:{0}", ex.Message));
            }
        }

        public List<Configs> Sel_ByType_ByStatus(int Type, int Status)
        {
            try
            {
                return aDatabaseDA.Configs.Where(c => c.Type == Type).Where(p => p.Status == Status).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ConfigsBO.Sel_ByType_ByStatus:{0}", ex.Message));
            }
        }
        public List<Configs> Sel_ByType_ByStatus_ByDisable(int Type, int Status, bool Disable)
        {
            try
            {
                return aDatabaseDA.Configs.Where(c => c.Type == Type).Where(p => p.Status == Status).Where(z => z.Disable == Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ConfigsBO.Sel_ByType_ByStatus:{0}", ex.Message));
            }
        }

      
        
        public int Del()
        {
            try
            {
                List<Configs> aTemp = aDatabaseDA.Configs.ToList();
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.Configs.RemoveRange(aTemp);
                    return aDatabaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ConfigsBO.Del: {0}", ex.Message));
            }
        }
		
       
        public int Upd_Status_ByID(int ID, int NewStatus) 
        {
            try
            {
                List<Configs> aListConfigs = aDatabaseDA.Configs.Where(b => b.ID == ID).ToList();
                if (aListConfigs.Count > 0) 
                {
                   
                        aListConfigs[0].Status = NewStatus;
                        aDatabaseDA.Configs.AddOrUpdate(aListConfigs[0]);
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
                List<Configs> aListConfigs = aDatabaseDA.Configs.Where(b => b.ID == ID).ToList();
                if (aListConfigs.Count > 0) 
                {
                   
                        aListConfigs[0].Type = NewType;
                        aDatabaseDA.Configs.AddOrUpdate(aListConfigs[0]);
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
                List<Configs> aListConfigs = aDatabaseDA.Configs.Where(b => b.ID == ID).ToList();
                if (aListConfigs.Count > 0) 
                {
                   
                        aListConfigs[0].Disable = NewDisable;
                        aDatabaseDA.Configs.AddOrUpdate(aListConfigs[0]);
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
                List<Configs> aTemp = aDatabaseDA.Configs.Where(p=>p.ID == ID).ToList();
           
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.Configs.Remove(aTemp[0]);
                    return aDatabaseDA.SaveChanges();
                }
                else
                {
                    throw new Exception(String.Format("ConfigsBO.Del_ByID: {0}", "Không tìm thấy Configs có ID = " + ID));
                }

            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ConfigsBO.Del: {0}", ex.Message));
            }
        }
		
        public int Del_By_ListID(List<int> aListID)
        {
            try
            {
                List<Configs> aTemp = aDatabaseDA.Configs.Where(p => aListID.Contains(int.Parse(p.ID.ToString()))).ToList();
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.Configs.RemoveRange(aTemp);
                    return aDatabaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ConfigsBO.Del_By_ListID: {0}", ex.Message));
            }
        }

        public  Configs Sel_ByID(Int32 ID)
        {
            try
            {
                Configs aConfigs = aDatabaseDA.Configs.Where(b => b.ID == ID).ToList()[0];
              
                    return aConfigs;
               
                
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ConfigsBO.Sel: {0}", ex.Message));
            }
        }
        


        //#######################################################
        //NgocBM

        public int Ins(Configs aConfigs)
        {
            try
            {
                aDatabaseDA.Configs.AddOrUpdate(aConfigs);
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ConfigsBO.Ins: {0}", ex.Message));
            }
        }
        public int Ins(ref List<Configs> aListConfigs)
        {
            try
            {
                aListConfigs = aDatabaseDA.Configs.AddRange(aListConfigs).ToList();
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ConfigsBO.Ins: {0}", ex.Message));
            }
        }
        public int Upd(List<Configs> aListConfigs)
        {
            try
            {
                aDatabaseDA.Configs.AddOrUpdate(aListConfigs.ToArray());
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ConfigsBO.Ins: {0}", ex.Message));
            }
        }
        public int Upd(Configs aConfigs)
        {
            try
            {
                aDatabaseDA.Configs.AddOrUpdate(aConfigs);
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ConfigsBO.Upd: {0}", ex.Message));
            }
        }

        public int Del(List<Configs> aListConfigs)
        {
            try
            {
                aDatabaseDA.Configs.RemoveRange(aListConfigs);
                return aDatabaseDA.SaveChanges();
                

            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ConfigsBO.Del: {0}", ex.Message));
            }
        }

     
        //NgocBM

    }
}


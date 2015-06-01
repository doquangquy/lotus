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
    public  class LanguagesBO
    {

        DatabaseDA aDatabaseDA = new DatabaseDA();
        

		public List<Languages> Sel()
        {
            try
            {
                return aDatabaseDA.Languages.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("LanguagesBO.Sel:{0}", ex.Message));
            }
        }
		public List<Languages> Sel(bool Disable)
        {
            try
            {
                return aDatabaseDA.Languages.Where(z => z.Disable == Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("LanguagesBO.Sel:{0}", ex.Message));
            }
        }
        public List<Languages> Sel_ByType(int Type)
        {
            try
            {
                return aDatabaseDA.Languages.Where(p => p.Type == Type).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("LanguagesBO.Sel_ByType:{0}", ex.Message));
            }
        }
        public List<Languages> Sel_ByType(int Type, bool Disable)
        {
            try
            {
                return aDatabaseDA.Languages.Where(p => p.Type == Type).Where(z => z.Disable == Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("LanguagesBO.Sel_ByType:{0}", ex.Message));
            }
        }

        
     
        public List<Languages> Sel_ByStatus(int Status)
        {
            try
            {
                return aDatabaseDA.Languages.Where(p => p.Status == Status).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("LanguagesBO.Sel_ByStatus:{0}", ex.Message));
            }
        }
        public List<Languages> Sel_ByStatus(int Status, bool Disable)
        {
            try
            {
                return aDatabaseDA.Languages.Where(p => p.Status == Status).Where(z => z.Disable == Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("LanguagesBO.Sel_ByStatus:{0}", ex.Message));
            }
        }

        public List<Languages> Sel_ByType_ByStatus(int Type, int Status)
        {
            try
            {
                return aDatabaseDA.Languages.Where(c => c.Type == Type).Where(p => p.Status == Status).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("LanguagesBO.Sel_ByType_ByStatus:{0}", ex.Message));
            }
        }
        public List<Languages> Sel_ByType_ByStatus_ByDisable(int Type, int Status, bool Disable)
        {
            try
            {
                return aDatabaseDA.Languages.Where(c => c.Type == Type).Where(p => p.Status == Status).Where(z => z.Disable == Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("LanguagesBO.Sel_ByType_ByStatus:{0}", ex.Message));
            }
        }

      
        
        public int Del()
        {
            try
            {
                List<Languages> aTemp = aDatabaseDA.Languages.ToList();
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.Languages.RemoveRange(aTemp);
                    return aDatabaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("LanguagesBO.Del: {0}", ex.Message));
            }
        }
		
       
        public int Upd_Status_ByID(int ID, int NewStatus) 
        {
            try
            {
                List<Languages> aListLanguages = aDatabaseDA.Languages.Where(b => b.ID == ID).ToList();
                if (aListLanguages.Count > 0) 
                {
                   
                        aListLanguages[0].Status = NewStatus;
                        aDatabaseDA.Languages.AddOrUpdate(aListLanguages[0]);
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
                List<Languages> aListLanguages = aDatabaseDA.Languages.Where(b => b.ID == ID).ToList();
                if (aListLanguages.Count > 0) 
                {
                   
                        aListLanguages[0].Type = NewType;
                        aDatabaseDA.Languages.AddOrUpdate(aListLanguages[0]);
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
                List<Languages> aListLanguages = aDatabaseDA.Languages.Where(b => b.ID == ID).ToList();
                if (aListLanguages.Count > 0) 
                {
                   
                        aListLanguages[0].Disable = NewDisable;
                        aDatabaseDA.Languages.AddOrUpdate(aListLanguages[0]);
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
                List<Languages> aTemp = aDatabaseDA.Languages.Where(p=>p.ID == ID).ToList();
           
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.Languages.Remove(aTemp[0]);
                    return aDatabaseDA.SaveChanges();
                }
                else
                {
                    throw new Exception(String.Format("LanguagesBO.Del_ByID: {0}", "Không tìm thấy Languages có ID = " + ID));
                }

            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("LanguagesBO.Del: {0}", ex.Message));
            }
        }
		
        public int Del_By_ListID(List<int> aListID)
        {
            try
            {
                List<Languages> aTemp = aDatabaseDA.Languages.Where(p => aListID.Contains(int.Parse(p.ID.ToString()))).ToList();
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.Languages.RemoveRange(aTemp);
                    return aDatabaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("LanguagesBO.Del_By_ListID: {0}", ex.Message));
            }
        }

        public  Languages Sel_ByID(Int32 ID)
        {
            try
            {
                Languages aLanguages = aDatabaseDA.Languages.Where(b => b.ID == ID).ToList()[0];
              
                    return aLanguages;
               
                
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("LanguagesBO.Sel: {0}", ex.Message));
            }
        }
        


        //#######################################################
        //NgocBM

        public int Ins(Languages aLanguages)
        {
            try
            {
                aDatabaseDA.Languages.AddOrUpdate(aLanguages);
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("LanguagesBO.Ins: {0}", ex.Message));
            }
        }
        public int Ins(ref List<Languages> aListLanguages)
        {
            try
            {
                aListLanguages = aDatabaseDA.Languages.AddRange(aListLanguages).ToList();
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("LanguagesBO.Ins: {0}", ex.Message));
            }
        }
        public int Upd(List<Languages> aListLanguages)
        {
            try
            {
                aDatabaseDA.Languages.AddOrUpdate(aListLanguages.ToArray());
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("LanguagesBO.Ins: {0}", ex.Message));
            }
        }
        public int Upd(Languages aLanguages)
        {
            try
            {
                aDatabaseDA.Languages.AddOrUpdate(aLanguages);
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("LanguagesBO.Upd: {0}", ex.Message));
            }
        }

        public int Del(List<Languages> aListLanguages)
        {
            try
            {
                aDatabaseDA.Languages.RemoveRange(aListLanguages);
                return aDatabaseDA.SaveChanges();
                

            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("LanguagesBO.Del: {0}", ex.Message));
            }
        }

     
        //NgocBM

    }
}


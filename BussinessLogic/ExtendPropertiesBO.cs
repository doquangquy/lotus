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
    public  class ExtendPropertiesBO
    {

        DatabaseDA aDatabaseDA = new DatabaseDA();
        

		public List<ExtendProperties> Sel_ByIDLang( int IDLang)
        {
            try
            {
                return aDatabaseDA.ExtendProperties.Where(z => z.IDLang == IDLang).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ExtendPropertiesBO.Sel_ByIDLang:{0}", ex.Message));
            }
        }
		public List<ExtendProperties> Sel_ByIDLang( int IDLang, bool Disable)
        {
            try
            {
                return aDatabaseDA.ExtendProperties.Where(z => z.IDLang == IDLang).Where(z => z.Disable == Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ExtendPropertiesBO.Sel_ByIDLang:{0}", ex.Message));
            }
        }
        public List<ExtendProperties> Sel_ByType_ByIDLang(int Type, int IDLang)
        {
            try
            {
                return aDatabaseDA.ExtendProperties.Where(p => p.Type == Type).Where(z => z.IDLang == IDLang).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ExtendPropertiesBO.Sel_ByType:{0}", ex.Message));
            }
        }
        public List<ExtendProperties> Sel_ByType_ByIDLang(int Type, int IDLang, bool Disable)
        {
            try
            {
                return aDatabaseDA.ExtendProperties.Where(p => p.Type == Type).Where(z => z.IDLang == IDLang).Where(z => z.Disable == Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ExtendPropertiesBO.Sel_ByType:{0}", ex.Message));
            }
        }

        
     
        public List<ExtendProperties> Sel_ByStatus_ByIDLang(int Status, int IDLang)
        {
            try
            {
                return aDatabaseDA.ExtendProperties.Where(p => p.Status == Status).Where(z => z.IDLang == IDLang).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ExtendPropertiesBO.Sel_ByStatus:{0}", ex.Message));
            }
        }
        public List<ExtendProperties> Sel_ByStatus_ByIDLang(int Status, int IDLang, bool Disable)
        {
            try
            {
                return aDatabaseDA.ExtendProperties.Where(p => p.Status == Status).Where(z => z.IDLang == IDLang).Where(z => z.Disable == Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ExtendPropertiesBO.Sel_ByStatus:{0}", ex.Message));
            }
        }

        public List<ExtendProperties> Sel_ByType_ByStatus_ByIDLang(int Type, int Status, int IDLang)
        {
            try
            {
                return aDatabaseDA.ExtendProperties.Where(c => c.Type == Type).Where(p => p.Status == Status).Where(z => z.IDLang == IDLang).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ExtendPropertiesBO.Sel_ByType_ByStatus_ByIDLang:{0}", ex.Message));
            }
        }
        public List<ExtendProperties> Sel_ByType_ByStatus_ByIDLang_ByDisable(int Type, int Status, int IDLang, bool Disable)
        {
            try
            {
                return aDatabaseDA.ExtendProperties.Where(c => c.Type == Type).Where(p => p.Status == Status).Where(z => z.IDLang == IDLang).Where(z => z.Disable == Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ExtendPropertiesBO.Sel_ByType_ByStatus_ByIDLang:{0}", ex.Message));
            }
        }

        public List<ExtendProperties> Sel_ByCode(string Code)
        {
            try
            {
                return aDatabaseDA.ExtendProperties.Where(p => p.Code == Code).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ExtendPropertiesBO.Sel_ByCode: {0}", ex.Message));
            }
        }
        public List<ExtendProperties> Sel_ByCode(string Code, bool Disable)
        {
            try
            {
                return aDatabaseDA.ExtendProperties.Where(p => p.Code == Code).Where(p => p.Disable == Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ExtendPropertiesBO.Sel_ByCode: {0}", ex.Message));
            }
        }

        
        public int Del()
        {
            try
            {
                List<ExtendProperties> aTemp = aDatabaseDA.ExtendProperties.ToList();
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.ExtendProperties.RemoveRange(aTemp);
                    return aDatabaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ExtendPropertiesBO.Del_ByCode: {0}", ex.Message));
            }
        }
		
       
        public int Upd_Status_ByID(int ID, int NewStatus) 
        {
            try
            {
                List<ExtendProperties> aListExtendProperties = aDatabaseDA.ExtendProperties.Where(b => b.ID == ID).ToList();
                if (aListExtendProperties.Count > 0) 
                {
                   
                        aListExtendProperties[0].Status = NewStatus;
                        aDatabaseDA.ExtendProperties.AddOrUpdate(aListExtendProperties[0]);
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
                List<ExtendProperties> aListExtendProperties = aDatabaseDA.ExtendProperties.Where(b => b.ID == ID).ToList();
                if (aListExtendProperties.Count > 0) 
                {
                   
                        aListExtendProperties[0].Type = NewType;
                        aDatabaseDA.ExtendProperties.AddOrUpdate(aListExtendProperties[0]);
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
                List<ExtendProperties> aListExtendProperties = aDatabaseDA.ExtendProperties.Where(b => b.ID == ID).ToList();
                if (aListExtendProperties.Count > 0) 
                {
                   
                        aListExtendProperties[0].Disable = NewDisable;
                        aDatabaseDA.ExtendProperties.AddOrUpdate(aListExtendProperties[0]);
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
                List<ExtendProperties> aTemp = aDatabaseDA.ExtendProperties.Where(p=>p.ID == ID).ToList();
           
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.ExtendProperties.Remove(aTemp[0]);
                    return aDatabaseDA.SaveChanges();
                }
                else
                {
                    throw new Exception(String.Format("ExtendPropertiesBO.Del: {0}", "Không tìm thấy ExtendProperties có ID = " + ID));
                }

            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ExtendPropertiesBO.Del: {0}", ex.Message));
            }
        }
		
        public int Del_By_ListID(List<int> aListID)
        {
            try
            {
                List<ExtendProperties> aTemp = aDatabaseDA.ExtendProperties.Where(p => aListID.Contains(int.Parse(p.ID.ToString()))).ToList();
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.ExtendProperties.RemoveRange(aTemp);
                    return aDatabaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ExtendPropertiesBO.Del_ByCode: {0}", ex.Message));
            }
        }

        public  ExtendProperties Sel_ByID(Int32 ID)
        {
            try
            {
                ExtendProperties aExtendProperties = aDatabaseDA.ExtendProperties.Where(b => b.ID == ID).ToList()[0];
              
                    return aExtendProperties;
               
                
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ExtendPropertiesBO.Sel: {0}", ex.Message));
            }
        }
        

        public int Upd_Status_ByCode(string Code, int NewStatus) 
        {
            try
            {
                List<ExtendProperties> aListExtendProperties = aDatabaseDA.ExtendProperties.Where(b => b.Code==Code).ToList();
                if (aListExtendProperties.Count > 0)
                {
                   
                        aListExtendProperties[0].Status = NewStatus;
                        aDatabaseDA.ExtendProperties.AddOrUpdate(aListExtendProperties[0]);
                        return aDatabaseDA.SaveChanges();
                   
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Upd_Status_ByCode:{0}", ex.Message));
            }
        }
        
        public int Upd_Type_ByCode(string Code, int NewType) 
        {
            try
            {
                List<ExtendProperties> aListExtendProperties = aDatabaseDA.ExtendProperties.Where(b => b.Code==Code).ToList();
                if (aListExtendProperties.Count > 0)
                {
                   
                        aListExtendProperties[0].Type = NewType;
                        aDatabaseDA.ExtendProperties.AddOrUpdate(aListExtendProperties[0]);
                        return aDatabaseDA.SaveChanges();
                   
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Upd_Type_ByCode:{0}", ex.Message));
            }
        }
        
        public int Upd_Disable_ByCode(string Code,bool NewDisable) 
        {
            try
            {
                 List<ExtendProperties> aListExtendProperties = aDatabaseDA.ExtendProperties.Where(b => b.Code==Code).ToList();
                 if (aListExtendProperties.Count > 0)
                  {
                        aListExtendProperties[0].Disable = NewDisable;
                        aDatabaseDA.ExtendProperties.AddOrUpdate(aListExtendProperties[0]);
                        return aDatabaseDA.SaveChanges();
                   
                  }
                 return 0;
            }
            catch (Exception ex) 
            {
                throw new Exception(String.Format("Upd_Type_ByCode:{0}", ex.Message));
            }
        }
        
        public int Upd_Status_ByCode_ByLang(string Code, int NewStatus, int IDLang) 
        {
            try
            {
                List<ExtendProperties> aListExtendProperties = aDatabaseDA.ExtendProperties.Where(b => b.Code == Code).Where(z=>z.IDLang==IDLang).ToList();
                if (aListExtendProperties.Count > 0)
                {
                    aListExtendProperties[0].Status = NewStatus;
                    aDatabaseDA.ExtendProperties.AddOrUpdate(aListExtendProperties[0]);
                    return aDatabaseDA.SaveChanges();

                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Upd_Status_ByCode_ByLang:{0}", ex.Message));
            }
        }
        

        public int Upd_Type_ByCode_ByLang(string Code,int NewType,int IDLang) 
        {
            try
            {
                List<ExtendProperties> aListExtendProperties = aDatabaseDA.ExtendProperties.Where(b => b.Code == Code).Where(z => z.IDLang == IDLang).ToList();
                if (aListExtendProperties.Count > 0)
                {
                    aListExtendProperties[0].Type = NewType;
                    aDatabaseDA.ExtendProperties.AddOrUpdate(aListExtendProperties[0]);
                    return aDatabaseDA.SaveChanges();

                }
                return 0;
            }
            catch (Exception ex) 
            {
                throw new Exception(String.Format("Upd_Type_ByCode_ByLang:{0}", ex.Message));
            }
        }
        
        public int Upd_Disable_ByCode_ByLang(string Code, bool NewDisable, int IDLang) 
        {
            try
            {
                List<ExtendProperties> aListExtendProperties = aDatabaseDA.ExtendProperties.Where(b => b.Code == Code).Where(z => z.IDLang == IDLang).ToList();
                if (aListExtendProperties.Count > 0)
                {
                    aListExtendProperties[0].Disable = NewDisable;
                    aDatabaseDA.ExtendProperties.AddOrUpdate(aListExtendProperties[0]);
                    return aDatabaseDA.SaveChanges();

                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Upd_Disable_ByCode_ByLang:{0}", ex.Message));
            }
        }


        //IDIDIDIDIDIDIDIDIDIDIDIDIDIDIDIDIDIDIDIDIDIDIDIDIDIDID#
        //NgocBM

        public int Ins(ExtendProperties aExtendProperties)
        {
            try
            {
                aDatabaseDA.ExtendProperties.AddOrUpdate(aExtendProperties);
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ExtendPropertiesBO.Ins: {0}", ex.Message));
            }
        }
        public int Ins(ref List<ExtendProperties> aListExtendProperties)
        {
            try
            {
                aListExtendProperties = aDatabaseDA.ExtendProperties.AddRange(aListExtendProperties).ToList();
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ExtendPropertiesBO.Ins: {0}", ex.Message));
            }
        }
        public int Upd(List<ExtendProperties> aListExtendProperties)
        {
            try
            {
                aDatabaseDA.ExtendProperties.AddOrUpdate(aListExtendProperties.ToArray());
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ExtendPropertiesBO.Ins: {0}", ex.Message));
            }
        }
        public int Upd(ExtendProperties aExtendProperties)
        {
            try
            {
                aDatabaseDA.ExtendProperties.AddOrUpdate(aExtendProperties);
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ExtendPropertiesBO.Upd: {0}", ex.Message));
            }
        }

        public int Del(List<ExtendProperties> aListExtendProperties)
        {
            try
            {
                aDatabaseDA.ExtendProperties.RemoveRange(aListExtendProperties);
                return aDatabaseDA.SaveChanges();
                

            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ExtendPropertiesBO.Del: {0}", ex.Message));
            }
        }

        public int Del_ByCode(string Code)
        {
            try
            {
                List<ExtendProperties> aTemp = aDatabaseDA.ExtendProperties.Where(p => p.Code == Code).ToList();
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.ExtendProperties.RemoveRange(aTemp);
                    return aDatabaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ExtendPropertiesBO.Del_ByCode: {0}", ex.Message));
            }
        }
        public int Del_ByCode_ByIDLang(string Code, int IDLang)
        {
            try
            {
                List<ExtendProperties> aTemp = aDatabaseDA.ExtendProperties.Where(p => p.Code == Code).Where(p => p.IDLang == IDLang).ToList();
                if (aTemp.Count >0)
                {
                    aDatabaseDA.ExtendProperties.Remove(aTemp[0]);
                    return aDatabaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ExtendPropertiesBO.Del_ByCode_ByIDLang: {0}", ex.Message));
            }
        }
        public int Del_By_ListCode(List<string> aListCode)
        {
            try
            {
                List<ExtendProperties> aTemp = aDatabaseDA.ExtendProperties.Where(p => aListCode.Contains(p.Code)).ToList();
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.ExtendProperties.RemoveRange(aTemp);
                    return aDatabaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ExtendPropertiesBO.Del_ByCode: {0}", ex.Message));
            }
        }



        //NgocBM
        public ExtendProperties Sel_ByCode_ByIDLang(string Code, int IDLang)
        {
            try
            {
            
                List<ExtendProperties> aListExtendProperties = new List<ExtendProperties>();


                aListExtendProperties = aDatabaseDA.ExtendProperties.Where(a => a.Code == Code).Where(a => a.IDLang == IDLang).ToList();
                if (aListExtendProperties.Count > 0)
                {
                    return aListExtendProperties[0];
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ExtendPropertiesBO.SelectListExtendProperties_ByCode_ByCategoryL1: {0}", ex.Message));
            }
        }
        public ExtendProperties Sel_ByCode_ByIDLang(string Code, int IDLang, bool Disable)
        {
            try
            {
             
                List<ExtendProperties> aListExtendProperties = new List<ExtendProperties>();


                aListExtendProperties = aDatabaseDA.ExtendProperties.Where(a => a.Code == Code).Where(a => a.IDLang == IDLang).Where(a => a.Disable == Disable).ToList();
                if (aListExtendProperties.Count > 0)
                {
                    return aListExtendProperties[0];
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ExtendPropertiesBO.SelectListExtendProperties_ByCode_ByCategoryL1: {0}", ex.Message));
            }
        }
        //==========================================================================================================================


    }
}


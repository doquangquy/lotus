using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Core.Objects;
using System.Configuration;
using System.Linq;
using DataAccess;
using EntitiesExt;
using System.Net.Mail;

namespace BussinessLogic
{
    public  class SystemUsersBO
    {

        DatabaseDA aDatabaseDA = new DatabaseDA();

        //Hiennv
        public SystemUsers Sel_ByUsername_ByPassword(string Username, string Password, bool Disable)
        {
            try
            {
                List<SystemUsers> aListSystemUsers = aDatabaseDA.SystemUsers.Where(s => s.Username == Username).Where(s => s.Password == Password).Where(s => s.Disable == Disable).ToList();
                if (aListSystemUsers.Count > 0)
                {
                    return aListSystemUsers[0];
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SystemUsersDA_SelectByUsernameByPassword: {0}", ex.Message));
            }
        }

        //Hiennv
        public SystemUsers Sel_ByEmail_ByPassword(string Email, string Password)
        {
            try
            {
                List<SystemUsers> aListSystemUsers = aDatabaseDA.SystemUsers.Where(s => s.Email == Email && s.Password == Password).ToList();
                if (aListSystemUsers.Count > 0)
                {
                    return aListSystemUsers[0];
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SystemUsersDA_SelectByEmailByPassword: {0}", ex.Message));
            }
        }
        public SystemUsers Sel_ByEmail_ByPassword(string Email, string Password, bool Disable)
        {
            try
            {
                List<SystemUsers> aListSystemUsers = aDatabaseDA.SystemUsers.Where(s => s.Email == Email && s.Password == Password && s.Disable == Disable).ToList();
                if (aListSystemUsers.Count > 0)
                {
                    return aListSystemUsers[0];
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SystemUsersDA_SelectByEmailByPassword: {0}", ex.Message));
            }
        }

		public List<SystemUsers> Sel()
        {
            try
            {
                return aDatabaseDA.SystemUsers.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SystemUsersBO.Sel:{0}", ex.Message));
            }
        }
		public List<SystemUsers> Sel(bool Disable)
        {
            try
            {
                return aDatabaseDA.SystemUsers.Where(z => z.Disable == Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SystemUsersBO.Sel:{0}", ex.Message));
            }
        }
        public List<SystemUsers> Sel_ByType(int Type)
        {
            try
            {
                return aDatabaseDA.SystemUsers.Where(p => p.Type == Type).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SystemUsersBO.Sel_ByType:{0}", ex.Message));
            }
        }
        public List<SystemUsers> Sel_ByType(int Type, bool Disable)
        {
            try
            {
                return aDatabaseDA.SystemUsers.Where(p => p.Type == Type).Where(z => z.Disable == Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SystemUsersBO.Sel_ByType:{0}", ex.Message));
            }
        }

        
     
        public List<SystemUsers> Sel_ByStatus(int Status)
        {
            try
            {
                return aDatabaseDA.SystemUsers.Where(p => p.Status == Status).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SystemUsersBO.Sel_ByStatus:{0}", ex.Message));
            }
        }
        public List<SystemUsers> Sel_ByStatus(int Status, bool Disable)
        {
            try
            {
                return aDatabaseDA.SystemUsers.Where(p => p.Status == Status).Where(z => z.Disable == Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SystemUsersBO.Sel_ByStatus:{0}", ex.Message));
            }
        }

        public List<SystemUsers> Sel_ByType_ByStatus(int Type, int Status)
        {
            try
            {
                return aDatabaseDA.SystemUsers.Where(c => c.Type == Type).Where(p => p.Status == Status).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SystemUsersBO.Sel_ByType_ByStatus:{0}", ex.Message));
            }
        }
        public List<SystemUsers> Sel_ByType_ByStatus_ByDisable(int Type, int Status, bool Disable)
        {
            try
            {
                return aDatabaseDA.SystemUsers.Where(c => c.Type == Type).Where(p => p.Status == Status).Where(z => z.Disable == Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SystemUsersBO.Sel_ByType_ByStatus:{0}", ex.Message));
            }
        }

      
        
        public int Del()
        {
            try
            {
                List<SystemUsers> aTemp = aDatabaseDA.SystemUsers.ToList();
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.SystemUsers.RemoveRange(aTemp);
                    return aDatabaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SystemUsersBO.Del: {0}", ex.Message));
            }
        }
		
       
        public int Upd_Status_ByID(int ID, int NewStatus) 
        {
            try
            {
                List<SystemUsers> aListSystemUsers = aDatabaseDA.SystemUsers.Where(b => b.ID == ID).ToList();
                if (aListSystemUsers.Count > 0) 
                {
                   
                        aListSystemUsers[0].Status = NewStatus;
                        aDatabaseDA.SystemUsers.AddOrUpdate(aListSystemUsers[0]);
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
                List<SystemUsers> aListSystemUsers = aDatabaseDA.SystemUsers.Where(b => b.ID == ID).ToList();
                if (aListSystemUsers.Count > 0) 
                {
                   
                        aListSystemUsers[0].Type = NewType;
                        aDatabaseDA.SystemUsers.AddOrUpdate(aListSystemUsers[0]);
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
                List<SystemUsers> aListSystemUsers = aDatabaseDA.SystemUsers.Where(b => b.ID == ID).ToList();
                if (aListSystemUsers.Count > 0) 
                {
                   
                        aListSystemUsers[0].Disable = NewDisable;
                        aDatabaseDA.SystemUsers.AddOrUpdate(aListSystemUsers[0]);
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
                List<SystemUsers> aTemp = aDatabaseDA.SystemUsers.Where(p=>p.ID == ID).ToList();
           
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.SystemUsers.Remove(aTemp[0]);
                    return aDatabaseDA.SaveChanges();
                }
                else
                {
                    throw new Exception(String.Format("SystemUsersBO.Del_ByID: {0}", "Không tìm thấy SystemUsers có ID = " + ID));
                }

            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SystemUsersBO.Del: {0}", ex.Message));
            }
        }
		
        public int Del_By_ListID(List<int> aListID)
        {
            try
            {
                List<SystemUsers> aTemp = aDatabaseDA.SystemUsers.Where(p => aListID.Contains(int.Parse(p.ID.ToString()))).ToList();
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.SystemUsers.RemoveRange(aTemp);
                    return aDatabaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SystemUsersBO.Del_By_ListID: {0}", ex.Message));
            }
        }

        public  SystemUsers Sel_ByID(Int32 ID)
        {
            try
            {
                SystemUsers aSystemUsers = aDatabaseDA.SystemUsers.Where(b => b.ID == ID).ToList()[0];
              
                    return aSystemUsers;
               
                
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SystemUsersBO.Sel: {0}", ex.Message));
            }
        }
        


        //#######################################################
        //NgocBM

        public int Ins(SystemUsers aSystemUsers)
        {
            try
            {
                aDatabaseDA.SystemUsers.AddOrUpdate(aSystemUsers);
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SystemUsersBO.Ins: {0}", ex.Message));
            }
        }
        public int Ins(ref List<SystemUsers> aListSystemUsers)
        {
            try
            {
                aListSystemUsers = aDatabaseDA.SystemUsers.AddRange(aListSystemUsers).ToList();
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SystemUsersBO.Ins: {0}", ex.Message));
            }
        }
        public int Upd(List<SystemUsers> aListSystemUsers)
        {
            try
            {
                aDatabaseDA.SystemUsers.AddOrUpdate(aListSystemUsers.ToArray());
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SystemUsersBO.Ins: {0}", ex.Message));
            }
        }
        public int Upd(SystemUsers aSystemUsers)
        {
            try
            {
                aDatabaseDA.SystemUsers.AddOrUpdate(aSystemUsers);
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SystemUsersBO.Upd: {0}", ex.Message));
            }
        }

        public int Del(List<SystemUsers> aListSystemUsers)
        {
            try
            {
                aDatabaseDA.SystemUsers.RemoveRange(aListSystemUsers);
                return aDatabaseDA.SaveChanges();
                

            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SystemUsersBO.Del: {0}", ex.Message));
            }
        }

             public bool SendMail(string To, string Title, string Content)
        {
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("englishcamp.dangky@gmail.com", "30f45510");
                smtp.EnableSsl = true;                                                      

            try
            {
                smtp.Send(To, "ngocbm1@picker.com.vn", Title, Content);
                return true;
            }
            catch (Exception E1)
            {
                return false;
            }
 
        }
        //NgocBM

    }
}

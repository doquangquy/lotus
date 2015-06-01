using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness;
using System.Web;
using CORE;
using DataAccess;
using Newtonsoft.Json.Converters;
using System.Globalization;
using Newtonsoft.Json;
using BussinessLogic;

namespace ActionHandler
{
    public class SinhvienAction : IAction
    {   
       public SystemUsers aCurrentSystemUsers = new SystemUsers();
       public void Do(HttpContext context)
       {
           string action = context.Request["action"].ToString();
           if (!String.IsNullOrEmpty(action))
           {
               this.aCurrentSystemUsers = (SystemUsers)context.Session["LoginAccount"];
               switch (action)
               {
                   case "Sel_ByAll":
                   this.Sel_ByAll(context);
                      
                       break;
                   default:
                       context.Response.Write("Can't find action");
                       break;
               }
           }
       }
       private IsoDateTimeConverter _converter = new IsoDateTimeConverter();
       private IFormatProvider culture = new CultureInfo("es-ES", true);// chưa biết nó  để làm gì
       public void Sel_ByAll(HttpContext context)
       {
           string jsonstring = "";
           SinhvienBO aSinhvienBO = new SinhvienBO();
           List<Sinhvien> obj = new List<Sinhvien>();
           obj = aSinhvienBO.Sel_ByAll();
           for (int i = 0; i < obj.Count(); i++)
           {
                      obj[i].Hoten = HttpUtility.HtmlDecode(obj[i].Hoten);
               //dạng dữ liệu html
           }
           if (obj!=null)
           {
               _converter.DateTimeFormat = "dd/MM/YYYY";
               jsonstring = JsonConvert.SerializeObject(obj, _converter);
           }
           jsonstring=  "{\"data\":"+jsonstring+"}";
           context.Response.Write(jsonstring);
       }
        public void Ins( HttpContext context)
       {
           ConfigsBO aConfigsBO = new ConfigsBO(); // ko hieu de lam cai gi
           string Jsonstring = "";
           try
           {
               List<Sinhvien> aListsinhvien = new List<Sinhvien>();
               Sinhvien aSinhvien = new Sinhvien();
               aSinhvien = new Sinhvien();
               //aSinhvien.Hoten=
            

           }
           catch (Exception)
           {
               
               throw;
           }

       }
       
    }
}

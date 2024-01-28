using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dto;
namespace Bll
{
   public class classDb
    {
        
        public RequestResult GetStudents()
        {
           // try
           // {
                using (databaseOrEntities db = new databaseOrEntities())
                {
                    List<studentTblDto> lst = new List<studentTblDto>();
                    foreach (var item in db.studentTbl.ToList())
                    {
                        lst.Add(studentTblDto.DalToDto(item));
                    }
                    return new RequestResult { Data = lst, Status = true, Message = "" };
                }
          //  }
            //catch (Exception ex)
            //{
            //    return new RequestResult { Data = null, Status = false, Message = "שגיאה בשליפת הנתונים" };
            //}
        }
    }
}

using BirthdayApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BirthdayApp.Controllers
{
    public class InvitationController : ApiController
    {
        public IEnumerable<InvitationModel> GetAttendants()
        {
            return DataBase.List.Where(i => i.AttendanceStatus == true);
        }

        public IEnumerable<InvitationModel> GetNonAttendants()
        {
            return DataBase.List.Where(i => i.AttendanceStatus == false);
        }
        public void PostAdd(InvitationModel model)
        {
            if (ModelState.IsValid)
            {
                DataBase.Add(model);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirthdayApp.Models
{
    public static class DataBase
    {
        private static Dictionary<string, InvitationModel> _list;


        static DataBase()
        {
            _list = new Dictionary<string, InvitationModel>();

            _list.Add("Arif", new InvitationModel
            {
                Name = "Arif",
                Email = "arif660damar@gmail.com",
                AttendanceStatus = true
            });

            _list.Add("Şule", new InvitationModel
            {
                Name = "Şule",
                Email = "suledamar@gmail.com",
                AttendanceStatus = false
            });

            _list.Add("Ömer Çağrı", new InvitationModel
            {
                Name = "Ömer Çağrı",
                Email = "omercagris@gmail.com",
                AttendanceStatus = true
            });
        }

        public static void Add(InvitationModel model)
        {
            string key = model.Name.ToLower();
            if (_list.ContainsKey(key))
            {
                _list[key] = model;
            }
            else
            {
                _list.Add(key, model);
            }
        }

        public static IEnumerable<InvitationModel> List
        {
            get { return _list.Values; }
        }

    }
}
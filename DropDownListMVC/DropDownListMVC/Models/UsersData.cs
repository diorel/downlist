using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropDownListMVC.Models
{
    public class UsersData
    {
        [DataType(DataType.Text)]
        [DisplayName("USers")]
        public List<SelectListItem> usersLista { get; set; }

        public int id { get; set; }

        public UsersData()
        {
            PDHNEntities data = new PDHNEntities();
            usersLista = new List<SelectListItem>();
            var query = from u in data.USers select u;
            var listData = query.ToList();

            foreach (var Data in listData)
            {
                usersLista.Add(new SelectListItem()
                {
                    Value = Data.IdUser.ToString(),
                    Text = Data.Name
                });
            }
            
        }
    }
}
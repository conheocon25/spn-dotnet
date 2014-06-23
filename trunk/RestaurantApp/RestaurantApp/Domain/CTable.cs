using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace RestaurantApp.Domain
{
    class CTable
    {
        public CTable(int Id = 0, int IdTable = 0,  string Name = "")
        {
            this.Id = Id;
            this.IdTable = Id;
            this.Name = Name;
        }

        [DisplayName("Id")]
        public int Id { get; set; }

        [Browsable(false)]
        public int IdTable { get; set; }

        [DisplayName("Tên")]
        public string Name { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace RestaurantApp.Domain
{
    class CConfig
    {
        public CConfig(int Id = 0, string Param = "", string Value = "")
        {
            this.Id = Id;
            this.Param = Param;
            this.Value = Value;
        }

        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Tham số")]
        public string Param{ get; set; }

        [DisplayName("Giá trị")]
        public string Value{ get; set; }
    }
}
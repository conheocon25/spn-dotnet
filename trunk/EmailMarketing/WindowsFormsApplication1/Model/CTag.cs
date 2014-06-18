using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace EmailMarketing
{
    public class CTag
    {        
        public CTag(int Id = 0, string Name = "")
        {
            this.Id = Id;
            this.Name = Name;
        }

        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Tên")]
        public string Name { get; set; }

    }
}

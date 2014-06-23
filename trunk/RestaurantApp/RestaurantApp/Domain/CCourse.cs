using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace RestaurantApp.Domain
{
    class CCourse
    {
        public CCourse(
            int Id = 0, 
            int IdCategory = 0,
            string Name = "",
            string Unit = "",
            long Price = 0,
            int Prepare = 0,
            bool Discount = false,
            bool Enable = true
            )
        {
            this.Id = Id;
            this.IdCategory = IdCategory;
            this.Name = Name;
            this.Unit = Unit;
            this.Price = Price;
            this.Prepare = Prepare;
            this.Discount = Discount;
            this.Enable = Enable;
        }

        [DisplayName("Id")]
        public int Id { get; set; }

        [Browsable(false)]
        public int IdCategory { get; set; }
        
        [DisplayName("Tên")]
        public string Name { get; set; }

        [DisplayName("Unit")]
        public string Unit { get; set; }

        [DisplayName("Giá")]
        public long Price{ get; set; }

        [DisplayName("Chuẩn bị")]
        public int Prepare{ get; set; }

        [DisplayName("Giảm giá")]
        public bool Discount { get; set; }

        [DisplayName("Sử dụng")]
        public bool Enable { get; set; }
    }
}
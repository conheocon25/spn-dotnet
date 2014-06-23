using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace RestaurantApp.Domain
{
    class CUser
    {
        public CUser(
            int Id = 0, 
            string Name = "",
            string Email = "",
            string Password = "",
            bool Gender = true,
            string Note = "",
            DateTime DateCreated = new DateTime(),
            DateTime DateUpdated = new DateTime(),
            DateTime DateActivity = new DateTime(),
            int Type = 0,
            string Code = ""
            )
        {
            this.Id = Id;
            this.Name = Name;
            this.Email = Email;
            this.Password = Password;
            this.Gender = Gender;
            this.Note = Note;
            this.DateCreated = DateCreated;
            this.DateUpdated = DateUpdated;
            this.DateActivity = DateActivity;
            this.Type = Type;
            this.Code = Code;
        }

        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Tên")]
        public string Name { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Mật khẩu")]
        public string Password { get; set; }

        [DisplayName("Giới tính")]
        public bool Gender{ get; set; }

        [DisplayName("Ghi chú")]
        public string Note{ get; set; }

        [DisplayName("Ngày tạo")]
        public DateTime DateCreated { get; set; }

        [DisplayName("Ngày cập nhật")]
        public DateTime DateUpdated { get; set; }

        [DisplayName("Ngày hoạt động")]
        public DateTime DateActivity { get; set; }

        [DisplayName("Loại")]
        public int Type { get; set; }

        [DisplayName("Mã Code")]
        public string Code{ get; set; }
    }
}

﻿namespace EntityLayer.AdminDetails
{
    public class Admin
    {
        public int id { get; set; }
        public int StaffId { get; set; }
<<<<<<< HEAD

        public byte[]? ProfilePicture { get; set; }
=======
        
        public byte? ProfilePicture { get; set; }
>>>>>>> 739e9637555c9aa1c46f1925834bce97ee9a46d1
        public string UserName { get; set; }
        public string Email { get; set; }

        //public string Password { get; set; }
        //public string ChangePassword { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
    }
}
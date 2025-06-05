using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibraryDA.Classes;

namespace GameLibraryDA
{
    public interface User
    {
        string Name { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        DateTime RegistrationDate { get; set; }
        Country Country { get; set; }


        void ChangeName(in string newName)
        {
            Name = newName;
        }

        void ChangeEmail(in string newEmail)
        {
            Email = newEmail;
        }

        void ChangePassword(in string newPassword)
        {
            Password = newPassword;
        }
    }
}

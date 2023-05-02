using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media.Classes
{
    public class User
    {
        private string userFirstName;
        private string userLastName;
        private string bio;
        private int key;
        private string email;
        private string password;
        private string userName;
        private DateTime dob;
        private string gender;
        private Image profilePhoto;

        public int Key
        {
            get { return key; }
            set { key = value; }
        }


       
        public string UserFirstName
        {
            get { return this.userFirstName; }
            set { this.userFirstName = value; }
        }
        public string UserLastName
        {
            get { return this.userLastName; }
            set { this.userLastName = value; }
        }
        public string Bio
        {
            get { return this.bio; }
            set
            {
                this.bio = value.Substring(0, 100);
            }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
        public string UserName
        {
            get { return this.userName; }
            set
            {
                this.userName = value;
            }
        }
        public DateTime Dob
        {
            get { return this.dob; }
            set
            {
                this.dob = value;
            }
        }
        public string Gender
        {
            get { return this.gender; }
            set
            {
                this.gender = value;
            }
        }
        public Image ProfilePhoto
        {
            get { return this.profilePhoto; }
            set
            {   if (value != null)
                    this.profilePhoto = value;
                else
                    this.profilePhoto = Coder_s_space.Properties.Resources.profile_user;
            }
        }

        public User(string userFirstName, string userLastName, string email, string userName, DateTime dob, string gender)
        {
            this.UserFirstName = userFirstName;
            this.UserLastName = userLastName;
            this.Email = email;
            this.userName = userName;
            this.Dob = dob;
            this.Gender = gender;
        }
        public User()
        {

        }
    }
}
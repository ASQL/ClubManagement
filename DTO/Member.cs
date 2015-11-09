using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Member
    {
        private String id;

        public String ID
        {
            get { return id; }
            set { id = value; }
        }

        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private String job;

        public String Job
        {
            get { return job; }
            set { job = value; }
        }

        private DateTime birthday;

        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        private String email;

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        private String password;

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        private int isChairman;

        public int IsChairman
        {
            get { return isChairman; }
            set { isChairman = value; }
        }

        private byte[] image;

        public byte[] Image
        {
            get { return image; }
            set { image = value; }
        }

        public bool IsCorrectPassword(String password)
        {
            return this.password.Equals(password) ? true : false;
        }
    }
}

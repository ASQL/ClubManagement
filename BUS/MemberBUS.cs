using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class MemberBUS
    {
        private MemberDAL memberDAL;

        public MemberBUS()
        {
            memberDAL = new MemberDAL();
        }

        public Member getMemberByID(String id)
        {
            Member member = new Member();
            DataTable dt = memberDAL.SearchByID(id);
            if (dt.Rows.Count > 0)
            {
                member.ID = dt.Rows[0][0].ToString();
                member.Name = dt.Rows[0][1].ToString();
                member.Job = dt.Rows[0][2].ToString();
                member.Birthday = Convert.ToDateTime(dt.Rows[0][3].ToString());
                member.Image = (byte[])(dt.Rows[0][4]);
                member.Email = dt.Rows[0][5].ToString();
                member.Password = dt.Rows[0][6].ToString();
                member.IsChairman = Convert.ToInt16(dt.Rows[0][7].ToString());
                return member;
            }
            else
            {
                throw new Exception("Tài khoản không tồn tại!");
            }
        }
    }
}

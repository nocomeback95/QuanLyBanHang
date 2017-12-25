using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1.DAL
{
    public class AccountDAL : BaseDAL<ACCOUNT>
    {
        public bool IsGetAccountByUserNameAndPassWord(string userName , string passWord)
        {
                var currentAccount = GetAll().Where(c => (c.UserName == userName) && (c.PassWord == passWord)).ToList();
                return currentAccount.Any();
        }
    }
}

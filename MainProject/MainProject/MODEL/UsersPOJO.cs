using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.MODEL
{
    public class UsersPOJO
    {
        public String Nick { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }

        public UsersPOJO() { }
        public UsersPOJO(String Nick, String Name, String Email)
        {
            this.Nick = Nick;
            this.Name = Name;
            this.Email = Email;
        }
        public static UsersPOJO FromDataRow(DataRow dr)
        {
            try
            {
                return new UsersPOJO(
                    dr["Nick"].ToString(),
                    dr["Name"].ToString(),
                    dr["Email"].ToString()
                );
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

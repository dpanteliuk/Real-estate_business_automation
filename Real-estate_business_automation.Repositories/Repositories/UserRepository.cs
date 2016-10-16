using Real_estate_business_automation.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_estate_business_automation.Repositories
{
    public class UserRepository:Repository<User>
    {
        public UserRepository(string connectionstring):
            base(connectionstring)
        {
        }

        protected override User Map(IDataRecord record)
        {
            var user = new User();

            user.Id = Convert.ToInt32(record["Id"]);
            user.PersId = Convert.ToInt32(record["PersId"]);
            user.Login = (string)record["Login"];

            user.Password = "hidden";

            return user;
        }

        public User GetUserByLogin(string login, string password)
        {
            return ExecuteCommand<User>((command) =>
           {
               command.CommandText = "spGetUser";
               command.Parameters.AddWithValue("@Login", login);
               command.Parameters.AddWithValue("@Password", password);

               User user = null;

               using (var reader = command.ExecuteReader())
               {
                   if (reader.Read())
                   {
                       user = Map(reader);
                   }
               }

               return user;
           });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Real_estate_business_automation.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Real_estate_business_automation.Repositories
{
    public class PersonRepository:Repository<Person>
    {
        public PersonRepository (string connectionstring):
            base(connectionstring)
        {

        }

        protected override Person Map(IDataRecord record)
        {
            var person = new Person();

            person.Name = (string)record["FirstName"];
            person.Surname = (string)record["LastName"];
            person.Phone = (string)record["Phone"];
            person.Mail = (string)record["Mail"];
            person.Id = Convert.ToInt32(record["Id"]);

            return person;
        }

        public Person GetPersonByID(int id)
        {
            return ExecuteCommand<Person> ((command) =>
            {
                command.CommandText = "spGetPersonByID";
                command.Parameters.AddWithValue("@Id", id);

                Person p = null;
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        p = Map(reader);
                    }
                }
                return p;
            });
        }

        protected void AddParameters(SqlCommand command, Person entity)
        {
            command.Parameters.AddWithValue("@FirstName", entity.Name);
            command.Parameters.AddWithValue("@LastName", entity.Surname);
            command.Parameters.AddWithValue("@Phone", entity.Phone);
            command.Parameters.AddWithValue("@Mail", entity.Mail);
        }

        public int Add(Person entity)
        {
            return ExecuteCommand<int>((command) =>
            {
                command.CommandText = "spInsertPerson";

                AddParameters(command, entity);

                var id = new SqlParameter("@Id", SqlDbType.Int);
                id.Direction = ParameterDirection.Output;
                command.Parameters.Add(id);

                command.ExecuteNonQuery();

                return Convert.ToInt32(id.Value);
            });
        }

        public bool Delete(int id)
        {
            return ExecuteCommand<bool>((command) =>
            {
                command.CommandText = "spDeletePerson";
                command.Parameters.AddWithValue("@Id", id);

                return command.ExecuteNonQuery() == 1;
            });
        }

        public bool Update (Person person)
        {
            return ExecuteCommand<bool>((command) =>
            {
                command.CommandText = "spUpdatePerson";

                AddParameters(command, person);
                command.Parameters.AddWithValue("@Id", person.Id);

                return command.ExecuteNonQuery() == 1;
            });
        }
    }
}

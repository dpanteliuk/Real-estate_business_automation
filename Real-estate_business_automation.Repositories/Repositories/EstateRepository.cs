using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Real_estate_business_automation.Entities;
using System.Data.SqlClient;

namespace Real_estate_business_automation.Repositories
{

    public class EstateRepository: Repository<Estate>
    {
        public EstateRepository(string connectionstring):
            base(connectionstring)
        {
        }

        protected override Estate Map(IDataRecord record)
        {
            var estate = new Estate();
            estate.Id = Convert.ToInt32(record["Id"]);
            estate.OwnerId = Convert.ToInt32(record["EstOwner"]);
            estate.DistrictId = (record["District"] is DBNull) ? (null) : (int?)Convert.ToInt32(record["District"]);
            estate.Rooms = Convert.ToInt32(record["Rooms"]);
            estate.Area = Convert.ToDouble(record["Area"]);
            estate.Address = (string)record["Address"];
            estate.Price = Convert.ToInt32(record["Price"]);
            estate.Rent = Convert.ToBoolean(record["Rent"]);
            estate.Sale = Convert.ToBoolean(record["Sale"]);

            return estate;
        }


        public IEnumerable<Estate> GetAll()
       {
            return  ExecuteCommand<IEnumerable<Estate>> ((command) =>
            {
                var items = new List<Estate>();
                command.CommandText = "spGetEstates";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        items.Add(Map(reader));
                    }
                }
                return items;
            });
        }

        public Estate GetEstateById(int id)
        {
            return ExecuteCommand<Estate>((command) =>
            {
                command.CommandText = "spGetEstateById";
                command.Parameters.AddWithValue("@Id", id);

                Estate estate = null;
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        estate = Map(reader);
                    }
                }
                return estate;
            });
        }

        public int Delete(int id)
        {
            return ExecuteCommand<int> ((command) =>
            {
                command.CommandText = "spDeleteEstate";
                command.Parameters.AddWithValue("@Id", id);

                var Ownerid = new SqlParameter("@EstOwnerId", SqlDbType.Int);
                Ownerid.Direction = ParameterDirection.Output;
                command.Parameters.Add(Ownerid);

                command.ExecuteNonQuery();
                return Convert.ToInt32(Ownerid.Value);
            });
        }


        protected void AddParameters(SqlCommand command, Estate entity)
        {
            if (entity.DistrictId == null)
            {
                command.Parameters.AddWithValue("@District", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@District", entity.DistrictId);
            }
            command.Parameters.AddWithValue("@EstOwner", entity.OwnerId);
            command.Parameters.AddWithValue("@Rooms", entity.Rooms);
            command.Parameters.AddWithValue("@Area", entity.Area);
            command.Parameters.AddWithValue("@Address", entity.Address);
            command.Parameters.AddWithValue("@Price", entity.Price);
            command.Parameters.AddWithValue("@Rent", entity.Rent);
            command.Parameters.AddWithValue("@Sale", entity.Sale);
        }

        public bool Add(Estate entity)
        {
            int num = ExecuteCommand<int> ((command) =>
            {
                command.CommandText = "spInsertEstate";
                AddParameters(command, entity);

                return command.ExecuteNonQuery();
            });

            return num != 0;
        }

        public bool Update(Estate entity)
        {
            int num = ExecuteCommand<int>((command) =>
            {
                command.CommandText = "spUpdateEstate";
                AddParameters(command, entity);
                command.Parameters.AddWithValue("@Id", entity.Id);

                return command.ExecuteNonQuery();
            });

            return num != 0;
        }



    }
}

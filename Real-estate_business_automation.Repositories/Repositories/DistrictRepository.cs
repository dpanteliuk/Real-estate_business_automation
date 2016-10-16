using Real_estate_business_automation.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_estate_business_automation.Repositories
{
    public class DistrictRepository: Repository<District>
    {
        public DistrictRepository(string connectionstring):
            base(connectionstring)
        {
        }

        protected override District Map(IDataRecord record)
        {
            var district = new District();

            district.Id = Convert.ToInt32(record["Id"]);
            district.Name = (string)record["Name"];

            return district;
        }

        public District GetDistrictById(int id)
        {
            return ExecuteCommand<District>((command) =>
            {
                command.CommandText = "spGetDistrictById";
                command.Parameters.AddWithValue("@Id", id);

                District dist = null;
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dist = Map(reader);
                    }
                }
                return dist;
            });
        }

        public List<District> GetAllDistricts()
        {
            return ExecuteCommand<List<District>>((command) =>
            {
                command.CommandText = "spGetDistricts";

                var list = new List<District>();
                using (var reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        list.Add(Map(reader));
                    }
                }
                return list;
            });
        }
    }
}

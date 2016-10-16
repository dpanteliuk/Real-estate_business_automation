using System;
using System.Collections.Generic;
using System.Data;
using Real_estate_business_automation.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_estate_business_automation.Repositories
{
    public class ContractRepository:Repository<Contract>
    {
        public ContractRepository (string connectionstring):
            base(connectionstring)
        {
        }

        protected override Contract Map(IDataRecord record)
        {
            var entity = new Contract();

            entity.Id = Convert.ToInt32(record["Id"]);
            entity.EmpId = Convert.ToInt32(record["EmployeeId"]);
            entity.CustId = Convert.ToInt32(record["CustomerId"]);
            entity.EstateId = Convert.ToInt32(record["EstateId"]);
            entity.Date = Convert.ToDateTime(record["Date"]);

            return entity;

        }

        public IEnumerable<Contract> GetAll()
        {
            return ExecuteCommand<IEnumerable<Contract>>((command) =>
            {
                var items = new List<Contract>();
                command.CommandText = "spGetContracts";

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

        public bool Add(Contract entity)
        {
            int num = ExecuteCommand<int>((command) =>
            {
                command.CommandText = "spInsertContract";

                command.Parameters.AddWithValue("@EmployeeId", entity.EmpId);
                command.Parameters.AddWithValue("@CustomerId", entity.CustId);
                command.Parameters.AddWithValue("@EstateId", entity.EstateId);

                return command.ExecuteNonQuery();
            });

            return num != 0;
        }
    }
}

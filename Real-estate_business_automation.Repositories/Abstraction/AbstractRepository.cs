using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_estate_business_automation.Repositories
{

    public abstract class Repository<TEntity>
        where TEntity : new()
    {
        private string _constr;
        
        public Repository(string connectionstring)
        {
            _constr = connectionstring;
        }

        protected abstract TEntity Map(IDataRecord record);


        protected TResult ExecuteCommand<TResult>(Func<SqlCommand, TResult> callback)
        {
            using (var connection = new SqlConnection(_constr))
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    return callback(command);
                }
            }

        }


    }
}

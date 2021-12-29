using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ExamDemo.Infrastructure
{
    public class StoredProcedureParams
    {
        public SqlParameter[] AsSqlParameters()
        {
            var sqlParameters = new List<SqlParameter>();
            var properties = this.GetType().GetProperties();
            foreach (var p in properties)
            {
                var value = p.GetValue(this) ?? DBNull.Value;
                var parameterName = p.Name;
                SqlParameter parameter;

                //If property type is user defined data type then add sql parameters
                //if (value is UserDefinedTableTypeParameter userDefinedTypeParameter)
                //{
                //    parameter = new SqlParameter(parameterName, userDefinedTypeParameter.Data)
                //    {
                //        SqlDbType = SqlDbType.Structured,
                //        TypeName = userDefinedTypeParameter.TableType
                //    };
                //}
                //For all other types



                parameter = new SqlParameter(parameterName, value);
               
                sqlParameters.Add(parameter);
            }

            return sqlParameters.ToArray();
        }
    }
}

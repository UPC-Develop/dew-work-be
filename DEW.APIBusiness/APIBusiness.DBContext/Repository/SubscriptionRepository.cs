using APIBusiness.DBContext.Interface;
using Dapper;
using DBContext;
using DBEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBusiness.DBContext.Repository
{
    public class SubscriptionRepository : BaseRepository, ISubscriptionRepository
    {
        public BaseResponse saveSubscription(string fullName, string email)
        {


            
            var returnEntity = new BaseResponse();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = @"usp_SaveSubscription";

                    var p = new DynamicParameters();
                    p.Add(name: "@FullName", value: fullName, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@Email", value: email, dbType: DbType.String, direction: ParameterDirection.Input);

                    db.Execute(sql, p, commandType: CommandType.StoredProcedure);

                    returnEntity.isSuccess = true;
                    returnEntity.errorCode = "0000";
                    returnEntity.errorMessage = string.Empty;
                    returnEntity.data = "Ok";
                    
                }
            }
            catch (Exception ex)
            {
                returnEntity.isSuccess = false;
                returnEntity.errorCode = "0001";
                returnEntity.errorMessage = ex.Message;
                returnEntity.data = null;
            }

            return returnEntity;
        }
    }
}

using APIBusiness.DBContext.Interface;
using Dapper;
using DBContext;
using DBEntity;
using DEW.APIBusiness.DBEntity.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBusiness.DBContext.Repository
{
    public class ContactRepository : BaseRepository, IContactRepository
    {
        public BaseResponse SaveContact(EntityContact entityContact)
        {
            var returnEntity = new BaseResponse();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = @"usp_SaveContact";

                    var p = new DynamicParameters();
                    p.Add(name: "@Phone", value: entityContact.phone, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@Email", value: entityContact.email, dbType: DbType.String, direction: ParameterDirection.Input);

                    db.Execute(sql: sql, param: p, commandType: CommandType.StoredProcedure);

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

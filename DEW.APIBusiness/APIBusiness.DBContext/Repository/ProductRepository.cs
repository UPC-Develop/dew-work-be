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
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public BaseResponse GetProductByCategoryId(int categoryId)
        {
            var entityProducts = new List<EntityProduct>();
            var returnEntity = new BaseResponse();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = @"usp_GetProductByCategory";

                    var p = new DynamicParameters();
                    p.Add(name: "@CategoryId", value: categoryId, dbType: DbType.Int32, direction: ParameterDirection.Input);

                    entityProducts = db.Query<EntityProduct>(sql: sql, param: p, commandType: CommandType.StoredProcedure).ToList();

                    if (entityProducts.Count > 0)
                    {
                        returnEntity.isSuccess = true;
                        returnEntity.errorCode = "0000";
                        returnEntity.errorMessage = string.Empty;
                        returnEntity.data = entityProducts;
                    }
                    else
                    {
                        returnEntity.isSuccess = true;
                        returnEntity.errorCode = "0000";
                        returnEntity.errorMessage = string.Empty;
                        returnEntity.data = null;
                    }
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

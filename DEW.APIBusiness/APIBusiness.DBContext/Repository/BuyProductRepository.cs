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
    public class BuyProductRepository : BaseRepository, IBuyProductRepository
    {
        public BaseResponse SaveBuyProduct(EntityBuyProduct entityBuyProduct)
        {
            var returnEntity = new BaseResponse();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = @"usp_SaveSubscription";

                    var p = new DynamicParameters();
                    p.Add(name: "@TipDoc", value: entityBuyProduct.tipodocumento, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@NroDoc", value: entityBuyProduct.nrodocumento, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@Nombre", value: entityBuyProduct.nombre, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@Direccion", value: entityBuyProduct.direccion, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@Distrito", value: entityBuyProduct.distrito, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@Provincia", value: entityBuyProduct.provincia, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@Departamento", value: entityBuyProduct.departamento, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@Telefono", value: entityBuyProduct.telefono, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@Email", value: entityBuyProduct.email, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@Total", value: entityBuyProduct.total, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                    db.Execute(sql, p, commandType: CommandType.StoredProcedure); ;

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

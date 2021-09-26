﻿using Dapper;
using DBEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBContext
{
    public class CatalogRepository : BaseRepository, ICatalogRepository
    {
        public BaseResponse GetCatalog()
        {
            var entityCatalog = new List<EntityCatalog>();
            var returnEntity = new BaseResponse();

            try
            {
                using (var db = GetSqlConnection())
                {

                    const string sql = @"usp_ListarProducto";
                    entityCatalog = db.Query<EntityCatalog>(sql: sql, commandType: CommandType.StoredProcedure).ToList();

                    if (entityCatalog.Count > 0)
                    {
                        returnEntity.isSuccess = true;
                        returnEntity.errorCode = "0000";
                        returnEntity.errorMessage = string.Empty;
                        returnEntity.data = entityCatalog;
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

using MISA.CukCuk.Core.Interfaces.Repository;
using System;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace MISA.CukCuk.Infrastructure.Repository
{
    /// <summary>
    /// Class thao tác trực tiếp với database
    /// </summary>
    /// <typeparam name="T">đối tượng cần thao tác</typeparam>
    public class BaseRepository<T> : IBaseRepository<T>
    {
        /// <summary>
        /// Khởi tạo kết nối đến database
        /// </summary>
        protected String _connectionString = "" +
               "Host = 47.241.69.179;" +
               "Port = 3306;" +
               "Database= 15B_MS2-34_cukcuk_NGDUONG;" +
               "User Id = dev;" +
               "Password= 12345678";

        // 2. Khởi tạo kết nối:
        protected IDbConnection _dbConnection;
        /// <summary>
        /// Hàm xóa dữ liệu trong table
        /// </summary>
        /// <param name="id">Id cần xóa</param>
        /// <returns>
        /// số hàng xóa được trong database
        /// </returns>
        public int Delete(Guid id)
        {
            using (_dbConnection = new MySqlConnection(_connectionString))
            {

                var tableName = typeof(T).Name;

                var sqlCommand = $"DELETE FROM {tableName} WHERE {tableName}Id = '{id.ToString()}'";
                var rowsAffect = _dbConnection.Execute(sqlCommand);
                return rowsAffect;
            }
        }
        /// <summary>
        /// Lấy toàn bộ dữ liệu trong table
        /// </summary>
        /// <returns>
        /// Danh sách các cột lấy được trong database
        /// </returns>
        public IEnumerable<T> GetAll()
        {
            using (_dbConnection = new MySqlConnection(_connectionString))
            {
                var name = typeof(T).Name;
                var sqlCommand = $"Proc_Get{name}s";
                var entities = _dbConnection.Query<T>(sqlCommand, commandType: CommandType.StoredProcedure);
                return entities;
            }
        }
        /// <summary>
        /// Hàm lấy dữ liệu theo mã id
        /// </summary>
        /// <param name="id">Id cần lấy</param>
        /// <returns>
        /// giá trị trong hàng lấy được
        /// </returns>
        public T GetById(Guid id)
        {
            using (_dbConnection = new MySqlConnection(_connectionString))
            {
                var tableName = typeof(T).Name;
                var sqlCommand = $"SELECT * FROM {tableName} WHERE {tableName}Id = '{id.ToString()}'";
                var entity = _dbConnection.QueryFirstOrDefault<T>(sqlCommand);
                return entity;
            }
        }
        /// <summary>
        /// thêm một hàng vào trong table
        /// </summary>
        /// <param name="entity">đối tương cần thêm</param>
        /// <returns>số hàng thao tác được trên table</returns>
        public int Insert(T entity)
        {
            using (_dbConnection = new MySqlConnection(_connectionString))
            {
                var tableName = typeof(T).Name;
                var storeName = $"Proc_Insert{tableName}";
                var rowsAffect = _dbConnection.Execute(storeName, param: entity, commandType: CommandType.StoredProcedure);
                return rowsAffect;
            }
        }
        /// <summary>
        /// Cập nhật giá trị của đối tượng entity
        /// </summary>
        /// <param name="entity">đối tượng cần cập nhật</param>
        /// <returns>số hàng thao tác được trên bảng</returns>
        public int Update(T entity)
        {
            using (_dbConnection = new MySqlConnection(_connectionString))
            {

                var tableName = typeof(T).Name;
                /*
                var entityIdPropertyName = $"{tableName}Id";
                var entityIdProperty = typeof(MISAEntity).GetProperty(entityIdPropertyName);
                if (entityIdProperty != null)
                    typeof(MISAEntity).GetProperty(entityIdPropertyName).SetValue(entity, entityId);
                */
                var storeName = $"Proc_Update{tableName}";
                var rowsAffect = _dbConnection.Execute(storeName, param: entity, commandType: CommandType.StoredProcedure);
                return rowsAffect;
            }
        }
    }
}

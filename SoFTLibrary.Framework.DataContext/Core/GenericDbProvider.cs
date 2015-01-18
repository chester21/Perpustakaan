using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using SoFTLibrary.Framework.DataContext.Infrastructure;

namespace SoFTLibrary.Framework.DataContext.Core
{
    public abstract class GenericDbProvider : ConnectionStringx , IDisposable
    {

        /// <summary>
        /// Executes DML of SQL Server. Non query syntax
        /// </summary>
        /// <param name="commandTexts">SQL syntax</param>
        /// <returns>Number of rows affected</returns>
        protected int ExecuteNonQuery(params string[] commandTexts)
        {
            try
            {
                int i = 0;
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand();
                            command.Connection = connection;
                            command.Transaction = transaction;
                            command.CommandType = CommandType.Text;
                            foreach (string commandText in commandTexts)
                            {
                                command.CommandText = commandText;
                                i = +command.ExecuteNonQuery();
                            }
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw new Exception(ex.Message, ex.InnerException);
                        }
                    }
                }
                return i;
            }
            catch
            {
                throw;
            }

        }

        /// <summary>
        /// Executes command text with non query.
        /// </summary>
        /// <param name="commandText">Command text</param>
        /// <param name="parameters">Sql parameter</param>
        /// <returns>The number of rows affected</returns>
        protected int ExecuteNonQuery(string commandText, params SqlParameter[] parameters)
        {
            try
            {
                int i = 0;
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand(commandText, connection, transaction))
                            {
                                command.Transaction = transaction;
                                command.Parameters.AddRange(parameters);
                                i += command.ExecuteNonQuery();
                                transaction.Commit();
                            }
                            return i;
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw new Exception(ex.Message, ex.InnerException);
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Executes query that returns scalar
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters">Sql parameter</param>
        /// <returns>Object</returns>
        protected object ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            try
            {
                object result = null;
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddRange(parameters);
                            result = command.ExecuteScalar();
                        }
                        connection.Close();
                        connection.Dispose();
                        return result;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message, ex.InnerException);
                    }
                }
            }
            catch
            {
                throw;
            }
        }


        /// <summary>
        /// Executes query returns scalar
        /// </summary>
        /// <param name="commandText">Sql query : Atau nama Stored Procedure</param>
        /// <param name="type">Sql Command Type : Tentukan Jenis CommandType nya, apakah CommandText, atau StoredProcedure</param>
        /// <param name="parameters">Sql Parameters</param>
        /// <returns>Object</returns>
        protected object ExecuteScalar(string commandText, CommandType type, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(base.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.CommandType = type;
                    command.Parameters.AddRange(parameters);
                    return command.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// Executes query returns scalar ,Untuk Eksekusi Stored Procedure yang return value nya hanya satu object saja.
        /// </summary>
        /// <param name="commandText">: Nama Stored Procedure nya.</param>
        /// <returns>Object : Hasil return berupa obejct.</returns>
        protected object ExecuteScalar(string commandText)
        {
            using (SqlConnection connection = new SqlConnection(base.ConnectionString))
            {
                connection.Open();
                object data;
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    data = command.ExecuteScalar();
                }
                connection.Close();
                connection.Dispose();
                return data;
            }
        }

        /// <summary>
        /// Gets table from sql query
        /// </summary>
        /// <param name="query">Sql query</param>
        /// <returns>Data Table</returns>
        protected DataTable ReadQueryIntoDataTable(string query, params SqlParameter[] parameters)
        {
            try
            {
                DataTable table = new DataTable();
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (parameters.Length > 0)
                            command.Parameters.AddRange(parameters);
                        IDataReader rader = command.ExecuteReader();
                        table.Load(rader);
                    }
                }
                return table;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        /// <summary>
        /// Gets IEnumerable of object entities mapped from SqlDataReader based on IDataReader
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="reader">IDataReader</param>
        /// <returns>IEnumerable of object</returns>
        private async Task<IEnumerable<T>> MapDataReader<T>(IDataReader reader) where T : class
        {
            try
            {
                List<T> listReturn = new List<T>();
                T entity = default(T);

                Type t = typeof(T); //untuk lihat tipenya. jika primitive ga perlu create instance

                if (t.IsPrimitive || t == typeof(object) || t == typeof(string) || t == typeof(Decimal) || t == typeof(TimeSpan) || t == typeof(DateTime) || t == typeof(DateTimeOffset))
                {
                    while (reader.Read()) //baca datareader
                    {
                        object[] values = new object[reader.FieldCount];
                        int countvalue = reader.GetValues(values);

                        for (int i = 0; i < countvalue; i++)
                        {
                            T val = (T)values[i];
                            listReturn.Add(val);
                        }
                    }
                }
                else
                {
                    while (reader.Read()) //baca datareader
                    {
                        entity = Activator.CreateInstance<T>();
                        foreach (PropertyInfo prop in entity.GetType().GetProperties())
                        {
                            for (int i = 0; i < reader.FieldCount; i++) //bandingkan kolomnya, antisipasi jika user select beberapa kolom aja sedangkan model ada banyak kolom
                            {
                                if (reader.GetName(i) == prop.Name)
                                    if (!object.Equals(reader[prop.Name], DBNull.Value))
                                    {
                                        prop.SetValue(entity, reader[prop.Name], null);
                                    }
                            }
                        }
                        listReturn.Add(entity);
                    }
                }
                IEnumerable<T> dataEnumerable = listReturn;
                return await Task.Run(() => dataEnumerable);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                    reader.Dispose();
                }
            }
        }

        /// <summary>
        /// Gets single object entity mapped from SqlDataReader based on sql query
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="query">Sql query</param>
        /// <param name="parameters"></param>
        /// <returns>Object</returns>
        protected async Task<T> MapQueryResult<T>(string query, params SqlParameter[] parameters) where T : class
        {
            return await Task.Run(() => this.MapQueryMultipleResult<T>(query, parameters).Result.FirstOrDefault());
            //return this.MapQueryMultipleResult<T>(query, parameters).FirstOrDefault();
        }

        protected async Task<T> MapQueryResult<T>(string query) where T : class
        {
            return await Task.Run(() => this.MapQueryMultipleResult<T>(query).Result.FirstOrDefault());
            //return this.MapQueryMultipleResult<T>(query).FirstOrDefault();
        }
        /// <summary>
        /// Gets IEnumerable of object entities mapped from SqlDataReader based on sql query
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="query">Sql query</param>
        /// <returns>IEnumerable of object</returns>
        protected async Task<IEnumerable<T>> MapQueryMultipleResult<T>(string query, params SqlParameter[] parameters) where T : class
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddRange(parameters);
                        IDataReader reader = command.ExecuteReader();
                        return await this.MapDataReader<T>(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }


        protected async Task<Int32> MapTotalRowCount(string spname)
        {
            Int32 intTotalProfile;
            using (SqlConnection connection = new SqlConnection(base.ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(spname, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        var reader = command.ExecuteReader();
                        reader.Read();
                        intTotalProfile = Convert.ToInt32(reader[0]);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex.InnerException);
                }
                finally
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
            return await Task.Run(()=>intTotalProfile);
        }

        /// <summary>
        /// Gets IEnumerable of object entities mapped from SqlDataReader based on sql query Without Parameter
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <returns></returns>
        protected async Task<IEnumerable<T>> MapQueryMultipleResult<T>(string query) where T : class
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        IDataReader reader = command.ExecuteReader();
                        return await this.MapDataReader<T>(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }


        /// <summary>
        /// Eksekusi Stored Procedure, yang mana hasil Kebalikan nya hanya satu row saja dengan banyak columns....
        /// </summary>
        /// <typeparam name="T"><b></b>Class untuk menampung hasil dari eksekusi stored procedure nya</typeparam>
        /// <param name="spName"><b></b>Nama Store Procedure nya</param>
        /// <param name="parameters"> SqlParameter, parameter yang ada di Stored Procedure nya</param>
        /// <returns></returns>
        protected async Task<T> MapStoredProcedureOneRow<T>(string spName, params SqlParameter[] parameters) where T : class
        {
            return await Task.Run(() => this.MapStoredProcedure<T>(spName, parameters).Result.FirstOrDefault());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="spName"></param>
        /// <returns></returns>
        protected async Task<T> MapStoredProcedureOneRow<T>(string spName) where T : class
        {
            return await Task.Run(() => this.MapStoredProcedure<T>(spName).Result.FirstOrDefault());
            //return this.MapQueryMultipleResult<T>(query).FirstOrDefault();
        }

        /// <summary>
        /// Mengeksekusi Store Procedure tanpa paramater.
        /// </summary>
        /// <typeparam name="T"> Class untuk menampung kebalikan dari hasil eksekusi</typeparam>
        /// <param name="storedProcedureName"> 'Nama Stored Procedure nya'</param>
        /// <returns></returns>
        private async Task<IEnumerable<T>> MapStoredProcedure<T>(string storedProcedureName) where T : class
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        IDataReader reader = command.ExecuteReader();
                        return await MapDataReader<T>(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        /// <summary>
        /// Gets IEnumerable of object entities mapped from SqlDataReader based on stored procedure that returns table
        /// </summary>
        /// <typeparam name="T">Type of object</typeparam>
        /// <param name="storedProcedureName">Stored Procedure name</param>
        /// <param name="parameters">Sql Parameters</param>
        /// <returns>IEnumerable of object</returns>
        protected async Task<IEnumerable<T>> MapStoredProcedure<T>(string storedProcedureName, params SqlParameter[] parameters) where T : class
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddRange(parameters);
                        IDataReader reader = command.ExecuteReader();
                        return await MapDataReader<T>(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        /// <summary>
        /// Gets Data Table based on stored procedure that returns table
        /// </summary>
        /// <param name="storedProcedureName">Stored procedure name</param>
        /// <param name="parameters">Sql parameters</param>
        /// <returns>Data Table</returns>
        protected DataTable ExecuteStoredProcedure(string storedProcedureName, params SqlParameter[] parameters)
        {
            try
            {
                DataTable table = new DataTable();
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (parameters.Length > 0)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        IDataReader reader = command.ExecuteReader();
                        table.Load(reader);
                    }
                }
                return table;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        /// <summary>
        /// Executes non query stored procedure
        /// </summary>
        /// <param name="storedProcedureName">Stored procedure name</param>
        /// <param name="parameters">Sql parameters</param>
        /// <returns>The number of rows affected</returns>
        protected async Task<int> ExecuteStoredProcedureNonQuery(string storedProcedureName, params SqlParameter[] parameters)
        {
            try
            {
                int i = 0;
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand(storedProcedureName, connection, transaction))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                if (parameters.Length > 0)
                                {
                                    command.Parameters.AddRange(parameters);
                                }
                                i = command.ExecuteNonQuery();
                                transaction.Commit();
                            }

                            return await Task.Run(()=>1); //tidak return i karena menghindari SET NOCOUNT ON di stored procedure
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw new Exception(ex.Message, ex.InnerException);
                        }
                        finally
                        {
                            transaction.Dispose();
                            connection.Close();
                            connection.Dispose();
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
        }
        bool _disposed;
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                _disposed = true;
            }
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~GenericDbProvider()
        {
            Dispose(false);
        }
    }
}

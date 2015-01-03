using System.Configuration;
using SoftFocusCenter.EncryptionWrapper;
using System.Data;
using System.Data.Common;
using Oracle.ManagedDataAccess.Client;

namespace SoFTLibrary.Framework.DataContext.Infrastructure
{
    public abstract class ConnectionStringx
    {
        private static readonly string SqlConnectionString = ConfigurationManager.ConnectionStrings["ModelSample"].ToString();
        private static readonly string OracleConnection = ConfigurationManager.ConnectionStrings["ModelSample"].ToString();

        protected DbCommand DCommand;
        protected IDataReader DReader;
        private OracleConnection _oracleDatabase;
        private string _connectionString;


        protected OracleConnection OracleDb
        {
            get
            {
                var connString = Encryption.Decrypt(OracleConnection);
                _oracleDatabase = new OracleConnection(connString);
                return _oracleDatabase;

            }
            set
            {
                _oracleDatabase = value;
            }
        }

        protected string ConnectionString
        {
            get
            {
                _connectionString = Encryption.Decrypt(SqlConnectionString);
                return _connectionString;
            }
        }

    }
}

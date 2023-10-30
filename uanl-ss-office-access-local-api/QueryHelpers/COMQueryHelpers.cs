using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uanl_ss_lib_office_access_local_api.QueryHelpers
{
    public static class COMQueryHelpers
    {
        public static string GetAccessColumnType(Type type)
        {
            switch (Type.GetTypeCode(type))
            {
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                    return "INTEGER";
                case TypeCode.Single:
                case TypeCode.Double:
                    return "DOUBLE";
                case TypeCode.Decimal:
                    return "DECIMAL";
                case TypeCode.Boolean:
                    return "YESNO";
                case TypeCode.DateTime:
                    return "DATETIME";
                case TypeCode.String:
                    return "VARCHAR(255)";
                case TypeCode.Byte:
                    return "BYTE";
                case TypeCode.SByte:
                    return "SBYTE";
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                    return "UNSIGNED INTEGER";
                case TypeCode.Char:
                    return "CHAR";
                case TypeCode.Object:
                    if (type == typeof(byte[]))
                        return "OLEOBJECT";
                    break;
            }
            return "VARCHAR(255)";
        }

        // CONSULTAS DE PROGRAMA
    }

    public class COMQueryObject<T>
    {
        private string TableName { get; set; }

        public COMQueryObject(Type T)
        {
            this.TableName = T.GetType().Name;
        }

        public string CreateTable() {
            return $"CREATE TABLE {TableName} (";
        }

        public string Insert()
        {
            return $"INSERT INTO {TableName} (=columns) VALUES (=values);";
        }

        public string Update()
        {
            return $"UPDATE {TableName} SET ";
        }

        public string Delete()
        {
            return $"DELETE * FROM {TableName} WHERE ID = @ID;";
        }

        public string Get() { 
            return $"SELECT * FROM {TableName} WHERE ID = @ID;";
        } 

        public string GetFiltered(string columnName)
        {
            return $"SELECT * FROM {TableName} WHERE {columnName} = @ColumnValue;";
        }

        public string GetAll() { 
            return $"SELECT * FROM {TableName};"; 
        }

        public string CreateFK() {
            return $"ALTER TABLE {TableName} ADD CONSTRAINT FK_{TableName}_=reftable FOREIGN KEY =refcolname REFERENCES =exttable =extcolumn;"; 
        }

        public string GetLast() { 
            return $"SELECT TOP 1 * FROM {TableName} ORDER BY ID DESC;"; 
        }
    }
}

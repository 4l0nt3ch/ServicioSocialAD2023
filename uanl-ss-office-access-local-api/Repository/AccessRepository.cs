using Microsoft.Office.Interop.Access;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using uanl_ss_lib_office_access_local_api.QueryHelpers;

namespace uanl_ss_lib_office_access_local_api.Repository
{
    public class AccessRepository<T>
    {
        private string connStr { get; set; }
        private List<T> listaObjetos { get; set; }
        private string QueryCreate { get; set; }
        private string QueryGet { get; set; }
        private string QueryGetAll { get; set; }
        private string QueryDelete { get; set; }
        private string QueryUpdate { get; set; }

        public AccessRepository(string conn, string queryGet, string queryGetAll, string queryCreate,
            string queryUpdate, string queryDelete)
        {
            this.connStr = conn;
            this.QueryGet = queryGet;
            this.QueryGetAll = queryGetAll;
            this.QueryCreate = queryCreate;
            this.QueryUpdate = queryUpdate;
            this.QueryDelete = queryDelete;
        }

        public void Create(T objeto)
        {
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();

                Type type = typeof(T);

                PropertyInfo[] props = type.GetProperties();

                string tableName = type.Name;
                string columnNames = string.Join(", ", props.Select(p => p.Name));
                string columnValues = string.Join(", ", props.Select(p => "@" + p.Name));

                using (OleDbCommand cmd = new OleDbCommand(QueryCreate, conn)) { 
                    
                    foreach (var prop in props)
                    {
                        cmd.Parameters.AddWithValue("@" + prop.Name, prop.GetValue(objeto));  
                    }

                    cmd.ExecuteNonQuery();
                    System.Diagnostics.Debug.WriteLine("Registro creado con éxito");

                }

                conn.Close();
            }
        }

        public List<T> ReadAll(int id)
        {
            if (listaObjetos == null)
            {
                listaObjetos = new List<T>();
            }
            else
            {
                listaObjetos.Clear();
            }

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();

                Type type = typeof(T);
                PropertyInfo[] props = type.GetProperties();

                string tableName = type.Name;

                using (OleDbCommand cmd = new OleDbCommand(QueryGetAll, conn))
                {
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            T obj = Activator.CreateInstance<T>();

                            foreach (var prop in props)
                            {
                                if (prop.Name != "id")
                                {
                                    prop.SetValue(obj, reader[prop.Name] != DBNull.Value ? reader[prop.Name] : null);
                                }
                            }

                            listaObjetos.Add(obj);  
                        }
                    }

                }

                conn.Close();
            }

            return listaObjetos;
        }

        public T Read(int id)
        {
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();

                Type type = typeof(T);
                PropertyInfo[] props = type.GetProperties();

                string tableName = type.Name;

                using (OleDbCommand cmd = new OleDbCommand(QueryGet, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {

                        if (reader.Read())
                        {
                            T obj = Activator.CreateInstance<T>();

                            foreach (var prop in props)
                            {
                                if (prop.Name != "Id")
                                {
                                    prop.SetValue(obj, reader[prop.Name] != DBNull.Value ? reader[prop.Name] : null);
                                }
                            }

                            return obj;
                        }

                    }
                }
                conn.Close();
            }
            return default(T);
        }

        public void Update(T objetoActualizado)
        {
            using (OleDbConnection conn = new OleDbConnection(connStr)) {
                
                conn.Open();

                Type type = typeof(T);
                PropertyInfo[] props = type.GetProperties();

                string tableName = type.Name;
                string queryUpdate = QueryUpdate;
                
                foreach (var prop in props)
                {
                    queryUpdate += $"{prop.Name} = @{prop.Name}, ";
                }

                queryUpdate = queryUpdate.TrimEnd(',', ' ');
                queryUpdate += " WHERE Id = @Id";

                using (OleDbCommand cmd = new OleDbCommand(queryUpdate,conn))
                {
                    foreach ( var prop in props)
                    {
                        cmd.Parameters.AddWithValue("@" + prop.Name, prop.GetValue(objetoActualizado));
                    }

                    cmd.ExecuteNonQuery();
                    System.Diagnostics.Debug.WriteLine("Registro actualizado con éxito");

                }

                conn.Close();
            }
        }

        public void Delete(int id)
        {
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();

                Type type = typeof(T);
                string tableName = type.Name;

                using (OleDbCommand cmd = new OleDbCommand(QueryDelete, conn))
                {

                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                    System.Diagnostics.Debug.WriteLine("Registro actualizado con éxito");

                }

                conn.Close();
            }
        }
    }
}

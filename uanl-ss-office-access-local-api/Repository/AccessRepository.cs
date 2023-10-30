using Microsoft.Office.Interop.Access;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Reflection;
using uanl_ss_lib_office_access_local_api.QueryHelpers;

namespace uanl_ss_lib_office_access_local_api.Repository
{
    public class AccessRepository<T>
    {
        private string connStr { get; set; }
        private List<T> listaObjetos { get; set; }
        private COMQueryObject<T> queryObj { get; set; }

        public AccessRepository(string conn, Type t)
        {
            this.connStr = conn;
            queryObj = new COMQueryObject<T>(t);
        }

        public void Create(T objeto)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();

                    Type type = typeof(T);
                    string queryIn = queryObj.CreateTable();

                    PropertyInfo[] props = type.GetProperties();

                    string columnNames = string.Join(", ", props.Select(p => p.Name));
                    string columnValues = string.Join(", ", props.Select(p => "@" + p.Name));

                    queryIn.Replace("=columns", columnNames);
                    queryIn.Replace("=values", columnValues);

                    using (OleDbCommand cmd = new OleDbCommand(queryIn, conn))
                    {

                        foreach (var prop in props)
                        {
                            cmd.Parameters.AddWithValue("@" + prop.Name, prop.GetValue(objeto));
                        }

                        cmd.ExecuteNonQuery();
                        System.Diagnostics.Debug.WriteLine($"Registro creado con éxito");

                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                return;
            }
            
        }

        public void SetForeignKey()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    Type type = typeof(T);
                    PropertyInfo[] props = type.GetProperties();

                    foreach (var prop in props)
                    {
                        string queryIn = queryObj.CreateFK();
                        string typeMeta = COMQueryHelpers.GetAccessColumnType(prop.PropertyType);

                        if (Type.GetTypeCode(type) == TypeCode.Object && typeMeta == "VARCHAR(255)")
                        {
                            queryIn.Replace("=reftable", prop.PropertyType.Name);
                            queryIn.Replace("=refcolname", prop.Name);
                            queryIn.Replace("=exttable", prop.PropertyType.Name);
                            queryIn.Replace("=extcolumn", "ID");

                            using (OleDbCommand cmd = new OleDbCommand(queryIn, conn))
                            {
                                cmd.ExecuteNonQuery();
                                System.Diagnostics.Debug.WriteLine($"Llave foránea definida con éxito");
                            }

                        }
                    }

                    conn.Close();

                }
            } catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                return;
            }
           

        }

        public List<T> ReadAll()
        {
            try
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

                    using (OleDbCommand cmd = new OleDbCommand(queryObj.GetAll(), conn))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                T obj = Activator.CreateInstance<T>();

                                foreach (var prop in props)
                                {
                                    if (prop.Name != "ID")
                                    {
                                        prop.SetValue(obj, reader[prop.Name] != DBNull.Value ? reader[prop.Name] : null);
                                    }
                                }

                                listaObjetos.Add(obj);
                            }
                        }

                        System.Diagnostics.Debug.WriteLine($"Registros actualizados con éxito");
                    }

                    conn.Close();
                }

                return listaObjetos;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                return default(List<T>);
            }
            
        }

        public List<T> ReadFilter(string columnName, object ColumnValue)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();

                    Type type = typeof(T);
                    PropertyInfo[] props = type.GetProperties();

                    string queryIn = queryObj.GetFiltered(columnName);

                    using (OleDbCommand cmd = new OleDbCommand(queryIn, conn))
                    {
                        cmd.Parameters.AddWithValue("@ColumnValue", ColumnValue);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            List<T> result = new List<T>();

                            while (reader.Read())
                            {
                                T obj = Activator.CreateInstance<T>();

                                foreach (var prop in props)
                                {
                                    if (prop.Name != columnName)
                                    {
                                        prop.SetValue(obj, reader[prop.Name] != DBNull.Value ? reader[prop.Name] : null);
                                    }
                                }

                                result.Add(obj);
                            }

                            if (result.Count > 0)
                            {
                                System.Diagnostics.Debug.WriteLine($"Registros leídos con éxito: {result.Count}");
                                return result;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }

            return new List<T>(); // Devuelve una lista vacía si no se encuentran registros o si hay errores.
        }

        public T Read(int id)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    string queryIn = queryObj.Get();

                    Type type = typeof(T);
                    PropertyInfo[] props = type.GetProperties();

                    using (OleDbCommand cmd = new OleDbCommand(queryIn, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", id);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                T obj = Activator.CreateInstance<T>();

                                foreach (var prop in props)
                                {
                                    if (prop.Name != "ID")
                                    {
                                        prop.SetValue(obj, reader[prop.Name] != DBNull.Value ? reader[prop.Name] : null);
                                    }
                                }

                                return obj;
                            }

                            System.Diagnostics.Debug.WriteLine($"Registro leido con éxito");
                        }
                    }
                    conn.Close();
                }
                return default(T);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                return default(T);
            }
            
        }

        public void Update(T objetoActualizado)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    Type type = typeof(T);
                    PropertyInfo[] props = type.GetProperties();

                    string queryIn = queryObj.Update();

                    foreach (var prop in props)
                    {
                        queryIn += $"{prop.Name} = @{prop.Name}, ";
                    }

                    queryIn = queryIn.TrimEnd(',', ' ');
                    queryIn += " WHERE ID = @ID;";

                    using (OleDbCommand cmd = new OleDbCommand(queryIn, conn))
                    {
                        foreach (var prop in props)
                        {
                            cmd.Parameters.AddWithValue("@" + prop.Name, prop.GetValue(objetoActualizado));
                        }

                        cmd.ExecuteNonQuery();
                        System.Diagnostics.Debug.WriteLine($"Registro actualizado con éxito");

                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                return;
            }
            
        }

        public void Delete(int id)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    string queryIn = queryObj.Delete();

                    Type type = typeof(T);
                    string tableName = type.Name;

                    using (OleDbCommand cmd = new OleDbCommand(queryIn, conn))
                    {

                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.ExecuteNonQuery();
                        System.Diagnostics.Debug.WriteLine($"Registro eliminado con éxito");

                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                return;
            }
            
        }

        public void CreateTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    string queryIn = queryObj.CreateTable();

                    Type type = typeof(T);
                    PropertyInfo[] props = type.GetProperties();

                    foreach (var prop in props)
                    {
                        string columnName = prop.Name;
                        string columnType = COMQueryHelpers.GetAccessColumnType(prop.PropertyType);

                        queryIn += $"{columnName} {columnType}, ";
                    }

                    queryIn = queryIn.TrimEnd(',', ' ');
                    queryIn += ");";

                    using (OleDbCommand cmd = new OleDbCommand(queryIn, conn))
                    {

                        cmd.ExecuteNonQuery();
                        System.Diagnostics.Debug.WriteLine($"Tabla creada con éxito.");
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                return;
            }
            
        }
    }
}

using Avaliacao3.Business.Interface;
using Avaliacao3.Model;
using Newtonsoft.Json;
using Npgsql;
using System.Data;
using System.Linq.Expressions;
using System.Reflection;

namespace Avaliacao3.DB
{
    public class SqlRawRepository<T> : IRepository<T> where T : Base_MD, new()
    {
        static Item dados = Config_JSON.LoadJson();
        NpgsqlConnection pgsqlConnection = null;
        static string connString = string.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",dados.Host, dados.Port, dados.User, dados.Password, dados.Database);
        public T Atualizar(T obj)
        {
            throw new NotImplementedException();
        }

        public T Buscar(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public T Criar(T obj)
        {
            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {             
                    PropertyInfo[] tipo = typeof(T).GetProperties();
                    List<string> propriedades = new List<string>();
                    foreach (PropertyInfo p in tipo)
                    {
                        propriedades.Add(p.Name);
                    }
                    pgsqlConnection.Open();

                    string cmdInserir = String.Format($"Insert Into {obj.GetType().Name.Replace("_MD", "").ToLower()}({obj.Propriedades()}) values({obj.ToString()})");

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdInserir, pgsqlConnection))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }
            return obj;
        }

        public T Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Query(Expression<Func<T, bool>> where = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> QuerySqlRaw(string sql)
        {
            DataSet ds = new DataSet();
            var ListaValores = new List<Dictionary<string, object>>();
            var ListaRetorno = new List<T>();
            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    pgsqlConnection.Open();

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(sql, pgsqlConnection))
                    {
                        Adpt.Fill(ds);
                        int qtdLinhas = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < qtdLinhas; i++)
                        {
                            foreach (DataColumn column in ds.Tables[0].Columns)
                            {
                                ListaValores.Add(new Dictionary<string, object>() { { column.ColumnName, ds.Tables[0].Rows[i][column.ColumnName] } });
                            }
                            var json = JsonConvert.SerializeObject(ListaValores).Replace("[", "").Replace("]", "").Replace("{", "").Replace("}", "");
                            json = "{" + json + "}";
                            ListaRetorno.Add(JsonConvert.DeserializeObject<T>(json));
                            ListaValores.Clear();
                        }                        
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }

            return ListaRetorno;
        }

    }
}

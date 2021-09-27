using System.Collections.Generic;
using System.Linq;
using API.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace API.Service
{
    public class ClienteService
    {
        private readonly Context _context;
        
        private IConfiguration Configuration {get;}

        public ClienteService(Context context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }

        public List<Cliente> ListarClientes()
        {
            return _context.Clientes.ToList();
        }

        public Cliente ProcurarCliente(int id)
        {
            return _context.Clientes.Find(id);
        }

        public void AdicionarCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void AtualizarCliente(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            _context.SaveChanges();
        }

        public void RemoverCliente(int id)
        {
            string sqlConn = Configuration.GetConnectionString("ConnectionDB");
            using (SqlConnection connection = new SqlConnection(sqlConn))
            {
                string query = "DELETE FROM Clientes WHERE ClienteId=" + id;
                SqlCommand command = new SqlCommand(query, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
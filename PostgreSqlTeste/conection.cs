using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace PostgreSqlTeste
{
    public class conection
    {
        public string Conexao(out bool conectado)
        {
            string msg;
            NpgsqlConnection con = new NpgsqlConnection("Server=Localhost;Username=postgres;Port=5432;Password=SOFTLOG;Database=CodeWave");

            try
            {
                con.Open();
                conectado = true;
                msg = "conectado";
                return msg;
            }
            catch (NpgsqlException ex)
            {
                con.Close();
                conectado = false;
                msg = "Exception:" + ex;
                return msg;
            }
            catch (Exception ex)
            {
                msg = "Exception:" + ex;
                conectado = false;
                return msg;
            }
        }
        public NpgsqlConnection Conexao()
        {
            
            NpgsqlConnection con = new NpgsqlConnection("Server=Localhost;Username=postgres;Port=5432;Password=SOFTLOG;Database=DataWave");

            try
            {
                con.Open();
                return con;
            }
            catch 
            {   
                con.Close();
                return con;
            }
        }
    }
}

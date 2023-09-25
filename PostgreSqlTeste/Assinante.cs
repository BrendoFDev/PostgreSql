using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using Correios.Net;
namespace PostgreSqlTeste
{
    public class Assinante
    {
        private const string TABLE_NAME = "T_ASSINANTE";
        public int id { get; set; }
        public string cpf { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }
        public string cep { get; set; }
        public string rua { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }

    }

    public class ActionAss
    {

        LoadList charge = new LoadList();
        Assinante ass = new Assinante();
        conection con = new conection();
        public NpgsqlDataReader QueryAssinante()
        {

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand("select * from t_assinante", con.Conexao());
                NpgsqlDataReader read = cmd.ExecuteReader();

                return read;
            }
            catch (NpgsqlException ex)
            {
                NpgsqlCommand cmd = new NpgsqlCommand("select * from t_assinante", con.Conexao());
                NpgsqlDataReader read = cmd.ExecuteReader();

                MessageBox.Show("Exception:" + ex.Message);
                return read;
            }
            catch (Exception ex)
            {
                NpgsqlCommand cmd = new NpgsqlCommand("select * from t_assinante", con.Conexao());
                NpgsqlDataReader read = cmd.ExecuteReader();

                MessageBox.Show("Exception:" + ex.Message);
                return read;
            }
        }
        public int QueryInsertAssinante(string nome, string senha, string cep, string rua, string bairro,
            string cidade, string estado, string cpf)
        {
            if (nome != "" || senha != "" || cep != "" || rua != "" || bairro != "" || cidade != "" || estado != "")
            {
                string query = "SELECT \"CPF\" FROM t_assinante where \"CPF\" ='" + cpf + "'";
                NpgsqlCommand cmd = new NpgsqlCommand(query, con.Conexao());
                cmd.Prepare();

                NpgsqlDataReader read = cmd.ExecuteReader();
                string verificacpf;
                int rows;
                while (read.Read())
                {  
                    
                    MessageBox.Show(cpf + " Já Está Cadastrado!","Erro Ao Cadastrar",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return 0;
                   
                }
                
                verificacpf = read[0].ToString();
                    if (verificacpf == cpf)
                    {
                      
                    }
                    else
                    {
                    
                        try
                        {
                            /*( "nome_Ass", "senha_Ass", "cep_Ass", "rua_Ass", "bairro_Ass", "cidade_Ass", "UF_Ass", "CPF")*/
                            query = "INSERT INTO t_assinante( \"nome_Ass\", \"senha_Ass\", \"cep_Ass\", \"rua_Ass\", \"bairro_Ass\"" +
                                ", \"cidade_Ass\", \"UF_Ass\", \"CPF\") values(@nome,@senha, @cep,@rua,@bairro, @cidade, @estado,@cpf)";

                            cmd = new NpgsqlCommand(query, con.Conexao());

                            cmd.Parameters.AddWithValue("@nome", nome);
                            cmd.Parameters.AddWithValue("@senha", senha);
                            cmd.Parameters.AddWithValue("@cep", cep);
                            cmd.Parameters.AddWithValue("@rua", rua);
                            cmd.Parameters.AddWithValue("@bairro", bairro);
                            cmd.Parameters.AddWithValue("@cidade", cidade);
                            cmd.Parameters.AddWithValue("@estado", estado);
                            cmd.Parameters.AddWithValue("@cpf", cpf);

                            rows = cmd.ExecuteNonQuery();
                            if(rows > 0)
                        {
                            MessageBox.Show("Cadastrado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return rows;
                        }
                        else
                        {
                            return 0;
                        }
             
                        }
                        catch (NpgsqlException ex)
                        {
                            MessageBox.Show("Exceção ocorreu:" + ex, "BRENDO SISTEMA", MessageBoxButtons.OK, MessageBoxIcon
                                 .Warning);
                            return 0;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Exceção ocorreu:" + ex, "BRENDO SISTEMA", MessageBoxButtons.OK, MessageBoxIcon
                                .Warning);
                            return 0;
                        }

                    }
                return 0;
            }
            else
            {
                MessageBox.Show("Complete  Todos Os Campos");
                return 0;
            }
        }
    }
}




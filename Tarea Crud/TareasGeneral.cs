using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Tarea_Crud
{
     class TareasGeneral
    {
        //Atributos 
        private string id; 
        private int  Carnet;
        private int  Nota1;
        private int Nota2;
        private int Nota3;
        private int Nota4;

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-R27RH76P\\SQLEXPRESS01;Initial Catalog=UMG;Integrated Security=True;Encrypt=False");

        public TareasGeneral()
        {
        }

        public TareasGeneral(string v, int carnet, int nota1, int nota2, int nota3, int nota4)
        {
            //Metodo constructor 
           this.Carnet = carnet;
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            this.Nota3 = nota3;
            this.Nota4 = nota4;
        }
        public int AgregarRegistro()
        {
            con.Open();
            SqlCommand consulta = new SqlCommand("INSERT INTO tareas VALUES (@Carnet, @Nota1, @Nota2, @Nota3, @Nota4)" , con);
            consulta.Parameters.AddWithValue ("Carnet", Carnet);
            consulta.Parameters.AddWithValue("Nota1", Nota1);
            consulta.Parameters.AddWithValue("Nota2", Nota2);
            consulta.Parameters.AddWithValue("Nota3", Nota3);
            consulta.Parameters.AddWithValue("Nota4", Nota4);

            int filasAfectadas = consulta.ExecuteNonQuery();
            Console.WriteLine($"Filas afectadas: {filasAfectadas}");
            con.Close();    

            return filasAfectadas; 
        }

    }
}

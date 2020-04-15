using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Datos
{
    public class EstampillaRepository
    {
        private readonly SqlConnection _connection;
        private readonly List<Estampilla> _personas = new List<Estampilla>();
        public EstampillaRepository(ConnectionManager connection)
        {
             _connection = connection._conexion;
        }

        public void Guardar(Estampilla estampilla)
        {
            using (var command = _connection.CreateCommand())
            {

                command.CommandText = @"Insert Into Copago (NumeroDeContrato,ObjetoDelContrato,ValorDelContrato,ApoyaEmergenciaCovid19,ValorEstampilla) 
                                        values (@NumeroDeContrato,ObjetoDelContrato,@ValorDelContrato,@ApoyaEmergenciaCovid19,@ValorEstampilla)";
                command.Parameters.AddWithValue("@NumeroDeContrato", estampilla.NumeroDeContrato);
                command.Parameters.AddWithValue("@ObjetoDelContrato", estampilla.ObjetoDelContrato);
                command.Parameters.AddWithValue("@ValorDelContrato", estampilla.ValorDelContrato);
                command.Parameters.AddWithValue("@ApoyaEmergenciaCovid19", estampilla.ApoyaEmergenciaCovid19);
                command.Parameters.AddWithValue("@ValorEstampilla", estampilla.ValorEstampilla);
                var filas = command.ExecuteNonQuery();
            }
        }

        public List<Estampilla> ConsultarTodos()
        {
            SqlDataReader dataReader;
            List<Estampilla> estampillas = new List<Estampilla>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from estampilla ";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Estampilla estampilla = DataReaderMapToPerson(dataReader);
                        estampillas.Add(estampilla);
                    }
                }
            }
            return estampillas;
        }

        private Estampilla DataReaderMapToPerson(SqlDataReader dataReader)
        {
            if(!dataReader.HasRows) return null;
            Estampilla estampilla = new Estampilla();
            estampilla.NumeroDeContrato = (string)dataReader["NumeroDeContrato"];
            estampilla.ObjetoDelContrato = (string)dataReader["ObjetoDelContrato"];
            estampilla.ValorDelContrato = (decimal)dataReader["ValorDelContrato"];
            estampilla.ApoyaEmergenciaCovid19 = (string)dataReader["ApoyaEmergenciaCovid19"];
            estampilla.ValorEstampilla = (decimal)dataReader["ValorEstampilla"];
            
            return estampilla;
        }
        
    }
}
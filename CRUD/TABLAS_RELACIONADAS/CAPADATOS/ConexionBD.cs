﻿using System.Data;
using System.Data.SqlClient;

namespace TABLAS_RELACIONADAS.CAPADATOS
{
    class ConexionBD
    {
        static private string CadenaConexion = "Server=DESKTOP-8J7J4KN\\SQLEXPRESS;DataBase=PRACTICA_TABLAS;Integrated Security=true";
        private SqlConnection Conexion= new SqlConnection(CadenaConexion);

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}

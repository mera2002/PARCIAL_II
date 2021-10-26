﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Parcial
{
    class Connection
    {
        private MySqlConnection conn =
            new MySqlConnection("Server= localhost;Database=bd;Uid=root;" +
                     "pwd=;SSL Mode=None");
        public MySqlCommand command;

        //abrir conexion
        public MySqlConnection openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        //cerrar la conexion
        public MySqlConnection closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            return conn;
        }

    }
}

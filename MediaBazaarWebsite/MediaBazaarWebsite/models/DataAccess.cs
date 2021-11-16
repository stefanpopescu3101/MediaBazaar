﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;

namespace MediaBazaarWebsite.models
{
    public class DataAccess
    {
        protected MySqlConnection connection;
        protected MySqlCommand command;
        protected MySqlDataReader dataReader;
        protected string query = "";

        public DataAccess()
        {


            string database = "Server=studmysql01.fhict.local;Uid=dbi467287;Database=dbi467287;Pwd=prj; SSL Mode=None;";

            this.connection = new MySqlConnection(database);
        }


        public void AddWithValue(string parameterName, object value)
        {
            this.command.Parameters.AddWithValue(parameterName, value);
        }

        public void NonQueryEx()
        {
            this.command.ExecuteNonQuery();
        }

        public void Close()
        {
            this.connection.Close();
        }
        public bool ConnOpen()
        {
            try
            {
                this.connection.Open();
                return true;
            }
            catch (MySqlException)
            {

                return false;
            }
        }

        public void SqlQuery(string queryText)
        {
            this.command = new MySqlCommand(queryText, this.connection);
        }

    }
}

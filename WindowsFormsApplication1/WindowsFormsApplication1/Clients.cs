/*
 * Kevin Borling
 * CSCD 306 | .Met Programming
 * WinForm Dating Service Part 2
 * 07/22/2013
 * Clients reads each client from the database and loads each one into an array list.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public class Clients : IEnumerable, IEnumerator
    {
        public int index;
        public ArrayList ClientList;

        public Clients(String database)
        {
            ClientList = new ArrayList();
 
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + database;
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Clients ORDER BY LastName, FirstName", conn);
            OleDbDataReader read = cmd.ExecuteReader();
            while (read.Read())
                {
                    Client c = new Client(read["FirstName"].ToString(),
                    read["LastName"].ToString(),
                    read["Sex"].ToString(),
                    int.Parse(read["Age"].ToString()),
                    read["FavoriteColor"].ToString(),
                    read["Hobby1"].ToString(),
                    read["Hobby2"].ToString(),
                    read["Photo"].ToString(),
                    int.Parse(read["ClientID"].ToString()));

                    ClientList.Add(c);
                }
                read.Close();
                conn.Close();
            
        }// End EVC


        public int Count
        {
            get { return ClientList.Count; }
        }
        public Client GetAClient(int p_clientID)
        {
            return (Client)ClientList[p_clientID];
        }
        public void AddAClient(Client p_client)
        {
            ClientList.Add(p_client);
            return;
        }
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }


        public void Reset()
        {
            index = -1;
        }
        public object Current { get; set; }

        object System.Collections.IEnumerator.Current
        {
            get { return ClientList[index]; }
        }

        public bool MoveNext()
        {
            if (index < ClientList.Count - 1)
            {
                index = index + 1;
                return true;
            }
            else
                return false;
        }//end MoveNext
 
    }

}

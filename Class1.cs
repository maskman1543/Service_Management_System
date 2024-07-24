using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Management_System
{
    internal class Class1
    {
        public static class GlobalVariables
        {
            public static string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\ServiceManagementSYstem.accdb;Persist Security Info=False;";
            public static string ConnectionString2 = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\ServiceManagementSystemC.accdb;Persist Security Info=False;";
            public static int JobOrderNumber;
            public static bool State;

        }
        public static int GetJobOrderID(string query)
        {
            int jobOrderID = -1; // Default value indicating an error or no result

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            jobOrderID = id;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return jobOrderID;
        }
    }
}

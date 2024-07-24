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
            public static int JobOrderNumber { get; set; }
            public static bool State;

        }
        public class JobOrderService
        {
            public int GetJobOrderIDByCustomerName(string customerName)
            {
                int jobOrderID = 0;

                // Use the correct connection string
                string connectionString = Class1.GlobalVariables.ConnectionString2;

                // SQL query to get the JobOrderID based on the customer's name
                string query = "SELECT JobOrderID FROM JobOrders WHERE CustomerName = @CustomerName";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@CustomerName", customerName);

                            // Debug: Output the query and parameters
                            Console.WriteLine("Executing query: " + query);
                            Console.WriteLine("CustomerName: " + customerName);

                            object result = command.ExecuteScalar();
                            if (result != null)
                            {
                                jobOrderID = Convert.ToInt32(result);
                            }
                            else
                            {
                                // Debug: If no job order ID is found
                                Console.WriteLine("No JobOrderID found for the given customer name.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle exception
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }

                // Debug: Output the retrieved JobOrderID
                Console.WriteLine("Retrieved JobOrderID: " + jobOrderID);

                return jobOrderID;
            }
        }



        public static int GetJobOrderID(string query)
        {
            int jobOrderID = -1; // Default value indicating an error or no result

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
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

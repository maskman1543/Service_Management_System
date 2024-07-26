using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_Management_System.POS
{
    public partial class Payment : Form
    {

        public Payment()
        {
            InitializeComponent();
            LoadData();

        }

        /*private void LoadData()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
                {
                    string query = "SELECT * FROM JobOrders"; // Adjust query as needed
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message);
            }
        }*/

        private void LoadData()//Load JobOrder Table to dataGridView1
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
                {
                    string query = "SELECT JobOrderID, CustomerName, CustomerContact, DateCreated, Vehicle, PlateNo, Subtotal, Tax, Total, Amount, Discount, Change, PaymentMethod, Status  FROM JobOrders WHERE Status = False";
                    ;
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }



        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            POSForm pOSForm = new POSForm();
            pOSForm.Show();
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            new POSForm().Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            string[] values = textBox5.Text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);


            if (values.Length > 0)
            {

                textBox3.Text = values.Length > 0 ? values[0] : string.Empty;
            }
            else
            {

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            CalculateAndDisplayChange();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            CalculateAndDisplayChange();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow clickedRow = dataGridView1.Rows[e.RowIndex];

                var totalCell = clickedRow.Cells["Total"];
                var subtotalCell = clickedRow.Cells["Subtotal"];
                var taxCell = clickedRow.Cells["Tax"];

                if (totalCell.Value != null && subtotalCell.Value != null && taxCell.Value != null)
                {
                    textBox5.Text = totalCell.Value.ToString();
                    textBox1.Text = subtotalCell.Value.ToString();
                    textBox2.Text = taxCell.Value.ToString();
                }
                else
                {
                    textBox5.Text = string.Empty;
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                }
            }
        }

        private void CalculateAndDisplayChange()
        {
            decimal value1, value2;

            bool isValidValue1 = decimal.TryParse(textBox5.Text, out value1);
            bool isValidValue2 = decimal.TryParse(textBox4.Text, out value2);

            if (isValidValue1 && isValidValue2)
            {
                decimal result = value1 - value2;
                changelbl.Text = result.ToString("F2");
            }
            else
            {
                changelbl.Text = "Invalid input";
            }
        }


        private void changelbl_TextChanged(object sender, EventArgs e)
        {
            //CalculateAndDisplayChange();
        }

        private void button2_Click(object sender, EventArgs e)//cashbutton
        {
            UpdatePaymentMethod("Cash");

        }

        private void btncreditCard_Click(object sender, EventArgs e)
        {
            UpdatePaymentMethod("CreditCard");

        }

        private void btndebitCard_Click(object sender, EventArgs e)
        {
            UpdatePaymentMethod("DebitCard");

        }

        private void btngiftCard_Click(object sender, EventArgs e)
        {

            UpdatePaymentMethod("GiftCard");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["JobOrderID"].Value);
                decimal value2, changeValue;

                if (decimal.TryParse(textBox4.Text, out value2) && decimal.TryParse(changelbl.Text, out changeValue))
                {
                    int JobOrderNumber = Class1.GlobalVariables.JobOrderNumber; // Get the current JobOrderNumber

                    using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
                    {
                        string updateJobOrderQuery = "UPDATE JobOrders SET Amount = @Amount, Change = @Change, Status = @Status WHERE JobOrderID = @JobOrderID";
                        OleDbCommand updateJobOrderCommand = new OleDbCommand(updateJobOrderQuery, connection);
                        //updateJobOrderCommand.Parameters.AddWithValue("@SalesID", JobOrderNumber);
                        updateJobOrderCommand.Parameters.AddWithValue("@Amount", value2);
                        updateJobOrderCommand.Parameters.AddWithValue("@Change", changeValue);
                        updateJobOrderCommand.Parameters.AddWithValue("@Status", true); // Assuming Status is a boolean field
                        updateJobOrderCommand.Parameters.AddWithValue("@JobOrderID", selectedRowId);

                        string insertSalesHistoryQuery = @"
                INSERT INTO SalesHistory (CustomerName, CustomerContact, DateCreated, Vehicle, PlateNo, Amount, SubTotal, Tax, Total, Discount, Change, PaymentMethod, Status)
                SELECT CustomerName, CustomerContact, DateCreated, Vehicle, PlateNo, Amount, SubTotal, Tax, Total, Discount, Change, PaymentMethod, Status
                FROM JobOrders WHERE JobOrderID = @JobOrderID";
                        OleDbCommand insertSalesHistoryCommand = new OleDbCommand(insertSalesHistoryQuery, connection);
                        insertSalesHistoryCommand.Parameters.AddWithValue("@JobOrderID", selectedRowId);

                        try
                        {
                            connection.Open();
                            updateJobOrderCommand.ExecuteNonQuery();
                            insertSalesHistoryCommand.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error submitting data: " + ex.Message);
                            return;
                        }
                    }

                    LoadDataGridView();
                    MessageBox.Show("Data submitted successfully!");
                }
                else
                {
                    MessageBox.Show("Invalid values in textBox4 or changelbl.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to submit.");
            }
        }

        private void LoadDataGridView()
        {
            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
            {
                string query = "SELECT * FROM JobOrders";
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void UpdatePaymentMethod(string paymentMethod)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["JobOrderID"].Value);

                using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
                {
                    string query = "UPDATE JobOrders SET PaymentMethod = @PaymentMethod WHERE JobOrderID = @JobOrderID";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                    command.Parameters.AddWithValue("@JobOrderID", selectedRowId);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating PaymentMethod: " + ex.Message);
                        return;
                    }
                }

                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Please select a row to update the payment method.");
            }
        }

        private void btnGenReceipt_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to generate the receipt.");
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (.pdf)|*.pdf";
                saveFileDialog.Title = "Save Receipt";
                saveFileDialog.FileName = "Receipt.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                        string customerName = selectedRow.Cells["CustomerName"].Value?.ToString() ?? "";
                        string customerContact = selectedRow.Cells["CustomerContact"].Value?.ToString() ?? "";
                        string vehicle = selectedRow.Cells["Vehicle"].Value?.ToString() ?? "";
                        string plateNo = selectedRow.Cells["PlateNo"].Value?.ToString() ?? "";

                        string receiptId = Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
                        string date = DateTime.Now.ToString("MM/dd/yyyy");
                        string time = DateTime.Now.ToString("hh:mm tt");

                        string subtotal = textBox1.Text;
                        string tax = textBox2.Text;
                        string total = textBox3.Text;
                        string amountReceived = textBox4.Text;
                        string change = changelbl.Text;

                        Document doc = new Document(PageSize.A4, 50, 50, 25, 25);
                        PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                        doc.Open();

                        iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance("logo.png");
                        logo.ScaleToFit(200f, 200f);
                        logo.Alignment = Element.ALIGN_LEFT;
                        doc.Add(logo);

                        /* Paragraph header = new Paragraph("ServiceFlow\nSERVICE MANAGEMENT SYSTEM\n\n", FontFactory.GetFont("Arial", 18, iTextSharp.text.Font.BOLD));
                        header.Alignment = Element.ALIGN_CENTER;
                        doc.Add(header); */

                        // Add a horizontal line
                        iTextSharp.text.pdf.draw.LineSeparator line = new iTextSharp.text.pdf.draw.LineSeparator(1f, 100f, BaseColor.BLUE, Element.ALIGN_CENTER, -2);
                        doc.Add(new Chunk(line));

                        doc.Add(new Paragraph("\n"));

                        doc.Add(new Paragraph($"RECEIPT ID: {receiptId}", FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD)));
                        doc.Add(new Paragraph($"DATE: {date}", FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD)));
                        doc.Add(new Paragraph($"TIME: {time}", FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD)));
                        doc.Add(new Paragraph("\n"));
                        doc.Add(new Paragraph($"CUSTOMER NAME: {customerName}", FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD)));
                        doc.Add(new Paragraph($"CONTACT NUMBER: {customerContact}", FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD)));
                        doc.Add(new Paragraph("\n"));

                        iTextSharp.text.pdf.draw.LineSeparator line1 = new iTextSharp.text.pdf.draw.LineSeparator(1f, 100f, BaseColor.BLUE, Element.ALIGN_CENTER, -2);
                        doc.Add(new Chunk(line));

                        doc.Add(new Paragraph("\n"));
                        doc.Add(new Paragraph("\n"));

                        PdfPTable table = new PdfPTable(2);
                        table.WidthPercentage = 100;
                        float[] widths = new float[] { 50f, 50f };
                        table.SetWidths(widths);

                        table.AddCell(new PdfPCell(new Phrase("VEHICLE", FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD))) { HorizontalAlignment = Element.ALIGN_CENTER, BackgroundColor = BaseColor.LIGHT_GRAY });
                        table.AddCell(new PdfPCell(new Phrase("PLATE NUMBER", FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD))) { HorizontalAlignment = Element.ALIGN_CENTER, BackgroundColor = BaseColor.LIGHT_GRAY });

                        table.AddCell(new PdfPCell(new Phrase(vehicle, FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.NORMAL))) { HorizontalAlignment = Element.ALIGN_CENTER });
                        table.AddCell(new PdfPCell(new Phrase(plateNo, FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.NORMAL))) { HorizontalAlignment = Element.ALIGN_CENTER });

                        doc.Add(table);

                        doc.Add(new Paragraph("\n"));
                        doc.Add(new Paragraph("\n"));

                        PdfPTable totalsTable = new PdfPTable(2);
                        totalsTable.WidthPercentage = 100;
                        float[] totalsWidths = new float[] { 50f, 50f };
                        totalsTable.SetWidths(totalsWidths);

                        iTextSharp.text.pdf.draw.LineSeparator line2 = new iTextSharp.text.pdf.draw.LineSeparator(1f, 100f, BaseColor.BLUE, Element.ALIGN_CENTER, -2);
                        doc.Add(new Chunk(line));

                        doc.Add(new Paragraph("\n"));
                        doc.Add(new Paragraph("\n"));

                        totalsTable.AddCell(new PdfPCell(new Phrase("SUBTOTAL:", FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD))) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                        totalsTable.AddCell(new PdfPCell(new Phrase(subtotal, FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.NORMAL))) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });

                        totalsTable.AddCell(new PdfPCell(new Phrase("TAX:", FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD))) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                        totalsTable.AddCell(new PdfPCell(new Phrase(tax, FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.NORMAL))) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });

                        totalsTable.AddCell(new PdfPCell(new Phrase("TOTAL:", FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD))) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                        totalsTable.AddCell(new PdfPCell(new Phrase(total, FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.NORMAL))) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });

                        totalsTable.AddCell(new PdfPCell(new Phrase("AMOUNT RECEIVED:", FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD))) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                        totalsTable.AddCell(new PdfPCell(new Phrase(amountReceived, FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.NORMAL))) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });

                        totalsTable.AddCell(new PdfPCell(new Phrase("CHANGE:", FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD))) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                        totalsTable.AddCell(new PdfPCell(new Phrase(change, FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.NORMAL))) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });

                        doc.Add(totalsTable);

                        iTextSharp.text.pdf.draw.LineSeparator line3 = new iTextSharp.text.pdf.draw.LineSeparator(1f, 100f, BaseColor.BLUE, Element.ALIGN_CENTER, -2);
                        doc.Add(new Chunk(line));

                        doc.Add(new Paragraph("\n"));
                        doc.Add(new Paragraph("\n"));
                        doc.Add(new Paragraph("\n"));
                        Paragraph thankYou = new Paragraph("Thank you for your purchase!", FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.BOLD));
                        thankYou.Alignment = Element.ALIGN_CENTER;
                        doc.Add(thankYou);

                        doc.Close();

                        MessageBox.Show("Receipt generated successfully and saved to " + saveFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while generating the receipt: " + ex.Message);
                    }
                }
            }

        }
        /*
        private void btndelRecord_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            // Confirm delete action
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected row?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int rowIndex = selectedRow.Index;

                    // Assuming the primary key column name is "ID" and it's in the database table
                    // Change "ID" to the actual primary key column name and data type
                    int recordId = Convert.ToInt32(selectedRow.Cells["JobOrderID"].Value);
                    string customerName = selectedRow.Cells["CustomerName"].Value.ToString();
                    string customerContact = selectedRow.Cells["CustomerContact"].Value.ToString();
                    string vehicle = selectedRow.Cells["Vehicle"].Value.ToString();
                    string plateNo = selectedRow.Cells["PlateNo"].Value.ToString();
                    decimal amount = Convert.ToDecimal(selectedRow.Cells["Amount"].Value);
                    decimal subTotal = Convert.ToDecimal(selectedRow.Cells["SubTotal"].Value);
                    decimal tax = Convert.ToDecimal(selectedRow.Cells["Tax"].Value);
                    decimal total = Convert.ToDecimal(selectedRow.Cells["Total"].Value);
                    decimal discount = Convert.ToDecimal(selectedRow.Cells["Discount"].Value);
                    decimal change = Convert.ToDecimal(selectedRow.Cells["Change"].Value);
                    string paymentMethod = selectedRow.Cells["PaymentMethod"].Value.ToString();
                    string status = selectedRow.Cells["Status"].Value.ToString();

                    // Remove the row from the DataGridView
                    dataGridView1.Rows.RemoveAt(rowIndex);

                    // Insert the record into JobOrders table
                    using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
                    {
                        connection.Open();

                        // Insert into JobOrders table
                        string insertQuery = @"
                    INSERT INTO JobOrders (
                        JobOrderID, 
                        CustomerName, 
                        CustomerContact, 
                        DateCreated, 
                        Vehicle, 
                        PlateNo, 
                        Amount, 
                        SubTotal, 
                        Tax, 
                        Total, 
                        Discount, 
                        Change, 
                        PaymentMethod, 
                        Status
                    ) VALUES (
                        @JobOrderID, 
                        @CustomerName, 
                        @CustomerContact, 
                        @DateCreated, 
                        @Vehicle, 
                        @PlateNo, 
                        @Amount, 
                        @SubTotal, 
                        @Tax, 
                        @Total, 
                        @Discount, 
                        @Change, 
                        @PaymentMethod, 
                        @Status
                    )";

                        using (OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@JobOrderID", recordId); // Assuming JobOrderID is the same as the record ID
                            insertCommand.Parameters.AddWithValue("@CustomerName", customerName);
                            insertCommand.Parameters.AddWithValue("@CustomerContact", customerContact);
                            insertCommand.Parameters.AddWithValue("@DateCreated", DateTime.Now); // Adjust as necessary
                            insertCommand.Parameters.AddWithValue("@Vehicle", vehicle);
                            insertCommand.Parameters.AddWithValue("@PlateNo", plateNo);
                            insertCommand.Parameters.AddWithValue("@Amount", amount);
                            insertCommand.Parameters.AddWithValue("@SubTotal", subTotal);
                            insertCommand.Parameters.AddWithValue("@Tax", tax);
                            insertCommand.Parameters.AddWithValue("@Total", total);
                            insertCommand.Parameters.AddWithValue("@Discount", discount);
                            insertCommand.Parameters.AddWithValue("@Change", change);
                            insertCommand.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                            insertCommand.Parameters.AddWithValue("@Status", status);

                            insertCommand.ExecuteNonQuery();
                        }

                        // Delete the record from SalesHistory table
                        string deleteQuery = "DELETE FROM JobOrder WHERE JobOrderID = @JobOrderID"; // Change ID to your actual primary key column name
                        using (OleDbCommand deleteCommand = new OleDbCommand(deleteQuery, connection))
                        {
                            deleteCommand.Parameters.AddWithValue("@JobOrderID", recordId);
                            deleteCommand.ExecuteNonQuery();
                        }
                    }

                    // Refresh dataGridView1
                    LoadData(); // Call a method to reload data into dataGridView1

                    MessageBox.Show("Record deleted and moved to JobOrders successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the record: " + ex.Message);
                }
            }
        }*/


        private void btndelRecord_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            // Confirm delete action
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected row?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int rowIndex = selectedRow.Index;

                    // Retrieve values from the selected row
                    int recordId = Convert.ToInt32(selectedRow.Cells["JobOrderID"].Value);
                    string customerName = selectedRow.Cells["CustomerName"].Value.ToString();
                    string customerContact = selectedRow.Cells["CustomerContact"].Value.ToString();
                    DateTime dateCreated = Convert.ToDateTime(selectedRow.Cells["DateCreated"].Value);
                    string vehicle = selectedRow.Cells["Vehicle"].Value.ToString();
                    string plateNo = selectedRow.Cells["PlateNo"].Value.ToString();
                    decimal amount = Convert.ToDecimal(selectedRow.Cells["Amount"].Value);
                    decimal subTotal = Convert.ToDecimal(selectedRow.Cells["SubTotal"].Value);
                    decimal tax = Convert.ToDecimal(selectedRow.Cells["Tax"].Value);
                    decimal total = Convert.ToDecimal(selectedRow.Cells["Total"].Value);
                    decimal discount = Convert.ToDecimal(selectedRow.Cells["Discount"].Value);
                    decimal change = Convert.ToDecimal(selectedRow.Cells["Change"].Value);
                    string paymentMethod = selectedRow.Cells["PaymentMethod"].Value.ToString();
                    string status = selectedRow.Cells["Status"].Value.ToString();

                    // Remove the row from the DataGridView
                    dataGridView1.Rows.RemoveAt(rowIndex);

                    // Insert the record into JobOrders table
                    using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
                    {
                        connection.Open();

                        // Insert into JobOrders table
                        string insertQuery = @"
                    INSERT INTO JobOrders (
                        JobOrderID, 
                        CustomerName, 
                        CustomerContact, 
                        DateCreated, 
                        Vehicle, 
                        PlateNo, 
                        Amount, 
                        SubTotal, 
                        Tax, 
                        Total, 
                        Discount, 
                        Change, 
                        PaymentMethod, 
                        Status
                    ) VALUES (
                        @JobOrderID, @CustomerName, @CustomerContact, @DateCreated, @Vehicle, @PlateNo, @Amount, @Subtotal, @Tax, @Total, @Discount, @Change, PaymentMethod, @Status
                    )";

                        using (OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.Add("@JobOrderID", OleDbType.Integer).Value = recordId;
                            insertCommand.Parameters.Add("@CustomerName", OleDbType.VarChar).Value = customerName;
                            insertCommand.Parameters.Add("@CustomerContact", OleDbType.VarChar).Value = customerContact;
                            insertCommand.Parameters.Add("@DateCreated", OleDbType.Date).Value = dateCreated; // Corrected parameter type
                            insertCommand.Parameters.Add("@Vehicle", OleDbType.VarChar).Value = vehicle;
                            insertCommand.Parameters.Add("@PlateNo", OleDbType.VarChar).Value = plateNo;
                            insertCommand.Parameters.Add("@Amount", OleDbType.Currency).Value = amount;
                            insertCommand.Parameters.Add("@Subtotal", OleDbType.Currency).Value = subTotal;
                            insertCommand.Parameters.Add("@Tax", OleDbType.Currency).Value = tax;
                            insertCommand.Parameters.Add("@Total", OleDbType.Currency).Value = total;
                            insertCommand.Parameters.Add("@Discount", OleDbType.Currency).Value = discount;
                            insertCommand.Parameters.Add("@Change", OleDbType.Currency).Value = change;
                            insertCommand.Parameters.Add("@PaymentMethod", OleDbType.VarChar).Value = paymentMethod;
                            insertCommand.Parameters.Add("@Status", OleDbType.VarChar).Value = status;

                            insertCommand.ExecuteNonQuery();
                        }

                        // Delete the record from JobOrder table
                        string deleteQuery = "DELETE FROM JobOrder WHERE JobOrderID = @ID";
                        using (OleDbCommand deleteCommand = new OleDbCommand(deleteQuery, connection))
                        {
                            deleteCommand.Parameters.Add("@ID", OleDbType.Integer).Value = recordId;
                            deleteCommand.ExecuteNonQuery();
                        }
                    }

                    // Refresh dataGridView1
                    LoadData(); // Call a method to reload data into dataGridView1

                    MessageBox.Show("Record deleted and moved to JobOrders successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the record: " + ex.Message);
                }
            }
        }


    }
}

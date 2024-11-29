using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PhoneNote
{   enum RowState
    {
        Existed,
        Now,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Form1 : Form
    {
        DataBase database = new DataBase();
        int selectedRow;
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("surname", "Фамилия");
            dataGridView1.Columns.Add("naming", "Имя");
            dataGridView1.Columns.Add("patronym", "Отчество");
            dataGridView1.Columns.Add("number", "Номер телефона");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from information";
            SqlCommand command = new SqlCommand(queryString, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }
       
        private void addAbonent_Click(object sender, EventArgs e)
        {
            Add_Form addfrm = new Add_Form();
            addfrm.ShowDialog();
        }
        private void Updating()
        {
            database.openConnection();
            for(int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[5].Value;
                if (rowState == RowState.Existed)
                continue;

                if (rowState == RowState.Deleted)
                {
                var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                var deleteQuery = $"delete from information where id = {id}";
                var command = new SqlCommand(deleteQuery, database.getConnection());
                command.ExecuteNonQuery();
                }
                if(rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var surname = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var patronym = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var number = dataGridView1.Rows[index].Cells[4].Value.ToString();

                    var changeQuary = $"update information set surname = '{surname}', naming = '{name}', patronym = '{patronym}', number = '{number}' where id = '{id}'";
                    var command = new SqlCommand(changeQuary, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }
        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = textBox_id.Text;
            var surname = textBox_surname.Text;
            var name = textBox_naming.Text;
            var patronym = textBox_patronym.Text;
            decimal number;
            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (decimal.TryParse(textBox_number.Text, out number))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, surname, name, patronym, number);
                    dataGridView1.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Номер телефона должен иметь числовой формат!");
                }
            }
        }

        private void makeAbonent_Click(object sender, EventArgs e)
        {
            Change();
        }
        private void deleteAbonent_Click(object sender, EventArgs e)
        {
            deleteRow();
            ClearFields();
        }

        private void deleteRow()
               {
                   int index = dataGridView1.CurrentCell.RowIndex;
                   dataGridView1.Rows[index].Visible = false;
                   if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
                   {
                       dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
                       return;
                   }
            dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
               }
        
        
        private void refresh_Click(object sender, EventArgs e)
        {
           RefreshDataGrid(dataGridView1);
           ClearFields();

        }

        private void добавитьСведенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Form addfrm = new Add_Form();
            addfrm.ShowDialog();
        }

        

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"select * from information where concat(id, surname, naming, patronym, number) like '%" + poisk_box.Text + "%'";
            SqlCommand com = new SqlCommand(searchString, database.getConnection());
            database.openConnection();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }

            read.Close();
        }
        private void poisk_box_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }
        
        private void btn_Update_Click(object sender, EventArgs e)
        {
            Updating();
            ClearFields();
        }
        private void ClearFields()
        {
            textBox_id.Text = "";
            textBox_surname.Text = "";
            textBox_naming.Text = "";
            textBox_patronym.Text = "";
            textBox_number.Text = "";

        }
        private void clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if(e.RowIndex >= 0)
            { 
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox_id.Text = row.Cells[0].Value.ToString();
                textBox_surname.Text = row.Cells[1].Value.ToString(); 
                textBox_naming.Text = row.Cells[2].Value.ToString();
                textBox_patronym.Text = row.Cells[3].Value.ToString();
                textBox_number.Text = row.Cells[4].Value.ToString();

            }
        }

        
    }  
}

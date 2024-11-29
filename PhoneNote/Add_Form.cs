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

namespace PhoneNote
{
    public partial class Add_Form : Form
    {

        DataBase database = new DataBase();

        public Add_Form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void save_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var surname = textBox1.Text;
            var name = textBox2.Text;
            var patronym = textBox3.Text;
            decimal number ;
            if (decimal.TryParse(textBox4.Text, out number)){ 
                 var addQuery = $"insert into information (surname, naming, patronym, number) values ('{surname}', '{name}', '{patronym}', '{number}')";
                 var command = new SqlCommand(addQuery, database.getConnection());
                 command.ExecuteNonQuery();
                 MessageBox.Show("Запись успешно создана!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Номер телефона должен иметь числовой формат!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            database.closeConnection();
        }

        
    }
}

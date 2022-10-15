using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form_Authorization : Form
    {
        public Form_Authorization()
        {
            InitializeComponent();
        }

        private void button_authorization_Click(object sender, EventArgs e)
        {
            string string_Connection = "server = 10.90.12.110;port = 33333;user = st_3_20_5;database = is_3_20_st5_KURS;password = 64570049;";

            MySqlConnection connection = new MySqlConnection(string_Connection);

            try
            {
                //открытие соединения
                connection.Open();

                //запрос для поиска пользователя по данным из textbox
                string string_findUser = $"SELECT * FROM users WHERE user_login = '{textBox_login.Text}' AND user_password = '{textBox_password.Text}'";

                //создание эземпляра класса MySqlCommand для выполнения запроса
                MySqlCommand command_findUser = new MySqlCommand(string_findUser, connection);

                //создание экземпляра класса DataTable для помещения в таблицу данных о пользователе
                DataTable data_user = new DataTable();

                //заполнение таблицы
                data_user.Load(command_findUser.ExecuteReader());

                //проверка на наличие данных в таблице
                if (data_user.Rows.Count > 0)
                {
                    //запись данных о пользователе в переменные
                    var user_name = data_user.Rows[0][1].ToString();
                    var user_surname = data_user.Rows[0][3].ToString();

                    //вывод приветственного сообщения
                    MessageBox.Show($"Здравствуйте, {user_name} {user_surname}", "Успешная вторизация!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    //вывод ошибки при отсутсвии данных в DataTable
                    MessageBox.Show("Пользователь не найден!\nПроверьте достоверность введённых вами данных","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                //вывод ошибки
                MessageBox.Show($"Неизвестная ошибка\n\nКод ошибки: {ex}","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                //закрытие соединения
                connection.Close();
            }
        }
    }
}

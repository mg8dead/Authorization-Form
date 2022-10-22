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


        private void button_authorization_Click(object sender, EventArgs e) //кнопка авторизации
        {
            //строка подключения к серверу с бд
            string string_Connection = "server = chuc.caseum.ru;port = 33333;user = st_3_20_5;database = is_3_20_st5_KURS;password = 64570049;";
            //создание экземпляра класса MySqlConnection для подключения к серверу с бд
            MySqlConnection connection = new MySqlConnection(string_Connection);

            try
            {
                //открытие соединения
                connection.Open();

                //строка запроса для поиска пользователя по данным из textbox
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
                    int user_profession_id = Int32.Parse(data_user.Rows[0][5].ToString());

                    //вывод приветственного сообщения
                    MessageBox.Show($"Здравствуйте, {user_name} {user_surname}", "Успешная вторизация!",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    if (user_profession_id == 1)//открытие формы для админа
                    {
                        Form_Admin form_next = new Form_Admin();
                        form_next.Show();
                    }
                    if (user_profession_id == 2)//открытие формы для работников клиники (врачи, хирурги)
                    {
                        Form_Personal form_next = new Form_Personal();
                        form_next.Show();
                    }
                    if (user_profession_id == 3)//открытие формы для работников регистратуры клиники
                    {
                        Form_Registratura form_next = new Form_Registratura();
                        form_next.Show();
                    }

                    this.Hide();
                }
                else
                {
                    //вывод ошибки при отсутсвии данных в DataTable
                    MessageBox.Show("Пользователь не найден!\nПроверьте достоверность введённых вами данных","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                //вывод не известной ошибки
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

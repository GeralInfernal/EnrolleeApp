using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Data;

namespace EnrolleeApp
{
    public class Sqlce_db
    {
        public Sqlce_db()
        {

        }

        private SqlCeConnection conn;

        /// <summary>
        /// Текущее соединение
        /// </summary>
        public SqlCeConnection Conn { get => conn; set => conn = value; }

        /// <summary>
        /// Обновление базы данных (для режима отладки)
        /// </summary>
        /// <returns></returns>
        public bool Sqlce_Upgrade()
        {
            try
            {
                SqlCeEngine qert = new SqlCeEngine("Data Source=LocalDB.sdf;Encrypt Database=True;Password=e5Dgq6!mG4nfC3-pl-4Fjd; " +
                    "File Mode = Exclusive; Persist Security Info = False; ");
                qert.Upgrade();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Открытие соединения с локальной СУБД
        /// </summary>
        /// <returns></returns>
        public bool OpenConnection()
        {
            try
            {
                conn = new SqlCeConnection("Data Source=LocalDB.sdf;Encrypt Database=True;Password=e5Dgq6!mG4nfC3-pl-4Fjd; " +
                    "File Mode = Exclusive; Persist Security Info = False; ");
                conn.Open();
                return true;
            }
            catch
            {
                MessageBox.Show("Критическая ошибка соединения с локальной базой данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Закрывает текущее соединение
        /// </summary>
        public void CloseConnection()
        {
            Conn.Close();
        }

        /// <summary> 
        /// Проверка пароля администратора
        /// </summary>
        /// <param name="str">Проверяемая строка</param>
        /// <returns></returns>
        public bool CheckPassword_Admin(string str)
        {
            string sql = "SELECT s_admin_pass FROM system;";
            SqlCeCommand com = new SqlCeCommand(sql, Conn);
            SqlCeDataReader reader = com.ExecuteReader();
            reader.Read();   
            if (reader[0].ToString() != null)
            {    
                string password = reader[0].ToString();
                reader.Close();
                if (str.Equals(password)) { return true; }
                else { return false; }
            }
            reader.Close();
            return false;
        }

        /// <summary>
        /// Проверка пароля пользователя
        /// </summary>
        /// <param name="str">Проверяемая строка</param>
        /// <returns></returns>
        public bool CheckPassword_User(string str)
        {
            string sql = "SELECT s_user_pass FROM system;";
            SqlCeCommand com = new SqlCeCommand(sql, Conn);
            SqlCeDataReader reader = com.ExecuteReader();
            reader.Read();
            if (reader[0].ToString() != null)
            {
                string password = reader[0].ToString();
                reader.Close();
                if (str.Equals(password)) { return true; }
                else { return false; }
            }
            reader.Close();
            return false;
        }

        /// <summary>
        /// Установка нового пароля администратора
        /// </summary>
        /// <param name="newpass">Новый пароль</param>
        /// <returns></returns>
        public bool SetPassword_Admin(string newpass)
        {
            try
            {
                string sql = "UPDATE system SET s_admin_pass = '" + newpass + "'; ";
                SqlCeCommand com = new SqlCeCommand(sql, Conn);
                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Установка нового пароля пользователя
        /// </summary>
        /// <param name="newpass">Новый пароль</param>
        /// <returns></returns>
        public bool SetPassword_User(string newpass)
        {
            try
            {
                string sql = "UPDATE system SET s_user_pass = '" + newpass + "'; ";
                SqlCeCommand com = new SqlCeCommand(sql, Conn);
                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Запуск запроса на текущем подключении
        /// </summary>
        /// <param name="sql_comm">Текст запроса</param>
        /// <returns></returns>
        public bool RunQuery(string sql_comm, out DataTable dt)
        {
            try
            {
                SqlCeDataAdapter da = new SqlCeDataAdapter(sql_comm, Conn);
                dt = new DataTable();
                da.Fill(dt);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = null;
                return false;
            }
        }

        /// <summary>
        /// Получить наборы соединений
        /// </summary>
        /// <param name="dt">Заполняемая таблица</param>
        /// <returns></returns>
        public bool Get_connections(out DataTable dt)
        {
            try
            {
                SqlCeDataAdapter da = new SqlCeDataAdapter("select p_id, p_name, p_serv, p_user, p_db, p_port, p_pass, p_auto from connections order by p_id DESC;", Conn);
                dt = new DataTable();
                da.Fill(dt);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = null;
                return false;
            }
        }

        /// <summary>
        /// Получить номер активного набора
        /// </summary>
        /// <param name="p_id">Номер набора</param>
        /// <returns></returns>
        public bool Get_curr_preset_id(out string p_id)
        {
            try
            {
                string str = "SELECT current_table FROM system;";
                SqlCeCommand com = new SqlCeCommand(str, Conn);
                SqlCeDataReader dr = com.ExecuteReader();
                dr.Read();
                p_id = dr[0].ToString();
                dr.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                p_id = null;
                return false;
            }
        }

        /// <summary>
        /// Получить активный набор
        /// </summary>
        /// <param name="p_id">Активный набор</param>
        /// <param name="dt">Заполняемая таблица</param>
        /// <returns></returns>
        public bool Get_curr_preset(string p_id, out DataTable dt)
        {
            try
            {
                string str = "SELECT p_name, p_serv, p_user, p_db, p_port, p_pass, p_auto FROM connections where p_id = " + p_id + ";";
                SqlCeDataAdapter da = new SqlCeDataAdapter(str, Conn);
                dt = new DataTable();
                da.Fill(dt);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = null;
                return false;
            }
        }

        /// <summary>
        /// Задает активный набор
        /// </summary>
        /// <param name="p_id">Идентификатор</param>
        /// <returns></returns>
        public bool Set_curr_preset(string p_id)
        {
            try
            {
                string str = "UPDATE system SET current_table = " + p_id + ";";
                SqlCeCommand com = new SqlCeCommand(str, Conn);
                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #region preset

        /// <summary>
        /// Добавить подключение
        /// </summary>
        /// <param name="preset">Название</param>
        /// <param name="server">Адрес сервера</param>
        /// <param name="user">Пользователь</param>
        /// <param name="db">База данных</param>
        /// <param name="port">Порт</param>
        /// <param name="pass">Пароль</param>
        /// <param name="auto">Автоподключение</param>
        /// <returns></returns>
        public bool Add_preset(string preset, string server, string user, string db, string port, string pass, string auto)
        {
            try
            {
                string str = "INSERT INTO connections (p_name, p_serv, p_user, p_db, p_port, p_pass, p_auto) " +
                    "VALUES('"+ preset + "','" + server + "','" + user + "','" + db + "'," + port + ",'" + pass + "'," + auto + ");";
                SqlCeCommand com = new SqlCeCommand(str, Conn);
                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Обновляет подключение
        /// </summary>
        /// <param name="id">Обновляемая запись</param>
        /// <param name="preset">Название</param>
        /// <param name="server">Адрес сервера</param>
        /// <param name="user">Пользователь</param>
        /// <param name="db">База данных</param>
        /// <param name="port">Порт</param>
        /// <param name="pass">Пароль</param>
        /// <param name="auto">Автоподключение</param>
        /// <returns></returns>
        public bool Update_preset(string id, string preset, string server, string user, string db, string port, string pass, string auto)
        {
            try
            {
                string str = "UPDATE connections SET p_name = '" + preset + "', p_serv = '" + server + "', p_user = '" + user + "', " +
                    "p_db = '" + db + "', p_port = " + port + ", p_pass = '" + pass + "', p_auto = " + auto + " WHERE p_id = " + id + "; ";
                SqlCeCommand com = new SqlCeCommand(str, Conn);
                com.ExecuteNonQuery();
                return true;
            }
            catch 
            {
                MessageBox.Show("При обновлении набора настроек произошла ошибка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Удаляет подключение
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool Delete_preset(string target)
        {
            try
            {
                string str = "DELETE FROM connections WHERE p_name = '" + target + "';";
                SqlCeCommand com = new SqlCeCommand(str, Conn);
                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        /// <summary>
        /// Загружает журнал событий
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Get_log(out DataTable dt)
        {
            try
            {
                string str = "Select log_id, log_event, CONVERT(nvarchar(10), log_date, 8) + ' ' + CONVERT(nvarchar(10), log_date, 3) AS log_date, log_desc FROM log order by log_id desc; ";
                SqlCeDataAdapter da = new SqlCeDataAdapter(str, Conn);
                dt = new DataTable();
                da.Fill(dt);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = null;
                return false;
            }
        }

        /// <summary>
        /// Добавить запись в локальный журнал событий
        /// </summary>
        /// <param name="_event">Событие</param>
        /// <param name="_desc">Описание</param>
        /// <returns></returns>
        public bool Add_log(string _event, string _desc)
        {
            try
            {
                string str = "INSERT INTO log (log_event, log_desc) values ('"+ _event + "','" + _desc + "');";
                SqlCeCommand com = new SqlCeCommand(str, Conn);
                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Clear_log()
        {
            try
            {
                string str = "Delete FROM log;";
                SqlCeCommand com = new SqlCeCommand(str, Conn);
                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


/*
        public bool Get_log(out DataTable dt)
        {
            try
            {
                string str = "Select log_id, log_event, CONVERT(datetime, log_date, 8) AS log_time, CONVERT(datetime, log_date, 6) AS log_date, log_desc FROM log;";
                SqlCeDataAdapter da = new SqlCeDataAdapter(str, Conn);
                dt = new DataTable();
                return true;
            }
            catch
            {

            }
        }*/
    }
}

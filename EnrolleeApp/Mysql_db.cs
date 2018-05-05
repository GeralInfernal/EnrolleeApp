using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace EnrolleeApp
{
    public class Mysql_db
    {
        public Mysql_db()
        {

        }
        private MySqlConnection mysql_conn;

        /// <summary>
        /// Представляет текущее соединение
        /// </summary>
        public MySqlConnection Conn { get => mysql_conn; set => mysql_conn = value; }


        /// <summary>
        /// Соединение к базе данных с параметрами по-умолчанию.
        /// Возврящает true при успешном соединении. 
        /// Показывает сообщение об ошибке и возвращает false при неудаче.
        /// </summary>
        /// <returns></returns>
        public bool ConnectToDatabase()
        {
            try
            {
                string serverName = "localhost";
                string userName = "root";
                string dbName = "enrolleeDB";
                string port = "3306";
                string password = "101010";
                string connStr = "server=" + serverName +
                    ";user=" + userName +
                    ";database=" + dbName +
                    ";port=" + port +
                    ";password=" + password + ";";
                mysql_conn = new MySqlConnection(connStr);
                mysql_conn.Open();
                //успешное соединение
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        /// <summary>
        /// Соединение к базе данных с заданными параметрами.
        /// Возврящает true при успешном соединении. 
        /// Показывает сообщение об ошибке и возвращает false при неудаче.
        /// </summary>
        /// <param name="serverName"></param>
        /// <param name="userName"></param>
        /// <param name="dbName"></param>
        /// <param name="port"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool ConnectToDatabase(string serverName = "localhost", string userName = "root",
                                              string dbName = "enrolleeDB", string port = "3306", string password = "1010")
        {
            try
            {
                string str = "server=" + serverName +
                    ";user=" + userName +
                    ";database=" + dbName +
                    ";port=" + port +
                    ";password=" + password + ";";
                Conn = new MySqlConnection(str);
                Conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void CloseConnection()
        {
            try
            {
                Conn.Close();
            }
            catch { }
        }

        #region Универсальные исполнители запросов

        public bool RunQuery(string sql, out DataTable dt)
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(sql, Conn);
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

        public bool RunAggregateQuery(string sql, out string result)
        {
            try
            {
                MySqlCommand comm = new MySqlCommand(sql, Conn);
                MySqlDataReader dr = comm.ExecuteReader();
                dr.Read();
                result = dr[0].ToString();
                dr.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = null;
                return false;
            }
        }

        public bool RunCommand(string sql)
        {
            try
            {
                MySqlCommand comm = new MySqlCommand(sql, Conn);
                comm.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #endregion

        public bool Get_log(out DataTable dt)
        {
            try
            {
                string str = "select log_id, Log_event, DATE_FORMAT(Log_datime, '%T %d.%m.%Y') as Log_datime, Log_desc from log order by log_id desc; ";
                MySqlDataAdapter da = new MySqlDataAdapter(str, Conn);
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

        public bool Add_log(string _event, string _desc)
        {
            try
            {
                string str = "INSERT INTO log (Log_datime, Log_event, Log_desc) values (NOW(), '" + _event + "','" + _desc + "'); ";
                MySqlCommand comm = new MySqlCommand(str, Conn);
                comm.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool Clear_log()
        {
            try
            {
                string str = "DELETE FROM log; ";
                MySqlCommand comm = new MySqlCommand(str, Conn);
                comm.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        #region Получить таблицу

        public bool Get_komis(out DataTable dt)
        {
            try
            {
                string str = "select * from komis;";
                MySqlDataAdapter da = new MySqlDataAdapter(str, Conn);
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

        public bool Get_base(out DataTable dt)
        {
            try
            {
                string str = "select * from base;";
                MySqlDataAdapter da = new MySqlDataAdapter(str, Conn);
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

        public bool Get_polity(out DataTable dt)
        {
            try
            {
                string str = "select * from polity;";
                MySqlDataAdapter da = new MySqlDataAdapter(str, Conn);
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

        public bool Get_docs(out DataTable dt)
        {
            try
            {
                string str = "select Doc_id, Doc_type, Doc_sernum, DATE_FORMAT(Doc_date, '%d.%m.%Y') as Doc_date from docs;";
                MySqlDataAdapter da = new MySqlDataAdapter(str, Conn);
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

        public bool Get_lang(out DataTable dt)
        {
            try
            {
                string str = "Select * from lang;";
                MySqlDataAdapter da = new MySqlDataAdapter(str, Conn);
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
        
        public bool Get_discipline(out DataTable dt)
        {
            try
            {
                string str = "Select * from discipline;";
                MySqlDataAdapter da = new MySqlDataAdapter(str, Conn);
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

        public bool Get_spec(out DataTable dt)
        {
            try
            {
                string str = "";
                MySqlDataAdapter da = new MySqlDataAdapter(str, Conn);
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

        public bool Get_military(out DataTable dt)
        {
            try
            {
                string str = "select military.M_id, abit.FIO, military.M_type, military.M_docinform from military " +
                    "INNER JOIN abit ON military.M_abit = abit.id; ";
                MySqlDataAdapter da = new MySqlDataAdapter(str, Conn);
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

        public bool Get_military_as_is(out DataTable dt)
        {
            try
            {
                string str = "select * from military; ";
                MySqlDataAdapter da = new MySqlDataAdapter(str, Conn);
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

        #endregion


    }
}

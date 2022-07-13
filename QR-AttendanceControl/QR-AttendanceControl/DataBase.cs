using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace QR_AttendanceControl
{
    class DataBase
    {
        public static SqlConnection GetConnection()
        {
            string sql = (ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString);

            SqlConnection connection = new SqlConnection(sql);
            try
            {
                connection.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Connection is not established\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return connection;
        }

        public static void AddStudent(Student student)
        {
            string sql = "INSERT INTO Students VALUES (@id, @name, @surname, @middle_name)";
            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@id", student.Id);
            command.Parameters.AddWithValue("@name", student.Name);
            command.Parameters.AddWithValue("@surname", student.Surname);
            command.Parameters.AddWithValue("@middle_name", student.MiddleName);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Student not added\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
        }

        public static void AddStudentFromAttendance(Student student)
        {
            string sql = "INSERT INTO StudentsAttendance VALUES (@student_id, @date_time)";
            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(sql, connection);

            DateTime date = DateTime.Now;

            command.Parameters.AddWithValue("@student_id", student.Id);
            command.Parameters.AddWithValue("@date_time", $"{date.Year}.{date.Month}.{date.Day} {date.Hour}:{date.Minute}:{date.Second}");

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Student not added\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
        }

        public static bool CheckingId(string id)
        {
            string sql = "SELECT Students.id FROM Students WHERE id = @StudentId";
            SqlConnection connection = GetConnection();

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            SqlCommand commandSelect = new SqlCommand(sql, connection);
            commandSelect.Parameters.AddWithValue("StudentId", id);

            dataAdapter.SelectCommand = commandSelect;
            dataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                return false;
            }

            return true;
        }

        public static void UpdateStudent(Student student, string id)
        {
            string sql = "UPDATE Students SET id = @studentNewId, name = @studentName, surname = @studentSurname, middle_name = @studentMiddleName WHERE Id = @studentId";
            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@studentId", id);
            command.Parameters.AddWithValue("@studentNewId", student.Id);
            command.Parameters.AddWithValue("@studentName", student.Name);
            command.Parameters.AddWithValue("@studentSurname", student.Surname);
            command.Parameters.AddWithValue("@studentMiddleName", student.MiddleName);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Student not update\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
        }

        public static void DeleteStudent(string id)
        {
            string sql = "DELETE FROM Students WHERE id = @studentId";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@studentId", id);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Student not delete\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
        }

        public static void DeleteStudentsFromAttendance()
        {
            string sql = "DELETE FROM StudentsAttendance";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Student not delete\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
        }
        public static void ShowAndSearch(string query, DataGridView dataGridView)
        {
            string sql = query;
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            connection.Close();
        }
        public static void Show(string query, DataGridView dataGridView)
        {
            string sql = query;
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            connection.Close();
        }
    }
}

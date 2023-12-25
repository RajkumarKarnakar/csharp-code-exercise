using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models
{
    public class Student
    {
        [Key]
        [Required]
        public int StudentNo { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Section { get; set; }
        [Required]
        public string? Branch { get; set; }
        [Required, EmailAddress]
        public string? Email { get; set; }

        public static Student GetSingleStudent(int id)
        {
            var student = new Student();
            SqlConnection sqlConnection = new SqlConnection();
            // sqlConnection.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentMVC;Integrated Security=True;";
            sqlConnection.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentMVC;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM Student where StudentNo={id}", sqlConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("before reader" + id);
                if (reader.Read())
                {
                    student.StudentNo = reader.GetInt32(0);
                    student.Name = reader.GetString(1);
                    Console.WriteLine("in getSingleStudent" + student.Name);
                    student.Section = reader.GetString(2);
                    student.Branch = reader.GetString(3);
                    student.Email = reader.GetString(4);
                }
                Console.WriteLine("after reader");
                reader.Close();
            }
            catch (Exception ex)
            {   //exception
                Console.WriteLine(ex.Message);
            }
            finally { sqlConnection.Close(); }
            return student;
        }

        public static List<Student> GetAllStudent()
        {
            var students = new List<Student>();
            //sql connection
            SqlConnection sqlConnection = new SqlConnection();
            // sqlConnection.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentMVC;Integrated Security=True;";
           sqlConnection.ConnectionString= "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentMVC;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            try
            {
                sqlConnection.Open();
                //SqlCommand cmd = new SqlCommand();
               // cmd.CommandType = System.Data.CommandType.Text;
               // cmd.CommandText = "SELECT * FROM Student";
                SqlCommand cmd = new SqlCommand("SELECT * FROM Student", sqlConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("here");
                while (reader.Read())
                {
                    students.Add(new Student { StudentNo = reader.GetInt32(0), Name = reader.GetString(1), Section = reader.GetString(2), Branch = reader.GetString(3), Email = reader.GetString(4) });
                }
                reader.Close();

            }
            catch (Exception ex)
            {   //exception
                Console.WriteLine(ex.Message);
            }
            finally { sqlConnection.Close(); }
            return students;
        }
        public static void EditDetails(int id, Student student)
        {

            Student student1 = new Student();
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentMVC;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"UPDATE Student SET Name={student.Name}," +
                        $"Section={student.Section},Branch={student.Branch},Email={student.Email} WHERE StudentNo={id}";

                cmd.ExecuteNonQuery();

                //cmd.CommandText = $"SELECT * FROM Student WHERE Id={id}";
                //SqlDataReader reader = cmd.ExecuteReader();
                //Console.WriteLine("here");
                //if (reader.Read())
                //{
                //    student1 = (new Student { StudentNo = reader.GetInt32(0), Name = reader.GetString(1), Section = reader.GetString(2), Branch = reader.GetString(3), Email = reader.GetString(4) });
                //    reader.Close();

                //    SqlCommand cmd1 = new SqlCommand();
                //    cmd1.CommandType = System.Data.CommandType.Text;
                //    cmd1.CommandText = $"UPDATE Student SET Name={student1.Name}," +
                //        $"Section={student1.Section},Brach={student1.Branch},Email={student1.Email} WHERE StudentNo={student1.StudentNo}";
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { sqlConnection.Close(); }

        }


    }
}

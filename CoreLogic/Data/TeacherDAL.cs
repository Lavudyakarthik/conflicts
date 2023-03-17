using CoreLogic.Model;
using System;
using System.Collections.Generic;

namespace CoreLogic.Data;

class TeacherDAL : BaseDAL
{
    //todo
   
        public int Create(Teacher item)
        {
            string qry = $"INSERT INTO Teacher VALUES ({item.Id}, '{item.Name}', '{item.City}')";

            int rowsAffected = ExecuteNonQuery(qry);

            return rowsAffected;
        }
        public List<Student> Retrieve()
        {
            var qry = "select * from student";

            var dataTable = ExecuteQuery(qry);

            var studentsList = new List<Student>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                var student  = new Student();

                student.Id = (int)dataRow["id"];
                student.Name = (string)dataRow["name"];
               
                studentsList.Add(student);
            }
            return studentsList;
        }
        public int Update(Student item)
        {
            var qry = $"UPDATE Student SET Name = '{item.Name}' WHERE id = {item.Id};";

            int rowsAffected = ExecuteNonQuery(qry);

            return rowsAffected;
        }
        public int Delete(int id)
        {
            var qry = $"DELETE FROM Student WHERE id = {id};";

            int rowsAffected = ExecuteNonQuery(qry);

            return rowsAffected;
        }
   
}

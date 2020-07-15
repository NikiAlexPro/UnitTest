using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_lab_15.Mock
{
    public class DownloadMock
    {
        public static List<Group> GetGroups()
        {
            var groups = new List<Group>();
            groups.Add(new Group { special = "1-ИВТ", department = "ИиПО", nmb = 1 });
            groups.Add(new Group { special = "2-ИВТ", department = "ИиПО", nmb = 2 });
            groups.Add(new Group { special = "3-ИВТ", department = "ИиПО", nmb = 3 });
            return groups;
        }
    }

    public static class AddTeacherMock
    {
        //public static bool AddTeacher(this ModelTeachers model, string firstName, string lastName, string phone, string exp, string special)
        public static bool AddTeacher(string firstName, string lastName, string phone, string exp, string special, string department, int nmb)
        {
            /*
            if (model.Groups.Find(special) == null)
            {
                return false;
            }
            */
            Teacher teacher = new Teacher { Group = new Group() };
            teacher.first_name = firstName;
            teacher.last_name = lastName;
            teacher.phone = phone;
            teacher.exp = exp;
            //teacher.special = special;
            teacher.Group.special = special;
            teacher.Group.department = department;
            teacher.Group.nmb = nmb;
            return true;

            /*
            try
            {
                model.Teachers.Add(teacher);
                model.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
            */
        }
    }

    public class SearchMock
    {
        public static Teacher GetTeacher(string searchText)
        {

            //поиск
            //string searchname = searchText;

            Teacher teacher = new Teacher { Group = new Group() };
            teacher.first_name = searchText;
            teacher.last_name = "XELA";
            teacher.phone = "9999999";
            teacher.exp = "master";
            //teacher.special = special;
            teacher.Group.special = "10-ПРИ";
            teacher.Group.department = "ИиПО";
            teacher.Group.nmb = 9999;
            return teacher;

        }
    }
}

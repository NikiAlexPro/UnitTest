using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_lab_15v2.Mock
{
    public class GroupDB
    {
        public static List<Group> GetGroups()
        {
            var modelTeacher = new ModelTeachers();
            List<Group> Groups = modelTeacher.Groups.ToList();
            return Groups;
        }
    }

    public static class AddTeacherDB
    {
        //public static bool AddTeacher(this ModelTeachers model, string firstName, string lastName, string phone, string exp, string special)
        public static bool AddTeacher(Group group, string firstName, string lastName, string phone, string exp)
        {
            var model = new ModelTeachers();
            var teacher = new Teacher { Group = new Group() };
            teacher.first_name = firstName;
            teacher.last_name = lastName;
            teacher.phone = phone;
            teacher.exp = exp;
            teacher.Group = group;
            teacher.special = group.special;

            //teacher.Group.special = group.special;
            //teacher.Group.department = group.department;
            //teacher.Group.nmb = group.nmb;

            //model.Teachers.Add(teacher);
            //model.SaveChanges();
            return true;
        }
    }

    public class SearchDB
    {
        public static Teacher GetTeacher(string searchText)
        {

            //поиск
            //string searchname = searchText;

            var model = new ModelTeachers();
            var teacher = new Teacher { Group = new Group() };
            var teach = model.Teachers.FirstOrDefault(b => b.first_name.Contains(searchText));
            teacher.first_name = teach.first_name;
            teacher.last_name = teach.last_name;
            teacher.phone = teach.phone;
            teacher.exp = teach.exp;
            teacher.Group.special = teach.Group.special;
            teacher.Group.department = teach.Group.department;
            teacher.Group.nmb = teach.Group.nmb;
            return teacher;

        }
    }
}

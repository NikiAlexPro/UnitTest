using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_lab_5
{
    public class Course
    {
        private List<Group> groups = new List<Group>();
        private List<Teacher> teachers = new List<Teacher>();
        private List<WorkLoad> workLoads = new List<WorkLoad>();
        #region [Properties]
        public List<Group> Groups
        {
            get { return groups; }
            set { Groups = value; }
        }
        public List<Teacher> Teachers
        {
            get { return teachers; }
            set { Teachers = value; }
        }
        public List<WorkLoad> WorkLoads
        {
            get { return workLoads; }
            set { WorkLoads = value; }
        }
        #endregion
        #region[Methods]
        public string GiveInformationObjectAboutTeacher(Teacher teacher, List<WorkLoad> loads)
        {
            //var workload = new List<WorkLoad>();
            //workload.FindAll(s => s.Teacher.Name == teacher.Name).Select(s => s.Object).ToList();
            //workload.AddRange(workLoads.Where(s => s.Teacher.Name == teacher.Name).Select(s => s.ClassType));
            //clients.AddRange(_settlements.Where(s => s.Room == room).Select(s => s.Client).Distinct().ToList());
            //workload.Find(WorkLoads.Where(s => s.Teacher.Name == teacher.Name))


            var found = loads.Find(item => item.Teacher.Name == teacher.Name);
            
            return found.Object;
            
        }
        #endregion

        

    }
}

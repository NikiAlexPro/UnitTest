using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Csharp_lab_5;

namespace UnitTestLab_5
{
    /// <summary>
    /// Сводное описание для CourseTest
    /// </summary>
    [TestClass]
    public class CourseTest
    {
        public CourseTest()
        {
            //
            // TODO: добавьте здесь логику конструктора
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Получает или устанавливает контекст теста, в котором предоставляются
        ///сведения о текущем тестовом запуске и обеспечивается его функциональность.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Дополнительные атрибуты тестирования
        //
        // При написании тестов можно использовать следующие дополнительные атрибуты:
        //
        // ClassInitialize используется для выполнения кода до запуска первого теста в классе
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // ClassCleanup используется для выполнения кода после завершения работы всех тестов в классе
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // TestInitialize используется для выполнения кода перед запуском каждого теста 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // TestCleanup используется для выполнения кода после завершения каждого теста
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        /// <summary>
        /// Тест конструктора Course
        /// </summary>
        [TestMethod]
        public void CourseConstructorTest()
        {
            var target = new Course();
            Assert.IsInstanceOfType(target, typeof(Course));
        }

        /// <summary>
        /// Тест поля list Group
        /// </summary>
        [TestMethod]
        public void GroupListTest()
        {
            var target = new Course();
            Group group1 = new Group { Specialty = "ИВТ-18", Department = "ФИТ", NumberOfStudents = 10 };
            Group group2 = new Group { Specialty = "ПРИ-18", Department = "ФИТ", NumberOfStudents = 15 };
            target.Groups.Clear();
            target.Groups.Add(group1);
            target.Groups.Add(group2);
            Assert.AreEqual(2, target.Groups.Count);
        }

        /// <summary>
        /// Тест поля list Teacher
        /// </summary>
        [TestMethod]
        public void TeacherListTest()
        {
            var target = new Course();
            Teacher teacher1 = new Teacher { Surname = "Фам1", Name = "Имя1", Patronymic = "Отч1", Experience = 10, Phone = 000 };
            Teacher teacher2 = new Teacher { Surname = "Фам2", Name = "Имя2", Patronymic = "Отч2", Experience = 20, Phone = 200 };
            target.Teachers.Clear();
            target.Teachers.Add(teacher1);
            target.Teachers.Add(teacher2);
            Assert.AreEqual(2, target.Teachers.Count);
        }

        /// <summary>
        /// Тест поля list WorkLoad
        /// </summary>
        [TestMethod]
        public void WorkLoadListTest()
        {
            var target = new Course();
            Teacher teacher1 = new Teacher { Surname = "Фам1", Name = "Имя1", Patronymic = "Отч1", Experience = 10, Phone = 000 };
            Teacher teacher2 = new Teacher { Surname = "Фам2", Name = "Имя2", Patronymic = "Отч2", Experience = 20, Phone = 200 };
            target.Teachers.Clear();
            target.Teachers.Add(teacher1);
            target.Teachers.Add(teacher2);
            Group group1 = new Group { Specialty = "ИВТ-18", Department = "ФИТ", NumberOfStudents = 10 };
            Group group2 = new Group { Specialty = "ПРИ-18", Department = "ФИТ", NumberOfStudents = 15 };
            target.Groups.Clear();
            target.Groups.Add(group1);
            target.Groups.Add(group2);
            target.WorkLoads.Clear();
            target.WorkLoads.Add(new WorkLoad { Teacher = teacher1, Group = group1, NumberOfHours = 100, Object = "Предмет1", ClassType = "Лекция", Payment = 9 });
            target.WorkLoads.Add(new WorkLoad { Teacher = teacher2, Group = group2, NumberOfHours = 100, Object = "Предмет2", ClassType = "Практика", Payment = 10 });
            Assert.AreEqual(2, target.WorkLoads.Count);
        }

        /// <summary>
        /// Тест метода GiveInformationObjectAboutTeacher
        /// </summary>
        [TestMethod]
        public void GiveInformationObjectAboutTeacherTest()
        {
            var target = new Course();
            Teacher teacher1 = new Teacher { Surname = "Фам1", Name = "Имя1", Patronymic = "Отч1", Experience = 10, Phone = 000 };
            Teacher teacher2 = new Teacher { Surname = "Фам2", Name = "Имя2", Patronymic = "Отч2", Experience = 20, Phone = 200 };
            target.Teachers.Clear();
            target.Teachers.Add(teacher1);
            target.Teachers.Add(teacher2);
            Group group1 = new Group { Specialty = "ИВТ-18", Department = "ФИТ", NumberOfStudents = 10 };
            Group group2 = new Group { Specialty = "ПРИ-18", Department = "ФИТ", NumberOfStudents = 15 };
            target.Groups.Clear();
            target.Groups.Add(group1);
            target.Groups.Add(group2);
            WorkLoad workload1 = new WorkLoad { Teacher = teacher1, Group = group1, NumberOfHours = 100, Object = "Предмет1", ClassType = "Лекция", Payment = 9 };
            WorkLoad workload2 = new WorkLoad { Teacher = teacher2, Group = group2, NumberOfHours = 100, Object = "Предмет2", ClassType = "Практика", Payment = 10 };
            target.WorkLoads.Clear();
            target.WorkLoads.Add(workload1);
            target.WorkLoads.Add(workload2);
            Assert.AreEqual(workload1.Object, target.GiveInformationObjectAboutTeacher(teacher1, target.WorkLoads));

        }
    }
}

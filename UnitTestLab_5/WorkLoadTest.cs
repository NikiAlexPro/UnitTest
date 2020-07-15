using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Csharp_lab_5;

namespace UnitTestLab_5
{
    /// <summary>
    /// Сводное описание для WorkLoadTest
    /// </summary>
    [TestClass]
    public class WorkLoadTest
    {
        public WorkLoadTest()
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
        /// Тест для конструктора WorkLoad
        /// </summary>
        [TestMethod]
        public void WorkLoadConstructorTest()
        {
            var target = new WorkLoad();
            Assert.IsInstanceOfType(target, typeof(WorkLoad));
        }

        /// <summary>
        /// Тест для поля Teacher
        /// </summary>
        [TestMethod]
        public void TeacherTest()
        {
            var target = new WorkLoad();
            var expected = new Teacher() { Surname = "Фамилия", Name = "Имя", Patronymic = "Отчество", Experience = 10, Phone = 00000000000 };
            target.Teacher = expected;
            Teacher actual = target.Teacher;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тест для поля Group
        /// </summary>
        [TestMethod]
        public void GroupTest()
        {
            var target = new WorkLoad();
            var expected = new Group() { Specialty = "18ИВТ", Department = "ФИТ", NumberOfStudents = 10 };
            target.Group = expected;
            Group actual = expected;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тест для поля NumberOfHours
        /// </summary>
        [TestMethod]
        public void NumberOfHoursTest()
        {
            var target = new WorkLoad();
            const int expected = 100;
            target.NumberOfHours = expected;
            int actual = target.NumberOfHours;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тест для поля Object
        /// </summary>
        [TestMethod]
        public void ObjectTest()
        {
            var target = new WorkLoad();
            const string expected = "Предмет";
            target.Object = expected;
            string actual = target.Object;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тест для поля ClassType
        /// </summary>
        [TestMethod]
        public void ClassTypeTest()
        {
            var target = new WorkLoad();
            const string expected = "Тип занятия";
            target.ClassType = expected;
            string actual = target.ClassType;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тест для поля Payment
        /// </summary>
        [TestMethod]
        public void PaymentTest()
        {
            var target = new WorkLoad();
            const int expected = 100;
            target.Payment = expected;
            int actual = target.Payment;
            Assert.AreEqual(expected, actual);
        }
    }
}

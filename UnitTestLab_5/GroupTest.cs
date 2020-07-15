using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Csharp_lab_5;

namespace UnitTestLab_5
{
    /// <summary>
    /// Сводное описание для GroupTest
    /// </summary>
    [TestClass]
    public class GroupTest
    {
        public GroupTest()
        {
            var target = new Group();
            Assert.IsInstanceOfType(target, typeof(Group));
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
        /// Тест для конструктора Group
        /// </summary>
        [TestMethod]
        public void GroupConstructorTest()
        {
            var target = new Group();
            Assert.IsInstanceOfType(target, typeof(Group));
        }

        /// <summary>
        /// Тест для поля Specialty
        /// </summary>
        [TestMethod]
        public void SpecialtyTest()
        {
            var target = new Group();
            const string expected = "18ИВТ";
            target.Specialty = expected;
            string actual = target.Specialty;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тест для поля Department
        /// </summary>
        [TestMethod]
        public void DepartmentTest()
        {
            var target = new Group();
            const string expected = "ФИТ";
            target.Department = expected;
            string actual = target.Department;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тест для поля NumberOfStudents
        /// </summary>
        [TestMethod]
        public void NumberOfStudentsTest()
        {
            var target = new Group();
            const int expected = 10;
            target.NumberOfStudents = expected;
            int actual = target.NumberOfStudents;
            Assert.AreEqual(expected, actual);
        }
    }
}

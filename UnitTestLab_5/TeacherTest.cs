using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Csharp_lab_5;

namespace UnitTestLab_5
{
    /// <summary>
    /// Сводное описание для TeacherTest
    /// </summary>
    [TestClass]
    public class TeacherTest
    {

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
        /// Тест для конструктора Teacher
        /// </summary>
        [TestMethod]
        public void TeacherConstructorTest()
        {
            var target = new Teacher();
            Assert.IsInstanceOfType(target, typeof(Teacher));
        }

        /// <summary>
        /// Тест для Surname
        /// </summary>
        [TestMethod]
        public void SurnameTest()
        {
            var target = new Teacher();
            const string expected = "Фамилия";
            target.Surname = expected;
            string actual = target.Surname;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тест для Name
        /// </summary>
        [TestMethod]
        public void NameTest()
        {
            var target = new Teacher();
            const string expected = "Имя";
            target.Name = expected;
            string actual = target.Name;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тест для Patronymic
        /// </summary>
        [TestMethod]
        public void PatronymicTest()
        {
            var target = new Teacher();
            const string expected = "Отчество";
            target.Patronymic = expected;
            string actual = target.Patronymic;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тест для Phone
        /// </summary>
        [TestMethod]
        public void PhoneTest()
        {
            var target = new Teacher();
            const long expected = 00000000000;
            target.Phone = expected;
            long actual = target.Phone;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тест для Experience
        /// </summary>
        [TestMethod]
        public void ExperienceTest()
        {
            var target = new Teacher();
            const int expected = 10;
            target.Experience = expected;
            int actual = target.Experience;
            Assert.AreEqual(expected, actual);
        }
    }
}

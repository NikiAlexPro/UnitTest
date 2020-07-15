using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Csharp_lab_15;
using Csharp_lab_15.Mock;

namespace UnitTestProject15
{
    /// <summary>
    /// Сводное описание для SearchMockTEST
    /// </summary>
    [TestClass]
    public class SearchMockTEST
    {
        public SearchMockTEST()
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

        [TestMethod]
        public void TestMethod1()
        {
            Teacher teacher = new Teacher { Group = new Group() };
            teacher.first_name = "Alex";
            teacher.last_name = "XELA";
            teacher.phone = "9999999";
            teacher.exp = "master";
            //teacher.special = special;
            teacher.Group.special = "10-ПРИ";
            teacher.Group.department = "ИиПО";
            teacher.Group.nmb = 9999;
            var teacherRes = SearchMock.GetTeacher("Alex");
            Assert.AreEqual(teacher.first_name, teacherRes.first_name);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var target = new Teacher();
            Assert.IsInstanceOfType(target, typeof(Teacher));
        }
    }
}

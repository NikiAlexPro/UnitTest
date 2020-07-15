using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Csharp_lab_15;
using Csharp_lab_15.Mock;

namespace UnitTestProject15
{
    /// <summary>
    /// Сводное описание для AddTeacherMockTEST
    /// </summary>
    [TestClass]
    public class AddTeacherMockTEST
    {
        public AddTeacherMockTEST()
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
            var teacherRes = AddTeacherMock.AddTeacher("Alex", "XELA", "9999999", "master", "10-ПРИ", "ИиПО", 9999);
            //Assert.AreEqual(teacher, teacherRes);
            Assert.IsTrue(teacherRes);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var target = new Teacher();
            Assert.IsInstanceOfType(target, typeof(Teacher));
        }
    }
}

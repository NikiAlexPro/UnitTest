using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Csharp_lab_15v2;
using Csharp_lab_15v2.Mock;

namespace UnitTestProject152
{
    /// <summary>
    /// Сводное описание для UnitTestDriverA
    /// </summary>
    [TestClass]
    public class UnitTestDriverA
    {
        public UnitTestDriverA()
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
            //ModelTeachers modelTeacher = new ModelTeachers();
            List<Group> groupDB = GroupDB.GetGroups();
            Group gr = new Group { department = "ИиПО", special = "ИВТ-2019", nmb = 2019 };
            var flag = AddTeacherDB.AddTeacher(gr, "Martin", "Lowrence", "34563875", "Mater");
            var teacher = SearchDB.GetTeacher("Alex");
            Assert.IsNotNull(groupDB);
            Assert.IsTrue(flag);
            Assert.IsNotNull(teacher);
        }
    }
}

using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Csharp_lab_5;

namespace Csharp_lab_5_test
{
    /// <summary>
    /// Сводное описание для GroupTest
    /// </summary>
    [TestClass]
    public class GroupTest
    {
        public GroupTest()
        {
            var target = new GroupTest();
            Assert.IsInstanceOfType(target, typeof(GroupTest));
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
        /// Тест для Конструктора Group
        /// </summary>
        [TestMethod]
        public void GroupConstructorTest()
        {
           
        }
        [TestMethod]
        public void TestMethod1()
        {
            //
            // TODO: добавьте здесь логику теста
            //
        }
    }
}

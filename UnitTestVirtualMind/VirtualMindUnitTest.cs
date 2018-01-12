using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirtualMindTestService;
using BE.Models;
using System.Collections.Generic;

namespace UnitTestVirtualMind
{
    [TestClass]
    public class VirtualMindUnitTest
    {
        [TestMethod]
        public void Test_Cotizacion()
        {
            //Arrange

            //Act
            VirtualMindService service = new VirtualMindService();
            Money expected =  service.Cotizacion("Dolar").item;

            Assert.IsNotInstanceOfType(expected, typeof(Exception));
       


        }

        [TestMethod]
        public void Test_Usuarios()
        {
            //Arrange

            //Act
            VirtualMindService service = new VirtualMindService();
            List<User> expected = service.Usuarios().list;

            //Assert

            Assert.IsNotInstanceOfType(expected, typeof(Exception));



        }

        [TestMethod]
        public void Test_InsertUser()
        {
            //Arrange

            //Act
            VirtualMindService service = new VirtualMindService();
            var expected = service.InsertUser(new User()
            {
                apellido = "Test Apellido",
                nombre = "Test Nombre",
                email = "Test Email",
                password = "Test Password"
            });

            //Assert

            Assert.IsNotInstanceOfType(expected, typeof(Exception));


        }

        [TestMethod]
        public void Test_DeleteUser()
        {
            //Arrange

            //Act
            VirtualMindService service = new VirtualMindService();
            var expected = service.DeleteUser(5);
           
            //Assert

            Assert.IsNotInstanceOfType(expected, typeof(Exception));


        }


        [TestMethod]
        public void Test_UpdateUser()
        {
            //Arrange

            //Act
            VirtualMindService service = new VirtualMindService();
            var expected = service.UpdateUser(new User()
            {
                apellido = "Test Apellido",
                nombre = "Test Nombre",
                email = "Test Email",
                password = "Test Password",
                id = 6
            });


            //Assert

            Assert.IsNotInstanceOfType(expected, typeof(Exception));


        }


    }
}

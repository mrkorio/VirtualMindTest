using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BE.Models;
using BL.Helpers;
using BL.Strategy;
using BL.Strategy.Base;
using VirtualMindTestService.Returns;

namespace VirtualMindTestService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class VirtualMindService : IVirtualMindService
    {


        public Return<Money> Cotizacion(string money)
        {
            try
            {
                Return<Money> ret = new Return<Money>();

                IMoneyStrategy strategy = CommonHelper.GetMoneyStrategy(money);
             
                 ret.item = strategy.GetQuotation();
                          
                return ret;

            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public Return<User> DeleteUser(int userId)
        {
            Return<User> ret = new Return<User>();
            try
            {
                new UserHelper().DeleteUser(userId);

                return ret; 
            }
            catch (Exception)
            {


                throw new WebFaultException(System.Net.HttpStatusCode.InternalServerError);
            }
        }

        public Return<User> GetUserById(int id)
        {
            Return<User> ret = new Return<User>();
            try
            {
                ret.item = new UserHelper().GetUserById(id);

                return ret;
            }
            catch (Exception)
            { 

                throw new WebFaultException(System.Net.HttpStatusCode.InternalServerError);
            }
        }

        public Return<User> InsertUser(User user)
        {
            Return<User> ret = new Return<User>();
            try
            {
                new UserHelper().InsertUser(user);

                return ret;
            }
            catch (Exception)
            {


                throw new WebFaultException(System.Net.HttpStatusCode.InternalServerError);
            }
        }

        public Return<User> UpdateUser(User user)
        {
            Return<User> ret = new Return<User>();
            try
            {
                new UserHelper().UpdateUser(user);

                return ret;
            }
            catch (Exception)
            {


                throw new WebFaultException(System.Net.HttpStatusCode.InternalServerError);
            }
        }

        public Return<User> Usuarios()
        {
            Return<User> ret = new Return<User>();
            try
            {
                ret.list = new UserHelper().GetUsers();

                return ret;                    
            }
            catch (Exception)
            {

                throw new WebFaultException(System.Net.HttpStatusCode.InternalServerError);
            }
        }
    }
}

using BE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using VirtualMindTestService.Returns;

namespace VirtualMindTestService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IVirtualMindService
    {

        [OperationContract]
        [WebGet(UriTemplate = "/Cotizacion/{money}",
        ResponseFormat = WebMessageFormat.Json)]
        Return<Money> Cotizacion(string money);

        [OperationContract]
        [WebGet(UriTemplate = "/Usuarios", ResponseFormat = WebMessageFormat.Json)]
        Return<User> Usuarios();

        [OperationContract]
        [WebGet(UriTemplate = "/GetUserById/{id}", ResponseFormat = WebMessageFormat.Json)]
        Return<User> GetUserById(int id);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, UriTemplate = "/InsertUser")]
        Return<User> InsertUser(User user);


        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, UriTemplate = "/UpdateUser")]
        Return<User> UpdateUser(User user);


        [OperationContract]
        [WebInvoke(Method = "DELETE", RequestFormat = WebMessageFormat.Json, UriTemplate = "/DeleteUser")]
        Return<User> DeleteUser(int userId);


    }


}

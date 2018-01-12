using BE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL.Helpers
{
    public class UserHelper
    {
        private BE.Models.User ToUser(DAL.User userEntity)
        {
            BE.Models.User newUser = new BE.Models.User();

            newUser.id = userEntity.id;
            newUser.nombre = userEntity.nombre;
            newUser.password = userEntity.password;
            newUser.email = userEntity.email;
            newUser.apellido = userEntity.apellido;

            return newUser;
        }


        private DAL.User ToUserEntity( BE.Models.User user)
        {
            DAL.User newUser = new DAL.User();

            newUser.id = user.id;
            newUser.nombre = user.nombre;

            if (!string.IsNullOrEmpty(user.password))
            {
                newUser.password = EncryptHelper.Encrypt(user.password);
            }
          
            newUser.email = user.email;
            newUser.apellido = user.apellido;

            return newUser;
        }


        public void UpdateUser(BE.Models.User user)
        {
            new DaoUser().UpdateUser(ToUserEntity(user));
        }

        public void DeleteUser(int userId)
        {
            new DaoUser().DeleteUser(userId);
        }

        public void InsertUser(BE.Models.User user)
        {
            new DaoUser().InsertUser(ToUserEntity(user));
        }

        public List<BE.Models.User> GetUsers()
        {
            try
            {
                List<BE.Models.User> list = new List<BE.Models.User>();
                List<DAL.User> result = new DaoUser().GetUsers();

                foreach (var item in result)
                {
                    list.Add(ToUser(item));
                }

                return list;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public BE.Models.User GetUserById(int id)
        {
            try
            {
                DAL.User dataUser = new DaoUser().GetUserById(id);
                BE.Models.User user = null;
                if (dataUser != null)
                {

                   user = ToUser(dataUser);
                }



                return user;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}

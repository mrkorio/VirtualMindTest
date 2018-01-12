using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DaoUser
    {

        private static VirtualMindEntities context;

        private VirtualMindEntities GetContext()
        {
            if (context == null)
            {
                context = new VirtualMindEntities();
            }

            return context;
        }

        public List<User> GetUsers()
        {
            try
            {
                return GetContext().User.ToList();
            }
            catch (Exception e)
            {

                throw e;
            }
            
          
        }

        public void InsertUser(User user)
        {
            try
            {
                var context = GetContext();
                context.User.Add(user);
                context.SaveChanges();
            }
            catch (Exception e)
            {

                throw e;
            }
        


        }

        public void DeleteUser(int userId)
        {
            try
            {
                var context = GetContext();

                User user = context.User.SingleOrDefault(x => x.id.Equals(userId));

                if (user != null)
                {
                    context.User.Remove(user);
                    context.SaveChanges();
                }

               

               
            }
            catch (Exception e)
            {

                throw e;
            }
           

        }



        public void UpdateUser(User user)
        {
            try
            {
                var context = GetContext();

                var result = context.User.SingleOrDefault(x => x.id.Equals(user.id));

                if (result != null)
                {
                    result.apellido = user.apellido;
                    result.nombre = user.nombre;
                    result.email = user.email;
                   

                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

                throw e;
            }
          
        }

        public User GetUserById(int id)
        {
            var context = GetContext();

            var result = context.User.SingleOrDefault(x => x.id.Equals(id));

            return result;
        }
    }
}

using SportLife.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.ApiCore
{
    public class ExceptionManagement
    {
        private static ExceptionManagement _instance;
        private Dictionary<string, Message> _userMessages;
        private ExceptionManagement() { }
        public static ExceptionManagement GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ExceptionManagement();
            }
            return _instance;
        }
        public void ManageException(SportLikeException rex)
        {
            throw new SportLikeException(_userMessages[rex.Code]);
        }
        public void ManageException(Exception ex)
        {
            if (ex.GetType() == typeof(SportLikeException))
            {
                ManageException((SportLikeException)ex);
            }
            else
            {
                throw new SportLikeException(_userMessages["E000"]);
            }
        }
        private void LoadMessages()
        {
            //Ir a la base de datos a traer mensajes
            var m1 = new Message()
            {
                Code = "E000",
                Description = "No se ha podido procesar la accion"
            };
            var m2 = new Message()
            {
                Code = "E001",
                Description = "El usuario debe ser mayor de edad.[18]"
            };
            //_userMessage.Add(m1.Code, m1);
            //_userMessage.Add(m2.Code, m2);
        }
    }
}

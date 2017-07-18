using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.DataAccess.Management
{
    public class ExceptionManagement
    {
        private static ExceptionManagement _instance;

        private ExceptionManagement() { }
        public static ExceptionManagement GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ExceptionManagement();
            }
            return _instance;
        }
        public void ManageException(Exception ex)
        {
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\Documents\Exceptions.txt", true))
            {

                file.WriteLine("----------------");
                file.WriteLine("Hora: " +
                    DateTime.Now.ToString("h:mm:ss tt"));
                file.WriteLine("Fecha: " +
                    DateTime.Now.ToString("M/d/yyyy"));
                file.WriteLine("Exception: " + ex.Message);
                file.WriteLine("----------------");
            }
        }
    }
}

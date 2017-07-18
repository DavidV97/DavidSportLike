using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLife.Entities
{
    public class SportLikeException : Exception
    {
        public enum ExceptionCode
        {
            IdNotNull,
            Fatal,
            DuplicatedId
        }

        public string MsjDes { get; set; }
        public string Code { get; set; }
        public SportLikeException(string code)
        {
            Code = code;
        }
        public SportLikeException(string code, string msj)
        {
            Code = code;
            MsjDes = msj;
        }

        public SportLikeException(Message m)
        {
            Code = m.Code;
            MsjDes = m.Description;
        }
        public SportLikeException(Exception ex)
        {
            Code = "E000";
        }
        public override string Message => GetErrorDesc();

        private string GetErrorDesc()
        {
            return MsjDes;
        }
    }
}

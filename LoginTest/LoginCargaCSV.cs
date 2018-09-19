using Atari;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LoginTest
{
    public class LoginCargaCSV:BaseTest
    {
        public  LoginCargaCSV()
        {

        }

        [Fact]
        public void CargaCSV()
        {
            var usuario = "chazki_mexico";
            var pass = "hviveso02";
           // var empresa = "NESPRESSO MEXICO SA DE CV";
            IrAtari();
            var loginAction = new CargaCVS(Driver);
            var iniciarSesion = loginAction.LoginCargaCSV(usuario,pass);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
    
}

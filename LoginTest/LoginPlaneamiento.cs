using Atari;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace LoginTest
{
    public class LoginPlaneamiento:BaseTest
    {
        public  LoginPlaneamiento()
        {

        }

        [Fact]

        public void Planeamiento()
        {

            /*USUARIO MEXICO
           var usuario = "chazki_mexico";
           var pass = "hviveso02";*/
            // var empresa = "NESPRESSO MEXICO SA DE CV";
            /*USUARIO PERU*/
            var usuario = "chazki_peru";
            var pass = "hviveso02";
            // var empresa = "NESPRESSO MEXICO SA DE CV";
            IrAtari();
            var loginAction = new Planeamiento(Driver);
            var iniciarSesion = loginAction.LoginPlaneamiento(usuario, pass);
        }




    }
    
}

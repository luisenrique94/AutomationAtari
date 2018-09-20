using Atari;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LoginTest
{
  public   class LoginSeguimientoPaqueteOrden:BaseTest
    {
        public LoginSeguimientoPaqueteOrden()
        {

        }
        [Fact]
        public void SeguimientoOrden()
        {
            /*USUARIO MEXICO
           var usuario = "chazki_mexico";
           var pass = "hviveso02";*/
            // var empresa = "NESPRESSO MEXICO SA DE CV";
            /*USUARIO PERU*/
            var usuario = "chazki_peru";
            var pass = "hviveso02";
            IrAtari();
            var login = new SeguimientoPaquetesOrdenPage(Driver);
            var iniciarSesion = login.LoginSeguimientoOrden(usuario,pass);


        }
    }
}

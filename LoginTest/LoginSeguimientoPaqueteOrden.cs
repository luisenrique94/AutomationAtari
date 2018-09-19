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
            string usuario = "chazki_mexico";
            string pass = "hviveso02";
            IrAtari();
            var login = new SeguimientoPaquetesOrdenPage(Driver);
            var iniciarSesion = login.LoginSeguimientoOrden(usuario,pass);


        }
    }
}

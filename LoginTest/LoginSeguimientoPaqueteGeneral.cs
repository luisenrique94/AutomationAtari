using Atari;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LoginTest
{
  public   class LoginSeguimientoPaqueteGeneral:BaseTest
    {
        public LoginSeguimientoPaqueteGeneral()
        {

        }
        [Fact]
        public void SeguimientoGeneral()
        {
            string usuario = "chazki_mexico";
            string pass = "hviveso02";
            IrAtari();
            var login = new SeguimientoPaquetesGeneralPage(Driver);
            var iniciarSesion = login.LoginSeguimientoPaqueGeneral(usuario,pass);


        }
    }
}

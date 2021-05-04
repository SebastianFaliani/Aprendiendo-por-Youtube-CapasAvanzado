using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.MailServicios
{
    public class MailSoporte:MasterMail
    {
        public MailSoporte()
        {
            enviarMail = "nedaover@gmail.com";
            password = "S0l_tech";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;

            IniciarClienteSmtp();
        }
    }
}

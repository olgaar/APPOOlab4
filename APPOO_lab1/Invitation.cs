using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPOO_lab1
{
    public class Invitation : Letter
    {

         Event myEvent;

        public Invitation(Event myEvent, string signature)
        {
            this.myEvent = myEvent;
            addressee = myEvent.getAdressee();
            this.signature = signature;
        }
        public override void BuildAddress()
        {
            addressee = string.Concat("Здравствуйте, уважаемый ", addressee, ".");
        }

        public override void BuildBody()
        {
            body = string.Concat(" Приглашаем Вас на ", myEvent.getName(), ", которое состоится ", myEvent.getDateTime() ,". Ваше присутствие очень важно для нас! Будем ждать. В случае возникновения вопросов, просим задать их в письме по этому адресу.");
        }
        public override void BuildSignature()
        {
            signature = string.Concat(" С уважением, ", signature);
        }
    }
}


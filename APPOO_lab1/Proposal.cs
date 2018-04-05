using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPOO_lab1
{
    class Proposal: Letter
    {
        Event myService;

        public Proposal(Event myService, string signature)
        {
            this.myService = myService;
            this.addressee = myService.getAdressee();
            this.signature = signature;
            }
        public override void BuildAddress()
        {
            addressee = string.Concat("Здравствуйте, ", addressee, "!");
        }

        public override void BuildBody()
        {
            body = string.Concat("Наша компания специализируется по предоставлению услуг, таких как ", myService.getName(),"Мы рады сообщить, что наша работа характеризуется высоким качеством и низкими ценами. Уверяем, вы останетесь притно удивлены!");
        }
        public override void BuildSignature()
        {
            signature = string.Concat(" С уважением,", signature );
        }
    }
}


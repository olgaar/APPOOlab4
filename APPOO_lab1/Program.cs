using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPOO_lab1
{
    class Program
    {
                
        static void Main(string[] args)
        {
            var congratulationEvent = new Event("День рождения", new DateTime(2018, 7, 20), "Анечка");
            var proposalEvent = new Event("Тестирование Программного Обеспечения", new DateTime(2018, 7, 20), "Анатолий Аркадьевич");
            var invitationEvent = new Event("День основания компании \" Vintix\"", new DateTime(2018, 7, 20), "Филипп");

            Letter congratulation = new Congratulation(congratulationEvent, "Оля");
            Letter invitation = new Invitation(invitationEvent, "Ольга");
            Letter proposal = new Proposal(proposalEvent, "Ольга Архирий");

            MessageCreator a = new MessageCreator();
            var letter = a.BuildLetter(invitation);
            Console.WriteLine(letter);

            letter = a.BuildLetter(proposal);
            Console.WriteLine(System.Environment.NewLine + letter);

            letter = a.BuildLetter(congratulation);
            Console.WriteLine(System.Environment.NewLine + letter);
                       
           
        }
    }
}

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
            var congratulation = new Event("День рождения", new DateTime(2018, 7, 20), "Анечка");
            var proposal = new Event("Тестирование Программного Обеспечения", new DateTime(2018, 7, 20), "Филипп");
            var invitation = new Event("День основания компании \" Vintix\"", new DateTime(2018, 7, 20), "Анатолий Аркадьевич");

            var a= MessageCreator.Create(MessageType.Congratulation, congratulation);            
            var b = MessageCreator.Create(MessageType.Proposal, proposal);
            var c = MessageCreator.Create(MessageType.Invitation, invitation);
                       
            Console.WriteLine(a);
            Console.WriteLine(System.Environment.NewLine + b);
            Console.WriteLine(System.Environment.NewLine + c);
        }
    }
}

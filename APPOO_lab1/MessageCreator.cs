using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPOO_lab1
{
    internal class MessageCreator 
    {
        private static MessageCreator _instance; 
        public Event eventToGo; 
           
        public MessageCreator( Event eventTo)
        {
           eventToGo = eventTo;
        }  

        internal static string Create(MessageType type, Event eventToGo)
        {
            string message;
            _instance = new MessageCreator(eventToGo);

            switch (type)
            {
                case MessageType.Congratulation:
                    message = _instance.Congratulation;
                    break;
                case MessageType.Invitation:
                    message = _instance.Invitation;
                    break;
                case MessageType.Proposal:
                    message = _instance.Proposal;
                    break;
                default:
                    throw new Exception("You must supply a valid message type");
              }
            return message;
        }
       private string Congratulation
        {
            get {
                Congratulation a = new Congratulation(eventToGo, "Оля");

                return a.BuildLetter();
            }                      
                
        }
        private string Invitation
        {
            get
            {
                Invitation a = new Invitation(eventToGo, "Ольга Архирий");

                return a.BuildLetter();
            }
        }
        private string Proposal
        {
            get
            {
                Proposal a = new Proposal(eventToGo, "Ольга Архирий компания \"E2E\"");

                return a.BuildLetter();
            }
        }

        
    }
}

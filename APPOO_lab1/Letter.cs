using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPOO_lab1
{
   public abstract class Letter
    {
        public string body { get; set; }
        public string addressee;
        public string signature;
        
        /*public string BuildLetter()
        {
            BuildAddress();
            BuildBody();
            BuildSignature();

            string myLetter = string.Concat(addressee, body, signature);
            return myLetter;
        }*/

        public abstract void BuildBody();
        public abstract void BuildAddress();
        public abstract void BuildSignature();
       // public abstract void buildNewLetter();
    }
   
}

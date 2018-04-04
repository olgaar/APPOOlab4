using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPOO_lab1
{
   public abstract class Letter
    {
        protected string body { get; set; }
        protected string addressee;
        protected string signature;
        
        public string BuildLetter()
        {
            BuildAddress();
            BuildBody();
            BuildSignature();

            string myLetter = string.Concat(addressee, body, signature);
            return myLetter;
        }

        public abstract void BuildBody();
        public abstract void BuildAddress();
        public abstract void BuildSignature();
    }
   
}

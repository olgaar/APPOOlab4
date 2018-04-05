using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPOO_lab1
{
    public class MessageCreator 
    {

        public string BuildLetter(Letter letter)
        {
            letter.BuildAddress();
            letter.BuildBody();
            letter.BuildSignature();

            string myLetter = string.Concat(letter.addressee, letter.body, letter.signature);
            return myLetter;
        }
       
    }
}

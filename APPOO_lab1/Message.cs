using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPOO_lab1
{
    abstract class Message
    {
        public abstract void BuildMessage();

        public abstract void BuildBody();
        public abstract void BuildAddress();
        public abstract void BuildSignature();
    }
}

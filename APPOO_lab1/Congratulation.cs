using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPOO_lab1
{
    public class Congratulation : Letter
    {
        Event theirsEvent;
        
        public Congratulation(Event theirsEvent, string signature)
        {
            this.addressee = theirsEvent.getAdressee();
            this.theirsEvent = theirsEvent;
            this.signature = signature;
        }

        public List<string> Wishes
        {
           get
            {
                string[] allWishes =
             {
                    " Счастья",
                    " Здоровья",
                    " Удачи",
                    " Любви",
                    " Чудес",
                    " Солнца",
                    " Волшебства",
                    " Улыбок",
                    " Везения",
                    " Долгих лет"

                };
                string[] wishesRand = new string[5];
                List<string> wishesToGo = new List<string>();

                int k;
                Random rand = new Random();
                for (int i = 0; i < wishesRand.Length; i++)
                {
                    while (true)
                    {
                        k = rand.Next(allWishes.Length);
                        if (!wishesToGo.Any(x => x.Equals(allWishes[k])))
                        {
                            wishesToGo.Add(allWishes[k]);
                            wishesRand[i] = allWishes[k];
                            break;
                        }
                    }
                }
                return wishesToGo;
            }
        }

        public override void BuildAddress()
        {
            addressee = string.Concat(addressee, "!");
        }

        public override void BuildBody()
        {
            var wishes = Wishes;

            body = string.Concat("Поздравляю от всей души с празником! Наконец-то наступил этот день - ",
                theirsEvent.getName(), "! ", "Желаю", wishes[0],",", wishes[1], ",", wishes[2], ",", wishes[3], ",",
                wishes[4], "!");
            
        }
        public override void BuildSignature()
        {
            signature = string.Concat(" С уважением, ", signature);
        }

        }
    }


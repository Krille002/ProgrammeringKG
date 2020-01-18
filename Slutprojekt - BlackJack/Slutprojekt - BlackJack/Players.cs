using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt___BlackJack
{
    class Players
    {
        public List<string> DealerHand = new List<string>();
        List<string> PlayerHand = new List<string>();



        //Metoder


        //Sätta in kort i AIs hand
        public void DealerHandAdd (string CardToAdd)
        {
            DealerHand.Add(CardToAdd);
        }

        //Sätta in kort i spelares hand
        public void PlayerHandAdd (string CardToAdd)
        {
            PlayerHand.Add(CardToAdd);
        }
    }
}

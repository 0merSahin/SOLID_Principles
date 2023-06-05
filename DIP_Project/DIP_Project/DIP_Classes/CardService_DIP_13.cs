using System;

namespace SolidProject1_211229013.DIP_Classes
{
	public class CardService_DIP_13
	{
        public int CardNo { get; set; }
        public int CardPassword { get; set; }

        public CardService_DIP_13()
        {
            this.CardNo = 0;
            this.CardPassword = 0;
        }

        public CardService_DIP_13(int CardNo, int CardPassword)
		{
            this.CardNo = CardNo;
            this.CardPassword = CardPassword;
        }


        public bool CardPasswordCheck(int CardPassword)
        {
            if (CardPassword == this.CardPassword)
            {
                Console.WriteLine("Card Password is correct.");
                return true;
            }
            else
            {
                Console.WriteLine("Card password is incorrect!\nThe transaction has been cancelled.");
                return false;
            }
        }
	}
}


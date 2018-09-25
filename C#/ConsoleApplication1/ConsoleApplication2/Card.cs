using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Card: IComparable<Card>
    {
        public CardTypes Type
        {
            get;
            private set;
        }
        public CardValues Value
        {
            get;
            private set;
        }

        public Card(CardTypes type, CardValues value)
        {
            Type = type;
            Value = value;
        }

        public int CompareTo(Card other) // у определенной карты вызовет CompareTo с другой картой
        {
            var valCompare = Value.CompareTo(other.Value);
            if (valCompare != 0)
                return valCompare;
            return 0; //
        }
        public override string ToString()
        {
            return String.Format("{0} - {1}", GetSymbol(), Value);
        }
        public string GetSymbol()
        {
            switch (Type) // ИЗ ENUM cARDtYPES
            {
                case CardTypes.Bubny:
                    return  "♦";                    
                case CardTypes.Kresty:

                    return "♣";
                case CardTypes.Chirvy:
                    return "♥";
                case CardTypes.Piki:
                    return "♠";                
            }
            throw new Exception();     
        }
    }        
}
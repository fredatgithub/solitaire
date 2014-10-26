using System.Collections;

namespace Solitaire
{
  class ColumnOfCards
  {
    public byte ColumnNumber { get; set; }
    public byte NumberOfCardsInColumn { get; set; }
    public bool IsEmpty { get; set; }
    public ArrayList CardList { get; set; }

    public ColumnOfCards()
    {
      
    }
  }
}
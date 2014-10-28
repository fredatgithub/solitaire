using System;
using System.Windows.Forms;

namespace Solitaire
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private bool _thereIsAnEmptyColumn;
    private bool _kingReadytoMove;
    private byte _numberOfKingReadyToMove;
    private bool _numberOfFreeColumn;
    private bool _numberOfKingsDown;
    private bool _AceReadyToMove;

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private Card HeadOfColumn(byte columnNumber)
    {
      return new Card();
    }

    private Card TailOfColumn(byte columnNumber)
    {
      return new Card();
    }
  }
}
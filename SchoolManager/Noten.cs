using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManager
{
  public partial class Noten : Form
  {
    public Noten()
    {
      InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void OnClear_Click(object sender, EventArgs e)
    {
      Fach_tbx.Clear();
      Note_tbx.Text ="0,0";
      Schueler_tbx.Text = "@sluz.ch";
    }

    private void OnApply_Click(object sender, EventArgs e)
    {
      string Fach = Fach_tbx.Text;
      double Note = Convert.ToDouble(Note_tbx.Text);
      string Email = Fach_tbx.Text;
    }
  }
}

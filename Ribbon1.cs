using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;

namespace WordAddIn1
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnLatinToCyrilic_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.changeToCyrilic();
        }

        private void btnCyrilicToLatin_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.changeToLatin();
        }

        private void checkBox1_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.toggleJustSelected();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;

namespace WordAddIn1
{
    public partial class ThisAddIn
    {

        private static readonly string[] latinica = new string[]{"nj","lj","dž","e","r","t","z","u","i","o","p","š","đ","a","s","d","f","g","h","j","k","l","č","ć","ž","c","v","b","n","m"};
        private static readonly string[] cirilica = new string[] { "њ", "љ","џ","е","р","т","з","у","и","о","п","ш","ђ","а","с","д","ф","г","х","ј","к","л","ч","ћ","ж","ц","в","б","н","м"};
        private static bool justSelected = false;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            //dodaje WorkWithDocument handler ako postoji otvoren dokument ili ako se kreira novi
            //this.Application.DocumentOpen += new Word.ApplicationEvents4_DocumentOpenEventHandler(WorkWithDocument);
            //((Word.ApplicationEvents4_Event)this.Application).NewDocument +=new Word.ApplicationEvents4_NewDocumentEventHandler(WorkWithDocument);
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }


        internal void changeToCyrilic()
        {
            this.changeLetters(1);
        }

        internal void changeToLatin()
        {
            this.changeLetters(2);
        }

        private void changeLetters(int flag)
        {
            System.Diagnostics.Debug.Assert(flag!=2 || flag!=1,"Nedozvoljena vrijednost flag-a");
            string[] array1 = null;
            string[] array2 = null;
            if (flag == 1)
            {
                array1 = latinica;
                array2 = cirilica;
            }
            else if(flag ==2)
            {
                array1 = cirilica;
                array2 = latinica;
            }

            Word.Document document = this.Application.ActiveDocument;
            document.Application.ScreenUpdating = false;
            Word.Range selectedPart = null;
            if (justSelected == false)
            {
                selectedPart = document.Range(document.Content.Start, document.Content.End);
            }
            else
            {
                selectedPart = document.Range(this.Application.Selection.Start, this.Application.Selection.End);
            }

            for (int i = 0; i < array1.Length; i++)
            {

                Word.Find findObject = selectedPart.Find;

                findObject.ClearFormatting();
                findObject.Text = array1[i];
                findObject.Replacement.ClearFormatting();
                findObject.Replacement.Text = array2[i];

                object replaceAll = Word.WdReplace.wdReplaceAll;
                object matchCase = false;
                object matchWholeWord = false;
                findObject.Execute(ref missing, matchCase, matchWholeWord, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing, ref missing,
                    ref replaceAll, ref missing, ref missing, ref missing, ref missing);
            }

            document.Application.ScreenRefresh();
            document.Application.ScreenUpdating = true;
        }

        internal void toggleJustSelected()
        {
            justSelected = !justSelected;
        }


        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion
    }
}

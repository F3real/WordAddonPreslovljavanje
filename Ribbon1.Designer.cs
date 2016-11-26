namespace WordAddIn1
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.lbl1 = this.Factory.CreateRibbonGroup();
            this.btnLatinToCyrilic = this.Factory.CreateRibbonButton();
            this.btnCyrilicToLatin = this.Factory.CreateRibbonButton();
            this.checkBox1 = this.Factory.CreateRibbonCheckBox();
            this.tab1.SuspendLayout();
            this.lbl1.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.lbl1);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // lbl1
            // 
            this.lbl1.Items.Add(this.btnLatinToCyrilic);
            this.lbl1.Items.Add(this.btnCyrilicToLatin);
            this.lbl1.Items.Add(this.checkBox1);
            this.lbl1.Label = "Preslovljavanje";
            this.lbl1.Name = "lbl1";
            // 
            // btnLatinToCyrilic
            // 
            this.btnLatinToCyrilic.Label = "latinica -> ћирилица";
            this.btnLatinToCyrilic.Name = "btnLatinToCyrilic";
            this.btnLatinToCyrilic.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnLatinToCyrilic_Click);
            // 
            // btnCyrilicToLatin
            // 
            this.btnCyrilicToLatin.Label = "ћирилица -> latinica";
            this.btnCyrilicToLatin.Name = "btnCyrilicToLatin";
            this.btnCyrilicToLatin.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnCyrilicToLatin_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Label = "Samo selektovani ";
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.checkBox1_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.lbl1.ResumeLayout(false);
            this.lbl1.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup lbl1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnLatinToCyrilic;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnCyrilicToLatin;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBox1;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}

namespace barlangokGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            lb_nev = new Label();
            label3 = new Label();
            label4 = new Label();
            tx_azon = new TextBox();
            tx_hossz = new TextBox();
            tx_melyseg = new TextBox();
            bt_keres = new Button();
            bt_mentes = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // lb_nev
            // 
            resources.ApplyResources(lb_nev, "lb_nev");
            lb_nev.Name = "lb_nev";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // tx_azon
            // 
            resources.ApplyResources(tx_azon, "tx_azon");
            tx_azon.Name = "tx_azon";
            // 
            // tx_hossz
            // 
            resources.ApplyResources(tx_hossz, "tx_hossz");
            tx_hossz.Name = "tx_hossz";
            // 
            // tx_melyseg
            // 
            resources.ApplyResources(tx_melyseg, "tx_melyseg");
            tx_melyseg.Name = "tx_melyseg";
            // 
            // bt_keres
            // 
            resources.ApplyResources(bt_keres, "bt_keres");
            bt_keres.Name = "bt_keres";
            bt_keres.UseVisualStyleBackColor = true;
            bt_keres.Click += bt_keres_Click;
            // 
            // bt_mentes
            // 
            resources.ApplyResources(bt_mentes, "bt_mentes");
            bt_mentes.Name = "bt_mentes";
            bt_mentes.UseVisualStyleBackColor = true;
            bt_mentes.Click += bt_mentes_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bt_mentes);
            Controls.Add(bt_keres);
            Controls.Add(tx_melyseg);
            Controls.Add(tx_hossz);
            Controls.Add(tx_azon);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lb_nev);
            Controls.Add(label1);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lb_nev;
        private Label label3;
        private Label label4;
        private TextBox tx_azon;
        private TextBox tx_hossz;
        private TextBox tx_melyseg;
        private Button bt_keres;
        private Button bt_mentes;
    }
}

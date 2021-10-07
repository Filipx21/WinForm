
namespace WindowsFormsApp1
{
    partial class UserControl2
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tx_Input = new System.Windows.Forms.TextBox();
            this.b_Check = new System.Windows.Forms.Button();
            this.l_title = new System.Windows.Forms.Label();
            this.l_Check = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tx_Input
            // 
            this.tx_Input.Location = new System.Drawing.Point(14, 39);
            this.tx_Input.Name = "tx_Input";
            this.tx_Input.Size = new System.Drawing.Size(226, 20);
            this.tx_Input.TabIndex = 4;
            // 
            // b_Check
            // 
            this.b_Check.Location = new System.Drawing.Point(252, 38);
            this.b_Check.Name = "b_Check";
            this.b_Check.Size = new System.Drawing.Size(108, 22);
            this.b_Check.TabIndex = 5;
            this.b_Check.Text = "Sprawdz";
            this.b_Check.UseVisualStyleBackColor = true;
            this.b_Check.Click += new System.EventHandler(this.button3_Click);
            // 
            // l_title
            // 
            this.l_title.AutoSize = true;
            this.l_title.Cursor = System.Windows.Forms.Cursors.Default;
            this.l_title.ForeColor = System.Drawing.Color.Black;
            this.l_title.Location = new System.Drawing.Point(17, 11);
            this.l_title.MinimumSize = new System.Drawing.Size(340, 0);
            this.l_title.Name = "l_title";
            this.l_title.Size = new System.Drawing.Size(340, 13);
            this.l_title.TabIndex = 6;
            this.l_title.Text = "Sprawdzanie wpisow ";
            this.l_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_Check
            // 
            this.l_Check.AutoSize = true;
            this.l_Check.Cursor = System.Windows.Forms.Cursors.Default;
            this.l_Check.ForeColor = System.Drawing.Color.Crimson;
            this.l_Check.Location = new System.Drawing.Point(17, 71);
            this.l_Check.MinimumSize = new System.Drawing.Size(340, 0);
            this.l_Check.Name = "l_Check";
            this.l_Check.Size = new System.Drawing.Size(340, 13);
            this.l_Check.TabIndex = 7;
            this.l_Check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.l_Check);
            this.Controls.Add(this.l_title);
            this.Controls.Add(this.tx_Input);
            this.Controls.Add(this.b_Check);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(375, 154);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tx_Input;
        private System.Windows.Forms.Button b_Check;
        private System.Windows.Forms.Label l_title;
        private System.Windows.Forms.Label l_Check;
    }
}

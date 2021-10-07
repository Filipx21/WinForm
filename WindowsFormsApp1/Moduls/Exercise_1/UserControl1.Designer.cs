
namespace WindowsFormsApp1
{
    partial class UserControl1
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
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.TextBox();
            this.l_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(253, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 22);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sprawdz";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(18, 70);
            this.label1.MinimumSize = new System.Drawing.Size(340, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 13);
            this.label1.TabIndex = 4;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(14, 38);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(226, 20);
            this.text.TabIndex = 2;
            // 
            // l_title
            // 
            this.l_title.AutoSize = true;
            this.l_title.Cursor = System.Windows.Forms.Cursors.Default;
            this.l_title.ForeColor = System.Drawing.Color.Black;
            this.l_title.Location = new System.Drawing.Point(17, 10);
            this.l_title.MinimumSize = new System.Drawing.Size(340, 0);
            this.l_title.Name = "l_title";
            this.l_title.Size = new System.Drawing.Size(340, 13);
            this.l_title.TabIndex = 7;
            this.l_title.Text = "Sprawdzanie ciagu matematycznego";
            this.l_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.l_title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text);
            this.Controls.Add(this.button3);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(375, 154);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Label l_title;
    }
}

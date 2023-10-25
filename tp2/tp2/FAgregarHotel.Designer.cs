
namespace tp2
{
    partial class FAgregarHotel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbEstrellas = new System.Windows.Forms.Label();
            this.nudEstrellas = new System.Windows.Forms.NumericUpDown();
            this.lbSimple = new System.Windows.Forms.Label();
            this.lbDobles = new System.Windows.Forms.Label();
            this.lbTriple = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstrellas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEstrellas
            // 
            this.lbEstrellas.AutoSize = true;
            this.lbEstrellas.Location = new System.Drawing.Point(45, 29);
            this.lbEstrellas.Name = "lbEstrellas";
            this.lbEstrellas.Size = new System.Drawing.Size(46, 13);
            this.lbEstrellas.TabIndex = 0;
            this.lbEstrellas.Text = "Estrellas";
            // 
            // nudEstrellas
            // 
            this.nudEstrellas.Location = new System.Drawing.Point(119, 29);
            this.nudEstrellas.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudEstrellas.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudEstrellas.Name = "nudEstrellas";
            this.nudEstrellas.Size = new System.Drawing.Size(34, 20);
            this.nudEstrellas.TabIndex = 1;
            this.nudEstrellas.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lbSimple
            // 
            this.lbSimple.AutoSize = true;
            this.lbSimple.Location = new System.Drawing.Point(45, 70);
            this.lbSimple.Name = "lbSimple";
            this.lbSimple.Size = new System.Drawing.Size(68, 13);
            this.lbSimple.TabIndex = 2;
            this.lbSimple.Text = "Cant Simples";
            // 
            // lbDobles
            // 
            this.lbDobles.AutoSize = true;
            this.lbDobles.Location = new System.Drawing.Point(45, 104);
            this.lbDobles.Name = "lbDobles";
            this.lbDobles.Size = new System.Drawing.Size(65, 13);
            this.lbDobles.TabIndex = 3;
            this.lbDobles.Text = "Cant Dobles";
            // 
            // lbTriple
            // 
            this.lbTriple.AutoSize = true;
            this.lbTriple.Location = new System.Drawing.Point(45, 136);
            this.lbTriple.Name = "lbTriple";
            this.lbTriple.Size = new System.Drawing.Size(63, 13);
            this.lbTriple.TabIndex = 4;
            this.lbTriple.Text = "Cant Triples";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(139, 70);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(139, 104);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 6;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(225, 258);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 7;
            // 
            // FAgregarHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 536);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lbTriple);
            this.Controls.Add(this.lbDobles);
            this.Controls.Add(this.lbSimple);
            this.Controls.Add(this.nudEstrellas);
            this.Controls.Add(this.lbEstrellas);
            this.Name = "FAgregarHotel";
            this.Text = "FAgregarHotel";
            ((System.ComponentModel.ISupportInitialize)(this.nudEstrellas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEstrellas;
        private System.Windows.Forms.NumericUpDown nudEstrellas;
        private System.Windows.Forms.Label lbSimple;
        private System.Windows.Forms.Label lbDobles;
        private System.Windows.Forms.Label lbTriple;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
    }
}
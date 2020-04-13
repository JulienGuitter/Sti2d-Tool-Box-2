namespace STI2D_Tool_Box.filtre
{
    partial class passeBande
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.C1Result = new System.Windows.Forms.TextBox();
            this.R1Result = new System.Windows.Forms.TextBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.FcValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.FcTitleLabel = new System.Windows.Forms.Label();
            this.R1Titlelabel = new System.Windows.Forms.Label();
            this.C1TitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FcValue)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::STI2D_Tool_Box.Properties.Resources.passe_band;
            this.pictureBox1.Location = new System.Drawing.Point(20, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 190);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // C1Result
            // 
            this.C1Result.Location = new System.Drawing.Point(457, 275);
            this.C1Result.Name = "C1Result";
            this.C1Result.ReadOnly = true;
            this.C1Result.Size = new System.Drawing.Size(127, 20);
            this.C1Result.TabIndex = 20;
            // 
            // R1Result
            // 
            this.R1Result.Location = new System.Drawing.Point(457, 228);
            this.R1Result.Name = "R1Result";
            this.R1Result.ReadOnly = true;
            this.R1Result.Size = new System.Drawing.Size(127, 20);
            this.R1Result.TabIndex = 19;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(441, 175);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(122, 23);
            this.ConvertButton.TabIndex = 18;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // FcValue
            // 
            this.FcValue.Location = new System.Drawing.Point(457, 127);
            this.FcValue.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.FcValue.Name = "FcValue";
            this.FcValue.Size = new System.Drawing.Size(96, 20);
            this.FcValue.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(553, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hz";
            // 
            // FcTitleLabel
            // 
            this.FcTitleLabel.AutoSize = true;
            this.FcTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FcTitleLabel.Location = new System.Drawing.Point(412, 127);
            this.FcTitleLabel.Name = "FcTitleLabel";
            this.FcTitleLabel.Size = new System.Drawing.Size(39, 20);
            this.FcTitleLabel.TabIndex = 15;
            this.FcTitleLabel.Text = "Fc :";
            // 
            // R1Titlelabel
            // 
            this.R1Titlelabel.AutoSize = true;
            this.R1Titlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R1Titlelabel.Location = new System.Drawing.Point(412, 229);
            this.R1Titlelabel.Name = "R1Titlelabel";
            this.R1Titlelabel.Size = new System.Drawing.Size(42, 20);
            this.R1Titlelabel.TabIndex = 14;
            this.R1Titlelabel.Text = "R1 :";
            // 
            // C1TitleLabel
            // 
            this.C1TitleLabel.AutoSize = true;
            this.C1TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1TitleLabel.Location = new System.Drawing.Point(412, 273);
            this.C1TitleLabel.Name = "C1TitleLabel";
            this.C1TitleLabel.Size = new System.Drawing.Size(41, 20);
            this.C1TitleLabel.TabIndex = 13;
            this.C1TitleLabel.Text = "C1 :";
            // 
            // passeBande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.C1Result);
            this.Controls.Add(this.R1Result);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.FcValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FcTitleLabel);
            this.Controls.Add(this.R1Titlelabel);
            this.Controls.Add(this.C1TitleLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "passeBande";
            this.Size = new System.Drawing.Size(658, 411);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FcValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox C1Result;
        private System.Windows.Forms.TextBox R1Result;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.NumericUpDown FcValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FcTitleLabel;
        private System.Windows.Forms.Label R1Titlelabel;
        private System.Windows.Forms.Label C1TitleLabel;
    }
}

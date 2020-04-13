namespace STI2D_Tool_Box
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuPannel = new System.Windows.Forms.Panel();
            this.filtreSlidePanel = new System.Windows.Forms.Panel();
            this.passeBandeButton = new System.Windows.Forms.Button();
            this.passeHautButton = new System.Windows.Forms.Button();
            this.passeBasButton = new System.Windows.Forms.Button();
            this.filtreButton = new System.Windows.Forms.Button();
            this.codeCouleurButton = new System.Windows.Forms.Button();
            this.resistanceButton = new System.Windows.Forms.Button();
            this.conversionsButton = new System.Windows.Forms.Button();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minimizButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MenuPannel.SuspendLayout();
            this.filtreSlidePanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.content.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPannel
            // 
            this.MenuPannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(65)))), ((int)(((byte)(97)))));
            this.MenuPannel.Controls.Add(this.filtreSlidePanel);
            this.MenuPannel.Controls.Add(this.filtreButton);
            this.MenuPannel.Controls.Add(this.codeCouleurButton);
            this.MenuPannel.Controls.Add(this.resistanceButton);
            this.MenuPannel.Controls.Add(this.conversionsButton);
            this.MenuPannel.Controls.Add(this.titlePanel);
            this.MenuPannel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPannel.Location = new System.Drawing.Point(0, 0);
            this.MenuPannel.Name = "MenuPannel";
            this.MenuPannel.Size = new System.Drawing.Size(142, 450);
            this.MenuPannel.TabIndex = 0;
            // 
            // filtreSlidePanel
            // 
            this.filtreSlidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(113)))), ((int)(((byte)(163)))));
            this.filtreSlidePanel.Controls.Add(this.passeBandeButton);
            this.filtreSlidePanel.Controls.Add(this.passeHautButton);
            this.filtreSlidePanel.Controls.Add(this.passeBasButton);
            this.filtreSlidePanel.Location = new System.Drawing.Point(12, 277);
            this.filtreSlidePanel.Name = "filtreSlidePanel";
            this.filtreSlidePanel.Size = new System.Drawing.Size(130, 111);
            this.filtreSlidePanel.TabIndex = 5;
            // 
            // passeBandeButton
            // 
            this.passeBandeButton.FlatAppearance.BorderSize = 0;
            this.passeBandeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passeBandeButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passeBandeButton.ForeColor = System.Drawing.Color.White;
            this.passeBandeButton.Location = new System.Drawing.Point(0, 74);
            this.passeBandeButton.Name = "passeBandeButton";
            this.passeBandeButton.Size = new System.Drawing.Size(130, 34);
            this.passeBandeButton.TabIndex = 7;
            this.passeBandeButton.Text = "Passe Bande";
            this.passeBandeButton.UseVisualStyleBackColor = false;
            this.passeBandeButton.EnabledChanged += new System.EventHandler(this.filtreColorChange);
            this.passeBandeButton.Click += new System.EventHandler(this.passeBandeButton_Click);
            // 
            // passeHautButton
            // 
            this.passeHautButton.FlatAppearance.BorderSize = 0;
            this.passeHautButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passeHautButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passeHautButton.ForeColor = System.Drawing.Color.White;
            this.passeHautButton.Location = new System.Drawing.Point(0, 37);
            this.passeHautButton.Name = "passeHautButton";
            this.passeHautButton.Size = new System.Drawing.Size(130, 34);
            this.passeHautButton.TabIndex = 6;
            this.passeHautButton.Text = "Passe Haut";
            this.passeHautButton.UseVisualStyleBackColor = false;
            this.passeHautButton.EnabledChanged += new System.EventHandler(this.filtreColorChange);
            this.passeHautButton.Click += new System.EventHandler(this.passeHautButton_Click);
            // 
            // passeBasButton
            // 
            this.passeBasButton.FlatAppearance.BorderSize = 0;
            this.passeBasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passeBasButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passeBasButton.ForeColor = System.Drawing.Color.White;
            this.passeBasButton.Location = new System.Drawing.Point(0, 0);
            this.passeBasButton.Name = "passeBasButton";
            this.passeBasButton.Size = new System.Drawing.Size(130, 34);
            this.passeBasButton.TabIndex = 5;
            this.passeBasButton.Text = "Passe Bas";
            this.passeBasButton.UseVisualStyleBackColor = false;
            this.passeBasButton.EnabledChanged += new System.EventHandler(this.filtreColorChange);
            this.passeBasButton.Click += new System.EventHandler(this.passeBasButton_Click);
            // 
            // filtreButton
            // 
            this.filtreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(94)))), ((int)(((byte)(138)))));
            this.filtreButton.FlatAppearance.BorderSize = 0;
            this.filtreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtreButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtreButton.ForeColor = System.Drawing.Color.White;
            this.filtreButton.Location = new System.Drawing.Point(0, 224);
            this.filtreButton.Name = "filtreButton";
            this.filtreButton.Size = new System.Drawing.Size(142, 53);
            this.filtreButton.TabIndex = 4;
            this.filtreButton.Text = "Filtres";
            this.filtreButton.UseVisualStyleBackColor = false;
            this.filtreButton.Click += new System.EventHandler(this.filtreButton_Click);
            // 
            // codeCouleurButton
            // 
            this.codeCouleurButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(94)))), ((int)(((byte)(138)))));
            this.codeCouleurButton.FlatAppearance.BorderSize = 0;
            this.codeCouleurButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.codeCouleurButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeCouleurButton.ForeColor = System.Drawing.Color.White;
            this.codeCouleurButton.Location = new System.Drawing.Point(0, 171);
            this.codeCouleurButton.Name = "codeCouleurButton";
            this.codeCouleurButton.Size = new System.Drawing.Size(142, 53);
            this.codeCouleurButton.TabIndex = 3;
            this.codeCouleurButton.Text = "Code Couleur";
            this.codeCouleurButton.UseVisualStyleBackColor = false;
            this.codeCouleurButton.EnabledChanged += new System.EventHandler(this.changeColor);
            this.codeCouleurButton.Click += new System.EventHandler(this.codeCouleurButton_Click);
            // 
            // resistanceButton
            // 
            this.resistanceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(94)))), ((int)(((byte)(138)))));
            this.resistanceButton.FlatAppearance.BorderSize = 0;
            this.resistanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resistanceButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resistanceButton.ForeColor = System.Drawing.Color.White;
            this.resistanceButton.Location = new System.Drawing.Point(0, 118);
            this.resistanceButton.Name = "resistanceButton";
            this.resistanceButton.Size = new System.Drawing.Size(142, 53);
            this.resistanceButton.TabIndex = 2;
            this.resistanceButton.Text = "Résistances";
            this.resistanceButton.UseVisualStyleBackColor = false;
            this.resistanceButton.EnabledChanged += new System.EventHandler(this.changeColor);
            this.resistanceButton.Click += new System.EventHandler(this.resistanceButton_Click);
            // 
            // conversionsButton
            // 
            this.conversionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(94)))), ((int)(((byte)(138)))));
            this.conversionsButton.CausesValidation = false;
            this.conversionsButton.FlatAppearance.BorderSize = 0;
            this.conversionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conversionsButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversionsButton.ForeColor = System.Drawing.Color.White;
            this.conversionsButton.Location = new System.Drawing.Point(0, 65);
            this.conversionsButton.Name = "conversionsButton";
            this.conversionsButton.Size = new System.Drawing.Size(142, 53);
            this.conversionsButton.TabIndex = 1;
            this.conversionsButton.Text = "Conversions";
            this.conversionsButton.UseVisualStyleBackColor = false;
            this.conversionsButton.EnabledChanged += new System.EventHandler(this.changeColor);
            this.conversionsButton.Click += new System.EventHandler(this.conversionsButton_Click);
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(84)))));
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.titlePanel.Location = new System.Drawing.Point(0, -1);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(142, 40);
            this.titlePanel.TabIndex = 0;
            this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.titlePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(16, 6);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(107, 28);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Tool Box";
            this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.titleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.titleLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Controls.Add(this.minimizButton);
            this.topPanel.Controls.Add(this.exitButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(142, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(658, 39);
            this.topPanel.TabIndex = 1;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // minimizButton
            // 
            this.minimizButton.FlatAppearance.BorderSize = 0;
            this.minimizButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizButton.ForeColor = System.Drawing.Color.White;
            this.minimizButton.Location = new System.Drawing.Point(587, 5);
            this.minimizButton.Name = "minimizButton";
            this.minimizButton.Size = new System.Drawing.Size(30, 30);
            this.minimizButton.TabIndex = 1;
            this.minimizButton.Text = "_";
            this.minimizButton.UseVisualStyleBackColor = true;
            this.minimizButton.Click += new System.EventHandler(this.minimizButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(620, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(30, 30);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // content
            // 
            this.content.Controls.Add(this.label1);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(142, 39);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(658, 411);
            this.content.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minecraft", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenue sur la tool box de la STI2D";
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.content);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.MenuPannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sti2d Tool Box";
            this.MenuPannel.ResumeLayout(false);
            this.filtreSlidePanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.content.ResumeLayout(false);
            this.content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPannel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Button minimizButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button conversionsButton;
        private System.Windows.Forms.Button filtreButton;
        private System.Windows.Forms.Button codeCouleurButton;
        private System.Windows.Forms.Button resistanceButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel filtreSlidePanel;
        private System.Windows.Forms.Button passeBandeButton;
        private System.Windows.Forms.Button passeHautButton;
        private System.Windows.Forms.Button passeBasButton;
        private System.Windows.Forms.Timer timer1;
    }
}


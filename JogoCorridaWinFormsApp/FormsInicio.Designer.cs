namespace JogoCorridaWinFormsApp
{
    partial class FormsInicio
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
            btnMedio = new Button();
            btnDificil = new Button();
            btnSair = new Button();
            btnFacil = new Button();
            SuspendLayout();
            // 
            // btnMedio
            // 
            btnMedio.BackColor = Color.Yellow;
            btnMedio.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnMedio.Location = new Point(337, 233);
            btnMedio.Name = "btnMedio";
            btnMedio.Size = new Size(127, 49);
            btnMedio.TabIndex = 2;
            btnMedio.Text = "MÉDIO";
            btnMedio.UseVisualStyleBackColor = false;
            btnMedio.Click += btnMedio_Click;
            // 
            // btnDificil
            // 
            btnDificil.BackColor = Color.Firebrick;
            btnDificil.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDificil.Location = new Point(567, 233);
            btnDificil.Name = "btnDificil";
            btnDificil.Size = new Size(127, 49);
            btnDificil.TabIndex = 3;
            btnDificil.Text = "DIFÍCIL";
            btnDificil.UseVisualStyleBackColor = false;
            btnDificil.Click += btnDificil_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Transparent;
            btnSair.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(362, 413);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(87, 35);
            btnSair.TabIndex = 4;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnFacil
            // 
            btnFacil.BackColor = Color.Chartreuse;
            btnFacil.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnFacil.Location = new Point(106, 233);
            btnFacil.Name = "btnFacil";
            btnFacil.Size = new Size(127, 49);
            btnFacil.TabIndex = 5;
            btnFacil.Text = "FÁCIL";
            btnFacil.UseVisualStyleBackColor = false;
            btnFacil.Click += btnFacil_Click;
            // 
            // FormsInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.selecionarDificuldade;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFacil);
            Controls.Add(btnSair);
            Controls.Add(btnDificil);
            Controls.Add(btnMedio);
            Name = "FormsInicio";
            Text = "FormsInicio";
            Load += FormsInicio_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnMedio;
        private Button btnDificil;
        private Button btnSair;
        private Button btnFacil;
    }
}
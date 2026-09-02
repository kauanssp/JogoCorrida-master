namespace JogoCorridaWinFormsApp
{
    partial class FormJogoCorrida
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
            components = new System.ComponentModel.Container();
            picCarro = new PictureBox();
            timerJogo = new System.Windows.Forms.Timer(components);
            labelPontuacao = new Label();
            ((System.ComponentModel.ISupportInitialize)picCarro).BeginInit();
            SuspendLayout();
            // 
            // picCarro
            // 
            picCarro.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            picCarro.BackColor = Color.Transparent;
            picCarro.BackgroundImage = Properties.Resources.carro_removebg_preview;
            picCarro.BackgroundImageLayout = ImageLayout.Stretch;
            picCarro.Location = new Point(278, 450);
            picCarro.Name = "picCarro";
            picCarro.Size = new Size(80, 80);
            picCarro.TabIndex = 1;
            picCarro.TabStop = false;
            // 
            // timerJogo
            // 
            timerJogo.Interval = 5;
            timerJogo.Tick += timerJogo_Tick;
            // 
            // labelPontuacao
            // 
            labelPontuacao.AutoSize = true;
            labelPontuacao.BackColor = Color.Transparent;
            labelPontuacao.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelPontuacao.ForeColor = Color.Yellow;
            labelPontuacao.Location = new Point(12, 9);
            labelPontuacao.Name = "labelPontuacao";
            labelPontuacao.Size = new Size(93, 18);
            labelPontuacao.TabIndex = 2;
            labelPontuacao.Text = "PONTOS: 0";
            labelPontuacao.Click += label1_Click;
            // 
            // FormJogoCorrida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pista1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(399, 550);
            Controls.Add(labelPontuacao);
            Controls.Add(picCarro);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormJogoCorrida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jogo Corrida - IFSP";
            Load += FormJogoCorrida_Load;
            KeyDown += FormJogoCorrida_KeyDown;
            ((System.ComponentModel.ISupportInitialize)picCarro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picCarro;
        private System.Windows.Forms.Timer timerJogo;
        private Label labelPontuacao;
    }
}

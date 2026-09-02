using JogoCorrida;
using System.Media;

namespace JogoCorridaWinFormsApp
{
    public partial class FormJogoCorrida : Form
    {
        Jogo jogo;
        DateTime tempoUltimaMovimentacao = DateTime.Now;
        List<PictureBox> pictureBoxes = [];
        public FormJogoCorrida(string Nivel)
        {
            DoubleBuffered = true;
            InitializeComponent();
            TocarSomCorrida();
            jogo = new Jogo
            {
                Faixa1Inicio = 2,
                Faixa1Fim = 198,
                Faixa2Inicio = 202,
                Faixa2Fim = 398
            };
            jogo.YMaximo = 550;
            jogo.IniciaJogo();
            jogo.Carro.PosicaoX = jogo.PosicionaObjeto(1);
            if (Nivel == "Fácil")
                jogo.Velocidade = 50;
            else if (Nivel == "Médio")
                jogo.Velocidade = 30;
            else
                jogo.Velocidade = 10;

            foreach (var ob in jogo.Obstaculos) // criação das imagens dos obstáculos
            {
                var picOb = new PictureBox();

                picOb.BackColor = Color.Transparent;

                int tipo = Random.Shared.Next(1, 4);

                if (tipo == 1)
                {
                    picOb.BackgroundImage = Properties.Resources.carro2_removebg_preview;
                }
                else if (tipo == 2)
                {
                    picOb.BackgroundImage = Properties.Resources.carroAzul;
                }
                else
                {
                    picOb.BackgroundImage = Properties.Resources.carroBranco_removebg_preview;
                }
                picOb.BackgroundImageLayout = ImageLayout.Stretch;

                pictureBoxes.Add(picOb);  // adiciona a imagem na lista interna
                this.Controls.Add(picOb); // adiciona a imagem no formulário
            }
            timerJogo.Enabled = true;
        }

        private void FormJogoCorrida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                jogo.Carro.PosicaoX = jogo.PosicionaObjeto(1);
            }
            if (e.KeyCode == Keys.Right)
            {
                jogo.Carro.PosicaoX = jogo.PosicionaObjeto(2);
            }
        }

        private void timerJogo_Tick(object sender, EventArgs e)
        {
            picCarro.Location = new Point(
                jogo.Carro.PosicaoX,
                jogo.Carro.PosicaoY
            );

            int i = 0;

            foreach (var ob in jogo.Obstaculos)
            {
                pictureBoxes[i].Location = new Point(
                    ob.PosicaoX,
                    ob.PosicaoY
                );

                i++;
            }

            if ((DateTime.Now - tempoUltimaMovimentacao).TotalMilliseconds >= jogo.Velocidade)
            {
                tempoUltimaMovimentacao = DateTime.Now;

                jogo.MovimentaObstaculos();
                jogo.AtualizaPontuacao();
                jogo.AtualizaFase();

                labelPontuacao.Text = "PONTOS: " + jogo.Pontuacao;

                if (jogo.Fase == 2)
                {
                    this.BackgroundImage =
                        Properties.Resources.pistaCorrida;
                }
            }
            if (jogo.ChecarColisao())
            {
                GameOver();
            }

            Application.DoEvents();
        }

        private void TocarSomBatida()
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = "D:\\Visual Studio Projects\\POE\\JogoCorrida27-08-master\\somBatida.wav";
            sp.Play();
            Thread.Sleep(1000);
        }

        private void TocarSomCorrida()
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = "D:\\Visual Studio Projects\\POE\\JogoCorrida27-08-master\\somJogo.wav";
            sp.Play();
        }

        private async Task GameOver()
        {
            TocarSomBatida();
            await EfeitoBatida();

            PictureBox picGameOver = new PictureBox();

            picGameOver.Image = Properties.Resources.gameOver;
            picGameOver.BackColor = Color.Black;
            picGameOver.SizeMode = PictureBoxSizeMode.StretchImage;
            picGameOver.Size = new Size(400, 550);

            picGameOver.Location = new Point(
                (this.ClientSize.Width - picGameOver.Width) / 2,
                (this.ClientSize.Height - picGameOver.Height) / 2
            );

            this.Controls.Add(picGameOver);
            picGameOver.BringToFront();

            await Task.Delay(1000);

            Application.Exit();
        }

        private async Task EfeitoBatida()
        {
            PictureBox picExplosao = new PictureBox();
            picExplosao.Image = Properties.Resources.explosao;
            picExplosao.BackColor = Color.Transparent;
            picExplosao.SizeMode = PictureBoxSizeMode.StretchImage;

            picExplosao.Size = new Size(170, 140);

            picExplosao.Location = new Point(
                jogo.Carro.PosicaoX,
                jogo.Carro.PosicaoY
            );

            this.Controls.Add(picExplosao);
            picExplosao.BringToFront();

            await Task.Delay(1000);

            picExplosao.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormJogoCorrida_Load(object sender, EventArgs e)
        {

        }
    }
}

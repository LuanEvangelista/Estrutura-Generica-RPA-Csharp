using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CascaRPA
{
    public partial class RPA_Principal : Form
    {
        private readonly Color telaCor = Color.FromArgb(226, 240, 221);

        public RPA_Principal()
        {
            InitializeComponent();
            // Inicializa a tela com o nome do robô
            DesenhaTela("RPA BOT Processar Dados");
        }

        private void DesenhaTela(string robotName)
        {
            // Configura a aparência da tela
            ScreenCor();
            // Define o nome da tela
            ScreenName(robotName);
            // Configura o nome do robô na label
            RobotNameLabel(robotName);
            // Configura os eventos do mouse para os PictureBoxes
            EventosDoMouse();
        }

        private void EventosDoMouse()
        {
            // Adiciona manipuladores de eventos de mouse para os PictureBoxes
            AdicionarManipuladorMouseEnter(pic_play);
            AdicionarManipuladorMouseEnter(pic_stop);
            AdicionarManipuladorMouseEnter(pic_log);
            AdicionarManipuladorMouseEnter(pic_set);
            AdicionarManipuladorMouseEnter(pic_icon);
        }
        private void ScreenCor() => this.BackColor = telaCor;    
        private void ScreenName(string name) => this.Text = name;
        private void RobotNameLabel(string name) => lbl_robotName.Text = name;
        private void AdicionarManipuladorMouseEnter(PictureBox pictureBox)
        {
            // Adiciona manipuladores de eventos de mouse para o PictureBox
            pictureBox.MouseEnter += (sender, e) => PictureBox_MouseEnter(sender, e, Cursors.Hand);
            pictureBox.MouseLeave += (sender,e) => PictureBox_MouseLeave(sender, e);
        }
        private void PictureBox_MouseEnter(object sender, EventArgs e, Cursor cursor)
        {
            // Altera o cursor ao entrar no PictureBox
            Cursor = cursor;
        }
        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            // Restaura o cursor padrão ao sair do PictureBox
            Cursor = Cursors.Default;
        }

        private void pic_play_Click(object sender, EventArgs e)
        {
            // Chama o método para processar dados ao clicar no botão "play"
            ProcessarDados();
        }

        private void ProcessarDados()
        {
            // Atualiza a barra de progresso e exibe uma mensagem de sucesso
            progressBar1.Value = 100;
            lbl_Valor_Dados.Text = "100/100";
            MessageBox.Show("Dados Processados");
        }
        
        private void pic_icon_Click(object sender, EventArgs e)
        {
            // Exibe uma mensagem com informações sobre os desenvolvedores
            MessageBox.Show("https://github.com/LuanEvangelista    &    https://github.com/Jefront", "Feito por Luan & Jefferson");

        }
    }
}

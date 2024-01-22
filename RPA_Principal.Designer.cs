namespace CascaRPA
{
    partial class RPA_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPA_Principal));
            this.lbl_robotName = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_Processamento_dados = new System.Windows.Forms.Label();
            this.lbl_Valor_Dados = new System.Windows.Forms.Label();
            this.pic_icon = new System.Windows.Forms.PictureBox();
            this.pic_set = new System.Windows.Forms.PictureBox();
            this.pic_log = new System.Windows.Forms.PictureBox();
            this.pic_stop = new System.Windows.Forms.PictureBox();
            this.pic_play = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_set)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_log)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_play)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_robotName
            // 
            this.lbl_robotName.AutoSize = true;
            this.lbl_robotName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_robotName.Location = new System.Drawing.Point(93, 41);
            this.lbl_robotName.Name = "lbl_robotName";
            this.lbl_robotName.Size = new System.Drawing.Size(340, 28);
            this.lbl_robotName.TabIndex = 0;
            this.lbl_robotName.Text = "RPA - CAPTURA  DE DADOS";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(34, 313);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(616, 27);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Value = 50;
            // 
            // lbl_Processamento_dados
            // 
            this.lbl_Processamento_dados.AutoSize = true;
            this.lbl_Processamento_dados.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Processamento_dados.Location = new System.Drawing.Point(29, 285);
            this.lbl_Processamento_dados.Name = "lbl_Processamento_dados";
            this.lbl_Processamento_dados.Size = new System.Drawing.Size(280, 24);
            this.lbl_Processamento_dados.TabIndex = 8;
            this.lbl_Processamento_dados.Text = "Processamento de Dados :";
            // 
            // lbl_Valor_Dados
            // 
            this.lbl_Valor_Dados.AutoSize = true;
            this.lbl_Valor_Dados.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.lbl_Valor_Dados.Location = new System.Drawing.Point(315, 284);
            this.lbl_Valor_Dados.Name = "lbl_Valor_Dados";
            this.lbl_Valor_Dados.Size = new System.Drawing.Size(86, 24);
            this.lbl_Valor_Dados.TabIndex = 9;
            this.lbl_Valor_Dados.Text = "50 / 100";
            // 
            // pic_icon
            // 
            this.pic_icon.Image = global::CascaRPA.Properties.Resources.robo;
            this.pic_icon.Location = new System.Drawing.Point(12, 12);
            this.pic_icon.Name = "pic_icon";
            this.pic_icon.Size = new System.Drawing.Size(75, 76);
            this.pic_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_icon.TabIndex = 7;
            this.pic_icon.TabStop = false;
            this.pic_icon.Click += new System.EventHandler(this.pic_icon_Click);
            // 
            // pic_set
            // 
            this.pic_set.Image = global::CascaRPA.Properties.Resources.Configuracoes;
            this.pic_set.Location = new System.Drawing.Point(510, 146);
            this.pic_set.Name = "pic_set";
            this.pic_set.Size = new System.Drawing.Size(85, 69);
            this.pic_set.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_set.TabIndex = 5;
            this.pic_set.TabStop = false;
            // 
            // pic_log
            // 
            this.pic_log.Image = global::CascaRPA.Properties.Resources.Logs2;
            this.pic_log.Location = new System.Drawing.Point(370, 146);
            this.pic_log.Name = "pic_log";
            this.pic_log.Size = new System.Drawing.Size(85, 69);
            this.pic_log.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_log.TabIndex = 4;
            this.pic_log.TabStop = false;
            // 
            // pic_stop
            // 
            this.pic_stop.Image = global::CascaRPA.Properties.Resources.Parar;
            this.pic_stop.Location = new System.Drawing.Point(230, 146);
            this.pic_stop.Name = "pic_stop";
            this.pic_stop.Size = new System.Drawing.Size(85, 69);
            this.pic_stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_stop.TabIndex = 3;
            this.pic_stop.TabStop = false;
            // 
            // pic_play
            // 
            this.pic_play.Image = global::CascaRPA.Properties.Resources.Play;
            this.pic_play.Location = new System.Drawing.Point(90, 146);
            this.pic_play.Name = "pic_play";
            this.pic_play.Size = new System.Drawing.Size(85, 69);
            this.pic_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_play.TabIndex = 2;
            this.pic_play.TabStop = false;
            this.pic_play.Click += new System.EventHandler(this.pic_play_Click);
            // 
            // RPA_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 365);
            this.Controls.Add(this.lbl_Valor_Dados);
            this.Controls.Add(this.lbl_Processamento_dados);
            this.Controls.Add(this.pic_icon);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pic_set);
            this.Controls.Add(this.pic_log);
            this.Controls.Add(this.pic_stop);
            this.Controls.Add(this.pic_play);
            this.Controls.Add(this.lbl_robotName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RPA_Principal";
            this.Text = "RPA";
            ((System.ComponentModel.ISupportInitialize)(this.pic_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_set)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_log)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_play)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_robotName;
        private System.Windows.Forms.PictureBox pic_play;
        private System.Windows.Forms.PictureBox pic_stop;
        private System.Windows.Forms.PictureBox pic_log;
        private System.Windows.Forms.PictureBox pic_set;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pic_icon;
        private System.Windows.Forms.Label lbl_Processamento_dados;
        private System.Windows.Forms.Label lbl_Valor_Dados;
    }
}


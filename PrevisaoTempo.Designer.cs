namespace PrevisaoTempo
{
    partial class frmPrevisaoTempo
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
            this.components = new System.ComponentModel.Container();
            this.lblPesquisaEstado = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCsv = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblTemperaturaMaxima = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTemperaturaMinima = new System.Windows.Forms.Label();
            this.lblResultadoTemperaturaMinima = new System.Windows.Forms.Label();
            this.lblResultadoEstado = new System.Windows.Forms.Label();
            this.lblResultadoTemperaturaMaxima = new System.Windows.Forms.Label();
            this.lblResultadoTempo = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblResultadoIuv = new System.Windows.Forms.Label();
            this.lblIuv = new System.Windows.Forms.Label();
            this.lblResultadoAtualizacao = new System.Windows.Forms.Label();
            this.lblAtualizacao = new System.Windows.Forms.Label();
            this.lblResultadoDia = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblResultadoCidade = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblErro = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblPesquisaEstado
            // 
            this.lblPesquisaEstado.AutoSize = true;
            this.lblPesquisaEstado.Location = new System.Drawing.Point(187, 78);
            this.lblPesquisaEstado.Name = "lblPesquisaEstado";
            this.lblPesquisaEstado.Size = new System.Drawing.Size(165, 17);
            this.lblPesquisaEstado.TabIndex = 2;
            this.lblPesquisaEstado.Text = "Digite o nome da cidade:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(87, 235);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(89, 38);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "&Pesquisar";
            this.toolTip1.SetToolTip(this.btnPesquisar, "Clique para pesquisar a cidade desejada");
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCsv
            // 
            this.btnCsv.Location = new System.Drawing.Point(316, 234);
            this.btnCsv.Name = "btnCsv";
            this.btnCsv.Size = new System.Drawing.Size(124, 39);
            this.btnCsv.TabIndex = 5;
            this.btnCsv.Text = "Gerar &CSV";
            this.toolTip1.SetToolTip(this.btnCsv, "Clique para gerar arquivo CSV com os dados da pesquisa");
            this.btnCsv.UseVisualStyleBackColor = true;
            this.btnCsv.Click += new System.EventHandler(this.btnCsv_Click);
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(205, 352);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(93, 38);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "&Sair";
            this.toolTip1.SetToolTip(this.btnSair, "Clique para sair da aplicação");
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(586, 211);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(56, 17);
            this.lblTempo.TabIndex = 8;
            this.lblTempo.Text = "Tempo:";
            // 
            // lblTemperaturaMaxima
            // 
            this.lblTemperaturaMaxima.AutoSize = true;
            this.lblTemperaturaMaxima.Location = new System.Drawing.Point(586, 268);
            this.lblTemperaturaMaxima.Name = "lblTemperaturaMaxima";
            this.lblTemperaturaMaxima.Size = new System.Drawing.Size(59, 17);
            this.lblTemperaturaMaxima.TabIndex = 9;
            this.lblTemperaturaMaxima.Text = "Máxima:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(586, 78);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(56, 17);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado:";
            // 
            // lblTemperaturaMinima
            // 
            this.lblTemperaturaMinima.AutoSize = true;
            this.lblTemperaturaMinima.Location = new System.Drawing.Point(586, 324);
            this.lblTemperaturaMinima.Name = "lblTemperaturaMinima";
            this.lblTemperaturaMinima.Size = new System.Drawing.Size(56, 17);
            this.lblTemperaturaMinima.TabIndex = 11;
            this.lblTemperaturaMinima.Text = "Mínima:";
            // 
            // lblResultadoTemperaturaMinima
            // 
            this.lblResultadoTemperaturaMinima.AutoSize = true;
            this.lblResultadoTemperaturaMinima.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultadoTemperaturaMinima.Location = new System.Drawing.Point(664, 324);
            this.lblResultadoTemperaturaMinima.MinimumSize = new System.Drawing.Size(58, 19);
            this.lblResultadoTemperaturaMinima.Name = "lblResultadoTemperaturaMinima";
            this.lblResultadoTemperaturaMinima.Size = new System.Drawing.Size(58, 19);
            this.lblResultadoTemperaturaMinima.TabIndex = 16;
            this.toolTip1.SetToolTip(this.lblResultadoTemperaturaMinima, "Temperatura mínima (em graus celsius) prevista para o município ou localidade sel" +
        "ecionado(a) na data referente.");
            // 
            // lblResultadoEstado
            // 
            this.lblResultadoEstado.AutoSize = true;
            this.lblResultadoEstado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultadoEstado.Location = new System.Drawing.Point(664, 76);
            this.lblResultadoEstado.MinimumSize = new System.Drawing.Size(58, 19);
            this.lblResultadoEstado.Name = "lblResultadoEstado";
            this.lblResultadoEstado.Size = new System.Drawing.Size(58, 19);
            this.lblResultadoEstado.TabIndex = 15;
            this.toolTip1.SetToolTip(this.lblResultadoEstado, "Sigla da Unidade da Federação a qual o município/localidade pertence.");
            // 
            // lblResultadoTemperaturaMaxima
            // 
            this.lblResultadoTemperaturaMaxima.AutoSize = true;
            this.lblResultadoTemperaturaMaxima.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultadoTemperaturaMaxima.Location = new System.Drawing.Point(664, 268);
            this.lblResultadoTemperaturaMaxima.MinimumSize = new System.Drawing.Size(58, 19);
            this.lblResultadoTemperaturaMaxima.Name = "lblResultadoTemperaturaMaxima";
            this.lblResultadoTemperaturaMaxima.Size = new System.Drawing.Size(58, 19);
            this.lblResultadoTemperaturaMaxima.TabIndex = 14;
            this.toolTip1.SetToolTip(this.lblResultadoTemperaturaMaxima, "Temperatura máxima (em graus celsius) prevista para o município ou localidade sel" +
        "ecionado(a) na data referente.");
            // 
            // lblResultadoTempo
            // 
            this.lblResultadoTempo.AutoSize = true;
            this.lblResultadoTempo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultadoTempo.Location = new System.Drawing.Point(664, 211);
            this.lblResultadoTempo.MinimumSize = new System.Drawing.Size(58, 19);
            this.lblResultadoTempo.Name = "lblResultadoTempo";
            this.lblResultadoTempo.Size = new System.Drawing.Size(58, 19);
            this.lblResultadoTempo.TabIndex = 13;
            this.toolTip1.SetToolTip(this.lblResultadoTempo, "Sigla que representa a condição de tempo na data referente no município ou locali" +
        "dade selecionado(a).");
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(190, 110);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(158, 22);
            this.txtCidade.TabIndex = 17;
            this.toolTip1.SetToolTip(this.txtCidade, "Digite aqui o nome da cidade que deseja buscar");
            // 
            // lblResultadoIuv
            // 
            this.lblResultadoIuv.AutoSize = true;
            this.lblResultadoIuv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultadoIuv.Location = new System.Drawing.Point(667, 382);
            this.lblResultadoIuv.MinimumSize = new System.Drawing.Size(58, 19);
            this.lblResultadoIuv.Name = "lblResultadoIuv";
            this.lblResultadoIuv.Size = new System.Drawing.Size(58, 19);
            this.lblResultadoIuv.TabIndex = 19;
            this.toolTip1.SetToolTip(this.lblResultadoIuv, "O IUV representa o valor máximo diário da radiação ultravioleta, isto é, no perío" +
        "do referente ao meio-dia solar, o horário de máxima intensidade de radiação sola" +
        "r.");
            // 
            // lblIuv
            // 
            this.lblIuv.AutoSize = true;
            this.lblIuv.Location = new System.Drawing.Point(589, 382);
            this.lblIuv.Name = "lblIuv";
            this.lblIuv.Size = new System.Drawing.Size(38, 17);
            this.lblIuv.TabIndex = 18;
            this.lblIuv.Text = "IUV: ";
            // 
            // lblResultadoAtualizacao
            // 
            this.lblResultadoAtualizacao.AutoSize = true;
            this.lblResultadoAtualizacao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultadoAtualizacao.Location = new System.Drawing.Point(664, 129);
            this.lblResultadoAtualizacao.MinimumSize = new System.Drawing.Size(58, 19);
            this.lblResultadoAtualizacao.Name = "lblResultadoAtualizacao";
            this.lblResultadoAtualizacao.Size = new System.Drawing.Size(58, 19);
            this.lblResultadoAtualizacao.TabIndex = 21;
            this.toolTip1.SetToolTip(this.lblResultadoAtualizacao, "Data da última atualização dos dados da previsão de tempo e índice ultravioleta d" +
        "o município ou localidade selecionado(a).");
            // 
            // lblAtualizacao
            // 
            this.lblAtualizacao.AutoSize = true;
            this.lblAtualizacao.Location = new System.Drawing.Point(576, 129);
            this.lblAtualizacao.Name = "lblAtualizacao";
            this.lblAtualizacao.Size = new System.Drawing.Size(85, 17);
            this.lblAtualizacao.TabIndex = 20;
            this.lblAtualizacao.Text = "Atualização:";
            // 
            // lblResultadoDia
            // 
            this.lblResultadoDia.AutoSize = true;
            this.lblResultadoDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultadoDia.Location = new System.Drawing.Point(664, 171);
            this.lblResultadoDia.MinimumSize = new System.Drawing.Size(58, 19);
            this.lblResultadoDia.Name = "lblResultadoDia";
            this.lblResultadoDia.Size = new System.Drawing.Size(58, 19);
            this.lblResultadoDia.TabIndex = 23;
            this.toolTip1.SetToolTip(this.lblResultadoDia, "Dia referente aos dados da previsão de tempo e índice ultravioleta.");
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(586, 171);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(33, 17);
            this.lblDia.TabIndex = 22;
            this.lblDia.Text = "Dia:";
            // 
            // lblResultadoCidade
            // 
            this.lblResultadoCidade.AutoSize = true;
            this.lblResultadoCidade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultadoCidade.Location = new System.Drawing.Point(664, 24);
            this.lblResultadoCidade.MinimumSize = new System.Drawing.Size(58, 19);
            this.lblResultadoCidade.Name = "lblResultadoCidade";
            this.lblResultadoCidade.Size = new System.Drawing.Size(58, 19);
            this.lblResultadoCidade.TabIndex = 25;
            this.toolTip1.SetToolTip(this.lblResultadoCidade, "Nome do município ou localidade selecionado(a).");
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(586, 24);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(56, 17);
            this.lblCidade.TabIndex = 24;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(163, 154);
            this.lblErro.MaximumSize = new System.Drawing.Size(220, 50);
            this.lblErro.MinimumSize = new System.Drawing.Size(220, 50);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(220, 50);
            this.lblErro.TabIndex = 26;
            this.lblErro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPrevisaoTempo
            // 
            this.AcceptButton = this.btnPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(955, 454);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.lblResultadoCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblResultadoDia);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblResultadoAtualizacao);
            this.Controls.Add(this.lblAtualizacao);
            this.Controls.Add(this.lblResultadoIuv);
            this.Controls.Add(this.lblIuv);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblResultadoTemperaturaMinima);
            this.Controls.Add(this.lblResultadoEstado);
            this.Controls.Add(this.lblResultadoTemperaturaMaxima);
            this.Controls.Add(this.lblResultadoTempo);
            this.Controls.Add(this.lblTemperaturaMinima);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblTemperaturaMaxima);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCsv);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblPesquisaEstado);
            this.Name = "frmPrevisaoTempo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Previsão do Tempo";
            this.toolTip1.SetToolTip(this, "Aplicação para verificar a previsão do tempo");
            this.Load += new System.EventHandler(this.frmPrevisaoTempo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPesquisaEstado;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCsv;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label lblTemperaturaMaxima;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTemperaturaMinima;
        private System.Windows.Forms.Label lblResultadoTemperaturaMinima;
        private System.Windows.Forms.Label lblResultadoEstado;
        private System.Windows.Forms.Label lblResultadoTemperaturaMaxima;
        private System.Windows.Forms.Label lblResultadoTempo;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblIuv;
        private System.Windows.Forms.Label lblResultadoAtualizacao;
        private System.Windows.Forms.Label lblAtualizacao;
        private System.Windows.Forms.Label lblResultadoDia;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblResultadoCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblResultadoIuv;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


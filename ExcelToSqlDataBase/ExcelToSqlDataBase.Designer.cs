namespace ExcelToSqlDataBase
{
    partial class ExcelToSqlDataBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelToSqlDataBase));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblLinhaLeft = new System.Windows.Forms.Label();
            this.lblTituloLeft = new System.Windows.Forms.Label();
            this.imgLogoBranco = new System.Windows.Forms.PictureBox();
            this.pnlConsultarItem = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonNao = new System.Windows.Forms.RadioButton();
            this.radioButtonSim = new System.Windows.Forms.RadioButton();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTabela = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxServidor = new System.Windows.Forms.TextBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblConsultarItem = new System.Windows.Forms.Label();
            this.imgConsultarItem = new System.Windows.Forms.PictureBox();
            this.lblLinhaConsultarItem = new System.Windows.Forms.Label();
            this.pnlProcessando = new System.Windows.Forms.Panel();
            this.lblProcessando = new System.Windows.Forms.Label();
            this.buttonExecutar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBoxScript = new System.Windows.Forms.RichTextBox();
            this.imgLimpar = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonAbrirExcel = new System.Windows.Forms.Button();
            this.BgwBtnAbrir = new System.ComponentModel.BackgroundWorker();
            this.BgwBtnExecutar = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoBranco)).BeginInit();
            this.pnlConsultarItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgConsultarItem)).BeginInit();
            this.pnlProcessando.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLimpar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Controls.Add(this.pictureBox1);
            this.pnlLeft.Controls.Add(this.lblLinhaLeft);
            this.pnlLeft.Controls.Add(this.lblTituloLeft);
            this.pnlLeft.Controls.Add(this.imgLogoBranco);
            this.pnlLeft.Location = new System.Drawing.Point(0, 1);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(271, 524);
            this.pnlLeft.TabIndex = 12;
            // 
            // lblLinhaLeft
            // 
            this.lblLinhaLeft.AutoSize = true;
            this.lblLinhaLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinhaLeft.Location = new System.Drawing.Point(31, 270);
            this.lblLinhaLeft.Name = "lblLinhaLeft";
            this.lblLinhaLeft.Size = new System.Drawing.Size(210, 25);
            this.lblLinhaLeft.TabIndex = 2;
            this.lblLinhaLeft.Text = "__________________";
            // 
            // lblTituloLeft
            // 
            this.lblTituloLeft.AutoSize = true;
            this.lblTituloLeft.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLeft.Location = new System.Drawing.Point(31, 250);
            this.lblTituloLeft.Name = "lblTituloLeft";
            this.lblTituloLeft.Size = new System.Drawing.Size(133, 25);
            this.lblTituloLeft.TabIndex = 1;
            this.lblTituloLeft.Text = "SQL DataBase";
            // 
            // imgLogoBranco
            // 
            this.imgLogoBranco.Image = ((System.Drawing.Image)(resources.GetObject("imgLogoBranco.Image")));
            this.imgLogoBranco.Location = new System.Drawing.Point(3, 32);
            this.imgLogoBranco.Name = "imgLogoBranco";
            this.imgLogoBranco.Size = new System.Drawing.Size(265, 159);
            this.imgLogoBranco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogoBranco.TabIndex = 0;
            this.imgLogoBranco.TabStop = false;
            // 
            // pnlConsultarItem
            // 
            this.pnlConsultarItem.Controls.Add(this.label5);
            this.pnlConsultarItem.Controls.Add(this.radioButtonNao);
            this.pnlConsultarItem.Controls.Add(this.radioButtonSim);
            this.pnlConsultarItem.Controls.Add(this.textBoxSenha);
            this.pnlConsultarItem.Controls.Add(this.label4);
            this.pnlConsultarItem.Controls.Add(this.textBoxUsuario);
            this.pnlConsultarItem.Controls.Add(this.label3);
            this.pnlConsultarItem.Controls.Add(this.textBoxTabela);
            this.pnlConsultarItem.Controls.Add(this.label2);
            this.pnlConsultarItem.Controls.Add(this.textBoxBase);
            this.pnlConsultarItem.Controls.Add(this.label1);
            this.pnlConsultarItem.Controls.Add(this.textBoxServidor);
            this.pnlConsultarItem.Controls.Add(this.lblItem);
            this.pnlConsultarItem.Controls.Add(this.lblConsultarItem);
            this.pnlConsultarItem.Controls.Add(this.imgConsultarItem);
            this.pnlConsultarItem.Controls.Add(this.lblLinhaConsultarItem);
            this.pnlConsultarItem.Location = new System.Drawing.Point(287, 1);
            this.pnlConsultarItem.Name = "pnlConsultarItem";
            this.pnlConsultarItem.Size = new System.Drawing.Size(283, 442);
            this.pnlConsultarItem.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tabela Criada?";
            // 
            // radioButtonNao
            // 
            this.radioButtonNao.AutoSize = true;
            this.radioButtonNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNao.Location = new System.Drawing.Point(21, 417);
            this.radioButtonNao.Name = "radioButtonNao";
            this.radioButtonNao.Size = new System.Drawing.Size(48, 17);
            this.radioButtonNao.TabIndex = 7;
            this.radioButtonNao.Text = "Nâo";
            this.radioButtonNao.UseVisualStyleBackColor = true;
            this.radioButtonNao.CheckedChanged += new System.EventHandler(this.radioButtonNao_CheckedChanged);
            // 
            // radioButtonSim
            // 
            this.radioButtonSim.AutoSize = true;
            this.radioButtonSim.Checked = true;
            this.radioButtonSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSim.Location = new System.Drawing.Point(21, 394);
            this.radioButtonSim.Name = "radioButtonSim";
            this.radioButtonSim.Size = new System.Drawing.Size(45, 17);
            this.radioButtonSim.TabIndex = 6;
            this.radioButtonSim.TabStop = true;
            this.radioButtonSim.Text = "Sim";
            this.radioButtonSim.UseVisualStyleBackColor = true;
            this.radioButtonSim.CheckedChanged += new System.EventHandler(this.radioButtonSim_CheckedChanged);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSenha.Location = new System.Drawing.Point(21, 153);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(226, 20);
            this.textBoxSenha.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Senha SQL";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(21, 100);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(226, 20);
            this.textBoxUsuario.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Usuário SQL";
            // 
            // textBoxTabela
            // 
            this.textBoxTabela.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTabela.Location = new System.Drawing.Point(21, 326);
            this.textBoxTabela.Name = "textBoxTabela";
            this.textBoxTabela.Size = new System.Drawing.Size(226, 20);
            this.textBoxTabela.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tabela SQL";
            // 
            // textBoxBase
            // 
            this.textBoxBase.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBase.Location = new System.Drawing.Point(21, 270);
            this.textBoxBase.Name = "textBoxBase";
            this.textBoxBase.Size = new System.Drawing.Size(226, 20);
            this.textBoxBase.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Base de Dados SQL";
            // 
            // textBoxServidor
            // 
            this.textBoxServidor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxServidor.Location = new System.Drawing.Point(21, 212);
            this.textBoxServidor.Name = "textBoxServidor";
            this.textBoxServidor.Size = new System.Drawing.Size(226, 20);
            this.textBoxServidor.TabIndex = 3;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(18, 187);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(93, 17);
            this.lblItem.TabIndex = 3;
            this.lblItem.Text = "Servidor SQL";
            // 
            // lblConsultarItem
            // 
            this.lblConsultarItem.AutoSize = true;
            this.lblConsultarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultarItem.Location = new System.Drawing.Point(73, 20);
            this.lblConsultarItem.Name = "lblConsultarItem";
            this.lblConsultarItem.Size = new System.Drawing.Size(92, 20);
            this.lblConsultarItem.TabIndex = 0;
            this.lblConsultarItem.Text = "Dados SQL";
            // 
            // imgConsultarItem
            // 
            this.imgConsultarItem.Image = ((System.Drawing.Image)(resources.GetObject("imgConsultarItem.Image")));
            this.imgConsultarItem.Location = new System.Drawing.Point(21, 7);
            this.imgConsultarItem.Name = "imgConsultarItem";
            this.imgConsultarItem.Size = new System.Drawing.Size(46, 39);
            this.imgConsultarItem.TabIndex = 1;
            this.imgConsultarItem.TabStop = false;
            // 
            // lblLinhaConsultarItem
            // 
            this.lblLinhaConsultarItem.AutoSize = true;
            this.lblLinhaConsultarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinhaConsultarItem.Location = new System.Drawing.Point(-4, 45);
            this.lblLinhaConsultarItem.Name = "lblLinhaConsultarItem";
            this.lblLinhaConsultarItem.Size = new System.Drawing.Size(287, 25);
            this.lblLinhaConsultarItem.TabIndex = 2;
            this.lblLinhaConsultarItem.Text = "_________________________";
            // 
            // pnlProcessando
            // 
            this.pnlProcessando.Controls.Add(this.lblProcessando);
            this.pnlProcessando.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlProcessando.Location = new System.Drawing.Point(0, 519);
            this.pnlProcessando.Name = "pnlProcessando";
            this.pnlProcessando.Size = new System.Drawing.Size(1015, 67);
            this.pnlProcessando.TabIndex = 15;
            // 
            // lblProcessando
            // 
            this.lblProcessando.AutoSize = true;
            this.lblProcessando.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessando.Location = new System.Drawing.Point(416, 12);
            this.lblProcessando.Name = "lblProcessando";
            this.lblProcessando.Size = new System.Drawing.Size(187, 29);
            this.lblProcessando.TabIndex = 0;
            this.lblProcessando.Text = "Processando...";
            this.lblProcessando.Visible = false;
            // 
            // buttonExecutar
            // 
            this.buttonExecutar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExecutar.Enabled = false;
            this.buttonExecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExecutar.ForeColor = System.Drawing.Color.Black;
            this.buttonExecutar.Location = new System.Drawing.Point(476, 474);
            this.buttonExecutar.Name = "buttonExecutar";
            this.buttonExecutar.Size = new System.Drawing.Size(94, 26);
            this.buttonExecutar.TabIndex = 9;
            this.buttonExecutar.Text = "Executar";
            this.buttonExecutar.UseVisualStyleBackColor = false;
            this.buttonExecutar.Click += new System.EventHandler(this.buttonExecutar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBoxScript);
            this.panel1.Controls.Add(this.imgLimpar);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(602, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 512);
            this.panel1.TabIndex = 16;
            // 
            // richTextBoxScript
            // 
            this.richTextBoxScript.Enabled = false;
            this.richTextBoxScript.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxScript.Location = new System.Drawing.Point(3, 75);
            this.richTextBoxScript.Name = "richTextBoxScript";
            this.richTextBoxScript.Size = new System.Drawing.Size(377, 437);
            this.richTextBoxScript.TabIndex = 10;
            this.richTextBoxScript.Text = "";
            // 
            // imgLimpar
            // 
            this.imgLimpar.Image = ((System.Drawing.Image)(resources.GetObject("imgLimpar.Image")));
            this.imgLimpar.Location = new System.Drawing.Point(78, 7);
            this.imgLimpar.Name = "imgLimpar";
            this.imgLimpar.Size = new System.Drawing.Size(44, 39);
            this.imgLimpar.TabIndex = 17;
            this.imgLimpar.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(128, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Script Create Table SQL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-4, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(397, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "___________________________________";
            // 
            // buttonAbrirExcel
            // 
            this.buttonAbrirExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAbrirExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbrirExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbrirExcel.ForeColor = System.Drawing.Color.Black;
            this.buttonAbrirExcel.Location = new System.Drawing.Point(287, 474);
            this.buttonAbrirExcel.Name = "buttonAbrirExcel";
            this.buttonAbrirExcel.Size = new System.Drawing.Size(118, 26);
            this.buttonAbrirExcel.TabIndex = 8;
            this.buttonAbrirExcel.Text = "Abrir Excel.xlsx";
            this.buttonAbrirExcel.UseVisualStyleBackColor = false;
            this.buttonAbrirExcel.Click += new System.EventHandler(this.buttonAbrirExcel_Click);
            // 
            // BgwBtnAbrir
            // 
            this.BgwBtnAbrir.WorkerReportsProgress = true;
            this.BgwBtnAbrir.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwBtnAbrir_DoWork);
            this.BgwBtnAbrir.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgwBtnAbrir_ProgressChanged);
            this.BgwBtnAbrir.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgwBtnAbrir_RunWorkerCompleted);
            // 
            // BgwBtnExecutar
            // 
            this.BgwBtnExecutar.WorkerReportsProgress = true;
            this.BgwBtnExecutar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwBtnExecutar_DoWork);
            this.BgwBtnExecutar.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgwBtnExecutar_ProgressChanged);
            this.BgwBtnExecutar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgwBtnExecutar_RunWorkerCompleted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 408);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ExcelToSqlDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 586);
            this.Controls.Add(this.buttonAbrirExcel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonExecutar);
            this.Controls.Add(this.pnlConsultarItem);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlProcessando);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ExcelToSqlDataBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel to SQL Server";
            this.Load += new System.EventHandler(this.ExcelToSqlDataBase_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoBranco)).EndInit();
            this.pnlConsultarItem.ResumeLayout(false);
            this.pnlConsultarItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgConsultarItem)).EndInit();
            this.pnlProcessando.ResumeLayout(false);
            this.pnlProcessando.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLimpar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblLinhaLeft;
        private System.Windows.Forms.Label lblTituloLeft;
        private System.Windows.Forms.PictureBox imgLogoBranco;
        private System.Windows.Forms.Panel pnlConsultarItem;
        private System.Windows.Forms.TextBox textBoxServidor;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblConsultarItem;
        private System.Windows.Forms.PictureBox imgConsultarItem;
        private System.Windows.Forms.Label lblLinhaConsultarItem;
        private System.Windows.Forms.TextBox textBoxTabela;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonExecutar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox imgLimpar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonNao;
        private System.Windows.Forms.RadioButton radioButtonSim;
        private System.Windows.Forms.Button buttonAbrirExcel;
        private System.Windows.Forms.RichTextBox richTextBoxScript;
        private System.Windows.Forms.Panel pnlProcessando;
        private System.Windows.Forms.Label lblProcessando;
        private System.ComponentModel.BackgroundWorker BgwBtnAbrir;
        private System.ComponentModel.BackgroundWorker BgwBtnExecutar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


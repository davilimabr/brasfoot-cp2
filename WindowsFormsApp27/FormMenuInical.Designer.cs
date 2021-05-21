namespace WindowsFormsApp27
{
    partial class FormMenuInical
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
            this.tabPageNovoJogo = new System.Windows.Forms.TabPage();
            this.comboBoxTimes = new System.Windows.Forms.ComboBox();
            this.labelTecnico = new System.Windows.Forms.Label();
            this.buttonComeçar = new System.Windows.Forms.Button();
            this.labelSelectTeam = new System.Windows.Forms.Label();
            this.textBoxTecnico = new System.Windows.Forms.TextBox();
            this.buttonVoltar1 = new System.Windows.Forms.Button();
            this.tabPagePrincipal = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.controleDePaginas = new System.Windows.Forms.TabControl();
            this.tabPageNovoJogo.SuspendLayout();
            this.tabPagePrincipal.SuspendLayout();
            this.controleDePaginas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageNovoJogo
            // 
            this.tabPageNovoJogo.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageNovoJogo.Controls.Add(this.buttonVoltar1);
            this.tabPageNovoJogo.Controls.Add(this.textBoxTecnico);
            this.tabPageNovoJogo.Controls.Add(this.labelSelectTeam);
            this.tabPageNovoJogo.Controls.Add(this.buttonComeçar);
            this.tabPageNovoJogo.Controls.Add(this.labelTecnico);
            this.tabPageNovoJogo.Controls.Add(this.comboBoxTimes);
            this.tabPageNovoJogo.Location = new System.Drawing.Point(4, 22);
            this.tabPageNovoJogo.Name = "tabPageNovoJogo";
            this.tabPageNovoJogo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNovoJogo.Size = new System.Drawing.Size(470, 521);
            this.tabPageNovoJogo.TabIndex = 1;
            this.tabPageNovoJogo.Text = "tabPage2";
            this.tabPageNovoJogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMenuInicial_MouseDown);
            this.tabPageNovoJogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMenuInicial_MouseMove);
            // 
            // comboBoxTimes
            // 
            this.comboBoxTimes.FormattingEnabled = true;
            this.comboBoxTimes.Location = new System.Drawing.Point(213, 222);
            this.comboBoxTimes.Name = "comboBoxTimes";
            this.comboBoxTimes.Size = new System.Drawing.Size(160, 21);
            this.comboBoxTimes.TabIndex = 0;
            // 
            // labelTecnico
            // 
            this.labelTecnico.AutoSize = true;
            this.labelTecnico.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTecnico.Location = new System.Drawing.Point(91, 176);
            this.labelTecnico.Name = "labelTecnico";
            this.labelTecnico.Size = new System.Drawing.Size(120, 19);
            this.labelTecnico.TabIndex = 1;
            this.labelTecnico.Text = "Nome do Técnico";
            // 
            // buttonComeçar
            // 
            this.buttonComeçar.BackColor = System.Drawing.Color.Teal;
            this.buttonComeçar.FlatAppearance.BorderSize = 0;
            this.buttonComeçar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComeçar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComeçar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonComeçar.Location = new System.Drawing.Point(94, 292);
            this.buttonComeçar.Name = "buttonComeçar";
            this.buttonComeçar.Size = new System.Drawing.Size(279, 65);
            this.buttonComeçar.TabIndex = 2;
            this.buttonComeçar.Text = "Começar";
            this.buttonComeçar.UseVisualStyleBackColor = false;
            this.buttonComeçar.Click += new System.EventHandler(this.buttonComeçar_Click);
            // 
            // labelSelectTeam
            // 
            this.labelSelectTeam.AutoSize = true;
            this.labelSelectTeam.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectTeam.Location = new System.Drawing.Point(91, 222);
            this.labelSelectTeam.Name = "labelSelectTeam";
            this.labelSelectTeam.Size = new System.Drawing.Size(48, 19);
            this.labelSelectTeam.TabIndex = 4;
            this.labelSelectTeam.Text = "Times";
            // 
            // textBoxTecnico
            // 
            this.textBoxTecnico.Location = new System.Drawing.Point(213, 176);
            this.textBoxTecnico.Multiline = true;
            this.textBoxTecnico.Name = "textBoxTecnico";
            this.textBoxTecnico.Size = new System.Drawing.Size(160, 20);
            this.textBoxTecnico.TabIndex = 3;
            // 
            // buttonVoltar1
            // 
            this.buttonVoltar1.BackColor = System.Drawing.Color.Teal;
            this.buttonVoltar1.FlatAppearance.BorderSize = 0;
            this.buttonVoltar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVoltar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltar1.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonVoltar1.Location = new System.Drawing.Point(409, 6);
            this.buttonVoltar1.Name = "buttonVoltar1";
            this.buttonVoltar1.Size = new System.Drawing.Size(53, 30);
            this.buttonVoltar1.TabIndex = 11;
            this.buttonVoltar1.Text = "Voltar";
            this.buttonVoltar1.UseVisualStyleBackColor = false;
            this.buttonVoltar1.Click += new System.EventHandler(this.buttonVoltar1_Click);
            // 
            // tabPagePrincipal
            // 
            this.tabPagePrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.tabPagePrincipal.Controls.Add(this.buttonSair);
            this.tabPagePrincipal.Controls.Add(this.button1);
            this.tabPagePrincipal.Controls.Add(this.label1);
            this.tabPagePrincipal.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrincipal.Name = "tabPagePrincipal";
            this.tabPagePrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrincipal.Size = new System.Drawing.Size(470, 521);
            this.tabPagePrincipal.TabIndex = 0;
            this.tabPagePrincipal.Text = "tabPage1";
            this.tabPagePrincipal.Click += new System.EventHandler(this.tabPagePrincipal_Click);
            this.tabPagePrincipal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMenuInicial_MouseDown);
            this.tabPagePrincipal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMenuInicial_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(97, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 59);
            this.label1.TabIndex = 7;
            this.label1.Text = "Brasfoot CP2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(123, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 78);
            this.button1.TabIndex = 8;
            this.button1.Text = "Novo Jogo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.Teal;
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSair.Location = new System.Drawing.Point(409, 6);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(53, 30);
            this.buttonSair.TabIndex = 10;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // controleDePaginas
            // 
            this.controleDePaginas.Controls.Add(this.tabPagePrincipal);
            this.controleDePaginas.Controls.Add(this.tabPageNovoJogo);
            this.controleDePaginas.Location = new System.Drawing.Point(-6, -23);
            this.controleDePaginas.Name = "controleDePaginas";
            this.controleDePaginas.SelectedIndex = 0;
            this.controleDePaginas.Size = new System.Drawing.Size(478, 547);
            this.controleDePaginas.TabIndex = 7;
            this.controleDePaginas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMenuInicial_MouseDown);
            this.controleDePaginas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMenuInicial_MouseMove);
            // 
            // FormMenuInical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 516);
            this.Controls.Add(this.controleDePaginas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuInical";
            this.Text = "FormMenuInical";
            this.Load += new System.EventHandler(this.FormMenuInical_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMenuInicial_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMenuInicial_MouseMove);
            this.tabPageNovoJogo.ResumeLayout(false);
            this.tabPageNovoJogo.PerformLayout();
            this.tabPagePrincipal.ResumeLayout(false);
            this.tabPagePrincipal.PerformLayout();
            this.controleDePaginas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageNovoJogo;
        private System.Windows.Forms.Button buttonVoltar1;
        private System.Windows.Forms.TextBox textBoxTecnico;
        private System.Windows.Forms.Label labelSelectTeam;
        private System.Windows.Forms.Button buttonComeçar;
        private System.Windows.Forms.Label labelTecnico;
        private System.Windows.Forms.ComboBox comboBoxTimes;
        private System.Windows.Forms.TabPage tabPagePrincipal;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl controleDePaginas;
    }
}
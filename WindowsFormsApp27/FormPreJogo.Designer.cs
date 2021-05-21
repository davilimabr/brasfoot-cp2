namespace WindowsFormsApp27
{
    partial class FormPreJogo
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.labelPTS = new System.Windows.Forms.Label();
            this.labelGC = new System.Windows.Forms.Label();
            this.labelMD = new System.Windows.Forms.Label();
            this.labelMA = new System.Windows.Forms.Label();
            this.labelGP = new System.Windows.Forms.Label();
            this.listBoxPoze = new System.Windows.Forms.ListBox();
            this.listBoxDfs = new System.Windows.Forms.ListBox();
            this.listBoxAtkk = new System.Windows.Forms.ListBox();
            this.listBoxNomeJogador = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.listBoxPoze);
            this.tabPage1.Controls.Add(this.listBoxDfs);
            this.tabPage1.Controls.Add(this.listBoxAtkk);
            this.tabPage1.Controls.Add(this.listBoxNomeJogador);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(725, 550);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMenuInicial_MouseDown);
            this.tabPage1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMenuInicial_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelSaldo);
            this.panel1.Controls.Add(this.labelPTS);
            this.panel1.Controls.Add(this.labelGC);
            this.panel1.Controls.Add(this.labelMD);
            this.panel1.Controls.Add(this.labelMA);
            this.panel1.Controls.Add(this.labelGP);
            this.panel1.Location = new System.Drawing.Point(9, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 378);
            this.panel1.TabIndex = 15;
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldo.Location = new System.Drawing.Point(3, 161);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(44, 16);
            this.labelSaldo.TabIndex = 5;
            this.labelSaldo.Text = "Saldo";
            // 
            // labelPTS
            // 
            this.labelPTS.AutoSize = true;
            this.labelPTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPTS.Location = new System.Drawing.Point(4, 183);
            this.labelPTS.Name = "labelPTS";
            this.labelPTS.Size = new System.Drawing.Size(50, 16);
            this.labelPTS.TabIndex = 4;
            this.labelPTS.Text = "Pontos";
            // 
            // labelGC
            // 
            this.labelGC.AutoSize = true;
            this.labelGC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGC.Location = new System.Drawing.Point(2, 139);
            this.labelGC.Name = "labelGC";
            this.labelGC.Size = new System.Drawing.Size(75, 16);
            this.labelGC.TabIndex = 3;
            this.labelGC.Text = "GolsContra";
            // 
            // labelMD
            // 
            this.labelMD.AutoSize = true;
            this.labelMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMD.Location = new System.Drawing.Point(2, 95);
            this.labelMD.Name = "labelMD";
            this.labelMD.Size = new System.Drawing.Size(93, 16);
            this.labelMD.TabIndex = 2;
            this.labelMD.Text = "Media Defesa";
            // 
            // labelMA
            // 
            this.labelMA.AutoSize = true;
            this.labelMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMA.Location = new System.Drawing.Point(2, 72);
            this.labelMA.Name = "labelMA";
            this.labelMA.Size = new System.Drawing.Size(101, 16);
            this.labelMA.TabIndex = 1;
            this.labelMA.Text = "Media Ataque : ";
            // 
            // labelGP
            // 
            this.labelGP.AutoSize = true;
            this.labelGP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGP.Location = new System.Drawing.Point(3, 117);
            this.labelGP.Name = "labelGP";
            this.labelGP.Size = new System.Drawing.Size(63, 16);
            this.labelGP.TabIndex = 0;
            this.labelGP.Text = "GolsPro :";
            // 
            // listBoxPoze
            // 
            this.listBoxPoze.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPoze.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPoze.FormattingEnabled = true;
            this.listBoxPoze.ItemHeight = 18;
            this.listBoxPoze.Items.AddRange(new object[] {
            "  "});
            this.listBoxPoze.Location = new System.Drawing.Point(610, 42);
            this.listBoxPoze.Name = "listBoxPoze";
            this.listBoxPoze.Size = new System.Drawing.Size(88, 378);
            this.listBoxPoze.TabIndex = 14;
            // 
            // listBoxDfs
            // 
            this.listBoxDfs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxDfs.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDfs.FormattingEnabled = true;
            this.listBoxDfs.ItemHeight = 18;
            this.listBoxDfs.Items.AddRange(new object[] {
            "  "});
            this.listBoxDfs.Location = new System.Drawing.Point(558, 42);
            this.listBoxDfs.Name = "listBoxDfs";
            this.listBoxDfs.Size = new System.Drawing.Size(52, 378);
            this.listBoxDfs.TabIndex = 13;
            // 
            // listBoxAtkk
            // 
            this.listBoxAtkk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxAtkk.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAtkk.FormattingEnabled = true;
            this.listBoxAtkk.ItemHeight = 18;
            this.listBoxAtkk.Items.AddRange(new object[] {
            "  "});
            this.listBoxAtkk.Location = new System.Drawing.Point(506, 42);
            this.listBoxAtkk.Name = "listBoxAtkk";
            this.listBoxAtkk.Size = new System.Drawing.Size(52, 378);
            this.listBoxAtkk.TabIndex = 12;
            // 
            // listBoxNomeJogador
            // 
            this.listBoxNomeJogador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxNomeJogador.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNomeJogador.FormattingEnabled = true;
            this.listBoxNomeJogador.ItemHeight = 18;
            this.listBoxNomeJogador.Items.AddRange(new object[] {
            "  "});
            this.listBoxNomeJogador.Location = new System.Drawing.Point(224, 42);
            this.listBoxNomeJogador.Name = "listBoxNomeJogador";
            this.listBoxNomeJogador.Size = new System.Drawing.Size(282, 378);
            this.listBoxNomeJogador.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(224, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 94);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tabela";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dados do time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Jogadores";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(9, 429);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(209, 94);
            this.button5.TabIndex = 7;
            this.button5.Text = "Jogar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(342, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 94);
            this.button2.TabIndex = 4;
            this.button2.Text = "Artilharia";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Teal;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(578, 429);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 94);
            this.button4.TabIndex = 6;
            this.button4.Text = "Sair do jogo";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(460, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 94);
            this.button3.TabIndex = 5;
            this.button3.Text = "Partidas";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-5, -23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(733, 576);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.listBox2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(725, 550);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Teal;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(632, 13);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 35);
            this.button6.TabIndex = 5;
            this.button6.Text = "Voltar";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(632, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gols";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome";
            // 
            // listBox2
            // 
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 19;
            this.listBox2.Items.AddRange(new object[] {
            " "});
            this.listBox2.Location = new System.Drawing.Point(632, 109);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(47, 361);
            this.listBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(314, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Artilharia";
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Items.AddRange(new object[] {
            " "});
            this.listBox1.Location = new System.Drawing.Point(49, 109);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(583, 361);
            this.listBox1.TabIndex = 0;
            // 
            // FormPreJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(723, 545);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPreJogo";
            this.Text = "FormPreJogo";
            this.Load += new System.EventHandler(this.FormPreJogo_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.Label labelPTS;
        private System.Windows.Forms.Label labelGC;
        private System.Windows.Forms.Label labelMD;
        private System.Windows.Forms.Label labelMA;
        private System.Windows.Forms.Label labelGP;
        private System.Windows.Forms.ListBox listBoxPoze;
        private System.Windows.Forms.ListBox listBoxDfs;
        private System.Windows.Forms.ListBox listBoxAtkk;
        private System.Windows.Forms.ListBox listBoxNomeJogador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button6;
    }
}
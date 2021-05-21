namespace WindowsFormsApp27
{
    partial class FormJogo
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
            this.components = new System.ComponentModel.Container();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.labelTimeA = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listBoxJogadoresA = new System.Windows.Forms.ListBox();
            this.listBoxAtaqueA = new System.Windows.Forms.ListBox();
            this.labelAtkA = new System.Windows.Forms.Label();
            this.labelDfsA = new System.Windows.Forms.Label();
            this.labelDfsB = new System.Windows.Forms.Label();
            this.labelAtkB = new System.Windows.Forms.Label();
            this.labelTimeB = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmbBoxEstilodeAttk = new System.Windows.Forms.ComboBox();
            this.cmbBoxMarcacao = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxReservasA = new System.Windows.Forms.ListBox();
            this.listBoxJogadoresB = new System.Windows.Forms.ListBox();
            this.listBoxReservasB = new System.Windows.Forms.ListBox();
            this.listBoxReservaAtkA = new System.Windows.Forms.ListBox();
            this.listBoxDefesaA = new System.Windows.Forms.ListBox();
            this.listBoxReservaDfsA = new System.Windows.Forms.ListBox();
            this.listBoxReservaDfsB = new System.Windows.Forms.ListBox();
            this.listBoxDefesaB = new System.Windows.Forms.ListBox();
            this.listBoxReservaAtkB = new System.Windows.Forms.ListBox();
            this.listBoxAtaqueB = new System.Windows.Forms.ListBox();
            this.buttonTroca = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.loadBar1 = new CircularProgressBar.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.TituStaminBarA1 = new MetroFramework.Controls.MetroProgressBar();
            this.TituStaminBarA2 = new MetroFramework.Controls.MetroProgressBar();
            this.TituStaminBarA3 = new MetroFramework.Controls.MetroProgressBar();
            this.TituStaminBarA4 = new MetroFramework.Controls.MetroProgressBar();
            this.TituStaminBarA5 = new MetroFramework.Controls.MetroProgressBar();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReserStaminBarA5 = new MetroFramework.Controls.MetroProgressBar();
            this.ReserStaminBarA4 = new MetroFramework.Controls.MetroProgressBar();
            this.ReserStaminBarA3 = new MetroFramework.Controls.MetroProgressBar();
            this.ReserStaminBarA2 = new MetroFramework.Controls.MetroProgressBar();
            this.ReserStaminBarA1 = new MetroFramework.Controls.MetroProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ReserStaminBarA6 = new MetroFramework.Controls.MetroProgressBar();
            this.ReserStaminBarA7 = new MetroFramework.Controls.MetroProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TituStaminBarB2 = new MetroFramework.Controls.MetroProgressBar();
            this.TituStaminBarB1 = new MetroFramework.Controls.MetroProgressBar();
            this.TituStaminBarB5 = new MetroFramework.Controls.MetroProgressBar();
            this.TituStaminBarB3 = new MetroFramework.Controls.MetroProgressBar();
            this.TituStaminBarB4 = new MetroFramework.Controls.MetroProgressBar();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.ReserStaminBarB7 = new MetroFramework.Controls.MetroProgressBar();
            this.ReserStaminBarB2 = new MetroFramework.Controls.MetroProgressBar();
            this.ReserStaminBarB6 = new MetroFramework.Controls.MetroProgressBar();
            this.ReserStaminBarB1 = new MetroFramework.Controls.MetroProgressBar();
            this.ReserStaminBarB5 = new MetroFramework.Controls.MetroProgressBar();
            this.ReserStaminBarB3 = new MetroFramework.Controls.MetroProgressBar();
            this.ReserStaminBarB4 = new MetroFramework.Controls.MetroProgressBar();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.labelGolA = new System.Windows.Forms.Label();
            this.labelGolB = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbBoxMarcacaoB = new System.Windows.Forms.ComboBox();
            this.cmbBoxEstilodeAttkB = new System.Windows.Forms.ComboBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.BackColor = System.Drawing.Color.Teal;
            this.buttonIniciar.FlatAppearance.BorderSize = 0;
            this.buttonIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIniciar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonIniciar.Location = new System.Drawing.Point(300, 86);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(144, 55);
            this.buttonIniciar.TabIndex = 0;
            this.buttonIniciar.Text = "Iniciar partida";
            this.buttonIniciar.UseVisualStyleBackColor = false;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonIniciar_Click);
            // 
            // labelTimeA
            // 
            this.labelTimeA.AutoSize = true;
            this.labelTimeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeA.Location = new System.Drawing.Point(16, 16);
            this.labelTimeA.Name = "labelTimeA";
            this.labelTimeA.Size = new System.Drawing.Size(58, 20);
            this.labelTimeA.TabIndex = 1;
            this.labelTimeA.Text = "Time A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(432, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 29);
            this.label10.TabIndex = 14;
            this.label10.Text = "X";
            // 
            // listBoxJogadoresA
            // 
            this.listBoxJogadoresA.BackColor = System.Drawing.Color.White;
            this.listBoxJogadoresA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxJogadoresA.FormattingEnabled = true;
            this.listBoxJogadoresA.Items.AddRange(new object[] {
            "   "});
            this.listBoxJogadoresA.Location = new System.Drawing.Point(20, 67);
            this.listBoxJogadoresA.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.listBoxJogadoresA.Name = "listBoxJogadoresA";
            this.listBoxJogadoresA.Size = new System.Drawing.Size(113, 143);
            this.listBoxJogadoresA.TabIndex = 17;
            this.listBoxJogadoresA.SelectedIndexChanged += new System.EventHandler(this.listBoxes_SelectedIndexChanged);
            // 
            // listBoxAtaqueA
            // 
            this.listBoxAtaqueA.BackColor = System.Drawing.Color.White;
            this.listBoxAtaqueA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxAtaqueA.FormattingEnabled = true;
            this.listBoxAtaqueA.Items.AddRange(new object[] {
            "   "});
            this.listBoxAtaqueA.Location = new System.Drawing.Point(135, 67);
            this.listBoxAtaqueA.Name = "listBoxAtaqueA";
            this.listBoxAtaqueA.Size = new System.Drawing.Size(43, 143);
            this.listBoxAtaqueA.TabIndex = 22;
            this.listBoxAtaqueA.SelectedIndexChanged += new System.EventHandler(this.listBoxes_SelectedIndexChanged);
            // 
            // labelAtkA
            // 
            this.labelAtkA.AutoSize = true;
            this.labelAtkA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAtkA.Location = new System.Drawing.Point(132, 50);
            this.labelAtkA.Name = "labelAtkA";
            this.labelAtkA.Size = new System.Drawing.Size(41, 13);
            this.labelAtkA.TabIndex = 24;
            this.labelAtkA.Text = "Ataque";
            // 
            // labelDfsA
            // 
            this.labelDfsA.AutoSize = true;
            this.labelDfsA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDfsA.Location = new System.Drawing.Point(177, 50);
            this.labelDfsA.Name = "labelDfsA";
            this.labelDfsA.Size = new System.Drawing.Size(41, 13);
            this.labelDfsA.TabIndex = 25;
            this.labelDfsA.Text = "Defesa";
            // 
            // labelDfsB
            // 
            this.labelDfsB.AutoSize = true;
            this.labelDfsB.Location = new System.Drawing.Point(779, 51);
            this.labelDfsB.Name = "labelDfsB";
            this.labelDfsB.Size = new System.Drawing.Size(41, 13);
            this.labelDfsB.TabIndex = 31;
            this.labelDfsB.Text = "Defesa";
            // 
            // labelAtkB
            // 
            this.labelAtkB.AutoSize = true;
            this.labelAtkB.Location = new System.Drawing.Point(730, 51);
            this.labelAtkB.Name = "labelAtkB";
            this.labelAtkB.Size = new System.Drawing.Size(41, 13);
            this.labelAtkB.TabIndex = 30;
            this.labelAtkB.Text = "Ataque";
            // 
            // labelTimeB
            // 
            this.labelTimeB.AutoSize = true;
            this.labelTimeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeB.Location = new System.Drawing.Point(618, 16);
            this.labelTimeB.Name = "labelTimeB";
            this.labelTimeB.Size = new System.Drawing.Size(58, 20);
            this.labelTimeB.TabIndex = 26;
            this.labelTimeB.Text = "Time B";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cmbBoxEstilodeAttk
            // 
            this.cmbBoxEstilodeAttk.FormattingEnabled = true;
            this.cmbBoxEstilodeAttk.Location = new System.Drawing.Point(142, 469);
            this.cmbBoxEstilodeAttk.Name = "cmbBoxEstilodeAttk";
            this.cmbBoxEstilodeAttk.Size = new System.Drawing.Size(113, 21);
            this.cmbBoxEstilodeAttk.TabIndex = 33;
            // 
            // cmbBoxMarcacao
            // 
            this.cmbBoxMarcacao.FormattingEnabled = true;
            this.cmbBoxMarcacao.Location = new System.Drawing.Point(142, 496);
            this.cmbBoxMarcacao.Name = "cmbBoxMarcacao";
            this.cmbBoxMarcacao.Size = new System.Drawing.Size(113, 21);
            this.cmbBoxMarcacao.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Estilo de Ataque ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Marcação";
            // 
            // listBoxReservasA
            // 
            this.listBoxReservasA.BackColor = System.Drawing.Color.White;
            this.listBoxReservasA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxReservasA.FormattingEnabled = true;
            this.listBoxReservasA.Items.AddRange(new object[] {
            " "});
            this.listBoxReservasA.Location = new System.Drawing.Point(20, 249);
            this.listBoxReservasA.Name = "listBoxReservasA";
            this.listBoxReservasA.Size = new System.Drawing.Size(113, 156);
            this.listBoxReservasA.TabIndex = 39;
            this.listBoxReservasA.SelectedIndexChanged += new System.EventHandler(this.listBoxes_SelectedIndexChanged);
            // 
            // listBoxJogadoresB
            // 
            this.listBoxJogadoresB.BackColor = System.Drawing.Color.White;
            this.listBoxJogadoresB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxJogadoresB.FormattingEnabled = true;
            this.listBoxJogadoresB.Items.AddRange(new object[] {
            " "});
            this.listBoxJogadoresB.Location = new System.Drawing.Point(622, 67);
            this.listBoxJogadoresB.Name = "listBoxJogadoresB";
            this.listBoxJogadoresB.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxJogadoresB.Size = new System.Drawing.Size(113, 143);
            this.listBoxJogadoresB.TabIndex = 27;
            // 
            // listBoxReservasB
            // 
            this.listBoxReservasB.BackColor = System.Drawing.Color.White;
            this.listBoxReservasB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxReservasB.FormattingEnabled = true;
            this.listBoxReservasB.Items.AddRange(new object[] {
            " "});
            this.listBoxReservasB.Location = new System.Drawing.Point(622, 249);
            this.listBoxReservasB.Name = "listBoxReservasB";
            this.listBoxReservasB.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxReservasB.Size = new System.Drawing.Size(113, 156);
            this.listBoxReservasB.TabIndex = 40;
            // 
            // listBoxReservaAtkA
            // 
            this.listBoxReservaAtkA.BackColor = System.Drawing.Color.White;
            this.listBoxReservaAtkA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxReservaAtkA.FormattingEnabled = true;
            this.listBoxReservaAtkA.Items.AddRange(new object[] {
            " "});
            this.listBoxReservaAtkA.Location = new System.Drawing.Point(135, 249);
            this.listBoxReservaAtkA.Name = "listBoxReservaAtkA";
            this.listBoxReservaAtkA.Size = new System.Drawing.Size(43, 156);
            this.listBoxReservaAtkA.TabIndex = 41;
            this.listBoxReservaAtkA.SelectedIndexChanged += new System.EventHandler(this.listBoxes_SelectedIndexChanged);
            // 
            // listBoxDefesaA
            // 
            this.listBoxDefesaA.BackColor = System.Drawing.Color.White;
            this.listBoxDefesaA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxDefesaA.FormattingEnabled = true;
            this.listBoxDefesaA.Items.AddRange(new object[] {
            " "});
            this.listBoxDefesaA.Location = new System.Drawing.Point(180, 67);
            this.listBoxDefesaA.Name = "listBoxDefesaA";
            this.listBoxDefesaA.Size = new System.Drawing.Size(43, 143);
            this.listBoxDefesaA.TabIndex = 43;
            this.listBoxDefesaA.SelectedIndexChanged += new System.EventHandler(this.listBoxes_SelectedIndexChanged);
            // 
            // listBoxReservaDfsA
            // 
            this.listBoxReservaDfsA.BackColor = System.Drawing.Color.White;
            this.listBoxReservaDfsA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxReservaDfsA.FormattingEnabled = true;
            this.listBoxReservaDfsA.Items.AddRange(new object[] {
            " "});
            this.listBoxReservaDfsA.Location = new System.Drawing.Point(180, 249);
            this.listBoxReservaDfsA.Name = "listBoxReservaDfsA";
            this.listBoxReservaDfsA.Size = new System.Drawing.Size(43, 156);
            this.listBoxReservaDfsA.TabIndex = 44;
            this.listBoxReservaDfsA.SelectedIndexChanged += new System.EventHandler(this.listBoxes_SelectedIndexChanged);
            // 
            // listBoxReservaDfsB
            // 
            this.listBoxReservaDfsB.BackColor = System.Drawing.Color.White;
            this.listBoxReservaDfsB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxReservaDfsB.FormattingEnabled = true;
            this.listBoxReservaDfsB.Items.AddRange(new object[] {
            " "});
            this.listBoxReservaDfsB.Location = new System.Drawing.Point(782, 249);
            this.listBoxReservaDfsB.Name = "listBoxReservaDfsB";
            this.listBoxReservaDfsB.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxReservaDfsB.Size = new System.Drawing.Size(43, 156);
            this.listBoxReservaDfsB.TabIndex = 48;
            // 
            // listBoxDefesaB
            // 
            this.listBoxDefesaB.BackColor = System.Drawing.Color.White;
            this.listBoxDefesaB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxDefesaB.FormattingEnabled = true;
            this.listBoxDefesaB.Items.AddRange(new object[] {
            " "});
            this.listBoxDefesaB.Location = new System.Drawing.Point(782, 67);
            this.listBoxDefesaB.Name = "listBoxDefesaB";
            this.listBoxDefesaB.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxDefesaB.Size = new System.Drawing.Size(43, 143);
            this.listBoxDefesaB.TabIndex = 47;
            // 
            // listBoxReservaAtkB
            // 
            this.listBoxReservaAtkB.BackColor = System.Drawing.Color.White;
            this.listBoxReservaAtkB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxReservaAtkB.FormattingEnabled = true;
            this.listBoxReservaAtkB.Items.AddRange(new object[] {
            " "});
            this.listBoxReservaAtkB.Location = new System.Drawing.Point(737, 249);
            this.listBoxReservaAtkB.Name = "listBoxReservaAtkB";
            this.listBoxReservaAtkB.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxReservaAtkB.Size = new System.Drawing.Size(43, 156);
            this.listBoxReservaAtkB.TabIndex = 46;
            // 
            // listBoxAtaqueB
            // 
            this.listBoxAtaqueB.BackColor = System.Drawing.Color.White;
            this.listBoxAtaqueB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxAtaqueB.FormattingEnabled = true;
            this.listBoxAtaqueB.Items.AddRange(new object[] {
            " "});
            this.listBoxAtaqueB.Location = new System.Drawing.Point(737, 67);
            this.listBoxAtaqueB.Name = "listBoxAtaqueB";
            this.listBoxAtaqueB.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxAtaqueB.Size = new System.Drawing.Size(43, 143);
            this.listBoxAtaqueB.TabIndex = 45;
            // 
            // buttonTroca
            // 
            this.buttonTroca.BackColor = System.Drawing.Color.Teal;
            this.buttonTroca.FlatAppearance.BorderSize = 0;
            this.buttonTroca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTroca.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonTroca.Location = new System.Drawing.Point(142, 439);
            this.buttonTroca.Name = "buttonTroca";
            this.buttonTroca.Size = new System.Drawing.Size(113, 21);
            this.buttonTroca.TabIndex = 49;
            this.buttonTroca.Text = "Substituir";
            this.buttonTroca.UseVisualStyleBackColor = false;
            this.buttonTroca.Click += new System.EventHandler(this.buttonTroca_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.BackColor = System.Drawing.Color.Teal;
            this.buttonPause.Enabled = false;
            this.buttonPause.FlatAppearance.BorderSize = 0;
            this.buttonPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPause.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonPause.Location = new System.Drawing.Point(445, 86);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(142, 55);
            this.buttonPause.TabIndex = 50;
            this.buttonPause.Text = "Pausar Partida";
            this.buttonPause.UseVisualStyleBackColor = false;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Titulares";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Reservas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(620, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Titulares";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(620, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Reservas";
            // 
            // loadBar1
            // 
            this.loadBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.CubicEaseIn;
            this.loadBar1.AnimationSpeed = 200;
            this.loadBar1.BackColor = System.Drawing.Color.Transparent;
            this.loadBar1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.loadBar1.ForeColor = System.Drawing.Color.Teal;
            this.loadBar1.InnerColor = System.Drawing.Color.Transparent;
            this.loadBar1.InnerMargin = 0;
            this.loadBar1.InnerWidth = -1;
            this.loadBar1.Location = new System.Drawing.Point(422, 428);
            this.loadBar1.Margin = new System.Windows.Forms.Padding(0);
            this.loadBar1.MarqueeAnimationSpeed = 6000;
            this.loadBar1.Maximum = 40;
            this.loadBar1.Name = "loadBar1";
            this.loadBar1.OuterColor = System.Drawing.Color.LightGray;
            this.loadBar1.OuterMargin = -10;
            this.loadBar1.OuterWidth = 10;
            this.loadBar1.ProgressColor = System.Drawing.Color.Teal;
            this.loadBar1.ProgressWidth = 5;
            this.loadBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.loadBar1.Size = new System.Drawing.Size(50, 50);
            this.loadBar1.StartAngle = 270;
            this.loadBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.loadBar1.SubscriptColor = System.Drawing.Color.Red;
            this.loadBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.loadBar1.SubscriptText = "";
            this.loadBar1.SuperscriptColor = System.Drawing.Color.Teal;
            this.loadBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.loadBar1.SuperscriptText = "";
            this.loadBar1.TabIndex = 56;
            this.loadBar1.Text = "0\'";
            this.loadBar1.TextMargin = new System.Windows.Forms.Padding(3, 2, 0, 0);
            this.loadBar1.Value = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Stamina";
            // 
            // TituStaminBarA1
            // 
            this.TituStaminBarA1.FontWeight = MetroFramework.MetroProgressBarWeight.Regular;
            this.TituStaminBarA1.Location = new System.Drawing.Point(0, 0);
            this.TituStaminBarA1.Margin = new System.Windows.Forms.Padding(0);
            this.TituStaminBarA1.Name = "TituStaminBarA1";
            this.TituStaminBarA1.Size = new System.Drawing.Size(43, 14);
            this.TituStaminBarA1.Style = MetroFramework.MetroColorStyle.Teal;
            this.TituStaminBarA1.TabIndex = 91;
            this.TituStaminBarA1.Value = 100;
            // 
            // TituStaminBarA2
            // 
            this.TituStaminBarA2.FontWeight = MetroFramework.MetroProgressBarWeight.Regular;
            this.TituStaminBarA2.Location = new System.Drawing.Point(0, 13);
            this.TituStaminBarA2.Margin = new System.Windows.Forms.Padding(0);
            this.TituStaminBarA2.Name = "TituStaminBarA2";
            this.TituStaminBarA2.Size = new System.Drawing.Size(43, 16);
            this.TituStaminBarA2.Style = MetroFramework.MetroColorStyle.Teal;
            this.TituStaminBarA2.TabIndex = 98;
            this.TituStaminBarA2.Value = 100;
            // 
            // TituStaminBarA3
            // 
            this.TituStaminBarA3.FontWeight = MetroFramework.MetroProgressBarWeight.Regular;
            this.TituStaminBarA3.Location = new System.Drawing.Point(0, 28);
            this.TituStaminBarA3.Margin = new System.Windows.Forms.Padding(0);
            this.TituStaminBarA3.Name = "TituStaminBarA3";
            this.TituStaminBarA3.Size = new System.Drawing.Size(43, 16);
            this.TituStaminBarA3.Style = MetroFramework.MetroColorStyle.Teal;
            this.TituStaminBarA3.TabIndex = 99;
            this.TituStaminBarA3.Value = 100;
            // 
            // TituStaminBarA4
            // 
            this.TituStaminBarA4.FontWeight = MetroFramework.MetroProgressBarWeight.Regular;
            this.TituStaminBarA4.Location = new System.Drawing.Point(0, 41);
            this.TituStaminBarA4.Margin = new System.Windows.Forms.Padding(0);
            this.TituStaminBarA4.Name = "TituStaminBarA4";
            this.TituStaminBarA4.Size = new System.Drawing.Size(43, 16);
            this.TituStaminBarA4.Style = MetroFramework.MetroColorStyle.Teal;
            this.TituStaminBarA4.TabIndex = 100;
            this.TituStaminBarA4.Value = 100;
            // 
            // TituStaminBarA5
            // 
            this.TituStaminBarA5.FontWeight = MetroFramework.MetroProgressBarWeight.Regular;
            this.TituStaminBarA5.Location = new System.Drawing.Point(0, 55);
            this.TituStaminBarA5.Margin = new System.Windows.Forms.Padding(0);
            this.TituStaminBarA5.Name = "TituStaminBarA5";
            this.TituStaminBarA5.Size = new System.Drawing.Size(43, 14);
            this.TituStaminBarA5.Style = MetroFramework.MetroColorStyle.Teal;
            this.TituStaminBarA5.TabIndex = 101;
            this.TituStaminBarA5.Value = 100;
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.White;
            this.listBox3.CausesValidation = false;
            this.listBox3.ForeColor = System.Drawing.Color.Black;
            this.listBox3.Items.AddRange(new object[] {
            " "});
            this.listBox3.Location = new System.Drawing.Point(300, 150);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(287, 264);
            this.listBox3.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(225, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(43, 156);
            this.panel1.TabIndex = 102;
            // 
            // ReserStaminBarA5
            // 
            this.ReserStaminBarA5.FontWeight = MetroFramework.MetroProgressBarWeight.Regular;
            this.ReserStaminBarA5.Location = new System.Drawing.Point(225, 304);
            this.ReserStaminBarA5.Margin = new System.Windows.Forms.Padding(0);
            this.ReserStaminBarA5.Name = "ReserStaminBarA5";
            this.ReserStaminBarA5.Size = new System.Drawing.Size(43, 14);
            this.ReserStaminBarA5.Style = MetroFramework.MetroColorStyle.Teal;
            this.ReserStaminBarA5.TabIndex = 107;
            this.ReserStaminBarA5.Value = 100;
            // 
            // ReserStaminBarA4
            // 
            this.ReserStaminBarA4.FontWeight = MetroFramework.MetroProgressBarWeight.Regular;
            this.ReserStaminBarA4.Location = new System.Drawing.Point(225, 290);
            this.ReserStaminBarA4.Margin = new System.Windows.Forms.Padding(0);
            this.ReserStaminBarA4.Name = "ReserStaminBarA4";
            this.ReserStaminBarA4.Size = new System.Drawing.Size(43, 16);
            this.ReserStaminBarA4.Style = MetroFramework.MetroColorStyle.Teal;
            this.ReserStaminBarA4.TabIndex = 106;
            this.ReserStaminBarA4.Value = 100;
            // 
            // ReserStaminBarA3
            // 
            this.ReserStaminBarA3.FontWeight = MetroFramework.MetroProgressBarWeight.Regular;
            this.ReserStaminBarA3.Location = new System.Drawing.Point(225, 277);
            this.ReserStaminBarA3.Margin = new System.Windows.Forms.Padding(0);
            this.ReserStaminBarA3.Name = "ReserStaminBarA3";
            this.ReserStaminBarA3.Size = new System.Drawing.Size(43, 16);
            this.ReserStaminBarA3.Style = MetroFramework.MetroColorStyle.Teal;
            this.ReserStaminBarA3.TabIndex = 105;
            this.ReserStaminBarA3.Value = 100;
            // 
            // ReserStaminBarA2
            // 
            this.ReserStaminBarA2.FontWeight = MetroFramework.MetroProgressBarWeight.Regular;
            this.ReserStaminBarA2.Location = new System.Drawing.Point(225, 262);
            this.ReserStaminBarA2.Margin = new System.Windows.Forms.Padding(0);
            this.ReserStaminBarA2.Name = "ReserStaminBarA2";
            this.ReserStaminBarA2.Size = new System.Drawing.Size(43, 16);
            this.ReserStaminBarA2.Style = MetroFramework.MetroColorStyle.Teal;
            this.ReserStaminBarA2.TabIndex = 104;
            this.ReserStaminBarA2.Value = 100;
            // 
            // ReserStaminBarA1
            // 
            this.ReserStaminBarA1.FontWeight = MetroFramework.MetroProgressBarWeight.Regular;
            this.ReserStaminBarA1.Location = new System.Drawing.Point(225, 249);
            this.ReserStaminBarA1.Margin = new System.Windows.Forms.Padding(0);
            this.ReserStaminBarA1.Name = "ReserStaminBarA1";
            this.ReserStaminBarA1.Size = new System.Drawing.Size(43, 14);
            this.ReserStaminBarA1.Style = MetroFramework.MetroColorStyle.Teal;
            this.ReserStaminBarA1.TabIndex = 103;
            this.ReserStaminBarA1.Value = 100;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.TituStaminBarA2);
            this.panel2.Controls.Add(this.TituStaminBarA1);
            this.panel2.Controls.Add(this.TituStaminBarA5);
            this.panel2.Controls.Add(this.TituStaminBarA3);
            this.panel2.Controls.Add(this.TituStaminBarA4);
            this.panel2.Location = new System.Drawing.Point(210, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(43, 143);
            this.panel2.TabIndex = 103;
            // 
            // ReserStaminBarA6
            // 
            this.ReserStaminBarA6.FontWeight = MetroFramework.MetroProgressBarWeight.Regular;
            this.ReserStaminBarA6.Location = new System.Drawing.Point(225, 317);
            this.ReserStaminBarA6.Margin = new System.Windows.Forms.Padding(0);
            this.ReserStaminBarA6.Name = "ReserStaminBarA6";
            this.ReserStaminBarA6.Size = new System.Drawing.Size(43, 14);
            this.ReserStaminBarA6.Style = MetroFramework.MetroColorStyle.Teal;
            this.ReserStaminBarA6.TabIndex = 108;
            this.ReserStaminBarA6.Value = 100;
            // 
            // ReserStaminBarA7
            // 
            this.ReserStaminBarA7.FontWeight = MetroFramework.MetroProgressBarWeight.Regular;
            this.ReserStaminBarA7.Location = new System.Drawing.Point(225, 330);
            this.ReserStaminBarA7.Margin = new System.Windows.Forms.Padding(0);
            this.ReserStaminBarA7.Name = "ReserStaminBarA7";
            this.ReserStaminBarA7.Size = new System.Drawing.Size(43, 14);
            this.ReserStaminBarA7.Style = MetroFramework.MetroColorStyle.Teal;
            this.ReserStaminBarA7.TabIndex = 109;
            this.ReserStaminBarA7.Value = 100;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(14, 59);
            this.panel3.Margin = new System.Windows.Forms.Padding(10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 160);
            this.panel3.TabIndex = 104;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Location = new System.Drawing.Point(-1, -1);
            this.panel4.Margin = new System.Windows.Forms.Padding(10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(260, 160);
            this.panel4.TabIndex = 105;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(14, 241);
            this.panel5.Margin = new System.Windows.Forms.Padding(10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(260, 173);
            this.panel5.TabIndex = 110;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(825, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 111;
            this.label4.Text = "Stamina";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.TituStaminBarB2);
            this.panel6.Controls.Add(this.TituStaminBarB1);
            this.panel6.Controls.Add(this.TituStaminBarB5);
            this.panel6.Controls.Add(this.TituStaminBarB3);
            this.panel6.Controls.Add(this.TituStaminBarB4);
            this.panel6.Location = new System.Drawing.Point(827, 67);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(43, 143);
            this.panel6.TabIndex = 112;
            // 
            // TituStaminBarB2
            // 
            this.TituStaminBarB2.FontWeight = MetroFramework.MetroProgressBarWeight.Regular;
            this.TituStaminBarB2.Location = new System.Drawing.Point(0, 13);
            this.TituStaminBarB2.Margin = new System.Windows.Forms.Padding(0);
            this.TituStaminBarB2.Name = "TituStaminBarB2";
            this.TituStaminBarB2.Size = new System.Drawing.Size(43, 16);
            this.TituStaminBarB2.Style = MetroFramework.MetroColorStyle.Teal;
            this.TituStaminBarB2.TabIndex = 98;
            this.TituStaminBarB2.Value = 100;
            // 
            // TituStaminBarB1
            // 
            this.TituStaminBarB1.FontWeight = MetroFramework.MetroProgressBarWeight.Regular;
            this.TituStaminBarB1.Location = new System.Drawing.Point(0, 0);
            this.TituStaminBarB1.Margin = new System.Windows.Forms.Padding(0);
            this.TituStaminBarB1.Name = "TituStaminBarB1";
            this.TituStaminBarB1.Size = new System.Drawing.Size(43, 14);
            this.TituStaminBarB1.Style = MetroFramework.MetroColorStyle.Teal;
            this.TituStaminBarB1.TabIndex = 91;
            this.TituStaminBarB1.Value = 100;
            // 
            // TituStaminBarB5
            // 
            this.TituStaminBarB5.FontWeight = MetroFramework.MetroProgressBarWeight.Regular;
            this.TituStaminBarB5.Location = new System.Drawing.Point(0, 55);
            this.TituStaminBarB5.Margin = new System.Windows.Forms.Padding(0);
            this.TituStaminBarB5.Name = "TituStaminBarB5";
            this.TituStaminBarB5.Size = new System.Drawing.Size(43, 14);
            this.TituStaminBarB5.Style = MetroFramework.MetroColorStyle.Teal;
            this.TituStaminBarB5.TabIndex = 101;
            this.TituStaminBarB5.Value = 100;
            // 
            // TituStaminBarB3
            // 
            this.TituStaminBarB3.FontWeight = MetroFramework.MetroProgressBarWeight.Regular;
            this.TituStaminBarB3.Location = new System.Drawing.Point(0, 28);
            this.TituStaminBarB3.Margin = new System.Windows.Forms.Padding(0);
            this.TituStaminBarB3.Name = "TituStaminBarB3";
            this.TituStaminBarB3.Size = new System.Drawing.Size(43, 16);
            this.TituStaminBarB3.Style = MetroFramework.MetroColorStyle.Teal;
            this.TituStaminBarB3.TabIndex = 99;
            this.TituStaminBarB3.Value = 100;
            // 
            // TituStaminBarB4
            // 
            this.TituStaminBarB4.FontWeight = MetroFramework.MetroProgressBarWeight.Regular;
            this.TituStaminBarB4.Location = new System.Drawing.Point(0, 41);
            this.TituStaminBarB4.Margin = new System.Windows.Forms.Padding(0);
            this.TituStaminBarB4.Name = "TituStaminBarB4";
            this.TituStaminBarB4.Size = new System.Drawing.Size(43, 16);
            this.TituStaminBarB4.Style = MetroFramework.MetroColorStyle.Teal;
            this.TituStaminBarB4.TabIndex = 100;
            this.TituStaminBarB4.Value = 100;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(615, 59);
            this.panel7.Margin = new System.Windows.Forms.Padding(10);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(260, 160);
            this.panel7.TabIndex = 113;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.ReserStaminBarB7);
            this.panel8.Controls.Add(this.ReserStaminBarB2);
            this.panel8.Controls.Add(this.ReserStaminBarB6);
            this.panel8.Controls.Add(this.ReserStaminBarB1);
            this.panel8.Controls.Add(this.ReserStaminBarB5);
            this.panel8.Controls.Add(this.ReserStaminBarB3);
            this.panel8.Controls.Add(this.ReserStaminBarB4);
            this.panel8.Location = new System.Drawing.Point(827, 249);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(43, 156);
            this.panel8.TabIndex = 114;
            // 
            // ReserStaminBarB7
            // 
            this.ReserStaminBarB7.FontWeight = MetroFramework.MetroProgressBarWeight.Regular;
            this.ReserStaminBarB7.Location = new System.Drawing.Point(0, 81);
            this.ReserStaminBarB7.Margin = new System.Windows.Forms.Padding(0);
            this.ReserStaminBarB7.Name = "ReserStaminBarB7";
            this.ReserStaminBarB7.Size = new System.Drawing.Size(43, 14);
            this.ReserStaminBarB7.Style = MetroFramework.MetroColorStyle.Teal;
            this.ReserStaminBarB7.TabIndex = 121;
            this.ReserStaminBarB7.Value = 100;
            // 
            // ReserStaminBarB2
            // 
            this.ReserStaminBarB2.FontWeight = MetroFramework.MetroProgressBarWeight.Regular;
            this.ReserStaminBarB2.Location = new System.Drawing.Point(0, 13);
            this.ReserStaminBarB2.Margin = new System.Windows.Forms.Padding(0);
            this.ReserStaminBarB2.Name = "ReserStaminBarB2";
            this.ReserStaminBarB2.Size = new System.Drawing.Size(43, 16);
            this.ReserStaminBarB2.Style = MetroFramework.MetroColorStyle.Teal;
            this.ReserStaminBarB2.TabIndex = 116;
            this.ReserStaminBarB2.Value = 100;
            // 
            // ReserStaminBarB6
            // 
            this.ReserStaminBarB6.FontWeight = MetroFramework.MetroProgressBarWeight.Regular;
            this.ReserStaminBarB6.Location = new System.Drawing.Point(0, 68);
            this.ReserStaminBarB6.Margin = new System.Windows.Forms.Padding(0);
            this.ReserStaminBarB6.Name = "ReserStaminBarB6";
            this.ReserStaminBarB6.Size = new System.Drawing.Size(43, 14);
            this.ReserStaminBarB6.Style = MetroFramework.MetroColorStyle.Teal;
            this.ReserStaminBarB6.TabIndex = 120;
            this.ReserStaminBarB6.Value = 100;
            // 
            // ReserStaminBarB1
            // 
            this.ReserStaminBarB1.FontWeight = MetroFramework.MetroProgressBarWeight.Regular;
            this.ReserStaminBarB1.Location = new System.Drawing.Point(0, 0);
            this.ReserStaminBarB1.Margin = new System.Windows.Forms.Padding(0);
            this.ReserStaminBarB1.Name = "ReserStaminBarB1";
            this.ReserStaminBarB1.Size = new System.Drawing.Size(43, 14);
            this.ReserStaminBarB1.Style = MetroFramework.MetroColorStyle.Teal;
            this.ReserStaminBarB1.TabIndex = 115;
            this.ReserStaminBarB1.Value = 100;
            // 
            // ReserStaminBarB5
            // 
            this.ReserStaminBarB5.FontWeight = MetroFramework.MetroProgressBarWeight.Regular;
            this.ReserStaminBarB5.Location = new System.Drawing.Point(0, 55);
            this.ReserStaminBarB5.Margin = new System.Windows.Forms.Padding(0);
            this.ReserStaminBarB5.Name = "ReserStaminBarB5";
            this.ReserStaminBarB5.Size = new System.Drawing.Size(43, 14);
            this.ReserStaminBarB5.Style = MetroFramework.MetroColorStyle.Teal;
            this.ReserStaminBarB5.TabIndex = 119;
            this.ReserStaminBarB5.Value = 100;
            // 
            // ReserStaminBarB3
            // 
            this.ReserStaminBarB3.FontWeight = MetroFramework.MetroProgressBarWeight.Regular;
            this.ReserStaminBarB3.Location = new System.Drawing.Point(0, 28);
            this.ReserStaminBarB3.Margin = new System.Windows.Forms.Padding(0);
            this.ReserStaminBarB3.Name = "ReserStaminBarB3";
            this.ReserStaminBarB3.Size = new System.Drawing.Size(43, 16);
            this.ReserStaminBarB3.Style = MetroFramework.MetroColorStyle.Teal;
            this.ReserStaminBarB3.TabIndex = 117;
            this.ReserStaminBarB3.Value = 100;
            // 
            // ReserStaminBarB4
            // 
            this.ReserStaminBarB4.FontWeight = MetroFramework.MetroProgressBarWeight.Regular;
            this.ReserStaminBarB4.Location = new System.Drawing.Point(0, 41);
            this.ReserStaminBarB4.Margin = new System.Windows.Forms.Padding(0);
            this.ReserStaminBarB4.Name = "ReserStaminBarB4";
            this.ReserStaminBarB4.Size = new System.Drawing.Size(43, 16);
            this.ReserStaminBarB4.Style = MetroFramework.MetroColorStyle.Teal;
            this.ReserStaminBarB4.TabIndex = 118;
            this.ReserStaminBarB4.Value = 100;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Location = new System.Drawing.Point(615, 240);
            this.panel9.Margin = new System.Windows.Forms.Padding(10);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(260, 173);
            this.panel9.TabIndex = 115;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Location = new System.Drawing.Point(14, 428);
            this.panel10.Margin = new System.Windows.Forms.Padding(10);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(260, 100);
            this.panel10.TabIndex = 116;
            // 
            // labelGolA
            // 
            this.labelGolA.AutoSize = true;
            this.labelGolA.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGolA.Location = new System.Drawing.Point(356, 47);
            this.labelGolA.Name = "labelGolA";
            this.labelGolA.Size = new System.Drawing.Size(29, 33);
            this.labelGolA.TabIndex = 117;
            this.labelGolA.Text = "0";
            this.labelGolA.Click += new System.EventHandler(this.labelGolA_Click);
            // 
            // labelGolB
            // 
            this.labelGolB.AutoSize = true;
            this.labelGolB.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGolB.Location = new System.Drawing.Point(501, 47);
            this.labelGolB.Name = "labelGolB";
            this.labelGolB.Size = new System.Drawing.Size(29, 33);
            this.labelGolB.TabIndex = 118;
            this.labelGolB.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(629, 499);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 123;
            this.label9.Text = "Marcação";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(629, 477);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 122;
            this.label11.Text = "Estilo de Ataque ";
            // 
            // cmbBoxMarcacaoB
            // 
            this.cmbBoxMarcacaoB.Enabled = false;
            this.cmbBoxMarcacaoB.FormattingEnabled = true;
            this.cmbBoxMarcacaoB.Location = new System.Drawing.Point(740, 496);
            this.cmbBoxMarcacaoB.Name = "cmbBoxMarcacaoB";
            this.cmbBoxMarcacaoB.Size = new System.Drawing.Size(113, 21);
            this.cmbBoxMarcacaoB.TabIndex = 121;
            // 
            // cmbBoxEstilodeAttkB
            // 
            this.cmbBoxEstilodeAttkB.Enabled = false;
            this.cmbBoxEstilodeAttkB.FormattingEnabled = true;
            this.cmbBoxEstilodeAttkB.Location = new System.Drawing.Point(740, 469);
            this.cmbBoxEstilodeAttkB.Name = "cmbBoxEstilodeAttkB";
            this.cmbBoxEstilodeAttkB.Size = new System.Drawing.Size(113, 21);
            this.cmbBoxEstilodeAttkB.TabIndex = 120;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Transparent;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Location = new System.Drawing.Point(615, 428);
            this.panel11.Margin = new System.Windows.Forms.Padding(10);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(260, 100);
            this.panel11.TabIndex = 125;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.BackColor = System.Drawing.Color.Teal;
            this.buttonVoltar.FlatAppearance.BorderSize = 0;
            this.buttonVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVoltar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonVoltar.Location = new System.Drawing.Point(402, 490);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(94, 38);
            this.buttonVoltar.TabIndex = 126;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = false;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // FormJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(887, 541);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbBoxMarcacaoB);
            this.Controls.Add(this.cmbBoxEstilodeAttkB);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.labelGolB);
            this.Controls.Add(this.labelGolA);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReserStaminBarA7);
            this.Controls.Add(this.ReserStaminBarA6);
            this.Controls.Add(this.ReserStaminBarA5);
            this.Controls.Add(this.ReserStaminBarA4);
            this.Controls.Add(this.ReserStaminBarA3);
            this.Controls.Add(this.listBoxDefesaA);
            this.Controls.Add(this.ReserStaminBarA2);
            this.Controls.Add(this.ReserStaminBarA1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadBar1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonTroca);
            this.Controls.Add(this.listBoxReservaDfsB);
            this.Controls.Add(this.listBoxDefesaB);
            this.Controls.Add(this.listBoxReservaAtkB);
            this.Controls.Add(this.listBoxAtaqueB);
            this.Controls.Add(this.listBoxReservaDfsA);
            this.Controls.Add(this.listBoxReservaAtkA);
            this.Controls.Add(this.listBoxReservasB);
            this.Controls.Add(this.listBoxReservasA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBoxMarcacao);
            this.Controls.Add(this.cmbBoxEstilodeAttk);
            this.Controls.Add(this.labelDfsB);
            this.Controls.Add(this.labelAtkB);
            this.Controls.Add(this.listBoxJogadoresB);
            this.Controls.Add(this.labelTimeB);
            this.Controls.Add(this.labelDfsA);
            this.Controls.Add(this.labelAtkA);
            this.Controls.Add(this.listBoxAtaqueA);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelTimeA);
            this.Controls.Add(this.buttonIniciar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBoxJogadoresA);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormJogo";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "BRASFOOTÃO DO CP2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormJogo_FormClosed);
            this.Load += new System.EventHandler(this.FormJogo_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMenuInicial_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMenuInicial_MouseMove);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.Label labelTimeA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBoxJogadoresA;
        private System.Windows.Forms.ListBox listBoxAtaqueA;
        private System.Windows.Forms.Label labelAtkA;
        private System.Windows.Forms.Label labelDfsA;
        private System.Windows.Forms.Label labelDfsB;
        private System.Windows.Forms.Label labelAtkB;
        private System.Windows.Forms.Label labelTimeB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cmbBoxEstilodeAttk;
        private System.Windows.Forms.ComboBox cmbBoxMarcacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxReservasA;
        private System.Windows.Forms.ListBox listBoxJogadoresB;
        private System.Windows.Forms.ListBox listBoxReservasB;
        private System.Windows.Forms.ListBox listBoxReservaAtkA;
        private System.Windows.Forms.ListBox listBoxDefesaA;
        private System.Windows.Forms.ListBox listBoxReservaDfsA;
        private System.Windows.Forms.ListBox listBoxReservaDfsB;
        private System.Windows.Forms.ListBox listBoxDefesaB;
        private System.Windows.Forms.ListBox listBoxReservaAtkB;
        private System.Windows.Forms.ListBox listBoxAtaqueB;
        private System.Windows.Forms.Button buttonTroca;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private CircularProgressBar.CircularProgressBar loadBar1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroProgressBar TituStaminBarA1;
        private MetroFramework.Controls.MetroProgressBar TituStaminBarA2;
        private MetroFramework.Controls.MetroProgressBar TituStaminBarA3;
        private MetroFramework.Controls.MetroProgressBar TituStaminBarA4;
        private System.Windows.Forms.ListBox listBox3;
        public MetroFramework.Controls.MetroProgressBar TituStaminBarA5;
        private System.Windows.Forms.Panel panel1;
        public MetroFramework.Controls.MetroProgressBar ReserStaminBarA5;
        private MetroFramework.Controls.MetroProgressBar ReserStaminBarA4;
        private MetroFramework.Controls.MetroProgressBar ReserStaminBarA3;
        private MetroFramework.Controls.MetroProgressBar ReserStaminBarA2;
        private MetroFramework.Controls.MetroProgressBar ReserStaminBarA1;
        private System.Windows.Forms.Panel panel2;
        public MetroFramework.Controls.MetroProgressBar ReserStaminBarA6;
        public MetroFramework.Controls.MetroProgressBar ReserStaminBarA7;
        protected System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Panel panel4;
        protected System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private MetroFramework.Controls.MetroProgressBar TituStaminBarB2;
        private MetroFramework.Controls.MetroProgressBar TituStaminBarB1;
        public MetroFramework.Controls.MetroProgressBar TituStaminBarB5;
        private MetroFramework.Controls.MetroProgressBar TituStaminBarB3;
        private MetroFramework.Controls.MetroProgressBar TituStaminBarB4;
        protected System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        public MetroFramework.Controls.MetroProgressBar ReserStaminBarB7;
        private MetroFramework.Controls.MetroProgressBar ReserStaminBarB2;
        public MetroFramework.Controls.MetroProgressBar ReserStaminBarB6;
        private MetroFramework.Controls.MetroProgressBar ReserStaminBarB1;
        public MetroFramework.Controls.MetroProgressBar ReserStaminBarB5;
        private MetroFramework.Controls.MetroProgressBar ReserStaminBarB3;
        private MetroFramework.Controls.MetroProgressBar ReserStaminBarB4;
        protected System.Windows.Forms.Panel panel9;
        protected System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label labelGolA;
        private System.Windows.Forms.Label labelGolB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbBoxMarcacaoB;
        private System.Windows.Forms.ComboBox cmbBoxEstilodeAttkB;
        protected System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button buttonVoltar;
    }
}


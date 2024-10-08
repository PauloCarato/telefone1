namespace telefone1
{
    partial class entrar_tela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(entrar_tela));
            cadastrar = new Button();
            EntrarBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            SenhaInput = new TextBox();
            UsuarioInput = new TextBox();
            menuStrip1 = new MenuStrip();
            sairToolStripMenuItem = new ToolStripMenuItem();
            SairMenu1 = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cadastrar
            // 
            cadastrar.Location = new Point(26, 199);
            cadastrar.Name = "cadastrar";
            cadastrar.Size = new Size(91, 23);
            cadastrar.TabIndex = 11;
            cadastrar.Text = "cadastrar";
            cadastrar.UseVisualStyleBackColor = true;
            cadastrar.Click += cadastrar_Click;
            // 
            // EntrarBtn
            // 
            EntrarBtn.Location = new Point(26, 161);
            EntrarBtn.Name = "EntrarBtn";
            EntrarBtn.Size = new Size(91, 32);
            EntrarBtn.TabIndex = 10;
            EntrarBtn.Text = "entrar";
            EntrarBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 103);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 9;
            label2.Text = "Senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 40);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 8;
            label1.Text = "Usuário";
            // 
            // SenhaInput
            // 
            SenhaInput.Location = new Point(26, 121);
            SenhaInput.Name = "SenhaInput";
            SenhaInput.Size = new Size(171, 23);
            SenhaInput.TabIndex = 7;
            SenhaInput.TextChanged += SenhaInput_TextChanged;
            // 
            // UsuarioInput
            // 
            UsuarioInput.Location = new Point(26, 58);
            UsuarioInput.Name = "UsuarioInput";
            UsuarioInput.Size = new Size(171, 23);
            UsuarioInput.TabIndex = 6;
            UsuarioInput.TextChanged += UsuarioInput_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(399, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SairMenu1 });
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(59, 20);
            sairToolStripMenuItem.Text = "arquivo";
            // 
            // SairMenu1
            // 
            SairMenu1.Name = "SairMenu1";
            SairMenu1.Size = new Size(92, 22);
            SairMenu1.Text = "sair";
            SairMenu1.Click += SairMenu1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(235, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // entrar_tela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 297);
            Controls.Add(pictureBox1);
            Controls.Add(cadastrar);
            Controls.Add(EntrarBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SenhaInput);
            Controls.Add(UsuarioInput);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "entrar_tela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "entrar_tela";
            FormClosed += entrar_tela_FormClosed;
            Load += entrar_tela_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cadastrar;
        private Button EntrarBtn;
        private Label label2;
        private Label label1;
        private TextBox SenhaInput;
        private TextBox UsuarioInput;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem SairMenu1;
        private PictureBox pictureBox1;
    }
}
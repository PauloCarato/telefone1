﻿namespace telefone1
{
    partial class cadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastrar));
            cadastrarBTN = new Button();
            label2 = new Label();
            label1 = new Label();
            SenhaCreate = new TextBox();
            UsuárioCreate = new TextBox();
            label3 = new Label();
            TelefoneCreate = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cadastrarBTN
            // 
            cadastrarBTN.Location = new Point(28, 214);
            cadastrarBTN.Name = "cadastrarBTN";
            cadastrarBTN.Size = new Size(112, 23);
            cadastrarBTN.TabIndex = 11;
            cadastrarBTN.Text = "cadastrar";
            cadastrarBTN.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 93);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 9;
            label2.Text = "Senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 39);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 8;
            label1.Text = "Usuário";
            // 
            // SenhaCreate
            // 
            SenhaCreate.Location = new Point(28, 111);
            SenhaCreate.Name = "SenhaCreate";
            SenhaCreate.Size = new Size(174, 23);
            SenhaCreate.TabIndex = 7;
            SenhaCreate.TextChanged += SenhaCreate_TextChanged;
            // 
            // UsuárioCreate
            // 
            UsuárioCreate.Location = new Point(28, 57);
            UsuárioCreate.Name = "UsuárioCreate";
            UsuárioCreate.Size = new Size(174, 23);
            UsuárioCreate.TabIndex = 6;
            UsuárioCreate.TextChanged += UsuárioCreate_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 154);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 13;
            label3.Text = "Telefone";
            // 
            // TelefoneCreate
            // 
            TelefoneCreate.Location = new Point(28, 172);
            TelefoneCreate.Name = "TelefoneCreate";
            TelefoneCreate.Size = new Size(174, 23);
            TelefoneCreate.TabIndex = 12;
            TelefoneCreate.TextChanged += TelefoneCreate_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(308, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // cadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 313);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(TelefoneCreate);
            Controls.Add(cadastrarBTN);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SenhaCreate);
            Controls.Add(UsuárioCreate);
            Name = "cadastrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "cadastrar";
            Load += cadastrar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cadastrarBTN;
        private Label label2;
        private Label label1;
        private TextBox SenhaCreate;
        private TextBox UsuárioCreate;
        private Label label3;
        private TextBox TelefoneCreate;
        private PictureBox pictureBox1;
    }
}
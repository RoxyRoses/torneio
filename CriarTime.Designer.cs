
namespace torneio
{
    partial class CriarTime
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
            this.criarTimeLabel = new System.Windows.Forms.Label();
            this.nomeTimeLabel = new System.Windows.Forms.Label();
            this.nomeTimeTextBox = new System.Windows.Forms.TextBox();
            this.membroTimeLabel = new System.Windows.Forms.Label();
            this.membroTimecomboBox = new System.Windows.Forms.ComboBox();
            this.AddMembroButton = new System.Windows.Forms.Button();
            this.addMembroGroupBox = new System.Windows.Forms.GroupBox();
            this.Nomelabel = new System.Windows.Forms.Label();
            this.sobrenomeLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.celularLabel = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.sobrenomeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.celularTextBox = new System.Windows.Forms.TextBox();
            this.criarMembroButton = new System.Windows.Forms.Button();
            this.jogadorListBox = new System.Windows.Forms.ListBox();
            this.timeButton = new System.Windows.Forms.Button();
            this.addMembroGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // criarTimeLabel
            // 
            this.criarTimeLabel.AutoSize = true;
            this.criarTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criarTimeLabel.Location = new System.Drawing.Point(34, 34);
            this.criarTimeLabel.Name = "criarTimeLabel";
            this.criarTimeLabel.Size = new System.Drawing.Size(113, 25);
            this.criarTimeLabel.TabIndex = 0;
            this.criarTimeLabel.Text = "Criar Time";
            // 
            // nomeTimeLabel
            // 
            this.nomeTimeLabel.AutoSize = true;
            this.nomeTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTimeLabel.Location = new System.Drawing.Point(36, 87);
            this.nomeTimeLabel.Name = "nomeTimeLabel";
            this.nomeTimeLabel.Size = new System.Drawing.Size(89, 17);
            this.nomeTimeLabel.TabIndex = 1;
            this.nomeTimeLabel.Text = "Nome Time";
            // 
            // nomeTimeTextBox
            // 
            this.nomeTimeTextBox.Location = new System.Drawing.Point(39, 123);
            this.nomeTimeTextBox.Name = "nomeTimeTextBox";
            this.nomeTimeTextBox.Size = new System.Drawing.Size(224, 20);
            this.nomeTimeTextBox.TabIndex = 2;
            // 
            // membroTimeLabel
            // 
            this.membroTimeLabel.AutoSize = true;
            this.membroTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membroTimeLabel.Location = new System.Drawing.Point(36, 169);
            this.membroTimeLabel.Name = "membroTimeLabel";
            this.membroTimeLabel.Size = new System.Drawing.Size(181, 17);
            this.membroTimeLabel.TabIndex = 3;
            this.membroTimeLabel.Text = "Selecione Membro Time";
            // 
            // membroTimecomboBox
            // 
            this.membroTimecomboBox.FormattingEnabled = true;
            this.membroTimecomboBox.Location = new System.Drawing.Point(39, 199);
            this.membroTimecomboBox.Name = "membroTimecomboBox";
            this.membroTimecomboBox.Size = new System.Drawing.Size(224, 21);
            this.membroTimecomboBox.TabIndex = 4;
            // 
            // AddMembroButton
            // 
            this.AddMembroButton.Location = new System.Drawing.Point(83, 239);
            this.AddMembroButton.Name = "AddMembroButton";
            this.AddMembroButton.Size = new System.Drawing.Size(124, 23);
            this.AddMembroButton.TabIndex = 5;
            this.AddMembroButton.Text = "Adicionar Membro";
            this.AddMembroButton.UseVisualStyleBackColor = true;
            // 
            // addMembroGroupBox
            // 
            this.addMembroGroupBox.Controls.Add(this.criarMembroButton);
            this.addMembroGroupBox.Controls.Add(this.celularTextBox);
            this.addMembroGroupBox.Controls.Add(this.emailTextBox);
            this.addMembroGroupBox.Controls.Add(this.sobrenomeTextBox);
            this.addMembroGroupBox.Controls.Add(this.nomeTextBox);
            this.addMembroGroupBox.Controls.Add(this.celularLabel);
            this.addMembroGroupBox.Controls.Add(this.emailLabel);
            this.addMembroGroupBox.Controls.Add(this.sobrenomeLabel);
            this.addMembroGroupBox.Controls.Add(this.Nomelabel);
            this.addMembroGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMembroGroupBox.Location = new System.Drawing.Point(39, 287);
            this.addMembroGroupBox.Name = "addMembroGroupBox";
            this.addMembroGroupBox.Size = new System.Drawing.Size(281, 222);
            this.addMembroGroupBox.TabIndex = 7;
            this.addMembroGroupBox.TabStop = false;
            this.addMembroGroupBox.Text = "Adicionar Novo Membro";
            // 
            // Nomelabel
            // 
            this.Nomelabel.AutoSize = true;
            this.Nomelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nomelabel.Location = new System.Drawing.Point(6, 42);
            this.Nomelabel.Name = "Nomelabel";
            this.Nomelabel.Size = new System.Drawing.Size(114, 17);
            this.Nomelabel.TabIndex = 8;
            this.Nomelabel.Text = "Primeiro Nome";
            // 
            // sobrenomeLabel
            // 
            this.sobrenomeLabel.AutoSize = true;
            this.sobrenomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobrenomeLabel.Location = new System.Drawing.Point(6, 74);
            this.sobrenomeLabel.Name = "sobrenomeLabel";
            this.sobrenomeLabel.Size = new System.Drawing.Size(90, 17);
            this.sobrenomeLabel.TabIndex = 9;
            this.sobrenomeLabel.Text = "Sobrenome";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(6, 107);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(47, 17);
            this.emailLabel.TabIndex = 10;
            this.emailLabel.Text = "Email";
            // 
            // celularLabel
            // 
            this.celularLabel.AutoSize = true;
            this.celularLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celularLabel.Location = new System.Drawing.Point(6, 141);
            this.celularLabel.Name = "celularLabel";
            this.celularLabel.Size = new System.Drawing.Size(59, 17);
            this.celularLabel.TabIndex = 11;
            this.celularLabel.Text = "Celular";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(126, 42);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(149, 23);
            this.nomeTextBox.TabIndex = 8;
            // 
            // sobrenomeTextBox
            // 
            this.sobrenomeTextBox.Location = new System.Drawing.Point(126, 74);
            this.sobrenomeTextBox.Name = "sobrenomeTextBox";
            this.sobrenomeTextBox.Size = new System.Drawing.Size(149, 23);
            this.sobrenomeTextBox.TabIndex = 12;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(126, 107);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(149, 23);
            this.emailTextBox.TabIndex = 13;
            // 
            // celularTextBox
            // 
            this.celularTextBox.Location = new System.Drawing.Point(126, 135);
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(149, 23);
            this.celularTextBox.TabIndex = 14;
            // 
            // criarMembroButton
            // 
            this.criarMembroButton.Location = new System.Drawing.Point(59, 184);
            this.criarMembroButton.Name = "criarMembroButton";
            this.criarMembroButton.Size = new System.Drawing.Size(151, 23);
            this.criarMembroButton.TabIndex = 8;
            this.criarMembroButton.Text = "Criar Membro";
            this.criarMembroButton.UseVisualStyleBackColor = true;
            // 
            // jogadorListBox
            // 
            this.jogadorListBox.FormattingEnabled = true;
            this.jogadorListBox.Location = new System.Drawing.Point(342, 128);
            this.jogadorListBox.Name = "jogadorListBox";
            this.jogadorListBox.Size = new System.Drawing.Size(314, 381);
            this.jogadorListBox.TabIndex = 8;
            // 
            // timeButton
            // 
            this.timeButton.Location = new System.Drawing.Point(264, 546);
            this.timeButton.Name = "timeButton";
            this.timeButton.Size = new System.Drawing.Size(151, 23);
            this.timeButton.TabIndex = 15;
            this.timeButton.Text = "Criar Time";
            this.timeButton.UseVisualStyleBackColor = true;
            // 
            // CriarTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 581);
            this.Controls.Add(this.timeButton);
            this.Controls.Add(this.jogadorListBox);
            this.Controls.Add(this.addMembroGroupBox);
            this.Controls.Add(this.AddMembroButton);
            this.Controls.Add(this.membroTimecomboBox);
            this.Controls.Add(this.membroTimeLabel);
            this.Controls.Add(this.nomeTimeTextBox);
            this.Controls.Add(this.nomeTimeLabel);
            this.Controls.Add(this.criarTimeLabel);
            this.Name = "CriarTime";
            this.Text = "Criar Time";
            this.addMembroGroupBox.ResumeLayout(false);
            this.addMembroGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label criarTimeLabel;
        private System.Windows.Forms.Label nomeTimeLabel;
        private System.Windows.Forms.TextBox nomeTimeTextBox;
        private System.Windows.Forms.Label membroTimeLabel;
        private System.Windows.Forms.ComboBox membroTimecomboBox;
        private System.Windows.Forms.Button AddMembroButton;
        private System.Windows.Forms.GroupBox addMembroGroupBox;
        private System.Windows.Forms.Button criarMembroButton;
        private System.Windows.Forms.TextBox celularTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox sobrenomeTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label celularLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label sobrenomeLabel;
        private System.Windows.Forms.Label Nomelabel;
        private System.Windows.Forms.ListBox jogadorListBox;
        private System.Windows.Forms.Button timeButton;
    }
}
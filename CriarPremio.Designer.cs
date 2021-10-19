
namespace torneio
{
    partial class CriarPremio
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
            this.label1 = new System.Windows.Forms.Label();
            this.numeroLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.premioLabel = new System.Windows.Forms.Label();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.premioTextBox = new System.Windows.Forms.TextBox();
            this.ouLabel = new System.Windows.Forms.Label();
            this.pocentagemLabel = new System.Windows.Forms.Label();
            this.porcentagemTextBox = new System.Windows.Forms.TextBox();
            this.premioButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criar Premio";
            // 
            // numeroLabel
            // 
            this.numeroLabel.AutoSize = true;
            this.numeroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroLabel.Location = new System.Drawing.Point(39, 103);
            this.numeroLabel.Name = "numeroLabel";
            this.numeroLabel.Size = new System.Drawing.Size(125, 17);
            this.numeroLabel.TabIndex = 1;
            this.numeroLabel.Text = "Digite o Numero";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLabel.Location = new System.Drawing.Point(39, 154);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(110, 17);
            this.nomeLabel.TabIndex = 2;
            this.nomeLabel.Text = "Digite o Nome";
            // 
            // premioLabel
            // 
            this.premioLabel.AutoSize = true;
            this.premioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.premioLabel.Location = new System.Drawing.Point(39, 208);
            this.premioLabel.Name = "premioLabel";
            this.premioLabel.Size = new System.Drawing.Size(119, 17);
            this.premioLabel.TabIndex = 3;
            this.premioLabel.Text = "Digite o Premio";
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.Location = new System.Drawing.Point(246, 100);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(168, 20);
            this.numeroTextBox.TabIndex = 4;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(246, 151);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(168, 20);
            this.nomeTextBox.TabIndex = 5;
            // 
            // premioTextBox
            // 
            this.premioTextBox.Location = new System.Drawing.Point(246, 205);
            this.premioTextBox.Name = "premioTextBox";
            this.premioTextBox.Size = new System.Drawing.Size(168, 20);
            this.premioTextBox.TabIndex = 6;
            // 
            // ouLabel
            // 
            this.ouLabel.AutoSize = true;
            this.ouLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ouLabel.Location = new System.Drawing.Point(191, 252);
            this.ouLabel.Name = "ouLabel";
            this.ouLabel.Size = new System.Drawing.Size(48, 17);
            this.ouLabel.TabIndex = 7;
            this.ouLabel.Text = "- ou -";
            // 
            // pocentagemLabel
            // 
            this.pocentagemLabel.AutoSize = true;
            this.pocentagemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pocentagemLabel.Location = new System.Drawing.Point(39, 306);
            this.pocentagemLabel.Name = "pocentagemLabel";
            this.pocentagemLabel.Size = new System.Drawing.Size(158, 17);
            this.pocentagemLabel.TabIndex = 8;
            this.pocentagemLabel.Text = "Porcentagem Premio";
            this.pocentagemLabel.Click += new System.EventHandler(this.pocentagemLabel_Click);
            // 
            // porcentagemTextBox
            // 
            this.porcentagemTextBox.Location = new System.Drawing.Point(246, 305);
            this.porcentagemTextBox.Name = "porcentagemTextBox";
            this.porcentagemTextBox.Size = new System.Drawing.Size(168, 20);
            this.porcentagemTextBox.TabIndex = 9;
            // 
            // premioButton
            // 
            this.premioButton.Location = new System.Drawing.Point(160, 390);
            this.premioButton.Name = "premioButton";
            this.premioButton.Size = new System.Drawing.Size(126, 23);
            this.premioButton.TabIndex = 10;
            this.premioButton.Text = "Criar Premio";
            this.premioButton.UseVisualStyleBackColor = true;
            this.premioButton.Click += new System.EventHandler(this.premioButton_Click);
            // 
            // CriarPremio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 445);
            this.Controls.Add(this.premioButton);
            this.Controls.Add(this.porcentagemTextBox);
            this.Controls.Add(this.pocentagemLabel);
            this.Controls.Add(this.ouLabel);
            this.Controls.Add(this.premioTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(this.premioLabel);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.numeroLabel);
            this.Controls.Add(this.label1);
            this.Name = "CriarPremio";
            this.Text = "Criar Premio";
            this.Load += new System.EventHandler(this.CriarPremio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numeroLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label premioLabel;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox premioTextBox;
        private System.Windows.Forms.Label ouLabel;
        private System.Windows.Forms.Label pocentagemLabel;
        private System.Windows.Forms.TextBox porcentagemTextBox;
        private System.Windows.Forms.Button premioButton;
    }
}
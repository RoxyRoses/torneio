
namespace torneio
{
    partial class TorneioUI
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
            this.torneioLabel = new System.Windows.Forms.Label();
            this.nomeTorneioLabel = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundComboBox = new System.Windows.Forms.ComboBox();
            this.naoJogadosCheckBox = new System.Windows.Forms.CheckBox();
            this.confrontoListBox = new System.Windows.Forms.ListBox();
            this.timeUmLabel = new System.Windows.Forms.Label();
            this.pontosUmLabel = new System.Windows.Forms.Label();
            this.timeUmTextBox = new System.Windows.Forms.TextBox();
            this.timeDoisTextBox = new System.Windows.Forms.TextBox();
            this.pontosDoislabel = new System.Windows.Forms.Label();
            this.timeDoisLabel = new System.Windows.Forms.Label();
            this.versusLabel = new System.Windows.Forms.Label();
            this.pontosButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // torneioLabel
            // 
            this.torneioLabel.AutoSize = true;
            this.torneioLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.torneioLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.torneioLabel.Location = new System.Drawing.Point(12, 25);
            this.torneioLabel.Name = "torneioLabel";
            this.torneioLabel.Size = new System.Drawing.Size(113, 35);
            this.torneioLabel.TabIndex = 0;
            this.torneioLabel.Text = "Torneio:";
            // 
            // nomeTorneioLabel
            // 
            this.nomeTorneioLabel.AutoSize = true;
            this.nomeTorneioLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTorneioLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.nomeTorneioLabel.Location = new System.Drawing.Point(131, 25);
            this.nomeTorneioLabel.Name = "nomeTorneioLabel";
            this.nomeTorneioLabel.Size = new System.Drawing.Size(129, 35);
            this.nomeTorneioLabel.TabIndex = 1;
            this.nomeTorneioLabel.Text = "<nenhum>";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.roundLabel.Location = new System.Drawing.Point(13, 84);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(65, 26);
            this.roundLabel.TabIndex = 2;
            this.roundLabel.Text = "Round";
            // 
            // roundComboBox
            // 
            this.roundComboBox.FormattingEnabled = true;
            this.roundComboBox.Location = new System.Drawing.Point(106, 73);
            this.roundComboBox.Name = "roundComboBox";
            this.roundComboBox.Size = new System.Drawing.Size(191, 37);
            this.roundComboBox.TabIndex = 3;
            // 
            // naoJogadosCheckBox
            // 
            this.naoJogadosCheckBox.AutoSize = true;
            this.naoJogadosCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.naoJogadosCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naoJogadosCheckBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.naoJogadosCheckBox.Location = new System.Drawing.Point(106, 116);
            this.naoJogadosCheckBox.Name = "naoJogadosCheckBox";
            this.naoJogadosCheckBox.Size = new System.Drawing.Size(210, 30);
            this.naoJogadosCheckBox.TabIndex = 4;
            this.naoJogadosCheckBox.Text = "Nao Jogados Apenas";
            this.naoJogadosCheckBox.UseVisualStyleBackColor = true;
            // 
            // confrontoListBox
            // 
            this.confrontoListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confrontoListBox.FormattingEnabled = true;
            this.confrontoListBox.ItemHeight = 29;
            this.confrontoListBox.Location = new System.Drawing.Point(18, 174);
            this.confrontoListBox.Name = "confrontoListBox";
            this.confrontoListBox.Size = new System.Drawing.Size(279, 234);
            this.confrontoListBox.TabIndex = 5;
            // 
            // timeUmLabel
            // 
            this.timeUmLabel.AutoSize = true;
            this.timeUmLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeUmLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.timeUmLabel.Location = new System.Drawing.Point(335, 174);
            this.timeUmLabel.Name = "timeUmLabel";
            this.timeUmLabel.Size = new System.Drawing.Size(103, 26);
            this.timeUmLabel.TabIndex = 6;
            this.timeUmLabel.Text = "<Time Um>";
            // 
            // pontosUmLabel
            // 
            this.pontosUmLabel.AutoSize = true;
            this.pontosUmLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pontosUmLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.pontosUmLabel.Location = new System.Drawing.Point(335, 213);
            this.pontosUmLabel.Name = "pontosUmLabel";
            this.pontosUmLabel.Size = new System.Drawing.Size(69, 26);
            this.pontosUmLabel.TabIndex = 7;
            this.pontosUmLabel.Text = "Pontos";
            // 
            // timeUmTextBox
            // 
            this.timeUmTextBox.Location = new System.Drawing.Point(444, 202);
            this.timeUmTextBox.Name = "timeUmTextBox";
            this.timeUmTextBox.Size = new System.Drawing.Size(100, 37);
            this.timeUmTextBox.TabIndex = 8;
            // 
            // timeDoisTextBox
            // 
            this.timeDoisTextBox.Location = new System.Drawing.Point(444, 336);
            this.timeDoisTextBox.Name = "timeDoisTextBox";
            this.timeDoisTextBox.Size = new System.Drawing.Size(100, 37);
            this.timeDoisTextBox.TabIndex = 11;
            this.timeDoisTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pontosDoislabel
            // 
            this.pontosDoislabel.AutoSize = true;
            this.pontosDoislabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pontosDoislabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.pontosDoislabel.Location = new System.Drawing.Point(335, 347);
            this.pontosDoislabel.Name = "pontosDoislabel";
            this.pontosDoislabel.Size = new System.Drawing.Size(69, 26);
            this.pontosDoislabel.TabIndex = 10;
            this.pontosDoislabel.Text = "Pontos";
            this.pontosDoislabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // timeDoisLabel
            // 
            this.timeDoisLabel.AutoSize = true;
            this.timeDoisLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeDoisLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.timeDoisLabel.Location = new System.Drawing.Point(335, 308);
            this.timeDoisLabel.Name = "timeDoisLabel";
            this.timeDoisLabel.Size = new System.Drawing.Size(111, 26);
            this.timeDoisLabel.TabIndex = 9;
            this.timeDoisLabel.Text = "<Time Dois>";
            this.timeDoisLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // versusLabel
            // 
            this.versusLabel.AutoSize = true;
            this.versusLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versusLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.versusLabel.Location = new System.Drawing.Point(415, 263);
            this.versusLabel.Name = "versusLabel";
            this.versusLabel.Size = new System.Drawing.Size(65, 26);
            this.versusLabel.TabIndex = 12;
            this.versusLabel.Text = "- VS -";
            // 
            // pontosButton
            // 
            this.pontosButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.pontosButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.pontosButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pontosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pontosButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.pontosButton.Location = new System.Drawing.Point(575, 248);
            this.pontosButton.Name = "pontosButton";
            this.pontosButton.Size = new System.Drawing.Size(103, 53);
            this.pontosButton.TabIndex = 13;
            this.pontosButton.Text = "Ponto";
            this.pontosButton.UseVisualStyleBackColor = true;
            // 
            // TorneioUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(710, 438);
            this.Controls.Add(this.pontosButton);
            this.Controls.Add(this.versusLabel);
            this.Controls.Add(this.timeDoisTextBox);
            this.Controls.Add(this.pontosDoislabel);
            this.Controls.Add(this.timeDoisLabel);
            this.Controls.Add(this.timeUmTextBox);
            this.Controls.Add(this.pontosUmLabel);
            this.Controls.Add(this.timeUmLabel);
            this.Controls.Add(this.confrontoListBox);
            this.Controls.Add(this.naoJogadosCheckBox);
            this.Controls.Add(this.roundComboBox);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.nomeTorneioLabel);
            this.Controls.Add(this.torneioLabel);
            this.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "TorneioUI";
            this.Text = "Torneio";
            this.Load += new System.EventHandler(this.TorneioUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label torneioLabel;
        private System.Windows.Forms.Label nomeTorneioLabel;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ComboBox roundComboBox;
        private System.Windows.Forms.CheckBox naoJogadosCheckBox;
        private System.Windows.Forms.ListBox confrontoListBox;
        private System.Windows.Forms.Label timeUmLabel;
        private System.Windows.Forms.Label pontosUmLabel;
        private System.Windows.Forms.TextBox timeUmTextBox;
        private System.Windows.Forms.TextBox timeDoisTextBox;
        private System.Windows.Forms.Label pontosDoislabel;
        private System.Windows.Forms.Label timeDoisLabel;
        private System.Windows.Forms.Label versusLabel;
        private System.Windows.Forms.Button pontosButton;
    }
}
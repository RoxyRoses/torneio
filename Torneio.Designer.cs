
namespace torneio
{
    partial class torneioForm
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
            this.torneioLabel = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundComboBox = new System.Windows.Forms.ComboBox();
            this.unplayedCheckBox = new System.Windows.Forms.CheckBox();
            this.marchupListbox = new System.Windows.Forms.ListBox();
            this.time1Label = new System.Windows.Forms.Label();
            this.resultadoTime1 = new System.Windows.Forms.Label();
            this.Resultado1TextBox = new System.Windows.Forms.TextBox();
            this.vsLabel = new System.Windows.Forms.Label();
            this.time2Label = new System.Windows.Forms.Label();
            this.resultado2Label = new System.Windows.Forms.Label();
            this.resultado2TextBox = new System.Windows.Forms.TextBox();
            this.ResultadoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // torneioLabel
            // 
            this.torneioLabel.AutoSize = true;
            this.torneioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.torneioLabel.Location = new System.Drawing.Point(33, 51);
            this.torneioLabel.Name = "torneioLabel";
            this.torneioLabel.Size = new System.Drawing.Size(85, 25);
            this.torneioLabel.TabIndex = 0;
            this.torneioLabel.Text = "Torneio:";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.Location = new System.Drawing.Point(35, 97);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(55, 17);
            this.roundLabel.TabIndex = 1;
            this.roundLabel.Text = "Round";
            // 
            // roundComboBox
            // 
            this.roundComboBox.FormattingEnabled = true;
            this.roundComboBox.Location = new System.Drawing.Point(119, 97);
            this.roundComboBox.Name = "roundComboBox";
            this.roundComboBox.Size = new System.Drawing.Size(168, 21);
            this.roundComboBox.TabIndex = 2;
            // 
            // unplayedCheckBox
            // 
            this.unplayedCheckBox.AutoSize = true;
            this.unplayedCheckBox.Location = new System.Drawing.Point(119, 136);
            this.unplayedCheckBox.Name = "unplayedCheckBox";
            this.unplayedCheckBox.Size = new System.Drawing.Size(115, 17);
            this.unplayedCheckBox.TabIndex = 3;
            this.unplayedCheckBox.Text = "Jogos nao jogados";
            this.unplayedCheckBox.UseVisualStyleBackColor = true;
            // 
            // marchupListbox
            // 
            this.marchupListbox.FormattingEnabled = true;
            this.marchupListbox.Location = new System.Drawing.Point(38, 172);
            this.marchupListbox.Name = "marchupListbox";
            this.marchupListbox.Size = new System.Drawing.Size(290, 212);
            this.marchupListbox.TabIndex = 4;
            // 
            // time1Label
            // 
            this.time1Label.AutoSize = true;
            this.time1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time1Label.Location = new System.Drawing.Point(385, 174);
            this.time1Label.Name = "time1Label";
            this.time1Label.Size = new System.Drawing.Size(62, 20);
            this.time1Label.TabIndex = 5;
            this.time1Label.Text = "Time 1";
            // 
            // resultadoTime1
            // 
            this.resultadoTime1.AutoSize = true;
            this.resultadoTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoTime1.Location = new System.Drawing.Point(386, 220);
            this.resultadoTime1.Name = "resultadoTime1";
            this.resultadoTime1.Size = new System.Drawing.Size(81, 17);
            this.resultadoTime1.TabIndex = 6;
            this.resultadoTime1.Text = "Resultado";
            // 
            // Resultado1TextBox
            // 
            this.Resultado1TextBox.Location = new System.Drawing.Point(490, 220);
            this.Resultado1TextBox.Name = "Resultado1TextBox";
            this.Resultado1TextBox.Size = new System.Drawing.Size(82, 20);
            this.Resultado1TextBox.TabIndex = 7;
            // 
            // vsLabel
            // 
            this.vsLabel.AutoSize = true;
            this.vsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsLabel.Location = new System.Drawing.Point(453, 262);
            this.vsLabel.Name = "vsLabel";
            this.vsLabel.Size = new System.Drawing.Size(33, 20);
            this.vsLabel.TabIndex = 8;
            this.vsLabel.Text = "VS";
            // 
            // time2Label
            // 
            this.time2Label.AutoSize = true;
            this.time2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time2Label.Location = new System.Drawing.Point(385, 303);
            this.time2Label.Name = "time2Label";
            this.time2Label.Size = new System.Drawing.Size(62, 20);
            this.time2Label.TabIndex = 9;
            this.time2Label.Text = "Time 2";
            // 
            // resultado2Label
            // 
            this.resultado2Label.AutoSize = true;
            this.resultado2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado2Label.Location = new System.Drawing.Point(386, 349);
            this.resultado2Label.Name = "resultado2Label";
            this.resultado2Label.Size = new System.Drawing.Size(81, 17);
            this.resultado2Label.TabIndex = 10;
            this.resultado2Label.Text = "Resultado";
            // 
            // resultado2TextBox
            // 
            this.resultado2TextBox.Location = new System.Drawing.Point(490, 346);
            this.resultado2TextBox.Name = "resultado2TextBox";
            this.resultado2TextBox.Size = new System.Drawing.Size(82, 20);
            this.resultado2TextBox.TabIndex = 11;
            // 
            // ResultadoButton
            // 
            this.ResultadoButton.Location = new System.Drawing.Point(616, 273);
            this.ResultadoButton.Name = "ResultadoButton";
            this.ResultadoButton.Size = new System.Drawing.Size(75, 23);
            this.ResultadoButton.TabIndex = 12;
            this.ResultadoButton.Text = "Resultado";
            this.ResultadoButton.UseVisualStyleBackColor = true;
            // 
            // torneioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 401);
            this.Controls.Add(this.ResultadoButton);
            this.Controls.Add(this.resultado2TextBox);
            this.Controls.Add(this.resultado2Label);
            this.Controls.Add(this.time2Label);
            this.Controls.Add(this.vsLabel);
            this.Controls.Add(this.Resultado1TextBox);
            this.Controls.Add(this.resultadoTime1);
            this.Controls.Add(this.time1Label);
            this.Controls.Add(this.marchupListbox);
            this.Controls.Add(this.unplayedCheckBox);
            this.Controls.Add(this.roundComboBox);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.torneioLabel);
            this.Name = "torneioForm";
            this.Text = "Torneio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label torneioLabel;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ComboBox roundComboBox;
        private System.Windows.Forms.CheckBox unplayedCheckBox;
        private System.Windows.Forms.ListBox marchupListbox;
        private System.Windows.Forms.Label time1Label;
        private System.Windows.Forms.Label resultadoTime1;
        private System.Windows.Forms.TextBox Resultado1TextBox;
        private System.Windows.Forms.Label vsLabel;
        private System.Windows.Forms.Label time2Label;
        private System.Windows.Forms.Label resultado2Label;
        private System.Windows.Forms.TextBox resultado2TextBox;
        private System.Windows.Forms.Button ResultadoButton;
    }
}


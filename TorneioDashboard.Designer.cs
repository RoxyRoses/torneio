
namespace torneio
{
    partial class TorneioDashboard
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
            this.label2 = new System.Windows.Forms.Label();
            this.torneioComboBox = new System.Windows.Forms.ComboBox();
            this.torneioButton = new System.Windows.Forms.Button();
            this.criarTorneioButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Painel de Controle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carregar Torneio";
            // 
            // torneioComboBox
            // 
            this.torneioComboBox.FormattingEnabled = true;
            this.torneioComboBox.IntegralHeight = false;
            this.torneioComboBox.Location = new System.Drawing.Point(42, 130);
            this.torneioComboBox.Name = "torneioComboBox";
            this.torneioComboBox.Size = new System.Drawing.Size(305, 21);
            this.torneioComboBox.TabIndex = 2;
            // 
            // torneioButton
            // 
            this.torneioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.torneioButton.Location = new System.Drawing.Point(122, 174);
            this.torneioButton.Name = "torneioButton";
            this.torneioButton.Size = new System.Drawing.Size(134, 38);
            this.torneioButton.TabIndex = 3;
            this.torneioButton.Text = "Carregar Torneio";
            this.torneioButton.UseVisualStyleBackColor = true;
            // 
            // criarTorneioButton
            // 
            this.criarTorneioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criarTorneioButton.Location = new System.Drawing.Point(53, 241);
            this.criarTorneioButton.Name = "criarTorneioButton";
            this.criarTorneioButton.Size = new System.Drawing.Size(274, 79);
            this.criarTorneioButton.TabIndex = 4;
            this.criarTorneioButton.Text = "Criar Torneio";
            this.criarTorneioButton.UseVisualStyleBackColor = true;
            // 
            // TorneioDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 349);
            this.Controls.Add(this.criarTorneioButton);
            this.Controls.Add(this.torneioButton);
            this.Controls.Add(this.torneioComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TorneioDashboard";
            this.Text = "Painel de Controle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox torneioComboBox;
        private System.Windows.Forms.Button torneioButton;
        private System.Windows.Forms.Button criarTorneioButton;
    }
}
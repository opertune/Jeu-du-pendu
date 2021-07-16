namespace btnWinForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpButton = new System.Windows.Forms.GroupBox();
            this.grpMot = new System.Windows.Forms.GroupBox();
            this.txtMot = new System.Windows.Forms.TextBox();
            this.pctPendu = new System.Windows.Forms.PictureBox();
            this.btnRetry = new System.Windows.Forms.Button();
            this.lblResultat = new System.Windows.Forms.Label();
            this.grpMot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPendu)).BeginInit();
            this.SuspendLayout();
            // 
            // grpButton
            // 
            this.grpButton.Location = new System.Drawing.Point(12, 87);
            this.grpButton.Name = "grpButton";
            this.grpButton.Size = new System.Drawing.Size(237, 97);
            this.grpButton.TabIndex = 0;
            this.grpButton.TabStop = false;
            this.grpButton.Text = "lettres";
            // 
            // grpMot
            // 
            this.grpMot.Controls.Add(this.txtMot);
            this.grpMot.Location = new System.Drawing.Point(12, 12);
            this.grpMot.Name = "grpMot";
            this.grpMot.Size = new System.Drawing.Size(237, 69);
            this.grpMot.TabIndex = 1;
            this.grpMot.TabStop = false;
            this.grpMot.Text = "mot à chercher";
            // 
            // txtMot
            // 
            this.txtMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMot.Location = new System.Drawing.Point(6, 22);
            this.txtMot.Multiline = true;
            this.txtMot.Name = "txtMot";
            this.txtMot.Size = new System.Drawing.Size(225, 40);
            this.txtMot.TabIndex = 0;
            this.txtMot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMot_KeyPress);
            // 
            // pctPendu
            // 
            this.pctPendu.Image = global::btnWinForms.Properties.Resources.pendu0;
            this.pctPendu.Location = new System.Drawing.Point(258, 13);
            this.pctPendu.Name = "pctPendu";
            this.pctPendu.Size = new System.Drawing.Size(221, 234);
            this.pctPendu.TabIndex = 3;
            this.pctPendu.TabStop = false;
            // 
            // btnRetry
            // 
            this.btnRetry.Image = global::btnWinForms.Properties.Resources.playagain;
            this.btnRetry.Location = new System.Drawing.Point(201, 199);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(48, 48);
            this.btnRetry.TabIndex = 2;
            this.btnRetry.UseVisualStyleBackColor = true;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultat.Location = new System.Drawing.Point(12, 216);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(0, 31);
            this.lblResultat.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 256);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.pctPendu);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.grpMot);
            this.Controls.Add(this.grpButton);
            this.Name = "Form1";
            this.Text = "Jeu du Pendu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpMot.ResumeLayout(false);
            this.grpMot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPendu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpButton;
        private System.Windows.Forms.GroupBox grpMot;
        private System.Windows.Forms.TextBox txtMot;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.PictureBox pctPendu;
        private System.Windows.Forms.Label lblResultat;
    }
}


namespace juexDe
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
            this.btn_brasser = new System.Windows.Forms.Button();
            this.lbl_deCourant = new System.Windows.Forms.Label();
            this.lbl_valeurObtenue = new System.Windows.Forms.Label();
            this.lbl_totalPoints = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_brasser
            // 
            this.btn_brasser.Location = new System.Drawing.Point(52, 72);
            this.btn_brasser.Name = "btn_brasser";
            this.btn_brasser.Size = new System.Drawing.Size(75, 23);
            this.btn_brasser.TabIndex = 0;
            this.btn_brasser.Text = "Brasser";
            this.btn_brasser.UseVisualStyleBackColor = true;
            this.btn_brasser.Click += new System.EventHandler(this.btn_brasser_Click);
            // 
            // lbl_deCourant
            // 
            this.lbl_deCourant.AutoSize = true;
            this.lbl_deCourant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deCourant.Location = new System.Drawing.Point(31, 9);
            this.lbl_deCourant.Name = "lbl_deCourant";
            this.lbl_deCourant.Size = new System.Drawing.Size(96, 20);
            this.lbl_deCourant.TabIndex = 1;
            this.lbl_deCourant.Text = "De courant: ";
            // 
            // lbl_valeurObtenue
            // 
            this.lbl_valeurObtenue.AutoSize = true;
            this.lbl_valeurObtenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valeurObtenue.Location = new System.Drawing.Point(1, 29);
            this.lbl_valeurObtenue.Name = "lbl_valeurObtenue";
            this.lbl_valeurObtenue.Size = new System.Drawing.Size(126, 20);
            this.lbl_valeurObtenue.TabIndex = 2;
            this.lbl_valeurObtenue.Text = "Valeur obtenue: ";
            // 
            // lbl_totalPoints
            // 
            this.lbl_totalPoints.AutoSize = true;
            this.lbl_totalPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalPoints.Location = new System.Drawing.Point(28, 49);
            this.lbl_totalPoints.Name = "lbl_totalPoints";
            this.lbl_totalPoints.Size = new System.Drawing.Size(99, 20);
            this.lbl_totalPoints.TabIndex = 3;
            this.lbl_totalPoints.Text = "Total points: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 127);
            this.Controls.Add(this.lbl_totalPoints);
            this.Controls.Add(this.lbl_valeurObtenue);
            this.Controls.Add(this.lbl_deCourant);
            this.Controls.Add(this.btn_brasser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_brasser;
        private System.Windows.Forms.Label lbl_deCourant;
        private System.Windows.Forms.Label lbl_valeurObtenue;
        private System.Windows.Forms.Label lbl_totalPoints;
    }
}


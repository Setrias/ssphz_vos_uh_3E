﻿
namespace záznam
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDownRealne = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownImaginarni = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonVypocitat = new System.Windows.Forms.Button();
            this.textBoxAbsolutniHodnota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRealne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImaginarni)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownRealne
            // 
            this.numericUpDownRealne.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownRealne.Location = new System.Drawing.Point(109, 37);
            this.numericUpDownRealne.Name = "numericUpDownRealne";
            this.numericUpDownRealne.Size = new System.Drawing.Size(51, 27);
            this.numericUpDownRealne.TabIndex = 0;
            // 
            // numericUpDownImaginarni
            // 
            this.numericUpDownImaginarni.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownImaginarni.Location = new System.Drawing.Point(109, 70);
            this.numericUpDownImaginarni.Name = "numericUpDownImaginarni";
            this.numericUpDownImaginarni.Size = new System.Drawing.Size(51, 27);
            this.numericUpDownImaginarni.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reálná část:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Imaginární část:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Komplexní čísla - výpočet absolutní hodnoty";
            // 
            // buttonVypocitat
            // 
            this.buttonVypocitat.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVypocitat.Location = new System.Drawing.Point(166, 42);
            this.buttonVypocitat.Name = "buttonVypocitat";
            this.buttonVypocitat.Size = new System.Drawing.Size(135, 49);
            this.buttonVypocitat.TabIndex = 6;
            this.buttonVypocitat.Text = "Výpočítat";
            this.buttonVypocitat.UseVisualStyleBackColor = true;
            this.buttonVypocitat.Click += new System.EventHandler(this.buttonVypocitat_Click);
            // 
            // textBoxAbsolutniHodnota
            // 
            this.textBoxAbsolutniHodnota.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAbsolutniHodnota.Location = new System.Drawing.Point(142, 103);
            this.textBoxAbsolutniHodnota.Name = "textBoxAbsolutniHodnota";
            this.textBoxAbsolutniHodnota.ReadOnly = true;
            this.textBoxAbsolutniHodnota.Size = new System.Drawing.Size(159, 23);
            this.textBoxAbsolutniHodnota.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Výsledek abs. hodnota:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 139);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAbsolutniHodnota);
            this.Controls.Add(this.buttonVypocitat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownImaginarni);
            this.Controls.Add(this.numericUpDownRealne);
            this.Name = "Form1";
            this.Text = "Výpočet absolutní hodnoty komplexního čísla";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRealne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImaginarni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownRealne;
        private System.Windows.Forms.NumericUpDown numericUpDownImaginarni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonVypocitat;
        private System.Windows.Forms.TextBox textBoxAbsolutniHodnota;
        private System.Windows.Forms.Label label4;
    }
}


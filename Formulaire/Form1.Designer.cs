namespace Formulaire
{
    partial class Form1
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
            this.titretext = new System.Windows.Forms.TextBox();
            this.prixtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.liste = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InsererButton = new System.Windows.Forms.Button();
            this.ModifierButton = new System.Windows.Forms.Button();
            this.SupprimerButton = new System.Windows.Forms.Button();
            this.AnnulerButton = new System.Windows.Forms.Button();
            this.ConfirmeButton = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // titretext
            // 
            this.titretext.Location = new System.Drawing.Point(180, 105);
            this.titretext.Name = "titretext";
            this.titretext.Size = new System.Drawing.Size(160, 20);
            this.titretext.TabIndex = 0;
            // 
            // prixtext
            // 
            this.prixtext.Location = new System.Drawing.Point(180, 142);
            this.prixtext.Name = "prixtext";
            this.prixtext.Size = new System.Drawing.Size(160, 20);
            this.prixtext.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Titre :";
            // 
            // liste
            // 
            this.liste.AutoSize = true;
            this.liste.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liste.Location = new System.Drawing.Point(28, 33);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(111, 17);
            this.liste.TabIndex = 4;
            this.liste.Text = "La liste des livre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prix :";
            // 
            // InsererButton
            // 
            this.InsererButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.InsererButton.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsererButton.Location = new System.Drawing.Point(12, 207);
            this.InsererButton.Name = "InsererButton";
            this.InsererButton.Size = new System.Drawing.Size(78, 30);
            this.InsererButton.TabIndex = 6;
            this.InsererButton.Text = "Insérer";
            this.InsererButton.UseVisualStyleBackColor = true;
            this.InsererButton.Click += new System.EventHandler(this.InsererButton_Click);
            // 
            // ModifierButton
            // 
            this.ModifierButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ModifierButton.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifierButton.Location = new System.Drawing.Point(96, 207);
            this.ModifierButton.Name = "ModifierButton";
            this.ModifierButton.Size = new System.Drawing.Size(78, 30);
            this.ModifierButton.TabIndex = 7;
            this.ModifierButton.Text = "Modifier";
            this.ModifierButton.UseVisualStyleBackColor = true;
            this.ModifierButton.Click += new System.EventHandler(this.ModifierButton_Click);
            // 
            // SupprimerButton
            // 
            this.SupprimerButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SupprimerButton.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupprimerButton.Location = new System.Drawing.Point(180, 207);
            this.SupprimerButton.Name = "SupprimerButton";
            this.SupprimerButton.Size = new System.Drawing.Size(78, 30);
            this.SupprimerButton.TabIndex = 8;
            this.SupprimerButton.Text = "Supprimer";
            this.SupprimerButton.UseVisualStyleBackColor = true;
            this.SupprimerButton.Click += new System.EventHandler(this.SupprimerButton_Click);
            // 
            // AnnulerButton
            // 
            this.AnnulerButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AnnulerButton.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnulerButton.Location = new System.Drawing.Point(348, 207);
            this.AnnulerButton.Name = "AnnulerButton";
            this.AnnulerButton.Size = new System.Drawing.Size(78, 30);
            this.AnnulerButton.TabIndex = 9;
            this.AnnulerButton.Text = "Annuler";
            this.AnnulerButton.UseVisualStyleBackColor = true;
            this.AnnulerButton.Click += new System.EventHandler(this.AnnulerButton_Click);
            // 
            // ConfirmeButton
            // 
            this.ConfirmeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ConfirmeButton.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmeButton.Location = new System.Drawing.Point(264, 207);
            this.ConfirmeButton.Name = "ConfirmeButton";
            this.ConfirmeButton.Size = new System.Drawing.Size(78, 30);
            this.ConfirmeButton.TabIndex = 10;
            this.ConfirmeButton.Text = "Confirmer";
            this.ConfirmeButton.UseVisualStyleBackColor = true;
            this.ConfirmeButton.Click += new System.EventHandler(this.ConfirmeButton_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(180, 29);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(180, 21);
            this.comboBox.TabIndex = 11;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(443, 250);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.ConfirmeButton);
            this.Controls.Add(this.AnnulerButton);
            this.Controls.Add(this.SupprimerButton);
            this.Controls.Add(this.ModifierButton);
            this.Controls.Add(this.InsererButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.liste);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prixtext);
            this.Controls.Add(this.titretext);
            this.Name = "Form1";
            this.Text = "Formulaire";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titretext;
        private System.Windows.Forms.TextBox prixtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label liste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button InsererButton;
        private System.Windows.Forms.Button ModifierButton;
        private System.Windows.Forms.Button SupprimerButton;
        private System.Windows.Forms.Button AnnulerButton;
        private System.Windows.Forms.Button ConfirmeButton;
        private System.Windows.Forms.ComboBox comboBox;
    }
}


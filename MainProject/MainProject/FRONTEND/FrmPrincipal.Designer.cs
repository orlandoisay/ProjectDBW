namespace MainProject.FRONTEND
{
    partial class FrmPrincipal
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
            this.btnProducts = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblWelcomeMessage = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(12, 103);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(197, 51);
            this.btnProducts.TabIndex = 0;
            this.btnProducts.Text = "Catálogo de productos";
            this.btnProducts.UseVisualStyleBackColor = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlHeader.Controls.Add(this.lblWelcomeMessage);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.ForeColor = System.Drawing.Color.White;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(366, 88);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lblTitle.Location = new System.Drawing.Point(12, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(301, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Proyecto de Taller de Base de Datos";
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(12, 160);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(139, 51);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "Acerca de...";
            this.btnAbout.UseVisualStyleBackColor = true;
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.AutoSize = true;
            this.lblWelcomeMessage.Location = new System.Drawing.Point(13, 59);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(107, 19);
            this.lblWelcomeMessage.TabIndex = 1;
            this.lblWelcomeMessage.Text = "Bienvenido: - | - ";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 249);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnProducts);
            this.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPrincipal";
            this.Text = "Menú principal";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label lblWelcomeMessage;
    }
}
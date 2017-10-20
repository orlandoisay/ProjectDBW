namespace MainProject.FRONTEND
{
    partial class FrmProducto
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblUnitsOnOrder = new System.Windows.Forms.Label();
            this.lblUnitsInStock = new System.Windows.Forms.Label();
            this.lblDescontinued = new System.Windows.Forms.Label();
            this.lblReorderLevel = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.chkDescontinued = new System.Windows.Forms.CheckBox();
            this.nmReorderLevel = new System.Windows.Forms.NumericUpDown();
            this.nmUnitsOnOrder = new System.Windows.Forms.NumericUpDown();
            this.nmUnitsInStock = new System.Windows.Forms.NumericUpDown();
            this.nmUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmReorderLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUnitsOnOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUnitsInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUnitPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.ForeColor = System.Drawing.Color.White;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(449, 63);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lblTitle.Location = new System.Drawing.Point(12, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(156, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Agregar producto";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(26, 87);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(142, 19);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Nombre del producto:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(98, 149);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(70, 19);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Categoría:";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(94, 118);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(74, 19);
            this.lblSupplier.TabIndex = 3;
            this.lblSupplier.Text = "Proveedor:";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(71, 211);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(97, 19);
            this.lblUnitPrice.TabIndex = 6;
            this.lblUnitPrice.Text = "Precio unitario:";
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.AutoSize = true;
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(34, 180);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(134, 19);
            this.lblQuantityPerUnit.TabIndex = 5;
            this.lblQuantityPerUnit.Text = "Cantidad por unidad:";
            // 
            // lblUnitsOnOrder
            // 
            this.lblUnitsOnOrder.AutoSize = true;
            this.lblUnitsOnOrder.Location = new System.Drawing.Point(38, 273);
            this.lblUnitsOnOrder.Name = "lblUnitsOnOrder";
            this.lblUnitsOnOrder.Size = new System.Drawing.Size(130, 19);
            this.lblUnitsOnOrder.TabIndex = 8;
            this.lblUnitsOnOrder.Text = "Unidades en pedido:";
            // 
            // lblUnitsInStock
            // 
            this.lblUnitsInStock.AutoSize = true;
            this.lblUnitsInStock.Location = new System.Drawing.Point(31, 242);
            this.lblUnitsInStock.Name = "lblUnitsInStock";
            this.lblUnitsInStock.Size = new System.Drawing.Size(137, 19);
            this.lblUnitsInStock.TabIndex = 7;
            this.lblUnitsInStock.Text = "Unidades en almacén:";
            // 
            // lblDescontinued
            // 
            this.lblDescontinued.AutoSize = true;
            this.lblDescontinued.Location = new System.Drawing.Point(70, 335);
            this.lblDescontinued.Name = "lblDescontinued";
            this.lblDescontinued.Size = new System.Drawing.Size(98, 19);
            this.lblDescontinued.TabIndex = 10;
            this.lblDescontinued.Text = "Descontinuado:";
            // 
            // lblReorderLevel
            // 
            this.lblReorderLevel.AutoSize = true;
            this.lblReorderLevel.Location = new System.Drawing.Point(57, 304);
            this.lblReorderLevel.Name = "lblReorderLevel";
            this.lblReorderLevel.Size = new System.Drawing.Size(111, 19);
            this.lblReorderLevel.TabIndex = 9;
            this.lblReorderLevel.Text = "Nivel de reorden:";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(174, 84);
            this.txtProductName.MaxLength = 40;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(175, 25);
            this.txtProductName.TabIndex = 11;
            // 
            // txtQuantityPerUnit
            // 
            this.txtQuantityPerUnit.Location = new System.Drawing.Point(174, 177);
            this.txtQuantityPerUnit.MaxLength = 20;
            this.txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            this.txtQuantityPerUnit.Size = new System.Drawing.Size(247, 25);
            this.txtQuantityPerUnit.TabIndex = 14;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.DisplayMember = "CompanyName";
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(173, 115);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(215, 25);
            this.cmbSupplier.TabIndex = 12;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(174, 146);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(152, 25);
            this.cmbCategory.TabIndex = 13;
            // 
            // chkDescontinued
            // 
            this.chkDescontinued.AutoSize = true;
            this.chkDescontinued.Location = new System.Drawing.Point(173, 333);
            this.chkDescontinued.Name = "chkDescontinued";
            this.chkDescontinued.Size = new System.Drawing.Size(46, 23);
            this.chkDescontinued.TabIndex = 19;
            this.chkDescontinued.Text = "No";
            this.chkDescontinued.UseVisualStyleBackColor = true;
            this.chkDescontinued.CheckedChanged += new System.EventHandler(this.chkDescontinued_CheckedChanged);
            // 
            // nmReorderLevel
            // 
            this.nmReorderLevel.Location = new System.Drawing.Point(173, 302);
            this.nmReorderLevel.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nmReorderLevel.Name = "nmReorderLevel";
            this.nmReorderLevel.Size = new System.Drawing.Size(120, 25);
            this.nmReorderLevel.TabIndex = 18;
            // 
            // nmUnitsOnOrder
            // 
            this.nmUnitsOnOrder.Location = new System.Drawing.Point(173, 271);
            this.nmUnitsOnOrder.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nmUnitsOnOrder.Name = "nmUnitsOnOrder";
            this.nmUnitsOnOrder.Size = new System.Drawing.Size(120, 25);
            this.nmUnitsOnOrder.TabIndex = 17;
            // 
            // nmUnitsInStock
            // 
            this.nmUnitsInStock.Location = new System.Drawing.Point(173, 240);
            this.nmUnitsInStock.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nmUnitsInStock.Name = "nmUnitsInStock";
            this.nmUnitsInStock.Size = new System.Drawing.Size(120, 25);
            this.nmUnitsInStock.TabIndex = 16;
            // 
            // nmUnitPrice
            // 
            this.nmUnitPrice.DecimalPlaces = 4;
            this.nmUnitPrice.Location = new System.Drawing.Point(173, 209);
            this.nmUnitPrice.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            262144});
            this.nmUnitPrice.Name = "nmUnitPrice";
            this.nmUnitPrice.Size = new System.Drawing.Size(120, 25);
            this.nmUnitPrice.TabIndex = 15;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(289, 376);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 41);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(151, 376);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 41);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FrmProducto
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(449, 438);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nmUnitPrice);
            this.Controls.Add(this.nmUnitsInStock);
            this.Controls.Add(this.nmUnitsOnOrder);
            this.Controls.Add(this.nmReorderLevel);
            this.Controls.Add(this.chkDescontinued);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.txtQuantityPerUnit);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblDescontinued);
            this.Controls.Add(this.lblReorderLevel);
            this.Controls.Add(this.lblUnitsOnOrder);
            this.Controls.Add(this.lblUnitsInStock);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblQuantityPerUnit);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProducto";
            this.Text = "Vista de producto";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmReorderLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUnitsOnOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUnitsInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUnitPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblQuantityPerUnit;
        private System.Windows.Forms.Label lblUnitsOnOrder;
        private System.Windows.Forms.Label lblUnitsInStock;
        private System.Windows.Forms.Label lblDescontinued;
        private System.Windows.Forms.Label lblReorderLevel;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtQuantityPerUnit;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.CheckBox chkDescontinued;
        private System.Windows.Forms.NumericUpDown nmReorderLevel;
        private System.Windows.Forms.NumericUpDown nmUnitsOnOrder;
        private System.Windows.Forms.NumericUpDown nmUnitsInStock;
        private System.Windows.Forms.NumericUpDown nmUnitPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
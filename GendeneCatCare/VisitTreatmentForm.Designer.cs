namespace GendeneCatCare
{
    partial class VisitTreatmentForm
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
            this.dgvVisits = new System.Windows.Forms.DataGridView();
            this.dgvVisitTreatments = new System.Windows.Forms.DataGridView();
            this.dgvTreatments = new System.Windows.Forms.DataGridView();
            this.btnAllocate = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitTreatments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVisits
            // 
            this.dgvVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisits.Location = new System.Drawing.Point(41, 24);
            this.dgvVisits.Name = "dgvVisits";
            this.dgvVisits.RowTemplate.Height = 24;
            this.dgvVisits.Size = new System.Drawing.Size(540, 193);
            this.dgvVisits.TabIndex = 0;
            // 
            // dgvVisitTreatments
            // 
            this.dgvVisitTreatments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitTreatments.Location = new System.Drawing.Point(79, 239);
            this.dgvVisitTreatments.Name = "dgvVisitTreatments";
            this.dgvVisitTreatments.RowTemplate.Height = 24;
            this.dgvVisitTreatments.Size = new System.Drawing.Size(240, 150);
            this.dgvVisitTreatments.TabIndex = 1;
            // 
            // dgvTreatments
            // 
            this.dgvTreatments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreatments.Location = new System.Drawing.Point(548, 239);
            this.dgvTreatments.Name = "dgvTreatments";
            this.dgvTreatments.RowTemplate.Height = 24;
            this.dgvTreatments.Size = new System.Drawing.Size(240, 150);
            this.dgvTreatments.TabIndex = 2;
            // 
            // btnAllocate
            // 
            this.btnAllocate.Location = new System.Drawing.Point(407, 239);
            this.btnAllocate.Name = "btnAllocate";
            this.btnAllocate.Size = new System.Drawing.Size(97, 35);
            this.btnAllocate.TabIndex = 3;
            this.btnAllocate.Text = "Allocate Treament";
            this.btnAllocate.UseVisualStyleBackColor = true;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(325, 298);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(65, 17);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(407, 298);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtQuantity.TabIndex = 5;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(407, 334);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(97, 55);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove Treament";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(649, 415);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click_1);
            // 
            // VisitTreatmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnAllocate);
            this.Controls.Add(this.dgvTreatments);
            this.Controls.Add(this.dgvVisitTreatments);
            this.Controls.Add(this.dgvVisits);
            this.Name = "VisitTreatmentForm";
            this.Text = "Allocate Treatment to Visit";
            this.Load += new System.EventHandler(this.VisitTreatmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitTreatments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVisits;
        private System.Windows.Forms.DataGridView dgvVisitTreatments;
        private System.Windows.Forms.DataGridView dgvTreatments;
        private System.Windows.Forms.Button btnAllocate;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnReturn;
    }
}
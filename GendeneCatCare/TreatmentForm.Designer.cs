namespace GendeneCatCare
{
    partial class TreatmentForm
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
            this.lstTreatments = new System.Windows.Forms.ListBox();
            this.lblTreatmentNo = new System.Windows.Forms.Label();
            this.lblTreatmentID = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddTreatment = new System.Windows.Forms.Button();
            this.btnUpdateTreatment = new System.Windows.Forms.Button();
            this.btnDeleteTreatment = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlAddTreatment = new System.Windows.Forms.Panel();
            this.lblAddDescription = new System.Windows.Forms.Label();
            this.lblAddCost = new System.Windows.Forms.Label();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.txtAddCost = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveTreatment = new System.Windows.Forms.Button();
            this.pnlAddTreatment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTreatments
            // 
            this.lstTreatments.FormattingEnabled = true;
            this.lstTreatments.ItemHeight = 16;
            this.lstTreatments.Location = new System.Drawing.Point(48, 45);
            this.lstTreatments.Name = "lstTreatments";
            this.lstTreatments.Size = new System.Drawing.Size(294, 260);
            this.lstTreatments.TabIndex = 0;
            this.lstTreatments.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblTreatmentNo
            // 
            this.lblTreatmentNo.AutoSize = true;
            this.lblTreatmentNo.Location = new System.Drawing.Point(369, 45);
            this.lblTreatmentNo.Name = "lblTreatmentNo";
            this.lblTreatmentNo.Size = new System.Drawing.Size(94, 17);
            this.lblTreatmentNo.TabIndex = 1;
            this.lblTreatmentNo.Text = "Treatment ID:";
            this.lblTreatmentNo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTreatmentID
            // 
            this.lblTreatmentID.AutoSize = true;
            this.lblTreatmentID.Location = new System.Drawing.Point(480, 45);
            this.lblTreatmentID.Name = "lblTreatmentID";
            this.lblTreatmentID.Size = new System.Drawing.Size(68, 17);
            this.lblTreatmentID.TabIndex = 2;
            this.lblTreatmentID.Text = "treatment";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(372, 100);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 17);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(375, 154);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(40, 17);
            this.lblCost.TabIndex = 4;
            this.lblCost.Text = "Cost:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(483, 100);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 22);
            this.txtDescription.TabIndex = 5;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(483, 154);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 22);
            this.txtCost.TabIndex = 6;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(48, 361);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(176, 361);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = " Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddTreatment
            // 
            this.btnAddTreatment.Location = new System.Drawing.Point(311, 361);
            this.btnAddTreatment.Name = "btnAddTreatment";
            this.btnAddTreatment.Size = new System.Drawing.Size(113, 23);
            this.btnAddTreatment.TabIndex = 9;
            this.btnAddTreatment.Text = "Add Treatment";
            this.btnAddTreatment.UseVisualStyleBackColor = true;
            this.btnAddTreatment.Click += new System.EventHandler(this.btnAddTreatment_Click);
            // 
            // btnUpdateTreatment
            // 
            this.btnUpdateTreatment.Location = new System.Drawing.Point(470, 361);
            this.btnUpdateTreatment.Name = "btnUpdateTreatment";
            this.btnUpdateTreatment.Size = new System.Drawing.Size(130, 23);
            this.btnUpdateTreatment.TabIndex = 10;
            this.btnUpdateTreatment.Text = "Update Treament";
            this.btnUpdateTreatment.UseVisualStyleBackColor = true;
            this.btnUpdateTreatment.Click += new System.EventHandler(this.btnUpdateTreatment_Click);
            // 
            // btnDeleteTreatment
            // 
            this.btnDeleteTreatment.Location = new System.Drawing.Point(649, 361);
            this.btnDeleteTreatment.Name = "btnDeleteTreatment";
            this.btnDeleteTreatment.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTreatment.TabIndex = 11;
            this.btnDeleteTreatment.Text = "Delete Treament";
            this.btnDeleteTreatment.UseVisualStyleBackColor = true;
            this.btnDeleteTreatment.Click += new System.EventHandler(this.btnDeleteTreatment_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(649, 415);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlAddTreatment
            // 
            this.pnlAddTreatment.Controls.Add(this.btnSaveTreatment);
            this.pnlAddTreatment.Controls.Add(this.btnCancel);
            this.pnlAddTreatment.Controls.Add(this.txtAddCost);
            this.pnlAddTreatment.Controls.Add(this.txtAddDescription);
            this.pnlAddTreatment.Controls.Add(this.lblAddCost);
            this.pnlAddTreatment.Controls.Add(this.lblAddDescription);
            this.pnlAddTreatment.Location = new System.Drawing.Point(378, 200);
            this.pnlAddTreatment.Name = "pnlAddTreatment";
            this.pnlAddTreatment.Size = new System.Drawing.Size(302, 124);
            this.pnlAddTreatment.TabIndex = 13;
            this.pnlAddTreatment.Visible = false;
            this.pnlAddTreatment.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAddTreatment_Paint);
            // 
            // lblAddDescription
            // 
            this.lblAddDescription.AutoSize = true;
            this.lblAddDescription.Location = new System.Drawing.Point(30, 16);
            this.lblAddDescription.Name = "lblAddDescription";
            this.lblAddDescription.Size = new System.Drawing.Size(83, 17);
            this.lblAddDescription.TabIndex = 0;
            this.lblAddDescription.Text = "Description:";
            // 
            // lblAddCost
            // 
            this.lblAddCost.AutoSize = true;
            this.lblAddCost.Location = new System.Drawing.Point(33, 51);
            this.lblAddCost.Name = "lblAddCost";
            this.lblAddCost.Size = new System.Drawing.Size(40, 17);
            this.lblAddCost.TabIndex = 1;
            this.lblAddCost.Text = "Cost:";
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(120, 16);
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(158, 22);
            this.txtAddDescription.TabIndex = 2;
            // 
            // txtAddCost
            // 
            this.txtAddCost.Location = new System.Drawing.Point(120, 51);
            this.txtAddCost.Name = "txtAddCost";
            this.txtAddCost.Size = new System.Drawing.Size(100, 22);
            this.txtAddCost.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(36, 90);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveTreatment
            // 
            this.btnSaveTreatment.Location = new System.Drawing.Point(163, 90);
            this.btnSaveTreatment.Name = "btnSaveTreatment";
            this.btnSaveTreatment.Size = new System.Drawing.Size(115, 23);
            this.btnSaveTreatment.TabIndex = 5;
            this.btnSaveTreatment.Text = "Save Treament";
            this.btnSaveTreatment.UseVisualStyleBackColor = true;
            this.btnSaveTreatment.Click += new System.EventHandler(this.btnSaveTreatment_Click);
            // 
            // TreatmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlAddTreatment);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteTreatment);
            this.Controls.Add(this.btnUpdateTreatment);
            this.Controls.Add(this.btnAddTreatment);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTreatmentID);
            this.Controls.Add(this.lblTreatmentNo);
            this.Controls.Add(this.lstTreatments);
            this.Name = "TreatmentForm";
            this.Text = "Treatment Maintenance";
            this.Load += new System.EventHandler(this.TreatmentForm_Load);
            this.pnlAddTreatment.ResumeLayout(false);
            this.pnlAddTreatment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTreatments;
        private System.Windows.Forms.Label lblTreatmentNo;
        private System.Windows.Forms.Label lblTreatmentID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddTreatment;
        private System.Windows.Forms.Button btnUpdateTreatment;
        private System.Windows.Forms.Button btnDeleteTreatment;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlAddTreatment;
        private System.Windows.Forms.Button btnSaveTreatment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtAddCost;
        private System.Windows.Forms.TextBox txtAddDescription;
        private System.Windows.Forms.Label lblAddCost;
        private System.Windows.Forms.Label lblAddDescription;
    }
}
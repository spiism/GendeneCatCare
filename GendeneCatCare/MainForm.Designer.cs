namespace GendeneCatCare
{
    partial class MainForm
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
            this.grpMaintenance = new System.Windows.Forms.GroupBox();
            this.btnVeterinarian = new System.Windows.Forms.Button();
            this.btnTreatmentVisit = new System.Windows.Forms.Button();
            this.btnVisit = new System.Windows.Forms.Button();
            this.btnTreatment = new System.Windows.Forms.Button();
            this.btnCat = new System.Windows.Forms.Button();
            this.btnOwner = new System.Windows.Forms.Button();
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.grpMaintenance.SuspendLayout();
            this.grpReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMaintenance
            // 
            this.grpMaintenance.Controls.Add(this.btnVeterinarian);
            this.grpMaintenance.Controls.Add(this.btnTreatmentVisit);
            this.grpMaintenance.Controls.Add(this.btnVisit);
            this.grpMaintenance.Controls.Add(this.btnTreatment);
            this.grpMaintenance.Controls.Add(this.btnCat);
            this.grpMaintenance.Controls.Add(this.btnOwner);
            this.grpMaintenance.Location = new System.Drawing.Point(33, 27);
            this.grpMaintenance.Name = "grpMaintenance";
            this.grpMaintenance.Size = new System.Drawing.Size(334, 393);
            this.grpMaintenance.TabIndex = 0;
            this.grpMaintenance.TabStop = false;
            this.grpMaintenance.Text = "Maintenance";
            this.grpMaintenance.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnVeterinarian
            // 
            this.btnVeterinarian.Location = new System.Drawing.Point(25, 103);
            this.btnVeterinarian.Name = "btnVeterinarian";
            this.btnVeterinarian.Size = new System.Drawing.Size(281, 23);
            this.btnVeterinarian.TabIndex = 1;
            this.btnVeterinarian.Text = "Veterinarian Maintanance";
            this.btnVeterinarian.UseVisualStyleBackColor = true;
            this.btnVeterinarian.Click += new System.EventHandler(this.btnVeterinarian_Click);
            // 
            // btnTreatmentVisit
            // 
            this.btnTreatmentVisit.Location = new System.Drawing.Point(25, 323);
            this.btnTreatmentVisit.Name = "btnTreatmentVisit";
            this.btnTreatmentVisit.Size = new System.Drawing.Size(281, 23);
            this.btnTreatmentVisit.TabIndex = 1;
            this.btnTreatmentVisit.Text = "Allocate Treatment to Visit";
            this.btnTreatmentVisit.UseVisualStyleBackColor = true;
            this.btnTreatmentVisit.Click += new System.EventHandler(this.btnTreatmentVisit_Click);
            // 
            // btnVisit
            // 
            this.btnVisit.Location = new System.Drawing.Point(25, 266);
            this.btnVisit.Name = "btnVisit";
            this.btnVisit.Size = new System.Drawing.Size(281, 23);
            this.btnVisit.TabIndex = 1;
            this.btnVisit.Text = "Visit Maintanance";
            this.btnVisit.UseVisualStyleBackColor = true;
            // 
            // btnTreatment
            // 
            this.btnTreatment.Location = new System.Drawing.Point(25, 213);
            this.btnTreatment.Name = "btnTreatment";
            this.btnTreatment.Size = new System.Drawing.Size(281, 23);
            this.btnTreatment.TabIndex = 1;
            this.btnTreatment.Text = "Treatment Maintanance";
            this.btnTreatment.UseVisualStyleBackColor = true;
            this.btnTreatment.Click += new System.EventHandler(this.btnTreatment_Click);
            // 
            // btnCat
            // 
            this.btnCat.Location = new System.Drawing.Point(25, 159);
            this.btnCat.Name = "btnCat";
            this.btnCat.Size = new System.Drawing.Size(281, 23);
            this.btnCat.TabIndex = 1;
            this.btnCat.Text = "Cat Maintainance";
            this.btnCat.UseVisualStyleBackColor = true;
            // 
            // btnOwner
            // 
            this.btnOwner.Location = new System.Drawing.Point(25, 49);
            this.btnOwner.Name = "btnOwner";
            this.btnOwner.Size = new System.Drawing.Size(281, 23);
            this.btnOwner.TabIndex = 0;
            this.btnOwner.Text = "Owner Maintanance";
            this.btnOwner.UseVisualStyleBackColor = true;
            // 
            // grpReport
            // 
            this.grpReport.Controls.Add(this.btnExit);
            this.grpReport.Controls.Add(this.btnInvoices);
            this.grpReport.Location = new System.Drawing.Point(418, 27);
            this.grpReport.Name = "grpReport";
            this.grpReport.Size = new System.Drawing.Size(334, 395);
            this.grpReport.TabIndex = 1;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "Reporting";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(30, 323);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(281, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnInvoices
            // 
            this.btnInvoices.Location = new System.Drawing.Point(30, 49);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(281, 23);
            this.btnInvoices.TabIndex = 0;
            this.btnInvoices.Text = "Invoices";
            this.btnInvoices.UseVisualStyleBackColor = true;
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpReport);
            this.Controls.Add(this.grpMaintenance);
            this.Name = "MainForm";
            this.Text = "Main menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpMaintenance.ResumeLayout(false);
            this.grpReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMaintenance;
        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.Button btnVeterinarian;
        private System.Windows.Forms.Button btnTreatmentVisit;
        private System.Windows.Forms.Button btnVisit;
        private System.Windows.Forms.Button btnTreatment;
        private System.Windows.Forms.Button btnCat;
        private System.Windows.Forms.Button btnOwner;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnInvoices;
    }
}


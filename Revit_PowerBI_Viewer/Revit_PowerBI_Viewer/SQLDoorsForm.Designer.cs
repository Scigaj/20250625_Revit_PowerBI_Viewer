namespace Revit_PowerBI_Viewer
{
    partial class SQLDoorsForm
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
            this.btnTableCreate = new System.Windows.Forms.Button();
            this.btnExportData = new System.Windows.Forms.Button();
            this.btnImportData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTableCreate
            // 
            this.btnTableCreate.Location = new System.Drawing.Point(89, 68);
            this.btnTableCreate.Name = "btnTableCreate";
            this.btnTableCreate.Size = new System.Drawing.Size(696, 80);
            this.btnTableCreate.TabIndex = 0;
            this.btnTableCreate.Text = "Create SQL Table";
            this.btnTableCreate.UseVisualStyleBackColor = true;
            this.btnTableCreate.Click += new System.EventHandler(this.btnTableCreate_Click);
            // 
            // btnExportData
            // 
            this.btnExportData.Location = new System.Drawing.Point(89, 254);
            this.btnExportData.Name = "btnExportData";
            this.btnExportData.Size = new System.Drawing.Size(696, 80);
            this.btnExportData.TabIndex = 1;
            this.btnExportData.Text = "Export Door Data";
            this.btnExportData.UseVisualStyleBackColor = true;
            this.btnExportData.Click += new System.EventHandler(this.btnExportData_Click);
            // 
            // btnImportData
            // 
            this.btnImportData.Location = new System.Drawing.Point(89, 440);
            this.btnImportData.Name = "btnImportData";
            this.btnImportData.Size = new System.Drawing.Size(696, 80);
            this.btnImportData.TabIndex = 2;
            this.btnImportData.Text = "Import Door Data";
            this.btnImportData.UseVisualStyleBackColor = true;
            this.btnImportData.Click += new System.EventHandler(this.btnImportData_Click);
            // 
            // SQLDoorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 589);
            this.Controls.Add(this.btnImportData);
            this.Controls.Add(this.btnExportData);
            this.Controls.Add(this.btnTableCreate);
            this.Name = "SQLDoorsForm";
            this.Text = "SQLDoorForm";
            this.Load += new System.EventHandler(this.SQLDoorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTableCreate;
        private System.Windows.Forms.Button btnExportData;
        private System.Windows.Forms.Button btnImportData;
    }
}
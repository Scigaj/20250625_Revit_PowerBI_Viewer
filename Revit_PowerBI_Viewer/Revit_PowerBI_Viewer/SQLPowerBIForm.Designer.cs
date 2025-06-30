namespace Revit_PowerBI_Viewer
{
    partial class SQLPowerBIForm
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.dg_Categories = new System.Windows.Forms.DataGridView();
            this.btn_Export = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Categories)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(55, 105);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(887, 38);
            this.txt_Search.TabIndex = 4;
            // 
            // dg_Categories
            // 
            this.dg_Categories.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_Categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Categories.Location = new System.Drawing.Point(55, 261);
            this.dg_Categories.Name = "dg_Categories";
            this.dg_Categories.RowHeadersWidth = 102;
            this.dg_Categories.RowTemplate.Height = 40;
            this.dg_Categories.Size = new System.Drawing.Size(887, 822);
            this.dg_Categories.TabIndex = 5;
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(55, 1133);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(887, 80);
            this.btn_Export.TabIndex = 6;
            this.btn_Export.Text = "Export Data";
            this.btn_Export.UseVisualStyleBackColor = true;
            // 
            // SQLPowerBIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 1273);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.dg_Categories);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SQLPowerBIForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dg_Categories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.DataGridView dg_Categories;
        private System.Windows.Forms.Button btn_Export;
    }
}
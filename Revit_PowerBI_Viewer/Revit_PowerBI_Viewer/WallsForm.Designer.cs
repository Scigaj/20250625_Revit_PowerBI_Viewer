namespace Revit_PowerBI_Viewer
{
    partial class WallsForm
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
            this.wall_count = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wall_count
            // 
            this.wall_count.Location = new System.Drawing.Point(76, 168);
            this.wall_count.Name = "wall_count";
            this.wall_count.Size = new System.Drawing.Size(636, 246);
            this.wall_count.TabIndex = 0;
            this.wall_count.Text = "Wall Count";
            this.wall_count.UseVisualStyleBackColor = true;
            this.wall_count.Click += new System.EventHandler(this.button1_Click);
            // 
            // WallsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 640);
            this.Controls.Add(this.wall_count);
            this.Name = "WallsForm";
            this.Text = "WallsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button wall_count;
    }
}
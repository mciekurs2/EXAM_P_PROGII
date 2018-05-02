namespace EXAM_P_PROGII
{
    partial class ParzinisForm
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
            this.dataParzinis = new System.Windows.Forms.DataGridView();
            this.updateParzinis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataParzinis)).BeginInit();
            this.SuspendLayout();
            // 
            // dataParzinis
            // 
            this.dataParzinis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataParzinis.Location = new System.Drawing.Point(3, 3);
            this.dataParzinis.Name = "dataParzinis";
            this.dataParzinis.Size = new System.Drawing.Size(634, 323);
            this.dataParzinis.TabIndex = 0;
            // 
            // updateParzinis
            // 
            this.updateParzinis.Location = new System.Drawing.Point(553, 332);
            this.updateParzinis.Name = "updateParzinis";
            this.updateParzinis.Size = new System.Drawing.Size(75, 23);
            this.updateParzinis.TabIndex = 1;
            this.updateParzinis.Text = "Update";
            this.updateParzinis.UseVisualStyleBackColor = true;
            // 
            // ParzinisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 367);
            this.Controls.Add(this.updateParzinis);
            this.Controls.Add(this.dataParzinis);
            this.Name = "ParzinisForm";
            this.Text = "ParzinisForm";
            this.Load += new System.EventHandler(this.ParzinisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataParzinis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataParzinis;
        private System.Windows.Forms.Button updateParzinis;
    }
}
namespace EXAM_P_PROGII
{
    partial class AdminForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label23 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nosaukums = new System.Windows.Forms.TextBox();
            this.tips = new System.Windows.Forms.TextBox();
            this.daudzums = new System.Windows.Forms.TextBox();
            this.cenaParGab = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.noliktavasDBDataSet1 = new EXAM_P_PROGII.noliktavasDBDataSet1();
            this.noliktavasDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noliktavasMantasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noliktavasMantasTableAdapter = new EXAM_P_PROGII.noliktavasDBDataSet1TableAdapters.NoliktavasMantasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noliktavasDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noliktavasDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noliktavasMantasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.refresh);
            this.splitContainer1.Panel1.Controls.Add(this.add);
            this.splitContainer1.Panel1.Controls.Add(this.cenaParGab);
            this.splitContainer1.Panel1.Controls.Add(this.daudzums);
            this.splitContainer1.Panel1.Controls.Add(this.tips);
            this.splitContainer1.Panel1.Controls.Add(this.nosaukums);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label23);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 242;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(554, 450);
            this.dataGridView.TabIndex = 0;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(33, 54);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "Nosaukums";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tips";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Daudzums";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cena par gab";
            // 
            // nosaukums
            // 
            this.nosaukums.Location = new System.Drawing.Point(119, 51);
            this.nosaukums.Name = "nosaukums";
            this.nosaukums.Size = new System.Drawing.Size(100, 20);
            this.nosaukums.TabIndex = 1;
            // 
            // tips
            // 
            this.tips.Location = new System.Drawing.Point(119, 103);
            this.tips.Name = "tips";
            this.tips.Size = new System.Drawing.Size(100, 20);
            this.tips.TabIndex = 1;
            // 
            // daudzums
            // 
            this.daudzums.Location = new System.Drawing.Point(119, 163);
            this.daudzums.Name = "daudzums";
            this.daudzums.Size = new System.Drawing.Size(100, 20);
            this.daudzums.TabIndex = 1;
            // 
            // cenaParGab
            // 
            this.cenaParGab.Location = new System.Drawing.Point(119, 225);
            this.cenaParGab.Name = "cenaParGab";
            this.cenaParGab.Size = new System.Drawing.Size(100, 20);
            this.cenaParGab.TabIndex = 1;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(144, 415);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 2;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(21, 415);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 2;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // noliktavasDBDataSet1
            // 
            this.noliktavasDBDataSet1.DataSetName = "noliktavasDBDataSet1";
            this.noliktavasDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // noliktavasDBDataSet1BindingSource
            // 
            this.noliktavasDBDataSet1BindingSource.DataSource = this.noliktavasDBDataSet1;
            this.noliktavasDBDataSet1BindingSource.Position = 0;
            // 
            // noliktavasMantasBindingSource
            // 
            this.noliktavasMantasBindingSource.DataMember = "NoliktavasMantas";
            this.noliktavasMantasBindingSource.DataSource = this.noliktavasDBDataSet1BindingSource;
            // 
            // noliktavasMantasTableAdapter
            // 
            this.noliktavasMantasTableAdapter.ClearBeforeFill = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noliktavasDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noliktavasDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noliktavasMantasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox cenaParGab;
        private System.Windows.Forms.TextBox daudzums;
        private System.Windows.Forms.TextBox tips;
        private System.Windows.Forms.TextBox nosaukums;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.BindingSource noliktavasDBDataSet1BindingSource;
        private noliktavasDBDataSet1 noliktavasDBDataSet1;
        private System.Windows.Forms.BindingSource noliktavasMantasBindingSource;
        private noliktavasDBDataSet1TableAdapters.NoliktavasMantasTableAdapter noliktavasMantasTableAdapter;
    }
}
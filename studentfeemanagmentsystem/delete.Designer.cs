namespace studentfeemanagmentsystem
{
    partial class delete
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.refresh = new System.Windows.Forms.Button();
            this.deleteid = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.resetid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Student ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(796, 314);
            this.dataGridView1.TabIndex = 5;
            // 
            // refresh
            // 
            this.refresh.Image = global::studentfeemanagmentsystem.Properties.Resources.Actions_edit_clear_history_icon3;
            this.refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refresh.Location = new System.Drawing.Point(359, 441);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(97, 38);
            this.refresh.TabIndex = 6;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // deleteid
            // 
            this.deleteid.Image = global::studentfeemanagmentsystem.Properties.Resources.Recycle_Bin_full_icon;
            this.deleteid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteid.Location = new System.Drawing.Point(446, 47);
            this.deleteid.Name = "deleteid";
            this.deleteid.Size = new System.Drawing.Size(97, 38);
            this.deleteid.TabIndex = 2;
            this.deleteid.Text = "Delete";
            this.deleteid.UseVisualStyleBackColor = true;
            this.deleteid.Click += new System.EventHandler(this.button4_Click);
            // 
            // close
            // 
            this.close.Image = global::studentfeemanagmentsystem.Properties.Resources.Actions_window_close_icon6;
            this.close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close.Location = new System.Drawing.Point(676, 47);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(122, 38);
            this.close.TabIndex = 4;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.button3_Click);
            // 
            // resetid
            // 
            this.resetid.Image = global::studentfeemanagmentsystem.Properties.Resources.Button_Refresh_icond;
            this.resetid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resetid.Location = new System.Drawing.Point(563, 47);
            this.resetid.Name = "resetid";
            this.resetid.Size = new System.Drawing.Size(97, 38);
            this.resetid.TabIndex = 3;
            this.resetid.Text = "Reset";
            this.resetid.UseVisualStyleBackColor = true;
            this.resetid.Click += new System.EventHandler(this.button2_Click);
            // 
            // delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::studentfeemanagmentsystem.Properties.Resources.fd4;
            this.ClientSize = new System.Drawing.Size(820, 491);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteid);
            this.Controls.Add(this.close);
            this.Controls.Add(this.resetid);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "delete";
            this.Text = "delete";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteid;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button resetid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button refresh;

    }
}
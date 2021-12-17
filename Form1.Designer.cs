
namespace Pictures
{
    partial class F_Picture
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
            this.bt_select = new System.Windows.Forms.Button();
            this.bt_Remove = new System.Windows.Forms.Button();
            this.pb_Picture1 = new System.Windows.Forms.PictureBox();
            this.ofd_picture = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Picture1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_select
            // 
            this.bt_select.Location = new System.Drawing.Point(61, 31);
            this.bt_select.Name = "bt_select";
            this.bt_select.Size = new System.Drawing.Size(75, 23);
            this.bt_select.TabIndex = 0;
            this.bt_select.Text = "Select";
            this.bt_select.UseVisualStyleBackColor = true;
            this.bt_select.Click += new System.EventHandler(this.bt_select_Click);
            // 
            // bt_Remove
            // 
            this.bt_Remove.Enabled = false;
            this.bt_Remove.Location = new System.Drawing.Point(226, 31);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(75, 23);
            this.bt_Remove.TabIndex = 1;
            this.bt_Remove.Text = "Remove";
            this.bt_Remove.UseVisualStyleBackColor = true;
            this.bt_Remove.Click += new System.EventHandler(this.bt_Remove_Click);
            // 
            // pb_Picture1
            // 
            this.pb_Picture1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Picture1.Location = new System.Drawing.Point(48, 84);
            this.pb_Picture1.Name = "pb_Picture1";
            this.pb_Picture1.Size = new System.Drawing.Size(600, 388);
            this.pb_Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Picture1.TabIndex = 2;
            this.pb_Picture1.TabStop = false;
            // 
            // ofd_picture
            // 
            this.ofd_picture.FileName = "openFileDialog1";
            // 
            // F_Picture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.pb_Picture1);
            this.Controls.Add(this.bt_Remove);
            this.Controls.Add(this.bt_select);
            this.Name = "F_Picture";
            this.Text = "Picture";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Picture_FormClosed);
            this.Load += new System.EventHandler(this.F_Picture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Picture1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_select;
        private System.Windows.Forms.Button bt_Remove;
        private System.Windows.Forms.PictureBox pb_Picture1;
        private System.Windows.Forms.OpenFileDialog ofd_picture;
    }
}


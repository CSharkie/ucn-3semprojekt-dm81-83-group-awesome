namespace AwesomeClient
{
    partial class Seats
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
            this.seats_panel = new System.Windows.Forms.Panel();
            this.seats_pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.getRoom_btn = new System.Windows.Forms.Button();
            this.txt_roomId = new System.Windows.Forms.TextBox();
            this.seats_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seats_pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // seats_panel
            // 
            this.seats_panel.Controls.Add(this.seats_pictureBox);
            this.seats_panel.Controls.Add(this.panel1);
            this.seats_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seats_panel.Location = new System.Drawing.Point(0, 0);
            this.seats_panel.Name = "seats_panel";
            this.seats_panel.Size = new System.Drawing.Size(612, 438);
            this.seats_panel.TabIndex = 0;
            // 
            // seats_pictureBox
            // 
            this.seats_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seats_pictureBox.Location = new System.Drawing.Point(0, 32);
            this.seats_pictureBox.Name = "seats_pictureBox";
            this.seats_pictureBox.Size = new System.Drawing.Size(612, 406);
            this.seats_pictureBox.TabIndex = 5;
            this.seats_pictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.getRoom_btn);
            this.panel1.Controls.Add(this.txt_roomId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 32);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Room Id:";
            // 
            // getRoom_btn
            // 
            this.getRoom_btn.Location = new System.Drawing.Point(160, 4);
            this.getRoom_btn.Name = "getRoom_btn";
            this.getRoom_btn.Size = new System.Drawing.Size(75, 23);
            this.getRoom_btn.TabIndex = 1;
            this.getRoom_btn.Text = "Get Room";
            this.getRoom_btn.UseVisualStyleBackColor = true;
            this.getRoom_btn.Click += new System.EventHandler(this.getRoom_btn_Click);
            // 
            // txt_roomId
            // 
            this.txt_roomId.Location = new System.Drawing.Point(54, 6);
            this.txt_roomId.Name = "txt_roomId";
            this.txt_roomId.Size = new System.Drawing.Size(100, 20);
            this.txt_roomId.TabIndex = 2;
            // 
            // Seats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 438);
            this.Controls.Add(this.seats_panel);
            this.Name = "Seats";
            this.Text = "Seats";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.seats_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seats_pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel seats_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_roomId;
        private System.Windows.Forms.Button getRoom_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox seats_pictureBox;
    }
}
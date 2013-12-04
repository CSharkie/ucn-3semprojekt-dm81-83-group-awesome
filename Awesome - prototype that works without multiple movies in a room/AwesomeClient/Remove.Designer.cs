namespace AwesomeClient
{
    partial class Remove
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.removeTab = new System.Windows.Forms.TabControl();
            this.roomTab = new System.Windows.Forms.TabPage();
            this.movieTab = new System.Windows.Forms.TabPage();
            this.reservationTab = new System.Windows.Forms.TabPage();
            this.discountTab = new System.Windows.Forms.TabPage();
            this.ticketTab = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.removeTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.removeTab);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 460);
            this.panel1.TabIndex = 1;
            // 
            // removeTab
            // 
            this.removeTab.Controls.Add(this.roomTab);
            this.removeTab.Controls.Add(this.movieTab);
            this.removeTab.Controls.Add(this.reservationTab);
            this.removeTab.Controls.Add(this.discountTab);
            this.removeTab.Controls.Add(this.ticketTab);
            this.removeTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeTab.Location = new System.Drawing.Point(0, 0);
            this.removeTab.Name = "removeTab";
            this.removeTab.SelectedIndex = 0;
            this.removeTab.Size = new System.Drawing.Size(650, 460);
            this.removeTab.TabIndex = 0;
            // 
            // roomTab
            // 
            this.roomTab.Location = new System.Drawing.Point(4, 22);
            this.roomTab.Name = "roomTab";
            this.roomTab.Padding = new System.Windows.Forms.Padding(3);
            this.roomTab.Size = new System.Drawing.Size(642, 434);
            this.roomTab.TabIndex = 0;
            this.roomTab.Text = "Room";
            this.roomTab.UseVisualStyleBackColor = true;
            // 
            // movieTab
            // 
            this.movieTab.Location = new System.Drawing.Point(4, 22);
            this.movieTab.Name = "movieTab";
            this.movieTab.Padding = new System.Windows.Forms.Padding(3);
            this.movieTab.Size = new System.Drawing.Size(642, 434);
            this.movieTab.TabIndex = 1;
            this.movieTab.Text = "Movie";
            this.movieTab.UseVisualStyleBackColor = true;
            // 
            // reservationTab
            // 
            this.reservationTab.Location = new System.Drawing.Point(4, 22);
            this.reservationTab.Name = "reservationTab";
            this.reservationTab.Padding = new System.Windows.Forms.Padding(3);
            this.reservationTab.Size = new System.Drawing.Size(642, 434);
            this.reservationTab.TabIndex = 2;
            this.reservationTab.Text = "Reservation";
            this.reservationTab.UseVisualStyleBackColor = true;
            // 
            // discountTab
            // 
            this.discountTab.Location = new System.Drawing.Point(4, 22);
            this.discountTab.Name = "discountTab";
            this.discountTab.Padding = new System.Windows.Forms.Padding(3);
            this.discountTab.Size = new System.Drawing.Size(642, 434);
            this.discountTab.TabIndex = 3;
            this.discountTab.Text = "Discount";
            this.discountTab.UseVisualStyleBackColor = true;
            // 
            // ticketTab
            // 
            this.ticketTab.Location = new System.Drawing.Point(4, 22);
            this.ticketTab.Name = "ticketTab";
            this.ticketTab.Padding = new System.Windows.Forms.Padding(3);
            this.ticketTab.Size = new System.Drawing.Size(642, 434);
            this.ticketTab.TabIndex = 4;
            this.ticketTab.Text = "Ticket";
            this.ticketTab.UseVisualStyleBackColor = true;
            // 
            // Remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 460);
            this.Controls.Add(this.panel1);
            this.Name = "Remove";
            this.Text = "Remove";
            this.panel1.ResumeLayout(false);
            this.removeTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl removeTab;
        private System.Windows.Forms.TabPage roomTab;
        private System.Windows.Forms.TabPage movieTab;
        private System.Windows.Forms.TabPage reservationTab;
        private System.Windows.Forms.TabPage discountTab;
        private System.Windows.Forms.TabPage ticketTab;
    }
}
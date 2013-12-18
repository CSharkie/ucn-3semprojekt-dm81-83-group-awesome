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
            this.room_txt_roomId = new System.Windows.Forms.TextBox();
            this.room_lbl_roomId = new System.Windows.Forms.Label();
            this.room_btn_remove = new System.Windows.Forms.Button();
            this.movieTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.movie_combo_movie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.movie_txt_title = new System.Windows.Forms.TextBox();
            this.movie_txt_movieId = new System.Windows.Forms.TextBox();
            this.movie_lbl_movieId = new System.Windows.Forms.Label();
            this.movie_btn_remove = new System.Windows.Forms.Button();
            this.reservationTab = new System.Windows.Forms.TabPage();
            this.reserv_txt_reservId = new System.Windows.Forms.TextBox();
            this.reserv_lbl_reservId = new System.Windows.Forms.Label();
            this.reserv_btn_remove = new System.Windows.Forms.Button();
            this.discountTab = new System.Windows.Forms.TabPage();
            this.discount_txt_discountId = new System.Windows.Forms.TextBox();
            this.discount_lbl_dicountId = new System.Windows.Forms.Label();
            this.discount_btn_remove = new System.Windows.Forms.Button();
            this.ticketTab = new System.Windows.Forms.TabPage();
            this.ticket_txt_ticketId = new System.Windows.Forms.TextBox();
            this.ticket_lbl_ticketId = new System.Windows.Forms.Label();
            this.ticket_btn_remove = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.removeTab.SuspendLayout();
            this.roomTab.SuspendLayout();
            this.movieTab.SuspendLayout();
            this.reservationTab.SuspendLayout();
            this.discountTab.SuspendLayout();
            this.ticketTab.SuspendLayout();
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
            this.roomTab.Controls.Add(this.room_txt_roomId);
            this.roomTab.Controls.Add(this.room_lbl_roomId);
            this.roomTab.Controls.Add(this.room_btn_remove);
            this.roomTab.Location = new System.Drawing.Point(4, 22);
            this.roomTab.Name = "roomTab";
            this.roomTab.Padding = new System.Windows.Forms.Padding(3);
            this.roomTab.Size = new System.Drawing.Size(642, 434);
            this.roomTab.TabIndex = 0;
            this.roomTab.Text = "Room";
            this.roomTab.UseVisualStyleBackColor = true;
            // 
            // room_txt_roomId
            // 
            this.room_txt_roomId.Location = new System.Drawing.Point(163, 69);
            this.room_txt_roomId.Name = "room_txt_roomId";
            this.room_txt_roomId.Size = new System.Drawing.Size(100, 20);
            this.room_txt_roomId.TabIndex = 2;
            // 
            // room_lbl_roomId
            // 
            this.room_lbl_roomId.AutoSize = true;
            this.room_lbl_roomId.Location = new System.Drawing.Point(112, 72);
            this.room_lbl_roomId.Name = "room_lbl_roomId";
            this.room_lbl_roomId.Size = new System.Drawing.Size(47, 13);
            this.room_lbl_roomId.TabIndex = 1;
            this.room_lbl_roomId.Text = "RoomId:";
            // 
            // room_btn_remove
            // 
            this.room_btn_remove.Location = new System.Drawing.Point(163, 95);
            this.room_btn_remove.Name = "room_btn_remove";
            this.room_btn_remove.Size = new System.Drawing.Size(75, 23);
            this.room_btn_remove.TabIndex = 0;
            this.room_btn_remove.Text = "Remove";
            this.room_btn_remove.UseVisualStyleBackColor = true;
            this.room_btn_remove.Click += new System.EventHandler(this.room_btn_remove_Click);
            // 
            // movieTab
            // 
            this.movieTab.Controls.Add(this.button1);
            this.movieTab.Controls.Add(this.label3);
            this.movieTab.Controls.Add(this.movie_combo_movie);
            this.movieTab.Controls.Add(this.label1);
            this.movieTab.Controls.Add(this.movie_txt_title);
            this.movieTab.Controls.Add(this.movie_txt_movieId);
            this.movieTab.Controls.Add(this.movie_lbl_movieId);
            this.movieTab.Controls.Add(this.movie_btn_remove);
            this.movieTab.Location = new System.Drawing.Point(4, 22);
            this.movieTab.Name = "movieTab";
            this.movieTab.Padding = new System.Windows.Forms.Padding(3);
            this.movieTab.Size = new System.Drawing.Size(642, 434);
            this.movieTab.TabIndex = 1;
            this.movieTab.Text = "Movie";
            this.movieTab.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Select the movie:";
            // 
            // movie_combo_movie
            // 
            this.movie_combo_movie.Enabled = false;
            this.movie_combo_movie.FormattingEnabled = true;
            this.movie_combo_movie.Location = new System.Drawing.Point(171, 107);
            this.movie_combo_movie.Name = "movie_combo_movie";
            this.movie_combo_movie.Size = new System.Drawing.Size(200, 21);
            this.movie_combo_movie.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Title:";
            // 
            // movie_txt_title
            // 
            this.movie_txt_title.Location = new System.Drawing.Point(171, 81);
            this.movie_txt_title.Name = "movie_txt_title";
            this.movie_txt_title.Size = new System.Drawing.Size(100, 20);
            this.movie_txt_title.TabIndex = 6;
            // 
            // movie_txt_movieId
            // 
            this.movie_txt_movieId.Location = new System.Drawing.Point(171, 55);
            this.movie_txt_movieId.Name = "movie_txt_movieId";
            this.movie_txt_movieId.Size = new System.Drawing.Size(100, 20);
            this.movie_txt_movieId.TabIndex = 5;
            // 
            // movie_lbl_movieId
            // 
            this.movie_lbl_movieId.AutoSize = true;
            this.movie_lbl_movieId.Location = new System.Drawing.Point(120, 58);
            this.movie_lbl_movieId.Name = "movie_lbl_movieId";
            this.movie_lbl_movieId.Size = new System.Drawing.Size(48, 13);
            this.movie_lbl_movieId.TabIndex = 4;
            this.movie_lbl_movieId.Text = "MovieId:";
            // 
            // movie_btn_remove
            // 
            this.movie_btn_remove.Location = new System.Drawing.Point(268, 134);
            this.movie_btn_remove.Name = "movie_btn_remove";
            this.movie_btn_remove.Size = new System.Drawing.Size(75, 23);
            this.movie_btn_remove.TabIndex = 3;
            this.movie_btn_remove.Text = "Remove";
            this.movie_btn_remove.UseVisualStyleBackColor = true;
            this.movie_btn_remove.Click += new System.EventHandler(this.movie_btn_remove_Click);
            // 
            // reservationTab
            // 
            this.reservationTab.Controls.Add(this.reserv_txt_reservId);
            this.reservationTab.Controls.Add(this.reserv_lbl_reservId);
            this.reservationTab.Controls.Add(this.reserv_btn_remove);
            this.reservationTab.Location = new System.Drawing.Point(4, 22);
            this.reservationTab.Name = "reservationTab";
            this.reservationTab.Padding = new System.Windows.Forms.Padding(3);
            this.reservationTab.Size = new System.Drawing.Size(642, 434);
            this.reservationTab.TabIndex = 2;
            this.reservationTab.Text = "Reservation";
            this.reservationTab.UseVisualStyleBackColor = true;
            // 
            // reserv_txt_reservId
            // 
            this.reserv_txt_reservId.Location = new System.Drawing.Point(186, 79);
            this.reserv_txt_reservId.Name = "reserv_txt_reservId";
            this.reserv_txt_reservId.Size = new System.Drawing.Size(100, 20);
            this.reserv_txt_reservId.TabIndex = 8;
            // 
            // reserv_lbl_reservId
            // 
            this.reserv_lbl_reservId.AutoSize = true;
            this.reserv_lbl_reservId.Location = new System.Drawing.Point(104, 82);
            this.reserv_lbl_reservId.Name = "reserv_lbl_reservId";
            this.reserv_lbl_reservId.Size = new System.Drawing.Size(79, 13);
            this.reserv_lbl_reservId.TabIndex = 7;
            this.reserv_lbl_reservId.Text = "Reservation Id:";
            // 
            // reserv_btn_remove
            // 
            this.reserv_btn_remove.Location = new System.Drawing.Point(186, 105);
            this.reserv_btn_remove.Name = "reserv_btn_remove";
            this.reserv_btn_remove.Size = new System.Drawing.Size(75, 23);
            this.reserv_btn_remove.TabIndex = 6;
            this.reserv_btn_remove.Text = "Remove";
            this.reserv_btn_remove.UseVisualStyleBackColor = true;
            this.reserv_btn_remove.Click += new System.EventHandler(this.reserv_btn_remove_Click);
            // 
            // discountTab
            // 
            this.discountTab.Controls.Add(this.discount_txt_discountId);
            this.discountTab.Controls.Add(this.discount_lbl_dicountId);
            this.discountTab.Controls.Add(this.discount_btn_remove);
            this.discountTab.Location = new System.Drawing.Point(4, 22);
            this.discountTab.Name = "discountTab";
            this.discountTab.Padding = new System.Windows.Forms.Padding(3);
            this.discountTab.Size = new System.Drawing.Size(642, 434);
            this.discountTab.TabIndex = 3;
            this.discountTab.Text = "Discount";
            this.discountTab.UseVisualStyleBackColor = true;
            // 
            // discount_txt_discountId
            // 
            this.discount_txt_discountId.Location = new System.Drawing.Point(198, 65);
            this.discount_txt_discountId.Name = "discount_txt_discountId";
            this.discount_txt_discountId.Size = new System.Drawing.Size(100, 20);
            this.discount_txt_discountId.TabIndex = 11;
            // 
            // discount_lbl_dicountId
            // 
            this.discount_lbl_dicountId.AutoSize = true;
            this.discount_lbl_dicountId.Location = new System.Drawing.Point(132, 68);
            this.discount_lbl_dicountId.Name = "discount_lbl_dicountId";
            this.discount_lbl_dicountId.Size = new System.Drawing.Size(64, 13);
            this.discount_lbl_dicountId.TabIndex = 10;
            this.discount_lbl_dicountId.Text = "Discount Id:";
            // 
            // discount_btn_remove
            // 
            this.discount_btn_remove.Location = new System.Drawing.Point(198, 91);
            this.discount_btn_remove.Name = "discount_btn_remove";
            this.discount_btn_remove.Size = new System.Drawing.Size(75, 23);
            this.discount_btn_remove.TabIndex = 9;
            this.discount_btn_remove.Text = "Remove";
            this.discount_btn_remove.UseVisualStyleBackColor = true;
            this.discount_btn_remove.Click += new System.EventHandler(this.discount_btn_remove_Click);
            // 
            // ticketTab
            // 
            this.ticketTab.Controls.Add(this.ticket_txt_ticketId);
            this.ticketTab.Controls.Add(this.ticket_lbl_ticketId);
            this.ticketTab.Controls.Add(this.ticket_btn_remove);
            this.ticketTab.Location = new System.Drawing.Point(4, 22);
            this.ticketTab.Name = "ticketTab";
            this.ticketTab.Padding = new System.Windows.Forms.Padding(3);
            this.ticketTab.Size = new System.Drawing.Size(642, 434);
            this.ticketTab.TabIndex = 4;
            this.ticketTab.Text = "Ticket";
            this.ticketTab.UseVisualStyleBackColor = true;
            // 
            // ticket_txt_ticketId
            // 
            this.ticket_txt_ticketId.Location = new System.Drawing.Point(226, 83);
            this.ticket_txt_ticketId.Name = "ticket_txt_ticketId";
            this.ticket_txt_ticketId.Size = new System.Drawing.Size(100, 20);
            this.ticket_txt_ticketId.TabIndex = 14;
            // 
            // ticket_lbl_ticketId
            // 
            this.ticket_lbl_ticketId.AutoSize = true;
            this.ticket_lbl_ticketId.Location = new System.Drawing.Point(168, 86);
            this.ticket_lbl_ticketId.Name = "ticket_lbl_ticketId";
            this.ticket_lbl_ticketId.Size = new System.Drawing.Size(52, 13);
            this.ticket_lbl_ticketId.TabIndex = 13;
            this.ticket_lbl_ticketId.Text = "Ticket Id:";
            // 
            // ticket_btn_remove
            // 
            this.ticket_btn_remove.Location = new System.Drawing.Point(226, 109);
            this.ticket_btn_remove.Name = "ticket_btn_remove";
            this.ticket_btn_remove.Size = new System.Drawing.Size(75, 23);
            this.ticket_btn_remove.TabIndex = 12;
            this.ticket_btn_remove.Text = "Remove";
            this.ticket_btn_remove.UseVisualStyleBackColor = true;
            this.ticket_btn_remove.Click += new System.EventHandler(this.ticket_btn_remove_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Find Movie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.roomTab.ResumeLayout(false);
            this.roomTab.PerformLayout();
            this.movieTab.ResumeLayout(false);
            this.movieTab.PerformLayout();
            this.reservationTab.ResumeLayout(false);
            this.reservationTab.PerformLayout();
            this.discountTab.ResumeLayout(false);
            this.discountTab.PerformLayout();
            this.ticketTab.ResumeLayout(false);
            this.ticketTab.PerformLayout();
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
        private System.Windows.Forms.TextBox room_txt_roomId;
        private System.Windows.Forms.Label room_lbl_roomId;
        private System.Windows.Forms.Button room_btn_remove;
        private System.Windows.Forms.TextBox movie_txt_movieId;
        private System.Windows.Forms.Label movie_lbl_movieId;
        private System.Windows.Forms.Button movie_btn_remove;
        private System.Windows.Forms.TextBox reserv_txt_reservId;
        private System.Windows.Forms.Label reserv_lbl_reservId;
        private System.Windows.Forms.Button reserv_btn_remove;
        private System.Windows.Forms.TextBox discount_txt_discountId;
        private System.Windows.Forms.Label discount_lbl_dicountId;
        private System.Windows.Forms.Button discount_btn_remove;
        private System.Windows.Forms.TextBox ticket_txt_ticketId;
        private System.Windows.Forms.Label ticket_lbl_ticketId;
        private System.Windows.Forms.Button ticket_btn_remove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox movie_txt_title;
        private System.Windows.Forms.ComboBox movie_combo_movie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}
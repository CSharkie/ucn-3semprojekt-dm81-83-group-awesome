using System;
namespace AwesomeClient
{
    partial class Create
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
            this.create_discountTab = new System.Windows.Forms.TabPage();
            this.discount_dPercent_txt = new System.Windows.Forms.TextBox();
            this.discount_create_btn = new System.Windows.Forms.Button();
            this.discount_percent_lbl = new System.Windows.Forms.Label();
            this.create_reservationTab = new System.Windows.Forms.TabPage();
            this.reserv_name_lbl = new System.Windows.Forms.Label();
            this.reserv_name_txt = new System.Windows.Forms.TextBox();
            this.reserv_movieId_txt = new System.Windows.Forms.TextBox();
            this.reserv_taken_chk = new System.Windows.Forms.CheckBox();
            this.reserv_date_picker = new System.Windows.Forms.DateTimePicker();
            this.reserv_seatCount_txt = new System.Windows.Forms.TextBox();
            this.reserv_date_lbl = new System.Windows.Forms.Label();
            this.reserv_movieId_lbl = new System.Windows.Forms.Label();
            this.reserv_seatCount_lbl = new System.Windows.Forms.Label();
            this.reserv_create_btn = new System.Windows.Forms.Button();
            this.create_movieTab = new System.Windows.Forms.TabPage();
            this.movie_title_txt = new System.Windows.Forms.TextBox();
            this.movie_roomId_txt = new System.Windows.Forms.TextBox();
            this.movie_title_lbl = new System.Windows.Forms.Label();
            this.movie_date_lbl = new System.Windows.Forms.Label();
            this.movie_roomId_lbl = new System.Windows.Forms.Label();
            this.movie_create_btn = new System.Windows.Forms.Button();
            this.movie_date_picker = new System.Windows.Forms.DateTimePicker();
            this.create_roomTab = new System.Windows.Forms.TabPage();
            this.col_room_txt = new System.Windows.Forms.TextBox();
            this.row_room_txt = new System.Windows.Forms.TextBox();
            this.columLbl = new System.Windows.Forms.Label();
            this.rowLbl = new System.Windows.Forms.Label();
            this.room_create_btn = new System.Windows.Forms.Button();
            this.createTab = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.create_discountTab.SuspendLayout();
            this.create_reservationTab.SuspendLayout();
            this.create_movieTab.SuspendLayout();
            this.create_roomTab.SuspendLayout();
            this.createTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.createTab);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 460);
            this.panel1.TabIndex = 0;
            // 
            // create_discountTab
            // 
            this.create_discountTab.Controls.Add(this.discount_percent_lbl);
            this.create_discountTab.Controls.Add(this.discount_create_btn);
            this.create_discountTab.Controls.Add(this.discount_dPercent_txt);
            this.create_discountTab.Location = new System.Drawing.Point(4, 22);
            this.create_discountTab.Name = "create_discountTab";
            this.create_discountTab.Padding = new System.Windows.Forms.Padding(3);
            this.create_discountTab.Size = new System.Drawing.Size(642, 434);
            this.create_discountTab.TabIndex = 3;
            this.create_discountTab.Text = "Discount";
            this.create_discountTab.UseVisualStyleBackColor = true;
            // 
            // discount_dPercent_txt
            // 
            this.discount_dPercent_txt.Location = new System.Drawing.Point(193, 54);
            this.discount_dPercent_txt.Name = "discount_dPercent_txt";
            this.discount_dPercent_txt.Size = new System.Drawing.Size(100, 20);
            this.discount_dPercent_txt.TabIndex = 0;
            // 
            // discount_create_btn
            // 
            this.discount_create_btn.Location = new System.Drawing.Point(193, 80);
            this.discount_create_btn.Name = "discount_create_btn";
            this.discount_create_btn.Size = new System.Drawing.Size(75, 23);
            this.discount_create_btn.TabIndex = 1;
            this.discount_create_btn.Text = "Create";
            this.discount_create_btn.UseVisualStyleBackColor = true;
            // 
            // discount_percent_lbl
            // 
            this.discount_percent_lbl.AutoSize = true;
            this.discount_percent_lbl.Location = new System.Drawing.Point(122, 57);
            this.discount_percent_lbl.Name = "discount_percent_lbl";
            this.discount_percent_lbl.Size = new System.Drawing.Size(65, 13);
            this.discount_percent_lbl.TabIndex = 2;
            this.discount_percent_lbl.Text = "Percentage:";
            // 
            // create_reservationTab
            // 
            this.create_reservationTab.Controls.Add(this.reserv_create_btn);
            this.create_reservationTab.Controls.Add(this.reserv_seatCount_lbl);
            this.create_reservationTab.Controls.Add(this.reserv_movieId_lbl);
            this.create_reservationTab.Controls.Add(this.reserv_date_lbl);
            this.create_reservationTab.Controls.Add(this.reserv_seatCount_txt);
            this.create_reservationTab.Controls.Add(this.reserv_movieId_txt);
            this.create_reservationTab.Controls.Add(this.reserv_name_txt);
            this.create_reservationTab.Controls.Add(this.reserv_date_picker);
            this.create_reservationTab.Controls.Add(this.reserv_taken_chk);
            this.create_reservationTab.Controls.Add(this.reserv_name_lbl);
            this.create_reservationTab.Location = new System.Drawing.Point(4, 22);
            this.create_reservationTab.Name = "create_reservationTab";
            this.create_reservationTab.Padding = new System.Windows.Forms.Padding(3);
            this.create_reservationTab.Size = new System.Drawing.Size(642, 434);
            this.create_reservationTab.TabIndex = 2;
            this.create_reservationTab.Text = "Reservation";
            this.create_reservationTab.UseVisualStyleBackColor = true;
            // 
            // reserv_name_lbl
            // 
            this.reserv_name_lbl.AutoSize = true;
            this.reserv_name_lbl.Location = new System.Drawing.Point(184, 43);
            this.reserv_name_lbl.Name = "reserv_name_lbl";
            this.reserv_name_lbl.Size = new System.Drawing.Size(38, 13);
            this.reserv_name_lbl.TabIndex = 0;
            this.reserv_name_lbl.Text = "Name:";
            // 
            // reserv_name_txt
            // 
            this.reserv_name_txt.Location = new System.Drawing.Point(228, 40);
            this.reserv_name_txt.Name = "reserv_name_txt";
            this.reserv_name_txt.Size = new System.Drawing.Size(200, 20);
            this.reserv_name_txt.TabIndex = 2;
            // 
            // reserv_movieId_txt
            // 
            this.reserv_movieId_txt.Location = new System.Drawing.Point(228, 115);
            this.reserv_movieId_txt.Name = "reserv_movieId_txt";
            this.reserv_movieId_txt.Size = new System.Drawing.Size(200, 20);
            this.reserv_movieId_txt.TabIndex = 4;
            // 
            // reserv_taken_chk
            // 
            this.reserv_taken_chk.AccessibleDescription = "";
            this.reserv_taken_chk.AutoSize = true;
            this.reserv_taken_chk.Checked = true;
            this.reserv_taken_chk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.reserv_taken_chk.Location = new System.Drawing.Point(228, 66);
            this.reserv_taken_chk.Name = "reserv_taken_chk";
            this.reserv_taken_chk.Size = new System.Drawing.Size(57, 17);
            this.reserv_taken_chk.TabIndex = 5;
            this.reserv_taken_chk.Text = "Taken";
            this.reserv_taken_chk.UseVisualStyleBackColor = true;
            // 
            // reserv_date_picker
            // 
            this.reserv_date_picker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.reserv_date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.reserv_date_picker.Location = new System.Drawing.Point(228, 89);
            this.reserv_date_picker.Name = "reserv_date_picker";
            this.reserv_date_picker.Size = new System.Drawing.Size(200, 20);
            this.reserv_date_picker.TabIndex = 6;
            // 
            // reserv_seatCount_txt
            // 
            this.reserv_seatCount_txt.Location = new System.Drawing.Point(228, 141);
            this.reserv_seatCount_txt.Name = "reserv_seatCount_txt";
            this.reserv_seatCount_txt.Size = new System.Drawing.Size(200, 20);
            this.reserv_seatCount_txt.TabIndex = 7;
            // 
            // reserv_date_lbl
            // 
            this.reserv_date_lbl.AutoSize = true;
            this.reserv_date_lbl.Location = new System.Drawing.Point(129, 95);
            this.reserv_date_lbl.Name = "reserv_date_lbl";
            this.reserv_date_lbl.Size = new System.Drawing.Size(93, 13);
            this.reserv_date_lbl.TabIndex = 8;
            this.reserv_date_lbl.Text = "Reservation Date:";
            // 
            // reserv_movieId_lbl
            // 
            this.reserv_movieId_lbl.AutoSize = true;
            this.reserv_movieId_lbl.Location = new System.Drawing.Point(171, 118);
            this.reserv_movieId_lbl.Name = "reserv_movieId_lbl";
            this.reserv_movieId_lbl.Size = new System.Drawing.Size(51, 13);
            this.reserv_movieId_lbl.TabIndex = 9;
            this.reserv_movieId_lbl.Text = "Movie Id:";
            // 
            // reserv_seatCount_lbl
            // 
            this.reserv_seatCount_lbl.AutoSize = true;
            this.reserv_seatCount_lbl.Location = new System.Drawing.Point(159, 144);
            this.reserv_seatCount_lbl.Name = "reserv_seatCount_lbl";
            this.reserv_seatCount_lbl.Size = new System.Drawing.Size(63, 13);
            this.reserv_seatCount_lbl.TabIndex = 10;
            this.reserv_seatCount_lbl.Text = "Seat Count:";
            // 
            // reserv_create_btn
            // 
            this.reserv_create_btn.Location = new System.Drawing.Point(228, 167);
            this.reserv_create_btn.Name = "reserv_create_btn";
            this.reserv_create_btn.Size = new System.Drawing.Size(75, 23);
            this.reserv_create_btn.TabIndex = 11;
            this.reserv_create_btn.Text = "Create";
            this.reserv_create_btn.UseVisualStyleBackColor = true;
            // 
            // create_movieTab
            // 
            this.create_movieTab.Controls.Add(this.movie_date_picker);
            this.create_movieTab.Controls.Add(this.movie_create_btn);
            this.create_movieTab.Controls.Add(this.movie_roomId_lbl);
            this.create_movieTab.Controls.Add(this.movie_date_lbl);
            this.create_movieTab.Controls.Add(this.movie_title_lbl);
            this.create_movieTab.Controls.Add(this.movie_roomId_txt);
            this.create_movieTab.Controls.Add(this.movie_title_txt);
            this.create_movieTab.Location = new System.Drawing.Point(4, 22);
            this.create_movieTab.Name = "create_movieTab";
            this.create_movieTab.Padding = new System.Windows.Forms.Padding(3);
            this.create_movieTab.Size = new System.Drawing.Size(642, 434);
            this.create_movieTab.TabIndex = 1;
            this.create_movieTab.Text = "Movie";
            this.create_movieTab.UseVisualStyleBackColor = true;
            // 
            // movie_title_txt
            // 
            this.movie_title_txt.Location = new System.Drawing.Point(152, 33);
            this.movie_title_txt.Name = "movie_title_txt";
            this.movie_title_txt.Size = new System.Drawing.Size(200, 20);
            this.movie_title_txt.TabIndex = 0;
            // 
            // movie_roomId_txt
            // 
            this.movie_roomId_txt.Location = new System.Drawing.Point(152, 85);
            this.movie_roomId_txt.Name = "movie_roomId_txt";
            this.movie_roomId_txt.Size = new System.Drawing.Size(200, 20);
            this.movie_roomId_txt.TabIndex = 2;
            // 
            // movie_title_lbl
            // 
            this.movie_title_lbl.AutoSize = true;
            this.movie_title_lbl.Location = new System.Drawing.Point(116, 36);
            this.movie_title_lbl.Name = "movie_title_lbl";
            this.movie_title_lbl.Size = new System.Drawing.Size(30, 13);
            this.movie_title_lbl.TabIndex = 3;
            this.movie_title_lbl.Text = "Title:";
            // 
            // movie_date_lbl
            // 
            this.movie_date_lbl.AutoSize = true;
            this.movie_date_lbl.Location = new System.Drawing.Point(66, 62);
            this.movie_date_lbl.Name = "movie_date_lbl";
            this.movie_date_lbl.Size = new System.Drawing.Size(80, 13);
            this.movie_date_lbl.TabIndex = 4;
            this.movie_date_lbl.Text = "Date and Time:";
            // 
            // movie_roomId_lbl
            // 
            this.movie_roomId_lbl.AutoSize = true;
            this.movie_roomId_lbl.Location = new System.Drawing.Point(96, 88);
            this.movie_roomId_lbl.Name = "movie_roomId_lbl";
            this.movie_roomId_lbl.Size = new System.Drawing.Size(50, 13);
            this.movie_roomId_lbl.TabIndex = 5;
            this.movie_roomId_lbl.Text = "Room Id:";
            // 
            // movie_create_btn
            // 
            this.movie_create_btn.Location = new System.Drawing.Point(152, 111);
            this.movie_create_btn.Name = "movie_create_btn";
            this.movie_create_btn.Size = new System.Drawing.Size(75, 23);
            this.movie_create_btn.TabIndex = 6;
            this.movie_create_btn.Text = "Create";
            this.movie_create_btn.UseVisualStyleBackColor = true;
            // 
            // movie_date_picker
            // 
            this.movie_date_picker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.movie_date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.movie_date_picker.Location = new System.Drawing.Point(152, 59);
            this.movie_date_picker.Name = "movie_date_picker";
            this.movie_date_picker.Size = new System.Drawing.Size(200, 20);
            this.movie_date_picker.TabIndex = 7;
            // 
            // create_roomTab
            // 
            this.create_roomTab.Controls.Add(this.room_create_btn);
            this.create_roomTab.Controls.Add(this.rowLbl);
            this.create_roomTab.Controls.Add(this.columLbl);
            this.create_roomTab.Controls.Add(this.row_room_txt);
            this.create_roomTab.Controls.Add(this.col_room_txt);
            this.create_roomTab.Location = new System.Drawing.Point(4, 22);
            this.create_roomTab.Name = "create_roomTab";
            this.create_roomTab.Padding = new System.Windows.Forms.Padding(3);
            this.create_roomTab.Size = new System.Drawing.Size(642, 434);
            this.create_roomTab.TabIndex = 0;
            this.create_roomTab.Text = "Room";
            this.create_roomTab.UseVisualStyleBackColor = true;
            // 
            // col_room_txt
            // 
            this.col_room_txt.Location = new System.Drawing.Point(95, 41);
            this.col_room_txt.Name = "col_room_txt";
            this.col_room_txt.Size = new System.Drawing.Size(100, 20);
            this.col_room_txt.TabIndex = 0;
            // 
            // row_room_txt
            // 
            this.row_room_txt.Location = new System.Drawing.Point(95, 67);
            this.row_room_txt.Name = "row_room_txt";
            this.row_room_txt.Size = new System.Drawing.Size(100, 20);
            this.row_room_txt.TabIndex = 1;
            // 
            // columLbl
            // 
            this.columLbl.AutoSize = true;
            this.columLbl.Location = new System.Drawing.Point(41, 44);
            this.columLbl.Name = "columLbl";
            this.columLbl.Size = new System.Drawing.Size(50, 13);
            this.columLbl.TabIndex = 2;
            this.columLbl.Text = "Columns:";
            // 
            // rowLbl
            // 
            this.rowLbl.AutoSize = true;
            this.rowLbl.Location = new System.Drawing.Point(54, 70);
            this.rowLbl.Name = "rowLbl";
            this.rowLbl.Size = new System.Drawing.Size(37, 13);
            this.rowLbl.TabIndex = 3;
            this.rowLbl.Text = "Rows:";
            // 
            // room_create_btn
            // 
            this.room_create_btn.Location = new System.Drawing.Point(95, 93);
            this.room_create_btn.Name = "room_create_btn";
            this.room_create_btn.Size = new System.Drawing.Size(75, 23);
            this.room_create_btn.TabIndex = 4;
            this.room_create_btn.Text = "Create";
            this.room_create_btn.UseVisualStyleBackColor = true;
            // 
            // createTab
            // 
            this.createTab.Controls.Add(this.create_roomTab);
            this.createTab.Controls.Add(this.create_movieTab);
            this.createTab.Controls.Add(this.create_reservationTab);
            this.createTab.Controls.Add(this.create_discountTab);
            this.createTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createTab.Location = new System.Drawing.Point(0, 0);
            this.createTab.Name = "createTab";
            this.createTab.SelectedIndex = 0;
            this.createTab.Size = new System.Drawing.Size(650, 460);
            this.createTab.TabIndex = 0;
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 460);
            this.Controls.Add(this.panel1);
            this.Name = "Create";
            this.Text = "Create";
            this.panel1.ResumeLayout(false);
            this.create_discountTab.ResumeLayout(false);
            this.create_discountTab.PerformLayout();
            this.create_reservationTab.ResumeLayout(false);
            this.create_reservationTab.PerformLayout();
            this.create_movieTab.ResumeLayout(false);
            this.create_movieTab.PerformLayout();
            this.create_roomTab.ResumeLayout(false);
            this.create_roomTab.PerformLayout();
            this.createTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl createTab;
        private System.Windows.Forms.TabPage create_roomTab;
        private System.Windows.Forms.Button room_create_btn;
        private System.Windows.Forms.Label rowLbl;
        private System.Windows.Forms.Label columLbl;
        private System.Windows.Forms.TextBox row_room_txt;
        private System.Windows.Forms.TextBox col_room_txt;
        private System.Windows.Forms.TabPage create_movieTab;
        private System.Windows.Forms.DateTimePicker movie_date_picker;
        private System.Windows.Forms.Button movie_create_btn;
        private System.Windows.Forms.Label movie_roomId_lbl;
        private System.Windows.Forms.Label movie_date_lbl;
        private System.Windows.Forms.Label movie_title_lbl;
        private System.Windows.Forms.TextBox movie_roomId_txt;
        private System.Windows.Forms.TextBox movie_title_txt;
        private System.Windows.Forms.TabPage create_reservationTab;
        private System.Windows.Forms.Button reserv_create_btn;
        private System.Windows.Forms.Label reserv_seatCount_lbl;
        private System.Windows.Forms.Label reserv_movieId_lbl;
        private System.Windows.Forms.Label reserv_date_lbl;
        private System.Windows.Forms.TextBox reserv_seatCount_txt;
        private System.Windows.Forms.TextBox reserv_movieId_txt;
        private System.Windows.Forms.TextBox reserv_name_txt;
        private System.Windows.Forms.DateTimePicker reserv_date_picker;
        private System.Windows.Forms.CheckBox reserv_taken_chk;
        private System.Windows.Forms.Label reserv_name_lbl;
        private System.Windows.Forms.TabPage create_discountTab;
        private System.Windows.Forms.Label discount_percent_lbl;
        private System.Windows.Forms.Button discount_create_btn;
        private System.Windows.Forms.TextBox discount_dPercent_txt;
    }
}
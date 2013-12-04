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
            this.createTab = new System.Windows.Forms.TabControl();
            this.create_roomTab = new System.Windows.Forms.TabPage();
            this.room_btn_create = new System.Windows.Forms.Button();
            this.rowLbl = new System.Windows.Forms.Label();
            this.columLbl = new System.Windows.Forms.Label();
            this.room_txt_row = new System.Windows.Forms.TextBox();
            this.room_txt_col = new System.Windows.Forms.TextBox();
            this.create_movieTab = new System.Windows.Forms.TabPage();
            this.movie_date_picker = new System.Windows.Forms.DateTimePicker();
            this.movie_btn_create = new System.Windows.Forms.Button();
            this.movie_roomId_lbl = new System.Windows.Forms.Label();
            this.movie_date_lbl = new System.Windows.Forms.Label();
            this.movie_title_lbl = new System.Windows.Forms.Label();
            this.movie_txt_roomId = new System.Windows.Forms.TextBox();
            this.movie_txt_title = new System.Windows.Forms.TextBox();
            this.create_reservationTab = new System.Windows.Forms.TabPage();
            this.reserv_btn_create = new System.Windows.Forms.Button();
            this.reserv_seatCount_lbl = new System.Windows.Forms.Label();
            this.reserv_movieId_lbl = new System.Windows.Forms.Label();
            this.reserv_date_lbl = new System.Windows.Forms.Label();
            this.reserv_txt_seatCount = new System.Windows.Forms.TextBox();
            this.reserv_txt_movieId = new System.Windows.Forms.TextBox();
            this.reserv_txt_name = new System.Windows.Forms.TextBox();
            this.reserv_date_picker = new System.Windows.Forms.DateTimePicker();
            this.reserv_taken_chk = new System.Windows.Forms.CheckBox();
            this.reserv_name_lbl = new System.Windows.Forms.Label();
            this.create_discountTab = new System.Windows.Forms.TabPage();
            this.discount_percent_lbl = new System.Windows.Forms.Label();
            this.discount_btn_create = new System.Windows.Forms.Button();
            this.discount_txt_dPercent = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.createTab.SuspendLayout();
            this.create_roomTab.SuspendLayout();
            this.create_movieTab.SuspendLayout();
            this.create_reservationTab.SuspendLayout();
            this.create_discountTab.SuspendLayout();
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
            // create_roomTab
            // 
            this.create_roomTab.Controls.Add(this.room_btn_create);
            this.create_roomTab.Controls.Add(this.rowLbl);
            this.create_roomTab.Controls.Add(this.columLbl);
            this.create_roomTab.Controls.Add(this.room_txt_row);
            this.create_roomTab.Controls.Add(this.room_txt_col);
            this.create_roomTab.Location = new System.Drawing.Point(4, 22);
            this.create_roomTab.Name = "create_roomTab";
            this.create_roomTab.Padding = new System.Windows.Forms.Padding(3);
            this.create_roomTab.Size = new System.Drawing.Size(642, 434);
            this.create_roomTab.TabIndex = 0;
            this.create_roomTab.Text = "Room";
            this.create_roomTab.UseVisualStyleBackColor = true;
            // 
            // room_btn_create
            // 
            this.room_btn_create.Location = new System.Drawing.Point(95, 93);
            this.room_btn_create.Name = "room_btn_create";
            this.room_btn_create.Size = new System.Drawing.Size(75, 23);
            this.room_btn_create.TabIndex = 4;
            this.room_btn_create.Text = "Create";
            this.room_btn_create.UseVisualStyleBackColor = true;
            this.room_btn_create.Click += new System.EventHandler(this.room_create_btn_Click);
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
            // columLbl
            // 
            this.columLbl.AutoSize = true;
            this.columLbl.Location = new System.Drawing.Point(41, 44);
            this.columLbl.Name = "columLbl";
            this.columLbl.Size = new System.Drawing.Size(50, 13);
            this.columLbl.TabIndex = 2;
            this.columLbl.Text = "Columns:";
            // 
            // room_txt_row
            // 
            this.room_txt_row.Location = new System.Drawing.Point(95, 67);
            this.room_txt_row.Name = "room_txt_row";
            this.room_txt_row.Size = new System.Drawing.Size(100, 20);
            this.room_txt_row.TabIndex = 1;
            // 
            // room_txt_col
            // 
            this.room_txt_col.Location = new System.Drawing.Point(95, 41);
            this.room_txt_col.Name = "room_txt_col";
            this.room_txt_col.Size = new System.Drawing.Size(100, 20);
            this.room_txt_col.TabIndex = 0;
            // 
            // create_movieTab
            // 
            this.create_movieTab.Controls.Add(this.movie_date_picker);
            this.create_movieTab.Controls.Add(this.movie_btn_create);
            this.create_movieTab.Controls.Add(this.movie_roomId_lbl);
            this.create_movieTab.Controls.Add(this.movie_date_lbl);
            this.create_movieTab.Controls.Add(this.movie_title_lbl);
            this.create_movieTab.Controls.Add(this.movie_txt_roomId);
            this.create_movieTab.Controls.Add(this.movie_txt_title);
            this.create_movieTab.Location = new System.Drawing.Point(4, 22);
            this.create_movieTab.Name = "create_movieTab";
            this.create_movieTab.Padding = new System.Windows.Forms.Padding(3);
            this.create_movieTab.Size = new System.Drawing.Size(642, 434);
            this.create_movieTab.TabIndex = 1;
            this.create_movieTab.Text = "Movie";
            this.create_movieTab.UseVisualStyleBackColor = true;
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
            // movie_btn_create
            // 
            this.movie_btn_create.Location = new System.Drawing.Point(152, 111);
            this.movie_btn_create.Name = "movie_btn_create";
            this.movie_btn_create.Size = new System.Drawing.Size(75, 23);
            this.movie_btn_create.TabIndex = 6;
            this.movie_btn_create.Text = "Create";
            this.movie_btn_create.UseVisualStyleBackColor = true;
            this.movie_btn_create.Click += new System.EventHandler(this.movie_btn_create_Click);
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
            // movie_date_lbl
            // 
            this.movie_date_lbl.AutoSize = true;
            this.movie_date_lbl.Location = new System.Drawing.Point(66, 62);
            this.movie_date_lbl.Name = "movie_date_lbl";
            this.movie_date_lbl.Size = new System.Drawing.Size(80, 13);
            this.movie_date_lbl.TabIndex = 4;
            this.movie_date_lbl.Text = "Date and Time:";
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
            // movie_txt_roomId
            // 
            this.movie_txt_roomId.Location = new System.Drawing.Point(152, 85);
            this.movie_txt_roomId.Name = "movie_txt_roomId";
            this.movie_txt_roomId.Size = new System.Drawing.Size(200, 20);
            this.movie_txt_roomId.TabIndex = 2;
            // 
            // movie_txt_title
            // 
            this.movie_txt_title.Location = new System.Drawing.Point(152, 33);
            this.movie_txt_title.Name = "movie_txt_title";
            this.movie_txt_title.Size = new System.Drawing.Size(200, 20);
            this.movie_txt_title.TabIndex = 0;
            // 
            // create_reservationTab
            // 
            this.create_reservationTab.Controls.Add(this.reserv_btn_create);
            this.create_reservationTab.Controls.Add(this.reserv_seatCount_lbl);
            this.create_reservationTab.Controls.Add(this.reserv_movieId_lbl);
            this.create_reservationTab.Controls.Add(this.reserv_date_lbl);
            this.create_reservationTab.Controls.Add(this.reserv_txt_seatCount);
            this.create_reservationTab.Controls.Add(this.reserv_txt_movieId);
            this.create_reservationTab.Controls.Add(this.reserv_txt_name);
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
            // reserv_btn_create
            // 
            this.reserv_btn_create.Location = new System.Drawing.Point(228, 167);
            this.reserv_btn_create.Name = "reserv_btn_create";
            this.reserv_btn_create.Size = new System.Drawing.Size(75, 23);
            this.reserv_btn_create.TabIndex = 11;
            this.reserv_btn_create.Text = "Create";
            this.reserv_btn_create.UseVisualStyleBackColor = true;
            this.reserv_btn_create.Click += new System.EventHandler(this.reserv_btn_create_Click);
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
            // reserv_movieId_lbl
            // 
            this.reserv_movieId_lbl.AutoSize = true;
            this.reserv_movieId_lbl.Location = new System.Drawing.Point(171, 118);
            this.reserv_movieId_lbl.Name = "reserv_movieId_lbl";
            this.reserv_movieId_lbl.Size = new System.Drawing.Size(51, 13);
            this.reserv_movieId_lbl.TabIndex = 9;
            this.reserv_movieId_lbl.Text = "Movie Id:";
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
            // reserv_txt_seatCount
            // 
            this.reserv_txt_seatCount.Location = new System.Drawing.Point(228, 141);
            this.reserv_txt_seatCount.Name = "reserv_txt_seatCount";
            this.reserv_txt_seatCount.Size = new System.Drawing.Size(200, 20);
            this.reserv_txt_seatCount.TabIndex = 7;
            // 
            // reserv_txt_movieId
            // 
            this.reserv_txt_movieId.Location = new System.Drawing.Point(228, 115);
            this.reserv_txt_movieId.Name = "reserv_txt_movieId";
            this.reserv_txt_movieId.Size = new System.Drawing.Size(200, 20);
            this.reserv_txt_movieId.TabIndex = 4;
            // 
            // reserv_txt_name
            // 
            this.reserv_txt_name.Location = new System.Drawing.Point(228, 40);
            this.reserv_txt_name.Name = "reserv_txt_name";
            this.reserv_txt_name.Size = new System.Drawing.Size(200, 20);
            this.reserv_txt_name.TabIndex = 2;
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
            // reserv_name_lbl
            // 
            this.reserv_name_lbl.AutoSize = true;
            this.reserv_name_lbl.Location = new System.Drawing.Point(184, 43);
            this.reserv_name_lbl.Name = "reserv_name_lbl";
            this.reserv_name_lbl.Size = new System.Drawing.Size(38, 13);
            this.reserv_name_lbl.TabIndex = 0;
            this.reserv_name_lbl.Text = "Name:";
            // 
            // create_discountTab
            // 
            this.create_discountTab.Controls.Add(this.discount_percent_lbl);
            this.create_discountTab.Controls.Add(this.discount_btn_create);
            this.create_discountTab.Controls.Add(this.discount_txt_dPercent);
            this.create_discountTab.Location = new System.Drawing.Point(4, 22);
            this.create_discountTab.Name = "create_discountTab";
            this.create_discountTab.Padding = new System.Windows.Forms.Padding(3);
            this.create_discountTab.Size = new System.Drawing.Size(642, 434);
            this.create_discountTab.TabIndex = 3;
            this.create_discountTab.Text = "Discount";
            this.create_discountTab.UseVisualStyleBackColor = true;
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
            // discount_btn_create
            // 
            this.discount_btn_create.Location = new System.Drawing.Point(193, 80);
            this.discount_btn_create.Name = "discount_btn_create";
            this.discount_btn_create.Size = new System.Drawing.Size(75, 23);
            this.discount_btn_create.TabIndex = 1;
            this.discount_btn_create.Text = "Create";
            this.discount_btn_create.UseVisualStyleBackColor = true;
            this.discount_btn_create.Click += new System.EventHandler(this.discount_btn_create_Click);
            // 
            // discount_txt_dPercent
            // 
            this.discount_txt_dPercent.Location = new System.Drawing.Point(193, 54);
            this.discount_txt_dPercent.Name = "discount_txt_dPercent";
            this.discount_txt_dPercent.Size = new System.Drawing.Size(100, 20);
            this.discount_txt_dPercent.TabIndex = 0;
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
            this.createTab.ResumeLayout(false);
            this.create_roomTab.ResumeLayout(false);
            this.create_roomTab.PerformLayout();
            this.create_movieTab.ResumeLayout(false);
            this.create_movieTab.PerformLayout();
            this.create_reservationTab.ResumeLayout(false);
            this.create_reservationTab.PerformLayout();
            this.create_discountTab.ResumeLayout(false);
            this.create_discountTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl createTab;
        private System.Windows.Forms.TabPage create_roomTab;
        private System.Windows.Forms.Button room_btn_create;
        private System.Windows.Forms.Label rowLbl;
        private System.Windows.Forms.Label columLbl;
        private System.Windows.Forms.TextBox room_txt_row;
        private System.Windows.Forms.TextBox room_txt_col;
        private System.Windows.Forms.TabPage create_movieTab;
        private System.Windows.Forms.DateTimePicker movie_date_picker;
        private System.Windows.Forms.Button movie_btn_create;
        private System.Windows.Forms.Label movie_roomId_lbl;
        private System.Windows.Forms.Label movie_date_lbl;
        private System.Windows.Forms.Label movie_title_lbl;
        private System.Windows.Forms.TextBox movie_txt_roomId;
        private System.Windows.Forms.TextBox movie_txt_title;
        private System.Windows.Forms.TabPage create_reservationTab;
        private System.Windows.Forms.Button reserv_btn_create;
        private System.Windows.Forms.Label reserv_seatCount_lbl;
        private System.Windows.Forms.Label reserv_movieId_lbl;
        private System.Windows.Forms.Label reserv_date_lbl;
        private System.Windows.Forms.TextBox reserv_txt_seatCount;
        private System.Windows.Forms.TextBox reserv_txt_movieId;
        private System.Windows.Forms.TextBox reserv_txt_name;
        private System.Windows.Forms.DateTimePicker reserv_date_picker;
        private System.Windows.Forms.CheckBox reserv_taken_chk;
        private System.Windows.Forms.Label reserv_name_lbl;
        private System.Windows.Forms.TabPage create_discountTab;
        private System.Windows.Forms.Label discount_percent_lbl;
        private System.Windows.Forms.Button discount_btn_create;
        private System.Windows.Forms.TextBox discount_txt_dPercent;
    }
}
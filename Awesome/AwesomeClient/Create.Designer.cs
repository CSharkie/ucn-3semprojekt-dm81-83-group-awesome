﻿using System;
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
            this.movie_lbl_daysNo = new System.Windows.Forms.Label();
            this.movie_lbl_date3 = new System.Windows.Forms.Label();
            this.movie_lbl_date2 = new System.Windows.Forms.Label();
            this.movie_txt_daysNo = new System.Windows.Forms.TextBox();
            this.movie_date_picker3 = new System.Windows.Forms.DateTimePicker();
            this.movie_date_picker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.movie_txt_duration = new System.Windows.Forms.TextBox();
            this.movie_date_picker1 = new System.Windows.Forms.DateTimePicker();
            this.movie_btn_create = new System.Windows.Forms.Button();
            this.movie_roomId_lbl = new System.Windows.Forms.Label();
            this.movie_lbl_date1 = new System.Windows.Forms.Label();
            this.movie_title_lbl = new System.Windows.Forms.Label();
            this.movie_txt_roomId = new System.Windows.Forms.TextBox();
            this.movie_txt_title = new System.Windows.Forms.TextBox();
            this.create_reservationTab = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.reserv_txt_DId = new System.Windows.Forms.TextBox();
            this.reserv_btn_prl = new System.Windows.Forms.Button();
            this.Validation = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.reserv_txt_SeatsNo = new System.Windows.Forms.TextBox();
            this.reserv_btn_next = new System.Windows.Forms.Button();
            this.reserv_btn_getAdj = new System.Windows.Forms.Button();
            this.reserv_btn_reset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.reserv_combo_movie = new System.Windows.Forms.ComboBox();
            this.reserv_btn_getRoom = new System.Windows.Forms.Button();
            this.reserv_txt_title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reserv_panel_room = new System.Windows.Forms.Panel();
            this.reserv_btn_create = new System.Windows.Forms.Button();
            this.reserv_movieId_lbl = new System.Windows.Forms.Label();
            this.reserv_txt_movieId = new System.Windows.Forms.TextBox();
            this.reserv_txt_name = new System.Windows.Forms.TextBox();
            this.reserv_chk_taken = new System.Windows.Forms.CheckBox();
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
            this.create_movieTab.Controls.Add(this.movie_lbl_daysNo);
            this.create_movieTab.Controls.Add(this.movie_lbl_date3);
            this.create_movieTab.Controls.Add(this.movie_lbl_date2);
            this.create_movieTab.Controls.Add(this.movie_txt_daysNo);
            this.create_movieTab.Controls.Add(this.movie_date_picker3);
            this.create_movieTab.Controls.Add(this.movie_date_picker2);
            this.create_movieTab.Controls.Add(this.label1);
            this.create_movieTab.Controls.Add(this.movie_txt_duration);
            this.create_movieTab.Controls.Add(this.movie_date_picker1);
            this.create_movieTab.Controls.Add(this.movie_btn_create);
            this.create_movieTab.Controls.Add(this.movie_roomId_lbl);
            this.create_movieTab.Controls.Add(this.movie_lbl_date1);
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
            // movie_lbl_daysNo
            // 
            this.movie_lbl_daysNo.AutoSize = true;
            this.movie_lbl_daysNo.Location = new System.Drawing.Point(81, 140);
            this.movie_lbl_daysNo.Name = "movie_lbl_daysNo";
            this.movie_lbl_daysNo.Size = new System.Drawing.Size(66, 13);
            this.movie_lbl_daysNo.TabIndex = 15;
            this.movie_lbl_daysNo.Text = "No. of Days:";
            // 
            // movie_lbl_date3
            // 
            this.movie_lbl_date3.AutoSize = true;
            this.movie_lbl_date3.Location = new System.Drawing.Point(98, 114);
            this.movie_lbl_date3.Name = "movie_lbl_date3";
            this.movie_lbl_date3.Size = new System.Drawing.Size(48, 13);
            this.movie_lbl_date3.TabIndex = 14;
            this.movie_lbl_date3.Text = "Movie 3:";
            // 
            // movie_lbl_date2
            // 
            this.movie_lbl_date2.AutoSize = true;
            this.movie_lbl_date2.Location = new System.Drawing.Point(98, 88);
            this.movie_lbl_date2.Name = "movie_lbl_date2";
            this.movie_lbl_date2.Size = new System.Drawing.Size(48, 13);
            this.movie_lbl_date2.TabIndex = 13;
            this.movie_lbl_date2.Text = "Movie 2:";
            // 
            // movie_txt_daysNo
            // 
            this.movie_txt_daysNo.Location = new System.Drawing.Point(152, 137);
            this.movie_txt_daysNo.Name = "movie_txt_daysNo";
            this.movie_txt_daysNo.Size = new System.Drawing.Size(200, 20);
            this.movie_txt_daysNo.TabIndex = 12;
            // 
            // movie_date_picker3
            // 
            this.movie_date_picker3.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.movie_date_picker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.movie_date_picker3.Location = new System.Drawing.Point(152, 111);
            this.movie_date_picker3.Name = "movie_date_picker3";
            this.movie_date_picker3.Size = new System.Drawing.Size(200, 20);
            this.movie_date_picker3.TabIndex = 11;
            // 
            // movie_date_picker2
            // 
            this.movie_date_picker2.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.movie_date_picker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.movie_date_picker2.Location = new System.Drawing.Point(152, 85);
            this.movie_date_picker2.Name = "movie_date_picker2";
            this.movie_date_picker2.Size = new System.Drawing.Size(200, 20);
            this.movie_date_picker2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Duration:";
            // 
            // movie_txt_duration
            // 
            this.movie_txt_duration.Location = new System.Drawing.Point(152, 163);
            this.movie_txt_duration.Name = "movie_txt_duration";
            this.movie_txt_duration.Size = new System.Drawing.Size(200, 20);
            this.movie_txt_duration.TabIndex = 8;
            // 
            // movie_date_picker1
            // 
            this.movie_date_picker1.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.movie_date_picker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.movie_date_picker1.Location = new System.Drawing.Point(152, 59);
            this.movie_date_picker1.Name = "movie_date_picker1";
            this.movie_date_picker1.Size = new System.Drawing.Size(200, 20);
            this.movie_date_picker1.TabIndex = 7;
            // 
            // movie_btn_create
            // 
            this.movie_btn_create.Location = new System.Drawing.Point(152, 215);
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
            this.movie_roomId_lbl.Location = new System.Drawing.Point(96, 192);
            this.movie_roomId_lbl.Name = "movie_roomId_lbl";
            this.movie_roomId_lbl.Size = new System.Drawing.Size(50, 13);
            this.movie_roomId_lbl.TabIndex = 5;
            this.movie_roomId_lbl.Text = "Room Id:";
            // 
            // movie_lbl_date1
            // 
            this.movie_lbl_date1.AutoSize = true;
            this.movie_lbl_date1.Location = new System.Drawing.Point(98, 62);
            this.movie_lbl_date1.Name = "movie_lbl_date1";
            this.movie_lbl_date1.Size = new System.Drawing.Size(48, 13);
            this.movie_lbl_date1.TabIndex = 4;
            this.movie_lbl_date1.Text = "Movie 1:";
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
            this.movie_txt_roomId.Location = new System.Drawing.Point(152, 189);
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
            this.create_reservationTab.Controls.Add(this.label5);
            this.create_reservationTab.Controls.Add(this.reserv_txt_DId);
            this.create_reservationTab.Controls.Add(this.reserv_btn_prl);
            this.create_reservationTab.Controls.Add(this.Validation);
            this.create_reservationTab.Controls.Add(this.label4);
            this.create_reservationTab.Controls.Add(this.reserv_txt_SeatsNo);
            this.create_reservationTab.Controls.Add(this.reserv_btn_next);
            this.create_reservationTab.Controls.Add(this.reserv_btn_getAdj);
            this.create_reservationTab.Controls.Add(this.reserv_btn_reset);
            this.create_reservationTab.Controls.Add(this.label3);
            this.create_reservationTab.Controls.Add(this.reserv_combo_movie);
            this.create_reservationTab.Controls.Add(this.reserv_btn_getRoom);
            this.create_reservationTab.Controls.Add(this.reserv_txt_title);
            this.create_reservationTab.Controls.Add(this.label2);
            this.create_reservationTab.Controls.Add(this.reserv_panel_room);
            this.create_reservationTab.Controls.Add(this.reserv_btn_create);
            this.create_reservationTab.Controls.Add(this.reserv_movieId_lbl);
            this.create_reservationTab.Controls.Add(this.reserv_txt_movieId);
            this.create_reservationTab.Controls.Add(this.reserv_txt_name);
            this.create_reservationTab.Controls.Add(this.reserv_chk_taken);
            this.create_reservationTab.Controls.Add(this.reserv_name_lbl);
            this.create_reservationTab.Location = new System.Drawing.Point(4, 22);
            this.create_reservationTab.Name = "create_reservationTab";
            this.create_reservationTab.Padding = new System.Windows.Forms.Padding(3);
            this.create_reservationTab.Size = new System.Drawing.Size(642, 434);
            this.create_reservationTab.TabIndex = 2;
            this.create_reservationTab.Text = "Reservation";
            this.create_reservationTab.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "DiscountId:";
            // 
            // reserv_txt_DId
            // 
            this.reserv_txt_DId.Location = new System.Drawing.Point(409, 12);
            this.reserv_txt_DId.Name = "reserv_txt_DId";
            this.reserv_txt_DId.Size = new System.Drawing.Size(101, 20);
            this.reserv_txt_DId.TabIndex = 24;
            this.reserv_txt_DId.Text = "2";
            this.reserv_txt_DId.TextChanged += new System.EventHandler(this.reserv_txt_DId_TextChanged);
            // 
            // reserv_btn_prl
            // 
            this.reserv_btn_prl.Location = new System.Drawing.Point(379, 113);
            this.reserv_btn_prl.Name = "reserv_btn_prl";
            this.reserv_btn_prl.Size = new System.Drawing.Size(95, 23);
            this.reserv_btn_prl.TabIndex = 23;
            this.reserv_btn_prl.Text = "GetSeatsPrallel";
            this.reserv_btn_prl.UseVisualStyleBackColor = true;
            this.reserv_btn_prl.Click += new System.EventHandler(this.reserv_btn_prl_Click);
            // 
            // Validation
            // 
            this.Validation.AutoSize = true;
            this.Validation.Location = new System.Drawing.Point(314, 15);
            this.Validation.Name = "Validation";
            this.Validation.Size = new System.Drawing.Size(31, 13);
            this.Validation.TabIndex = 21;
            this.Validation.Text = "        ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "No. of adj Seats: ";
            // 
            // reserv_txt_SeatsNo
            // 
            this.reserv_txt_SeatsNo.Location = new System.Drawing.Point(409, 85);
            this.reserv_txt_SeatsNo.Name = "reserv_txt_SeatsNo";
            this.reserv_txt_SeatsNo.Size = new System.Drawing.Size(101, 20);
            this.reserv_txt_SeatsNo.TabIndex = 21;
            this.reserv_txt_SeatsNo.TextChanged += new System.EventHandler(this.reserv_txt_SeatsNo_TextChanged);
            // 
            // reserv_btn_next
            // 
            this.reserv_btn_next.Location = new System.Drawing.Point(480, 113);
            this.reserv_btn_next.Name = "reserv_btn_next";
            this.reserv_btn_next.Size = new System.Drawing.Size(75, 23);
            this.reserv_btn_next.TabIndex = 20;
            this.reserv_btn_next.Text = "Next";
            this.reserv_btn_next.UseVisualStyleBackColor = true;
            this.reserv_btn_next.Click += new System.EventHandler(this.reserv_btn_next_Click);
            // 
            // reserv_btn_getAdj
            // 
            this.reserv_btn_getAdj.Location = new System.Drawing.Point(270, 113);
            this.reserv_btn_getAdj.Name = "reserv_btn_getAdj";
            this.reserv_btn_getAdj.Size = new System.Drawing.Size(103, 23);
            this.reserv_btn_getAdj.TabIndex = 19;
            this.reserv_btn_getAdj.Text = "Get Adj Seats";
            this.reserv_btn_getAdj.UseVisualStyleBackColor = true;
            this.reserv_btn_getAdj.Click += new System.EventHandler(this.reserv_btn_getAdj_Click);
            // 
            // reserv_btn_reset
            // 
            this.reserv_btn_reset.Location = new System.Drawing.Point(27, 113);
            this.reserv_btn_reset.Name = "reserv_btn_reset";
            this.reserv_btn_reset.Size = new System.Drawing.Size(75, 23);
            this.reserv_btn_reset.TabIndex = 18;
            this.reserv_btn_reset.Text = "Reset All";
            this.reserv_btn_reset.UseVisualStyleBackColor = true;
            this.reserv_btn_reset.Click += new System.EventHandler(this.reserv_btn_reset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Select the movie:";
            // 
            // reserv_combo_movie
            // 
            this.reserv_combo_movie.Enabled = false;
            this.reserv_combo_movie.FormattingEnabled = true;
            this.reserv_combo_movie.Location = new System.Drawing.Point(108, 85);
            this.reserv_combo_movie.Name = "reserv_combo_movie";
            this.reserv_combo_movie.Size = new System.Drawing.Size(200, 21);
            this.reserv_combo_movie.TabIndex = 16;
            // 
            // reserv_btn_getRoom
            // 
            this.reserv_btn_getRoom.Location = new System.Drawing.Point(108, 113);
            this.reserv_btn_getRoom.Name = "reserv_btn_getRoom";
            this.reserv_btn_getRoom.Size = new System.Drawing.Size(75, 23);
            this.reserv_btn_getRoom.TabIndex = 15;
            this.reserv_btn_getRoom.Text = "Get Room";
            this.reserv_btn_getRoom.UseVisualStyleBackColor = true;
            this.reserv_btn_getRoom.Click += new System.EventHandler(this.reserv_btn_getRoom_Click);
            // 
            // reserv_txt_title
            // 
            this.reserv_txt_title.Location = new System.Drawing.Point(207, 58);
            this.reserv_txt_title.Name = "reserv_txt_title";
            this.reserv_txt_title.Size = new System.Drawing.Size(101, 20);
            this.reserv_txt_title.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Title:";
            // 
            // reserv_panel_room
            // 
            this.reserv_panel_room.AutoScroll = true;
            this.reserv_panel_room.Location = new System.Drawing.Point(6, 142);
            this.reserv_panel_room.Name = "reserv_panel_room";
            this.reserv_panel_room.Size = new System.Drawing.Size(628, 284);
            this.reserv_panel_room.TabIndex = 12;
            // 
            // reserv_btn_create
            // 
            this.reserv_btn_create.Enabled = false;
            this.reserv_btn_create.Location = new System.Drawing.Point(189, 113);
            this.reserv_btn_create.Name = "reserv_btn_create";
            this.reserv_btn_create.Size = new System.Drawing.Size(75, 23);
            this.reserv_btn_create.TabIndex = 11;
            this.reserv_btn_create.Text = "Create";
            this.reserv_btn_create.UseVisualStyleBackColor = true;
            this.reserv_btn_create.Click += new System.EventHandler(this.reserv_btn_create_Click);
            // 
            // reserv_movieId_lbl
            // 
            this.reserv_movieId_lbl.AutoSize = true;
            this.reserv_movieId_lbl.Location = new System.Drawing.Point(51, 61);
            this.reserv_movieId_lbl.Name = "reserv_movieId_lbl";
            this.reserv_movieId_lbl.Size = new System.Drawing.Size(51, 13);
            this.reserv_movieId_lbl.TabIndex = 9;
            this.reserv_movieId_lbl.Text = "Movie Id:";
            // 
            // reserv_txt_movieId
            // 
            this.reserv_txt_movieId.Location = new System.Drawing.Point(108, 58);
            this.reserv_txt_movieId.Name = "reserv_txt_movieId";
            this.reserv_txt_movieId.Size = new System.Drawing.Size(57, 20);
            this.reserv_txt_movieId.TabIndex = 4;
            this.reserv_txt_movieId.TextChanged += new System.EventHandler(this.reserv_txt_movieId_TextChanged);
            // 
            // reserv_txt_name
            // 
            this.reserv_txt_name.Location = new System.Drawing.Point(108, 12);
            this.reserv_txt_name.Name = "reserv_txt_name";
            this.reserv_txt_name.Size = new System.Drawing.Size(200, 20);
            this.reserv_txt_name.TabIndex = 2;
            this.reserv_txt_name.TextChanged += new System.EventHandler(this.reserv_txt_name_TextChanged);
            // 
            // reserv_chk_taken
            // 
            this.reserv_chk_taken.AccessibleDescription = "";
            this.reserv_chk_taken.AutoSize = true;
            this.reserv_chk_taken.Location = new System.Drawing.Point(108, 38);
            this.reserv_chk_taken.Name = "reserv_chk_taken";
            this.reserv_chk_taken.Size = new System.Drawing.Size(57, 17);
            this.reserv_chk_taken.TabIndex = 5;
            this.reserv_chk_taken.Text = "Taken";
            this.reserv_chk_taken.UseVisualStyleBackColor = true;
            // 
            // reserv_name_lbl
            // 
            this.reserv_name_lbl.AutoSize = true;
            this.reserv_name_lbl.Location = new System.Drawing.Point(64, 15);
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
            this.AutoScroll = true;
            this.AutoSize = true;
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
        private System.Windows.Forms.DateTimePicker movie_date_picker1;
        private System.Windows.Forms.Button movie_btn_create;
        private System.Windows.Forms.Label movie_roomId_lbl;
        private System.Windows.Forms.Label movie_lbl_date1;
        private System.Windows.Forms.Label movie_title_lbl;
        private System.Windows.Forms.TextBox movie_txt_roomId;
        private System.Windows.Forms.TextBox movie_txt_title;
        private System.Windows.Forms.TabPage create_reservationTab;
        private System.Windows.Forms.Button reserv_btn_create;
        private System.Windows.Forms.Label reserv_movieId_lbl;
        private System.Windows.Forms.TextBox reserv_txt_movieId;
        private System.Windows.Forms.TextBox reserv_txt_name;
        private System.Windows.Forms.CheckBox reserv_chk_taken;
        private System.Windows.Forms.Label reserv_name_lbl;
        private System.Windows.Forms.TabPage create_discountTab;
        private System.Windows.Forms.Label discount_percent_lbl;
        private System.Windows.Forms.Button discount_btn_create;
        private System.Windows.Forms.TextBox discount_txt_dPercent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox movie_txt_duration;
        private System.Windows.Forms.Panel reserv_panel_room;
        private System.Windows.Forms.TextBox reserv_txt_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button reserv_btn_getRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox reserv_combo_movie;
        private System.Windows.Forms.Button reserv_btn_reset;
        private System.Windows.Forms.Button reserv_btn_getAdj;
        private System.Windows.Forms.Button reserv_btn_next;
        private System.Windows.Forms.Label Validation;
        private System.Windows.Forms.TextBox reserv_txt_SeatsNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label movie_lbl_daysNo;
        private System.Windows.Forms.Label movie_lbl_date3;
        private System.Windows.Forms.Label movie_lbl_date2;
        private System.Windows.Forms.TextBox movie_txt_daysNo;
        private System.Windows.Forms.DateTimePicker movie_date_picker3;
        private System.Windows.Forms.DateTimePicker movie_date_picker2;
        private System.Windows.Forms.Button reserv_btn_prl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox reserv_txt_DId;

    }
}
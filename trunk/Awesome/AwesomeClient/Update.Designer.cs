namespace AwesomeClient
{
    partial class Update
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
            this.updateTabs = new System.Windows.Forms.TabControl();
            this.roomTab = new System.Windows.Forms.TabPage();
            this.room_btn_show = new System.Windows.Forms.Button();
            this.room_btn_save = new System.Windows.Forms.Button();
            this.room_txt_seats = new System.Windows.Forms.TextBox();
            this.room_btn_edit = new System.Windows.Forms.Button();
            this.room_txt_rows = new System.Windows.Forms.TextBox();
            this.room_seats_lbl = new System.Windows.Forms.Label();
            this.room_txt_cols = new System.Windows.Forms.TextBox();
            this.room_rows_lbl = new System.Windows.Forms.Label();
            this.room_txt_roomId = new System.Windows.Forms.TextBox();
            this.room_cols_lbl = new System.Windows.Forms.Label();
            this.room_roomId_lbl = new System.Windows.Forms.Label();
            this.movieTab = new System.Windows.Forms.TabPage();
            this.movie_btn_reset = new System.Windows.Forms.Button();
            this.movie_btn_find = new System.Windows.Forms.Button();
            this.movie_combo_movies = new System.Windows.Forms.ComboBox();
            this.movie_lbl_dropdown = new System.Windows.Forms.Label();
            this.movie_roomId_lbl = new System.Windows.Forms.Label();
            this.movie_date_lbl = new System.Windows.Forms.Label();
            this.movie_title_lbl = new System.Windows.Forms.Label();
            this.movie_movieId_lbl = new System.Windows.Forms.Label();
            this.movie_btn_save = new System.Windows.Forms.Button();
            this.movie_btn_edit = new System.Windows.Forms.Button();
            this.movie_date_picker = new System.Windows.Forms.DateTimePicker();
            this.movie_txt_roomId = new System.Windows.Forms.TextBox();
            this.movie_txt_title = new System.Windows.Forms.TextBox();
            this.movie_txt_movieId = new System.Windows.Forms.TextBox();
            this.reservationTab = new System.Windows.Forms.TabPage();
            this.reserv_lbl_reservations = new System.Windows.Forms.Label();
            this.reserv_combo_reservations = new System.Windows.Forms.ComboBox();
            this.reserv_reservId_lbl = new System.Windows.Forms.Label();
            this.reserv_txt_reservId = new System.Windows.Forms.TextBox();
            this.reserv_seatCount_lbl = new System.Windows.Forms.Label();
            this.reserv_lbl_date = new System.Windows.Forms.Label();
            this.reserv_name_lbl = new System.Windows.Forms.Label();
            this.reserv_check_taken = new System.Windows.Forms.CheckBox();
            this.reserv_txt_seatCount = new System.Windows.Forms.TextBox();
            this.reserv_txt_name = new System.Windows.Forms.TextBox();
            this.reserv_btn_show = new System.Windows.Forms.Button();
            this.reserv_btn_save = new System.Windows.Forms.Button();
            this.reserv_btn_edit = new System.Windows.Forms.Button();
            this.discountTab = new System.Windows.Forms.TabPage();
            this.discount_percent_lbl = new System.Windows.Forms.Label();
            this.discount_id_lbl = new System.Windows.Forms.Label();
            this.discount_txt_percent = new System.Windows.Forms.TextBox();
            this.discount_txt_id = new System.Windows.Forms.TextBox();
            this.discount_btn_show = new System.Windows.Forms.Button();
            this.discount_btn_save = new System.Windows.Forms.Button();
            this.discount_btn_edit = new System.Windows.Forms.Button();
            this.ticketTab = new System.Windows.Forms.TabPage();
            this.ticket_btn_show = new System.Windows.Forms.Button();
            this.ticket_btn_save = new System.Windows.Forms.Button();
            this.ticket_btn_edit = new System.Windows.Forms.Button();
            this.ticket_discount_lbl = new System.Windows.Forms.Label();
            this.ticket_reservId_lbl = new System.Windows.Forms.Label();
            this.ticket_price_lbl = new System.Windows.Forms.Label();
            this.ticket_id_lbl = new System.Windows.Forms.Label();
            this.ticket_txt_discount = new System.Windows.Forms.TextBox();
            this.ticket_txt_reservId = new System.Windows.Forms.TextBox();
            this.ticket_txt_price = new System.Windows.Forms.TextBox();
            this.ticket_txt_id = new System.Windows.Forms.TextBox();
            this.movie_txt_duration = new System.Windows.Forms.TextBox();
            this.movie_lbl_duration = new System.Windows.Forms.Label();
            this.reserv_dateTime_picker = new System.Windows.Forms.DateTimePicker();
            this.reserv_btn_reset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.updateTabs.SuspendLayout();
            this.roomTab.SuspendLayout();
            this.movieTab.SuspendLayout();
            this.reservationTab.SuspendLayout();
            this.discountTab.SuspendLayout();
            this.ticketTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.updateTabs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 460);
            this.panel1.TabIndex = 1;
            // 
            // updateTabs
            // 
            this.updateTabs.Controls.Add(this.roomTab);
            this.updateTabs.Controls.Add(this.movieTab);
            this.updateTabs.Controls.Add(this.reservationTab);
            this.updateTabs.Controls.Add(this.discountTab);
            this.updateTabs.Controls.Add(this.ticketTab);
            this.updateTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateTabs.Location = new System.Drawing.Point(0, 0);
            this.updateTabs.Name = "updateTabs";
            this.updateTabs.SelectedIndex = 0;
            this.updateTabs.Size = new System.Drawing.Size(650, 460);
            this.updateTabs.TabIndex = 0;
            // 
            // roomTab
            // 
            this.roomTab.Controls.Add(this.room_btn_show);
            this.roomTab.Controls.Add(this.room_btn_save);
            this.roomTab.Controls.Add(this.room_txt_seats);
            this.roomTab.Controls.Add(this.room_btn_edit);
            this.roomTab.Controls.Add(this.room_txt_rows);
            this.roomTab.Controls.Add(this.room_seats_lbl);
            this.roomTab.Controls.Add(this.room_txt_cols);
            this.roomTab.Controls.Add(this.room_rows_lbl);
            this.roomTab.Controls.Add(this.room_txt_roomId);
            this.roomTab.Controls.Add(this.room_cols_lbl);
            this.roomTab.Controls.Add(this.room_roomId_lbl);
            this.roomTab.Location = new System.Drawing.Point(4, 22);
            this.roomTab.Name = "roomTab";
            this.roomTab.Padding = new System.Windows.Forms.Padding(3);
            this.roomTab.Size = new System.Drawing.Size(642, 434);
            this.roomTab.TabIndex = 0;
            this.roomTab.Text = "Room";
            this.roomTab.UseVisualStyleBackColor = true;
            // 
            // room_btn_show
            // 
            this.room_btn_show.Location = new System.Drawing.Point(85, 133);
            this.room_btn_show.Name = "room_btn_show";
            this.room_btn_show.Size = new System.Drawing.Size(100, 23);
            this.room_btn_show.TabIndex = 18;
            this.room_btn_show.Text = "Display";
            this.room_btn_show.UseVisualStyleBackColor = true;
            this.room_btn_show.Click += new System.EventHandler(this.room_show_btn_Click);
            // 
            // room_btn_save
            // 
            this.room_btn_save.Enabled = false;
            this.room_btn_save.Location = new System.Drawing.Point(85, 191);
            this.room_btn_save.Name = "room_btn_save";
            this.room_btn_save.Size = new System.Drawing.Size(100, 23);
            this.room_btn_save.TabIndex = 20;
            this.room_btn_save.Text = "Save";
            this.room_btn_save.UseVisualStyleBackColor = true;
            this.room_btn_save.Click += new System.EventHandler(this.room_save_btn_Click);
            // 
            // room_txt_seats
            // 
            this.room_txt_seats.Enabled = false;
            this.room_txt_seats.Location = new System.Drawing.Point(85, 107);
            this.room_txt_seats.Name = "room_txt_seats";
            this.room_txt_seats.Size = new System.Drawing.Size(100, 20);
            this.room_txt_seats.TabIndex = 13;
            this.room_txt_seats.TextChanged += new System.EventHandler(this.room_seats_txt_TextChanged);
            // 
            // room_btn_edit
            // 
            this.room_btn_edit.Enabled = false;
            this.room_btn_edit.Location = new System.Drawing.Point(85, 162);
            this.room_btn_edit.Name = "room_btn_edit";
            this.room_btn_edit.Size = new System.Drawing.Size(100, 23);
            this.room_btn_edit.TabIndex = 19;
            this.room_btn_edit.Text = "Edit";
            this.room_btn_edit.UseVisualStyleBackColor = true;
            this.room_btn_edit.Click += new System.EventHandler(this.room_edit_btn_Click);
            // 
            // room_txt_rows
            // 
            this.room_txt_rows.Enabled = false;
            this.room_txt_rows.Location = new System.Drawing.Point(85, 81);
            this.room_txt_rows.Name = "room_txt_rows";
            this.room_txt_rows.Size = new System.Drawing.Size(100, 20);
            this.room_txt_rows.TabIndex = 12;
            this.room_txt_rows.TextChanged += new System.EventHandler(this.room_rows_txt_TextChanged);
            // 
            // room_seats_lbl
            // 
            this.room_seats_lbl.AutoSize = true;
            this.room_seats_lbl.Location = new System.Drawing.Point(42, 110);
            this.room_seats_lbl.Name = "room_seats_lbl";
            this.room_seats_lbl.Size = new System.Drawing.Size(37, 13);
            this.room_seats_lbl.TabIndex = 3;
            this.room_seats_lbl.Text = "Seats:";
            // 
            // room_txt_cols
            // 
            this.room_txt_cols.Enabled = false;
            this.room_txt_cols.Location = new System.Drawing.Point(85, 55);
            this.room_txt_cols.Name = "room_txt_cols";
            this.room_txt_cols.Size = new System.Drawing.Size(100, 20);
            this.room_txt_cols.TabIndex = 11;
            this.room_txt_cols.TextChanged += new System.EventHandler(this.room_cols_txt_TextChanged);
            // 
            // room_rows_lbl
            // 
            this.room_rows_lbl.AutoSize = true;
            this.room_rows_lbl.Location = new System.Drawing.Point(42, 84);
            this.room_rows_lbl.Name = "room_rows_lbl";
            this.room_rows_lbl.Size = new System.Drawing.Size(37, 13);
            this.room_rows_lbl.TabIndex = 2;
            this.room_rows_lbl.Text = "Rows:";
            // 
            // room_txt_roomId
            // 
            this.room_txt_roomId.Location = new System.Drawing.Point(85, 29);
            this.room_txt_roomId.Name = "room_txt_roomId";
            this.room_txt_roomId.Size = new System.Drawing.Size(100, 20);
            this.room_txt_roomId.TabIndex = 10;
            this.room_txt_roomId.TextChanged += new System.EventHandler(this.room_roomId_txt_TextChanged);
            // 
            // room_cols_lbl
            // 
            this.room_cols_lbl.AutoSize = true;
            this.room_cols_lbl.Location = new System.Drawing.Point(29, 58);
            this.room_cols_lbl.Name = "room_cols_lbl";
            this.room_cols_lbl.Size = new System.Drawing.Size(50, 13);
            this.room_cols_lbl.TabIndex = 1;
            this.room_cols_lbl.Text = "Columns:";
            // 
            // room_roomId_lbl
            // 
            this.room_roomId_lbl.AutoSize = true;
            this.room_roomId_lbl.Location = new System.Drawing.Point(29, 32);
            this.room_roomId_lbl.Name = "room_roomId_lbl";
            this.room_roomId_lbl.Size = new System.Drawing.Size(50, 13);
            this.room_roomId_lbl.TabIndex = 0;
            this.room_roomId_lbl.Text = "Room Id:";
            // 
            // movieTab
            // 
            this.movieTab.Controls.Add(this.movie_lbl_duration);
            this.movieTab.Controls.Add(this.movie_txt_duration);
            this.movieTab.Controls.Add(this.movie_btn_reset);
            this.movieTab.Controls.Add(this.movie_btn_find);
            this.movieTab.Controls.Add(this.movie_combo_movies);
            this.movieTab.Controls.Add(this.movie_lbl_dropdown);
            this.movieTab.Controls.Add(this.movie_roomId_lbl);
            this.movieTab.Controls.Add(this.movie_date_lbl);
            this.movieTab.Controls.Add(this.movie_title_lbl);
            this.movieTab.Controls.Add(this.movie_movieId_lbl);
            this.movieTab.Controls.Add(this.movie_btn_save);
            this.movieTab.Controls.Add(this.movie_btn_edit);
            this.movieTab.Controls.Add(this.movie_date_picker);
            this.movieTab.Controls.Add(this.movie_txt_roomId);
            this.movieTab.Controls.Add(this.movie_txt_title);
            this.movieTab.Controls.Add(this.movie_txt_movieId);
            this.movieTab.Location = new System.Drawing.Point(4, 22);
            this.movieTab.Name = "movieTab";
            this.movieTab.Padding = new System.Windows.Forms.Padding(3);
            this.movieTab.Size = new System.Drawing.Size(642, 434);
            this.movieTab.TabIndex = 1;
            this.movieTab.Text = "Movie";
            this.movieTab.UseVisualStyleBackColor = true;
            // 
            // movie_btn_reset
            // 
            this.movie_btn_reset.Location = new System.Drawing.Point(225, 220);
            this.movie_btn_reset.Name = "movie_btn_reset";
            this.movie_btn_reset.Size = new System.Drawing.Size(100, 23);
            this.movie_btn_reset.TabIndex = 32;
            this.movie_btn_reset.Text = "Reset All";
            this.movie_btn_reset.UseVisualStyleBackColor = true;
            this.movie_btn_reset.Click += new System.EventHandler(this.movie_btn_reset_Click);
            // 
            // movie_btn_find
            // 
            this.movie_btn_find.Location = new System.Drawing.Point(225, 191);
            this.movie_btn_find.Name = "movie_btn_find";
            this.movie_btn_find.Size = new System.Drawing.Size(100, 23);
            this.movie_btn_find.TabIndex = 31;
            this.movie_btn_find.Text = "Find Movie";
            this.movie_btn_find.UseVisualStyleBackColor = true;
            this.movie_btn_find.Click += new System.EventHandler(this.movie_btn_find_Click);
            // 
            // movie_combo_movies
            // 
            this.movie_combo_movies.Enabled = false;
            this.movie_combo_movies.FormattingEnabled = true;
            this.movie_combo_movies.Location = new System.Drawing.Point(120, 85);
            this.movie_combo_movies.Name = "movie_combo_movies";
            this.movie_combo_movies.Size = new System.Drawing.Size(313, 21);
            this.movie_combo_movies.TabIndex = 30;
            // 
            // movie_lbl_dropdown
            // 
            this.movie_lbl_dropdown.AutoSize = true;
            this.movie_lbl_dropdown.Location = new System.Drawing.Point(70, 88);
            this.movie_lbl_dropdown.Name = "movie_lbl_dropdown";
            this.movie_lbl_dropdown.Size = new System.Drawing.Size(44, 13);
            this.movie_lbl_dropdown.TabIndex = 29;
            this.movie_lbl_dropdown.Text = "Movies:";
            // 
            // movie_roomId_lbl
            // 
            this.movie_roomId_lbl.AutoSize = true;
            this.movie_roomId_lbl.Location = new System.Drawing.Point(64, 168);
            this.movie_roomId_lbl.Name = "movie_roomId_lbl";
            this.movie_roomId_lbl.Size = new System.Drawing.Size(50, 13);
            this.movie_roomId_lbl.TabIndex = 27;
            this.movie_roomId_lbl.Text = "Room Id:";
            // 
            // movie_date_lbl
            // 
            this.movie_date_lbl.AutoSize = true;
            this.movie_date_lbl.Location = new System.Drawing.Point(34, 116);
            this.movie_date_lbl.Name = "movie_date_lbl";
            this.movie_date_lbl.Size = new System.Drawing.Size(80, 13);
            this.movie_date_lbl.TabIndex = 26;
            this.movie_date_lbl.Text = "Date and Time:";
            // 
            // movie_title_lbl
            // 
            this.movie_title_lbl.AutoSize = true;
            this.movie_title_lbl.Location = new System.Drawing.Point(84, 62);
            this.movie_title_lbl.Name = "movie_title_lbl";
            this.movie_title_lbl.Size = new System.Drawing.Size(30, 13);
            this.movie_title_lbl.TabIndex = 25;
            this.movie_title_lbl.Text = "Title:";
            // 
            // movie_movieId_lbl
            // 
            this.movie_movieId_lbl.AutoSize = true;
            this.movie_movieId_lbl.Location = new System.Drawing.Point(63, 36);
            this.movie_movieId_lbl.Name = "movie_movieId_lbl";
            this.movie_movieId_lbl.Size = new System.Drawing.Size(51, 13);
            this.movie_movieId_lbl.TabIndex = 24;
            this.movie_movieId_lbl.Text = "Movie Id:";
            // 
            // movie_btn_save
            // 
            this.movie_btn_save.Enabled = false;
            this.movie_btn_save.Location = new System.Drawing.Point(225, 278);
            this.movie_btn_save.Name = "movie_btn_save";
            this.movie_btn_save.Size = new System.Drawing.Size(100, 23);
            this.movie_btn_save.TabIndex = 23;
            this.movie_btn_save.Text = "Save";
            this.movie_btn_save.UseVisualStyleBackColor = true;
            this.movie_btn_save.Click += new System.EventHandler(this.movie_save_btn_Click);
            // 
            // movie_btn_edit
            // 
            this.movie_btn_edit.Enabled = false;
            this.movie_btn_edit.Location = new System.Drawing.Point(225, 249);
            this.movie_btn_edit.Name = "movie_btn_edit";
            this.movie_btn_edit.Size = new System.Drawing.Size(100, 23);
            this.movie_btn_edit.TabIndex = 22;
            this.movie_btn_edit.Text = "Edit";
            this.movie_btn_edit.UseVisualStyleBackColor = true;
            this.movie_btn_edit.Click += new System.EventHandler(this.movie_edit_btn_Click);
            // 
            // movie_date_picker
            // 
            this.movie_date_picker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.movie_date_picker.Enabled = false;
            this.movie_date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.movie_date_picker.Location = new System.Drawing.Point(120, 113);
            this.movie_date_picker.Name = "movie_date_picker";
            this.movie_date_picker.Size = new System.Drawing.Size(313, 20);
            this.movie_date_picker.TabIndex = 3;
            this.movie_date_picker.ValueChanged += new System.EventHandler(this.movie_date_picker_ValueChanged);
            // 
            // movie_txt_roomId
            // 
            this.movie_txt_roomId.Enabled = false;
            this.movie_txt_roomId.Location = new System.Drawing.Point(120, 165);
            this.movie_txt_roomId.Name = "movie_txt_roomId";
            this.movie_txt_roomId.Size = new System.Drawing.Size(313, 20);
            this.movie_txt_roomId.TabIndex = 2;
            this.movie_txt_roomId.TextChanged += new System.EventHandler(this.movie_roomId_txt_TextChanged);
            // 
            // movie_txt_title
            // 
            this.movie_txt_title.Location = new System.Drawing.Point(120, 59);
            this.movie_txt_title.Name = "movie_txt_title";
            this.movie_txt_title.Size = new System.Drawing.Size(313, 20);
            this.movie_txt_title.TabIndex = 1;
            this.movie_txt_title.TextChanged += new System.EventHandler(this.movie_title_txt_TextChanged);
            // 
            // movie_txt_movieId
            // 
            this.movie_txt_movieId.Location = new System.Drawing.Point(120, 33);
            this.movie_txt_movieId.Name = "movie_txt_movieId";
            this.movie_txt_movieId.Size = new System.Drawing.Size(313, 20);
            this.movie_txt_movieId.TabIndex = 0;
            this.movie_txt_movieId.TextChanged += new System.EventHandler(this.movie_movieId_txt_TextChanged);
            // 
            // reservationTab
            // 
            this.reservationTab.Controls.Add(this.reserv_btn_reset);
            this.reservationTab.Controls.Add(this.reserv_dateTime_picker);
            this.reservationTab.Controls.Add(this.reserv_lbl_reservations);
            this.reservationTab.Controls.Add(this.reserv_combo_reservations);
            this.reservationTab.Controls.Add(this.reserv_reservId_lbl);
            this.reservationTab.Controls.Add(this.reserv_txt_reservId);
            this.reservationTab.Controls.Add(this.reserv_seatCount_lbl);
            this.reservationTab.Controls.Add(this.reserv_lbl_date);
            this.reservationTab.Controls.Add(this.reserv_name_lbl);
            this.reservationTab.Controls.Add(this.reserv_check_taken);
            this.reservationTab.Controls.Add(this.reserv_txt_seatCount);
            this.reservationTab.Controls.Add(this.reserv_txt_name);
            this.reservationTab.Controls.Add(this.reserv_btn_show);
            this.reservationTab.Controls.Add(this.reserv_btn_save);
            this.reservationTab.Controls.Add(this.reserv_btn_edit);
            this.reservationTab.Location = new System.Drawing.Point(4, 22);
            this.reservationTab.Name = "reservationTab";
            this.reservationTab.Padding = new System.Windows.Forms.Padding(3);
            this.reservationTab.Size = new System.Drawing.Size(642, 434);
            this.reservationTab.TabIndex = 2;
            this.reservationTab.Text = "Reservation";
            this.reservationTab.UseVisualStyleBackColor = true;
            // 
            // reserv_lbl_reservations
            // 
            this.reserv_lbl_reservations.AutoSize = true;
            this.reserv_lbl_reservations.Location = new System.Drawing.Point(85, 52);
            this.reserv_lbl_reservations.Name = "reserv_lbl_reservations";
            this.reserv_lbl_reservations.Size = new System.Drawing.Size(72, 13);
            this.reserv_lbl_reservations.TabIndex = 37;
            this.reserv_lbl_reservations.Text = "Reservations:";
            // 
            // reserv_combo_reservations
            // 
            this.reserv_combo_reservations.Enabled = false;
            this.reserv_combo_reservations.FormattingEnabled = true;
            this.reserv_combo_reservations.Location = new System.Drawing.Point(163, 49);
            this.reserv_combo_reservations.Name = "reserv_combo_reservations";
            this.reserv_combo_reservations.Size = new System.Drawing.Size(256, 21);
            this.reserv_combo_reservations.TabIndex = 36;
            // 
            // reserv_reservId_lbl
            // 
            this.reserv_reservId_lbl.AutoSize = true;
            this.reserv_reservId_lbl.Location = new System.Drawing.Point(333, 25);
            this.reserv_reservId_lbl.Name = "reserv_reservId_lbl";
            this.reserv_reservId_lbl.Size = new System.Drawing.Size(19, 13);
            this.reserv_reservId_lbl.TabIndex = 35;
            this.reserv_reservId_lbl.Text = "Id:";
            // 
            // reserv_txt_reservId
            // 
            this.reserv_txt_reservId.Location = new System.Drawing.Point(358, 22);
            this.reserv_txt_reservId.Name = "reserv_txt_reservId";
            this.reserv_txt_reservId.Size = new System.Drawing.Size(61, 20);
            this.reserv_txt_reservId.TabIndex = 34;
            // 
            // reserv_seatCount_lbl
            // 
            this.reserv_seatCount_lbl.AutoSize = true;
            this.reserv_seatCount_lbl.Location = new System.Drawing.Point(94, 130);
            this.reserv_seatCount_lbl.Name = "reserv_seatCount_lbl";
            this.reserv_seatCount_lbl.Size = new System.Drawing.Size(63, 13);
            this.reserv_seatCount_lbl.TabIndex = 33;
            this.reserv_seatCount_lbl.Text = "Seat Count:";
            // 
            // reserv_lbl_date
            // 
            this.reserv_lbl_date.AutoSize = true;
            this.reserv_lbl_date.Location = new System.Drawing.Point(64, 104);
            this.reserv_lbl_date.Name = "reserv_lbl_date";
            this.reserv_lbl_date.Size = new System.Drawing.Size(93, 13);
            this.reserv_lbl_date.TabIndex = 32;
            this.reserv_lbl_date.Text = "Reservation Date:";
            // 
            // reserv_name_lbl
            // 
            this.reserv_name_lbl.AutoSize = true;
            this.reserv_name_lbl.Location = new System.Drawing.Point(119, 25);
            this.reserv_name_lbl.Name = "reserv_name_lbl";
            this.reserv_name_lbl.Size = new System.Drawing.Size(38, 13);
            this.reserv_name_lbl.TabIndex = 31;
            this.reserv_name_lbl.Text = "Name:";
            // 
            // reserv_check_taken
            // 
            this.reserv_check_taken.AutoSize = true;
            this.reserv_check_taken.Enabled = false;
            this.reserv_check_taken.Location = new System.Drawing.Point(163, 78);
            this.reserv_check_taken.Name = "reserv_check_taken";
            this.reserv_check_taken.Size = new System.Drawing.Size(57, 17);
            this.reserv_check_taken.TabIndex = 30;
            this.reserv_check_taken.Text = "Taken";
            this.reserv_check_taken.UseVisualStyleBackColor = true;
            this.reserv_check_taken.CheckedChanged += new System.EventHandler(this.reserv_taken_check_CheckedChanged);
            // 
            // reserv_txt_seatCount
            // 
            this.reserv_txt_seatCount.Enabled = false;
            this.reserv_txt_seatCount.Location = new System.Drawing.Point(163, 127);
            this.reserv_txt_seatCount.Name = "reserv_txt_seatCount";
            this.reserv_txt_seatCount.Size = new System.Drawing.Size(256, 20);
            this.reserv_txt_seatCount.TabIndex = 29;
            this.reserv_txt_seatCount.TextChanged += new System.EventHandler(this.reserv_seatCount_txt_TextChanged);
            // 
            // reserv_txt_name
            // 
            this.reserv_txt_name.Location = new System.Drawing.Point(163, 22);
            this.reserv_txt_name.Name = "reserv_txt_name";
            this.reserv_txt_name.Size = new System.Drawing.Size(164, 20);
            this.reserv_txt_name.TabIndex = 27;
            this.reserv_txt_name.TextChanged += new System.EventHandler(this.reserv_name_txt_TextChanged);
            // 
            // reserv_btn_show
            // 
            this.reserv_btn_show.Location = new System.Drawing.Point(252, 153);
            this.reserv_btn_show.Name = "reserv_btn_show";
            this.reserv_btn_show.Size = new System.Drawing.Size(100, 23);
            this.reserv_btn_show.TabIndex = 24;
            this.reserv_btn_show.Text = "Find";
            this.reserv_btn_show.UseVisualStyleBackColor = true;
            this.reserv_btn_show.Click += new System.EventHandler(this.reserv_show_btn_Click);
            // 
            // reserv_btn_save
            // 
            this.reserv_btn_save.Enabled = false;
            this.reserv_btn_save.Location = new System.Drawing.Point(252, 240);
            this.reserv_btn_save.Name = "reserv_btn_save";
            this.reserv_btn_save.Size = new System.Drawing.Size(100, 23);
            this.reserv_btn_save.TabIndex = 26;
            this.reserv_btn_save.Text = "Save";
            this.reserv_btn_save.UseVisualStyleBackColor = true;
            this.reserv_btn_save.Click += new System.EventHandler(this.reserv_save_btn_Click);
            // 
            // reserv_btn_edit
            // 
            this.reserv_btn_edit.Enabled = false;
            this.reserv_btn_edit.Location = new System.Drawing.Point(252, 211);
            this.reserv_btn_edit.Name = "reserv_btn_edit";
            this.reserv_btn_edit.Size = new System.Drawing.Size(100, 23);
            this.reserv_btn_edit.TabIndex = 25;
            this.reserv_btn_edit.Text = "Edit";
            this.reserv_btn_edit.UseVisualStyleBackColor = true;
            this.reserv_btn_edit.Click += new System.EventHandler(this.reserv_edit_btn_Click);
            // 
            // discountTab
            // 
            this.discountTab.Controls.Add(this.discount_percent_lbl);
            this.discountTab.Controls.Add(this.discount_id_lbl);
            this.discountTab.Controls.Add(this.discount_txt_percent);
            this.discountTab.Controls.Add(this.discount_txt_id);
            this.discountTab.Controls.Add(this.discount_btn_show);
            this.discountTab.Controls.Add(this.discount_btn_save);
            this.discountTab.Controls.Add(this.discount_btn_edit);
            this.discountTab.Location = new System.Drawing.Point(4, 22);
            this.discountTab.Name = "discountTab";
            this.discountTab.Padding = new System.Windows.Forms.Padding(3);
            this.discountTab.Size = new System.Drawing.Size(642, 434);
            this.discountTab.TabIndex = 3;
            this.discountTab.Text = "Discount";
            this.discountTab.UseVisualStyleBackColor = true;
            // 
            // discount_percent_lbl
            // 
            this.discount_percent_lbl.AutoSize = true;
            this.discount_percent_lbl.Location = new System.Drawing.Point(159, 66);
            this.discount_percent_lbl.Name = "discount_percent_lbl";
            this.discount_percent_lbl.Size = new System.Drawing.Size(65, 13);
            this.discount_percent_lbl.TabIndex = 33;
            this.discount_percent_lbl.Text = "Percentage:";
            // 
            // discount_id_lbl
            // 
            this.discount_id_lbl.AutoSize = true;
            this.discount_id_lbl.Location = new System.Drawing.Point(160, 40);
            this.discount_id_lbl.Name = "discount_id_lbl";
            this.discount_id_lbl.Size = new System.Drawing.Size(64, 13);
            this.discount_id_lbl.TabIndex = 32;
            this.discount_id_lbl.Text = "Discount Id:";
            // 
            // discount_txt_percent
            // 
            this.discount_txt_percent.Location = new System.Drawing.Point(230, 63);
            this.discount_txt_percent.Name = "discount_txt_percent";
            this.discount_txt_percent.Size = new System.Drawing.Size(100, 20);
            this.discount_txt_percent.TabIndex = 31;
            this.discount_txt_percent.TextChanged += new System.EventHandler(this.discount_percent_txt_TextChanged);
            // 
            // discount_txt_id
            // 
            this.discount_txt_id.Location = new System.Drawing.Point(230, 37);
            this.discount_txt_id.Name = "discount_txt_id";
            this.discount_txt_id.Size = new System.Drawing.Size(100, 20);
            this.discount_txt_id.TabIndex = 30;
            this.discount_txt_id.TextChanged += new System.EventHandler(this.discount_id_txt_TextChanged);
            // 
            // discount_btn_show
            // 
            this.discount_btn_show.Location = new System.Drawing.Point(230, 89);
            this.discount_btn_show.Name = "discount_btn_show";
            this.discount_btn_show.Size = new System.Drawing.Size(100, 23);
            this.discount_btn_show.TabIndex = 27;
            this.discount_btn_show.Text = "Display";
            this.discount_btn_show.UseVisualStyleBackColor = true;
            this.discount_btn_show.Click += new System.EventHandler(this.discount_show_btn_Click);
            // 
            // discount_btn_save
            // 
            this.discount_btn_save.Enabled = false;
            this.discount_btn_save.Location = new System.Drawing.Point(230, 147);
            this.discount_btn_save.Name = "discount_btn_save";
            this.discount_btn_save.Size = new System.Drawing.Size(100, 23);
            this.discount_btn_save.TabIndex = 29;
            this.discount_btn_save.Text = "Save";
            this.discount_btn_save.UseVisualStyleBackColor = true;
            this.discount_btn_save.Click += new System.EventHandler(this.discount_save_btn_Click);
            // 
            // discount_btn_edit
            // 
            this.discount_btn_edit.Enabled = false;
            this.discount_btn_edit.Location = new System.Drawing.Point(230, 118);
            this.discount_btn_edit.Name = "discount_btn_edit";
            this.discount_btn_edit.Size = new System.Drawing.Size(100, 23);
            this.discount_btn_edit.TabIndex = 28;
            this.discount_btn_edit.Text = "Edit";
            this.discount_btn_edit.UseVisualStyleBackColor = true;
            this.discount_btn_edit.Click += new System.EventHandler(this.discount_edit_btn_Click);
            // 
            // ticketTab
            // 
            this.ticketTab.Controls.Add(this.ticket_btn_show);
            this.ticketTab.Controls.Add(this.ticket_btn_save);
            this.ticketTab.Controls.Add(this.ticket_btn_edit);
            this.ticketTab.Controls.Add(this.ticket_discount_lbl);
            this.ticketTab.Controls.Add(this.ticket_reservId_lbl);
            this.ticketTab.Controls.Add(this.ticket_price_lbl);
            this.ticketTab.Controls.Add(this.ticket_id_lbl);
            this.ticketTab.Controls.Add(this.ticket_txt_discount);
            this.ticketTab.Controls.Add(this.ticket_txt_reservId);
            this.ticketTab.Controls.Add(this.ticket_txt_price);
            this.ticketTab.Controls.Add(this.ticket_txt_id);
            this.ticketTab.Location = new System.Drawing.Point(4, 22);
            this.ticketTab.Name = "ticketTab";
            this.ticketTab.Padding = new System.Windows.Forms.Padding(3);
            this.ticketTab.Size = new System.Drawing.Size(642, 434);
            this.ticketTab.TabIndex = 4;
            this.ticketTab.Text = "Ticket";
            this.ticketTab.UseVisualStyleBackColor = true;
            // 
            // ticket_btn_show
            // 
            this.ticket_btn_show.Location = new System.Drawing.Point(224, 149);
            this.ticket_btn_show.Name = "ticket_btn_show";
            this.ticket_btn_show.Size = new System.Drawing.Size(100, 23);
            this.ticket_btn_show.TabIndex = 30;
            this.ticket_btn_show.Text = "Display";
            this.ticket_btn_show.UseVisualStyleBackColor = true;
            this.ticket_btn_show.Click += new System.EventHandler(this.ticket_show_btn_Click);
            // 
            // ticket_btn_save
            // 
            this.ticket_btn_save.Enabled = false;
            this.ticket_btn_save.Location = new System.Drawing.Point(224, 207);
            this.ticket_btn_save.Name = "ticket_btn_save";
            this.ticket_btn_save.Size = new System.Drawing.Size(100, 23);
            this.ticket_btn_save.TabIndex = 32;
            this.ticket_btn_save.Text = "Save";
            this.ticket_btn_save.UseVisualStyleBackColor = true;
            this.ticket_btn_save.Click += new System.EventHandler(this.ticket_save_btn_Click);
            // 
            // ticket_btn_edit
            // 
            this.ticket_btn_edit.Enabled = false;
            this.ticket_btn_edit.Location = new System.Drawing.Point(224, 178);
            this.ticket_btn_edit.Name = "ticket_btn_edit";
            this.ticket_btn_edit.Size = new System.Drawing.Size(100, 23);
            this.ticket_btn_edit.TabIndex = 31;
            this.ticket_btn_edit.Text = "Edit";
            this.ticket_btn_edit.UseVisualStyleBackColor = true;
            this.ticket_btn_edit.Click += new System.EventHandler(this.ticket_edit_btn_Click);
            // 
            // ticket_discount_lbl
            // 
            this.ticket_discount_lbl.AutoSize = true;
            this.ticket_discount_lbl.Location = new System.Drawing.Point(166, 126);
            this.ticket_discount_lbl.Name = "ticket_discount_lbl";
            this.ticket_discount_lbl.Size = new System.Drawing.Size(52, 13);
            this.ticket_discount_lbl.TabIndex = 7;
            this.ticket_discount_lbl.Text = "Discount:";
            // 
            // ticket_reservId_lbl
            // 
            this.ticket_reservId_lbl.AutoSize = true;
            this.ticket_reservId_lbl.Location = new System.Drawing.Point(139, 73);
            this.ticket_reservId_lbl.Name = "ticket_reservId_lbl";
            this.ticket_reservId_lbl.Size = new System.Drawing.Size(79, 13);
            this.ticket_reservId_lbl.TabIndex = 6;
            this.ticket_reservId_lbl.Text = "Reservation Id:";
            // 
            // ticket_price_lbl
            // 
            this.ticket_price_lbl.AutoSize = true;
            this.ticket_price_lbl.Location = new System.Drawing.Point(184, 99);
            this.ticket_price_lbl.Name = "ticket_price_lbl";
            this.ticket_price_lbl.Size = new System.Drawing.Size(34, 13);
            this.ticket_price_lbl.TabIndex = 5;
            this.ticket_price_lbl.Text = "Price:";
            // 
            // ticket_id_lbl
            // 
            this.ticket_id_lbl.AutoSize = true;
            this.ticket_id_lbl.Location = new System.Drawing.Point(166, 48);
            this.ticket_id_lbl.Name = "ticket_id_lbl";
            this.ticket_id_lbl.Size = new System.Drawing.Size(52, 13);
            this.ticket_id_lbl.TabIndex = 4;
            this.ticket_id_lbl.Text = "Ticket Id:";
            // 
            // ticket_txt_discount
            // 
            this.ticket_txt_discount.Enabled = false;
            this.ticket_txt_discount.Location = new System.Drawing.Point(224, 123);
            this.ticket_txt_discount.Name = "ticket_txt_discount";
            this.ticket_txt_discount.Size = new System.Drawing.Size(100, 20);
            this.ticket_txt_discount.TabIndex = 3;
            this.ticket_txt_discount.TextChanged += new System.EventHandler(this.ticket_discount_txt_TextChanged);
            // 
            // ticket_txt_reservId
            // 
            this.ticket_txt_reservId.Location = new System.Drawing.Point(224, 70);
            this.ticket_txt_reservId.Name = "ticket_txt_reservId";
            this.ticket_txt_reservId.Size = new System.Drawing.Size(100, 20);
            this.ticket_txt_reservId.TabIndex = 2;
            this.ticket_txt_reservId.TextChanged += new System.EventHandler(this.ticket_reservId_txt_TextChanged);
            // 
            // ticket_txt_price
            // 
            this.ticket_txt_price.Enabled = false;
            this.ticket_txt_price.Location = new System.Drawing.Point(224, 96);
            this.ticket_txt_price.Name = "ticket_txt_price";
            this.ticket_txt_price.Size = new System.Drawing.Size(100, 20);
            this.ticket_txt_price.TabIndex = 1;
            this.ticket_txt_price.TextChanged += new System.EventHandler(this.ticket_price_txt_TextChanged);
            // 
            // ticket_txt_id
            // 
            this.ticket_txt_id.Location = new System.Drawing.Point(224, 45);
            this.ticket_txt_id.Name = "ticket_txt_id";
            this.ticket_txt_id.Size = new System.Drawing.Size(100, 20);
            this.ticket_txt_id.TabIndex = 0;
            this.ticket_txt_id.TextChanged += new System.EventHandler(this.ticket_id_txt_TextChanged);
            // 
            // movie_txt_duration
            // 
            this.movie_txt_duration.Enabled = false;
            this.movie_txt_duration.Location = new System.Drawing.Point(120, 139);
            this.movie_txt_duration.Name = "movie_txt_duration";
            this.movie_txt_duration.Size = new System.Drawing.Size(313, 20);
            this.movie_txt_duration.TabIndex = 33;
            // 
            // movie_lbl_duration
            // 
            this.movie_lbl_duration.AutoSize = true;
            this.movie_lbl_duration.Location = new System.Drawing.Point(64, 142);
            this.movie_lbl_duration.Name = "movie_lbl_duration";
            this.movie_lbl_duration.Size = new System.Drawing.Size(50, 13);
            this.movie_lbl_duration.TabIndex = 34;
            this.movie_lbl_duration.Text = "Duration:";
            // 
            // reserv_dateTime_picker
            // 
            this.reserv_dateTime_picker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.reserv_dateTime_picker.Enabled = false;
            this.reserv_dateTime_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.reserv_dateTime_picker.Location = new System.Drawing.Point(163, 101);
            this.reserv_dateTime_picker.Name = "reserv_dateTime_picker";
            this.reserv_dateTime_picker.Size = new System.Drawing.Size(256, 20);
            this.reserv_dateTime_picker.TabIndex = 38;
            // 
            // reserv_btn_reset
            // 
            this.reserv_btn_reset.Location = new System.Drawing.Point(252, 182);
            this.reserv_btn_reset.Name = "reserv_btn_reset";
            this.reserv_btn_reset.Size = new System.Drawing.Size(100, 23);
            this.reserv_btn_reset.TabIndex = 39;
            this.reserv_btn_reset.Text = "Reset All";
            this.reserv_btn_reset.UseVisualStyleBackColor = true;
            this.reserv_btn_reset.Click += new System.EventHandler(this.reserv_btn_reset_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 460);
            this.Controls.Add(this.panel1);
            this.Name = "Update";
            this.Text = "Update";
            this.panel1.ResumeLayout(false);
            this.updateTabs.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl updateTabs;
        private System.Windows.Forms.TabPage roomTab;
        private System.Windows.Forms.TabPage movieTab;
        private System.Windows.Forms.TabPage reservationTab;
        private System.Windows.Forms.TabPage discountTab;
        private System.Windows.Forms.TabPage ticketTab;
        private System.Windows.Forms.Button room_btn_show;
        private System.Windows.Forms.TextBox room_txt_seats;
        private System.Windows.Forms.TextBox room_txt_rows;
        private System.Windows.Forms.TextBox room_txt_cols;
        private System.Windows.Forms.TextBox room_txt_roomId;
        private System.Windows.Forms.Button room_btn_save;
        private System.Windows.Forms.Button room_btn_edit;
        private System.Windows.Forms.Label room_seats_lbl;
        private System.Windows.Forms.Label room_rows_lbl;
        private System.Windows.Forms.Label room_cols_lbl;
        private System.Windows.Forms.Label room_roomId_lbl;
        private System.Windows.Forms.Label movie_roomId_lbl;
        private System.Windows.Forms.Label movie_date_lbl;
        private System.Windows.Forms.Label movie_title_lbl;
        private System.Windows.Forms.Label movie_movieId_lbl;
        private System.Windows.Forms.Button movie_btn_save;
        private System.Windows.Forms.Button movie_btn_edit;
        private System.Windows.Forms.DateTimePicker movie_date_picker;
        private System.Windows.Forms.TextBox movie_txt_roomId;
        private System.Windows.Forms.TextBox movie_txt_title;
        private System.Windows.Forms.TextBox movie_txt_movieId;
        private System.Windows.Forms.Label reserv_seatCount_lbl;
        private System.Windows.Forms.Label reserv_lbl_date;
        private System.Windows.Forms.Label reserv_name_lbl;
        private System.Windows.Forms.CheckBox reserv_check_taken;
        private System.Windows.Forms.TextBox reserv_txt_seatCount;
        private System.Windows.Forms.TextBox reserv_txt_name;
        private System.Windows.Forms.Button reserv_btn_show;
        private System.Windows.Forms.Button reserv_btn_save;
        private System.Windows.Forms.Button reserv_btn_edit;
        private System.Windows.Forms.Label discount_percent_lbl;
        private System.Windows.Forms.Label discount_id_lbl;
        private System.Windows.Forms.TextBox discount_txt_percent;
        private System.Windows.Forms.TextBox discount_txt_id;
        private System.Windows.Forms.Button discount_btn_show;
        private System.Windows.Forms.Button discount_btn_save;
        private System.Windows.Forms.Button discount_btn_edit;
        private System.Windows.Forms.Button ticket_btn_show;
        private System.Windows.Forms.Button ticket_btn_save;
        private System.Windows.Forms.Button ticket_btn_edit;
        private System.Windows.Forms.Label ticket_discount_lbl;
        private System.Windows.Forms.Label ticket_reservId_lbl;
        private System.Windows.Forms.Label ticket_price_lbl;
        private System.Windows.Forms.Label ticket_id_lbl;
        private System.Windows.Forms.TextBox ticket_txt_discount;
        private System.Windows.Forms.TextBox ticket_txt_reservId;
        private System.Windows.Forms.TextBox ticket_txt_price;
        private System.Windows.Forms.TextBox ticket_txt_id;
        private System.Windows.Forms.ComboBox movie_combo_movies;
        private System.Windows.Forms.Label movie_lbl_dropdown;
        private System.Windows.Forms.Button movie_btn_find;
        private System.Windows.Forms.Label reserv_reservId_lbl;
        private System.Windows.Forms.TextBox reserv_txt_reservId;
        private System.Windows.Forms.Label reserv_lbl_reservations;
        private System.Windows.Forms.ComboBox reserv_combo_reservations;
        private System.Windows.Forms.Button movie_btn_reset;
        private System.Windows.Forms.Label movie_lbl_duration;
        private System.Windows.Forms.TextBox movie_txt_duration;
        private System.Windows.Forms.DateTimePicker reserv_dateTime_picker;
        private System.Windows.Forms.Button reserv_btn_reset;
    }
}
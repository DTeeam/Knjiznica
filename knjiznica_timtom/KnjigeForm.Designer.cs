
namespace knjiznica_timtom
{
    partial class KnjigeForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.book_listView = new System.Windows.Forms.ListView();
            this.st = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.change_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.insert_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.section_combo = new System.Windows.Forms.ComboBox();
            this.search_text = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.clani_combo = new System.Windows.Forms.ComboBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.stanje_user_tab = new System.Windows.Forms.TabPage();
            this.izposoja_user_tab = new System.Windows.Forms.TabPage();
            this.changedata_user_tab = new System.Windows.Forms.TabPage();
            this.izposoje_listview = new System.Windows.Forms.ListView();
            this.book_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stanje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.return_butt = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.stanje_user_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(19, 17);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1035, 524);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.book_listView);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.change_button);
            this.tabPage1.Controls.Add(this.delete_button);
            this.tabPage1.Controls.Add(this.insert_button);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.section_combo);
            this.tabPage1.Controls.Add(this.search_text);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1027, 495);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Knjige";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(596, 438);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 28);
            this.button2.TabIndex = 11;
            this.button2.Text = "Shrani";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // book_listView
            // 
            this.book_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.st,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.book_listView.FullRowSelect = true;
            this.book_listView.HideSelection = false;
            this.book_listView.LabelEdit = true;
            this.book_listView.Location = new System.Drawing.Point(32, 160);
            this.book_listView.Margin = new System.Windows.Forms.Padding(4);
            this.book_listView.MultiSelect = false;
            this.book_listView.Name = "book_listView";
            this.book_listView.Size = new System.Drawing.Size(555, 306);
            this.book_listView.TabIndex = 10;
            this.book_listView.TileSize = new System.Drawing.Size(10, 10);
            this.book_listView.UseCompatibleStateImageBehavior = false;
            this.book_listView.View = System.Windows.Forms.View.Details;
            this.book_listView.SelectedIndexChanged += new System.EventHandler(this.book_listView_SelectedIndexChanged);
            // 
            // st
            // 
            this.st.Text = "Inventarna št.:";
            this.st.Width = 84;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Naslov:";
            this.columnHeader1.Width = 131;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Avtor:";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Na voljo:";
            this.columnHeader3.Width = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Iskalno polje:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kategorije:";
            // 
            // change_button
            // 
            this.change_button.Location = new System.Drawing.Point(596, 399);
            this.change_button.Margin = new System.Windows.Forms.Padding(4);
            this.change_button.Name = "change_button";
            this.change_button.Size = new System.Drawing.Size(141, 28);
            this.change_button.TabIndex = 6;
            this.change_button.Text = "Uredi";
            this.change_button.UseVisualStyleBackColor = true;
            this.change_button.Click += new System.EventHandler(this.change_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(881, 453);
            this.delete_button.Margin = new System.Windows.Forms.Padding(4);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(100, 28);
            this.delete_button.TabIndex = 5;
            this.delete_button.Text = "Zbriši";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // insert_button
            // 
            this.insert_button.Location = new System.Drawing.Point(860, 160);
            this.insert_button.Margin = new System.Windows.Forms.Padding(4);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(141, 28);
            this.insert_button.TabIndex = 4;
            this.insert_button.Text = "Vnesi knjigo";
            this.insert_button.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(629, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Išči";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // section_combo
            // 
            this.section_combo.FormattingEnabled = true;
            this.section_combo.Location = new System.Drawing.Point(32, 89);
            this.section_combo.Margin = new System.Windows.Forms.Padding(4);
            this.section_combo.Name = "section_combo";
            this.section_combo.Size = new System.Drawing.Size(160, 24);
            this.section_combo.TabIndex = 2;
            // 
            // search_text
            // 
            this.search_text.Location = new System.Drawing.Point(32, 26);
            this.search_text.Margin = new System.Windows.Forms.Padding(4);
            this.search_text.Name = "search_text";
            this.search_text.Size = new System.Drawing.Size(520, 22);
            this.search_text.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.clani_combo);
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1027, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Uporabniki";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Izberite člana";
            // 
            // clani_combo
            // 
            this.clani_combo.FormattingEnabled = true;
            this.clani_combo.Location = new System.Drawing.Point(106, 24);
            this.clani_combo.Name = "clani_combo";
            this.clani_combo.Size = new System.Drawing.Size(121, 24);
            this.clani_combo.TabIndex = 1;
            this.clani_combo.SelectedIndexChanged += new System.EventHandler(this.clani_combo_SelectedIndexChanged);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.stanje_user_tab);
            this.tabControl2.Controls.Add(this.izposoja_user_tab);
            this.tabControl2.Controls.Add(this.changedata_user_tab);
            this.tabControl2.Enabled = false;
            this.tabControl2.Location = new System.Drawing.Point(3, 68);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1017, 420);
            this.tabControl2.TabIndex = 0;
            // 
            // stanje_user_tab
            // 
            this.stanje_user_tab.Controls.Add(this.return_butt);
            this.stanje_user_tab.Controls.Add(this.izposoje_listview);
            this.stanje_user_tab.Location = new System.Drawing.Point(4, 25);
            this.stanje_user_tab.Name = "stanje_user_tab";
            this.stanje_user_tab.Padding = new System.Windows.Forms.Padding(3);
            this.stanje_user_tab.Size = new System.Drawing.Size(1009, 391);
            this.stanje_user_tab.TabIndex = 0;
            this.stanje_user_tab.Text = "Stanje";
            this.stanje_user_tab.UseVisualStyleBackColor = true;
            // 
            // izposoja_user_tab
            // 
            this.izposoja_user_tab.Location = new System.Drawing.Point(4, 25);
            this.izposoja_user_tab.Name = "izposoja_user_tab";
            this.izposoja_user_tab.Padding = new System.Windows.Forms.Padding(3);
            this.izposoja_user_tab.Size = new System.Drawing.Size(1009, 391);
            this.izposoja_user_tab.TabIndex = 1;
            this.izposoja_user_tab.Text = "Izposodi";
            this.izposoja_user_tab.UseVisualStyleBackColor = true;
            // 
            // changedata_user_tab
            // 
            this.changedata_user_tab.Location = new System.Drawing.Point(4, 25);
            this.changedata_user_tab.Name = "changedata_user_tab";
            this.changedata_user_tab.Padding = new System.Windows.Forms.Padding(3);
            this.changedata_user_tab.Size = new System.Drawing.Size(1009, 391);
            this.changedata_user_tab.TabIndex = 2;
            this.changedata_user_tab.Text = "Spremeni podatke";
            this.changedata_user_tab.UseVisualStyleBackColor = true;
            // 
            // izposoje_listview
            // 
            this.izposoje_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.book_title,
            this.stanje,
            this.date});
            this.izposoje_listview.FullRowSelect = true;
            this.izposoje_listview.HideSelection = false;
            this.izposoje_listview.Location = new System.Drawing.Point(19, 68);
            this.izposoje_listview.MultiSelect = false;
            this.izposoje_listview.Name = "izposoje_listview";
            this.izposoje_listview.Size = new System.Drawing.Size(324, 286);
            this.izposoje_listview.TabIndex = 0;
            this.izposoje_listview.UseCompatibleStateImageBehavior = false;
            this.izposoje_listview.View = System.Windows.Forms.View.Details;
            this.izposoje_listview.SelectedIndexChanged += new System.EventHandler(this.izposoje_listview_SelectedIndexChanged);
            // 
            // book_title
            // 
            this.book_title.Text = "Inventarna št.";
            this.book_title.Width = 90;
            // 
            // stanje
            // 
            this.stanje.Text = "Stanje";
            // 
            // date
            // 
            this.date.Text = "Datum izposoje";
            this.date.Width = 90;
            // 
            // return_butt
            // 
            this.return_butt.Enabled = false;
            this.return_butt.Location = new System.Drawing.Point(367, 68);
            this.return_butt.Name = "return_butt";
            this.return_butt.Size = new System.Drawing.Size(63, 33);
            this.return_butt.TabIndex = 1;
            this.return_butt.Text = "Vrni";
            this.return_butt.UseVisualStyleBackColor = true;
            this.return_butt.Click += new System.EventHandler(this.return_butt_Click);
            // 
            // KnjigeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KnjigeForm";
            this.Text = "KnjigeForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.stanje_user_tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button change_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox section_combo;
        private System.Windows.Forms.TextBox search_text;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView book_listView;
        private System.Windows.Forms.ColumnHeader st;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox clani_combo;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage stanje_user_tab;
        private System.Windows.Forms.TabPage izposoja_user_tab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage changedata_user_tab;
        private System.Windows.Forms.ListView izposoje_listview;
        private System.Windows.Forms.ColumnHeader book_title;
        private System.Windows.Forms.ColumnHeader stanje;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.Button return_butt;
    }
}
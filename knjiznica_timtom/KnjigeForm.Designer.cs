﻿
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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Knjige";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(447, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
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
            this.book_listView.Location = new System.Drawing.Point(24, 130);
            this.book_listView.MultiSelect = false;
            this.book_listView.Name = "book_listView";
            this.book_listView.Size = new System.Drawing.Size(417, 249);
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
            this.label2.Location = new System.Drawing.Point(21, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Iskalno polje:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kategorije:";
            // 
            // change_button
            // 
            this.change_button.Location = new System.Drawing.Point(447, 324);
            this.change_button.Name = "change_button";
            this.change_button.Size = new System.Drawing.Size(106, 23);
            this.change_button.TabIndex = 6;
            this.change_button.Text = "Uredi";
            this.change_button.UseVisualStyleBackColor = true;
            this.change_button.Click += new System.EventHandler(this.change_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(661, 368);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 23);
            this.delete_button.TabIndex = 5;
            this.delete_button.Text = "Zbriši";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // insert_button
            // 
            this.insert_button.Location = new System.Drawing.Point(645, 130);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(106, 23);
            this.insert_button.TabIndex = 4;
            this.insert_button.Text = "Vnesi knjigo";
            this.insert_button.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Išči";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // section_combo
            // 
            this.section_combo.FormattingEnabled = true;
            this.section_combo.Location = new System.Drawing.Point(24, 72);
            this.section_combo.Name = "section_combo";
            this.section_combo.Size = new System.Drawing.Size(121, 21);
            this.section_combo.TabIndex = 2;
            // 
            // search_text
            // 
            this.search_text.Location = new System.Drawing.Point(24, 21);
            this.search_text.Name = "search_text";
            this.search_text.Size = new System.Drawing.Size(391, 20);
            this.search_text.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Uporabniki";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // KnjigeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "KnjigeForm";
            this.Text = "KnjigeForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
    }
}
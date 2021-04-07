
namespace knjiznica_timtom
{
    partial class DodajKnjigo
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
            this.add_book_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.title_textBox = new System.Windows.Forms.TextBox();
            this.author_textBox = new System.Windows.Forms.TextBox();
            this.publisher_textBox = new System.Windows.Forms.TextBox();
            this.udk_combo = new System.Windows.Forms.ComboBox();
            this.year_numUpDown = new System.Windows.Forms.NumericUpDown();
            this.shop_checkedList = new System.Windows.Forms.CheckedListBox();
            this.lost_checkedList = new System.Windows.Forms.CheckedListBox();
            this.notes_RtextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.year_numUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // add_book_button
            // 
            this.add_book_button.Location = new System.Drawing.Point(485, 409);
            this.add_book_button.Name = "add_book_button";
            this.add_book_button.Size = new System.Drawing.Size(75, 23);
            this.add_book_button.TabIndex = 0;
            this.add_book_button.Text = "Dodaj knjigo";
            this.add_book_button.UseVisualStyleBackColor = true;
            this.add_book_button.Click += new System.EventHandler(this.add_book_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naslov:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Avtor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "UDK:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Leto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Založba:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Pridobitev:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Izgubljena:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Zapiski:";
            // 
            // title_textBox
            // 
            this.title_textBox.Location = new System.Drawing.Point(65, 12);
            this.title_textBox.Name = "title_textBox";
            this.title_textBox.Size = new System.Drawing.Size(121, 20);
            this.title_textBox.TabIndex = 10;
            // 
            // author_textBox
            // 
            this.author_textBox.Location = new System.Drawing.Point(65, 38);
            this.author_textBox.Name = "author_textBox";
            this.author_textBox.Size = new System.Drawing.Size(121, 20);
            this.author_textBox.TabIndex = 11;
            // 
            // publisher_textBox
            // 
            this.publisher_textBox.Location = new System.Drawing.Point(65, 114);
            this.publisher_textBox.Name = "publisher_textBox";
            this.publisher_textBox.Size = new System.Drawing.Size(121, 20);
            this.publisher_textBox.TabIndex = 14;
            // 
            // udk_combo
            // 
            this.udk_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.udk_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.udk_combo.FormattingEnabled = true;
            this.udk_combo.Location = new System.Drawing.Point(65, 64);
            this.udk_combo.Name = "udk_combo";
            this.udk_combo.Size = new System.Drawing.Size(121, 21);
            this.udk_combo.TabIndex = 15;
            // 
            // year_numUpDown
            // 
            this.year_numUpDown.Location = new System.Drawing.Point(125, 90);
            this.year_numUpDown.Maximum = new decimal(new int[] {
            2040,
            0,
            0,
            0});
            this.year_numUpDown.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.year_numUpDown.Name = "year_numUpDown";
            this.year_numUpDown.Size = new System.Drawing.Size(61, 20);
            this.year_numUpDown.TabIndex = 16;
            this.year_numUpDown.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // shop_checkedList
            // 
            this.shop_checkedList.CheckOnClick = true;
            this.shop_checkedList.FormattingEnabled = true;
            this.shop_checkedList.Items.AddRange(new object[] {
            "Nakup",
            "Darilo",
            "Ostalo"});
            this.shop_checkedList.Location = new System.Drawing.Point(67, 140);
            this.shop_checkedList.Name = "shop_checkedList";
            this.shop_checkedList.Size = new System.Drawing.Size(120, 49);
            this.shop_checkedList.TabIndex = 17;
            this.shop_checkedList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.shop_checkedList_ItemCheck);
            // 
            // lost_checkedList
            // 
            this.lost_checkedList.CheckOnClick = true;
            this.lost_checkedList.FormattingEnabled = true;
            this.lost_checkedList.Items.AddRange(new object[] {
            "Ne",
            "Da"});
            this.lost_checkedList.Location = new System.Drawing.Point(65, 195);
            this.lost_checkedList.Name = "lost_checkedList";
            this.lost_checkedList.Size = new System.Drawing.Size(120, 49);
            this.lost_checkedList.TabIndex = 18;
            this.lost_checkedList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lost_checkedList_ItemCheck);
            // 
            // notes_RtextBox
            // 
            this.notes_RtextBox.Location = new System.Drawing.Point(65, 250);
            this.notes_RtextBox.Name = "notes_RtextBox";
            this.notes_RtextBox.Size = new System.Drawing.Size(120, 96);
            this.notes_RtextBox.TabIndex = 19;
            this.notes_RtextBox.Text = "";
            // 
            // DodajKnjigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 444);
            this.Controls.Add(this.notes_RtextBox);
            this.Controls.Add(this.lost_checkedList);
            this.Controls.Add(this.shop_checkedList);
            this.Controls.Add(this.year_numUpDown);
            this.Controls.Add(this.udk_combo);
            this.Controls.Add(this.publisher_textBox);
            this.Controls.Add(this.author_textBox);
            this.Controls.Add(this.title_textBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.add_book_button);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DodajKnjigo";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.year_numUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_book_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox title_textBox;
        private System.Windows.Forms.TextBox author_textBox;
        private System.Windows.Forms.TextBox publisher_textBox;
        private System.Windows.Forms.ComboBox udk_combo;
        private System.Windows.Forms.NumericUpDown year_numUpDown;
        private System.Windows.Forms.CheckedListBox shop_checkedList;
        private System.Windows.Forms.CheckedListBox lost_checkedList;
        private System.Windows.Forms.RichTextBox notes_RtextBox;
    }
}
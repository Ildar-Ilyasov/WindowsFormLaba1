namespace WindowsFormLaba1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(169, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Абоненты ТНС";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "Логотип ТНС";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button2.Location = new System.Drawing.Point(12, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Абоненты";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.button3.Location = new System.Drawing.Point(13, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 39);
            this.button3.TabIndex = 4;
            this.button3.Text = "Управление оборудованием";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button4.Location = new System.Drawing.Point(13, 169);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 36);
            this.button4.TabIndex = 5;
            this.button4.Text = "Активы";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button5.Location = new System.Drawing.Point(13, 211);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 37);
            this.button5.TabIndex = 6;
            this.button5.Text = "Биллинг";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button6.Location = new System.Drawing.Point(13, 255);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 36);
            this.button6.TabIndex = 7;
            this.button6.Text = "Поддержка пользователей";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button7.Location = new System.Drawing.Point(12, 297);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(93, 36);
            this.button7.TabIndex = 8;
            this.button7.Text = "CRM";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(37, 446);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(45, 45);
            this.button8.TabIndex = 9;
            this.button8.Text = "проф.";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button9.Location = new System.Drawing.Point(37, 497);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(45, 45);
            this.button9.TabIndex = 10;
            this.button9.Text = "?";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(-5, -18);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.label2.Size = new System.Drawing.Size(122, 606);
            this.label2.TabIndex = 11;
            this.label2.Text = " ";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(598, 204);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 302);
            this.vScrollBar1.TabIndex = 14;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(174, 511);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(443, 17);
            this.hScrollBar1.TabIndex = 16;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(174, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 339);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ФИО";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Абоненский номер";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Лицевой счет";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Услуги";
            this.Column4.Name = "Column4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(206, 544);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Активные";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(485, 546);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Неактивные";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button10.Location = new System.Drawing.Point(175, 540);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(25, 25);
            this.button10.TabIndex = 18;
            this.button10.Text = " ";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button11.Location = new System.Drawing.Point(454, 540);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(25, 25);
            this.button11.TabIndex = 19;
            this.button11.Text = " ";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button13.Location = new System.Drawing.Point(733, 34);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(50, 50);
            this.button13.TabIndex = 23;
            this.button13.Text = "Фото";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.domainUpDown1.Location = new System.Drawing.Point(571, 51);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(145, 20);
            this.domainUpDown1.TabIndex = 25;
            this.domainUpDown1.Text = "ФИО_пользователя";
            this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(646, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 430);
            this.label5.TabIndex = 26;
            this.label5.Text = "    ";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(646, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "_____________________________________________________________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(707, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "События";
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button12.Location = new System.Drawing.Point(649, 170);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(185, 35);
            this.button12.TabIndex = 29;
            this.button12.Text = "^";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button14.Location = new System.Drawing.Point(649, 524);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(185, 35);
            this.button14.TabIndex = 30;
            this.button14.Text = "˅";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button15.Location = new System.Drawing.Point(649, 207);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(185, 70);
            this.button15.TabIndex = 31;
            this.button15.Text = "Собрание менеджеров 10:00";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button16.Location = new System.Drawing.Point(649, 279);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(185, 70);
            this.button16.TabIndex = 32;
            this.button16.Text = "Отчет по инвертации";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button17.Location = new System.Drawing.Point(649, 351);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(185, 70);
            this.button17.TabIndex = 33;
            this.button17.Text = "Собрание акционеров 12:00";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button18.Location = new System.Drawing.Point(649, 423);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(185, 70);
            this.button18.TabIndex = 34;
            this.button18.Text = "Отчет по Адмиралтейскому району";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button19.Location = new System.Drawing.Point(649, 495);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(185, 27);
            this.button19.TabIndex = 35;
            this.button19.Text = "  ";
            this.button19.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 570);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
    }
}


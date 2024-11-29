namespace PhoneNote
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.clear = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.poisk_box = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.refresh = new System.Windows.Forms.Button();
            this.deleteAbonent = new System.Windows.Forms.Button();
            this.addAbonent = new System.Windows.Forms.Button();
            this.makeAbonent = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСведенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_naming = new System.Windows.Forms.TextBox();
            this.textBox_patronym = new System.Windows.Forms.TextBox();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.clear);
            this.panel1.Controls.Add(this.btn_Update);
            this.panel1.Controls.Add(this.poisk_box);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.refresh);
            this.panel1.Controls.Add(this.deleteAbonent);
            this.panel1.Controls.Add(this.addAbonent);
            this.panel1.Controls.Add(this.makeAbonent);
            this.panel1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(542, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 549);
            this.panel1.TabIndex = 1;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.White;
            this.clear.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(27, 416);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(141, 51);
            this.clear.TabIndex = 7;
            this.clear.Text = "Очистка";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.White;
            this.btn_Update.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(31, 267);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(140, 51);
            this.btn_Update.TabIndex = 6;
            this.btn_Update.Text = "Сохранить";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // poisk_box
            // 
            this.poisk_box.Location = new System.Drawing.Point(70, 366);
            this.poisk_box.Name = "poisk_box";
            this.poisk_box.Size = new System.Drawing.Size(100, 24);
            this.poisk_box.TabIndex = 5;
            this.poisk_box.TextChanged += new System.EventHandler(this.poisk_box_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PhoneNote.Properties.Resources._751463;
            this.pictureBox1.Location = new System.Drawing.Point(21, 349);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.White;
            this.refresh.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.Location = new System.Drawing.Point(31, 29);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(141, 51);
            this.refresh.TabIndex = 3;
            this.refresh.Text = "Обновить таблицу";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // deleteAbonent
            // 
            this.deleteAbonent.BackColor = System.Drawing.Color.White;
            this.deleteAbonent.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAbonent.Location = new System.Drawing.Point(31, 200);
            this.deleteAbonent.Name = "deleteAbonent";
            this.deleteAbonent.Size = new System.Drawing.Size(140, 51);
            this.deleteAbonent.TabIndex = 2;
            this.deleteAbonent.Text = "Удалить сведения об абоненте";
            this.deleteAbonent.UseVisualStyleBackColor = false;
            this.deleteAbonent.Click += new System.EventHandler(this.deleteAbonent_Click);
            // 
            // addAbonent
            // 
            this.addAbonent.BackColor = System.Drawing.Color.White;
            this.addAbonent.Cursor = System.Windows.Forms.Cursors.Default;
            this.addAbonent.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAbonent.Location = new System.Drawing.Point(31, 86);
            this.addAbonent.Name = "addAbonent";
            this.addAbonent.Size = new System.Drawing.Size(140, 51);
            this.addAbonent.TabIndex = 0;
            this.addAbonent.Text = "Добавить сведения об абоненте";
            this.addAbonent.UseVisualStyleBackColor = false;
            this.addAbonent.Click += new System.EventHandler(this.addAbonent_Click);
            // 
            // makeAbonent
            // 
            this.makeAbonent.BackColor = System.Drawing.Color.White;
            this.makeAbonent.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeAbonent.Location = new System.Drawing.Point(31, 143);
            this.makeAbonent.Name = "makeAbonent";
            this.makeAbonent.Size = new System.Drawing.Size(139, 51);
            this.makeAbonent.TabIndex = 1;
            this.makeAbonent.Text = "Изменить сведения об абоненте";
            this.makeAbonent.UseVisualStyleBackColor = false;
            this.makeAbonent.Click += new System.EventHandler(this.makeAbonent_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 370);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операцииToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(724, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСведенияToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // добавитьСведенияToolStripMenuItem
            // 
            this.добавитьСведенияToolStripMenuItem.Name = "добавитьСведенияToolStripMenuItem";
            this.добавитьСведенияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьСведенияToolStripMenuItem.Text = "Добавить сведения";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(27, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Изменить  сведения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.label2.Location = new System.Drawing.Point(284, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Фамилия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.label3.Location = new System.Drawing.Point(284, 548);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Телефон:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.label4.Location = new System.Drawing.Point(284, 514);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Отчество:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.label5.Location = new System.Drawing.Point(284, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Имя:";
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(402, 452);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(130, 20);
            this.textBox_surname.TabIndex = 10;
            // 
            // textBox_naming
            // 
            this.textBox_naming.Location = new System.Drawing.Point(402, 485);
            this.textBox_naming.Name = "textBox_naming";
            this.textBox_naming.Size = new System.Drawing.Size(130, 20);
            this.textBox_naming.TabIndex = 11;
            // 
            // textBox_patronym
            // 
            this.textBox_patronym.Location = new System.Drawing.Point(402, 516);
            this.textBox_patronym.Name = "textBox_patronym";
            this.textBox_patronym.Size = new System.Drawing.Size(130, 20);
            this.textBox_patronym.TabIndex = 12;
            // 
            // textBox_number
            // 
            this.textBox_number.Location = new System.Drawing.Point(402, 550);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(130, 20);
            this.textBox_number.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.label6.Location = new System.Drawing.Point(284, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID:";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(402, 424);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(130, 20);
            this.textBox_id.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PhoneNote.Properties.Resources.free_icon_phone_call_3222644;
            this.pictureBox2.Location = new System.Drawing.Point(32, 464);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(184, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(724, 580);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_number);
            this.Controls.Add(this.textBox_patronym);
            this.Controls.Add(this.textBox_naming);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Телефонный справочник";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button deleteAbonent;
        private System.Windows.Forms.Button makeAbonent;
        private System.Windows.Forms.Button addAbonent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСведенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TextBox poisk_box;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.TextBox textBox_naming;
        private System.Windows.Forms.TextBox textBox_patronym;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button clear;
    }
}



namespace HotelApp
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
            this.components = new System.ComponentModel.Container();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.numberroomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDreservationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnamepeopleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datearrivalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonepeopleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childrenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datedepartureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDDataSet = new HotelApp.BDDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.databirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDWorkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerTableAdapter = new HotelApp.BDDataSetTableAdapters.WorkerTableAdapter();
            this.reservationTableAdapter = new HotelApp.BDDataSetTableAdapters.ReservationTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(623, 397);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 28);
            this.button4.TabIndex = 19;
            this.button4.Text = "Редакт. бронь";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(623, 337);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(129, 28);
            this.button5.TabIndex = 18;
            this.button5.Text = "Удалить бронь";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(623, 275);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(129, 28);
            this.button6.TabIndex = 17;
            this.button6.Text = "Добавить бронь";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(623, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 28);
            this.button3.TabIndex = 16;
            this.button3.Text = "Редакт. сотрудника";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(623, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 28);
            this.button2.TabIndex = 15;
            this.button2.Text = "Удалить сотрудника";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(623, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "Добавить сотрудника";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(60, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Бронирование";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(60, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Персонал";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberroomDataGridViewTextBoxColumn,
            this.iDreservationDataGridViewTextBoxColumn,
            this.fullnamepeopleDataGridViewTextBoxColumn,
            this.datearrivalDataGridViewTextBoxColumn,
            this.phonepeopleDataGridViewTextBoxColumn,
            this.childrenDataGridViewTextBoxColumn,
            this.bageDataGridViewTextBoxColumn,
            this.datedepartureDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.reservationBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(49, 275);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(499, 150);
            this.dataGridView2.TabIndex = 11;
            // 
            // numberroomDataGridViewTextBoxColumn
            // 
            this.numberroomDataGridViewTextBoxColumn.DataPropertyName = "Number_room";
            this.numberroomDataGridViewTextBoxColumn.HeaderText = "Номер комнаты";
            this.numberroomDataGridViewTextBoxColumn.Name = "numberroomDataGridViewTextBoxColumn";
            // 
            // iDreservationDataGridViewTextBoxColumn
            // 
            this.iDreservationDataGridViewTextBoxColumn.DataPropertyName = "ID_reservation";
            this.iDreservationDataGridViewTextBoxColumn.HeaderText = "Номер брони";
            this.iDreservationDataGridViewTextBoxColumn.Name = "iDreservationDataGridViewTextBoxColumn";
            // 
            // fullnamepeopleDataGridViewTextBoxColumn
            // 
            this.fullnamepeopleDataGridViewTextBoxColumn.DataPropertyName = "Fullname_people";
            this.fullnamepeopleDataGridViewTextBoxColumn.HeaderText = "Имя клиента";
            this.fullnamepeopleDataGridViewTextBoxColumn.Name = "fullnamepeopleDataGridViewTextBoxColumn";
            // 
            // datearrivalDataGridViewTextBoxColumn
            // 
            this.datearrivalDataGridViewTextBoxColumn.DataPropertyName = "Date_arrival";
            this.datearrivalDataGridViewTextBoxColumn.HeaderText = "Дата приезда";
            this.datearrivalDataGridViewTextBoxColumn.Name = "datearrivalDataGridViewTextBoxColumn";
            // 
            // phonepeopleDataGridViewTextBoxColumn
            // 
            this.phonepeopleDataGridViewTextBoxColumn.DataPropertyName = "Phone_people";
            this.phonepeopleDataGridViewTextBoxColumn.HeaderText = "Дата отъезда";
            this.phonepeopleDataGridViewTextBoxColumn.Name = "phonepeopleDataGridViewTextBoxColumn";
            // 
            // childrenDataGridViewTextBoxColumn
            // 
            this.childrenDataGridViewTextBoxColumn.DataPropertyName = "Children";
            this.childrenDataGridViewTextBoxColumn.HeaderText = "Дети";
            this.childrenDataGridViewTextBoxColumn.Name = "childrenDataGridViewTextBoxColumn";
            // 
            // bageDataGridViewTextBoxColumn
            // 
            this.bageDataGridViewTextBoxColumn.DataPropertyName = "Bage";
            this.bageDataGridViewTextBoxColumn.HeaderText = "Багаж";
            this.bageDataGridViewTextBoxColumn.Name = "bageDataGridViewTextBoxColumn";
            // 
            // datedepartureDataGridViewTextBoxColumn
            // 
            this.datedepartureDataGridViewTextBoxColumn.DataPropertyName = "Date_departure";
            this.datedepartureDataGridViewTextBoxColumn.HeaderText = "Дата отъезда";
            this.datedepartureDataGridViewTextBoxColumn.Name = "datedepartureDataGridViewTextBoxColumn";
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataMember = "Reservation";
            this.reservationBindingSource.DataSource = this.bDDataSet;
            // 
            // bDDataSet
            // 
            this.bDDataSet.DataSetName = "BDDataSet";
            this.bDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.databirthDataGridViewTextBoxColumn,
            this.iDWorkerDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.passportDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.iNNDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(49, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(499, 150);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // databirthDataGridViewTextBoxColumn
            // 
            this.databirthDataGridViewTextBoxColumn.DataPropertyName = "Data_birth";
            this.databirthDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.databirthDataGridViewTextBoxColumn.Name = "databirthDataGridViewTextBoxColumn";
            // 
            // iDWorkerDataGridViewTextBoxColumn
            // 
            this.iDWorkerDataGridViewTextBoxColumn.DataPropertyName = "ID_Worker";
            this.iDWorkerDataGridViewTextBoxColumn.HeaderText = "Код работника";
            this.iDWorkerDataGridViewTextBoxColumn.Name = "iDWorkerDataGridViewTextBoxColumn";
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "Fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Полное имя";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // passportDataGridViewTextBoxColumn
            // 
            this.passportDataGridViewTextBoxColumn.DataPropertyName = "Passport";
            this.passportDataGridViewTextBoxColumn.HeaderText = "Паспорт";
            this.passportDataGridViewTextBoxColumn.Name = "passportDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // iNNDataGridViewTextBoxColumn
            // 
            this.iNNDataGridViewTextBoxColumn.DataPropertyName = "INN";
            this.iNNDataGridViewTextBoxColumn.HeaderText = "ИНН";
            this.iNNDataGridViewTextBoxColumn.Name = "iNNDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataMember = "Worker";
            this.workerBindingSource.DataSource = this.bDDataSet;
            // 
            // workerTableAdapter
            // 
            this.workerTableAdapter.ClearBeforeFill = true;
            // 
            // reservationTableAdapter
            // 
            this.reservationTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(341, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 20);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Поиск работников:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(366, 237);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 20);
            this.textBox2.TabIndex = 23;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Поиск бронирования:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информационная система гостинницы";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BDDataSet bDDataSet;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private BDDataSetTableAdapters.WorkerTableAdapter workerTableAdapter;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private BDDataSetTableAdapters.ReservationTableAdapter reservationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn databirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDWorkerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberroomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDreservationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnamepeopleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datearrivalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonepeopleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn childrenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datedepartureDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
    }
}


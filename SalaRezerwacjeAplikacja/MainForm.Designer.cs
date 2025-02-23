namespace SalaRezerwacjeAplikacja
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewRooms = new DataGridView();
            dataGridViewReservations = new DataGridView();
            textBoxNazwaSali = new TextBox();
            numericUpDownPojemnosc = new NumericUpDown();
            comboBoxSale = new ComboBox();
            dateTimePickerOd = new DateTimePicker();
            dateTimePickerDo = new DateTimePicker();
            textBoxRezerwujacy = new TextBox();
            buttonDodajSale = new Button();
            buttonUsunSale = new Button();
            buttonDodajRezerwacje = new Button();
            buttonUsunRezerwacje = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPojemnosc).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRooms
            // 
            dataGridViewRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRooms.Location = new Point(23, 12);
            dataGridViewRooms.Name = "dataGridViewRooms";
            dataGridViewRooms.Size = new Size(311, 143);
            dataGridViewRooms.TabIndex = 0;
            // 
            // dataGridViewReservations
            // 
            dataGridViewReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReservations.Location = new Point(464, 12);
            dataGridViewReservations.Name = "dataGridViewReservations";
            dataGridViewReservations.Size = new Size(324, 143);
            dataGridViewReservations.TabIndex = 1;
            // 
            // textBoxNazwaSali
            // 
            textBoxNazwaSali.Location = new Point(83, 238);
            textBoxNazwaSali.Name = "textBoxNazwaSali";
            textBoxNazwaSali.Size = new Size(100, 23);
            textBoxNazwaSali.TabIndex = 2;
            // 
            // numericUpDownPojemnosc
            // 
            numericUpDownPojemnosc.Location = new Point(83, 323);
            numericUpDownPojemnosc.Name = "numericUpDownPojemnosc";
            numericUpDownPojemnosc.Size = new Size(120, 23);
            numericUpDownPojemnosc.TabIndex = 3;
            // 
            // comboBoxSale
            // 
            comboBoxSale.FormattingEnabled = true;
            comboBoxSale.Location = new Point(83, 277);
            comboBoxSale.Name = "comboBoxSale";
            comboBoxSale.Size = new Size(121, 23);
            comboBoxSale.TabIndex = 4;
            // 
            // dateTimePickerOd
            // 
            dateTimePickerOd.Location = new Point(540, 317);
            dateTimePickerOd.Name = "dateTimePickerOd";
            dateTimePickerOd.Size = new Size(200, 23);
            dateTimePickerOd.TabIndex = 5;
            // 
            // dateTimePickerDo
            // 
            dateTimePickerDo.Location = new Point(540, 375);
            dateTimePickerDo.Name = "dateTimePickerDo";
            dateTimePickerDo.Size = new Size(200, 23);
            dateTimePickerDo.TabIndex = 6;
            // 
            // textBoxRezerwujacy
            // 
            textBoxRezerwujacy.Location = new Point(583, 243);
            textBoxRezerwujacy.Name = "textBoxRezerwujacy";
            textBoxRezerwujacy.Size = new Size(165, 23);
            textBoxRezerwujacy.TabIndex = 7;
            // 
            // buttonDodajSale
            // 
            buttonDodajSale.Location = new Point(6, 180);
            buttonDodajSale.Name = "buttonDodajSale";
            buttonDodajSale.Size = new Size(151, 23);
            buttonDodajSale.TabIndex = 8;
            buttonDodajSale.Text = " Dodaj salę";
            buttonDodajSale.UseVisualStyleBackColor = true;
            buttonDodajSale.Click += buttonDodajSale_Click;
            // 
            // buttonUsunSale
            // 
            buttonUsunSale.Location = new Point(180, 180);
            buttonUsunSale.Name = "buttonUsunSale";
            buttonUsunSale.Size = new Size(145, 23);
            buttonUsunSale.TabIndex = 9;
            buttonUsunSale.Text = " Usuń salę";
            buttonUsunSale.UseVisualStyleBackColor = true;
            buttonUsunSale.Click += buttonUsunSale_Click;
            // 
            // buttonDodajRezerwacje
            // 
            buttonDodajRezerwacje.Location = new Point(502, 180);
            buttonDodajRezerwacje.Name = "buttonDodajRezerwacje";
            buttonDodajRezerwacje.Size = new Size(145, 23);
            buttonDodajRezerwacje.TabIndex = 10;
            buttonDodajRezerwacje.Text = "Dodaj rezerwację";
            buttonDodajRezerwacje.UseVisualStyleBackColor = true;
            buttonDodajRezerwacje.Click += buttonDodajRezerwacje_Click;
            // 
            // buttonUsunRezerwacje
            // 
            buttonUsunRezerwacje.Location = new Point(653, 180);
            buttonUsunRezerwacje.Name = "buttonUsunRezerwacje";
            buttonUsunRezerwacje.Size = new Size(135, 23);
            buttonUsunRezerwacje.TabIndex = 11;
            buttonUsunRezerwacje.Text = " Usuń rezerwację";
            buttonUsunRezerwacje.UseVisualStyleBackColor = true;
            buttonUsunRezerwacje.Click += buttonUsunRezerwacje_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 241);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 12;
            label1.Text = "Nazwa sali : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 280);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 13;
            label2.Text = "Sale :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(476, 246);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 14;
            label3.Text = "Rezerwujący :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 325);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 15;
            label4.Text = "Ilość osób : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(425, 323);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 16;
            label5.Text = "Rezerwacja Od : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(425, 381);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 17;
            label6.Text = "Rezerwacja Do : ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 451);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonUsunRezerwacje);
            Controls.Add(buttonDodajRezerwacje);
            Controls.Add(buttonUsunSale);
            Controls.Add(buttonDodajSale);
            Controls.Add(textBoxRezerwujacy);
            Controls.Add(dateTimePickerDo);
            Controls.Add(dateTimePickerOd);
            Controls.Add(comboBoxSale);
            Controls.Add(numericUpDownPojemnosc);
            Controls.Add(textBoxNazwaSali);
            Controls.Add(dataGridViewReservations);
            Controls.Add(dataGridViewRooms);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservations).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPojemnosc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewRooms;
        private DataGridView dataGridViewReservations;
        private TextBox textBoxNazwaSali;
        private NumericUpDown numericUpDownPojemnosc;
        private ComboBox comboBoxSale;
        private DateTimePicker dateTimePickerOd;
        private DateTimePicker dateTimePickerDo;
        private TextBox textBoxRezerwujacy;
        private Button buttonDodajSale;
        private Button buttonUsunSale;
        private Button buttonDodajRezerwacje;
        private Button buttonUsunRezerwacje;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}

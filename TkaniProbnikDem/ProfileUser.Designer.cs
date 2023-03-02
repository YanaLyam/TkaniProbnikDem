namespace TkaniProbnikDem
{
    partial class ProfileUser
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
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPatronymic = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.btnOut = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.NameTovar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionTovar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManufacturerTovar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceTovar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockTovar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.lbSort = new System.Windows.Forms.Label();
            this.lbSource = new System.Windows.Forms.Label();
            this.tbSource = new System.Windows.Forms.TextBox();
            this.ckbSort = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.lbSurname.Location = new System.Drawing.Point(544, 9);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(100, 26);
            this.lbSurname.TabIndex = 0;
            this.lbSurname.Text = "Фамилия:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.lbName.Location = new System.Drawing.Point(544, 35);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(56, 26);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Имя:";
            // 
            // lbPatronymic
            // 
            this.lbPatronymic.AutoSize = true;
            this.lbPatronymic.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPatronymic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.lbPatronymic.Location = new System.Drawing.Point(544, 61);
            this.lbPatronymic.Name = "lbPatronymic";
            this.lbPatronymic.Size = new System.Drawing.Size(102, 26);
            this.lbPatronymic.TabIndex = 2;
            this.lbPatronymic.Text = "Отчество:";
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.lbRole.Location = new System.Drawing.Point(544, 87);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(60, 26);
            this.lbRole.TabIndex = 3;
            this.lbRole.Text = "Роль:";
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.btnOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOut.FlatAppearance.BorderSize = 0;
            this.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOut.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.btnOut.Location = new System.Drawing.Point(690, 124);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(103, 31);
            this.btnOut.TabIndex = 4;
            this.btnOut.Text = "Выйти";
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameTovar,
            this.DescriptionTovar,
            this.ManufacturerTovar,
            this.PriceTovar,
            this.StockTovar});
            this.dataGridView.Location = new System.Drawing.Point(261, 175);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(532, 319);
            this.dataGridView.TabIndex = 5;
            // 
            // NameTovar
            // 
            this.NameTovar.Frozen = true;
            this.NameTovar.HeaderText = "Наименование товара";
            this.NameTovar.Name = "NameTovar";
            this.NameTovar.ReadOnly = true;
            // 
            // DescriptionTovar
            // 
            this.DescriptionTovar.Frozen = true;
            this.DescriptionTovar.HeaderText = "Описание товара";
            this.DescriptionTovar.Name = "DescriptionTovar";
            this.DescriptionTovar.ReadOnly = true;
            // 
            // ManufacturerTovar
            // 
            this.ManufacturerTovar.Frozen = true;
            this.ManufacturerTovar.HeaderText = "Производитель";
            this.ManufacturerTovar.Name = "ManufacturerTovar";
            this.ManufacturerTovar.ReadOnly = true;
            // 
            // PriceTovar
            // 
            this.PriceTovar.Frozen = true;
            this.PriceTovar.HeaderText = "Цена";
            this.PriceTovar.Name = "PriceTovar";
            this.PriceTovar.ReadOnly = true;
            // 
            // StockTovar
            // 
            this.StockTovar.Frozen = true;
            this.StockTovar.HeaderText = "Наличие на складе";
            this.StockTovar.Name = "StockTovar";
            this.StockTovar.ReadOnly = true;
            // 
            // cbSort
            // 
            this.cbSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "По возрастанию цены",
            "По убыванию цены"});
            this.cbSort.Location = new System.Drawing.Point(58, 201);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(158, 24);
            this.cbSort.TabIndex = 6;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // lbSort
            // 
            this.lbSort.AutoSize = true;
            this.lbSort.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSort.Location = new System.Drawing.Point(53, 172);
            this.lbSort.Name = "lbSort";
            this.lbSort.Size = new System.Drawing.Size(115, 26);
            this.lbSort.TabIndex = 7;
            this.lbSort.Text = "Сортировка";
            // 
            // lbSource
            // 
            this.lbSource.AutoSize = true;
            this.lbSource.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSource.Location = new System.Drawing.Point(258, 142);
            this.lbSource.Name = "lbSource";
            this.lbSource.Size = new System.Drawing.Size(71, 26);
            this.lbSource.TabIndex = 8;
            this.lbSource.Text = "Поиск";
            // 
            // tbSource
            // 
            this.tbSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSource.Location = new System.Drawing.Point(340, 139);
            this.tbSource.Name = "tbSource";
            this.tbSource.Size = new System.Drawing.Size(177, 26);
            this.tbSource.TabIndex = 9;
            this.tbSource.TextChanged += new System.EventHandler(this.tbSource_TextChanged);
            // 
            // ckbSort
            // 
            this.ckbSort.AutoSize = true;
            this.ckbSort.Location = new System.Drawing.Point(58, 265);
            this.ckbSort.Name = "ckbSort";
            this.ckbSort.Size = new System.Drawing.Size(70, 17);
            this.ckbSort.TabIndex = 10;
            this.ckbSort.Text = "Выбрать";
            this.ckbSort.UseVisualStyleBackColor = true;
            // 
            // ProfileUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 506);
            this.Controls.Add(this.ckbSort);
            this.Controls.Add(this.tbSource);
            this.Controls.Add(this.lbSource);
            this.Controls.Add(this.lbSort);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.lbRole);
            this.Controls.Add(this.lbPatronymic);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbSurname);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "ProfileUser";
            this.Text = "ProfileUser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPatronymic;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameTovar;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionTovar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturerTovar;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceTovar;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockTovar;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.Label lbSort;
        private System.Windows.Forms.Label lbSource;
        private System.Windows.Forms.TextBox tbSource;
        private System.Windows.Forms.CheckBox ckbSort;
    }
}
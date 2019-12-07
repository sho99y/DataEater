namespace DataEater
{
    partial class MainForm
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
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.DrawPlace = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.forelBut = new System.Windows.Forms.Button();
            this.ScaleText = new System.Windows.Forms.TextBox();
            this.GridResult = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HowMany = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawPlace)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridResult)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(11, 12);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(244, 512);
            this.DataGrid.TabIndex = 0;
            this.DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellClick);
            this.DataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellValueChanged);
            // 
            // DrawPlace
            // 
            this.DrawPlace.BackColor = System.Drawing.SystemColors.Window;
            this.DrawPlace.Location = new System.Drawing.Point(19, 11);
            this.DrawPlace.Name = "DrawPlace";
            this.DrawPlace.Size = new System.Drawing.Size(856, 776);
            this.DrawPlace.TabIndex = 1;
            this.DrawPlace.TabStop = false;
            this.DrawPlace.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawPlace_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.DrawPlace);
            this.panel1.Location = new System.Drawing.Point(428, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 803);
            this.panel1.TabIndex = 2;
            // 
            // forelBut
            // 
            this.forelBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forelBut.Location = new System.Drawing.Point(11, 529);
            this.forelBut.Name = "forelBut";
            this.forelBut.Size = new System.Drawing.Size(244, 68);
            this.forelBut.TabIndex = 4;
            this.forelBut.Text = "Старт";
            this.forelBut.UseVisualStyleBackColor = true;
            this.forelBut.Click += new System.EventHandler(this.forelBut_Click);
            // 
            // ScaleText
            // 
            this.ScaleText.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScaleText.Location = new System.Drawing.Point(313, 543);
            this.ScaleText.Name = "ScaleText";
            this.ScaleText.Size = new System.Drawing.Size(58, 39);
            this.ScaleText.TabIndex = 6;
            this.ScaleText.Text = "0,5";
            this.ScaleText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GridResult
            // 
            this.GridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Mass});
            this.GridResult.Location = new System.Drawing.Point(261, 11);
            this.GridResult.Name = "GridResult";
            this.GridResult.Size = new System.Drawing.Size(144, 513);
            this.GridResult.TabIndex = 7;
            this.GridResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridResult_CellClick);
            // 
            // Id
            // 
            this.Id.FillWeight = 30F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 30;
            // 
            // Mass
            // 
            this.Mass.FillWeight = 90F;
            this.Mass.HeaderText = "Mass";
            this.Mass.Name = "Mass";
            this.Mass.Width = 90;
            // 
            // HowMany
            // 
            this.HowMany.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HowMany.Location = new System.Drawing.Point(313, 615);
            this.HowMany.Name = "HowMany";
            this.HowMany.Size = new System.Drawing.Size(58, 38);
            this.HowMany.TabIndex = 8;
            this.HowMany.Text = "10";
            this.HowMany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.HowMany);
            this.panel2.Controls.Add(this.DataGrid);
            this.panel2.Controls.Add(this.ScaleText);
            this.panel2.Controls.Add(this.GridResult);
            this.panel2.Controls.Add(this.forelBut);
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 677);
            this.panel2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(11, 603);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 68);
            this.button1.TabIndex = 9;
            this.button1.Text = "Старт (анимация)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(347, 753);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 10;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(347, 782);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 11;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1315, 817);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawPlace)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridResult)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.PictureBox DrawPlace;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button forelBut;
        private System.Windows.Forms.TextBox ScaleText;
        private System.Windows.Forms.DataGridView GridResult;
        private System.Windows.Forms.TextBox HowMany;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Refresh;
    }
}


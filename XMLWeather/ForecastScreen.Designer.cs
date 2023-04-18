namespace XMLWeather
{
    partial class ForecastScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.min1 = new System.Windows.Forms.Label();
            this.max1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.Label();
            this.min2 = new System.Windows.Forms.Label();
            this.max2 = new System.Windows.Forms.Label();
            this.date3 = new System.Windows.Forms.Label();
            this.max3 = new System.Windows.Forms.Label();
            this.min3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(189, 17);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(110, 34);
            this.forecastLabel.TabIndex = 62;
            this.forecastLabel.Text = "7 Day";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 34);
            this.label3.TabIndex = 61;
            this.label3.Text = "Today";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // min1
            // 
            this.min1.BackColor = System.Drawing.Color.White;
            this.min1.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min1.Location = new System.Drawing.Point(75, 255);
            this.min1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.min1.Name = "min1";
            this.min1.Size = new System.Drawing.Size(39, 32);
            this.min1.TabIndex = 48;
            // 
            // max1
            // 
            this.max1.BackColor = System.Drawing.Color.White;
            this.max1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max1.Location = new System.Drawing.Point(28, 255);
            this.max1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.max1.Name = "max1";
            this.max1.Size = new System.Drawing.Size(39, 32);
            this.max1.TabIndex = 45;
            this.max1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(172, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 33);
            this.label5.TabIndex = 63;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // date1
            // 
            this.date1.BackColor = System.Drawing.Color.Transparent;
            this.date1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.ForeColor = System.Drawing.Color.White;
            this.date1.Location = new System.Drawing.Point(22, 301);
            this.date1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(96, 26);
            this.date1.TabIndex = 64;
            this.date1.Text = "Date";
            this.date1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date2
            // 
            this.date2.BackColor = System.Drawing.Color.Transparent;
            this.date2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.ForeColor = System.Drawing.Color.White;
            this.date2.Location = new System.Drawing.Point(116, 301);
            this.date2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(103, 26);
            this.date2.TabIndex = 69;
            this.date2.Text = "Date";
            this.date2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // min2
            // 
            this.min2.BackColor = System.Drawing.Color.White;
            this.min2.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min2.Location = new System.Drawing.Point(168, 255);
            this.min2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.min2.Name = "min2";
            this.min2.Size = new System.Drawing.Size(38, 32);
            this.min2.TabIndex = 68;
            // 
            // max2
            // 
            this.max2.BackColor = System.Drawing.Color.White;
            this.max2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max2.Location = new System.Drawing.Point(122, 255);
            this.max2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.max2.Name = "max2";
            this.max2.Size = new System.Drawing.Size(38, 32);
            this.max2.TabIndex = 66;
            this.max2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // date3
            // 
            this.date3.BackColor = System.Drawing.Color.Transparent;
            this.date3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date3.ForeColor = System.Drawing.Color.White;
            this.date3.Location = new System.Drawing.Point(213, 301);
            this.date3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date3.Name = "date3";
            this.date3.Size = new System.Drawing.Size(98, 26);
            this.date3.TabIndex = 70;
            this.date3.Text = "Date";
            this.date3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // max3
            // 
            this.max3.BackColor = System.Drawing.Color.White;
            this.max3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max3.Location = new System.Drawing.Point(217, 255);
            this.max3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.max3.Name = "max3";
            this.max3.Size = new System.Drawing.Size(39, 32);
            this.max3.TabIndex = 71;
            this.max3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // min3
            // 
            this.min3.BackColor = System.Drawing.Color.White;
            this.min3.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min3.Location = new System.Drawing.Point(264, 255);
            this.min3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.min3.Name = "min3";
            this.min3.Size = new System.Drawing.Size(35, 32);
            this.min3.TabIndex = 72;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(28, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(120, 166);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 74;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(217, 166);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(86, 86);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 75;
            this.pictureBox3.TabStop = false;
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.rainyDayWeather;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.min3);
            this.Controls.Add(this.max3);
            this.Controls.Add(this.date3);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.min2);
            this.Controls.Add(this.max2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.min1);
            this.Controls.Add(this.max1);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(333, 492);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label min1;
        private System.Windows.Forms.Label max1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.Label min2;
        private System.Windows.Forms.Label max2;
        private System.Windows.Forms.Label date3;
        private System.Windows.Forms.Label max3;
        private System.Windows.Forms.Label min3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

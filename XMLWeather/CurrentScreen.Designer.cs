namespace XMLWeather
{
    partial class CurrentScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentScreen));
            this.cityOutput = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.humidLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.brandLabel2 = new System.Windows.Forms.Label();
            this.obligatoryJapaneseLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.weatherIconBox = new System.Windows.Forms.PictureBox();
            this.backdrop = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIconBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backdrop)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.AutoSize = true;
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Microsoft YaHei UI", 62.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(72, 59);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(200, 109);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxOutput
            // 
            this.maxOutput.AutoSize = true;
            this.maxOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput.ForeColor = System.Drawing.Color.White;
            this.maxOutput.Location = new System.Drawing.Point(24, 197);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(51, 25);
            this.maxOutput.TabIndex = 31;
            this.maxOutput.Text = "max";
            this.maxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minOutput
            // 
            this.minOutput.AutoSize = true;
            this.minOutput.BackColor = System.Drawing.Color.Transparent;
            this.minOutput.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput.ForeColor = System.Drawing.Color.White;
            this.minOutput.Location = new System.Drawing.Point(24, 222);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(47, 25);
            this.minOutput.TabIndex = 29;
            this.minOutput.Text = "min";
            this.minOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 44.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.Color.White;
            this.tempLabel.Location = new System.Drawing.Point(94, 182);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(193, 78);
            this.tempLabel.TabIndex = 26;
            this.tempLabel.Text = "Temp";
            this.tempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tempLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // todayLabel
            // 
            this.todayLabel.BackColor = System.Drawing.Color.Transparent;
            this.todayLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayLabel.ForeColor = System.Drawing.Color.White;
            this.todayLabel.Location = new System.Drawing.Point(527, 15);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(82, 28);
            this.todayLabel.TabIndex = 40;
            this.todayLabel.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(629, 15);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(82, 28);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(508, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 27);
            this.label5.TabIndex = 42;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // conditionLabel
            // 
            this.conditionLabel.BackColor = System.Drawing.Color.Transparent;
            this.conditionLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionLabel.ForeColor = System.Drawing.Color.White;
            this.conditionLabel.Location = new System.Drawing.Point(368, 254);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(343, 35);
            this.conditionLabel.TabIndex = 45;
            this.conditionLabel.Text = "Condition";
            this.conditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.conditionLabel.Click += new System.EventHandler(this.CurrentScreen_Load);
            // 
            // humidLabel
            // 
            this.humidLabel.AutoSize = true;
            this.humidLabel.BackColor = System.Drawing.Color.Transparent;
            this.humidLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidLabel.ForeColor = System.Drawing.Color.White;
            this.humidLabel.Location = new System.Drawing.Point(127, 282);
            this.humidLabel.Name = "humidLabel";
            this.humidLabel.Size = new System.Drawing.Size(96, 25);
            this.humidLabel.TabIndex = 46;
            this.humidLabel.Text = "Humidity";
            this.humidLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brandLabel
            // 
            this.brandLabel.BackColor = System.Drawing.Color.White;
            this.brandLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandLabel.ForeColor = System.Drawing.Color.Black;
            this.brandLabel.Location = new System.Drawing.Point(45, 341);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(122, 48);
            this.brandLabel.TabIndex = 47;
            this.brandLabel.Text = "Tokyo";
            this.brandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brandLabel2
            // 
            this.brandLabel2.BackColor = System.Drawing.Color.Red;
            this.brandLabel2.Font = new System.Drawing.Font("Franklin Gothic Medium", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandLabel2.ForeColor = System.Drawing.Color.White;
            this.brandLabel2.Location = new System.Drawing.Point(159, 341);
            this.brandLabel2.Name = "brandLabel2";
            this.brandLabel2.Size = new System.Drawing.Size(64, 48);
            this.brandLabel2.TabIndex = 48;
            this.brandLabel2.Text = "24";
            this.brandLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // obligatoryJapaneseLabel
            // 
            this.obligatoryJapaneseLabel.BackColor = System.Drawing.Color.Transparent;
            this.obligatoryJapaneseLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.obligatoryJapaneseLabel.ForeColor = System.Drawing.Color.White;
            this.obligatoryJapaneseLabel.Location = new System.Drawing.Point(509, 341);
            this.obligatoryJapaneseLabel.Name = "obligatoryJapaneseLabel";
            this.obligatoryJapaneseLabel.Size = new System.Drawing.Size(187, 48);
            this.obligatoryJapaneseLabel.TabIndex = 49;
            this.obligatoryJapaneseLabel.Text = "今日の天気東京で。\r\nいつも東京の天気だけ。";
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(490, 59);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(144, 23);
            this.dateLabel.TabIndex = 50;
            this.dateLabel.Text = "xxxx-xx-xx";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weatherIconBox
            // 
            this.weatherIconBox.BackColor = System.Drawing.Color.Transparent;
            this.weatherIconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weatherIconBox.Location = new System.Drawing.Point(469, 111);
            this.weatherIconBox.Name = "weatherIconBox";
            this.weatherIconBox.Size = new System.Drawing.Size(140, 140);
            this.weatherIconBox.TabIndex = 44;
            this.weatherIconBox.TabStop = false;
            // 
            // backdrop
            // 
            this.backdrop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backdrop.Cursor = System.Windows.Forms.Cursors.Default;
            this.backdrop.ErrorImage = ((System.Drawing.Image)(resources.GetObject("backdrop.ErrorImage")));
            this.backdrop.Location = new System.Drawing.Point(-3, 0);
            this.backdrop.Name = "backdrop";
            this.backdrop.Size = new System.Drawing.Size(728, 410);
            this.backdrop.TabIndex = 43;
            this.backdrop.TabStop = false;
            this.backdrop.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.obligatoryJapaneseLabel);
            this.Controls.Add(this.weatherIconBox);
            this.Controls.Add(this.brandLabel2);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.humidLabel);
            this.Controls.Add(this.conditionLabel);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.backdrop);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(725, 410);
            this.Load += new System.EventHandler(this.CurrentScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weatherIconBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backdrop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox backdrop;
        private System.Windows.Forms.PictureBox weatherIconBox;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.Label humidLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Label brandLabel2;
        private System.Windows.Forms.Label obligatoryJapaneseLabel;
        private System.Windows.Forms.Label dateLabel;
    }
}

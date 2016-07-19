namespace WeatherForecast
{
    partial class ClockForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.city_label = new System.Windows.Forms.Label();
            this.city_txtbox = new System.Windows.Forms.TextBox();
            this.thing_label = new System.Windows.Forms.Label();
            this.thing_txtbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 11);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 21);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // city_label
            // 
            this.city_label.AutoSize = true;
            this.city_label.Location = new System.Drawing.Point(27, 55);
            this.city_label.Name = "city_label";
            this.city_label.Size = new System.Drawing.Size(29, 12);
            this.city_label.TabIndex = 5;
            this.city_label.Text = "城市";
            // 
            // city_txtbox
            // 
            this.city_txtbox.Location = new System.Drawing.Point(78, 52);
            this.city_txtbox.Name = "city_txtbox";
            this.city_txtbox.Size = new System.Drawing.Size(100, 21);
            this.city_txtbox.TabIndex = 6;
            // 
            // thing_label
            // 
            this.thing_label.AutoSize = true;
            this.thing_label.Location = new System.Drawing.Point(25, 95);
            this.thing_label.Name = "thing_label";
            this.thing_label.Size = new System.Drawing.Size(53, 12);
            this.thing_label.TabIndex = 7;
            this.thing_label.Text = "待办事项";
            // 
            // thing_txtbox
            // 
            this.thing_txtbox.Location = new System.Drawing.Point(29, 110);
            this.thing_txtbox.Multiline = true;
            this.thing_txtbox.Name = "thing_txtbox";
            this.thing_txtbox.Size = new System.Drawing.Size(167, 134);
            this.thing_txtbox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(78, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 321);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.thing_txtbox);
            this.Controls.Add(this.thing_label);
            this.Controls.Add(this.city_txtbox);
            this.Controls.Add(this.city_label);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "ClockForm";
            this.Text = "ClockForm";
            this.Load += new System.EventHandler(this.ClockForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label city_label;
        private System.Windows.Forms.TextBox city_txtbox;
        private System.Windows.Forms.Label thing_label;
        private System.Windows.Forms.TextBox thing_txtbox;
        private System.Windows.Forms.Button button1;
    }
}
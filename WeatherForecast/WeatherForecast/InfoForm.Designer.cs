namespace WeatherForecast
{
    partial class InfoForm
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
            this.city = new System.Windows.Forms.Label();
            this.High = new System.Windows.Forms.Label();
            this.Low = new System.Windows.Forms.Label();
            this.fengli = new System.Windows.Forms.Label();
            this.fengxiang = new System.Windows.Forms.Label();
            this.gaomao_txtbox = new System.Windows.Forms.TextBox();
            this.info_txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.city.Location = new System.Drawing.Point(23, 9);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(44, 18);
            this.city.TabIndex = 0;
            this.city.Text = "北京";
            // 
            // High
            // 
            this.High.AutoSize = true;
            this.High.Location = new System.Drawing.Point(26, 40);
            this.High.Name = "High";
            this.High.Size = new System.Drawing.Size(41, 12);
            this.High.TabIndex = 1;
            this.High.Text = "label1";
            // 
            // Low
            // 
            this.Low.AutoSize = true;
            this.Low.Location = new System.Drawing.Point(160, 40);
            this.Low.Name = "Low";
            this.Low.Size = new System.Drawing.Size(41, 12);
            this.Low.TabIndex = 2;
            this.Low.Text = "label2";
            // 
            // fengli
            // 
            this.fengli.AutoSize = true;
            this.fengli.Location = new System.Drawing.Point(160, 69);
            this.fengli.Name = "fengli";
            this.fengli.Size = new System.Drawing.Size(41, 12);
            this.fengli.TabIndex = 3;
            this.fengli.Text = "label3";
            // 
            // fengxiang
            // 
            this.fengxiang.AutoSize = true;
            this.fengxiang.Location = new System.Drawing.Point(26, 69);
            this.fengxiang.Name = "fengxiang";
            this.fengxiang.Size = new System.Drawing.Size(41, 12);
            this.fengxiang.TabIndex = 4;
            this.fengxiang.Text = "label4";
            // 
            // gaomao_txtbox
            // 
            this.gaomao_txtbox.HideSelection = false;
            this.gaomao_txtbox.Location = new System.Drawing.Point(26, 96);
            this.gaomao_txtbox.Multiline = true;
            this.gaomao_txtbox.Name = "gaomao_txtbox";
            this.gaomao_txtbox.ReadOnly = true;
            this.gaomao_txtbox.Size = new System.Drawing.Size(232, 59);
            this.gaomao_txtbox.TabIndex = 5;
            // 
            // info_txtbox
            // 
            this.info_txtbox.HideSelection = false;
            this.info_txtbox.Location = new System.Drawing.Point(26, 174);
            this.info_txtbox.Multiline = true;
            this.info_txtbox.Name = "info_txtbox";
            this.info_txtbox.ReadOnly = true;
            this.info_txtbox.Size = new System.Drawing.Size(232, 61);
            this.info_txtbox.TabIndex = 6;
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.info_txtbox);
            this.Controls.Add(this.gaomao_txtbox);
            this.Controls.Add(this.fengxiang);
            this.Controls.Add(this.fengli);
            this.Controls.Add(this.Low);
            this.Controls.Add(this.High);
            this.Controls.Add(this.city);
            this.Name = "InfoForm";
            this.Text = "每日提醒";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label High;
        private System.Windows.Forms.Label Low;
        private System.Windows.Forms.Label fengli;
        private System.Windows.Forms.Label fengxiang;
        private System.Windows.Forms.TextBox gaomao_txtbox;
        private System.Windows.Forms.TextBox info_txtbox;
    }
}
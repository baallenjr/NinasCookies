
namespace NinasCookieSource
{
    partial class NinasCookieSource
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
            this.ninasCookieSourceLabel = new System.Windows.Forms.Label();
            this.cookieTypeLabel = new System.Windows.Forms.Label();
            this.howManyLabel = new System.Windows.Forms.Label();
            this.sugarRadioButton = new System.Windows.Forms.RadioButton();
            this.oatmealRaisinRadioButton = new System.Windows.Forms.RadioButton();
            this.strawberryRadioButton = new System.Windows.Forms.RadioButton();
            this.howManyListBox = new System.Windows.Forms.ListBox();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.deliveryDateLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.updateInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ninasCookieSourceLabel
            // 
            this.ninasCookieSourceLabel.AutoSize = true;
            this.ninasCookieSourceLabel.Font = new System.Drawing.Font("Poor Richard", 22.25455F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ninasCookieSourceLabel.Location = new System.Drawing.Point(240, 9);
            this.ninasCookieSourceLabel.Name = "ninasCookieSourceLabel";
            this.ninasCookieSourceLabel.Size = new System.Drawing.Size(291, 41);
            this.ninasCookieSourceLabel.TabIndex = 0;
            this.ninasCookieSourceLabel.Text = "Nina\'s Cookie Source";
            // 
            // cookieTypeLabel
            // 
            this.cookieTypeLabel.AutoSize = true;
            this.cookieTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cookieTypeLabel.Location = new System.Drawing.Point(47, 82);
            this.cookieTypeLabel.Name = "cookieTypeLabel";
            this.cookieTypeLabel.Size = new System.Drawing.Size(151, 25);
            this.cookieTypeLabel.TabIndex = 1;
            this.cookieTypeLabel.Text = "Cookie Type:";
            this.cookieTypeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // howManyLabel
            // 
            this.howManyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howManyLabel.Location = new System.Drawing.Point(310, 82);
            this.howManyLabel.Name = "howManyLabel";
            this.howManyLabel.Size = new System.Drawing.Size(141, 24);
            this.howManyLabel.TabIndex = 2;
            this.howManyLabel.Text = "How Many?";
            this.howManyLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sugarRadioButton
            // 
            this.sugarRadioButton.AutoSize = true;
            this.sugarRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sugarRadioButton.Location = new System.Drawing.Point(52, 117);
            this.sugarRadioButton.Name = "sugarRadioButton";
            this.sugarRadioButton.Size = new System.Drawing.Size(78, 28);
            this.sugarRadioButton.TabIndex = 3;
            this.sugarRadioButton.TabStop = true;
            this.sugarRadioButton.Text = "Sugar";
            this.sugarRadioButton.UseVisualStyleBackColor = true;
            this.sugarRadioButton.CheckedChanged += new System.EventHandler(this.SugarRadioButton_CheckedChanged);
            // 
            // oatmealRaisinRadioButton
            // 
            this.oatmealRaisinRadioButton.AutoSize = true;
            this.oatmealRaisinRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oatmealRaisinRadioButton.Location = new System.Drawing.Point(52, 156);
            this.oatmealRaisinRadioButton.Name = "oatmealRaisinRadioButton";
            this.oatmealRaisinRadioButton.Size = new System.Drawing.Size(154, 28);
            this.oatmealRaisinRadioButton.TabIndex = 4;
            this.oatmealRaisinRadioButton.TabStop = true;
            this.oatmealRaisinRadioButton.Text = "Oatmeal Raisin";
            this.oatmealRaisinRadioButton.UseVisualStyleBackColor = true;
            this.oatmealRaisinRadioButton.CheckedChanged += new System.EventHandler(this.OatmealRaisinRadioButton_CheckedChanged);
            // 
            // strawberryRadioButton
            // 
            this.strawberryRadioButton.AutoSize = true;
            this.strawberryRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strawberryRadioButton.Location = new System.Drawing.Point(52, 197);
            this.strawberryRadioButton.Name = "strawberryRadioButton";
            this.strawberryRadioButton.Size = new System.Drawing.Size(117, 28);
            this.strawberryRadioButton.TabIndex = 5;
            this.strawberryRadioButton.TabStop = true;
            this.strawberryRadioButton.Text = "Strawberry";
            this.strawberryRadioButton.UseVisualStyleBackColor = true;
            this.strawberryRadioButton.CheckedChanged += new System.EventHandler(this.StrawberryRadioButton_CheckedChanged);
            // 
            // howManyListBox
            // 
            this.howManyListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howManyListBox.FormattingEnabled = true;
            this.howManyListBox.ItemHeight = 22;
            this.howManyListBox.Items.AddRange(new object[] {
            "1/2 Dozen",
            "1 Dozen",
            "2 Dozen",
            "3 Dozen"});
            this.howManyListBox.Location = new System.Drawing.Point(310, 133);
            this.howManyListBox.Name = "howManyListBox";
            this.howManyListBox.Size = new System.Drawing.Size(141, 92);
            this.howManyListBox.TabIndex = 6;
            this.howManyListBox.SelectedIndexChanged += new System.EventHandler(this.HowManyListBox_SelectedIndexChanged);
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDateLabel.Location = new System.Drawing.Point(527, 82);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(255, 24);
            this.orderDateLabel.TabIndex = 7;
            this.orderDateLabel.Text = "Select Order Date";
            this.orderDateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(527, 117);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar1_DateChanged);
            // 
            // deliveryDateLabel
            // 
            this.deliveryDateLabel.Font = new System.Drawing.Font("Modern No. 20", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryDateLabel.Location = new System.Drawing.Point(48, 354);
            this.deliveryDateLabel.Name = "deliveryDateLabel";
            this.deliveryDateLabel.Size = new System.Drawing.Size(403, 32);
            this.deliveryDateLabel.TabIndex = 9;
            this.deliveryDateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.Font = new System.Drawing.Font("Modern No. 20", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostLabel.Location = new System.Drawing.Point(52, 386);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(399, 38);
            this.totalCostLabel.TabIndex = 10;
            this.totalCostLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // updateInfoButton
            // 
            this.updateInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateInfoButton.Location = new System.Drawing.Point(52, 316);
            this.updateInfoButton.Name = "updateInfoButton";
            this.updateInfoButton.Size = new System.Drawing.Size(399, 35);
            this.updateInfoButton.TabIndex = 11;
            this.updateInfoButton.Text = "View/Update Subtotal and Delivery Date";
            this.updateInfoButton.UseVisualStyleBackColor = true;
            this.updateInfoButton.Click += new System.EventHandler(this.UpdateInfoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateInfoButton);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.deliveryDateLabel);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.orderDateLabel);
            this.Controls.Add(this.howManyListBox);
            this.Controls.Add(this.strawberryRadioButton);
            this.Controls.Add(this.oatmealRaisinRadioButton);
            this.Controls.Add(this.sugarRadioButton);
            this.Controls.Add(this.howManyLabel);
            this.Controls.Add(this.cookieTypeLabel);
            this.Controls.Add(this.ninasCookieSourceLabel);
            this.Name = "Form1";
            this.Text = "Cookies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ninasCookieSourceLabel;
        private System.Windows.Forms.Label cookieTypeLabel;
        private System.Windows.Forms.Label howManyLabel;
        private System.Windows.Forms.RadioButton sugarRadioButton;
        private System.Windows.Forms.RadioButton oatmealRaisinRadioButton;
        private System.Windows.Forms.RadioButton strawberryRadioButton;
        private System.Windows.Forms.ListBox howManyListBox;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label deliveryDateLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Button updateInfoButton;
    }
}


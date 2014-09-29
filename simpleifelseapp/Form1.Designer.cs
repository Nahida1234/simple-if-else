namespace simpleifelseapp
{
    partial class PlanetForm
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
            this.planetnameComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showplanetnumberButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // planetnameComboBox
            // 
            this.planetnameComboBox.FormattingEnabled = true;
            this.planetnameComboBox.Items.AddRange(new object[] {
            "Planet",
            "Mars"});
            this.planetnameComboBox.Location = new System.Drawing.Point(230, 59);
            this.planetnameComboBox.Name = "planetnameComboBox";
            this.planetnameComboBox.Size = new System.Drawing.Size(151, 21);
            this.planetnameComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Planet Name";
            // 
            // showplanetnumberButton
            // 
            this.showplanetnumberButton.Location = new System.Drawing.Point(191, 154);
            this.showplanetnumberButton.Name = "showplanetnumberButton";
            this.showplanetnumberButton.Size = new System.Drawing.Size(156, 29);
            this.showplanetnumberButton.TabIndex = 2;
            this.showplanetnumberButton.Text = "Show Planet Number";
            this.showplanetnumberButton.UseVisualStyleBackColor = true;
            this.showplanetnumberButton.Click += new System.EventHandler(this.showplanetnumberButton_Click);
            // 
            // PlanetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 335);
            this.Controls.Add(this.showplanetnumberButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.planetnameComboBox);
            this.Name = "PlanetForm";
            this.Text = "Simple If/Else App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox planetnameComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showplanetnumberButton;
    }
}


namespace CalendarApp
{
    partial class EventForm
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
            this.addEventTitleTextBox = new System.Windows.Forms.TextBox();
            this.addEventDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.addEventDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addEventBtn = new System.Windows.Forms.Button();
            this.cancelEventAddBtn = new System.Windows.Forms.Button();
            this.updateEventBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // addEventTitleTextBox
            // 
            this.addEventTitleTextBox.Location = new System.Drawing.Point(60, 70);
            this.addEventTitleTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addEventTitleTextBox.Name = "addEventTitleTextBox";
            this.addEventTitleTextBox.Size = new System.Drawing.Size(537, 22);
            this.addEventTitleTextBox.TabIndex = 0;
            // 
            // addEventDescriptionTextBox
            // 
            this.addEventDescriptionTextBox.Location = new System.Drawing.Point(60, 137);
            this.addEventDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addEventDescriptionTextBox.Name = "addEventDescriptionTextBox";
            this.addEventDescriptionTextBox.Size = new System.Drawing.Size(537, 22);
            this.addEventDescriptionTextBox.TabIndex = 1;
            // 
            // addEventDateTimePicker
            // 
            this.addEventDateTimePicker.Location = new System.Drawing.Point(60, 202);
            this.addEventDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addEventDateTimePicker.Name = "addEventDateTimePicker";
            this.addEventDateTimePicker.Size = new System.Drawing.Size(537, 22);
            this.addEventDateTimePicker.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // addEventBtn
            // 
            this.addEventBtn.Location = new System.Drawing.Point(168, 263);
            this.addEventBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addEventBtn.Name = "addEventBtn";
            this.addEventBtn.Size = new System.Drawing.Size(100, 28);
            this.addEventBtn.TabIndex = 6;
            this.addEventBtn.Text = "Add";
            this.addEventBtn.UseVisualStyleBackColor = true;
            this.addEventBtn.Click += new System.EventHandler(this.addEventBtn_Click);
            // 
            // cancelEventAddBtn
            // 
            this.cancelEventAddBtn.Location = new System.Drawing.Point(60, 263);
            this.cancelEventAddBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelEventAddBtn.Name = "cancelEventAddBtn";
            this.cancelEventAddBtn.Size = new System.Drawing.Size(100, 28);
            this.cancelEventAddBtn.TabIndex = 7;
            this.cancelEventAddBtn.Text = "Cancel";
            this.cancelEventAddBtn.UseVisualStyleBackColor = true;
            this.cancelEventAddBtn.Click += new System.EventHandler(this.cancelEventAddBtn_Click);
            // 
            // updateEventBtn
            // 
            this.updateEventBtn.Enabled = false;
            this.updateEventBtn.Location = new System.Drawing.Point(499, 263);
            this.updateEventBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateEventBtn.Name = "updateEventBtn";
            this.updateEventBtn.Size = new System.Drawing.Size(100, 28);
            this.updateEventBtn.TabIndex = 8;
            this.updateEventBtn.Text = "Update";
            this.updateEventBtn.UseVisualStyleBackColor = true;
            this.updateEventBtn.Click += new System.EventHandler(this.updateEventBtn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(354, 268);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 20);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Scheduled";
            this.checkBox1.UseVisualStyleBackColor = true;
           
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 351);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.updateEventBtn);
            this.Controls.Add(this.cancelEventAddBtn);
            this.Controls.Add(this.addEventBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addEventDateTimePicker);
            this.Controls.Add(this.addEventDescriptionTextBox);
            this.Controls.Add(this.addEventTitleTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EventForm";
            this.Text = "e";
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addEventTitleTextBox;
        private System.Windows.Forms.TextBox addEventDescriptionTextBox;
        private System.Windows.Forms.DateTimePicker addEventDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addEventBtn;
        private System.Windows.Forms.Button cancelEventAddBtn;
        private System.Windows.Forms.Button updateEventBtn;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
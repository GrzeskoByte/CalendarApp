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
            this.SuspendLayout();
            // 
            // addEventTitleTextBox
            // 
            this.addEventTitleTextBox.Location = new System.Drawing.Point(45, 57);
            this.addEventTitleTextBox.Name = "addEventTitleTextBox";
            this.addEventTitleTextBox.Size = new System.Drawing.Size(404, 20);
            this.addEventTitleTextBox.TabIndex = 0;
            // 
            // addEventDescriptionTextBox
            // 
            this.addEventDescriptionTextBox.Location = new System.Drawing.Point(45, 111);
            this.addEventDescriptionTextBox.Name = "addEventDescriptionTextBox";
            this.addEventDescriptionTextBox.Size = new System.Drawing.Size(404, 20);
            this.addEventDescriptionTextBox.TabIndex = 1;
            // 
            // addEventDateTimePicker
            // 
            this.addEventDateTimePicker.Location = new System.Drawing.Point(45, 164);
            this.addEventDateTimePicker.Name = "addEventDateTimePicker";
            this.addEventDateTimePicker.Size = new System.Drawing.Size(404, 20);
            this.addEventDateTimePicker.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // addEventBtn
            // 
            this.addEventBtn.Location = new System.Drawing.Point(126, 214);
            this.addEventBtn.Name = "addEventBtn";
            this.addEventBtn.Size = new System.Drawing.Size(75, 23);
            this.addEventBtn.TabIndex = 6;
            this.addEventBtn.Text = "Add";
            this.addEventBtn.UseVisualStyleBackColor = true;
            this.addEventBtn.Click += new System.EventHandler(this.addEventBtn_Click);
            // 
            // cancelEventAddBtn
            // 
            this.cancelEventAddBtn.Location = new System.Drawing.Point(45, 214);
            this.cancelEventAddBtn.Name = "cancelEventAddBtn";
            this.cancelEventAddBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelEventAddBtn.TabIndex = 7;
            this.cancelEventAddBtn.Text = "Cancel";
            this.cancelEventAddBtn.UseVisualStyleBackColor = true;
            this.cancelEventAddBtn.Click += new System.EventHandler(this.cancelEventAddBtn_Click);
            // 
            // updateEventBtn
            // 
            this.updateEventBtn.Enabled = false;
            this.updateEventBtn.Location = new System.Drawing.Point(374, 214);
            this.updateEventBtn.Name = "updateEventBtn";
            this.updateEventBtn.Size = new System.Drawing.Size(75, 23);
            this.updateEventBtn.TabIndex = 8;
            this.updateEventBtn.Text = "Update";
            this.updateEventBtn.UseVisualStyleBackColor = true;
            this.updateEventBtn.Click += new System.EventHandler(this.updateEventBtn_Click);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 285);
            this.Controls.Add(this.updateEventBtn);
            this.Controls.Add(this.cancelEventAddBtn);
            this.Controls.Add(this.addEventBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addEventDateTimePicker);
            this.Controls.Add(this.addEventDescriptionTextBox);
            this.Controls.Add(this.addEventTitleTextBox);
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
    }
}
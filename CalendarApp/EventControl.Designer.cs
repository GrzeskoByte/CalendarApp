namespace CalendarApp
{
    partial class EventControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.eventTitle = new System.Windows.Forms.Label();
            this.eventDesc = new System.Windows.Forms.Label();
            this.removeEventBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eventTitle
            // 
            this.eventTitle.AutoSize = true;
            this.eventTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.eventTitle.ForeColor = System.Drawing.Color.White;
            this.eventTitle.Location = new System.Drawing.Point(3, 9);
            this.eventTitle.Name = "eventTitle";
            this.eventTitle.Size = new System.Drawing.Size(41, 13);
            this.eventTitle.TabIndex = 0;
            this.eventTitle.Text = "label1";
            // 
            // eventDesc
            // 
            this.eventDesc.AutoEllipsis = true;
            this.eventDesc.ForeColor = System.Drawing.Color.White;
            this.eventDesc.Location = new System.Drawing.Point(3, 51);
            this.eventDesc.Name = "eventDesc";
            this.eventDesc.Size = new System.Drawing.Size(117, 18);
            this.eventDesc.TabIndex = 1;
            this.eventDesc.Text = "label2";
            // 
            // removeEventBtn
            // 
            this.removeEventBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(129)))), ((int)(((byte)(173)))));
            this.removeEventBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeEventBtn.FlatAppearance.BorderSize = 0;
            this.removeEventBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeEventBtn.ForeColor = System.Drawing.Color.White;
            this.removeEventBtn.Location = new System.Drawing.Point(137, 46);
            this.removeEventBtn.Name = "removeEventBtn";
            this.removeEventBtn.Size = new System.Drawing.Size(75, 23);
            this.removeEventBtn.TabIndex = 2;
            this.removeEventBtn.Text = "Remove";
            this.removeEventBtn.UseVisualStyleBackColor = false;
            this.removeEventBtn.Click += new System.EventHandler(this.removeEventBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(195)))), ((int)(((byte)(166)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(137, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.editEventBtn);
            // 
            // EventControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(126)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.removeEventBtn);
            this.Controls.Add(this.eventDesc);
            this.Controls.Add(this.eventTitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "EventControl";
            this.Size = new System.Drawing.Size(215, 80);
            this.Load += new System.EventHandler(this.EventControl_Load);
            this.Click += new System.EventHandler(this.EventControl_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eventTitle;
        private System.Windows.Forms.Label eventDesc;
        private System.Windows.Forms.Button removeEventBtn;
        private System.Windows.Forms.Button button1;
    }
}

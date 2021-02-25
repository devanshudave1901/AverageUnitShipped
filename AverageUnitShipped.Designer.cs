
namespace AverageUnitShipped
{
    partial class formAverageUnitShipped
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.UnitsPromptLabel = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.textboxInputNumbers = new System.Windows.Forms.TextBox();
            this.textBoxPastInputs = new System.Windows.Forms.TextBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.buttonToEnter = new System.Windows.Forms.Button();
            this.buttontoReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // UnitsPromptLabel
            // 
            this.UnitsPromptLabel.Location = new System.Drawing.Point(67, 34);
            this.UnitsPromptLabel.Name = "UnitsPromptLabel";
            this.UnitsPromptLabel.Size = new System.Drawing.Size(59, 38);
            this.UnitsPromptLabel.TabIndex = 0;
            this.UnitsPromptLabel.Text = "&Units:";
            this.UnitsPromptLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelDay
            // 
            this.labelDay.Location = new System.Drawing.Point(372, 37);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(68, 28);
            this.labelDay.TabIndex = 1;
            this.labelDay.Text = "Day 1";
            this.labelDay.Click += new System.EventHandler(this.label2_Click);
            // 
            // textboxInputNumbers
            // 
            this.textboxInputNumbers.Location = new System.Drawing.Point(200, 34);
            this.textboxInputNumbers.Name = "textboxInputNumbers";
            this.textboxInputNumbers.Size = new System.Drawing.Size(98, 31);
            this.textboxInputNumbers.TabIndex = 2;
            this.toolTip.SetToolTip(this.textboxInputNumbers, "Enter the unit shipped on the specific day");
            this.textboxInputNumbers.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxPastInputs
            // 
            this.textBoxPastInputs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxPastInputs.Location = new System.Drawing.Point(67, 87);
            this.textBoxPastInputs.Multiline = true;
            this.textBoxPastInputs.Name = "textBoxPastInputs";
            this.textBoxPastInputs.ReadOnly = true;
            this.textBoxPastInputs.Size = new System.Drawing.Size(337, 232);
            this.textBoxPastInputs.TabIndex = 3;
            this.toolTip.SetToolTip(this.textBoxPastInputs, "all days entered ");
            // 
            // labelOutput
            // 
            this.labelOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOutput.Location = new System.Drawing.Point(67, 339);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(337, 38);
            this.labelOutput.TabIndex = 4;
            this.toolTip.SetToolTip(this.labelOutput, "Calculated average of the shipment been displayed here.");
            this.labelOutput.Click += new System.EventHandler(this.labelOutput_Click);
            // 
            // buttonToEnter
            // 
            this.buttonToEnter.Location = new System.Drawing.Point(28, 414);
            this.buttonToEnter.Name = "buttonToEnter";
            this.buttonToEnter.Size = new System.Drawing.Size(98, 36);
            this.buttonToEnter.TabIndex = 5;
            this.buttonToEnter.Text = "&Enter";
            this.toolTip.SetToolTip(this.buttonToEnter, "Enter button to execute the calcualation.");
            this.buttonToEnter.UseVisualStyleBackColor = true;
            this.buttonToEnter.Click += new System.EventHandler(this.EnterButtonClick);
            // 
            // buttontoReset
            // 
            this.buttontoReset.Location = new System.Drawing.Point(182, 416);
            this.buttontoReset.Name = "buttontoReset";
            this.buttontoReset.Size = new System.Drawing.Size(116, 36);
            this.buttontoReset.TabIndex = 6;
            this.buttontoReset.Text = "&Reset";
            this.toolTip.SetToolTip(this.buttontoReset, "Reset Button to reset the whole application");
            this.buttontoReset.UseVisualStyleBackColor = true;
            this.buttontoReset.Click += new System.EventHandler(this.ResetButtonClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(357, 416);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 34);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "&Exit";
            this.toolTip.SetToolTip(this.buttonExit, "Exit button to exit the application");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // formAverageUnitShipped
            // 
            this.AcceptButton = this.buttonToEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.buttontoReset;
            this.ClientSize = new System.Drawing.Size(509, 478);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttontoReset);
            this.Controls.Add(this.buttonToEnter);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.textBoxPastInputs);
            this.Controls.Add(this.textboxInputNumbers);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.UnitsPromptLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formAverageUnitShipped";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Units Shipped";
            this.Load += new System.EventHandler(this.AverageUnitShipped_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UnitsPromptLabel;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.TextBox textboxInputNumbers;
        private System.Windows.Forms.TextBox textBoxPastInputs;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonToEnter;
        private System.Windows.Forms.Button buttontoReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolTip toolTip;
    }
}


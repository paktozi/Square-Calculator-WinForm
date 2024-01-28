namespace Square_Meter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            heightInputBox = new TextBox();
            widthInputBox = new TextBox();
            resultBox = new RichTextBox();
            calculateButton = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button4 = new Button();
            label4 = new Label();
            label5 = new Label();
            wallCheckButton = new CheckBox();
            windowCheckButton = new CheckBox();
            revealCheckButton = new CheckBox();
            revealInputBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            totalRevealsBox = new TextBox();
            totalWindowsBox = new TextBox();
            totalWallsBox = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // heightInputBox
            // 
            heightInputBox.BackColor = SystemColors.Window;
            resources.ApplyResources(heightInputBox, "heightInputBox");
            heightInputBox.Name = "heightInputBox";
            heightInputBox.TextChanged += textBox1_TextChanged;
            // 
            // widthInputBox
            // 
            resources.ApplyResources(widthInputBox, "widthInputBox");
            widthInputBox.Name = "widthInputBox";
            widthInputBox.TextChanged += textBox2_TextChanged;
            // 
            // resultBox
            // 
            resultBox.BackColor = SystemColors.GradientActiveCaption;
            resources.ApplyResources(resultBox, "resultBox");
            resultBox.Name = "resultBox";
            resultBox.TextChanged += richTextBox1_TextChanged;
            // 
            // calculateButton
            // 
            calculateButton.BackColor = Color.LimeGreen;
            resources.ApplyResources(calculateButton, "calculateButton");
            calculateButton.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            calculateButton.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            calculateButton.Name = "calculateButton";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += CalculateButtonClick;
            // 
            // button2
            // 
            button2.BackColor = Color.RosyBrown;
            button2.FlatAppearance.BorderColor = Color.DarkOliveGreen;
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += ResetButtonClick;
            // 
            // button3
            // 
            button3.BackColor = Color.Firebrick;
            resources.ApplyResources(button3, "button3");
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += ClearButtonClick;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.BackColor = Color.Transparent;
            label3.Name = "label3";
            // 
            // button4
            // 
            button4.BackColor = Color.Coral;
            resources.ApplyResources(button4, "button4");
            button4.Name = "button4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += TotalButtonClick;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.BackColor = Color.Transparent;
            label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.BackColor = Color.Transparent;
            label5.Name = "label5";
            // 
            // wallCheckButton
            // 
            resources.ApplyResources(wallCheckButton, "wallCheckButton");
            wallCheckButton.BackColor = Color.Transparent;
            wallCheckButton.Checked = true;
            wallCheckButton.CheckState = CheckState.Checked;
            wallCheckButton.Name = "wallCheckButton";
            wallCheckButton.UseVisualStyleBackColor = false;
            wallCheckButton.CheckedChanged += wallButton_CheckedChanged;
            // 
            // windowCheckButton
            // 
            resources.ApplyResources(windowCheckButton, "windowCheckButton");
            windowCheckButton.BackColor = Color.Transparent;
            windowCheckButton.Name = "windowCheckButton";
            windowCheckButton.UseVisualStyleBackColor = false;
            windowCheckButton.CheckedChanged += windowButton_CheckedChanged;
            // 
            // revealCheckButton
            // 
            resources.ApplyResources(revealCheckButton, "revealCheckButton");
            revealCheckButton.BackColor = Color.Transparent;
            revealCheckButton.Name = "revealCheckButton";
            revealCheckButton.UseVisualStyleBackColor = false;
            revealCheckButton.CheckedChanged += revealButton_CheckedChanged;
            // 
            // revealInputBox
            // 
            resources.ApplyResources(revealInputBox, "revealInputBox");
            revealInputBox.Name = "revealInputBox";
            revealInputBox.TextChanged += textBox3_TextChanged;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.BackColor = Color.Transparent;
            label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.BackColor = Color.Transparent;
            label7.Name = "label7";
            // 
            // totalRevealsBox
            // 
            resources.ApplyResources(totalRevealsBox, "totalRevealsBox");
            totalRevealsBox.Name = "totalRevealsBox";
            totalRevealsBox.TextChanged += totalRevealsBox_TextChanged;
            // 
            // totalWindowsBox
            // 
            resources.ApplyResources(totalWindowsBox, "totalWindowsBox");
            totalWindowsBox.Name = "totalWindowsBox";
            totalWindowsBox.TextChanged += totalWindowsBox_TextChanged;
            // 
            // totalWallsBox
            // 
            resources.ApplyResources(totalWallsBox, "totalWallsBox");
            totalWallsBox.Name = "totalWallsBox";
            totalWallsBox.TextChanged += totalWallsBox_TextChanged;
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.BackColor = Color.Transparent;
            label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.BackColor = Color.Transparent;
            label9.Name = "label9";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.BackColor = Color.Transparent;
            label10.Name = "label10";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(totalWallsBox);
            Controls.Add(totalWindowsBox);
            Controls.Add(totalRevealsBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(revealInputBox);
            Controls.Add(revealCheckButton);
            Controls.Add(windowCheckButton);
            Controls.Add(wallCheckButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(calculateButton);
            Controls.Add(resultBox);
            Controls.Add(widthInputBox);
            Controls.Add(heightInputBox);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaptionText;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form1";
            Opacity = 0.95D;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox heightInputBox;
        private TextBox widthInputBox;
        private RichTextBox resultBox;
        private Button calculateButton;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button4;
        private Label label4;
        private Label label5;
        private CheckBox wallCheckButton;
        private CheckBox windowCheckButton;
        private CheckBox revealCheckButton;
        private TextBox revealInputBox;
        private Label label6;
        private Label label7;
        private TextBox totalRevealsBox;
        private TextBox totalWindowsBox;
        private TextBox totalWallsBox;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}

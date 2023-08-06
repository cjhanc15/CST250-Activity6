namespace TextFileDataAccessDemoGUI
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
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            URLLabel = new Label();
            add = new Button();
            save = new Button();
            load = new Button();
            peopleListBox = new ListBox();
            firstName = new TextBox();
            lastName = new TextBox();
            URL = new TextBox();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(12, 74);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(134, 32);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(12, 119);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(131, 32);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Last Name:";
            // 
            // URLLabel
            // 
            URLLabel.AutoSize = true;
            URLLabel.Location = new Point(12, 169);
            URLLabel.Name = "URLLabel";
            URLLabel.Size = new Size(60, 32);
            URLLabel.TabIndex = 2;
            URLLabel.Text = "URL:";
            // 
            // add
            // 
            add.Location = new Point(12, 240);
            add.Name = "add";
            add.Size = new Size(215, 46);
            add.TabIndex = 3;
            add.Text = "Add to List -->";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // save
            // 
            save.Location = new Point(112, 447);
            save.Name = "save";
            save.Size = new Size(215, 46);
            save.TabIndex = 4;
            save.Text = "Save to File";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // load
            // 
            load.Location = new Point(112, 514);
            load.Name = "load";
            load.Size = new Size(215, 46);
            load.TabIndex = 5;
            load.Text = "Load from File";
            load.UseVisualStyleBackColor = true;
            load.Click += load_Click;
            // 
            // peopleListBox
            // 
            peopleListBox.FormattingEnabled = true;
            peopleListBox.ItemHeight = 32;
            peopleListBox.Location = new Point(447, 32);
            peopleListBox.Name = "peopleListBox";
            peopleListBox.Size = new Size(678, 612);
            peopleListBox.TabIndex = 6;
            // 
            // firstName
            // 
            firstName.Location = new Point(183, 71);
            firstName.Name = "firstName";
            firstName.Size = new Size(200, 39);
            firstName.TabIndex = 7;
            // 
            // lastName
            // 
            lastName.Location = new Point(183, 116);
            lastName.Name = "lastName";
            lastName.Size = new Size(200, 39);
            lastName.TabIndex = 8;
            // 
            // URL
            // 
            URL.Location = new Point(183, 166);
            URL.Name = "URL";
            URL.Size = new Size(200, 39);
            URL.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 673);
            Controls.Add(URL);
            Controls.Add(lastName);
            Controls.Add(firstName);
            Controls.Add(peopleListBox);
            Controls.Add(load);
            Controls.Add(save);
            Controls.Add(add);
            Controls.Add(URLLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label URLLabel;
        private Button add;
        private Button save;
        private Button load;
        private ListBox peopleListBox;
        private TextBox firstName;
        private TextBox lastName;
        private TextBox URL;
    }
}
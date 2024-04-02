namespace WinFormsApp2
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
            titleLabel = new Label();
            taskTextBox = new TextBox();
            addButton = new Button();
            taskListBox = new ListBox();
            removeButton = new Button();
            dueDateTimePicker = new DateTimePicker();
            completeCheckBox = new CheckBox();
            completedTasksButton = new Button();
            overdueTasksButton = new Button();
            overdueListBox = new ListBox();
            completedListBox = new ListBox();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F);
            titleLabel.Location = new Point(389, 24);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(174, 41);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Список дел";
            titleLabel.Click += titleLabel_Click;
            // 
            // taskTextBox
            // 
            taskTextBox.Location = new Point(318, 96);
            taskTextBox.Margin = new Padding(4);
            taskTextBox.Name = "taskTextBox";
            taskTextBox.Size = new Size(363, 31);
            taskTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            addButton.Location = new Point(75, 229);
            addButton.Margin = new Padding(4);
            addButton.Name = "addButton";
            addButton.Size = new Size(141, 39);
            addButton.TabIndex = 2;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // taskListBox
            // 
            taskListBox.FormattingEnabled = true;
            taskListBox.ItemHeight = 27;
            taskListBox.Location = new Point(318, 165);
            taskListBox.Margin = new Padding(4);
            taskListBox.Name = "taskListBox";
            taskListBox.Size = new Size(363, 382);
            taskListBox.TabIndex = 3;
            taskListBox.SelectedIndexChanged += taskListBox_SelectedIndexChanged;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(75, 311);
            removeButton.Margin = new Padding(4);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(141, 39);
            removeButton.TabIndex = 4;
            removeButton.Text = "Удалить";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // dueDateTimePicker
            // 
            dueDateTimePicker.Location = new Point(42, 96);
            dueDateTimePicker.Margin = new Padding(4);
            dueDateTimePicker.Name = "dueDateTimePicker";
            dueDateTimePicker.Size = new Size(263, 31);
            dueDateTimePicker.TabIndex = 5;
            // 
            // completeCheckBox
            // 
            completeCheckBox.AutoSize = true;
            completeCheckBox.Location = new Point(42, 165);
            completeCheckBox.Margin = new Padding(4);
            completeCheckBox.Name = "completeCheckBox";
            completeCheckBox.Size = new Size(226, 31);
            completeCheckBox.TabIndex = 6;
            completeCheckBox.Text = "Задача выполнена";
            completeCheckBox.UseVisualStyleBackColor = true;
            completeCheckBox.CheckedChanged += completeCheckBox_CheckedChanged;
            // 
            // completedTasksButton
            // 
            completedTasksButton.Location = new Point(824, 311);
            completedTasksButton.Margin = new Padding(4);
            completedTasksButton.Name = "completedTasksButton";
            completedTasksButton.Size = new Size(270, 77);
            completedTasksButton.TabIndex = 7;
            completedTasksButton.Text = "Просмотр выполненных задач";
            completedTasksButton.UseVisualStyleBackColor = true;
            // 
            // overdueTasksButton
            // 
            overdueTasksButton.Location = new Point(824, 24);
            overdueTasksButton.Margin = new Padding(4);
            overdueTasksButton.Name = "overdueTasksButton";
            overdueTasksButton.Size = new Size(270, 77);
            overdueTasksButton.TabIndex = 8;
            overdueTasksButton.Text = "Просмотр просроченных задач";
            overdueTasksButton.UseVisualStyleBackColor = true;
            // 
            // overdueListBox
            // 
            overdueListBox.FormattingEnabled = true;
            overdueListBox.ItemHeight = 27;
            overdueListBox.Location = new Point(769, 124);
            overdueListBox.Name = "overdueListBox";
            overdueListBox.Size = new Size(423, 166);
            overdueListBox.TabIndex = 9;
            overdueListBox.SelectedIndexChanged += overdueListBox_SelectedIndexChanged;
            // 
            // completedListBox
            // 
            completedListBox.FormattingEnabled = true;
            completedListBox.ItemHeight = 27;
            completedListBox.Location = new Point(769, 417);
            completedListBox.Name = "completedListBox";
            completedListBox.Size = new Size(423, 166);
            completedListBox.TabIndex = 10;
            completedListBox.SelectedIndexChanged += completedListBox_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1200, 608);
            Controls.Add(completedListBox);
            Controls.Add(overdueListBox);
            Controls.Add(overdueTasksButton);
            Controls.Add(completedTasksButton);
            Controls.Add(completeCheckBox);
            Controls.Add(dueDateTimePicker);
            Controls.Add(removeButton);
            Controls.Add(taskListBox);
            Controls.Add(addButton);
            Controls.Add(taskTextBox);
            Controls.Add(titleLabel);
            Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.MenuText;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private TextBox taskTextBox;
        private Button addButton;
        private ListBox taskListBox;
        private Button removeButton;
        private DateTimePicker dueDateTimePicker;
        private CheckBox completeCheckBox;
        private Button completedTasksButton;
        private Button overdueTasksButton;
        private ListBox overdueListBox;
        private ListBox completedListBox;
        //private Button titleLabel_Click;
    }
}

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private List<TaskItem> tasks = new List<TaskItem>();

        public Form1()
        {
            InitializeComponent();
            LoadTasks();
            ShowOverdueTasks(); 
            ShowCompletedTasks();
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {
            // 
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string taskDescription = taskTextBox.Text;
            if (!string.IsNullOrWhiteSpace(taskDescription))
            {
                DateTime? dueDate = dueDateTimePicker.Value;
                TaskItem newTask = new TaskItem(taskDescription, dueDate);
                tasks.Add(newTask);
                taskListBox.Items.Add(newTask);
                taskTextBox.Clear();

                SaveTasks();
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (taskListBox.SelectedIndex != -1)
            {
                TaskItem selectedTask = (TaskItem)taskListBox.SelectedItem;
                tasks.Remove(selectedTask);
                taskListBox.Items.Remove(selectedTask);

                SaveTasks();
            }
        }

        private void completeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TaskItem selectedTask = (TaskItem)taskListBox.SelectedItem;
            if (selectedTask != null)
            {
                selectedTask.Completed = completeCheckBox.Checked;
                taskListBox.Items[taskListBox.SelectedIndex] = selectedTask;
                taskListBox.Refresh(); 
                SaveTasks();

                ShowOverdueTasks();
                ShowCompletedTasks();
            }
        }



        private void taskListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskItem selectedTask = (TaskItem)taskListBox.SelectedItem;
            if (selectedTask != null)
            {
                completeCheckBox.Checked = selectedTask.Completed;
            }
        }

        private void LoadTasks()
        {
            try
            {
                using (StreamReader sr = new StreamReader("tasks.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        string description = parts[0];
                        DateTime? dueDate = string.IsNullOrEmpty(parts[1]) ? null : (DateTime?)DateTime.Parse(parts[1]);
                        bool completed = bool.Parse(parts[2]);
                        TaskItem task = new TaskItem(description, dueDate, completed);
                        tasks.Add(task);
                        taskListBox.Items.Add(task);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                // 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке задач: {ex.Message}");
            }
        }

        private void SaveTasks()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("tasks.txt"))
                {
                    foreach (TaskItem task in tasks)
                    {
                        sw.WriteLine($"{task.Description},{task.DueDate},{task.Completed}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении задач: {ex.Message}");
            }
        }

        private void ShowOverdueTasks()
        {
            overdueListBox.Items.Clear();
            foreach (TaskItem task in tasks)
            {
                if (task.DueDate.HasValue && task.DueDate < DateTime.Today && !task.Completed)
                {
                    overdueListBox.Items.Add($"Просроченная задача: {task.Description}");
                }
            }
        }

        private void ShowCompletedTasks()
        {
            completedListBox.Items.Clear();
            foreach (TaskItem task in tasks)
            {
                if (task.Completed)
                {
                    completedListBox.Items.Add($"Выполненная задача: {task.Description}");
                }
            }
        }
        private void overdueTasksButton_Click(object sender, EventArgs e)
        {
            ShowOverdueTasks();
        }

        private void completedTasksButton_Click(object sender, EventArgs e)
        {
            ShowCompletedTasks();
        }

        private void overdueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 
        }

        private void completedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }
    }

    public class TaskItem
    {
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public bool Completed { get; set; }

        public TaskItem(string description, DateTime? dueDate, bool completed = false)
        {
            Description = description;
            DueDate = dueDate;
            Completed = completed;
        }

        public override string ToString()
        {
            if (DueDate.HasValue)
            {
                return $"{Description} (до {DueDate.Value.ToShortDateString()})";
            }
            else
            {
                return Description;
            }
        }
    }
}

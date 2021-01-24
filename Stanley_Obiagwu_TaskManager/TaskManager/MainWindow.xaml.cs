using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TaskManager
{
    /// Interaction logic for MainWindow.xaml
   
    public partial class MainWindow : Window
    {
        private List<Task> tasks = new List<Task>();
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            Task task = null;
            task = createTask();
            if (task != null)
            {
                tasks.Add(task);
                listBox1.Items.Add(task.ToFormattedString());
            }
        }

        // Create new task function
        private Task createTask()
        {
            AddEditTask aet = new AddEditTask();

            bool? result = aet.ShowDialog();
            if (result != result.HasValue)
            {
                return null;
            }

            Task T = new Task(aet.TaskName,
                                aet.TimeCreated,
                                aet.TimeDue
                                );
            return T;
        }

        // Delete task event
        private void DeleteTask_Click(object sender, RoutedEventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("You must select an item to be deleted");
                return;
            }
            if (listBox1.SelectedItems.Count > 1)
            {
                MessageBox.Show("You must select one item to delete");
                return;
            }
            Task tasktoDelete = tasks[index];
            tasks.RemoveAt(index);
            listBox1.Items.RemoveAt(index);
        }

        // Update task event 
        private void UpdateTask_Click(object sender, RoutedEventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("You must select an item to be update");
                return;
            }
            if (listBox1.SelectedItems.Count > 1)
            {
                MessageBox.Show("You must select one item to update");
                return;
            }

            Task tasktoUpdate = tasks[index];
            uppdateTask(index);
        }

        private void uppdateTask( int index)
        {
            AddEditTask aet = new AddEditTask();
            aet.EditMode = true;

            Task T = (Task)tasks[index];

            aet.TaskName = T.Name;
            aet.TimeDue = T.DateDue;
            aet.TimeCreated = T.DateCreated;
            aet.TaskStatus = T.Status;
            bool? result = aet.ShowDialog();
            if (result != result.HasValue)
            {
                return ;
            }
            Task updatedTask = new Task(aet.TaskName,
                                aet.TimeCreated,
                                aet.TimeDue,
                                aet.TaskStatus
                                );
            
            // Update confirmation 

            MessageBoxResult result2;
            result2 = MessageBox.Show($"Are you sure you like to update {updatedTask.Name}'s details?",
                                        "Confirmation", MessageBoxButton.YesNo);
            if(result2 == MessageBoxResult.Yes)
            {
                tasks[index] = updatedTask;
                listBox1.Items[index] = updatedTask.ToString();
            }
            else { return; }
        }

        // Set up Current date 
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            currentDateTextBlock.Text = $"Current Date: {DateTime.Now}";
        }
    }
}

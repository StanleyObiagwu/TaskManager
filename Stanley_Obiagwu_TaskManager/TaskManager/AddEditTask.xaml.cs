using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TaskManager
{
    /// <summary>
    /// Interaction logic for AddEditTask.xaml
    /// </summary>
    public partial class AddEditTask : Window
    {
        public bool EditMode;
        public string TaskName;
        public DateTime TimeCreated;
        public DateTime TimeDue;
        public int TaskStatus;

        private bool haveValidName = false;
        private bool haveDateCreated = false;
        private bool haveValidDateDue = false;
        private bool haveValidStatus = false;

        public AddEditTask()
        {
            InitializeComponent();
        }

        // Validation for input parameters
        private void AddtaskButton_Click(object sender, RoutedEventArgs e)
        {
            string badFieldName = null;
            string adviceString = null;

            if (!haveValidName)
            {
                badFieldName = "Task Name";
                adviceString = "Must enter Valid Task Name";
            }
            if (!haveDateCreated)
            {
                badFieldName = "Date Created";
                adviceString = "Must enter Valid Date";
            }
            if (!haveValidDateDue)
            {
                badFieldName = "Date Due";
                adviceString = "Must enter Valid Date";
            }
            if (!haveValidStatus)
            {
                badFieldName = "Status";
                adviceString = "Must Select Valid Status";
            }
            if (badFieldName != null)
            {
                MessageBox.Show($"Invalid {badFieldName}, \n{adviceString}", "Data Entry Error");
                return;
            }
            DialogResult = true;
        }

        // Task name textbox data parse
        private void TaskNameTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(TaskNameTextbox.Text.Trim().Length == 0)
            {
                haveValidName = false;
            }
            else
            {
                haveValidName = true;
                TaskName = TaskNameTextbox.Text.Trim();
            }
        }

        //  Date created textbox data parse
        private void DateCreatedTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(DateCreatedTextBox.Text.Trim().Length == 0)
            {
                haveDateCreated = false;
            }
            else
            {
                haveDateCreated = true;
                
            }
        }

        // Due date textbox data parse
        private void DateDueTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (DateDueTextBox.Text.Trim().Length == 0)
            {
                haveValidDateDue = false;
            }
            else
            {
               haveValidDateDue = true;
                
            }
        }

        // Status textbox data parse

        private void StatusTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (StatusTextBox.Text.Trim().Length == 0)
            {
                haveValidStatus = false;
            }
            else
            {
                haveValidStatus = true;
                TaskStatus = int.Parse(StatusTextBox.Text.Trim());
            }
        }

        private void DateCreatedpicker_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        // date created task picker
        private void DateCreatedpicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateCreatedTextBox.Text = DateCreatedpicker.SelectedDate.Value.Date.ToShortDateString();
            TimeCreated = DateCreatedpicker.SelectedDate.Value;
        }

        // due date task picker
        private void DateDuepicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateDueTextBox.Text = DateDuepicker.SelectedDate.Value.Date.ToShortDateString();
            TimeDue = DateDuepicker.SelectedDate.Value.Date;
        }

        // Onload event for editing task
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (EditMode)
            {
                TaskNameTextbox.Text = TaskName;
                DateDueTextBox.Text = TimeDue.ToString();
                DateCreatedTextBox.Text = TimeCreated.ToString();
                StatusTextBox.Text = TaskStatus.ToString();
            }
        }

        // combobox switch configuration
        private void StatusComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (StatusComboBox.SelectedIndex)
            {
                case 0:
                    StatusTextBox.Text = "0";
                    break;
                case 1:
                    StatusTextBox.Text = "1";
                    break;
                default:
                    //
                    break;
            }
        }
    }
}

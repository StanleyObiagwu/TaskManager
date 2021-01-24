using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager
{
    class Task
    {
        // Set task name parameters
        public string Name
        {
            get { return _name; }
            set
            {
                if ((value == "") && (value.Length < 1))
                {
                    throw new ArgumentException("Please use a Vailid Name");
                }
                _name = value;
            }
        }

        // Data created parameters 
        public DateTime DateCreated
        {
            get { return _dateCreated; }
            set
            {
                if (value < DateTime.Now)
                {
                    throw new ArgumentException("Invalid Date");
                }
                value = _dateCreated;
            }
        }

        // Date due parameters 
        public DateTime DateDue
        {
            get { return _dateDue; }
            set
            {
                if (value < DateCreated)
                {
                    throw new ArgumentException("Invalid Date");
                }
                value = _dateDue;
            }
        }

        // Set status parameters
        public int Status
        {
            get { return _status; }
            set
            {
                if (value != 0 || value != 1)
                {
                    throw new ArgumentException("Invalid Status number");

                }
            }
        }

        //instance variable access modifiers
        private string _name;
        private DateTime _dateCreated;
        private DateTime _dateDue;
        private int _status;

        public Task() { }

        public Task (string name, DateTime dateCreated, DateTime dateDue)
        {
            this._name = name;
            this._dateCreated = dateCreated;
            this._dateDue = dateDue;
            this._status = 0;
        }
        public Task(string name, DateTime dateCreated, DateTime dateDue, int status)
        {
            this._name = name;
            this._dateCreated = dateCreated;
            this._dateDue = dateDue;
            this._status = status;
        }

        public override string ToString()
        {
            return $"Name {_name} Date Created {_dateCreated.Date.ToShortDateString()} Date Due {_dateDue.Date.ToShortDateString()} Status {_status}";
        }

        // Format date and string result
        public virtual string ToFormattedString()
        {
            string thestring = "";
            thestring += $"{_name,2}";
            thestring += $" {_dateCreated.Date.ToShortDateString(),25}";
            thestring += $" {_dateDue.Date.ToShortDateString(),25}";
            thestring += $" {FormatStatus(Status),25}";

            return thestring;
        }

        // Task status check for complete and impcomplete task 
        private string FormatStatus(int status)
        {
            string newStatus;
            newStatus = status == 1 ? "Completed" : "Not Completed";
            return newStatus;
        }
    }
}

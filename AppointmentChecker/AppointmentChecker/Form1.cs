using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentChecker
{
    public partial class Form1 : Form
    {
        private List<Meeting> _meeting = new List<Meeting>();

        public Form1()
        {
            InitializeComponent();
            lstMeetings.DrawMode = DrawMode.OwnerDrawFixed;
            lstMeetings.DrawItem += lstMeetings_DrawItem;

            SetMinMaxDate();
        }


        private void dtEndDate_ValueChanged(object sender, EventArgs e)
        {
            SetMinMaxDate();
        }

        private void dtStartDate_ValueChanged(object sender, EventArgs e)
        {
            SetMinMaxDate();
        }

        private void SetMinMaxDate()
        {
            dtEndDate.MinDate = dtStartDate.Value;
            dtStartDate.MaxDate = dtEndDate.Value;
        }

        private void btnCheckAppointment_Click(object sender, EventArgs e)
        {
            var selectedStartDate = Convert.ToDateTime(dtStartDate.Value);
            var selectedEndDate = Convert.ToDateTime(dtEndDate.Value);

            lstMeetings.Items.Clear();
            bool hasOverlapped = false;
            foreach (var item in _meeting)
            {
                if ((selectedStartDate <= item.EndDate) && (item.StartDate <= selectedEndDate))
                {
                    lstMeetings.Items.Add(new MyListBoxItem(Color.Red, string.Format("{0} - {1}", item.StartDate, item.EndDate)));
                    hasOverlapped = true;
                }
                else
                {
                    lstMeetings.Items.Add(new MyListBoxItem(Color.Black, string.Format("{0} - {1}", item.StartDate, item.EndDate)));
                    hasOverlapped = false;
                }
            }


            if (hasOverlapped)
            {
                lstMeetings.Items.Add(new MyListBoxItem(Color.Red, string.Format("{0} - {1} (your selected date)", selectedStartDate, selectedEndDate)));
            }
            else
            {
                lstMeetings.Items.Add(new MyListBoxItem(Color.Black, string.Format("{0} - {1} (your selected date)", selectedStartDate, selectedEndDate)));
            }
        }


        private void lstMeetings_DrawItem(object sender, DrawItemEventArgs e)
        {
            MyListBoxItem item = lstMeetings.Items[e.Index] as MyListBoxItem; // Get the current item and cast it to MyListBoxItem
            if (item != null)
            {
                e.Graphics.DrawString( // Draw the appropriate text in the ListBox
                    item.Message, // The message linked to the item
                    lstMeetings.Font, // Take the font from the listbox
                    new SolidBrush(item.ItemColor), // Set the color 
                    0, // X pixel coordinate
                    e.Index * lstMeetings.ItemHeight // Y pixel coordinate.  Multiply the index by the ItemHeight defined in the listbox.
                );
            }
            else
            {
                // The item isn't a MyListBoxItem, do something about it
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _meeting.Clear();
            
            _meeting.Add(new Meeting()
            {
                //Jan 11th, 2016 10:00am – Jan 11th , 2016 1:30pm
                StartDate = new DateTime(2016, 01, 11, 10, 00, 00),
                EndDate = new DateTime(2016, 01, 11, 13, 30, 00)
            });
            _meeting.Add(new Meeting()
            {
                //Jan 11th, 2016 1:30pm – Jan 11th, 2016 4:00pm
                StartDate = new DateTime(2016, 01, 11, 13, 30, 00),
                EndDate = new DateTime(2016, 01, 11, 16, 30, 00)
            });
            _meeting.Add(new Meeting()
            {
                //Jan 5th, 2016 9:00am – Jan 5th, 2016 11:00am
                StartDate = new DateTime(2016, 01, 05, 09, 00, 00),
                EndDate = new DateTime(2016, 01, 05, 11, 00, 00)
            });
            _meeting.Add(new Meeting()
            {
                //Jan 5th, 2016 9:00am – Jan 5th, 2016 11:00am
                StartDate = new DateTime(2016, 01, 05, 09, 00, 00),
                EndDate = new DateTime(2016, 01, 05, 11, 00, 00)
            });
            _meeting.Add(new Meeting()
            {
                //Dec 29th, 2015 9:00am – Jan 1st, 2016 10:00am
                StartDate = new DateTime(2015, 12, 29, 09, 00, 00),
                EndDate = new DateTime(2016, 01, 01, 10, 00, 00)
            });

            foreach (var item in _meeting)
            {
                var startDate = item.StartDate.ToString("MMMM dd, yyyy hh:mm:tt");
                var endDate = item.EndDate.ToString("MMMM dd, yyyy hh:mm:tt");

                lstMeetings.Items.Add(new MyListBoxItem(Color.Black, string.Format("{0} - {1}", startDate, endDate)));
            }
        }
    }
}

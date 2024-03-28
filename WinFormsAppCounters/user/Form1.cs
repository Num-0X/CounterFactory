using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using WinFormsAppCounters.bus;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppCounters.user
{
    public partial class Form1 : Form
    {
        List<Counter> listOfcounters = new List<Counter>();
        Counter currentCounter;
        Date currentDate;
        int month, day, year;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            currentDate = new Date();
            currentCounter = new Counter();
            EnumColor color;
            Enum.TryParse(this.comboBoxColor.Text, out color);

            if (this.textBoxNumber.Text != "" && this.textBoxValue.Text != "" && this.textBoxMonth.Text != "" && this.textBoxDay.Text != "" && this.textBoxYear.Text != "")
            {
                currentDate.Month = Convert.ToInt32(this.textBoxMonth.Text);
                currentDate.Day = Convert.ToInt32(this.textBoxDay.Text);
                currentDate.Year = Convert.ToInt32(this.textBoxYear.Text);

                currentCounter.Number = Convert.ToInt32(this.textBoxNumber.Text);
                currentCounter.Value = Convert.ToInt32(this.textBoxValue.Text);



            }
            else
            {
                MessageBox.Show("You must input the data");
                this.textBoxNumber.Focus();
            }
            try
            {

                currentDate.Month = Convert.ToInt32(this.textBoxMonth.Text);
                currentDate.Day = Convert.ToInt32(this.textBoxDay.Text);
                currentDate.Year = Convert.ToInt32(this.textBoxYear.Text);

                currentCounter.Number = Convert.ToInt32(this.textBoxNumber.Text);
                currentCounter.Value = Convert.ToInt32(this.textBoxValue.Text);
                currentCounter.Color = color;





            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message + "You must input a valid data ");

                this.textBoxNumber.Focus();
            }



        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {

            if (listOfcounters.Count > 0 && this.listBoxCounter.Items.Count == 0)
            {
                foreach (Counter currentCounter in this.listOfcounters)
                {

                    this.listBoxCounter.Items.Add(currentCounter.GetCounterState());

                }


            }
            else
            {
                MessageBox.Show("The list of Conuter must be full or empty");
            }



        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            bool found = false;
            Counter foundcounter = new Counter();

            foreach (Counter item in this.listOfcounters)
            {
                if (item.Number == Convert.ToInt32(this.textBoxNumber.Text))
                {
                    found = true;
                    foundcounter = item;
                    break;


                }
                if (found)
                {
                    this.listBoxCounter.Items.Add(foundcounter.GetCounterState());
                }
                else
                {
                    MessageBox.Show("Counter not found ", "Event Programing C#", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (index > 0) 
            { 
                this.listOfcounters.RemoveAt(index);


                this.listBoxCounter.Items.Clear();
            }
            else 
            {
                MessageBox.Show("Choose from the list the counter to delete ");
            }


        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if(index > 0) 
            {

                this.listOfcounters[index].Number = Convert.ToInt32(this.textBoxNumber.Text);
                this.listOfcounters[index].Value = Convert.ToInt32(this.textBoxValue.Text);
                EnumColor color;
                Enum.TryParse(this.comboBoxColor.Text,out color);

                this.listOfcounters[index].Color = color;

                currentDate = new Date();
                currentDate.Month = Convert.ToInt32(this.textBoxMonth.Text);
                currentDate.Day = Convert.ToInt32(this.textBoxDay.Text);
                currentDate.Year = Convert.ToInt32(this.textBoxYear.Text);

                this.listBoxCounter.Items.Clear();
                
            }
            else
            {
                MessageBox.Show("Choose from the listcounter a counter to update ");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application written by Amos Bayanak", "Event Programing ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (EnumColor item in Enum.GetValues(typeof(EnumColor)))
            {
                this.comboBoxColor.Items.Add(item);
            }
            this.comboBoxColor.Text = Convert.ToString(this.comboBoxColor.Text);
        }
        int index = 1;
        private void listBoxCounter_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = listBoxCounter.SelectedIndex;

            this.textBoxNumber.Enabled = false;

            this.textBoxNumber.Text = Convert.ToString(this.listOfcounters[index].Number);
            this.textBoxValue.Text = Convert.ToString(this.listOfcounters[index].Value);
            comboBoxColor.Text = Convert.ToString(this.listOfcounters[index].Color);
        }
    }
}

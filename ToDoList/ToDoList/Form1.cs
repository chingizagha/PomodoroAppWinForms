using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : MaterialForm
    {
        TimeCounter firstTimer = new TimeCounter();
        bool isStarted = false;
        TimeSpan secondsRemaining;
        bool isCompleted = false;
        DateTime dt;
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue900, Primary.Blue500, Accent.Blue400, TextShade.WHITE);
        }

        MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;

        private void timer1_Tick(object sender, EventArgs e)
        {
            secondsRemaining = firstTimer.LeftTime - DateTime.Now;

            labelTime.Text = secondsRemaining.ToString("hh':'mm':'ss");

            if (secondsRemaining.TotalSeconds <= 0)
            {
                timer1.Stop();
                isCompleted = false;
                if(timeDataGridView.Rows[0].Cells[0].Value == DBNull.Value)
                {
                    timeDataGridView.Rows.RemoveAt(0);
                }
                startButton.Text = "Start";
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!isCompleted)
            {
                if (timeDataGridView.Rows[0].Cells[0].Value == DBNull.Value)
                {
                    MessageBox.Show("Data not added", "Error");
                }
                else
                {
                    firstTimer.Seconds = Convert.ToInt32(timeDataGridView.Rows[0].Cells[0].Value);
                    firstTimer.AddSecondsToLeftTime();
                    timer1.Start();
                    startButton.Text = "Pause";
                    isStarted = true;
                    isCompleted = true;
                }
            }
            else if (!isStarted && isCompleted)
            {
                dt = DateTime.Now + secondsRemaining;
                firstTimer.LeftTime = dt;
                timer1.Start();
                startButton.Text = "Pause";
                isStarted = true;
            }
            else if (isStarted && isCompleted)
            {
                startButton.Text = "Resume";
                timer1.Stop();
                isStarted = false;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(textBoxAdd.Text, out parsedValue))
            {
                MessageBox.Show("This is a number only field", "Invalid input");
                return;
            }

            timeDataGridView.Rows.Add(textBoxAdd.Text);
            textBoxAdd.Text = "";
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            labelTime.Text = "00:00:00";
            secondsRemaining = DateTime.Now - DateTime.Now;
            startButton.Text = "Start";
            isCompleted = false;
        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void materialRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ColorScheme = new ColorScheme(Primary.Green700, Primary.Green900, Primary.Green500, Accent.Green400, TextShade.WHITE);
        }

        private void materialRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue900, Primary.Blue500, Accent.Blue400, TextShade.WHITE);
        }

        private void materialRadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ColorScheme = new ColorScheme(Primary.Purple700, Primary.Purple900, Primary.Purple500, Accent.Purple400, TextShade.WHITE);
        }

        private void materialRadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ColorScheme = new ColorScheme(Primary.Orange700, Primary.Orange900, Primary.Orange500, Accent.Orange400, TextShade.WHITE);
        }

        private void timeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == timeDataGridView.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == timeDataGridView.Columns["Remove"].Index)
            {
                timeDataGridView.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}

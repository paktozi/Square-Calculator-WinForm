

using Square_Meter.Models;
using Square_Meter.Storage;

namespace Square_Meter
{
    public partial class Form1 : Form
    {
        Wall wall;
        WallStorage wallStorage = new();
        Window window;
        WindowStorage windowStorage = new();
        Reveal reveal;
        RevealStorage revealStorage = new();

        double height;
        double width;
        double winReveal;
        double result;
        string total = string.Empty;
        bool isEmptyHeight = true;
        bool isEmptyWidth = true;
        bool isEmptyReveal = true;
        bool totalButtonIsPressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (heightInputBox.Focused && totalButtonIsPressed)
            {
                resultBox.Clear();
                totalRevealsBox.Clear();
                totalWindowsBox.Clear();
                totalWallsBox.Clear();
                totalButtonIsPressed = false;
                wallCheckButton.Checked = true;
            }

            if (!string.IsNullOrWhiteSpace(heightInputBox.Text))
            {
                if (double.TryParse(heightInputBox.Text, out height))
                {
                    height = double.Parse(heightInputBox.Text);
                    isEmptyHeight = false;
                }
                else
                {
                    MessageBox.Show("Invalid value for Height.");
                    heightInputBox.Text = string.Empty;
                }
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(widthInputBox.Text))
            {
                if (double.TryParse(widthInputBox.Text, out width))
                {
                    width = double.Parse(widthInputBox.Text);
                    isEmptyWidth = false;
                }
                else
                {
                    MessageBox.Show("Invalid value for Width.");
                    widthInputBox.Text = string.Empty;
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(revealInputBox.Text))
            {
                if (double.TryParse(revealInputBox.Text, out winReveal))
                {
                    winReveal = double.Parse(revealInputBox.Text);
                    isEmptyReveal = false;
                }
                else
                {
                    MessageBox.Show("Invalid value for Reveal.");
                    revealInputBox.Text = string.Empty;
                }
            }
        }

        private void CalculateButtonClick(object sender, EventArgs e)              // Calculate button
        {
            if (wallCheckButton.Checked && !isEmptyHeight && !isEmptyWidth)
            {
                wall = new Wall(double.Parse(heightInputBox.Text), double.Parse(widthInputBox.Text));            //  Create new wall
                wallStorage.AddWall(wall);                                                         //add wall to storage                               
                resultBox.AppendText(wall.GetSquareMeters() + Environment.NewLine);       // print sum of wall
                totalWallsBox.Text = wallStorage.GetAllWallSum().ToString() + "m²";
            }
            else if (windowCheckButton.Checked && !isEmptyHeight && !isEmptyWidth)
            {
                window = new Window(double.Parse(heightInputBox.Text), double.Parse(widthInputBox.Text));
                windowStorage.AddWindow(window);
                resultBox.SelectionColor = Color.Blue;
                resultBox.AppendText(window.GetSquareMeters() + Environment.NewLine);
                totalWindowsBox.Text = windowStorage.GetAllWindowsSum().ToString() + "m²";
            }
            else if (revealCheckButton.Checked && !isEmptyHeight && !isEmptyWidth && !isEmptyReveal)
            {
                window = new Window(double.Parse(heightInputBox.Text), double.Parse(widthInputBox.Text));
                windowStorage.AddWindow(window);
                double revealValue = double.Parse(revealInputBox.Text);
                double revealSum = Math.Round((window.Height * revealValue) * 2 + (window.Width * revealValue), 2);
                Reveal reveal = new Reveal(revealSum);
                revealStorage.AddReveal(reveal);
                resultBox.SelectionColor = Color.Blue;

                resultBox.AppendText(window.GetSquareMeters() + Environment.NewLine);
                resultBox.SelectionColor = Color.Green;
                resultBox.AppendText(revealSum.ToString() + "m²" + Environment.NewLine);
                totalWindowsBox.Text = windowStorage.GetAllWindowsSum().ToString() + "m²";
                totalRevealsBox.Text = revealStorage.GetAllRevealSum().ToString() + "m²";
            }
            heightInputBox.Clear();
            widthInputBox.Clear();
            revealInputBox.Clear();
            heightInputBox.Focus();
            isEmptyHeight = true;
            isEmptyWidth = true;
            isEmptyReveal = true;
        }

        private void ResetButtonClick(object sender, EventArgs e) // Reset all
        {
            windowStorage.ClearStorage();
            wallStorage.ClearStorage();
            revealStorage.ClearStorage();
            resultBox.Clear();
            totalRevealsBox.Clear();
            totalWindowsBox.Clear();
            totalWallsBox.Clear();
            heightInputBox.Focus();
        }

        private void ClearButtonClick(object sender, EventArgs e) // Clear
        {
            resultBox.Clear();
            heightInputBox.Focus();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void TotalButtonClick(object sender, EventArgs e)    //  Total button
        {
            double totalSum = 0;
            if (wallStorage.GetAllWallSum() > windowStorage.GetAllWindowsSum())
            {
                totalSum = Math.Round(((wallStorage.GetAllWallSum() - windowStorage.GetAllWindowsSum()) + revealStorage.GetAllRevealSum()), 2);
            }

            if (wallStorage.GetAllWallSum() != 0 && wallStorage.GetAllWallSum() > windowStorage.GetAllWindowsSum())
            {
                resultBox.AppendText("------------------------" + Environment.NewLine);
                resultBox.AppendText("Total:" + Environment.NewLine);
                resultBox.SelectionColor = Color.Red;
                resultBox.AppendText(totalSum.ToString() + "m²" + Environment.NewLine);       // print wall square          
                totalWallsBox.Text = totalSum.ToString() + "m²";
                totalRevealsBox.Text = string.Empty;

                //string date = DateTime.Now.ToString("dd/MM/yyyy");                //Write to text file
                //string time = DateTime.Now.ToString("HH mm");
                //using (StreamWriter sr = new StreamWriter(@$"{date} {time}.txt"))             
                //{
                //    sr.WriteLine("Walls area: " + wallStorage.GetAllWallSum() + "m²");
                //    sr.WriteLine("Total Windows area: " + windowStorage.GetAllWindowsSum() + "m²");
                //    sr.WriteLine("Added Windows reveals: " + revealStorage.GetAllRevealSum() + "m²");
                //    sr.WriteLine("-------------------------");
                //    sr.WriteLine("Total Walls area to paint: " + totalSum.ToString() + "m²");
                //}
            }
            windowStorage.ClearStorage();                            //    Clear Value from windows,walls,reveals.
            wallStorage.ClearStorage();
            revealStorage.ClearStorage();
            totalButtonIsPressed = true;
        }

        private void wallButton_CheckedChanged(object sender, EventArgs e)   //wall checked button
        {
            if (wallCheckButton.Checked)
            {
                windowCheckButton.Checked = false;
                revealCheckButton.Checked = false;
                heightInputBox.Focus();
            }
        }

        private void windowButton_CheckedChanged(object sender, EventArgs e)
        {
            if (windowCheckButton.Checked)
            {
                wallCheckButton.Checked = false;
                revealCheckButton.Checked = false;
                heightInputBox.Focus();
            }
        }

        private void revealButton_CheckedChanged(object sender, EventArgs e)
        {
            revealInputBox.Visible = revealCheckButton.Checked;
            label6.Visible = revealCheckButton.Checked;
            label7.Visible = revealCheckButton.Checked;

            if (revealCheckButton.Checked)
            {
                wallCheckButton.Checked = false;
                windowCheckButton.Checked = false;
                heightInputBox.Focus();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void totalWallsBox_TextChanged(object sender, EventArgs e)
        {
            totalWallsBox.ReadOnly = true;
        }

        private void totalWindowsBox_TextChanged(object sender, EventArgs e)
        {
            totalWindowsBox.ReadOnly = true;
        }

        private void totalRevealsBox_TextChanged(object sender, EventArgs e)
        {
            totalRevealsBox.ReadOnly = true;
        }
    }
}
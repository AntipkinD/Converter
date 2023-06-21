using System.Collections;
using System.Reflection;

namespace Converter
{
    public partial class Converter : Form
    {
        bool sex = false;
        bool defaultpose = true;
        public Converter()
        {
            InitializeComponent();
            comBoxChange(defaultpose);
        }
        Dictionary<double, double> wSizes = new Dictionary<double, double>
            {
                { 34.0, 21.0 },
                { 34.5, 22.0 },
                { 35.0, 22.5 },
                { 36.0, 23.0 },
                { 36.5, 23.5 },
                { 37.0, 24.0 },
                { 37.5, 25.0 },
                { 38.0, 25.5 },
                { 38.5, 26.0 },
                { 39.0, 26.5 },
                { 40.0, 27.0 },
                { 40.5, 28.0 },
                { 41.0, 28.5 },
                { 42.0, 29.0 },
                { 42.5, 29.5 },
                { 43.0, 30.0 }
            };
        Dictionary<double, double> wSizesReversed = new Dictionary<double, double>
            {
                { 21.0, 34.0 },
                { 22.0, 34.5 },
                { 22.5, 35.0 },
                { 23.0, 36.0 },
                { 23.5, 36.5 },
                { 24.0, 37.0 },
                { 25.0, 37.5 },
                { 25.5, 38.0 },
                { 26.0, 38.5 },
                { 26.5, 39.0 },
                { 27.0, 40.0 },
                { 28.0, 40.5 },
                { 28.5, 41.0 },
                { 29.0, 42.0 },
                { 29.5, 42.5 },
                { 30.0, 43.0 }
            };
        Dictionary<double, double> mSizes = new Dictionary<double, double>
            {
                {38.0, 23.0 },
                {38.5, 23.5 },
                {39.0, 24.0 },
                {40.0, 25.0 },
                {40.5, 26.0 },
                {41.0, 26.5 },
                {42.0, 27.0 },
                {43.0, 28.0 },
                {43.5, 29.0 },
                {44.0, 29.5 },
                {45.0, 30.0 },
                {45.5, 30.5 },
                {46.0, 31.0 },
                {46.5, 32.0 },
                {47.0, 32.5 },
                {48.0, 33.0 }
            };
        Dictionary<double, double> mSizesReversed = new Dictionary<double, double>
            {
                {23.0, 38.0 },
                {23.5, 38.5 },
                {24.0, 39.0 },
                {25.0, 40.0 },
                {26.0, 40.5 },
                {26.5, 41.0 },
                {27.0, 42.0 },
                {28.0, 43.0 },
                {29.0, 43.5 },
                {29.5, 44.0 },
                {30.0, 45.0 },
                {30.5, 45.5 },
                {31.0, 46.0 },
                {32.0, 46.5 },
                {32.5, 47.0 },
                {33.0, 48.0 }
            };

        void comBoxChange(bool defaultpose)
        {
            switch (defaultpose)
            {
                case (true):
                    if (sex == false)
                    {
                        BindingSource bindSRC = new BindingSource(mSizes.Keys, null);
                        comboBox1.DataSource = bindSRC;
                        comboBox1.Refresh();
                    }
                    else
                    {
                        BindingSource bindSRC = new BindingSource(wSizes.Keys, null);
                        comboBox1.DataSource = bindSRC;
                        comboBox1.Refresh();
                    }
                    break;
                case (false):
                    if (sex == false)
                    {
                        BindingSource bindSRC = new BindingSource(mSizesReversed.Keys, null);
                        comboBox1.DataSource = bindSRC;
                        comboBox1.Refresh();
                    }
                    else
                    {
                        BindingSource bindSRC = new BindingSource(wSizesReversed.Keys, null);
                        comboBox1.DataSource = bindSRC;
                        comboBox1.Refresh();
                    }
                    break;
            }

        }
        internal void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        internal void label1_Click(object sender, EventArgs e)
        {

        }

        internal void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sex = false;
            comboBox1.Sorted = false;
            label3.Text = "";
            comBoxChange(defaultpose);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sex = true;
            comboBox1.Sorted = false;
            label3.Text = "";
            comBoxChange(defaultpose);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (defaultpose == true)
            {
                if (sex == false)
                    label3.Text = Convert.ToString(mSizes[Convert.ToDouble(comboBox1.Text)]);
                if (sex == true)
                    label3.Text = Convert.ToString(wSizes[Convert.ToDouble(comboBox1.Text)]);
            }

            if (defaultpose == false)
            {
                if (sex == false)
                    label3.Text = Convert.ToString(mSizesReversed[Convert.ToDouble(comboBox1.Text)]);
                if (sex == true)
                    label3.Text = Convert.ToString(wSizesReversed[Convert.ToDouble(comboBox1.Text)]);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (defaultpose)
            {
                case (false):
                    defaultpose = true;
                    label1.Text = "Русский размер";
                    label2.Text = "Японский размер";
                    label3.Text = "";
                    break;
                case (true):
                    defaultpose = false;
                    label2.Text = "Русский размер";
                    label1.Text = "Японский размер";
                    label3.Text = "";
                    break;
            }
            radioButton2_CheckedChanged(sender, e);
            radioButton1_CheckedChanged(sender, e);
            comBoxChange(defaultpose);
        }
    }
}
namespace lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialogButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pathTextBox.Text = openFileDialog1.FileName;
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            if (radioBtnWithoutFilters.Checked == false && radioBtnSelective.Checked == false)
                MessageBox.Show("Вы не выбрали фильтр");

            try
            {
                using (StreamReader reader = new StreamReader(pathTextBox.Text))
                {
                    string text = reader.ReadToEnd();
                    string[] rows = text.Split('\r');

                    using (StreamWriter writerValues = new StreamWriter("values.txt"))
                    {
                        using (StreamWriter writerResults = new StreamWriter("results.txt"))
                        {
                            if (radioBtnWithoutFilters.Checked || 
                                (checkBoxNumbers.Checked && checkBoxPlusMinus.Checked && checkBoxText.Checked)) //all filters
                            {
                                if (letterTextBox.Text == "")
                                {
                                    MessageBox.Show("Введите букву фильтрации");
                                    return;
                                }

                                for (int i = 0; i < rows.Length; i++)
                                {
                                    rows[i] = rows[i].Trim();
                                    string[] values = rows[i].Split(' ');

                                    foreach (string value in values)
                                    {
                                        bool isPlusMinus = true;
                                        int option = 0;
                                        if (radioBtnUpperRegistr.Checked)
                                            option = 1;
                                        else if (radioBtnLowerRegistr.Checked)
                                            option = 2;

                                        double numb;
                                        if (double.TryParse(value, out numb))
                                        {
                                            writerValues.Write(value + " ");
                                            writerResults.Write("true ");
                                        }
                                        else if(value.Contains(letterTextBox.Text.ToLower())
                                            || value.Contains(letterTextBox.Text.ToUpper()))
                                        {
                                            if (option == 0)
                                                writerValues.Write(value + " ");
                                            else if (option == 1)
                                                writerValues.Write(value.ToUpper() + " ");
                                            else
                                                writerValues.Write(value.ToLower() + " ");
                                            writerResults.Write("true ");
                                        }
                                        else
                                        {
                                            foreach (var symb in value)
                                            {
                                                if (symb == '+' || symb == '-')
                                                    continue;
                                                isPlusMinus = false;
                                            }

                                            if (isPlusMinus)
                                            {
                                                writerValues.Write(value + " ");
                                                writerResults.Write("true ");
                                            }
                                            else
                                            {
                                                writerValues.Write("пусто ");
                                                writerResults.Write("false ");
                                            }
                                        }
                                    }
                                    writerValues.WriteLine();
                                    writerResults.WriteLine();
                                }
                            }
                            else if (checkBoxPlusMinus.Checked && checkBoxText.Checked) //+/- with text
                            {
                                if (letterTextBox.Text == "")
                                {
                                    MessageBox.Show("Введите букву фильтрации");
                                    return;
                                }

                                for (int i = 0; i < rows.Length; i++)
                                {
                                    rows[i] = rows[i].Trim();
                                    string[] values = rows[i].Split(' ');

                                    foreach (string value in values)
                                    {
                                        bool isPlusMinus = true;
                                        int option = 0;
                                        if (radioBtnUpperRegistr.Checked)
                                            option = 1;
                                        else if (radioBtnLowerRegistr.Checked)
                                            option = 2;

                                        if (value.Contains(letterTextBox.Text.ToLower())
                                            || value.Contains(letterTextBox.Text.ToUpper()))
                                        {
                                            if (option == 0)
                                                writerValues.Write(value + " ");
                                            else if (option == 1)
                                                writerValues.Write(value.ToUpper() + " ");
                                            else
                                                writerValues.Write(value.ToLower() + " ");
                                            writerResults.Write("true ");
                                        }
                                        else
                                        {
                                            foreach (var symb in value)
                                            {
                                                if (symb == '+' || symb == '-')
                                                    continue;
                                                isPlusMinus = false;
                                            }

                                            if (isPlusMinus)
                                            {
                                                writerValues.Write(value + " ");
                                                writerResults.Write("true ");
                                            }
                                            else
                                            {
                                                writerValues.Write("пусто ");
                                                writerResults.Write("false ");
                                            }
                                        }                                      
                                    }

                                    writerValues.WriteLine();
                                    writerResults.WriteLine();
                                }
                            }
                            else if (checkBoxNumbers.Checked && checkBoxText.Checked) //numbers with text
                            {
                                if (letterTextBox.Text == "")
                                {
                                    MessageBox.Show("Введите букву фильтрации");
                                    return;
                                }

                                for (int i = 0; i < rows.Length; i++)
                                {
                                    rows[i] = rows[i].Trim();
                                    string[] values = rows[i].Split(' ');

                                    double numb = 0;
                                    int option = 0;
                                    if (radioBtnUpperRegistr.Checked)
                                        option = 1;
                                    else if (radioBtnLowerRegistr.Checked)
                                        option = 2;

                                    foreach (string value in values)
                                    {
                                        if (value.Contains(letterTextBox.Text.ToLower())
                                            || value.Contains(letterTextBox.Text.ToUpper()))
                                        {
                                            if (option == 0)
                                                writerValues.Write(value + " ");
                                            else if (option == 1)
                                                writerValues.Write(value.ToUpper() + " ");
                                            else
                                                writerValues.Write(value.ToLower() + " ");
                                            writerResults.Write("true ");
                                        }
                                        else if (double.TryParse(value, out numb))
                                        {
                                            writerValues.Write(value + " ");
                                            writerResults.Write("true ");
                                        }
                                        else
                                        {
                                            writerValues.Write("пусто ");
                                            writerResults.Write("false ");
                                        }
                                    }

                                    writerValues.WriteLine();
                                    writerResults.WriteLine();
                                }
                            }
                            else if (checkBoxNumbers.Checked && checkBoxPlusMinus.Checked) //numbers with +/-  
                            {
                                double numb = 0;
                                for (int i = 0; i < rows.Length; i++)
                                {
                                    rows[i] = rows[i].Trim();
                                    string[] values = rows[i].Split(' ');

                                    foreach (string value in values)
                                    {
                                        bool isPlusMinus = true;

                                        foreach (var symb in value)
                                        {
                                            if (symb == '+' || symb == '-')
                                                continue;
                                            isPlusMinus = false;
                                        }

                                        if (double.TryParse(value, out numb) || isPlusMinus)
                                        {
                                            writerValues.Write(value + " ");
                                            writerResults.Write("true ");
                                        }
                                        else
                                        {
                                            writerValues.Write("пусто ");
                                            writerResults.Write("false ");
                                        }
                                    }
                                    writerValues.WriteLine();
                                    writerResults.WriteLine();
                                }
                            }
                            else if (checkBoxNumbers.Checked) //only numbers
                            {
                                for (int i = 0; i < rows.Length; i++)
                                {
                                    rows[i] = rows[i].Trim();
                                    string[] values = rows[i].Split(' ');

                                    foreach (string value in values)
                                    {
                                        double numb;
                                        if (double.TryParse(value, out numb))
                                        {
                                            writerValues.Write(value + " ");
                                            writerResults.Write("true ");
                                        }
                                        else
                                        {
                                            writerValues.Write("пусто ");
                                            writerResults.Write("false ");
                                        }
                                    }
                                    writerValues.WriteLine();
                                    writerResults.WriteLine();
                                }
                            }
                            else if (checkBoxPlusMinus.Checked) //only +/-
                            {
                                for (int i = 0; i < rows.Length; i++)
                                {
                                    rows[i] = rows[i].Trim();
                                    string[] values = rows[i].Split(' ');

                                    foreach (string value in values)
                                    {
                                        bool isPlusMinus = true;

                                        foreach (var symb in value)
                                        {
                                            if (symb == '+' || symb == '-')
                                                continue;
                                            isPlusMinus = false;
                                        }

                                        if (isPlusMinus)
                                        {
                                            writerValues.Write(value + " ");
                                            writerResults.Write("true ");
                                        }
                                        else
                                        {
                                            writerValues.Write("пусто ");
                                            writerResults.Write("false ");
                                        }
                                    }

                                    writerValues.WriteLine();
                                    writerResults.WriteLine();
                                }
                            }
                            else if (checkBoxText.Checked) // only text with letter
                            {
                                if (letterTextBox.Text == "")
                                {
                                    MessageBox.Show("Введите букву фильтрации");
                                    return;
                                }

                                for (int i = 0; i < rows.Length; i++)
                                {
                                    rows[i] = rows[i].Trim();
                                    string[] values = rows[i].Split(' ');

                                    int option = 0;
                                    if (radioBtnUpperRegistr.Checked)
                                        option = 1;
                                    else if (radioBtnLowerRegistr.Checked)
                                        option = 2;

                                    foreach (string value in values)
                                    {
                                        if (value.Contains(letterTextBox.Text.ToLower()) 
                                            || value.Contains(letterTextBox.Text.ToUpper()))
                                        {
                                            if (option == 0)
                                                writerValues.Write(value + " ");
                                            else if (option == 1)
                                                writerValues.Write(value.ToUpper() + " ");
                                            else 
                                                writerValues.Write(value.ToLower() + " ");
                                            writerResults.Write("true ");
                                        }
                                        else
                                        {
                                            writerValues.Write("пусто ");
                                            writerResults.Write("false ");
                                        }
                                    }

                                    writerValues.WriteLine();
                                    writerResults.WriteLine();
                                }
                            } 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return;
            }

            MessageBox.Show("Фильтрация прошла успешно");
        }

        private void radioBtnSelective_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxNumbers.Enabled = true;
            checkBoxPlusMinus.Enabled = true;
            checkBoxText.Enabled = true;
            radioBtnDefault.Enabled = false;
            radioBtnLowerRegistr.Enabled = false;
            radioBtnUpperRegistr.Enabled = false;
            if (checkBoxText.Checked)
                groupBox1.Enabled = true;
        }

        private void radioBtnWithoutFilters_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            radioBtnDefault.Enabled = true;
            radioBtnLowerRegistr.Enabled = true;
            radioBtnUpperRegistr.Enabled = true;
            checkBoxNumbers.Enabled = false;
            checkBoxPlusMinus.Enabled = false;
            checkBoxText.Enabled = false;
        }

        private void checkBoxText_CheckStateChanged(object sender, EventArgs e)
        {
            if (false == checkBoxText.Checked)
            {
                groupBox1.Enabled = false;
                radioBtnDefault.Enabled = false;
                radioBtnLowerRegistr.Enabled = false;
                radioBtnUpperRegistr.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = true;
                radioBtnDefault.Enabled = true;
                radioBtnLowerRegistr.Enabled = true;
                radioBtnUpperRegistr.Enabled = true;
            }
        }
    }
}
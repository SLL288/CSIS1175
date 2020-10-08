using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Assign_Sales_total
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            depositeCheck.Checked = true;
            //Form1.Size = new System.Drawing.Size(100, 100);
        }

        public void showError(string str)
        {   
            MessageBox.Show(str);
        }

        private void processButton_Click(object sender, EventArgs e)
        {

            var firstname = firstnameTextbox.Text;
            var lastname = lastnameTextbox.Text;

            var name = firstname + lastname;

            string[] lines = System.IO.File.ReadAllLines(Application.StartupPath+"/Customer.dat");
            string content = "";
            string[] datalines = System.IO.File.ReadAllLines(Application.StartupPath + "/Transaction.dat");

            StreamWriter logfile;

            decimal amount = 0;
            decimal total = 0;
            bool error = false;
            bool user = false;
            //logfile = File.CreateText("TransactionError.dat");
            logfile = File.AppendText("TransactionError.dat");

            for (int i = 0; i < lines.Length; i += 1)
            {
                if (String.Compare(name, lines[i], false) == 0)
                {
                    user = true;
                    if (content == "")
                    {
                        content = lines[i].ToLower() + "\n";
                        content += "========================================\n";
                   
                    }
                    //string client = datalines[i];
                    if (depositeCheck.Checked == true)
                    {

                        try
                        {
                            total += decimal.Parse(datalines[i]);

                            if (decimal.Parse(datalines[i]) > 0)
                            {
                                amount += decimal.Parse(datalines[i]);
                                content += datalines[i] + "\n";
                            }
                        }
                        catch
                        {
                            error = true;
                            showError("Error Data");
                            logfile.WriteLine(lines[i] + " " + datalines[i]);
                        }
                        
  
                        
                    }
                    else
                    {

                        try
                        {
                            total += decimal.Parse(datalines[i]);

                            if (decimal.Parse(datalines[i]) < 0)
                            {
                                amount += decimal.Parse(datalines[i]);

                                content += amount.ToString("C2") + "\n";
                            }
                        }
                        catch
                        {
                            error = true;
                            showError("Error Data");
                            logfile.WriteLine(lines[i] + " " + datalines[i]);

                        }


                    }




                }

            }


 
            if (user == true)
            {

                content += "========================================\n";
                if ((user == true) && (depositeCheck.Checked == true))
                {
                    content += "Total Deposite: " + amount.ToString("C2") + "\n";
                    content += "Total Amount: " + total.ToString("C2");
                    contentTextbox.Text = content;
                }
                else if ((user == true) && (withdrawCheck.Checked == true))
                {
                    content += "Total Withdraw: " + amount.ToString("C2") + "\n";
                    content += "Total Amount: " + total.ToString("C2");
                    contentTextbox.Text = content;
                }

                if (error == true)
                {
                    totalBox.Text = total.ToString();
                    totalBox.BackColor = System.Drawing.Color.Red;
                    totalBox.ForeColor = System.Drawing.Color.Black;
                }

            }
            else
            {
                content = name + "\n";
                content += "========================================\n";
                contentTextbox.Text = content;
            }



            logfile.Close();

            //}
            //catch
            //{
            //    showError();
            //}


        }

        private void withdrawCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (withdrawCheck.Checked)
            {
                depositeCheck.Checked = false;

            }
        }

        private void depositeCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (depositeCheck.Checked)
            {
                withdrawCheck.Checked = false;
            }
        }

        private void showresult() 
        {

            //contentTextbox.Text = Application.StartupPath;
            //Console.WriteLine(Application.StartupPath);
            //Console.WriteLine(lines[1]);
            //contentTextbox.Text = lines[1];
           
        }
    }
}

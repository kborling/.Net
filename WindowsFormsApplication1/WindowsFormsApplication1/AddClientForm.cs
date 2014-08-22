/*
 * Kevin Borling
 * CSCD 306 | .Met Programming
 * WinForm Dating Service Part 2
 * 07/22/2013
 * AddClientForm allows the user to add a new client by entering data including... Name, Age, Interests, Favorite Color, and Gender
 * Was unable to figure out how to add an image properly.
 * Attempted to assign each photo 'MysteryDate', but I couldn't get it to work.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AddClientForm : Form
    {
        public static System.Resources.ResourceManager resources;

        public AddClientForm()
        {
            InitializeComponent();
        }

        private void AddClientForm_Load(object sender, EventArgs e)
        {
           
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }// End Cancel Button Click

        private void addclient_Click(object sender, EventArgs e)
        {
            Image i;

            DataRow row;
            row = DatingForm.ClientTable.NewRow();
            row["Name"] = fname.Text + " " + lname.Text;
            if (FemaleButton.Checked == true)
            {
                row["Sex"] = "F";
            }
            if (MaleButton.Checked == true)
            {
                row["Sex"] = "M";
            }
            
            row["Age"] = age.Value;
            row["Hobby"] = ActivityBox.SelectedItem.ToString();
            row["Other"] = OtherBox.SelectedItem.ToString();
            row["Favorite Color"] = ColorBox.SelectedItem.ToString();



            if (Picture.Text.ToString() != "")
            {
                row["Photo"] = Picture.Text.ToString();
            }
            else
            {
                row["Photo"] = "MysteryDate";
            }

            row["Client ID"] = DatingForm.ID;
            DatingForm.ID++;
            DatingForm.ClientTable.Rows.Add(row);
            this.Close();
        }// End Add New Client

    }
}

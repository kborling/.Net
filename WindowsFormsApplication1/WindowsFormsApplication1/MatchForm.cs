/*
 * Kevin Borling
 * CSCD 306 | .Met Programming
 * WinForm Dating Service Part 2
 * 07/22/2013
 * MatchFrom presents the Client being matched, along with top 3 matches.
 * It shows the Main Clients full photo, along with each of the matches thumbnail, along with there full name
 * I was unable to figure out the timer sequence for loading each match thumbnail image..
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
    public partial class MatchForm : Form
    {
        public MatchForm(Client fish, Client shark1, Client shark2, Client shark3)
        {
            InitializeComponent();

            Image f, s1, s2, s3;

            f = (Image)(Bitmap)(DatingForm.resources.GetObject(DatingForm.photo));


            s1 = (Image)(Bitmap)(DatingForm.resources.GetObject(shark1.Photo + "t"));
            s2 = (Image)(Bitmap)(DatingForm.resources.GetObject(shark2.Photo + "t"));
            s3 = (Image)(Bitmap)(DatingForm.resources.GetObject(shark3.Photo + "t"));
            
            Bitmap img = (Bitmap)f;
            Bitmap img2 = (Bitmap)s1;
            Bitmap img3 = (Bitmap)s2;
            Bitmap img4 = (Bitmap)s3;


            // Client
            fishy.Image = img;

            // Matches
            sharky1.Image = img2;
            shark1Text.Text = "Best Match:\r\n" + shark1.Fname + " " + shark1.Lname;
            sharky2.Image = img3;
            shark2Text.Text = "Great Match:\r\n" + shark2.Fname + " " + shark2.Lname;
            sharky3.Image = img4;
            shark3Text.Text = "Good Match:\r\n" + shark3.Fname + " " + shark3.Lname;


            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                sharky1.Image = img2;
            });
            ClientMatchStatus.Text = "Here are the top 3 matches for " + fish.Fname + " " + fish.Lname + " based on age and common interest!";
        }

        private void okayClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

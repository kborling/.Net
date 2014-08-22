/*
 * Kevin Borling
 * CSCD 306 | .Met Programming
 * WinForm Dating Service Part 2
 * 07/22/2013
 * DatingForm Contains all of the Data Grid Information for each client.
 * All of the clients are stored in a Data Grid View.
 * DatingForm also contains the Image form, which is presented to the user upon clicking 'Show Full Photo' button, clicking on thumbnail image', or by selecting File > 'Show Full Photo'.
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
    public partial class DatingForm : Form
    {
        private Timer clock = new Timer();
        public static Clients fishtank;
        public static System.Resources.ResourceManager resources;
        public static DataTable ClientTable = new DataTable();
        public static String photo,name,age,hobby,other,color;
        public static int ID;

        public DatingForm()
        {

            Splash splash = new Splash();
            splash.Show();
            splash.Refresh();

            // Change To Current Directory for .accdb file
            fishtank = new Clients(@"C:\Users\Kevin\Dropbox\Visual Studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\DateABase.accdb");

            InitializeComponent();
            ClientTable.Columns.Clear();
            DataColumn name = new DataColumn("Name");
            DataColumn sex = new DataColumn("Sex");
            DataColumn age = new DataColumn("Age");
            DataColumn hobby = new DataColumn("Hobby");
            DataColumn other = new DataColumn("Other");
            DataColumn color = new DataColumn("Favorite Color");
            DataColumn photo = new DataColumn("Photo");
            DataColumn clientID = new DataColumn("Client ID");


            ClientTable.Columns.Add(name);
            ClientTable.Columns.Add(sex);
            ClientTable.Columns.Add(age);
            ClientTable.Columns.Add(hobby);
            ClientTable.Columns.Add(other);
            ClientTable.Columns.Add(color);
            ClientTable.Columns.Add(photo);
            ClientTable.Columns.Add(clientID);

            System.Threading.Thread.Sleep(2000);

            loadClientGrid();


            splash.Close();
        }
        // Loads DataGrid with Clients
        private void loadClientGrid()
        {
            ClientTable.Clear();
            fishtank.Reset();
            ID = 0;

            foreach (Client c in fishtank)
            {
                DataRow row;
                row = ClientTable.NewRow();
                row["Name"] = c.Fname + " " + c.Lname;
                row["Sex"] = c.Sex;
                row["Age"] = c.Age;
                row["Hobby"] = c.Hobby;
                row["Other"] = c.Other;
                row["Favorite Color"] = c.Color;
                row["Photo"] = c.Photo;
                row["Client ID"] = ID++;
                ClientTable.Rows.Add(row);
            }

            ClientGrid.DataSource = ClientTable;// Binds Data Table to Data Grid

  
            EventArgs e = new EventArgs();
            date_update(this, e);
            ClientGrid.Refresh();

        }// End loadClientGrid

        // Selects First Client at top of list
        private void Form1_Load(object sender, EventArgs e)
        {
            ClientGrid.Rows[0].Selected = true;
            DataGridViewCellEventArgs f = new DataGridViewCellEventArgs(1, 1);
            ClientGrid_CellContentClick_1(this, f);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowIndex = 0;
            Client fish = null;
            Client shark1 = null, shark2 = null, shark3 = null;

            rowIndex = ClientGrid.CurrentRow.Index;
            ClientGrid.Rows[rowIndex].Selected = true;
            rowIndex = int.Parse(ClientGrid[7, rowIndex].Value.ToString());
            fish = fishtank.GetAClient(rowIndex);
            fishtank.Reset();
            
            foreach (Client c in fishtank)
            {

                if (shark1 == null || (fish.Match(c) > fish.Match(shark1)))
                    shark1 = c;
                else if (shark1 == null || (fish.Match(c) > fish.Match(shark2)))
                    shark2 = c;
                else if (shark1 == null || (fish.Match(c) > fish.Match(shark3)))
                    shark3 = c;
            }

            MatchForm mf = new MatchForm(fish, shark1, shark2, shark3);
             
            mf.Show();
            
            this.Preview.Image = GetPicture(fish.Photo, "t");
            this.ShowFullPhoto.Enabled = true;

        }// End Match Client

        private void button4_Click(object sender, EventArgs e)
        {
            Image i;

            i = (Image)(Bitmap)(DatingForm.resources.GetObject(photo));

            if (i == null)
            {
                i = (Image)(Bitmap)(resources.GetObject("MysteryDate"));
            }

            Bitmap img = (Bitmap)i;


            using (Form Photo = new Form())
            {
                Photo.MaximizeBox = false;
                Photo.MinimizeBox = false;
                Photo.StartPosition = FormStartPosition.CenterScreen;
                Photo.Size = new System.Drawing.Size(i.Size.Width + 150, i.Size.Height + 30);
                PictureBox pic = new PictureBox();
                pic.Dock = DockStyle.Fill;
                pic.Image = img;
                Button butt = new Button();
                butt.Dock = DockStyle.Bottom;
                butt.Size = new System.Drawing.Size(10, 30);
                butt.Text = "OK";
                butt.Click += new EventHandler(butt_Click);
                TextBox text = new TextBox();
                text.Dock = DockStyle.Right;
                text.Size = new System.Drawing.Size(120, i.Size.Height);
                text.Multiline = true;
                text.Text = "Name:\r\n" + name + "\r\n\r\nAge:\r\n" + age + "\r\n\r\nHobbies:\r\n" + hobby + "\r\n" + other + "\r\n\r\nFavorite Color:\r\n" + color;
                text.Enabled = false;
                Photo.Controls.Add(pic);
                Photo.Controls.Add(text);
                Photo.Controls.Add(butt);
                Photo.ShowDialog();
                

            }
        }

        private void butt_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You may open full size image by clicking on the thumbnail, 'show full photo' button, or File > Show Full Photo from the dropdown menu.\n\nTo match a client, click 'Match Client' button. This will display the top 3 matches for the client based on age, common interest, and favorite color.\n\nClick 'Add new client' to enter all of the required information to add a new client to the database.");
        }
        // Thumbnail Image
        private void Preview_Click(object sender, EventArgs e)
        {
            Image i;

            i = (Image)(Bitmap)(DatingForm.resources.GetObject(photo));

            if (i == null)
            {
                i = (Image)(Bitmap)(resources.GetObject("MysteryDate"));
            }

            Bitmap img = (Bitmap)i;


            using (Form Photo = new Form())
            {
                Photo.MaximizeBox = false;
                Photo.MinimizeBox = false;
                Photo.StartPosition = FormStartPosition.CenterScreen;
                Photo.Size = new System.Drawing.Size(i.Size.Width + 150, i.Size.Height + 30);
                PictureBox pic = new PictureBox();
                pic.Dock = DockStyle.Fill;
                pic.Image = img;
                Button butt = new Button();
                butt.Dock = DockStyle.Bottom;
                butt.Size = new System.Drawing.Size(10, 30);
                butt.Text = "OK";
                butt.Click += new EventHandler(butt_Click);
                TextBox text = new TextBox();
                text.Dock = DockStyle.Right;
                text.Size = new System.Drawing.Size(120, i.Size.Height);
                text.Multiline = true;
                text.Text = "Name:\r\n" + name + "\r\n\r\nAge:\r\n" + age + "\r\n\r\nHobbies:\r\n" + hobby + "\r\n" + other + "\r\n\r\nFavorite Color:\r\n" + color;
                text.Enabled = false;
                Photo.Controls.Add(pic);
                Photo.Controls.Add(text);
                Photo.Controls.Add(butt);
                Photo.ShowDialog();
            }
        }// End Thumbnail Image Click

        public static Image GetPicture(string resName, string p_type)
        {
            Image i;

            if (resources == null)
            {
                resources = new System.Resources.ResourceManager("WindowsFormsApplication1.Resource1", System.Reflection.Assembly.GetExecutingAssembly());
            }
           
            i = (Bitmap)(resources.GetObject(resName + p_type));


            if (i == null)
            {
                i = (Image)(Bitmap)(resources.GetObject("MysteryDate" + p_type));
            }
            return i;
        }// End GetPicture


        /*
         * Produces new Form with Full Image and Desription
         */
        private void showFullPhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image i;

            i = (Image)(Bitmap)(DatingForm.resources.GetObject(photo));

            if (i == null)
            {
                i = (Image)(Bitmap)(resources.GetObject("MysteryDate"));
            }

            Bitmap img = (Bitmap)i;


            using (Form Photo = new Form())
            {
                Photo.MaximizeBox = false;
                Photo.MinimizeBox = false;
                Photo.StartPosition = FormStartPosition.CenterScreen;
                Photo.Size = new System.Drawing.Size(i.Size.Width + 150, i.Size.Height + 30);
                PictureBox pic = new PictureBox();
                pic.Dock = DockStyle.Fill;
                pic.Image = img;
                Button butt = new Button();
                butt.Dock = DockStyle.Bottom;
                butt.Size = new System.Drawing.Size(10, 30);
                butt.Text = "OK";
                butt.Click += new EventHandler(butt_Click);
                TextBox text = new TextBox();
                text.Dock = DockStyle.Right;
                text.Size = new System.Drawing.Size(120, i.Size.Height);
                text.Multiline = true;
                text.Text = "Name:\r\n" + name + "\r\n\r\nAge:\r\n" + age + "\r\n\r\nHobbies:\r\n" + hobby + "\r\n" + other + "\r\n\r\nFavorite Color:\r\n" + color;
                text.Enabled = false;
                Photo.Controls.Add(pic);
                Photo.Controls.Add(text);
                Photo.Controls.Add(butt);
                Photo.ShowDialog();
               
            }
        }





        private void ClientGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = 0;
            Client fish = null;

            rowIndex = ClientGrid.CurrentRow.Index;
            ClientGrid.Rows[rowIndex].Selected = true;
            rowIndex = int.Parse(ClientGrid[7, rowIndex].Value.ToString());
            fish = fishtank.GetAClient(rowIndex);

            photo = fish.Photo;
            age = ""+ fish.Age;
            hobby = fish.Hobby;
            other = fish.Other;
            color = fish.Color;
            name= fish.Fname + " " + fish.Lname;
            this.Preview.Image = GetPicture(fish.Photo, "t");
            this.ShowFullPhoto.Enabled = true;
        }// End Thumbnail Image Update

        private void AddNewClient_Click(object sender, EventArgs e)
        {
            AddClientForm client = new AddClientForm();
            client.ShowDialog();
        }

        private void date_update(object sender, EventArgs e)
        {
            this.toolStripStatusLabel4.Text = "" + System.DateTime.Now.ToShortTimeString();
        }// Updates Time

    }
}

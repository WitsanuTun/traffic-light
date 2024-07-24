using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace traffic_light
{
    public partial class Form1 : Form
    {
        string  light="red";

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(light) {
                case "red":
                    this.pictop.Image = global::traffic_light.Properties.Resources.red;
                    this.picmid.Image = global::traffic_light.Properties.Resources.black4;
                    this.picbutton.Image = global::traffic_light.Properties.Resources.black4;
                    light = "green";
                    break;
                case "green":
                    this.pictop.Image = global::traffic_light.Properties.Resources.black4;
                    this.picmid.Image = global::traffic_light.Properties.Resources.black4;
                    this.picbutton.Image = global::traffic_light.Properties.Resources.green;
                    light = "yellow";
                    break;
                case "yellow":
                    this.pictop.Image = global::traffic_light.Properties.Resources.black4;
                    this.picmid.Image = global::traffic_light.Properties.Resources.yellow;
                    this.picbutton.Image = global::traffic_light.Properties.Resources.black4;
                    light = "red";
                    break;
        }
    }

        private void pictop_Click(object sender, EventArgs e)
        {

        }
    }
    }

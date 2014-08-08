using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapMyRoute
{
    public partial class MapMyRoute : Form
    {
        TextBox[] buildings = new TextBox[1];
        String[,] buildingCode = new String[32,2];
		int furthest = 60;
        public MapMyRoute()
        {
            InitializeComponent();
            buildings[0] = new TextBox();
			this.Controls.Add(buildings[0]);
            //buildings[0].Enabled = true;
            //buildings[0].Top = 60;
            //buildings[0].Left = 50;
            //buildings[0].Show();
            //buildings[0].Visible = true;
            buildingCode[0,0] = "AMB";
            buildingCode[1,0] = "ABB";
            buildingCode[2,0] = "BSB";
            buildingCode[3,0] = "CNH";
            buildingCode[4,0] = "CB";
            buildingCode[5,0] = "CRL";
            buildingCode[6,0] = "DBAC";
            buildingCode[7,0] = "DSB";
            buildingCode[8,0] = "ETCC";
            buildingCode[9,0] = "GCB";
            buildingCode[10,0] = "GH";
            buildingCode[11,0] = "HGTL";
            buildingCode[12,0] = "ITB";
            buildingCode[13,0] = "IAHS";
            buildingCode[14,0] = "IWC";
            buildingCode[15,0] = "JHE";
            buildingCode[16,0] = "KTH";
            buildingCode[17,0] = "LSB";
            buildingCode[18,0] = "MUSC";
            buildingCode[19,0] = "MDCL";
            buildingCode[20,0] = "ML";
            buildingCode[21,0] = "MOA";
            buildingCode[22,0] = "NRB";
            buildingCode[23,0] = "PB";
            buildingCode[24,0] = "RB";
            buildingCode[25,0] = "RJS";
            buildingCode[26,0] = "T13";
            buildingCode[27,0] = "T28q34 qerg5 3w56h56";
            buildingCode[28,0] = "T29w45g w4rtgwyh56y54";
            buildingCode[29,0] = "TA";
            buildingCode[30,0] = "TSH";
            buildingCode[31,0] = "UH";
			//gMaps
            buildingCode[0, 1] = "Alumni+Memorial+Bldg,+McMaster+University,+Hamilton,+ON+L8S+4E8";
            buildingCode[1, 1] = "A.N.+Bourns+Science+Bldg,+1280+Main+St+W,+McMaster+University,+Hamilton,+ON+L8S";
            buildingCode[2, 1] = "Burke+Science+Bldg,+1280+Main+St+W,+McMaster+University,+Hamilton,+ON+L8S+4L8";
            buildingCode[3, 1] = "Chester+New+Hall,+McMaster+University,+Hamilton,+ON+L8S+4E8";
            buildingCode[4, 1] = "Commons+Bldg,+McMaster+University,+Hamilton,+ON+L8S+4E8";
            buildingCode[5, 1] = "Innis+Library,+1280+Main+Street+West,+Hamilton,+ON+L8S+4M4";
            buildingCode[6, 1] = "David+Braley+Athletic+Centre,+1280+E+Main+St,+McMaster+University,+Hamilton,+ON+L8S+4E8";
            buildingCode[7, 1] = "McMaster+DeGroote+School+of+Business";
            buildingCode[8, 1] = "Parking+Area+H,+Cootes+Paradise+A,+Hamilton,+ON";
            buildingCode[9, 1] = "General+Sciences+Bldg,+McMaster+University,+Hamilton,+ON+L8S";
            buildingCode[10, 1] = "Gilmour+Hall,+McMaster+University,+Hamilton,+ON+L8S+4E8";
            buildingCode[11, 1] = "HG+Thode+Library,+1280+Main+Street+West,+Hamilton,+Ontario";
            buildingCode[12, 1] = "Information+Technology+Centre,+Hamilton,+ON";
            buildingCode[13, 1] = "Institute+for+Applied+Health+Sciences+at+McMaster,+1400+Main+St+W,+Hamilton,+ON+L8S+1C7";
            buildingCode[14, 1] = "Ivor+Wynne+Stadium,+75+Balsam+Ave+N,+Hamilton,+ON+L8L+6Y2";
            buildingCode[15, 1] = "John+Hodgins+Engineering+Building,+Hamilton,+ON";
            buildingCode[16, 1] = "Kenneth+Taylor+Hall,+McMaster+University,+Hamilton,+ON+L8S+4E8";
            buildingCode[17, 1] = "Life+Sciences+Bldg,+McMaster+University,+Hamilton,+ON+L8S+4E8";
            buildingCode[18, 1] = "McMaster+University+Student+Centre,+MUSC-222,+1280+Main+Street+West,+Hamilton,+ON+L8S+4S4";
            buildingCode[19, 1] = "Michael+G.+DeGroote+Centre+for+Learning+and+Discovery,+1280+Main+Street+West,+Hamilton,+ON+L8S+4K1";
            buildingCode[20, 1] = "Mills+Memorial+Library,+Hamilton,+ON";
            buildingCode[21, 1] = "McMaster+Museum+of+Art,+1280+Main+St+W,+Hamilton,+ON+L8S+4L6";
            buildingCode[22, 1] = "Nuclear+Research+Building,+Hamilton,+ON";
            buildingCode[23, 1] = "Psychology+Bldg,+McMaster+University,+Hamilton,+ON+L8S";
            buildingCode[24, 1] = "Refectory,+McMaster+University,+Hamilton,+ON+L8S+4E8";
            buildingCode[25, 1] = "Ron+Joyce+Stadium,+Hamilton,+ON";
            buildingCode[26, 1] = "Prelim+Laboratory,+McMaster+University,+Hamilton,+ON+L8S";
            buildingCode[27,1] = "T28";
            buildingCode[28,1] = "T29";
            buildingCode[29, 1] = "Tandem+Accelerator+Building,+Hamilton,+ON";
            buildingCode[30, 1] = "Togo+Salmon+Hall,+McMaster+University,+Hamilton,+ON+L8S+4E8";
            buildingCode[31, 1] = "University+Hall,+Hamilton,+ON+L8S+4E8";

        }
        private void MapMyRoute_Load(object sender, EventArgs e)
        {

        }

        private void btnAddBuilding_Click(object sender, EventArgs e)
        {
			//check window size if (furthest + 30 > this.width)
            TextBox[] bCopy = new TextBox[buildings.Length];
            for ( int i = 0; i < buildings.Length; i++)
            {
                bCopy[i] = new TextBox();
                bCopy[i].Text = buildings[i].Text;
            }
            buildings = new TextBox[bCopy.Length + 1];
            for (int i = 0; i < bCopy.Length; i++)
            {
                buildings[i] = new TextBox();
                buildings[i].Text = bCopy[i].Text;
            }
            buildings[buildings.Length - 1] = new TextBox();
			buildings[buildings.Length - 1].Top = furthest + 30;
			furthest += 30;
			buildings[buildings.Length - 1].Left = 50;
			this.Controls.Add(buildings[buildings.Length - 1]);
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < buildings.Length; i++)
            {
                this.Controls.Add(buildings[i]);
            }
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            string link = @"www.google.com/maps/dir/";
            foreach (TextBox t in buildings)
            {
                for (int i = 0; i < 32; i++)
                {
                    if (t.Text == buildingCode[i, 0])
                    {
                        link += buildingCode[i, 1].ToString() + @"/";
                    }
                }
            }
            System.Diagnostics.Process.Start(link);
        }
    }
}

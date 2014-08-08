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
		int furthest = 30;
        public MapMyRoute()
        {
            InitializeComponent();
            buildings[0] = new TextBox();
			this.Controls.Add(buildings[0]);
            buildings[0].Enabled = true;
            buildings[0].Top = 30;
            buildings[0].Left = 50;
            buildings[0].Show();
            buildings[0].Visible = true;
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
            buildingCode[27,0] = "T28";
            buildingCode[28,0] = "T29";
            buildingCode[29,0] = "TA";
            buildingCode[30,0] = "TSH";
            buildingCode[31,0] = "UH";
			//gMaps
			buildingCode[0,1] = "AMB";
            buildingCode[1,1] = "ABB";
            buildingCode[2,1] = "BSB";
            buildingCode[3,1] = "CNH";
            buildingCode[4,1] = "CB";
            buildingCode[5,1] = "CRL";
            buildingCode[6,1] = "DBAC";
            buildingCode[7,1] = "DSB";
            buildingCode[8,1] = "ETCC";
            buildingCode[9,1] = "GCB";
            buildingCode[10,1] = "GH";
            buildingCode[11,1] = "HGTL";
            buildingCode[12,1] = "ITB";
            buildingCode[13,1] = "IAHS";
            buildingCode[14,1] = "IWC";
            buildingCode[15,1] = "JHE";
            buildingCode[16,1] = "KTH";
            buildingCode[17,1] = "LSB";
            buildingCode[18,1] = "MUSC";
            buildingCode[19,1] = "MDCL";
            buildingCode[20,1] = "ML";
            buildingCode[21,1] = "MOA";
            buildingCode[22,1] = "NRB";
            buildingCode[23,1] = "PB";
            buildingCode[24,1] = "RB";
            buildingCode[25,1] = "RJS";
            buildingCode[26,1] = "T13";
            buildingCode[27,1] = "T28";
            buildingCode[28,1] = "T29";
            buildingCode[29,1] = "TA";
            buildingCode[30,1] = "TSH";
            buildingCode[31,1] = "UH";

        }
		
		private void btnMapMyRoute(object sender, EventArgs e)
		{
			string link = @"www.google.com/maps/dir/";
			foreach (Textbox t in buildings)
			{
				for (int i = 0; i < buildings.Length; i++)
				{
					if (t.Text == buildingCode[i,0])
					{
						link += buildingCode[i,1].ToString() + @"/";
					}
					else if (i == 31 && t.Text != buildingCode[i,0])
					{
						MessageBox.Show("Building code " + t.Text + " does not exist");
					}
				}
			}
			System.Diagnostics.Process.Start(link);
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
            buildings = new TextBox[bCopy.Length];
            for (int i = 0; i < bCopy.Length; i++)
            {
                buildings[i] = new TextBox();
                buildings[i].Text = bCopy[i].Text;
            }
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
    }
}

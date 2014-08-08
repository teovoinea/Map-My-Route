namespace MapMyRoute
{
    partial class MapMyRoute
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblExample = new System.Windows.Forms.Label();
            this.btnAddBuilding = new System.Windows.Forms.Button();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.btnMap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 26);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(188, 13);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Input building code from your timetable";
            // 
            // lblExample
            // 
            this.lblExample.AutoSize = true;
            this.lblExample.Location = new System.Drawing.Point(13, 43);
            this.lblExample.Name = "lblExample";
            this.lblExample.Size = new System.Drawing.Size(58, 13);
            this.lblExample.TabIndex = 2;
            this.lblExample.Text = "e.g: MDCL";
            // 
            // btnAddBuilding
            // 
            this.btnAddBuilding.Location = new System.Drawing.Point(165, 68);
            this.btnAddBuilding.Name = "btnAddBuilding";
            this.btnAddBuilding.Size = new System.Drawing.Size(98, 23);
            this.btnAddBuilding.TabIndex = 3;
            this.btnAddBuilding.Text = "Add a building";
            this.btnAddBuilding.UseVisualStyleBackColor = true;
            this.btnAddBuilding.Click += new System.EventHandler(this.btnAddBuilding_Click);
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Enabled = true;
            this.tmrUpdate.Interval = 60;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // btnMap
            // 
            this.btnMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMap.Location = new System.Drawing.Point(300, 15);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(245, 76);
            this.btnMap.TabIndex = 4;
            this.btnMap.Text = "Map My Route!";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // MapMyRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 707);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.btnAddBuilding);
            this.Controls.Add(this.lblExample);
            this.Controls.Add(this.lblInfo);
            this.Name = "MapMyRoute";
            this.Text = "Map My Route";
            this.Load += new System.EventHandler(this.MapMyRoute_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblExample;
        private System.Windows.Forms.Button btnAddBuilding;
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.Button btnMap;
    }
}


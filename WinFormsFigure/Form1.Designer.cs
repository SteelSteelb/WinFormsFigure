//Abramov Danil 220 GeometricFigures-4 24.06.2022
namespace WinFormsFigure
{
    partial class FormFigure
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFigure));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.tbMain = new System.Windows.Forms.TextBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.cbFigure = new System.Windows.Forms.ComboBox();
            this.tbXcdt = new System.Windows.Forms.TextBox();
            this.tbStrtCdt = new System.Windows.Forms.TextBox();
            this.tbYcdt = new System.Windows.Forms.TextBox();
            this.tbWdh = new System.Windows.Forms.TextBox();
            this.tbHght = new System.Windows.Forms.TextBox();
            this.svFD = new System.Windows.Forms.SaveFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.opFD = new System.Windows.Forms.OpenFileDialog();
            this.tbSlctFgr = new System.Windows.Forms.TextBox();
            this.clrDlg = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.tbDepth = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlMain.Controls.Add(this.tbMain);
            this.pnlMain.Location = new System.Drawing.Point(12, 13);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1017, 285);
            this.pnlMain.TabIndex = 0;
            // 
            // pbMain
            // 
            this.pbMain.Location = new System.Drawing.Point(10, 12);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(1019, 286);
            this.pbMain.TabIndex = 2;
            this.pbMain.TabStop = false;
            // 
            // tbMain
            // 
            this.tbMain.Location = new System.Drawing.Point(0, 317);
            this.tbMain.Multiline = true;
            this.tbMain.Name = "tbMain";
            this.tbMain.ReadOnly = true;
            this.tbMain.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMain.Size = new System.Drawing.Size(761, 237);
            this.tbMain.TabIndex = 1;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(9, 493);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(764, 74);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // cbFigure
            // 
            this.cbFigure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFigure.Location = new System.Drawing.Point(9, 379);
            this.cbFigure.Name = "cbFigure";
            this.cbFigure.Size = new System.Drawing.Size(247, 28);
            this.cbFigure.TabIndex = 2;
            this.cbFigure.SelectedIndexChanged += new System.EventHandler(this.cbFigure_SelectedIndexChanged);
            // 
            // tbXcdt
            // 
            this.tbXcdt.Location = new System.Drawing.Point(9, 439);
            this.tbXcdt.Name = "tbXcdt";
            this.tbXcdt.Size = new System.Drawing.Size(110, 27);
            this.tbXcdt.TabIndex = 3;
            this.tbXcdt.Tag = "a";
            this.tbXcdt.Click += new System.EventHandler(this.tbXcdt_Click);
            this.tbXcdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbXcdt_KeyPress);
            this.tbXcdt.Leave += new System.EventHandler(this.tbXcdt_Leave);
            // 
            // tbStrtCdt
            // 
            this.tbStrtCdt.BackColor = System.Drawing.SystemColors.Menu;
            this.tbStrtCdt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbStrtCdt.Location = new System.Drawing.Point(9, 413);
            this.tbStrtCdt.Name = "tbStrtCdt";
            this.tbStrtCdt.ReadOnly = true;
            this.tbStrtCdt.Size = new System.Drawing.Size(249, 20);
            this.tbStrtCdt.TabIndex = 4;
            this.tbStrtCdt.Text = "Coords";
            // 
            // tbYcdt
            // 
            this.tbYcdt.Location = new System.Drawing.Point(146, 439);
            this.tbYcdt.Name = "tbYcdt";
            this.tbYcdt.Size = new System.Drawing.Size(110, 27);
            this.tbYcdt.TabIndex = 5;
            this.tbYcdt.Tag = "a";
            this.tbYcdt.Click += new System.EventHandler(this.tbYcdt_Click);
            this.tbYcdt.TextChanged += new System.EventHandler(this.tbYcdt_TextChanged);
            this.tbYcdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbXcdt_KeyPress);
            this.tbYcdt.Leave += new System.EventHandler(this.tbYcdt_Leave);
            // 
            // tbWdh
            // 
            this.tbWdh.Location = new System.Drawing.Point(351, 379);
            this.tbWdh.Name = "tbWdh";
            this.tbWdh.Size = new System.Drawing.Size(110, 27);
            this.tbWdh.TabIndex = 7;
            this.tbWdh.Click += new System.EventHandler(this.tbWdh_Click);
            this.tbWdh.TextChanged += new System.EventHandler(this.tbWdh_TextChanged);
            this.tbWdh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWdh_KeyPress);
            this.tbWdh.Leave += new System.EventHandler(this.tbWdh_Leave);
            // 
            // tbHght
            // 
            this.tbHght.Location = new System.Drawing.Point(488, 379);
            this.tbHght.Name = "tbHght";
            this.tbHght.Size = new System.Drawing.Size(110, 27);
            this.tbHght.TabIndex = 8;
            this.tbHght.Click += new System.EventHandler(this.tbHght_Click);
            this.tbHght.TextChanged += new System.EventHandler(this.tbXcdt_TextChanged);
            this.tbHght.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbXcdt_KeyPress);
            this.tbHght.Leave += new System.EventHandler(this.tbHght_Leave);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(816, 97);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 29);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(816, 26);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(120, 29);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // opFD
            // 
            this.opFD.FileName = "openFileDialog1";
            // 
            // tbSlctFgr
            // 
            this.tbSlctFgr.BackColor = System.Drawing.SystemColors.Menu;
            this.tbSlctFgr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSlctFgr.Location = new System.Drawing.Point(9, 353);
            this.tbSlctFgr.Name = "tbSlctFgr";
            this.tbSlctFgr.ReadOnly = true;
            this.tbSlctFgr.Size = new System.Drawing.Size(247, 20);
            this.tbSlctFgr.TabIndex = 12;
            this.tbSlctFgr.Text = "Select figure:";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(634, 378);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(139, 88);
            this.btnColor.TabIndex = 14;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // tbDepth
            // 
            this.tbDepth.Location = new System.Drawing.Point(351, 439);
            this.tbDepth.Name = "tbDepth";
            this.tbDepth.Size = new System.Drawing.Size(110, 27);
            this.tbDepth.TabIndex = 16;
            this.tbDepth.Click += new System.EventHandler(this.tbDepth_Click);
            this.tbDepth.TextChanged += new System.EventHandler(this.tbDepth_TextChanged);
            this.tbDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDepth_KeyPress);
            this.tbDepth.Leave += new System.EventHandler(this.tbDepth_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(4, 330);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 246);
            this.panel1.TabIndex = 17;
            // 
            // FormFigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1041, 579);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.tbDepth);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.tbSlctFgr);
            this.Controls.Add(this.tbHght);
            this.Controls.Add(this.tbWdh);
            this.Controls.Add(this.tbYcdt);
            this.Controls.Add(this.tbStrtCdt);
            this.Controls.Add(this.tbXcdt);
            this.Controls.Add(this.cbFigure);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel1);
            this.Name = "FormFigure";
            this.Text = "Drawer";
            this.Activated += new System.EventHandler(this.FormFigure_Activated);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.TextBox tbMain;
        private System.Windows.Forms.ComboBox cbFigure;
        private System.Windows.Forms.TextBox tbXcdt;
        private System.Windows.Forms.TextBox tbStrtCdt;
        private System.Windows.Forms.TextBox tbYcdt;
        private System.Windows.Forms.TextBox tbWdh;
        private System.Windows.Forms.TextBox tbHght;
        private System.Windows.Forms.SaveFileDialog svFD;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog opFD;
        private System.Windows.Forms.TextBox tbSlctFgr;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.ColorDialog clrDlg;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox tbDepth;
        private System.Windows.Forms.Panel panel1;
    }
}


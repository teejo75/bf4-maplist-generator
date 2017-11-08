namespace BF4MapListGenerator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDontRepeat = new System.Windows.Forms.CheckBox();
            this.cbRepeatAll = new System.Windows.Forms.CheckBox();
            this.lblRepeat = new System.Windows.Forms.Label();
            this.nmRepeats = new System.Windows.Forms.NumericUpDown();
            this.lblRound = new System.Windows.Forms.Label();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.nmRounds = new System.Windows.Forms.NumericUpDown();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbGameTypesPattern = new System.Windows.Forms.ListBox();
            this.lbGameTypes = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvMaps = new System.Windows.Forms.ListView();
            this.cbMapsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearSelectionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maplisttxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanMapListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmRepeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmRounds)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.cbMapsContextMenuStrip.SuspendLayout();
            this.MainFormMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDontRepeat);
            this.groupBox1.Controls.Add(this.cbRepeatAll);
            this.groupBox1.Controls.Add(this.lblRepeat);
            this.groupBox1.Controls.Add(this.nmRepeats);
            this.groupBox1.Controls.Add(this.lblRound);
            this.groupBox1.Controls.Add(this.btnDown);
            this.groupBox1.Controls.Add(this.btnUp);
            this.groupBox1.Controls.Add(this.nmRounds);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lbGameTypesPattern);
            this.groupBox1.Controls.Add(this.lbGameTypes);
            this.groupBox1.Location = new System.Drawing.Point(203, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 267);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Types";
            // 
            // cbDontRepeat
            // 
            this.cbDontRepeat.AutoSize = true;
            this.cbDontRepeat.Location = new System.Drawing.Point(132, 43);
            this.cbDontRepeat.Name = "cbDontRepeat";
            this.cbDontRepeat.Size = new System.Drawing.Size(38, 17);
            this.cbDontRepeat.TabIndex = 13;
            this.cbDontRepeat.Text = "≠∞";
            this.toolTip1.SetToolTip(this.cbDontRepeat, "Select this box to not repeat maps when a game type runs out");
            this.cbDontRepeat.UseVisualStyleBackColor = true;
            // 
            // cbRepeatAll
            // 
            this.cbRepeatAll.AutoSize = true;
            this.cbRepeatAll.Location = new System.Drawing.Point(132, 212);
            this.cbRepeatAll.Name = "cbRepeatAll";
            this.cbRepeatAll.Size = new System.Drawing.Size(32, 17);
            this.cbRepeatAll.TabIndex = 12;
            this.cbRepeatAll.Text = "∞";
            this.toolTip1.SetToolTip(this.cbRepeatAll, "Select this box to repeat the pattern until all maps are used.");
            this.cbRepeatAll.UseVisualStyleBackColor = true;
            this.cbRepeatAll.CheckedChanged += new System.EventHandler(this.cbRepeatAll_CheckedChanged);
            // 
            // lblRepeat
            // 
            this.lblRepeat.AutoSize = true;
            this.lblRepeat.Location = new System.Drawing.Point(129, 169);
            this.lblRepeat.Name = "lblRepeat";
            this.lblRepeat.Size = new System.Drawing.Size(42, 13);
            this.lblRepeat.TabIndex = 11;
            this.lblRepeat.Text = "Repeat";
            // 
            // nmRepeats
            // 
            this.nmRepeats.Location = new System.Drawing.Point(132, 185);
            this.nmRepeats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmRepeats.Name = "nmRepeats";
            this.nmRepeats.Size = new System.Drawing.Size(35, 20);
            this.nmRepeats.TabIndex = 5;
            this.toolTip1.SetToolTip(this.nmRepeats, "Number of times to repeat the pattern");
            this.nmRepeats.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Location = new System.Drawing.Point(127, 73);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(44, 13);
            this.lblRound.TabIndex = 9;
            this.lblRound.Text = "Rounds";
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(299, 143);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(15, 23);
            this.btnDown.TabIndex = 9;
            this.btnDown.Text = "˅";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(299, 114);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(15, 23);
            this.btnUp.TabIndex = 8;
            this.btnUp.Text = "˄";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // nmRounds
            // 
            this.nmRounds.Location = new System.Drawing.Point(132, 88);
            this.nmRounds.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmRounds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmRounds.Name = "nmRounds";
            this.nmRounds.Size = new System.Drawing.Size(35, 20);
            this.nmRounds.TabIndex = 2;
            this.toolTip1.SetToolTip(this.nmRounds, "Number of game rounds per pattern entry");
            this.nmRounds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(132, 234);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(35, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "<<";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(132, 143);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(35, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "<--";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(132, 114);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(35, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "-->";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbGameTypesPattern
            // 
            this.lbGameTypesPattern.FormattingEnabled = true;
            this.lbGameTypesPattern.Location = new System.Drawing.Point(173, 20);
            this.lbGameTypesPattern.Name = "lbGameTypesPattern";
            this.lbGameTypesPattern.Size = new System.Drawing.Size(120, 238);
            this.lbGameTypesPattern.TabIndex = 7;
            this.lbGameTypesPattern.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbGameTypesPattern_MouseDoubleClick);
            // 
            // lbGameTypes
            // 
            this.lbGameTypes.FormattingEnabled = true;
            this.lbGameTypes.Location = new System.Drawing.Point(6, 19);
            this.lbGameTypes.Name = "lbGameTypes";
            this.lbGameTypes.Size = new System.Drawing.Size(120, 238);
            this.lbGameTypes.TabIndex = 1;
            this.lbGameTypes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbGameTypes_MouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvMaps);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 267);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Maps";
            // 
            // lvMaps
            // 
            this.lvMaps.CheckBoxes = true;
            this.lvMaps.ContextMenuStrip = this.cbMapsContextMenuStrip;
            this.lvMaps.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvMaps.Location = new System.Drawing.Point(6, 20);
            this.lvMaps.MultiSelect = false;
            this.lvMaps.Name = "lvMaps";
            this.lvMaps.Size = new System.Drawing.Size(172, 238);
            this.lvMaps.TabIndex = 0;
            this.lvMaps.UseCompatibleStateImageBehavior = false;
            this.lvMaps.View = System.Windows.Forms.View.Details;
            // 
            // cbMapsContextMenuStrip
            // 
            this.cbMapsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem1,
            this.clearSelectionToolStripMenuItem1});
            this.cbMapsContextMenuStrip.Name = "contextMenuStrip2";
            this.cbMapsContextMenuStrip.Size = new System.Drawing.Size(153, 48);
            // 
            // selectAllToolStripMenuItem1
            // 
            this.selectAllToolStripMenuItem1.Name = "selectAllToolStripMenuItem1";
            this.selectAllToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.selectAllToolStripMenuItem1.Text = "Select &All";
            this.selectAllToolStripMenuItem1.Click += new System.EventHandler(this.selectAllToolStripMenuItem1_Click);
            // 
            // clearSelectionToolStripMenuItem1
            // 
            this.clearSelectionToolStripMenuItem1.Name = "clearSelectionToolStripMenuItem1";
            this.clearSelectionToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.clearSelectionToolStripMenuItem1.Text = "&Clear Selection";
            this.clearSelectionToolStripMenuItem1.Click += new System.EventHandler(this.clearSelectionToolStripMenuItem1_Click);
            // 
            // MainFormMenuStrip
            // 
            this.MainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.mapToolStripMenuItem,
            this.generateToolStripMenuItem});
            this.MainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainFormMenuStrip.Name = "MainFormMenuStrip";
            this.MainFormMenuStrip.Size = new System.Drawing.Size(539, 24);
            this.MainFormMenuStrip.TabIndex = 6;
            this.MainFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "A&bout";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // mapToolStripMenuItem
            // 
            this.mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            this.mapToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.mapToolStripMenuItem.Text = "&Map Selection";
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maplisttxtToolStripMenuItem,
            this.cleanMapListToolStripMenuItem});
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.generateToolStripMenuItem.Text = "&Generate";
            // 
            // maplisttxtToolStripMenuItem
            // 
            this.maplisttxtToolStripMenuItem.Name = "maplisttxtToolStripMenuItem";
            this.maplisttxtToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.maplisttxtToolStripMenuItem.Text = "&Map List";
            this.maplisttxtToolStripMenuItem.Click += new System.EventHandler(this.maplisttxtToolStripMenuItem_Click);
            // 
            // cleanMapListToolStripMenuItem
            // 
            this.cleanMapListToolStripMenuItem.Name = "cleanMapListToolStripMenuItem";
            this.cleanMapListToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cleanMapListToolStripMenuItem.Text = "&Clean Map List";
            this.cleanMapListToolStripMenuItem.Click += new System.EventHandler(this.cleanMapListToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 307);
            this.Controls.Add(this.MainFormMenuStrip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainFormMenuStrip;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmRepeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmRounds)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.cbMapsContextMenuStrip.ResumeLayout(false);
            this.MainFormMenuStrip.ResumeLayout(false);
            this.MainFormMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip MainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cbMapsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearSelectionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maplisttxtToolStripMenuItem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbGameTypesPattern;
        private System.Windows.Forms.ListBox lbGameTypes;
        private System.Windows.Forms.ListView lvMaps;
        private System.Windows.Forms.NumericUpDown nmRounds;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Label lblRepeat;
        private System.Windows.Forms.NumericUpDown nmRepeats;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.CheckBox cbRepeatAll;
        private System.Windows.Forms.CheckBox cbDontRepeat;
        private System.Windows.Forms.ToolStripMenuItem mapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cleanMapListToolStripMenuItem;

    }
}


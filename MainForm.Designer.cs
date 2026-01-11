namespace NEXT_Tuning_App
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.NumericUpDown numPlaysPerGame;
        private System.Windows.Forms.NumericUpDown numAutoBids;
        private System.Windows.Forms.NumericUpDown numStartYear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnOpen = new Button();
            btnSave = new Button();
            lblFile = new Label();
            numPlaysPerGame = new NumericUpDown();
            numAutoBids = new NumericUpDown();
            numStartYear = new NumericUpDown();
            numFatigueJV = new NumericUpDown();
            numFatigueVarsity = new NumericUpDown();
            numFatigueAA = new NumericUpDown();
            numFatigueHeisman = new NumericUpDown();
            groupFatigue = new GroupBox();
            label13 = new Label();
            label9 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnPickTeamTextColor = new Button();
            pnlTeamTextColorPreview = new Panel();
            lblTeamTextColorRaw = new Label();
            PPGBox = new TextBox();
            label7 = new Label();
            groupBox2 = new GroupBox();
            btnLoad = new Button();
            label8 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label14 = new Label();
            lblMatchUpColorRaw = new Label();
            pnlMatchUpColorPreview = new Panel();
            btnMatchUpTextColor = new Button();
            groupSpeedNerf = new GroupBox();
            label15 = new Label();
            SpeedNerfAmount = new NumericUpDown();
            SpeedNerfBox = new CheckBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupOptOut = new GroupBox();
            BowlRankingBox = new CheckBox();
            label16 = new Label();
            numOptOutRating = new NumericUpDown();
            OptOutBox = new CheckBox();
            groupStartYear = new GroupBox();
            groupSimEngine = new GroupBox();
            label20 = new Label();
            label21 = new Label();
            label19 = new Label();
            label18 = new Label();
            numSimRushYds = new NumericUpDown();
            numSimPassYds = new NumericUpDown();
            groupConfChamps = new GroupBox();
            groupColors = new GroupBox();
            EasyKickBox = new CheckBox();
            groupKickMeter = new GroupBox();
            textBox1 = new TextBox();
            KickMeterValue = new TextBox();
            label6 = new Label();
            KickDiffComboBox = new ComboBox();
            label5 = new Label();
            numKickSlider = new NumericUpDown();
            pictureBox3 = new PictureBox();
            groupPolygon = new GroupBox();
            PolygonBox = new CheckBox();
            groupImpactPlayer = new GroupBox();
            label17 = new Label();
            ImpactMenuSettingBox = new ComboBox();
            ImpactPlayerBox = new CheckBox();
            label22 = new Label();
            groupRecruiting = new GroupBox();
            label23 = new Label();
            numScholarships = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numPlaysPerGame).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAutoBids).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStartYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFatigueJV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFatigueVarsity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFatigueAA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFatigueHeisman).BeginInit();
            groupFatigue.SuspendLayout();
            groupBox2.SuspendLayout();
            groupSpeedNerf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SpeedNerfAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupOptOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numOptOutRating).BeginInit();
            groupStartYear.SuspendLayout();
            groupSimEngine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSimRushYds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSimPassYds).BeginInit();
            groupConfChamps.SuspendLayout();
            groupColors.SuspendLayout();
            groupKickMeter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numKickSlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupPolygon.SuspendLayout();
            groupImpactPlayer.SuspendLayout();
            groupRecruiting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numScholarships).BeginInit();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.PowderBlue;
            btnOpen.Location = new Point(6, 25);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(100, 30);
            btnOpen.TabIndex = 3;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.PowderBlue;
            btnSave.Location = new Point(234, 25);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblFile
            // 
            lblFile.Location = new Point(6, 74);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(311, 20);
            lblFile.TabIndex = 5;
            lblFile.Text = "No file loaded";
            // 
            // numPlaysPerGame
            // 
            numPlaysPerGame.Location = new Point(17, 27);
            numPlaysPerGame.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numPlaysPerGame.Minimum = new decimal(new int[] { 80, 0, 0, 0 });
            numPlaysPerGame.Name = "numPlaysPerGame";
            numPlaysPerGame.Size = new Size(75, 22);
            numPlaysPerGame.TabIndex = 6;
            numPlaysPerGame.TextAlign = HorizontalAlignment.Center;
            numPlaysPerGame.Value = new decimal(new int[] { 100, 0, 0, 0 });
            numPlaysPerGame.ValueChanged += numPlaysPerGame_ValueChanged;
            // 
            // numAutoBids
            // 
            numAutoBids.Location = new Point(17, 25);
            numAutoBids.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numAutoBids.Name = "numAutoBids";
            numAutoBids.Size = new Size(75, 22);
            numAutoBids.TabIndex = 8;
            numAutoBids.TextAlign = HorizontalAlignment.Center;
            numAutoBids.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // numStartYear
            // 
            numStartYear.Location = new Point(20, 28);
            numStartYear.Maximum = new decimal(new int[] { 2200, 0, 0, 0 });
            numStartYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numStartYear.Name = "numStartYear";
            numStartYear.Size = new Size(75, 22);
            numStartYear.TabIndex = 1;
            numStartYear.TextAlign = HorizontalAlignment.Center;
            numStartYear.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            // 
            // numFatigueJV
            // 
            numFatigueJV.DecimalPlaces = 3;
            numFatigueJV.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numFatigueJV.Location = new Point(100, 26);
            numFatigueJV.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            numFatigueJV.Minimum = new decimal(new int[] { 5, 0, 0, 65536 });
            numFatigueJV.Name = "numFatigueJV";
            numFatigueJV.Size = new Size(59, 22);
            numFatigueJV.TabIndex = 10;
            numFatigueJV.TextAlign = HorizontalAlignment.Center;
            numFatigueJV.Value = new decimal(new int[] { 5, 0, 0, 65536 });
            // 
            // numFatigueVarsity
            // 
            numFatigueVarsity.DecimalPlaces = 3;
            numFatigueVarsity.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numFatigueVarsity.Location = new Point(100, 71);
            numFatigueVarsity.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            numFatigueVarsity.Minimum = new decimal(new int[] { 5, 0, 0, 65536 });
            numFatigueVarsity.Name = "numFatigueVarsity";
            numFatigueVarsity.Size = new Size(59, 22);
            numFatigueVarsity.TabIndex = 11;
            numFatigueVarsity.TextAlign = HorizontalAlignment.Center;
            numFatigueVarsity.Value = new decimal(new int[] { 75, 0, 0, 131072 });
            // 
            // numFatigueAA
            // 
            numFatigueAA.DecimalPlaces = 3;
            numFatigueAA.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numFatigueAA.Location = new Point(100, 123);
            numFatigueAA.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            numFatigueAA.Minimum = new decimal(new int[] { 5, 0, 0, 65536 });
            numFatigueAA.Name = "numFatigueAA";
            numFatigueAA.Size = new Size(59, 22);
            numFatigueAA.TabIndex = 12;
            numFatigueAA.TextAlign = HorizontalAlignment.Center;
            numFatigueAA.Value = new decimal(new int[] { 10, 0, 0, 65536 });
            // 
            // numFatigueHeisman
            // 
            numFatigueHeisman.DecimalPlaces = 3;
            numFatigueHeisman.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numFatigueHeisman.Location = new Point(100, 171);
            numFatigueHeisman.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            numFatigueHeisman.Minimum = new decimal(new int[] { 5, 0, 0, 65536 });
            numFatigueHeisman.Name = "numFatigueHeisman";
            numFatigueHeisman.Size = new Size(59, 22);
            numFatigueHeisman.TabIndex = 13;
            numFatigueHeisman.TextAlign = HorizontalAlignment.Center;
            numFatigueHeisman.Value = new decimal(new int[] { 115, 0, 0, 131072 });
            // 
            // groupFatigue
            // 
            groupFatigue.Controls.Add(label13);
            groupFatigue.Controls.Add(label9);
            groupFatigue.Controls.Add(label4);
            groupFatigue.Controls.Add(label3);
            groupFatigue.Controls.Add(label2);
            groupFatigue.Controls.Add(label1);
            groupFatigue.Controls.Add(numFatigueJV);
            groupFatigue.Controls.Add(numFatigueHeisman);
            groupFatigue.Controls.Add(numFatigueVarsity);
            groupFatigue.Controls.Add(numFatigueAA);
            groupFatigue.Location = new Point(374, 79);
            groupFatigue.Name = "groupFatigue";
            groupFatigue.Size = new Size(193, 256);
            groupFatigue.TabIndex = 14;
            groupFatigue.TabStop = false;
            groupFatigue.Text = "Fatigue Slider";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 8.25F);
            label13.Location = new Point(4, 229);
            label13.Name = "label13";
            label13.Size = new Size(182, 13);
            label13.TabIndex = 19;
            label13.Text = "Next Defaults: 1.0 / 1.1 / 1.17 / 1.17";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 8.25F);
            label9.Location = new Point(3, 208);
            label9.Name = "label9";
            label9.Size = new Size(185, 13);
            label9.TabIndex = 18;
            label9.Text = "OG Defaults: 0.50 / 0.75 / 1.0 / 1.15 ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(33, 173);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 17;
            label4.Text = "Heisman";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(10, 125);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 16;
            label3.Text = "All-American";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(46, 79);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 15;
            label2.Text = "Varsity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(14, 32);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 14;
            label1.Text = "Junior Varsity";
            // 
            // btnPickTeamTextColor
            // 
            btnPickTeamTextColor.BackColor = Color.SkyBlue;
            btnPickTeamTextColor.Location = new Point(12, 42);
            btnPickTeamTextColor.Name = "btnPickTeamTextColor";
            btnPickTeamTextColor.Size = new Size(223, 33);
            btnPickTeamTextColor.TabIndex = 17;
            btnPickTeamTextColor.Text = "Color Chooser";
            btnPickTeamTextColor.UseVisualStyleBackColor = false;
            btnPickTeamTextColor.MouseClick += btnPickTeamTextColor_Click;
            // 
            // pnlTeamTextColorPreview
            // 
            pnlTeamTextColorPreview.Location = new Point(12, 81);
            pnlTeamTextColorPreview.Name = "pnlTeamTextColorPreview";
            pnlTeamTextColorPreview.Size = new Size(223, 47);
            pnlTeamTextColorPreview.TabIndex = 18;
            // 
            // lblTeamTextColorRaw
            // 
            lblTeamTextColorRaw.AutoSize = true;
            lblTeamTextColorRaw.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTeamTextColorRaw.Location = new Point(12, 131);
            lblTeamTextColorRaw.Name = "lblTeamTextColorRaw";
            lblTeamTextColorRaw.Size = new Size(66, 15);
            lblTeamTextColorRaw.TabIndex = 19;
            lblTeamTextColorRaw.Text = "Raw Value";
            // 
            // PPGBox
            // 
            PPGBox.BackColor = SystemColors.Info;
            PPGBox.Enabled = false;
            PPGBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PPGBox.Location = new Point(115, 24);
            PPGBox.Name = "PPGBox";
            PPGBox.ReadOnly = true;
            PPGBox.Size = new Size(52, 25);
            PPGBox.TabIndex = 20;
            PPGBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(170, 28);
            label7.Name = "label7";
            label7.Size = new Size(166, 16);
            label7.TabIndex = 21;
            label7.Text = "Predicted Plays Per Game";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnLoad);
            groupBox2.Controls.Add(lblFile);
            groupBox2.Controls.Add(btnOpen);
            groupBox2.Controls.Add(btnSave);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(342, 97);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Menu";
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.PowderBlue;
            btnLoad.Location = new Point(118, 25);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(100, 30);
            btnLoad.TabIndex = 6;
            btnLoad.Text = "Load Config";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.PaleTurquoise;
            label8.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(389, 632);
            label8.Name = "label8";
            label8.Size = new Size(321, 25);
            label8.TabIndex = 23;
            label8.Text = "NCAA Next Tuning App v1.20";
            label8.UseMnemonic = false;
            // 
            // label10
            // 
            label10.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label10.Location = new Point(12, 27);
            label10.Name = "label10";
            label10.Size = new Size(192, 20);
            label10.TabIndex = 24;
            label10.Text = "User Team Highlighted Text Color";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 8.25F);
            label11.Location = new Point(17, 65);
            label11.Name = "label11";
            label11.Size = new Size(174, 13);
            label11.TabIndex = 19;
            label11.Text = "OG Default: 100  NEXT Default: 94";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 8.25F);
            label12.Location = new Point(106, 34);
            label12.Name = "label12";
            label12.Size = new Size(85, 13);
            label12.TabIndex = 25;
            label12.Text = "NEXT Default: 5";
            // 
            // label14
            // 
            label14.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label14.Location = new Point(12, 156);
            label14.Name = "label14";
            label14.Size = new Size(192, 20);
            label14.TabIndex = 29;
            label14.Text = "Match-Up Highlighted Text Color";
            // 
            // lblMatchUpColorRaw
            // 
            lblMatchUpColorRaw.AutoSize = true;
            lblMatchUpColorRaw.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMatchUpColorRaw.Location = new Point(12, 268);
            lblMatchUpColorRaw.Name = "lblMatchUpColorRaw";
            lblMatchUpColorRaw.Size = new Size(66, 15);
            lblMatchUpColorRaw.TabIndex = 28;
            lblMatchUpColorRaw.Text = "Raw Value";
            // 
            // pnlMatchUpColorPreview
            // 
            pnlMatchUpColorPreview.Location = new Point(12, 218);
            pnlMatchUpColorPreview.Name = "pnlMatchUpColorPreview";
            pnlMatchUpColorPreview.Size = new Size(223, 47);
            pnlMatchUpColorPreview.TabIndex = 27;
            // 
            // btnMatchUpTextColor
            // 
            btnMatchUpTextColor.BackColor = Color.SkyBlue;
            btnMatchUpTextColor.Location = new Point(12, 179);
            btnMatchUpTextColor.Name = "btnMatchUpTextColor";
            btnMatchUpTextColor.Size = new Size(223, 33);
            btnMatchUpTextColor.TabIndex = 26;
            btnMatchUpTextColor.Text = "Color Chooser";
            btnMatchUpTextColor.UseVisualStyleBackColor = false;
            btnMatchUpTextColor.Click += btnMatchUpTextColor_Click;
            // 
            // groupSpeedNerf
            // 
            groupSpeedNerf.Controls.Add(label15);
            groupSpeedNerf.Controls.Add(SpeedNerfAmount);
            groupSpeedNerf.Controls.Add(SpeedNerfBox);
            groupSpeedNerf.Location = new Point(374, 345);
            groupSpeedNerf.Name = "groupSpeedNerf";
            groupSpeedNerf.Size = new Size(193, 106);
            groupSpeedNerf.TabIndex = 30;
            groupSpeedNerf.TabStop = false;
            groupSpeedNerf.Text = "Speed Nerf";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(79, 67);
            label15.Name = "label15";
            label15.Size = new Size(80, 16);
            label15.TabIndex = 2;
            label15.Text = "Nerf Amount";
            // 
            // SpeedNerfAmount
            // 
            SpeedNerfAmount.Enabled = false;
            SpeedNerfAmount.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SpeedNerfAmount.Location = new Point(14, 64);
            SpeedNerfAmount.Maximum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            SpeedNerfAmount.Minimum = new decimal(new int[] { 50, 0, 0, int.MinValue });
            SpeedNerfAmount.Name = "SpeedNerfAmount";
            SpeedNerfAmount.ReadOnly = true;
            SpeedNerfAmount.Size = new Size(59, 24);
            SpeedNerfAmount.TabIndex = 1;
            SpeedNerfAmount.TextAlign = HorizontalAlignment.Center;
            SpeedNerfAmount.Value = new decimal(new int[] { 20, 0, 0, int.MinValue });
            // 
            // SpeedNerfBox
            // 
            SpeedNerfBox.AutoSize = true;
            SpeedNerfBox.Location = new Point(14, 30);
            SpeedNerfBox.Name = "SpeedNerfBox";
            SpeedNerfBox.Size = new Size(171, 20);
            SpeedNerfBox.TabIndex = 0;
            SpeedNerfBox.Text = "Enable Speed Nerf Mod";
            SpeedNerfBox.UseVisualStyleBackColor = true;
            SpeedNerfBox.CheckedChanged += SpeedNerfBox_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(525, 555);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(389, 555);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // groupOptOut
            // 
            groupOptOut.Controls.Add(BowlRankingBox);
            groupOptOut.Controls.Add(label16);
            groupOptOut.Controls.Add(numOptOutRating);
            groupOptOut.Controls.Add(OptOutBox);
            groupOptOut.Location = new Point(12, 307);
            groupOptOut.Name = "groupOptOut";
            groupOptOut.Size = new Size(342, 104);
            groupOptOut.TabIndex = 33;
            groupOptOut.TabStop = false;
            groupOptOut.Text = "Bowl Games";
            // 
            // BowlRankingBox
            // 
            BowlRankingBox.AutoSize = true;
            BowlRankingBox.Location = new Point(172, 30);
            BowlRankingBox.Name = "BowlRankingBox";
            BowlRankingBox.Size = new Size(158, 20);
            BowlRankingBox.TabIndex = 0;
            BowlRankingBox.Text = "Bowls Affect Rankings";
            BowlRankingBox.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(74, 69);
            label16.Name = "label16";
            label16.Size = new Size(70, 16);
            label16.TabIndex = 2;
            label16.Text = "Min Rating";
            // 
            // numOptOutRating
            // 
            numOptOutRating.Enabled = false;
            numOptOutRating.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numOptOutRating.Location = new Point(9, 65);
            numOptOutRating.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numOptOutRating.Minimum = new decimal(new int[] { 40, 0, 0, 0 });
            numOptOutRating.Name = "numOptOutRating";
            numOptOutRating.ReadOnly = true;
            numOptOutRating.Size = new Size(59, 24);
            numOptOutRating.TabIndex = 1;
            numOptOutRating.TextAlign = HorizontalAlignment.Center;
            numOptOutRating.Value = new decimal(new int[] { 40, 0, 0, 0 });
            // 
            // OptOutBox
            // 
            OptOutBox.AutoSize = true;
            OptOutBox.Location = new Point(6, 30);
            OptOutBox.Name = "OptOutBox";
            OptOutBox.Size = new Size(158, 20);
            OptOutBox.TabIndex = 0;
            OptOutBox.Text = "Enable Player Opt Out";
            OptOutBox.UseVisualStyleBackColor = true;
            OptOutBox.CheckedChanged += OptOutDisabled_CheckedChanged;
            // 
            // groupStartYear
            // 
            groupStartYear.Controls.Add(numStartYear);
            groupStartYear.Location = new Point(374, 12);
            groupStartYear.Name = "groupStartYear";
            groupStartYear.Size = new Size(193, 61);
            groupStartYear.TabIndex = 34;
            groupStartYear.TabStop = false;
            groupStartYear.Text = "Dynasty Start Year";
            // 
            // groupSimEngine
            // 
            groupSimEngine.Controls.Add(label20);
            groupSimEngine.Controls.Add(label21);
            groupSimEngine.Controls.Add(label19);
            groupSimEngine.Controls.Add(label18);
            groupSimEngine.Controls.Add(numSimRushYds);
            groupSimEngine.Controls.Add(numSimPassYds);
            groupSimEngine.Controls.Add(numPlaysPerGame);
            groupSimEngine.Controls.Add(PPGBox);
            groupSimEngine.Controls.Add(label7);
            groupSimEngine.Controls.Add(label11);
            groupSimEngine.Location = new Point(12, 122);
            groupSimEngine.Name = "groupSimEngine";
            groupSimEngine.Size = new Size(342, 176);
            groupSimEngine.TabIndex = 35;
            groupSimEngine.TabStop = false;
            groupSimEngine.Text = "Sim Engine";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(17, 144);
            label20.Name = "label20";
            label20.Size = new Size(201, 16);
            label20.TabIndex = 27;
            label20.Text = "Sim Stat Modifier: Rushing Yards";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(17, 105);
            label21.Name = "label21";
            label21.Size = new Size(201, 16);
            label21.TabIndex = 26;
            label21.Text = "Sim Stat Modifier: Passing Yards";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(291, 144);
            label19.Name = "label19";
            label19.Size = new Size(43, 16);
            label19.TabIndex = 25;
            label19.Text = "Yards";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(291, 105);
            label18.Name = "label18";
            label18.Size = new Size(43, 16);
            label18.TabIndex = 24;
            label18.Text = "Yards";
            // 
            // numSimRushYds
            // 
            numSimRushYds.Location = new Point(234, 140);
            numSimRushYds.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            numSimRushYds.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            numSimRushYds.Name = "numSimRushYds";
            numSimRushYds.Size = new Size(51, 22);
            numSimRushYds.TabIndex = 23;
            numSimRushYds.TextAlign = HorizontalAlignment.Center;
            // 
            // numSimPassYds
            // 
            numSimPassYds.Location = new Point(234, 103);
            numSimPassYds.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            numSimPassYds.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            numSimPassYds.Name = "numSimPassYds";
            numSimPassYds.Size = new Size(51, 22);
            numSimPassYds.TabIndex = 22;
            numSimPassYds.TextAlign = HorizontalAlignment.Center;
            // 
            // groupConfChamps
            // 
            groupConfChamps.Controls.Add(numAutoBids);
            groupConfChamps.Controls.Add(label12);
            groupConfChamps.Location = new Point(12, 420);
            groupConfChamps.Name = "groupConfChamps";
            groupConfChamps.Size = new Size(342, 65);
            groupConfChamps.TabIndex = 36;
            groupConfChamps.TabStop = false;
            groupConfChamps.Text = "Conf Champ Auto-Bids for Playoffs ";
            // 
            // groupColors
            // 
            groupColors.Controls.Add(btnPickTeamTextColor);
            groupColors.Controls.Add(pnlTeamTextColorPreview);
            groupColors.Controls.Add(btnMatchUpTextColor);
            groupColors.Controls.Add(pnlMatchUpColorPreview);
            groupColors.Controls.Add(label10);
            groupColors.Controls.Add(lblMatchUpColorRaw);
            groupColors.Controls.Add(lblTeamTextColorRaw);
            groupColors.Controls.Add(label14);
            groupColors.Location = new Point(587, 153);
            groupColors.Name = "groupColors";
            groupColors.Size = new Size(270, 329);
            groupColors.TabIndex = 38;
            groupColors.TabStop = false;
            groupColors.Text = "Colorize";
            // 
            // EasyKickBox
            // 
            EasyKickBox.AutoSize = true;
            EasyKickBox.Location = new Point(16, 141);
            EasyKickBox.Name = "EasyKickBox";
            EasyKickBox.Size = new Size(131, 20);
            EasyKickBox.TabIndex = 0;
            EasyKickBox.Text = "Enable Easy Kick";
            EasyKickBox.UseVisualStyleBackColor = true;
            EasyKickBox.Visible = false;
            EasyKickBox.CheckedChanged += EasyKickBox_CheckedChanged;
            // 
            // groupKickMeter
            // 
            groupKickMeter.Controls.Add(textBox1);
            groupKickMeter.Controls.Add(KickMeterValue);
            groupKickMeter.Controls.Add(label6);
            groupKickMeter.Controls.Add(KickDiffComboBox);
            groupKickMeter.Controls.Add(label5);
            groupKickMeter.Controls.Add(numKickSlider);
            groupKickMeter.Controls.Add(EasyKickBox);
            groupKickMeter.Location = new Point(12, 491);
            groupKickMeter.Name = "groupKickMeter";
            groupKickMeter.Size = new Size(342, 169);
            groupKickMeter.TabIndex = 39;
            groupKickMeter.TabStop = false;
            groupKickMeter.Text = "Kick Meter Slider";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(169, 42);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(167, 119);
            textBox1.TabIndex = 28;
            textBox1.Text = "Default Speed Target Values:\r\nHeisman: 25\r\nAll-American: 33\r\nVarsity: 42\r\nJunior Varsity: 50\r\n\r\nThe YELLOW box should be used to compare to these values";
            // 
            // KickMeterValue
            // 
            KickMeterValue.BackColor = SystemColors.Info;
            KickMeterValue.Enabled = false;
            KickMeterValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KickMeterValue.Location = new Point(97, 107);
            KickMeterValue.Name = "KickMeterValue";
            KickMeterValue.ReadOnly = true;
            KickMeterValue.Size = new Size(52, 27);
            KickMeterValue.TabIndex = 27;
            KickMeterValue.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F);
            label6.Location = new Point(16, 27);
            label6.Name = "label6";
            label6.Size = new Size(72, 13);
            label6.TabIndex = 26;
            label6.Text = "User Difficulty";
            // 
            // KickDiffComboBox
            // 
            KickDiffComboBox.FormattingEnabled = true;
            KickDiffComboBox.Items.AddRange(new object[] { "Junior Varsity", "Varsity", "All-American", "Heisman" });
            KickDiffComboBox.Location = new Point(16, 47);
            KickDiffComboBox.Name = "KickDiffComboBox";
            KickDiffComboBox.Size = new Size(133, 24);
            KickDiffComboBox.TabIndex = 9;
            KickDiffComboBox.SelectedIndexChanged += KickDiffComboBox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 90);
            label5.Name = "label5";
            label5.Size = new Size(151, 16);
            label5.TabIndex = 8;
            label5.Text = "Kick Meter Speed Value";
            // 
            // numKickSlider
            // 
            numKickSlider.Location = new Point(16, 111);
            numKickSlider.Maximum = new decimal(new int[] { 75, 0, 0, 0 });
            numKickSlider.Minimum = new decimal(new int[] { 25, 0, 0, 0 });
            numKickSlider.Name = "numKickSlider";
            numKickSlider.Size = new Size(58, 22);
            numKickSlider.TabIndex = 7;
            numKickSlider.TextAlign = HorizontalAlignment.Center;
            numKickSlider.Value = new decimal(new int[] { 50, 0, 0, 0 });
            numKickSlider.ValueChanged += numEasyKick_ValueChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(740, 555);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(117, 105);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 40;
            pictureBox3.TabStop = false;
            // 
            // groupPolygon
            // 
            groupPolygon.Controls.Add(PolygonBox);
            groupPolygon.Location = new Point(587, 488);
            groupPolygon.Name = "groupPolygon";
            groupPolygon.Size = new Size(270, 61);
            groupPolygon.TabIndex = 41;
            groupPolygon.TabStop = false;
            groupPolygon.Text = "Polygon Patch";
            // 
            // PolygonBox
            // 
            PolygonBox.AutoSize = true;
            PolygonBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PolygonBox.Location = new Point(9, 28);
            PolygonBox.Name = "PolygonBox";
            PolygonBox.Size = new Size(212, 19);
            PolygonBox.TabIndex = 0;
            PolygonBox.Text = "Enhanced Polygon Draw Distance";
            PolygonBox.UseVisualStyleBackColor = true;
            // 
            // groupImpactPlayer
            // 
            groupImpactPlayer.Controls.Add(label17);
            groupImpactPlayer.Controls.Add(ImpactMenuSettingBox);
            groupImpactPlayer.Controls.Add(ImpactPlayerBox);
            groupImpactPlayer.Location = new Point(587, 12);
            groupImpactPlayer.Name = "groupImpactPlayer";
            groupImpactPlayer.Size = new Size(270, 131);
            groupImpactPlayer.TabIndex = 35;
            groupImpactPlayer.TabStop = false;
            groupImpactPlayer.Text = "Impact Players";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(14, 68);
            label17.Name = "label17";
            label17.Size = new Size(232, 16);
            label17.TabIndex = 3;
            label17.Text = "Dynasty: Assign Impact Player Setting";
            // 
            // ImpactMenuSettingBox
            // 
            ImpactMenuSettingBox.FormattingEnabled = true;
            ImpactMenuSettingBox.Items.AddRange(new object[] { "QB, HB, Top 2 Defense", "QB, HB, Top Defense, Top Remaining Player", "QB, HB, Top 2 Remaining", "Top 2 Offense, Top 2 Defense", "Top 4 Skill Players" });
            ImpactMenuSettingBox.Location = new Point(12, 90);
            ImpactMenuSettingBox.Name = "ImpactMenuSettingBox";
            ImpactMenuSettingBox.Size = new Size(234, 24);
            ImpactMenuSettingBox.TabIndex = 2;
            // 
            // ImpactPlayerBox
            // 
            ImpactPlayerBox.AutoSize = true;
            ImpactPlayerBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ImpactPlayerBox.Location = new Point(12, 27);
            ImpactPlayerBox.Name = "ImpactPlayerBox";
            ImpactPlayerBox.Size = new Size(148, 19);
            ImpactPlayerBox.TabIndex = 1;
            ImpactPlayerBox.Text = "Enable Impact Players";
            ImpactPlayerBox.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            label22.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(465, 555);
            label22.Name = "label22";
            label22.Size = new Size(54, 70);
            label22.TabIndex = 42;
            label22.Text = "X";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupRecruiting
            // 
            groupRecruiting.Controls.Add(label23);
            groupRecruiting.Controls.Add(numScholarships);
            groupRecruiting.Location = new Point(374, 457);
            groupRecruiting.Name = "groupRecruiting";
            groupRecruiting.Size = new Size(193, 74);
            groupRecruiting.TabIndex = 43;
            groupRecruiting.TabStop = false;
            groupRecruiting.Text = "Recruiting";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(79, 34);
            label23.Name = "label23";
            label23.Size = new Size(85, 16);
            label23.TabIndex = 2;
            label23.Text = "Scholarships";
            // 
            // numScholarships
            // 
            numScholarships.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numScholarships.Location = new Point(14, 30);
            numScholarships.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            numScholarships.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            numScholarships.Name = "numScholarships";
            numScholarships.Size = new Size(59, 24);
            numScholarships.TabIndex = 1;
            numScholarships.TextAlign = HorizontalAlignment.Center;
            numScholarships.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(880, 672);
            Controls.Add(groupRecruiting);
            Controls.Add(label22);
            Controls.Add(groupImpactPlayer);
            Controls.Add(groupPolygon);
            Controls.Add(pictureBox3);
            Controls.Add(groupColors);
            Controls.Add(groupKickMeter);
            Controls.Add(groupConfChamps);
            Controls.Add(groupSimEngine);
            Controls.Add(groupStartYear);
            Controls.Add(groupOptOut);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupSpeedNerf);
            Controls.Add(label8);
            Controls.Add(groupBox2);
            Controls.Add(groupFatigue);
            Font = new Font("Microsoft Sans Serif", 9.75F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "NCAA Next Tuning App";
            ((System.ComponentModel.ISupportInitialize)numPlaysPerGame).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAutoBids).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStartYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFatigueJV).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFatigueVarsity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFatigueAA).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFatigueHeisman).EndInit();
            groupFatigue.ResumeLayout(false);
            groupFatigue.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupSpeedNerf.ResumeLayout(false);
            groupSpeedNerf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SpeedNerfAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupOptOut.ResumeLayout(false);
            groupOptOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numOptOutRating).EndInit();
            groupStartYear.ResumeLayout(false);
            groupSimEngine.ResumeLayout(false);
            groupSimEngine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSimRushYds).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSimPassYds).EndInit();
            groupConfChamps.ResumeLayout(false);
            groupConfChamps.PerformLayout();
            groupColors.ResumeLayout(false);
            groupColors.PerformLayout();
            groupKickMeter.ResumeLayout(false);
            groupKickMeter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numKickSlider).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupPolygon.ResumeLayout(false);
            groupPolygon.PerformLayout();
            groupImpactPlayer.ResumeLayout(false);
            groupImpactPlayer.PerformLayout();
            groupRecruiting.ResumeLayout(false);
            groupRecruiting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numScholarships).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private NumericUpDown numFatigueJV;
        private NumericUpDown numFatigueVarsity;
        private NumericUpDown numFatigueAA;
        private NumericUpDown numFatigueHeisman;
        private GroupBox groupFatigue;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnPickTeamTextColor;
        private Panel pnlTeamTextColorPreview;
        private Label lblTeamTextColorRaw;
        private TextBox PPGBox;
        private Label label7;
        private Label label9;
        private GroupBox groupBox2;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label lblMatchUpColorRaw;
        private Panel pnlMatchUpColorPreview;
        private Button btnMatchUpTextColor;
        private GroupBox groupSpeedNerf;
        private NumericUpDown SpeedNerfAmount;
        private CheckBox SpeedNerfBox;
        private Label label15;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private GroupBox groupOptOut;
        private Label label16;
        private NumericUpDown numOptOutRating;
        private CheckBox OptOutBox;
        private GroupBox groupStartYear;
        private GroupBox groupSimEngine;
        private GroupBox groupConfChamps;
        private CheckBox BowlRankingBox;
        private GroupBox groupColors;
        private Button btnLoad;
        private GroupBox groupKickMeter;
        private NumericUpDown numKickSlider;
        private CheckBox EasyKickBox;
        private Label label5;
        private ComboBox KickDiffComboBox;
        private Label label6;
        private TextBox KickMeterValue;
        private TextBox textBox1;
        private PictureBox pictureBox3;
        private GroupBox groupPolygon;
        private CheckBox PolygonBox;
        private GroupBox groupImpactPlayer;
        private CheckBox ImpactPlayerBox;
        private ComboBox ImpactMenuSettingBox;
        private Label label17;
        private NumericUpDown numSimRushYds;
        private NumericUpDown numSimPassYds;
        private Label label20;
        private Label label21;
        private Label label19;
        private Label label18;
        private Label label22;
        private GroupBox groupRecruiting;
        private Label label23;
        private NumericUpDown numScholarships;
    }
}
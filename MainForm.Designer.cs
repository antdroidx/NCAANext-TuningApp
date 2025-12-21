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
            groupSimGameLength = new GroupBox();
            groupConfChamps = new GroupBox();
            groupColors = new GroupBox();
            groupKickMeter = new GroupBox();
            textBox1 = new TextBox();
            KickMeterValue = new TextBox();
            label6 = new Label();
            KickDiffComboBox = new ComboBox();
            label5 = new Label();
            numKickSlider = new NumericUpDown();
            EasyKickBox = new CheckBox();
            pictureBox3 = new PictureBox();
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
            groupSimGameLength.SuspendLayout();
            groupConfChamps.SuspendLayout();
            groupColors.SuspendLayout();
            groupKickMeter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numKickSlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            groupFatigue.Location = new Point(370, 107);
            groupFatigue.Name = "groupFatigue";
            groupFatigue.Size = new Size(193, 272);
            groupFatigue.TabIndex = 14;
            groupFatigue.TabStop = false;
            groupFatigue.Text = "Fatigue Slider";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 8.25F);
            label13.Location = new Point(5, 241);
            label13.Name = "label13";
            label13.Size = new Size(182, 13);
            label13.TabIndex = 19;
            label13.Text = "Next Defaults: 1.0 / 1.1 / 1.17 / 1.17";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 8.25F);
            label9.Location = new Point(5, 220);
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
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(379, 552);
            label8.Name = "label8";
            label8.Size = new Size(442, 20);
            label8.TabIndex = 23;
            label8.Text = "NCAA Next Tuning App v1.1  by Antdroid + JDHalfrack";
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
            label11.Text = "OG Default: 100  NEXT Default: 92";
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
            label14.Location = new Point(12, 179);
            label14.Name = "label14";
            label14.Size = new Size(192, 20);
            label14.TabIndex = 29;
            label14.Text = "Match-Up Highlighted Text Color";
            // 
            // lblMatchUpColorRaw
            // 
            lblMatchUpColorRaw.AutoSize = true;
            lblMatchUpColorRaw.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMatchUpColorRaw.Location = new Point(12, 291);
            lblMatchUpColorRaw.Name = "lblMatchUpColorRaw";
            lblMatchUpColorRaw.Size = new Size(66, 15);
            lblMatchUpColorRaw.TabIndex = 28;
            lblMatchUpColorRaw.Text = "Raw Value";
            // 
            // pnlMatchUpColorPreview
            // 
            pnlMatchUpColorPreview.Location = new Point(12, 241);
            pnlMatchUpColorPreview.Name = "pnlMatchUpColorPreview";
            pnlMatchUpColorPreview.Size = new Size(223, 47);
            pnlMatchUpColorPreview.TabIndex = 27;
            // 
            // btnMatchUpTextColor
            // 
            btnMatchUpTextColor.BackColor = Color.SkyBlue;
            btnMatchUpTextColor.Location = new Point(12, 202);
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
            groupSpeedNerf.Location = new Point(370, 403);
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
            pictureBox1.Location = new Point(610, 395);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(610, 468);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 67);
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
            groupOptOut.Location = new Point(12, 219);
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
            groupStartYear.Location = new Point(370, 17);
            groupStartYear.Name = "groupStartYear";
            groupStartYear.Size = new Size(193, 70);
            groupStartYear.TabIndex = 34;
            groupStartYear.TabStop = false;
            groupStartYear.Text = "Dynasty Start Year";
            // 
            // groupSimGameLength
            // 
            groupSimGameLength.Controls.Add(numPlaysPerGame);
            groupSimGameLength.Controls.Add(PPGBox);
            groupSimGameLength.Controls.Add(label7);
            groupSimGameLength.Controls.Add(label11);
            groupSimGameLength.Location = new Point(12, 123);
            groupSimGameLength.Name = "groupSimGameLength";
            groupSimGameLength.Size = new Size(342, 90);
            groupSimGameLength.TabIndex = 35;
            groupSimGameLength.TabStop = false;
            groupSimGameLength.Text = "Sim Game Length Factor";
            // 
            // groupConfChamps
            // 
            groupConfChamps.Controls.Add(numAutoBids);
            groupConfChamps.Controls.Add(label12);
            groupConfChamps.Location = new Point(12, 332);
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
            groupColors.Location = new Point(574, 12);
            groupColors.Name = "groupColors";
            groupColors.Size = new Size(247, 367);
            groupColors.TabIndex = 38;
            groupColors.TabStop = false;
            groupColors.Text = "Colorize";
            // 
            // groupKickMeter
            // 
            groupKickMeter.Controls.Add(textBox1);
            groupKickMeter.Controls.Add(KickMeterValue);
            groupKickMeter.Controls.Add(label6);
            groupKickMeter.Controls.Add(KickDiffComboBox);
            groupKickMeter.Controls.Add(label5);
            groupKickMeter.Controls.Add(numKickSlider);
            groupKickMeter.Location = new Point(7, 403);
            groupKickMeter.Name = "groupKickMeter";
            groupKickMeter.Size = new Size(347, 169);
            groupKickMeter.TabIndex = 39;
            groupKickMeter.TabStop = false;
            groupKickMeter.Text = "Kick Meter Slider";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(169, 39);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(153, 98);
            textBox1.TabIndex = 28;
            textBox1.Text = "Default Speed Target Values:\r\nHeisman: 25\r\nAll-American: 33\r\nVarsity: 42\r\nJunior Varsity: 50";
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
            // EasyKickBox
            // 
            EasyKickBox.AutoSize = true;
            EasyKickBox.Location = new Point(370, 515);
            EasyKickBox.Name = "EasyKickBox";
            EasyKickBox.Size = new Size(131, 20);
            EasyKickBox.TabIndex = 0;
            EasyKickBox.Text = "Enable Easy Kick";
            EasyKickBox.UseVisualStyleBackColor = true;
            EasyKickBox.Visible = false;
            EasyKickBox.CheckedChanged += EasyKickBox_CheckedChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(703, 467);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(75, 68);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 40;
            pictureBox3.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(835, 584);
            Controls.Add(pictureBox3);
            Controls.Add(groupKickMeter);
            Controls.Add(groupConfChamps);
            Controls.Add(groupSimGameLength);
            Controls.Add(groupStartYear);
            Controls.Add(groupOptOut);
            Controls.Add(EasyKickBox);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupSpeedNerf);
            Controls.Add(label8);
            Controls.Add(groupBox2);
            Controls.Add(groupFatigue);
            Controls.Add(groupColors);
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
            groupSimGameLength.ResumeLayout(false);
            groupSimGameLength.PerformLayout();
            groupConfChamps.ResumeLayout(false);
            groupConfChamps.PerformLayout();
            groupColors.ResumeLayout(false);
            groupColors.PerformLayout();
            groupKickMeter.ResumeLayout(false);
            groupKickMeter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numKickSlider).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private GroupBox groupSimGameLength;
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
    }
}
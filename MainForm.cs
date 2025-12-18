using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace NEXT_Tuning_App
{
    public partial class MainForm : Form
    {
        //Offset Database is located in Offset.cs file

        private System.Drawing.Color teamTextColor = System.Drawing.Color.White;
        private System.Drawing.Color matchupTextColor = System.Drawing.Color.White;

        private FileStream? fs;
        private long originBase;

        public MainForm()
        {
            InitializeComponent();
            ToggleUI(false);
        }

        //Version Check
        private void CheckVersion()
        {
            double currentVersion = 16.4;
            string x = "";
            for (int i = 0; i < 4; i++)
            {
                x += Convert.ToChar(ReadByte(originBase + VersionNum + i));

            }


            if (Convert.ToDouble(x) >= 16.4)
            {
                //MessageBox.Show("Correct Version Loaded");
            }
            else
            {
                MessageBox.Show("This app only works with version " + currentVersion + " or higher.\n\nThe loaded file is on version " + x + ".");
            }

        }

        //Toggle UI Elements
        private void ToggleUI(bool enabled)
        {
            btnSave.Enabled = enabled;

            groupStartYear.Enabled = enabled;
            groupBowlRankings.Enabled = enabled;
            groupOptOut.Enabled = enabled;
            groupSimGameLength.Enabled = enabled;
            groupConfChamps.Enabled = enabled;
            groupFatigue.Enabled = enabled;
            groupSpeedNerf.Enabled = enabled;
            groupColors.Enabled = enabled;

        }

        //Open File
        private void btnOpen_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new() { Filter = "All Files (*.*)|*.*" };
            if (ofd.ShowDialog() != DialogResult.OK) return;

            fs?.Dispose();
            fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.ReadWrite);

            // Fix: Pass the FileStream (_fs) instead of the file name string to SignatureScanner.TryFind
            if (!SignatureScanner.TryFind(fs, SlusSignature, out originBase))
            {
                MessageBox.Show("SLUS ELF header not found.");
                ToggleUI(false);
                return;
            }

            CheckVersion();

            lblFile.Text = $"{Path.GetFileName(ofd.FileName)} (SLUS @ 0x{originBase:X})";
            LoadValues();
            ToggleUI(true);
        }


        //Load Config
        private void btnLoad_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new() { Filter = "All Files (*.*)|*.*" };
            if (ofd.ShowDialog() != DialogResult.OK) return;

            List<decimal> config = new List<decimal>();
            string filePath = ofd.FileName;
            StreamReader sr = new StreamReader(filePath);
            int Row = 0;
            while (!sr.EndOfStream)
            {
                string[] Line = sr.ReadLine().Split(':');
                for (int column = 0; column < Line.Length; column++)
                {
                    if(Row == 0)
                    {
                        if (Line[0].Equals("User Configuration"))
                        {
                            MessageBox.Show("Valid");
                        }
                        else
                        {
                            MessageBox.Show("This is not a configuration file.");
                            return;
                        }
                    }
                    else
                    {
                        if (column == 1) config.Add(Convert.ToDecimal(Line[column]));
                    }
                }
                Row++;
            }
            sr.Close();

            LoadConfig(config);
            ToggleUI(true);
        }

        #region Color Pickers
        private void btnPickTeamTextColor_Click(object sender, EventArgs e)
        {
            using var dlg = new ColorDialog
            {
                AllowFullOpen = true,
                FullOpen = true,
                Color = teamTextColor
            };

            if (dlg.ShowDialog(this) != DialogResult.OK)
                return;

            teamTextColor = dlg.Color;
            pnlTeamTextColorPreview.BackColor = teamTextColor;

            lblTeamTextColorRaw.Text =
                $"RGB: {teamTextColor.R},{teamTextColor.G},{teamTextColor.B} " +
                $"(R:{teamTextColor.R:X2} G:{teamTextColor.G:X2} B:{teamTextColor.B:X2})";
        }

        private void btnMatchUpTextColor_Click(object sender, EventArgs e)
        {
            using var dlg = new ColorDialog
            {
                AllowFullOpen = true,
                FullOpen = true,
                Color = matchupTextColor
            };

            if (dlg.ShowDialog(this) != DialogResult.OK)
                return;

            matchupTextColor = dlg.Color;
            pnlMatchUpColorPreview.BackColor = matchupTextColor;

            lblTeamTextColorRaw.Text =
                $"RGB: {matchupTextColor.R},{matchupTextColor.G},{matchupTextColor.B} " +
                $"(R:{matchupTextColor.R:X2} G:{matchupTextColor.G:X2} B:{matchupTextColor.B:X2})";
        }

        #endregion

        #region Dynamic Text Boxes

        private void numPlaysPerGame_ValueChanged(object sender, EventArgs e)
        {
            double ppgVal = Convert.ToDouble(numPlaysPerGame.Value);

            int PPG = Convert.ToInt32((-1.6667 * ppgVal) + 290.67);
            PPGBox.Text = PPG.ToString();
        }

        private void SpeedNerfBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SpeedNerfBox.Checked)
            {
                SpeedNerfAmount.Enabled = true;
                SpeedNerfAmount.ReadOnly = false;

                sbyte speedAmt = ReadSByte(originBase + SpeedNerfAmtOffset);
                double speedVal = Convert.ToDouble(speedAmt) / 255.0 * 100.0;

                // Convert signed byte (-128..127) to percentage 0..100 where mapping is application-defined.
                // If stored value is intended as -value relative to 255, normalize accordingly.
                if (speedVal == 0)
                {
                    SpeedNerfAmount.Value = -20;
                }
                else
                {
                    // Example conversion: map signed byte directly to 0..100 range when positive, otherwise set default
                    SpeedNerfAmount.Value = Math.Round((decimal)speedVal, 0);
                }
            }
            else
            {
                SpeedNerfAmount.Enabled = false;
                SpeedNerfAmount.ReadOnly = true;
            }
        }

        private void OptOutDisabled_CheckedChanged(object sender, EventArgs e)
        {
            if (OptOutBox.Checked)
            {
                numOptOutRating.Enabled = true;
                numOptOutRating.ReadOnly = false;
                numOptOutRating.Value = 80;
            }
            else
            {
                numOptOutRating.Enabled = false;
                numOptOutRating.ReadOnly = true;
                numOptOutRating.Value = 80;
            }
        }

        #endregion


    }
}
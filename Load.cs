using System;
using System.IO;
using System.Security.Policy;

namespace NEXT_Tuning_App
{
    public partial class MainForm : Form
    {

        //Load Default Values from File
        private void LoadValues()
        {
            // Starting Year (read from first offset)
            ushort year = ReadUInt16LE(originBase + StartYearOffsets[0]);
            numStartYear.Value = Math.Clamp((decimal)year, numStartYear.Minimum, numStartYear.Maximum);

            //Plays Per Game Slider
            byte plays = ReadByte(originBase + PlaysPerGameOffset);
            numPlaysPerGame.Value = Math.Clamp(plays, (byte)80, (byte)120);

            //conf champ bids
            byte autoBids = ReadByte(originBase + AutoBidOffset);
            numAutoBids.Value = Math.Clamp(autoBids, (byte)0, (byte)12);

            //Opt-Out
            byte optoutYear = ReadByte(originBase + OptOutYearOffset);
            byte optoutRating = ReadByte(originBase + OptOutRatingOffset);

            if (optoutYear > 3)
            {
                OptOutBox.Checked = false;
                numOptOutRating.Value = 80;
                numOptOutRating.Enabled = false;
            }
            else
            {
                OptOutBox.Checked = true;
                numOptOutRating.Value = optoutRating + 40;
                numOptOutRating.Enabled = true;
            }

            //Bowls count in Rankings
            byte bowlrank = ReadByte(originBase + BowlRankingSkipOffset);
            if (bowlrank == 0x00)
            {
                BowlRankingBox.Checked = true;
            }
            else
            {
                BowlRankingBox.Checked = false;
            }


            //Speed Nerf Mod
            byte[] SpeedNerf1Loaded = new byte[8];
            for (int i = 0; i < SpeedNerf1Loaded.Length; i++)
            {
                SpeedNerf1Loaded[i] = ReadByte(originBase + SpeedNerfOffset1 + i);
            }

            byte[] SpeedNerf2Loaded = new byte[88];
            for (int i = 0; i < SpeedNerf2Loaded.Length; i++)
            {
                SpeedNerf2Loaded[i] = ReadByte(originBase + SpeedNerfOffset2 + i);
            }

            // Compare array contents instead of references
            if (SpeedNerf1Loaded.SequenceEqual(SpeedNerfUpdate1))
            {
                SpeedNerfBox.Checked = true;
            }
            else
            {
                SpeedNerfBox.Checked = false;
            }

            //Fatigue Sliders
            float jv = ReadFloatHighWordOnly(originBase + FatigueJVOffset);
            float v = ReadFloatWordSwapped(originBase + FatigueVarsityOffset);
            float aa = ReadFloatWordSwapped(originBase + FatigueAAOffset);
            float h = ReadFloatWordSwapped(originBase + FatigueHeismanOffset);

            numFatigueJV.Value = (decimal)jv;
            numFatigueVarsity.Value = (decimal)v;
            numFatigueAA.Value = (decimal)aa;
            numFatigueHeisman.Value = (decimal)h;


            //User Team Text Color
            byte r = ReadByte(originBase + UserTeamTextR_Offset);
            byte g = ReadByte(originBase + UserTeamTextG_Offset);
            byte b = ReadByte(originBase + UserTeamTextB_Offset);

            teamTextColor = System.Drawing.Color.FromArgb(r, g, b);
            pnlTeamTextColorPreview.BackColor = teamTextColor;

            lblTeamTextColorRaw.Text = $"RGB: {r},{g},{b} (R:{r:X2} G:{g:X2} B:{b:X2})";

            //Matchup Text Color
            byte r2 = ReadByte(originBase + MatchUpTextR_Offset);
            byte g2 = ReadByte(originBase + MatchUpTextG_Offset);
            byte b2 = ReadByte(originBase + MatchUpTextB_Offset);

            matchupTextColor = System.Drawing.Color.FromArgb(r2, g2, b2);
            pnlMatchUpColorPreview.BackColor = matchupTextColor;

            lblMatchUpColorRaw.Text = $"RGB: {r2},{g2},{b2} (R:{r2:X2} G:{g2:X2} B:{b2:X2})";

            /*
            //Easy Kick
            byte[] EasyKick = new byte[4];
            for (int i = 0; i < EasyKickRevert.Length; i++)
            {
                EasyKick[i] = ReadByte(originBase + EasyKickOffset1 + i);
            }
            // Compare array contents instead of references
            if (EasyKick.SequenceEqual(EasyKickUpdate))
            {
                EasyKickBox.Checked = true;
            }
            else
            {
                EasyKickBox.Checked = false;
            }
            */

            //Kicking Slider 
            float kickingSlider = ReadFloatHighWordOnly(originBase +KickingSliderOffset);
            numKickSlider.Value = Convert.ToDecimal(kickingSlider);
        }


        //Load User Config File Data
        private void LoadConfig(List<decimal> config)
        {
            for (int i = 0; i < config.Count; i++)
            {

                // Starting Year (read from first offset)
                if (i == 0)
                    numStartYear.Value = config[0];

                //Plays Per Game Slider
                else if (i == 1)
                    numPlaysPerGame.Value = config[1];

                //conf champs
                else if (i == 2)
                    numAutoBids.Value = config[2];

                //Opt-Out
                else if (i == 3)
                {
                    if (config[3] == 0)
                    {
                        OptOutBox.Checked = false;
                        numOptOutRating.Value = 45;
                        numOptOutRating.Enabled = false;
                    }
                    else
                    {
                        OptOutBox.Checked = true;
                        numOptOutRating.Value = config[4];
                        numOptOutRating.Enabled = true;
                    }
                }

                //Bowls count in Rankings
                else if (i == 5)
                {
                    if (config[5] == 0)
                    {
                        BowlRankingBox.Checked = false;
                    }
                    else
                    {
                        BowlRankingBox.Checked = true;
                    }
                }

                //Speed Nerf Mod
                else if (i == 6)
                {
                    if (config[6] == 0)
                    {
                        SpeedNerfBox.Checked = false;
                        SpeedNerfAmount.Enabled = false;
                    }
                    else
                    {
                        SpeedNerfBox.Checked = true;
                        SpeedNerfAmount.Value = config[7];
                        SpeedNerfAmount.Enabled = true;
                    }
                }

                //Fatigue Sliders
                else if (i == 8)
                {
                    numFatigueJV.Value = config[8];
                    numFatigueVarsity.Value = config[9];
                    numFatigueAA.Value = config[10];
                    numFatigueHeisman.Value = config[11];
                }

                //User Team Text Color
                else if (i == 12)
                {
                    int r = Convert.ToInt32(config[12]);
                    int g = Convert.ToInt32(config[13]);
                    int b = Convert.ToInt32(config[14]);
                    teamTextColor = System.Drawing.Color.FromArgb(r, g, b);
                    pnlTeamTextColorPreview.BackColor = teamTextColor;
                    lblTeamTextColorRaw.Text = $"RGB: {r},{g},{b} (R:{r:X2} G:{g:X2} B:{b:X2})";
                }

                else if (i == 15)
                {
                    //Matchup Text Color
                    int r2 = Convert.ToInt32(config[15]);
                    int g2 = Convert.ToInt32(config[16]);
                    int b2 = Convert.ToInt32(config[17]);
                    matchupTextColor = System.Drawing.Color.FromArgb(r2, g2, b2);
                    pnlMatchUpColorPreview.BackColor = matchupTextColor;
                    lblMatchUpColorRaw.Text = $"RGB: {r2},{g2},{b2} (R:{r2:X2} G:{g2:X2} B:{b2:X2})";
                }

                /*
                //Easy Kick
                else if (i == 18)
                {
                    if (config[18] == 0)
                    {
                        EasyKickBox.Checked = false;
                        numEasyKick.Enabled = false;
                    }
                    else
                    {
                        EasyKickBox.Checked = true;
                        numEasyKick.Value = config[19];
                        numEasyKick.Enabled = true;
                    }
                }
                */

                //Kicking Slider
                else if (i == 18)
                {
                    KickDiffComboBox.SelectedIndex = Convert.ToInt32(config[18]);
                    numKickSlider.Value = config[19];
                }



            }
        }



    }
}
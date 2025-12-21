using System;
using System.IO;

namespace NEXT_Tuning_App
{
    public partial class MainForm : Form
    {
        //Save Data
        private void btnSave_Click(object sender, EventArgs e)
        {
            Stream myStream = File.Create("user-config.cfg");
            StreamWriter wText = new StreamWriter(myStream);
            //StringBuilder hbuilder = new StringBuilder();

            //write headers
            wText.WriteLine("User Configuration");
            wText.WriteLine("");

            //Save Starting Year
            ushort year = (ushort)numStartYear.Value;
            ushort yearPlus1 = (ushort)(year + 1);

            foreach (int off in StartYearOffsets)
                WriteUInt16LE(originBase + off, year);

            foreach (int off in StartYearPlus1Offsets)
                WriteUInt16LE(originBase + off, yearPlus1);
            wText.WriteLine("Start Year:" + numStartYear.Value);



            //Save Plays Per Game Sim
            WriteByte(originBase + PlaysPerGameOffset, (byte)numPlaysPerGame.Value);
            wText.WriteLine("Sim Plays:" + numPlaysPerGame.Value);


            //Conference Champs
            WriteByte(originBase + AutoBidOffset, (byte)numAutoBids.Value);
            wText.WriteLine("AutoBids:"  + numAutoBids.Value);


            //Opt Out
            if (OptOutBox.Checked)
            {
                WriteByte(originBase + OptOutYearOffset, 3);
                int rating = Convert.ToInt32(numOptOutRating.Value) - 40;
                WriteByte(originBase + OptOutRatingOffset, Convert.ToByte(rating));

                wText.WriteLine("Opt Out:" + 1);
                wText.WriteLine("Opt Out Rating:" + numOptOutRating.Value);
            }
            else
            {
                WriteByte(originBase + OptOutYearOffset, 5);
                WriteByte(originBase + OptOutRatingOffset, 0x28);

                wText.WriteLine("Opt Out:" + 0);
                wText.WriteLine("Opt Out Rating:" + 80);
            }

            //Bowl Ranking Skip
            if (BowlRankingBox.Checked)
            {
                for (int i = 0; i < BowlRankingSkipUpdate.Length; i++)
                {
                    WriteByte(originBase + BowlRankingSkipOffset + i, BowlRankingSkipUpdate[i]);
                }

                wText.WriteLine("Bowl Ranking:" + 1);
            }
            else
            {
                for (int i = 0; i < BowlRankingSkipRevert.Length; i++)
                {
                    WriteByte(originBase + BowlRankingSkipOffset + i, BowlRankingSkipRevert[i]);
                }
                wText.WriteLine("Bowl Ranking:" + 0);

            }


            //Speed Nerf Mod
            if (SpeedNerfBox.Checked)
            {
                for (int i = 0; i < SpeedNerfUpdate1.Length; i++)
                {
                    WriteByte(originBase + SpeedNerfOffset1 + i, SpeedNerfUpdate1[i]);
                }
                for (int i = 0; i < SpeedNerfUpdate2.Length; i++)
                {
                    WriteByte(originBase + SpeedNerfOffset2 + i, SpeedNerfUpdate2[i]);
                }

                int speedAmt = Convert.ToInt32(SpeedNerfAmount.Value) * 255 / 100;
                sbyte speedAmtByte = unchecked((sbyte)speedAmt);
                WriteSByte(originBase + SpeedNerfAmtOffset, speedAmtByte);

                wText.WriteLine("Speed Nerf:" + 1);
                wText.WriteLine("Speed Nerf Amount:" + SpeedNerfAmount.Value);
            }
            else
            {
                for (int i = 0; i < SpeedNerfRevert1.Length; i++)
                {
                    WriteByte(originBase + SpeedNerfOffset1 + i, SpeedNerfRevert1[i]);
                }
                for (int i = 0; i < SpeedNerfRevert2.Length; i++)
                {
                    WriteByte(originBase + SpeedNerfOffset2 + i, SpeedNerfRevert2[i]);
                }

                wText.WriteLine("Speed Nerf:" + 0);
                wText.WriteLine("Speed Nerf Amount:" + -20);
            }

            //Save Fatigue Sliders
            WriteFloatHighWordOnly(originBase + FatigueJVOffset, (float)numFatigueJV.Value);
            WriteFloatWordSwapped(originBase + FatigueVarsityOffset, (float)numFatigueVarsity.Value);
            WriteFloatWordSwapped(originBase + FatigueAAOffset, (float)numFatigueAA.Value);
            WriteFloatWordSwapped(originBase + FatigueHeismanOffset, (float)numFatigueHeisman.Value);
            wText.WriteLine("Fatigue JV:" + numFatigueJV.Value);
            wText.WriteLine("Fatigue Varsity:" + numFatigueVarsity.Value);
            wText.WriteLine("Fatigue All-American:" + numFatigueAA.Value);
            wText.WriteLine("Fatigue Heisman:" + numFatigueHeisman.Value);


            //Save User Text Color
            WriteByte(originBase + UserTeamTextR_Offset, teamTextColor.R);
            WriteByte(originBase + UserTeamTextG_Offset, teamTextColor.G);
            WriteByte(originBase + UserTeamTextB_Offset, teamTextColor.B);
            wText.WriteLine("UserTeam Text Color R:" + teamTextColor.R);
            wText.WriteLine("UserTeam Text Color G:" + teamTextColor.G);
            wText.WriteLine("UserTeam Text Color B:" + teamTextColor.B);


            //Save MatchUp Text Color
            WriteByte(originBase + MatchUpTextR_Offset, matchupTextColor.R);
            WriteByte(originBase + MatchUpTextG_Offset, matchupTextColor.G);
            WriteByte(originBase + MatchUpTextB_Offset, matchupTextColor.B);
            wText.WriteLine("MatchUp Text Color R:" + matchupTextColor.R);
            wText.WriteLine("MatchUp Text Color G:" + matchupTextColor.G);
            wText.WriteLine("MatchUp Text Color B:" + matchupTextColor.B);


            /*
            //Easy Kick Mod
            if (EasyKickBox.Checked)
            {
                for (int i = 0; i < EasyKickUpdate.Length; i++)
                {
                    WriteByte(originBase + EasyKickOffset1 + i, EasyKickUpdate[i]);
                }
                for (int i = 0; i < EasyKickUpdate.Length; i++)
                {
                    WriteByte(originBase + EasyKickOffset2 + i, EasyKickUpdate[i]);
                }

                wText.WriteLine("Easy Kick:" + 1);
                wText.WriteLine("Easy Kick Amount:" + numEasyKick.Value);
            }
            else
            {
                for (int i = 0; i < EasyKickUpdate.Length; i++)
                {
                    WriteByte(originBase + EasyKickOffset1 + i, EasyKickRevert[i]);
                }
                for (int i = 0; i < EasyKickUpdate.Length; i++)
                {
                    WriteByte(originBase + EasyKickOffset2 + i, EasyKickRevert[i]);
                }

                wText.WriteLine("Easy Kick:" + 0);
                wText.WriteLine("Easy Kick Amount:" + 50);
            }
            */


            WriteFloatHighWordOnly(originBase + KickingSliderOffset, (float)numKickSlider.Value);
            wText.WriteLine("User Difficulty:" + KickDiffComboBox.SelectedIndex);
            wText.WriteLine("Kicking Slider:" + numKickSlider.Value);



            //Clear Memory
            fs!.Flush();

            wText.Dispose();
            wText.Close();

            MessageBox.Show("Changes Saved.");

        }
    }
}
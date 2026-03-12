using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEXT_Tuning_App
{
    public partial class MainForm : Form
    {
        private int ConvertSimPlaysPerGame()
        {
            double val = 100;

            double ppgVal = Convert.ToDouble(numPlaysPerGame.Value);

            val = (ppgVal - 290.67) / -1.6667;

            return Convert.ToInt32(val);
        }

        private int ConvertSimPlaysPerGameByteToInt(byte val)
        {
            double ppgVal = 0;

            ppgVal = (Convert.ToInt32(val) * -1.66667) + 290.67;

            return Convert.ToInt32(ppgVal);
        }

        /*
        private byte ConvertKickMeterSliderToByte()
        {
            //KickMeterValue.Text = Convert.ToString(Math.Round(Convert.ToDouble(numKickSlider.Value) - difficultyFactor * difficulty, 0));
            double val = 0;
            double difficultyFactor = 8.33;
            int difficulty = (int)KickDiffComboBox.SelectedIndex;
            int slider = kickMeterBar.Value;

            val = slider + difficultyFactor * difficulty;


            return Convert.ToByte(val);
        }

        private int ConvertKickMeterSliderFloatToInt(float val)
        {
            //KickMeterValue.Text = Convert.ToString(Math.Round(Convert.ToDouble(numKickSlider.Value) - difficultyFactor * difficulty, 0));
            int slider = 0;
            
            double difficultyFactor = 8.33;
            int difficulty = (int)KickDiffComboBox.SelectedIndex;
            slider = Convert.ToInt32(val) - (int)(difficultyFactor * difficulty);

            if(slider < 25) slider = 25;
            else if (slider > 50) slider = 50;
            return slider;
        }
        */
    }
}
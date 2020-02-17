using System;
using System.Collections;
using System.Linq;

namespace MasterMind.Data.DomainClasses
{
    public class GuessResult
    {
        private int _correctColorAndPositionAmount;
        private int _correctColorAmount;

        public string[] Colors { get; set; }

        public virtual int CorrectColorAndPositionAmount => _correctColorAndPositionAmount; //must be virtual for some automated test to work!

        public virtual int CorrectColorAmount => _correctColorAmount; //must be virtual for some automated test to work!

        public GuessResult(string[] colors)
        {
            Colors = colors;
        }

        public void Verify(string[] codeToGuess)
        {
            //Colors: RED GREEN BLUE YELLOW
            //            0   1   2       3
            //CodeToGuess: RED GREEN YELLOW BLUE
            //
            IList colorList = Colors.ToList();
            IList codeList = codeToGuess.ToList();

            for (int i = 0; i < codeToGuess.Length; i++)
            {
                if (Colors[i] == codeToGuess[i])
                {
                    _correctColorAndPositionAmount++;
                    colorList.Remove(Colors[i]);
                    codeList.Remove(codeToGuess[i]);
                }
            }

            //codeList: YELLOW BLUE
            //colorList: BLUE YELLOW
            //--> 
            //codeList: YELLOW
            //colorList: BLUE YELLOW

            for (int i = 0; i < codeList.Count; i++)
            {
                if (codeList.Contains(colorList[i]))
                {
                    _correctColorAmount++;
                    codeList.Remove(colorList[i]);
                    colorList.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}

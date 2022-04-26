using A2CBarros.Forms.Design;
using A2CBarros.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2CBarros.Play
{
    public class Game
    {

        public static DesignerPic SquaresInMaze(int row, int col, DesignerPic[,] squares)
        {
            if (squares[row, col] == null)
            {
                return null;
            }
            return squares[row, col];
        }


        // Check if the color of the box match with the color of the door.
        public static bool IsDoorAndBoxMatched(DesignerPic sidePicture, DesignerPic selPic)
        {
            if ((sidePicture.PicType == DesignerToolEnum.BlueDoor && selPic.PicType == DesignerToolEnum.BlueBox)
                || sidePicture.PicType == DesignerToolEnum.RedDoor && selPic.PicType == DesignerToolEnum.RedBox)
            {
                return true;
            }

            return false;
        }


        // It will appears a message with the picture is not selected
        public static bool IsPicSelected(DesignerPic selectedPicture)
        {
            if (selectedPicture == null)
            {
                MessageBox.Show("Before trying to move, you need to click on image to select and click to move", "Q - Puzzle Game");
                return false;
            }
            return true;
        }

        //IT counts the moviments of the boxes
        public static void MovimentCounter(ref int countMoviment, TextBox BoxesMoving)
        {
            countMoviment += 1;
            BoxesMoving.Text = countMoviment.ToString();
        }

        //Remove the box from the game
        public static void BoxRemover(DesignerPic[,] squares, DesignerPic selPic, Panel pnlMazeStructure)
        {
            squares[selPic.PicRow, selPic.PicColumn] = null;
            pnlMazeStructure.Controls.Remove(selPic);
            selPic = null;
        }






    }
}

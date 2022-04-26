using A2CBarros.Forms.Design;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2CBarros.Menu
{
    public class LoadMaze
    {


        public static bool  isHorizontal;


        public static  DesignerPic LoadPictures(EventHandler PictureBox_Click, DesignerToolEnum squareType, int row, int col )
        {
            if (squareType == DesignerToolEnum.None)
            {
                return null;
            }

            DesignerPic pictureBox = new DesignerPic();
            pictureBox.Size = new Size(60, 60);
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.PicRow = row;
            pictureBox.PicColumn = col;
            pictureBox.Click += new EventHandler(PictureBox_Click);
            pictureBox.SetImage(squareType);

            if (squareType == DesignerToolEnum.BlueBox || squareType == DesignerToolEnum.RedBox)
            {
                pictureBox.Cursor = Cursors.Hand;
            }

            return pictureBox;
        }


        // create the picture box.
        public static void SquaresCreator(DesignerPic[,] squares, int numRows, int numColumns, Panel pnlMazeStructure)
        {
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numColumns; j++)
                {
                    if (squares[i, j] != null)
                    {
                        squares[i, j].Location = new Point(20 + j * 60, 20 + i * 60);
                        pnlMazeStructure.Controls.Add(squares[i, j]);
                    }
                }
            }
        }

        //To unlock the controls buttons
        public static void UnlockControl(bool buttonState, Button moveDown, Button moveUp, Button moveLeft, Button moveRight)
        {
            moveDown.Enabled = buttonState;
            moveUp.Enabled = buttonState;
            moveLeft.Enabled = buttonState;
            moveRight.Enabled = buttonState;
        }

        //It will counting how many Box has in the game and check if the player won.
        public static void BoxCounter(DesignerPic[,] squares, int numRows, int numColumns, Panel pnlMazeStructure, int countMoviment, TextBox boxesMoving, TextBox boxesRemaining, Button btnMoveDown,
            Button btnMoveUp, Button btnMoveLeft, Button btnMoveRight)
        {
            int boxCount = 0;
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numColumns; j++)
                {
                    if (squares[i, j] != null && (squares[i, j].PicType == DesignerToolEnum.BlueBox || squares[i, j].PicType == DesignerToolEnum.RedBox))
                    {
                        boxCount += 1;
                    }
                }
            }
            boxesRemaining.Text = boxCount.ToString();
            PlayerWin(boxCount, pnlMazeStructure, countMoviment, boxesMoving, boxesRemaining, btnMoveDown, btnMoveUp, btnMoveLeft, btnMoveRight);
        }

        // Once the player place all the boxes to the same door color, the game will end with a message, it will lock the controls buttons.
        public static void PlayerWin(int boxCount, Panel pnlMazeStructure, int countMoviment, TextBox boxesMoving, TextBox boxesRemaining, Button btnMoveDown,
            Button btnMoveUp, Button btnMoveLeft, Button btnMoveRight)
        {
            if (boxCount == 0)
            {
                MessageBox.Show("Congratulations, you won!\nThis is the end of the Game.\nIf you want to play more, please load a new Maze or keep using the same to make more effiecient moves.", "Q - Puzzle Game");

                countMoviment = 0;
                boxesMoving.Text = "0";
                boxesRemaining.Text = "0";
                pnlMazeStructure.Controls.Clear();

                UnlockControl(false, btnMoveDown, btnMoveUp, btnMoveLeft, btnMoveRight);
            }
        }

    }
}

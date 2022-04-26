using A2CBarros.Forms.Design;
using A2CBarros.Menu;
using A2CBarros.Play;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2CBarros
{
    public partial class PlayGame : Form
    {



        private int numRows, numColumns, countMoviment = 0;
        private bool isHorizontal;
        private StreamReader reader;
        private DesignerPic selPic;
        private DesignerPic[,] squares;



        public PlayGame()
        {
            InitializeComponent();
            txtBoxesMoving.Enabled = false;
            txtBoxesRemaining.Enabled = false;
            LoadMaze.UnlockControl(false, btnMoveDown,btnMoveUp,btnMoveLeft,btnMoveRight);
        }



        //Load the maze by .txt file
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog openFile = new OpenFileDialog
                {
                    InitialDirectory = @"C:\",
                    Multiselect = false,
                    Title = "Open"

                };

                MazeGenerator(openFile);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something happened:\n" + ex.Message, "Q - Puzzle Game");
            }

            }



        //buttons to move the boxes
        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            if (Game.IsPicSelected(selPic))
            {
                isHorizontal = true;
                Game.MovimentCounter(ref countMoviment, txtBoxesMoving);
                BoxMoviment(1);
            }
        }
        //buttons to move the boxes
        private void btnMoveDown_Click(object sender, EventArgs e)
        {

            if (Game.IsPicSelected(selPic))
            {
                isHorizontal = false;
                Game.MovimentCounter(ref countMoviment, txtBoxesMoving);
                BoxMoviment(1);
            }

        }
        //buttons to move the boxes
        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            if (Game.IsPicSelected(selPic))
            {
                isHorizontal = true;
                Game.MovimentCounter(ref countMoviment, txtBoxesMoving);
                BoxMoviment(-1);
            }
        }
        //buttons to move the boxes
        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            if (Game.IsPicSelected(selPic))
            {
                isHorizontal = false;
                Game.MovimentCounter(ref countMoviment, txtBoxesMoving);
                BoxMoviment(-1);
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //PictureBox_Click event
        private void PictureBox_Click(object sender, EventArgs e)
        {
            DesignerPic picClicked = sender as DesignerPic;

            if (picClicked.PicType == DesignerToolEnum.RedBox || picClicked.PicType == DesignerToolEnum.BlueBox)
            {
                if (selPic != null)
                {
                    DesignerPic.UnselectTool(selPic, 60);
                }

                selPic = picClicked;
                selPic.Left = 20 + 60 * selPic.PicColumn;
                selPic.Top = 20 + 60 * selPic.PicRow;

                DesignerPic.SelectTool(selPic, 60);

            }
        }


        //It makes the box move
        private void BoxMoviment(int displacement)
        {
            DesignerPic sidePicture = isHorizontal
                ? Game.SquaresInMaze(selPic.PicRow, selPic.PicColumn + displacement, squares)
                : Game.SquaresInMaze(selPic.PicRow + displacement, selPic.PicColumn, squares);
            while (sidePicture == null)
            {
                int antecedentRow = selPic.PicRow;
                int antecedentCol = selPic.PicColumn;
                if (isHorizontal)
                {
                    selPic.PicColumn += displacement;
                    Thread.Sleep(10);
                    selPic.Left = 20 + 60 * (selPic.PicColumn);
                    Thread.Sleep(10);
                    squares[antecedentRow, antecedentCol] = null;
                    squares[selPic.PicRow, selPic.PicColumn] = selPic;
                    sidePicture = Game.SquaresInMaze(selPic.PicRow, selPic.PicColumn + displacement, squares);
                }
                else
                {
                    selPic.PicRow += displacement;
                    Thread.Sleep(10);
                    selPic.Top = 20 + 60 * (selPic.PicRow);
                    Thread.Sleep(10);
                    squares[antecedentRow, antecedentCol] = null;
                    squares[selPic.PicRow, selPic.PicColumn] = selPic;
                    sidePicture = Game.SquaresInMaze(selPic.PicRow + displacement, selPic.PicColumn, squares);
                }
            }
            if (Game.IsDoorAndBoxMatched(sidePicture, selPic))
            {
                Game.BoxRemover(squares, selPic, pnlMazeStructure);
                LoadMaze.BoxCounter(squares, numRows, numColumns, pnlMazeStructure, countMoviment, txtBoxesMoving, txtBoxesRemaining, btnMoveDown, btnMoveUp, btnMoveLeft, btnMoveRight);
            }
        }

        //It generate the maze in Panel
        public void MazeGenerator(OpenFileDialog openFile)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetFullPath(openFile.FileName);
                using (reader = new StreamReader(path))
                {
                    numRows = Convert.ToInt32(reader.ReadLine());
                    numColumns = Convert.ToInt32(reader.ReadLine());
                    int row,col, squareType;
                    squares = new DesignerPic[numRows, numColumns];

                    while (!reader.EndOfStream)
                    {
                        row = Convert.ToInt32(reader.ReadLine());
                        col = Convert.ToInt32(reader.ReadLine());
                        squareType = Convert.ToInt32(reader.ReadLine());

                        squares[row, col] = LoadMaze.LoadPictures( PictureBox_Click, (DesignerToolEnum)squareType, row, col);

                    }

                    countMoviment = 0;
                    txtBoxesMoving.Text = "0";
                    txtBoxesRemaining.Text = "0";

                    pnlMazeStructure.Controls.Clear();
                    LoadMaze.SquaresCreator(squares, numRows, numColumns, pnlMazeStructure);
                    LoadMaze.UnlockControl(true, btnMoveDown, btnMoveUp, btnMoveLeft, btnMoveRight);
                    LoadMaze.BoxCounter(squares, numRows, numColumns, pnlMazeStructure, countMoviment, txtBoxesMoving, txtBoxesRemaining, btnMoveDown, btnMoveUp, btnMoveLeft, btnMoveRight);
                }
            }
        }
    }

    }









    

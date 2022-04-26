using A2CBarros.Design;
using A2CBarros.Forms.Design;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2CBarros
{
    public partial class Designs : Form
    {

        DesignerToolEnum picChosen;

                

        
        private List<string> errors = new List<string>();



        private string message = "";

        public Designs()
        {
            InitializeComponent();
            DesignerPic.PicSize(pnlMazeBuilder);
            btnEnableGenerate.Visible = false;
        }

        //In case the user make any problem, it will show which the problem was. Otherwise, it will generate grid for the user to changes the pic type.
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if(PicBoxGen.ErrorGeneratorMaze(tBoxRows.Text,tBoxColumns.Text).Count() != 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, PicBoxGen.ErrorGeneratorMaze(tBoxRows.Text, tBoxColumns.Text).ToArray()), "Q - Puzzle Game");
            }
            else
            {
                PicBoxGen.GenerateMazeStructureGUI(int.Parse(tBoxRows.Text), int.Parse(tBoxColumns.Text), pnlMazeStructure, PictureBox_Click);
                btnEnableGenerate.Visible = true;
                pnlSquareBuilder.Enabled = false;
                saveToolStripMenuItem.Enabled = true;
            }
        }

        //It set a image of a picture if the user clicked in the pictures to build the maze.
        private void PictureBox_MouseMove(object sender, EventArgs e)
        {
            DesignerPic picClicked = sender as DesignerPic;
            picClicked.SetImage(picChosen);
        }



        //It set a image of a picture if the user clicked in the pictures to build the maze.
        private void PictureBox_Click(object sender, EventArgs e)
        {
            DesignerPic picClicked = sender as DesignerPic;
            picClicked.SetImage(picChosen);
        }

        //Once the user clicked in the picture that he want build the maze, it will store as a image, changing the picture in the panel interface
        //to a smaller one in order to the user identify which picture he is using.
        private void pBoxNone_Click(object sender, EventArgs e)
        {
            picChosen = DesignerToolEnum.None;
            DesignerPic.PicSize(pnlMazeBuilder);
            DesignerPic.SelectImagePicture(pBoxNone, 50);
        }

        //Once the user clicked in the picture that he want build the maze, it will store as a image, changing the picture in the panel interface
        //to a smaller one in order to the user identify which picture he is using.
        private void pBoxWall_Click(object sender, EventArgs e)
        {
            picChosen = DesignerToolEnum.Wall;
            DesignerPic.PicSize(pnlMazeBuilder);
            DesignerPic.SelectImagePicture(pBoxWall, 50);

        }

        //Once the user clicked in the picture that he want build the maze, it will store as a image, changing the picture in the panel interface
        //to a smaller one in order to the user identify which picture he is using.
        private void pBoxBlueDoor_Click(object sender, EventArgs e)
        {
            picChosen = DesignerToolEnum.BlueDoor;
            DesignerPic.PicSize(pnlMazeBuilder);
            DesignerPic.SelectImagePicture(pBoxBlueDoor, 50);
        }

        //Once the user clicked in the picture that he want build the maze, it will store as a image, changing the picture in the panel interface
        //to a smaller one in order to the user identify which picture he is using.
        private void pBoxBlueBox_Click(object sender, EventArgs e)
        {
            picChosen = DesignerToolEnum.BlueBox;
            DesignerPic.PicSize(pnlMazeBuilder);
            DesignerPic.SelectImagePicture(pBoxBlueBox, 50);
        }

        //Once the user clicked in the picture that he want build the maze, it will store as a image, changing the picture in the panel interface
        //to a smaller one in order to the user identify which picture he is using.
        private void pBoxRedDoor_Click(object sender, EventArgs e)
        {
            picChosen = DesignerToolEnum.RedDoor;
            DesignerPic.PicSize(pnlMazeBuilder);
            DesignerPic.SelectImagePicture(pBoxRedDoor, 50);
        }

        //Once the user clicked in the picture that he want build the maze, it will store as a image, changing the picture in the panel interface
        //to a smaller one in order to the user identify which picture he is using.
        private void pBoxRedBox_Click(object sender, EventArgs e)
        {
            picChosen = DesignerToolEnum.RedBox;
            DesignerPic.PicSize(pnlMazeBuilder);
            DesignerPic.SelectImagePicture(pBoxRedBox, 50);
        }

        //It will save the file. Howerver, if it has any problem, it will show the problem to the user.
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveMaze.SaveMessage(tBoxRows.Text,tBoxColumns.Text,pnlMazeStructure,errors).Count() != 0)
            { 
                MessageBox.Show(string.Join(Environment.NewLine, SaveMaze.SaveMessage(tBoxRows.Text, tBoxColumns.Text, pnlMazeStructure, errors).ToArray()), "Q - Puzzle Game");
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //It allow the user to generate the maze again from the start.
        private void newMazeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEnableGenerate.Visible = false;
            saveToolStripMenuItem.Enabled = true;
            pnlMazeStructure.Controls.Clear();
            tBoxRows.Text = "0";
            tBoxColumns.Text = "0";
            pnlMazeBuilder.Enabled = true;
            pnlSquareBuilder.Enabled = true;
            pnlMazeStructure.Enabled = true;
        }


        //Open a messagebox with instructons for the users showing how they can build the maze. 
        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            message = "Welcome to Q - Puzzle Game Designs.\n" +
                      "Here, you will be able to create your own Maze.\n" +
                      "However, before you start creating your own maze, here is some instructons:\n" +
                      "You have to Generate using the number of columns and rows of your maze.\n " +
                      "Once the squares are generated, if you click in the picture of the Maze Builder, " +
                      "you will store this image. Click in the squares that was generated and you will be able" +
                      "to set a new image in the square." +
                      "When you are done, you can save your maze as a .txt file clicking in Menu / Save and it is done.";


            MessageBox.Show(message, "Q - Puzzle Game");



        }

        private void btnEnableGenerate_Click(object sender, EventArgs e)
        {
            pnlSquareBuilder.Enabled = true;
            saveToolStripMenuItem.Enabled = false;
            btnEnableGenerate.Visible = false;
        }
    }

}

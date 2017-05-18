using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**TO DO LIST
 * 
 * TODO: Istället för hårdkodade vinstscenarion:
 *  kontaktera(?) strängarna i gameField arrayen, horisontellt, vertikalt och diagonalt
 *  leta efter tex "RRRR" eller "BBBB" (typ if string.contains("RRRR") red wins)
 * */

namespace ConnectFourV1._0
{
    public partial class Form1 : Form
    {
        bool redTurn = true; // keeps track on which colors turn it is. Green when false
        string theWinnerIs = "";

        int countA = 0; // keeps count on which button to change in the column
        int countB = 0; // keeps count on which button to change in the column
        int countC = 0; // keeps count on which button to change in the column
        int countD = 0; // keeps count on which button to change in the column
        int countE = 0; // keeps count on which button to change in the column
        int countF = 0; // keeps count on which button to change in the column
        int countG = 0; // keeps count on which button to change in the column

        static string[,] gameField = new string[6, 7] // creates array of 6 rows and 7 columns [R,C]
        {
            { "A6", "B6", "C6", "D6", "E6", "F6", "G6"},
            { "A5", "B5", "C5", "D5", "E5", "F5", "G5"},
            { "A4", "B4", "C4", "D4", "E4", "F4", "G4"},
            { "A3", "B3", "C3", "D3", "E3", "F3", "G3"},
            { "A2", "B2", "C2", "D2", "E2", "F2", "G2"},
            { "A1", "B1", "C1", "D1", "E1", "F1", "G1"}
        };

        public Form1()
        {
            InitializeComponent();
        }


        //CHANGES COLOR ON ADD BUTTONS TO CORRESPONDENT PLAYERS TURN WHEN HOVERED
        private void buttonAddColumnA_MouseEnter(object sender, EventArgs e)
        {
            if (redTurn)
            {
                buttonAddColumnA.BackColor = Color.Crimson;
            }
            else if (!redTurn)
            {
                buttonAddColumnA.BackColor = Color.LimeGreen;
            }
        }

        private void buttonAddColumnB_MouseEnter(object sender, EventArgs e)
        {
            if (redTurn)
            {
                buttonAddColumnB.BackColor = Color.Crimson;
            }
            else if (!redTurn)
            {
                buttonAddColumnB.BackColor = Color.LimeGreen;
            }
        }

        private void buttonAddColumnC_MouseEnter(object sender, EventArgs e)
        {
            if (redTurn)
            {
                buttonAddColumnC.BackColor = Color.Crimson;
            }
            else if (!redTurn)
            {
                buttonAddColumnC.BackColor = Color.LimeGreen;
            }
        }

        private void buttonAddColumnD_MouseEnter(object sender, EventArgs e)
        {
            if (redTurn)
            {
                buttonAddColumnD.BackColor = Color.Crimson;
            }
            else if (!redTurn)
            {
                buttonAddColumnD.BackColor = Color.LimeGreen;
            }
        }

        private void buttonAddColumnE_MouseEnter(object sender, EventArgs e)
        {
            if (redTurn)
            {
                buttonAddColumnE.BackColor = Color.Crimson;
            }
            else if (!redTurn)
            {
                buttonAddColumnE.BackColor = Color.LimeGreen;
            }
        }

        private void buttonAddColumnF_MouseEnter(object sender, EventArgs e)
        {
            if (redTurn)
            {
                buttonAddColumnF.BackColor = Color.Crimson;
            }
            else if (!redTurn)
            {
                buttonAddColumnF.BackColor = Color.LimeGreen;
            }
        }

        private void buttonAddColumnG_MouseEnter(object sender, EventArgs e)
        {
            if (redTurn)
            {
                buttonAddColumnG.BackColor = Color.Crimson;
            }
            else if (!redTurn)
            {
                buttonAddColumnG.BackColor = Color.LimeGreen;
            }
        }

        //CHANGES COLOR ON ADD BUTTONS BACK TO GREY WHEN NO LONGER HOVERED
        private void buttonAddColumnA_MouseLeave(object sender, EventArgs e)
        {
            buttonAddColumnA.BackColor = Color.LightGray;
        }

        private void buttonAddColumnB_MouseLeave(object sender, EventArgs e)
        {
            buttonAddColumnB.BackColor = Color.LightGray;
        }

        private void buttonAddColumnC_MouseLeave(object sender, EventArgs e)
        {
            buttonAddColumnC.BackColor = Color.LightGray;
        }

        private void buttonAddColumnD_MouseLeave(object sender, EventArgs e)
        {
            buttonAddColumnD.BackColor = Color.LightGray;
        }

        private void buttonAddColumnE_MouseLeave(object sender, EventArgs e)
        {
            buttonAddColumnE.BackColor = Color.LightGray;
        }

        private void buttonAddColumnF_MouseLeave(object sender, EventArgs e)
        {
            buttonAddColumnF.BackColor = Color.LightGray;
        }

        private void buttonAddColumnG_MouseLeave(object sender, EventArgs e)
        {
            buttonAddColumnG.BackColor = Color.LightGray;
        }


        //ADDS TOKEN TO CORRECT ROW OF COLUMNS WHEN ADD BUTTON IS CLICKED
        private void buttonAddColumnA_Click(object sender, EventArgs e)
        {
            countA++; // adds to the count of that column

            // disables the addCol button when the column is full
            if (countA == 6)
                buttonAddColumnA.Enabled = false;

            if (redTurn)
            {
                redTurn = !redTurn; // flips the turn

                // adds a brick to the correct row of column A
                switch (countA)
                {
                    case 1:
                        A1.BackColor = Color.Crimson; // changes color
                        gameField[5, 0] = "R"; // adds the color to the gameField array
                        break;
                    case 2:
                        A2.BackColor = Color.Crimson; // changes color
                        gameField[4, 0] = "R"; // adds the color to the gameField array
                        break;
                    case 3:
                        A3.BackColor = Color.Crimson; // changes color
                        gameField[3, 0] = "R"; // adds the color to the gameField array
                        break;
                    case 4:
                        A4.BackColor = Color.Crimson; // changes color
                        gameField[2, 0] = "R"; // adds the color to the gameField array
                        break;
                    case 5:
                        A5.BackColor = Color.Crimson; // changes color
                        gameField[1, 0] = "R"; // adds the color to the gameField array
                        break;
                    case 6:
                        A6.BackColor = Color.Crimson; // changes color
                        gameField[0, 0] = "R"; // adds the color to the gameField array
                        break;
                    default:
                        break;
                }
            }
            else if (!redTurn) // if green turn
            {
                redTurn = !redTurn; // flips the turn

                // adds a brick to the correct row of column
                switch (countA)
                {
                    case 1:
                        A1.BackColor = Color.LimeGreen; // changes color
                        gameField[5, 0] = "B";
                        break;
                    case 2:
                        A2.BackColor = Color.LimeGreen; // changes color
                        gameField[4, 0] = "B";
                        break;
                    case 3:
                        A3.BackColor = Color.LimeGreen; // changes color
                        gameField[3, 0] = "B";
                        break;
                    case 4:
                        A4.BackColor = Color.LimeGreen; // changes color
                        gameField[2, 0] = "B";
                        break;
                    case 5:
                        A5.BackColor = Color.LimeGreen; // changes color
                        gameField[1, 0] = "B";
                        break;
                    case 6:
                        A6.BackColor = Color.LimeGreen; // changes color
                        gameField[0, 0] = "B";
                        break;
                    default:
                        break;
                }
            }

            CheckForWinner();
        }

        private void buttonAddColumnB_Click(object sender, EventArgs e)
        {
            countB++; // adds to the count of that column

            // disables the addCol button when the column is full
            if (countB == 6)
                buttonAddColumnB.Enabled = false;

            if (redTurn)
            {
                redTurn = !redTurn; // flips the turn

                // adds a brick to the correct row of column A
                switch (countB)
                {
                    case 1:
                        B1.BackColor = Color.Crimson; // changes color
                        gameField[5, 1] = "R"; // adds the color to the gameField array
                        break;
                    case 2:
                        B2.BackColor = Color.Crimson; // changes color
                        gameField[4, 1] = "R"; // adds the color to the gameField array
                        break;
                    case 3:
                        B3.BackColor = Color.Crimson; // changes color
                        gameField[3, 1] = "R"; // adds the color to the gameField array
                        break;
                    case 4:
                        B4.BackColor = Color.Crimson; // changes color
                        gameField[2, 1] = "R"; // adds the color to the gameField array
                        break;
                    case 5:
                        B5.BackColor = Color.Crimson; // changes color
                        gameField[1, 1] = "R"; // adds the color to the gameField array
                        break;
                    case 6:
                        B6.BackColor = Color.Crimson; // changes color
                        gameField[0, 1] = "R"; // adds the color to the gameField array
                        break;
                    default:
                        break;
                }
            }
            else if (!redTurn) // if green turn
            {
                redTurn = !redTurn; // flips the turn

                // adds a brick to the correct row of column
                switch (countB)
                {
                    case 1:
                        B1.BackColor = Color.LimeGreen; // changes color
                        gameField[5, 1] = "B";
                        break;
                    case 2:
                        B2.BackColor = Color.LimeGreen; // changes color
                        gameField[4, 1] = "B";
                        break;
                    case 3:
                        B3.BackColor = Color.LimeGreen; // changes color
                        gameField[3, 1] = "B";
                        break;
                    case 4:
                        B4.BackColor = Color.LimeGreen; // changes color
                        gameField[2, 1] = "B";
                        break;
                    case 5:
                        B5.BackColor = Color.LimeGreen; // changes color
                        gameField[1, 1] = "B";
                        break;
                    case 6:
                        B6.BackColor = Color.LimeGreen; // changes color
                        gameField[0, 1] = "B";
                        break;
                    default:
                        break;
                }
            }

            CheckForWinner();
        }

        private void buttonAddColumnC_Click(object sender, EventArgs e)
        {
            countC++; // adds to the count of that column

            // disables the addCol button when the column is full
            if (countC == 6)
                buttonAddColumnC.Enabled = false;

            if (redTurn)
            {
                redTurn = !redTurn; // flips the turn

                // adds a brick to the correct row of column A
                switch (countC)
                {
                    case 1:
                        C1.BackColor = Color.Crimson; // changes color
                        gameField[5, 2] = "R"; // adds the color to the gameField array
                        break;
                    case 2:
                        C2.BackColor = Color.Crimson; // changes color
                        gameField[4, 2] = "R"; // adds the color to the gameField array
                        break;
                    case 3:
                        C3.BackColor = Color.Crimson; // changes color
                        gameField[3, 2] = "R"; // adds the color to the gameField array
                        break;
                    case 4:
                        C4.BackColor = Color.Crimson; // changes color
                        gameField[2, 2] = "R"; // adds the color to the gameField array
                        break;
                    case 5:
                        C5.BackColor = Color.Crimson; // changes color
                        gameField[1, 2] = "R"; // adds the color to the gameField array
                        break;
                    case 6:
                        C6.BackColor = Color.Crimson; // changes color
                        gameField[0, 2] = "R"; // adds the color to the gameField array
                        break;
                    default:
                        break;
                }
            }
            else if (!redTurn) // if green turn
            {
                redTurn = !redTurn; // flips the turn

                // adds a brick to the correct row of column
                switch (countC)
                {
                    case 1:
                        C1.BackColor = Color.LimeGreen; // changes color
                        gameField[5, 2] = "B";
                        break;
                    case 2:
                        C2.BackColor = Color.LimeGreen; // changes color
                        gameField[4, 2] = "B";
                        break;
                    case 3:
                        C3.BackColor = Color.LimeGreen; // changes color
                        gameField[3, 2] = "B";
                        break;
                    case 4:
                        C4.BackColor = Color.LimeGreen; // changes color
                        gameField[2, 2] = "B";
                        break;
                    case 5:
                        C5.BackColor = Color.LimeGreen; // changes color
                        gameField[1, 2] = "B";
                        break;
                    case 6:
                        C6.BackColor = Color.LimeGreen; // changes color
                        gameField[0, 2] = "B";
                        break;
                    default:
                        break;
                }
            }

            CheckForWinner();
        }

        private void buttonAddColumnD_Click(object sender, EventArgs e)
        {
            countD++; // adds to the count of that column

            // disables the addCol button when the column is full
            if (countD == 6)
                buttonAddColumnD.Enabled = false;

            if (redTurn)
            {
                redTurn = !redTurn; // flips the turn

                // adds a brick to the correct row of column A
                switch (countD)
                {
                    case 1:
                        D1.BackColor = Color.Crimson; // changes color
                        gameField[5, 3] = "R"; // adds the color to the gameField array
                        break;
                    case 2:
                        D2.BackColor = Color.Crimson; // changes color
                        gameField[4, 3] = "R"; // adds the color to the gameField array
                        break;
                    case 3:
                        D3.BackColor = Color.Crimson; // changes color
                        gameField[3, 3] = "R"; // adds the color to the gameField array
                        break;
                    case 4:
                        D4.BackColor = Color.Crimson; // changes color
                        gameField[2, 3] = "R"; // adds the color to the gameField array
                        break;
                    case 5:
                        D5.BackColor = Color.Crimson; // changes color
                        gameField[1, 3] = "R"; // adds the color to the gameField array
                        break;
                    case 6:
                        D6.BackColor = Color.Crimson; // changes color
                        gameField[0, 3] = "R"; // adds the color to the gameField array
                        break;
                    default:
                        break;
                }
            }
            else if (!redTurn) // if green turn
            {
                redTurn = !redTurn; // flips the turn

                // adds a brick to the correct row of column
                switch (countD)
                {
                    case 1:
                        D1.BackColor = Color.LimeGreen; // changes color
                        gameField[5, 3] = "B";
                        break;
                    case 2:
                        D2.BackColor = Color.LimeGreen; // changes color
                        gameField[4, 3] = "B";
                        break;
                    case 3:
                        D3.BackColor = Color.LimeGreen; // changes color
                        gameField[3, 3] = "B";
                        break;
                    case 4:
                        D4.BackColor = Color.LimeGreen; // changes color
                        gameField[2, 3] = "B";
                        break;
                    case 5:
                        D5.BackColor = Color.LimeGreen; // changes color
                        gameField[1, 3] = "B";
                        break;
                    case 6:
                        D6.BackColor = Color.LimeGreen; // changes color
                        gameField[0, 3] = "B";
                        break;
                    default:
                        break;
                }
            }

            CheckForWinner();
        }

        private void buttonAddColumnE_Click(object sender, EventArgs e)
        {
            countE++; // adds to the count of that column

            // disables the addCol button when the column is full
            if (countE == 6)
                buttonAddColumnE.Enabled = false;

            if (redTurn)
            {
                redTurn = !redTurn; // flips the turn

                // adds a brick to the correct row of column A
                switch (countE)
                {
                    case 1:
                        E1.BackColor = Color.Crimson; // changes color
                        gameField[5, 4] = "R"; // adds the color to the gameField array
                        break;
                    case 2:
                        E2.BackColor = Color.Crimson; // changes color
                        gameField[4, 4] = "R"; // adds the color to the gameField array
                        break;
                    case 3:
                        E3.BackColor = Color.Crimson; // changes color
                        gameField[3, 4] = "R"; // adds the color to the gameField array
                        break;
                    case 4:
                        E4.BackColor = Color.Crimson; // changes color
                        gameField[2, 4] = "R"; // adds the color to the gameField array
                        break;
                    case 5:
                        E5.BackColor = Color.Crimson; // changes color
                        gameField[1, 4] = "R"; // adds the color to the gameField array
                        break;
                    case 6:
                        E6.BackColor = Color.Crimson; // changes color
                        gameField[0, 4] = "R"; // adds the color to the gameField array
                        break;
                    default:
                        break;
                }
            }
            else if (!redTurn) // if green turn
            {
                redTurn = !redTurn; // flips the turn

                // adds a brick to the correct row of column
                switch (countE)
                {
                    case 1:
                        E1.BackColor = Color.LimeGreen; // changes color
                        gameField[5, 4] = "B";
                        break;
                    case 2:
                        E2.BackColor = Color.LimeGreen; // changes color
                        gameField[4, 4] = "B";
                        break;
                    case 3:
                        E3.BackColor = Color.LimeGreen; // changes color
                        gameField[3, 4] = "B";
                        break;
                    case 4:
                        E4.BackColor = Color.LimeGreen; // changes color
                        gameField[2, 4] = "B";
                        break;
                    case 5:
                        E5.BackColor = Color.LimeGreen; // changes color
                        gameField[1, 4] = "B";
                        break;
                    case 6:
                        E6.BackColor = Color.LimeGreen; // changes color
                        gameField[0, 4] = "B";
                        break;
                    default:
                        break;
                }
            }

            CheckForWinner();
        }

        private void buttonAddColumnF_Click(object sender, EventArgs e)
        {
            countF++; // adds to the count of that column

            // disables the addCol button when the column is full
            if (countF == 6)
                buttonAddColumnF.Enabled = false;

            if (redTurn)
            {
                redTurn = !redTurn; // flips the turn

                // adds a brick to the correct row of column A
                switch (countF)
                {
                    case 1:
                        F1.BackColor = Color.Crimson; // changes color
                        gameField[5, 5] = "R"; // adds the color to the gameField array
                        break;
                    case 2:
                        F2.BackColor = Color.Crimson; // changes color
                        gameField[4, 5] = "R"; // adds the color to the gameField array
                        break;
                    case 3:
                        F3.BackColor = Color.Crimson; // changes color
                        gameField[3, 5] = "R"; // adds the color to the gameField array
                        break;
                    case 4:
                        F4.BackColor = Color.Crimson; // changes color
                        gameField[2, 5] = "R"; // adds the color to the gameField array
                        break;
                    case 5:
                        F5.BackColor = Color.Crimson; // changes color
                        gameField[1, 5] = "R"; // adds the color to the gameField array
                        break;
                    case 6:
                        F6.BackColor = Color.Crimson; // changes color
                        gameField[0, 5] = "R"; // adds the color to the gameField array
                        break;
                    default:
                        break;
                }
            }
            else if (!redTurn) // if green turn
            {
                redTurn = !redTurn; // flips the turn

                // adds a brick to the correct row of column
                switch (countF)
                {
                    case 1:
                        F1.BackColor = Color.LimeGreen; // changes color
                        gameField[5, 5] = "B";
                        break;
                    case 2:
                        F2.BackColor = Color.LimeGreen; // changes color
                        gameField[4, 5] = "B";
                        break;
                    case 3:
                        F3.BackColor = Color.LimeGreen; // changes color
                        gameField[3, 5] = "B";
                        break;
                    case 4:
                        F4.BackColor = Color.LimeGreen; // changes color
                        gameField[2, 5] = "B";
                        break;
                    case 5:
                        F5.BackColor = Color.LimeGreen; // changes color
                        gameField[1, 5] = "B";
                        break;
                    case 6:
                        F6.BackColor = Color.LimeGreen; // changes color
                        gameField[0, 5] = "B";
                        break;
                    default:
                        break;
                }
            }

            CheckForWinner();
        }

        private void buttonAddColumnG_Click(object sender, EventArgs e)
        {
            countG++; // adds to the count of that column

            // disables the addCol button when the column is full
            if (countG == 6)
                buttonAddColumnG.Enabled = false;

            if (redTurn)
            {
                redTurn = !redTurn; // flips the turn

                // adds a brick to the correct row of column A
                switch (countG)
                {
                    case 1:
                        G1.BackColor = Color.Crimson; // changes color
                        gameField[5, 6] = "R"; // adds the color to the gameField array
                        break;
                    case 2:
                        G2.BackColor = Color.Crimson; // changes color
                        gameField[4, 6] = "R"; // adds the color to the gameField array
                        break;
                    case 3:
                        G3.BackColor = Color.Crimson; // changes color
                        gameField[3, 6] = "R"; // adds the color to the gameField array
                        break;
                    case 4:
                        G4.BackColor = Color.Crimson; // changes color
                        gameField[2, 6] = "R"; // adds the color to the gameField array
                        break;
                    case 5:
                        G5.BackColor = Color.Crimson; // changes color
                        gameField[1, 6] = "R"; // adds the color to the gameField array
                        break;
                    case 6:
                        G6.BackColor = Color.Crimson; // changes color
                        gameField[0, 6] = "R"; // adds the color to the gameField array
                        break;
                    default:
                        break;
                }
            }
            else if (!redTurn) // if green turn
            {
                redTurn = !redTurn; // flips the turn

                // adds a brick to the correct row of column
                switch (countG)
                {
                    case 1:
                        G1.BackColor = Color.LimeGreen; // changes color
                        gameField[5, 6] = "B";
                        break;
                    case 2:
                        G2.BackColor = Color.LimeGreen; // changes color
                        gameField[4, 6] = "B";
                        break;
                    case 3:
                        G3.BackColor = Color.LimeGreen; // changes color
                        gameField[3, 6] = "B";
                        break;
                    case 4:
                        G4.BackColor = Color.LimeGreen; // changes color
                        gameField[2, 6] = "B";
                        break;
                    case 5:
                        G5.BackColor = Color.LimeGreen; // changes color
                        gameField[1, 6] = "B";
                        break;
                    case 6:
                        G6.BackColor = Color.LimeGreen; // changes color
                        gameField[0, 6] = "B";
                        break;
                    default:
                        break;
                }
            }

            CheckForWinner();
        }

        string GetWinner()
        {
            if (gameField[0, 0] == "B" && gameField[0, 1] == "B" && gameField[0, 2] == "B" && gameField[0, 3] == "B") { return "B"; }
            if (gameField[0, 0] == "R" && gameField[0, 1] == "R" && gameField[0, 2] == "R" && gameField[0, 3] == "R") { return "R"; }
            if (gameField[0, 1] == "B" && gameField[0, 2] == "B" && gameField[0, 3] == "B" && gameField[0, 4] == "B") { return "B"; }
            if (gameField[0, 1] == "R" && gameField[0, 2] == "R" && gameField[0, 3] == "R" && gameField[0, 4] == "R") { return "R"; }
            if (gameField[0, 2] == "B" && gameField[0, 3] == "B" && gameField[0, 4] == "B" && gameField[0, 5] == "B") { return "B"; }
            if (gameField[0, 2] == "R" && gameField[0, 3] == "R" && gameField[0, 4] == "R" && gameField[0, 5] == "R") { return "R"; }
            if (gameField[0, 3] == "B" && gameField[0, 4] == "B" && gameField[0, 5] == "B" && gameField[0, 6] == "B") { return "B"; }
            if (gameField[0, 3] == "R" && gameField[0, 4] == "R" && gameField[0, 5] == "R" && gameField[0, 6] == "R") { return "R"; }
            if (gameField[1, 0] == "B" && gameField[1, 1] == "B" && gameField[1, 2] == "B" && gameField[1, 3] == "B") { return "B"; }
            if (gameField[1, 0] == "R" && gameField[1, 1] == "R" && gameField[1, 2] == "R" && gameField[1, 3] == "R") { return "R"; }
            if (gameField[1, 1] == "B" && gameField[1, 2] == "B" && gameField[1, 3] == "B" && gameField[1, 4] == "B") { return "B"; }
            if (gameField[1, 1] == "R" && gameField[1, 2] == "R" && gameField[1, 3] == "R" && gameField[1, 4] == "R") { return "R"; }
            if (gameField[1, 2] == "B" && gameField[1, 3] == "B" && gameField[1, 4] == "B" && gameField[1, 5] == "B") { return "B"; }
            if (gameField[1, 2] == "R" && gameField[1, 3] == "R" && gameField[1, 4] == "R" && gameField[1, 5] == "R") { return "R"; }
            if (gameField[1, 3] == "B" && gameField[1, 4] == "B" && gameField[1, 5] == "B" && gameField[1, 6] == "B") { return "B"; }
            if (gameField[1, 3] == "R" && gameField[1, 4] == "R" && gameField[1, 5] == "R" && gameField[1, 6] == "R") { return "R"; }
            if (gameField[2, 0] == "B" && gameField[2, 1] == "B" && gameField[2, 2] == "B" && gameField[2, 3] == "B") { return "B"; }
            if (gameField[2, 0] == "R" && gameField[2, 1] == "R" && gameField[2, 2] == "R" && gameField[2, 3] == "R") { return "R"; }
            if (gameField[2, 1] == "B" && gameField[2, 2] == "B" && gameField[2, 3] == "B" && gameField[2, 4] == "B") { return "B"; }
            if (gameField[2, 1] == "R" && gameField[2, 2] == "R" && gameField[2, 3] == "R" && gameField[2, 4] == "R") { return "R"; }
            if (gameField[2, 2] == "B" && gameField[2, 3] == "B" && gameField[2, 4] == "B" && gameField[2, 5] == "B") { return "B"; }
            if (gameField[2, 2] == "R" && gameField[2, 3] == "R" && gameField[2, 4] == "R" && gameField[2, 5] == "R") { return "R"; }
            if (gameField[2, 3] == "B" && gameField[2, 4] == "B" && gameField[2, 5] == "B" && gameField[2, 6] == "B") { return "B"; }
            if (gameField[2, 3] == "R" && gameField[2, 4] == "R" && gameField[2, 5] == "R" && gameField[2, 6] == "R") { return "R"; }
            if (gameField[3, 0] == "B" && gameField[3, 1] == "B" && gameField[3, 2] == "B" && gameField[3, 3] == "B") { return "B"; }
            if (gameField[3, 0] == "R" && gameField[3, 1] == "R" && gameField[3, 2] == "R" && gameField[3, 3] == "R") { return "R"; }
            if (gameField[3, 1] == "B" && gameField[3, 2] == "B" && gameField[3, 3] == "B" && gameField[3, 4] == "B") { return "B"; }
            if (gameField[3, 1] == "R" && gameField[3, 2] == "R" && gameField[3, 3] == "R" && gameField[3, 4] == "R") { return "R"; }
            if (gameField[3, 2] == "B" && gameField[3, 3] == "B" && gameField[3, 4] == "B" && gameField[3, 5] == "B") { return "B"; }
            if (gameField[3, 2] == "R" && gameField[3, 3] == "R" && gameField[3, 4] == "R" && gameField[3, 5] == "R") { return "R"; }
            if (gameField[3, 3] == "B" && gameField[3, 4] == "B" && gameField[3, 5] == "B" && gameField[3, 6] == "B") { return "B"; }
            if (gameField[3, 3] == "R" && gameField[3, 4] == "R" && gameField[3, 5] == "R" && gameField[3, 6] == "R") { return "R"; }
            if (gameField[4, 0] == "B" && gameField[4, 1] == "B" && gameField[4, 2] == "B" && gameField[4, 3] == "B") { return "B"; }
            if (gameField[4, 0] == "R" && gameField[4, 1] == "R" && gameField[4, 2] == "R" && gameField[4, 3] == "R") { return "R"; }
            if (gameField[4, 1] == "B" && gameField[4, 2] == "B" && gameField[4, 3] == "B" && gameField[4, 4] == "B") { return "B"; }
            if (gameField[4, 1] == "R" && gameField[4, 2] == "R" && gameField[4, 3] == "R" && gameField[4, 4] == "R") { return "R"; }
            if (gameField[4, 2] == "B" && gameField[4, 3] == "B" && gameField[4, 4] == "B" && gameField[4, 5] == "B") { return "B"; }
            if (gameField[4, 2] == "R" && gameField[4, 3] == "R" && gameField[4, 4] == "R" && gameField[4, 5] == "R") { return "R"; }
            if (gameField[4, 3] == "B" && gameField[4, 4] == "B" && gameField[4, 5] == "B" && gameField[4, 6] == "B") { return "B"; }
            if (gameField[4, 3] == "R" && gameField[4, 4] == "R" && gameField[4, 5] == "R" && gameField[4, 6] == "R") { return "R"; }
            if (gameField[5, 0] == "B" && gameField[5, 1] == "B" && gameField[5, 2] == "B" && gameField[5, 3] == "B") { return "B"; }
            if (gameField[5, 0] == "R" && gameField[5, 1] == "R" && gameField[5, 2] == "R" && gameField[5, 3] == "R") { return "R"; }
            if (gameField[5, 1] == "B" && gameField[5, 2] == "B" && gameField[5, 3] == "B" && gameField[5, 4] == "B") { return "B"; }
            if (gameField[5, 1] == "R" && gameField[5, 2] == "R" && gameField[5, 3] == "R" && gameField[5, 4] == "R") { return "R"; }
            if (gameField[5, 2] == "B" && gameField[5, 3] == "B" && gameField[5, 4] == "B" && gameField[5, 5] == "B") { return "B"; }
            if (gameField[5, 2] == "R" && gameField[5, 3] == "R" && gameField[5, 4] == "R" && gameField[5, 5] == "R") { return "R"; }
            if (gameField[5, 3] == "B" && gameField[5, 4] == "B" && gameField[5, 5] == "B" && gameField[5, 6] == "B") { return "B"; }
            if (gameField[5, 3] == "R" && gameField[5, 4] == "R" && gameField[5, 5] == "R" && gameField[5, 6] == "R") { return "R"; }
            if (gameField[0, 0] == "B" && gameField[1, 0] == "B" && gameField[2, 0] == "B" && gameField[3, 0] == "B") { return "B"; }
            if (gameField[0, 0] == "R" && gameField[1, 0] == "R" && gameField[2, 0] == "R" && gameField[3, 0] == "R") { return "R"; }
            if (gameField[1, 0] == "B" && gameField[2, 0] == "B" && gameField[3, 0] == "B" && gameField[4, 0] == "B") { return "B"; }
            if (gameField[1, 0] == "R" && gameField[2, 0] == "R" && gameField[3, 0] == "R" && gameField[4, 0] == "R") { return "R"; }
            if (gameField[2, 0] == "B" && gameField[3, 0] == "B" && gameField[4, 0] == "B" && gameField[5, 0] == "B") { return "B"; }
            if (gameField[2, 0] == "R" && gameField[3, 0] == "R" && gameField[4, 0] == "R" && gameField[5, 0] == "R") { return "R"; }
            if (gameField[0, 1] == "B" && gameField[1, 1] == "B" && gameField[2, 1] == "B" && gameField[3, 1] == "B") { return "B"; }
            if (gameField[0, 1] == "R" && gameField[1, 1] == "R" && gameField[2, 1] == "R" && gameField[3, 1] == "R") { return "R"; }
            if (gameField[1, 1] == "B" && gameField[2, 1] == "B" && gameField[3, 1] == "B" && gameField[4, 1] == "B") { return "B"; }
            if (gameField[1, 1] == "R" && gameField[2, 1] == "R" && gameField[3, 1] == "R" && gameField[4, 1] == "R") { return "R"; }
            if (gameField[2, 1] == "B" && gameField[3, 1] == "B" && gameField[4, 1] == "B" && gameField[5, 1] == "B") { return "B"; }
            if (gameField[2, 1] == "R" && gameField[3, 1] == "R" && gameField[4, 1] == "R" && gameField[5, 1] == "R") { return "R"; }
            if (gameField[0, 2] == "B" && gameField[1, 2] == "B" && gameField[2, 2] == "B" && gameField[3, 2] == "B") { return "B"; }
            if (gameField[0, 2] == "R" && gameField[1, 2] == "R" && gameField[2, 2] == "R" && gameField[3, 2] == "R") { return "R"; }
            if (gameField[1, 2] == "B" && gameField[2, 2] == "B" && gameField[3, 2] == "B" && gameField[4, 2] == "B") { return "B"; }
            if (gameField[1, 2] == "R" && gameField[2, 2] == "R" && gameField[3, 2] == "R" && gameField[4, 2] == "R") { return "R"; }
            if (gameField[2, 2] == "B" && gameField[3, 2] == "B" && gameField[4, 2] == "B" && gameField[5, 2] == "B") { return "B"; }
            if (gameField[2, 2] == "R" && gameField[3, 2] == "R" && gameField[4, 2] == "R" && gameField[5, 2] == "R") { return "R"; }
            if (gameField[0, 3] == "B" && gameField[1, 3] == "B" && gameField[2, 3] == "B" && gameField[3, 3] == "B") { return "B"; }
            if (gameField[0, 3] == "R" && gameField[1, 3] == "R" && gameField[2, 3] == "R" && gameField[3, 3] == "R") { return "R"; }
            if (gameField[1, 3] == "B" && gameField[2, 3] == "B" && gameField[3, 3] == "B" && gameField[4, 3] == "B") { return "B"; }
            if (gameField[1, 3] == "R" && gameField[2, 3] == "R" && gameField[3, 3] == "R" && gameField[4, 3] == "R") { return "R"; }
            if (gameField[2, 3] == "B" && gameField[3, 3] == "B" && gameField[4, 3] == "B" && gameField[5, 3] == "B") { return "B"; }
            if (gameField[2, 3] == "R" && gameField[3, 3] == "R" && gameField[4, 3] == "R" && gameField[5, 3] == "R") { return "R"; }
            if (gameField[0, 4] == "B" && gameField[1, 4] == "B" && gameField[2, 4] == "B" && gameField[3, 4] == "B") { return "B"; }
            if (gameField[0, 4] == "R" && gameField[1, 4] == "R" && gameField[2, 4] == "R" && gameField[3, 4] == "R") { return "R"; }
            if (gameField[1, 4] == "B" && gameField[2, 4] == "B" && gameField[3, 4] == "B" && gameField[4, 4] == "B") { return "B"; }
            if (gameField[1, 4] == "R" && gameField[2, 4] == "R" && gameField[3, 4] == "R" && gameField[4, 4] == "R") { return "R"; }
            if (gameField[2, 4] == "B" && gameField[3, 4] == "B" && gameField[4, 4] == "B" && gameField[5, 4] == "B") { return "B"; }
            if (gameField[2, 4] == "R" && gameField[3, 4] == "R" && gameField[4, 4] == "R" && gameField[5, 4] == "R") { return "R"; }
            if (gameField[0, 5] == "B" && gameField[1, 5] == "B" && gameField[2, 5] == "B" && gameField[3, 5] == "B") { return "B"; }
            if (gameField[0, 5] == "R" && gameField[1, 5] == "R" && gameField[2, 5] == "R" && gameField[3, 5] == "R") { return "R"; }
            if (gameField[1, 5] == "B" && gameField[2, 5] == "B" && gameField[3, 5] == "B" && gameField[4, 5] == "B") { return "B"; }
            if (gameField[1, 5] == "R" && gameField[2, 5] == "R" && gameField[3, 5] == "R" && gameField[4, 5] == "R") { return "R"; }
            if (gameField[2, 5] == "B" && gameField[3, 5] == "B" && gameField[4, 5] == "B" && gameField[5, 5] == "B") { return "B"; }
            if (gameField[2, 5] == "R" && gameField[3, 5] == "R" && gameField[4, 5] == "R" && gameField[5, 5] == "R") { return "R"; }
            if (gameField[0, 6] == "B" && gameField[1, 6] == "B" && gameField[2, 6] == "B" && gameField[3, 6] == "B") { return "B"; }
            if (gameField[0, 6] == "R" && gameField[1, 6] == "R" && gameField[2, 6] == "R" && gameField[3, 6] == "R") { return "R"; }
            if (gameField[1, 6] == "B" && gameField[2, 6] == "B" && gameField[3, 6] == "B" && gameField[4, 6] == "B") { return "B"; }
            if (gameField[1, 6] == "R" && gameField[2, 6] == "R" && gameField[3, 6] == "R" && gameField[4, 6] == "R") { return "R"; }
            if (gameField[2, 6] == "B" && gameField[3, 6] == "B" && gameField[4, 6] == "B" && gameField[5, 6] == "B") { return "B"; }
            if (gameField[2, 6] == "R" && gameField[3, 6] == "R" && gameField[4, 6] == "R" && gameField[5, 6] == "R") { return "R"; }
            if (gameField[3, 0] == "B" && gameField[2, 1] == "B" && gameField[1, 2] == "B" && gameField[0, 3] == "B") { return "B"; }
            if (gameField[3, 0] == "R" && gameField[2, 1] == "R" && gameField[1, 2] == "R" && gameField[0, 3] == "R") { return "R"; }
            if (gameField[3, 3] == "B" && gameField[2, 2] == "B" && gameField[1, 1] == "B" && gameField[0, 0] == "B") { return "B"; }
            if (gameField[3, 3] == "R" && gameField[2, 2] == "R" && gameField[1, 1] == "R" && gameField[0, 0] == "R") { return "R"; }
            if (gameField[4, 0] == "B" && gameField[3, 1] == "B" && gameField[2, 2] == "B" && gameField[1, 3] == "B") { return "B"; }
            if (gameField[4, 0] == "R" && gameField[3, 1] == "R" && gameField[2, 2] == "R" && gameField[1, 3] == "R") { return "R"; }
            if (gameField[4, 3] == "B" && gameField[3, 2] == "B" && gameField[2, 1] == "B" && gameField[1, 0] == "B") { return "B"; }
            if (gameField[4, 3] == "R" && gameField[3, 2] == "R" && gameField[2, 1] == "R" && gameField[1, 0] == "R") { return "R"; }
            if (gameField[5, 0] == "B" && gameField[4, 1] == "B" && gameField[3, 2] == "B" && gameField[2, 3] == "B") { return "B"; }
            if (gameField[5, 0] == "R" && gameField[4, 1] == "R" && gameField[3, 2] == "R" && gameField[2, 3] == "R") { return "R"; }
            if (gameField[5, 3] == "B" && gameField[4, 2] == "B" && gameField[3, 1] == "B" && gameField[2, 0] == "B") { return "B"; }
            if (gameField[5, 3] == "R" && gameField[4, 2] == "R" && gameField[3, 1] == "R" && gameField[2, 0] == "R") { return "R"; }
            if (gameField[3, 1] == "B" && gameField[2, 2] == "B" && gameField[1, 3] == "B" && gameField[0, 4] == "B") { return "B"; }
            if (gameField[3, 1] == "R" && gameField[2, 2] == "R" && gameField[1, 3] == "R" && gameField[0, 4] == "R") { return "R"; }
            if (gameField[3, 4] == "B" && gameField[2, 3] == "B" && gameField[1, 2] == "B" && gameField[0, 1] == "B") { return "B"; }
            if (gameField[3, 4] == "R" && gameField[2, 3] == "R" && gameField[1, 2] == "R" && gameField[0, 1] == "R") { return "R"; }
            if (gameField[4, 1] == "B" && gameField[3, 2] == "B" && gameField[2, 3] == "B" && gameField[1, 4] == "B") { return "B"; }
            if (gameField[4, 1] == "R" && gameField[3, 2] == "R" && gameField[2, 3] == "R" && gameField[1, 4] == "R") { return "R"; }
            if (gameField[4, 4] == "B" && gameField[3, 3] == "B" && gameField[2, 2] == "B" && gameField[1, 1] == "B") { return "B"; }
            if (gameField[4, 4] == "R" && gameField[3, 3] == "R" && gameField[2, 2] == "R" && gameField[1, 1] == "R") { return "R"; }
            if (gameField[5, 1] == "B" && gameField[4, 2] == "B" && gameField[3, 3] == "B" && gameField[2, 4] == "B") { return "B"; }
            if (gameField[5, 1] == "R" && gameField[4, 2] == "R" && gameField[3, 3] == "R" && gameField[2, 4] == "R") { return "R"; }
            if (gameField[5, 4] == "B" && gameField[4, 3] == "B" && gameField[3, 2] == "B" && gameField[2, 1] == "B") { return "B"; }
            if (gameField[5, 4] == "R" && gameField[4, 3] == "R" && gameField[3, 2] == "R" && gameField[2, 1] == "R") { return "R"; }
            if (gameField[3, 2] == "B" && gameField[2, 3] == "B" && gameField[1, 4] == "B" && gameField[0, 5] == "B") { return "B"; }
            if (gameField[3, 2] == "R" && gameField[2, 3] == "R" && gameField[1, 4] == "R" && gameField[0, 5] == "R") { return "R"; }
            if (gameField[3, 5] == "B" && gameField[2, 4] == "B" && gameField[1, 3] == "B" && gameField[0, 2] == "B") { return "B"; }
            if (gameField[3, 5] == "R" && gameField[2, 4] == "R" && gameField[1, 3] == "R" && gameField[0, 2] == "R") { return "R"; }
            if (gameField[4, 2] == "B" && gameField[3, 3] == "B" && gameField[2, 4] == "B" && gameField[1, 5] == "B") { return "B"; }
            if (gameField[4, 2] == "R" && gameField[3, 3] == "R" && gameField[2, 4] == "R" && gameField[1, 5] == "R") { return "R"; }
            if (gameField[4, 5] == "B" && gameField[3, 4] == "B" && gameField[2, 3] == "B" && gameField[1, 2] == "B") { return "B"; }
            if (gameField[4, 5] == "R" && gameField[3, 4] == "R" && gameField[2, 3] == "R" && gameField[1, 2] == "R") { return "R"; }
            if (gameField[5, 2] == "B" && gameField[4, 3] == "B" && gameField[3, 4] == "B" && gameField[2, 5] == "B") { return "B"; }
            if (gameField[5, 2] == "R" && gameField[4, 3] == "R" && gameField[3, 4] == "R" && gameField[2, 5] == "R") { return "R"; }
            if (gameField[5, 5] == "B" && gameField[4, 4] == "B" && gameField[3, 3] == "B" && gameField[2, 2] == "B") { return "B"; }
            if (gameField[5, 5] == "R" && gameField[4, 4] == "R" && gameField[3, 3] == "R" && gameField[2, 2] == "R") { return "R"; }
            if (gameField[3, 3] == "B" && gameField[2, 4] == "B" && gameField[1, 5] == "B" && gameField[0, 6] == "B") { return "B"; }
            if (gameField[3, 3] == "R" && gameField[2, 4] == "R" && gameField[1, 5] == "R" && gameField[0, 6] == "R") { return "R"; }
            if (gameField[3, 6] == "B" && gameField[2, 5] == "B" && gameField[1, 4] == "B" && gameField[0, 3] == "B") { return "B"; }
            if (gameField[3, 6] == "R" && gameField[2, 5] == "R" && gameField[1, 4] == "R" && gameField[0, 3] == "R") { return "R"; }
            if (gameField[4, 3] == "B" && gameField[3, 4] == "B" && gameField[2, 5] == "B" && gameField[1, 6] == "B") { return "B"; }
            if (gameField[4, 3] == "R" && gameField[3, 4] == "R" && gameField[2, 5] == "R" && gameField[1, 6] == "R") { return "R"; }
            if (gameField[4, 6] == "B" && gameField[3, 5] == "B" && gameField[2, 4] == "B" && gameField[1, 3] == "B") { return "B"; }
            if (gameField[4, 6] == "R" && gameField[3, 5] == "R" && gameField[2, 4] == "R" && gameField[1, 3] == "R") { return "R"; }
            if (gameField[5, 3] == "B" && gameField[4, 4] == "B" && gameField[3, 5] == "B" && gameField[2, 6] == "B") { return "B"; }
            if (gameField[5, 3] == "R" && gameField[4, 4] == "R" && gameField[3, 5] == "R" && gameField[2, 6] == "R") { return "R"; }
            if (gameField[5, 6] == "B" && gameField[4, 5] == "B" && gameField[3, 4] == "B" && gameField[2, 3] == "B") { return "B"; }
            if (gameField[5, 6] == "R" && gameField[4, 5] == "R" && gameField[3, 4] == "R" && gameField[2, 3] == "R") { return "R"; }
            else
                return "noWinnerYet";
        }

        void CheckForWinner()
        {
            // Checks for winner, and gets color of winner
            theWinnerIs = GetWinner();

            if (theWinnerIs == "R") // If the winner is red, disables all buttons and shows messagebox informing of the winner
            {
                buttonAddColumnA.Enabled = false;
                buttonAddColumnB.Enabled = false;
                buttonAddColumnC.Enabled = false;
                buttonAddColumnD.Enabled = false;
                buttonAddColumnE.Enabled = false;
                buttonAddColumnF.Enabled = false;
                buttonAddColumnG.Enabled = false;
                MessageBox.Show("Red wins!", "Game over!");
            }

            else if (theWinnerIs == "B") // Else if the winner is blue, disables all buttons and shows messagebox informing of the winner
            {
                buttonAddColumnA.Enabled = false;
                buttonAddColumnB.Enabled = false;
                buttonAddColumnC.Enabled = false;
                buttonAddColumnD.Enabled = false;
                buttonAddColumnE.Enabled = false;
                buttonAddColumnF.Enabled = false;
                buttonAddColumnG.Enabled = false;
                MessageBox.Show("Green wins!", "Game over!");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Jonas W", "About this game");
        }

        private void tutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("First things first, red player always starts the game. \n" +
                "The goal of the game is to connect four tokens of your own color on the game board." +
                "The first player to achieve this wins the game.", "How to play");
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // resets the color of all rows and tables on the gamefield
            foreach (Button b in tableLayoutPanel1.Controls)
            {
                b.BackColor = Color.LightGray;
            }

            // resets the counters on all columns
            countA = 0;
            countB = 0;
            countC = 0;
            countD = 0;
            countE = 0;
            countF = 0;
            countG = 0;

            // enables the add button for each column
            buttonAddColumnA.Enabled = true;
            buttonAddColumnB.Enabled = true;
            buttonAddColumnC.Enabled = true;
            buttonAddColumnD.Enabled = true;
            buttonAddColumnE.Enabled = true;
            buttonAddColumnF.Enabled = true;
            buttonAddColumnG.Enabled = true;

            // resets the 2d-array gameField
            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    gameField[i, j] = "";
                }
            }

            redTurn = true; // red starts the game
        }
    }
}

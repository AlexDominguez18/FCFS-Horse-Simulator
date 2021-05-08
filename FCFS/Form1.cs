using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FCFS
{
    public partial class Form1 : Form
    {
        //Constants
        private const int MAX_HORSES = 5;
        //Starting position
        private int starting_x;
        private int starting_y;
        //Horses queue declaration
        private List<Horse> horses;
        //Timer for the program
        private System.Windows.Forms.Timer globalTimer;
        private readonly static Object _lock = new Object();

        private List<int> winnerHorses;
        private int finishHorses;

        public Form1()
        {
            InitializeComponent();
            //Initial values
            horses = new List<Horse>();
            winnerHorses = new List<int>();
            finishHorses = 0;
            //Getting the start position of the first horse
            starting_x = 32;
            starting_y = 9;
            
            //Creating the horses
            for (int i = 0; i < MAX_HORSES; i++)
            {
                Horse horse = new Horse(i+1, new Point(starting_x,starting_y + (i * Horse.IMAGE_HEIGHT)));
                //Adding the horse into de queue
                horses.Add(horse);
                //Adding the horse's picture box into the view
                this.Controls.Add(horse.GetPictureBox());
            }

            //Running the program
            globalTimer = new System.Windows.Forms.Timer() { Interval = 200 };
            globalTimer.Tick += new EventHandler(timer_Tick);
        }

        private void startButton_click(object sender, EventArgs e)
        {
            if (!globalTimer.Enabled)
            {
                globalTimer.Start();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (horses.Count() > 0)
            {
                Horse currentHorse = horses.First();
                Thread t = new Thread(new ThreadStart(() =>
                {
                    if (currentHorse.GetCurrentCoordX() < Size.Width)
                    {
                        MoveHorse(currentHorse);
                    }
                }
                ));
                t.Start();
            }
            else
            {
                globalTimer.Stop();
            }
        }

        private void MoveHorse(Horse horse)
        {
            Invoke(new MethodInvoker(() =>
            {
                lock (_lock)
                {
                    horse.GetPictureBox().Enabled = true;
                    horse.Move(Horse.VELOCITY);
                    //Checking if finished
                    if (horse.GetCurrentCoordX() >= Size.Width)
                    {
                        winnerHorses.Add(horse.GetId());
                        horse.GetPictureBox().Enabled = false;
                        horses.Remove(horse);
                        finishHorses++;
                    }
                    if (winnerHorses.Count > 0)
                    {
                        UpdateResults();
                    }
                }
            })); 
        }

        private void UpdateResults()
        {
            Invoke(new MethodInvoker(() =>
            {
                lock (_lock)
                {
                    if (winnerHorses.Count > 0)
                    {
                        winnersList.Items.Clear();
                        for (int i = 0; i < winnerHorses.Count; i++)
                        {
                            winnersList.Items.Add($"Posición {i+1} -> Caballo #{winnerHorses[i]}");
                        }
                    }
                }
            }
            ));
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

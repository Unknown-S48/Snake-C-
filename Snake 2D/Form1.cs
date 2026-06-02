namespace Snake_2D
{
    public partial class frmSnake : Form
    {
        // Declaring variables
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();

        int maxWidth;
        int maxHight;

        int score;
        int highScore;

        Random random = new Random();

        bool goLeft, goRight, goDown, goUp;

        public frmSnake()
        {
            InitializeComponent();

            // Calling in instance of the Setting class
            new Settings();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            // Checking for input and if the left key is down and the direction is the oppisite of the key it goes that direction
            if (e.KeyCode == Keys.Left && Settings.Directions != "right")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && Settings.Directions != "left")
            { 
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && Settings.Directions != "down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && Settings.Directions != "up")
            {
                goDown = true;
            }
                            
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void StartGame(object sender, EventArgs e)
        {

        }

        private void TakeScrnShot(object sender, EventArgs e)
        {

        }

        private void GameTimerEvent(object sender, EventArgs e)
        {

        }

        private void UpdatePictureBoxDisplay(object sender, PaintEventArgs e)
        {

        }

        private void RestartGame(object sender, EventArgs e)
        {
            // Adding all the default values we want before the game starts
            maxWidth = picCanvas.Width / Settings.Width - 1;
            maxHight = picCanvas.Height / Settings.Height - 1;

            // Clearing any children in the cavas
            Snake.Clear();

            // Reseting elements
            btnStart.Enabled = false;
            btnScrnSave.Enabled = false;
            score = 0;
            lblScore.Text = "Score: " + score;

            // Creating the body part for the snake 
            Circle head = new Circle { x = 10, y = 5 };
            Snake.Add(head); // Index 0 for the body and adding the head to a list

            // Adding another 10 body parts to the snake
            for (int i = 0; i < 10;  i++)
            {
                Circle body = new Circle();
                Snake.Add(body);
            }

            // Adding the food spawner
            food = new Circle {x = random.Next(2, maxWidth), y = random.Next(2, maxHight) };

            // Starting the game timer
            gameTimer.Start();
        }

        private void EatFood(object sender, EventArgs e)
        {

        }

        private void GameOver(object sender, EventArgs e)
        {

        }
    }
}

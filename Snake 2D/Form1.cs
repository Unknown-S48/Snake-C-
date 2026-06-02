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

        }

        private void EatFood(object sender, EventArgs e)
        {

        }

        private void GameOver(object sender, EventArgs e)
        {

        }
    }
}

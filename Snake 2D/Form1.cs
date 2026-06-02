using System.CodeDom;
using System.ComponentModel.DataAnnotations;

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
            RestartGame();
        }

        private void TakeScrnShot(object sender, EventArgs e)
        {

        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            // Setting the directions
            if (goLeft)
            {
                Settings.Directions = "left";
            }
            if (goRight)
            {
                Settings.Directions = "right";
            }
            if (goUp)
            {
                Settings.Directions = "up";
            }
            if (goDown)
            {
                Settings.Directions = "down";
            }

            for (int i = Snake.Count - 1; i < 0; i--)
            {
                // Checking the head of the snake
                if (i == 0)
                {
                    switch (Settings.Directions)
                    {
                        case "left":
                            Snake[i].x--;
                            break;
                        case "right":
                            Snake[i].x++;
                            break;
                        case "down":
                            Snake[i].y++;
                            break;
                        case "up":
                            Snake[i].y--;
                            break;
                    }

                    // Setting the boundry of the screen and making the snake get sent to the otherside
                    if (Snake[i].x < 0)
                    {
                        Snake[i].x = maxWidth;
                    }
                    if (Snake[i].x > maxWidth)
                    {
                        Snake[i].x = 0;
                    }
                    if (Snake[i].y < 0)
                    {
                        Snake[i].y = maxHight;
                    }
                    if (Snake[i].y > maxHight)
                    {
                        Snake[i].y = 0;
                    }

                    // Adding the eating part
                    // Checking if the head is on the food
                    if (Snake[i].x == food.x && Snake[i].y == food.y)
                    {
                        EatFood();
                    }

                    // Checknig if the snake eats a part of it's self
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].x == Snake[j].x && Snake[i].y == Snake[j].y)
                        {
                            GameOver();
                        }
                    }

                }
                // Telling the body what to do
                else
                {
                    Snake[i].x = Snake[i - 1].x;
                    Snake[i].y = Snake[i - 1].y;
                }
            }

            // Adding the games tickrate
            picCanvas.Invalidate();
        }

        private void UpdatePictureBoxDisplay(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            Brush snakeColor;

            // Looping the snakes body
            for (int i = 0; i < Snake.Count; i++)
            {
                // Accessing the first index of the snake (The Head)
                if (i == 0)
                {
                    snakeColor = Brushes.Black;
                }
                // Setting the value for the rest of the snake
                else
                {
                    snakeColor = Brushes.Gray;
                }
                // Giving the snakes body color 
                canvas.FillEllipse(snakeColor, new Rectangle
                    (
                        Snake[i].x * Settings.Width,
                        Snake[i].y * Settings.Height,
                        Settings.Width, Settings.Height
                    ));
            }
            //Setting the value for the food
            canvas.FillEllipse(Brushes.Red, new Rectangle
                (
                    food.x * Settings.Width,
                    food.y * Settings.Height,
                    Settings.Width, Settings.Height
                ));
        }

        private void RestartGame()
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
            for (int i = 0; i < 10; i++)
            {
                Circle body = new Circle();
                Snake.Add(body);
            }

            // Adding the food spawner
            food = new Circle { x = random.Next(2, maxWidth), y = random.Next(2, maxHight) };

            // Starting the game timer
            gameTimer.Start();
        }

        private void EatFood()
        {
            // Updating the score
            score += 1;
            lblScore.Text = "Score: " + score;
            // Creating a new body part
            Circle body = new Circle
            {
                x = Snake[Snake.Count - 1].x,
                y = Snake[Snake.Count - 1].y
            };
            // Adding the new body part to the snake
            Snake.Add(body);

            // Generating the new piece of food
            food = new Circle { x = random.Next(2, maxWidth), y = random.Next(2, maxHight) };
        }

        private void GameOver()
        {
            // Stoping the game loop
            gameTimer.Stop();
            btnStart.Enabled = true;
            btnScrnSave.Enabled = true;

            // Checking if there is a new highscore 
            if (score > highScore)
            {
                highScore = score;
                lblHighScore.Text = "High Score: " + Environment.NewLine + highScore;
                lblHighScore.ForeColor = Color.Maroon;
                lblHighScore.TextAlign = ContentAlignment.MiddleCenter; 
            }
        }
    }
}

using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Drawing;





namespace MEMORY_MATCH
{
    public partial class MainGame : Form
    {
        //private int score = 0;
        private int level = 1;
        private int rows = 2;
        private int cols = 3;
        private int DefaultCardSize = 300;
        private int CardWidth = 0;

        private const int HideCardsDelay = 1000;

        private List<PictureBox> cards;
        private PictureBox firstCard;
        private int matchedCardsCount;
        static string basePath = "C:\\Csharp\\WindowsFormsMatchGame\\Recources";
        // list các hình ảnh
        private List<string> imagePaths = new List<string>
        {
              basePath+ "\\card1.jpg",
              basePath+ "\\card2.jpg",
              basePath+ "\\card3.jpg",
              basePath+ "\\card4.jpg",
              basePath+ "\\card5.jpg",
              basePath+ "\\card6.jpg",
              basePath+ "\\card7.jpg",
              basePath+ "\\card8.jpg",
              basePath+ "\\card9.jpg",
              basePath+ "\\card10.jpg"
            // Add paths to other images here
        };
        public Timer timer;
        private TimeSpan elapsedTime;
        private bool isPaused;
        // Để chỉ được nhấn 1 lần ra 1 form
        private bool isButtonClicked = false;
        public void SetButtonClickedStatus(bool status)
        {
            isButtonClicked = status;
        }

        //Tính thời gian chơi
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!isPaused)
            {
                elapsedTime = elapsedTime.Add(TimeSpan.FromSeconds(1));

                // Hiển thị thời gian lên Label
                lbl_time.Text = "Times: " + elapsedTime.ToString(@"hh\:mm\:ss");
            }
        }
        //private void MainGame_Load(object sender, EventArgs e)
        //{
        //    MainGame maingame = (MainGame)Application.OpenForms["MainGame"];
        //    elapsedTime = maingame.elapsedTime;
        //    isPaused = false;
        //    //Bắt đầu đếm thời gian
        //    timer.Start();
        //}
        // Nút Pause
        private void btn_pause_Click(object sender, EventArgs e)
        {
            if (!isButtonClicked)
            {
                isButtonClicked = true;
            }
            else
            {
                return; // Không có hiệu lực nếu đã click liên tiếp 
            }
            Pause pause = new Pause(this);
            pause.Show();
            isPaused = !isPaused;
            timer.Stop();
        }
        public void ResumeTimer()
        {
            isPaused = false;
            timer.Start();
        }
        // Nút Setting
        private void btn_setting_Click(object sender, EventArgs e)
        {
            if (!isButtonClicked)
            {
                isButtonClicked = true;
            }
            else
            {
                return; // Không có hiệu lực nếu đã click liên tiếp 
            }
            Setting setting = new Setting(this);
            setting.Show();
            isPaused = !isPaused;
            timer.Stop();
        }
        //private MainOption mainoption;
        public MainGame()
        {
            InitializeComponent();
            //score = 0;
            InitializeGame();
            // Khởi tạo Timer
            timer = new Timer();
            timer.Interval = 1000; // Mỗi giây
            timer.Tick += Timer_Tick;
        }
        private void InitializeGame()
        {

            //UpdateLevelScore(); // Khởi tạo điểm ban đầ
            Controls.Add(panel_level);
            Controls.Add(panel_score);
            Controls.Add(panel_times);
            Controls.Add(btn_setting);
            Controls.Add(btn_pause);
            
          
           
            cards = new List<PictureBox>();
            matchedCardsCount = 0;
            // Create and shuffle the cards
            int cardCount = rows * cols;
            CardWidth = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(DefaultCardSize / cols)));
            for (int i = 0; i < cardCount / 2; i++)
            {

                cards.Add(CreateCard(i));
                cards.Add(CreateCard(i));

            }

            ShuffleCards();


            // Add the cards to the form
            int cardIndex = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    int x = ((cardIndex % cols) * (CardWidth + 10)) + 100;
                    int y = ((cardIndex / cols) * (CardWidth + 10)  ) + 100;

                    PictureBox card = cards[cardIndex];
                    card.Location = new Point(x, y);
                    card.SizeMode = PictureBoxSizeMode.StretchImage;
                    card.BorderStyle = BorderStyle.FixedSingle;
                    card.Click += Card_Click;
                    Controls.Add(card);
                    card.BringToFront();
                    cardIndex++;

                }
            }

        }

        // hàm tạo card item
        private PictureBox CreateCard(int imageIndex)
        {
            int imageSize = DefaultCardSize / rows; // Kích thước hình ảnh cho mỗi ô lưới
            int imageCount = rows * cols; // Tổng số hình ảnh trong lưới
            PictureBox card = new PictureBox();
            card.Size = new Size(CardWidth, CardWidth);
            card.Tag = imagePaths[imageIndex];
            card.SizeMode = PictureBoxSizeMode.StretchImage;

            //string imagePath = imagePaths[imageIndex];
            Image img = Image.FromFile("C:\\Csharp\\WindowsFormsMatchGame\\Recources\\imagecard2.jpg");
            card.Image = ResizeImageToGrid(img, imageSize, imageSize);
            return card;
        }
        // hàm xáo trộn các thẻ hình
        private void ShuffleCards()
        {
            Random random = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                PictureBox value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }

        // hàm thay đổi kích thước hình ảnh để phù hợp với form
        private Image ResizeImageToGrid(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }

        // hàm cập nhật điểm và hiện thị
        //private void UpdateLevelScore()
        //{
        //    score += 100;
        //    label1.Text = "Score: " + (score - 100).ToString();
        //}
        // hàm xủ lí click thẻ hình 
        private bool isProcessing = false; // Biến kiểm tra xem có đang xử lý các click trước đó hay không


        private void Card_Click(object sender, EventArgs e)
        {
            if (isProcessing)
            {
                // Nếu đang xử lý các click trước đó, bỏ qua click hiện tại
                return;
            }

            PictureBox currentCard = (PictureBox)sender;
            string str = currentCard.Tag.ToString();
            currentCard.Image = Image.FromFile(str);

            if (firstCard == null)
            {
                firstCard = currentCard;
            }
            else
            {
                if (firstCard == currentCard)
                {
                    // Đã chọn cùng 1 thẻ, không làm gì
                    return;
                }

                if (firstCard.Tag.ToString() == currentCard.Tag.ToString())
                {
                    // Hai hình giống nhau
                    isProcessing = true; // Đánh dấu đang xử lý

                    Timer timer = new Timer();
                    timer.Interval = 10;
                    int steps = 20;
                    double opacityStep = 1.0 / steps;
                    int delay = 300 / steps;
                    int currentStep = 0;

                    timer.Tick += (s, args) =>
                    {
                        currentStep++;
                        if (currentStep <= steps)
                        {
                            double opacity = 1 - (opacityStep * currentStep);
                            currentCard.BackColor = Color.FromArgb((int)(opacity * 255), currentCard.BackColor);
                            firstCard.BackColor = Color.FromArgb((int)(opacity * 255), firstCard.BackColor);
                        }
                        else
                        {
                            currentCard.Visible = false;
                            firstCard.Visible = false;
                            timer.Stop();

                            firstCard = null;

                            matchedCardsCount += 2;
                            if (matchedCardsCount == cards.Count)
                            {
                                // Tất cả các thẻ đã khớp, chuyển sang level tiếp theo hoặc kết thúc trò chơi
                                if (level < 3) // Level tối đa
                                {
                                    level++;
                                    rows++;
                                    cols++;
                                    Controls.Clear();
                                    InitializeGame();

                                }
                                else
                                {
                                    MessageBox.Show("Congratulations! You've completed all levels.");
                                    Close();
                                }
                            }
                            // Tăng điểm và cập nhật label điểm
                            //UpdateLevelScore();


                            isProcessing = false; // Đánh dấu kết thúc xử lý
                        }
                    };

                    timer.Start();
                }
                else
                {
                    // Hai hình không khớp
                    isProcessing = true; // Đánh dấu đang xử lý

                    currentCard.Enabled = false;
                    Timer timer = new Timer();
                    timer.Interval = 500;
                    timer.Tick += (s, args) =>
                    {
                        timer.Stop();
                        currentCard.Image = Image.FromFile("C:\\Csharp\\WindowsFormsMatchGame\\Recources\\imagecard2.jpg");
                        firstCard.Image = Image.FromFile("C:\\Csharp\\WindowsFormsMatchGame\\Recources\\imagecard2.jpg");
                        firstCard = null;
                        currentCard.Enabled = true;

                        isProcessing = false; // Đánh dấu kết thúc xử lý
                    };
                    timer.Start();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

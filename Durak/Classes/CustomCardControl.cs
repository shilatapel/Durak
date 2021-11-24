using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Durak.Properties;

namespace Durak.Classes
{
    public class CustomCardControl : UserControl
    {
        private Card _card = new Card();
        private PictureBox _cardPictureBox;

        public CustomCardControl()
        {
            InitializeComponent();
            StartingCardImage();
        }

        public Image Image { get; set; }

        public Card Card
        {
            get => _card;
            set
            {
                _card = value;
                UpdateCardImage();
            }
        }

        public event EventHandler CardClick;

        private void InitializeComponent()
        {
            SuspendLayout();
            _cardPictureBox = new PictureBox();
            ((ISupportInitialize) _cardPictureBox).BeginInit();
            _cardPictureBox.Image = Resources.back1;
            _cardPictureBox.Location = new Point(0, 0);
            _cardPictureBox.Name = "_cardPictureBox";
            _cardPictureBox.Size = new Size(100, 150);
            _cardPictureBox.TabIndex = 0;
            _cardPictureBox.TabStop = false;
            _cardPictureBox.Click += cardPictureBox_Click;

            Controls.Add(_cardPictureBox);
            Name = "CustomCardControl";
            Size = new Size(100, 150);
            ((ISupportInitialize) _cardPictureBox).EndInit();
            ResumeLayout(false);
        }

        private void StartingCardImage()
        {
            _cardPictureBox.Image = Resources.back1;
            _cardPictureBox.Refresh();
        }

        public void RotateFlipImage(Image image)
        {
            _cardPictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            _cardPictureBox.Refresh();
        }


        private void UpdateCardImage()
        {
            var name = _card.GetName();
            _cardPictureBox.Image = (Image) Resources.ResourceManager.GetObject(name);
            _cardPictureBox.Refresh();
        }


        private void cardPictureBox_Click(object sender, EventArgs e)
        {
            CardClick?.Invoke(this, e);
        }
    }
}
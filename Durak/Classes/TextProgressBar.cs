﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Durak
{
    /// <summary>
    ///  enum for the different types of cards
    /// </summary>
    public enum ProgressBarDisplayMode
    {
        NoText,
        Percentage,
        CurrProgress,
        CustomText,
        TextAndPercentage,
        TextAndCurrProgress
    }
    /// <summary>
    ///  A Windows control that displays a progress bar with a text label.
    /// </summary>
    public class TextProgressBar : ProgressBar
    {
        private SolidBrush _progressColourBrush = (SolidBrush) Brushes.LightGreen;
        private string _text = string.Empty;
        private SolidBrush _textColourBrush = (SolidBrush) Brushes.Black;
        private ProgressBarDisplayMode _visualMode = ProgressBarDisplayMode.CurrProgress;
        
        /// <summary>
        ///  constructor
        /// </summary>
        public TextProgressBar()
        {
            Value = Minimum;
            FixComponentBlinking();
        }
        /// <summary>
        ///  The colour of the progress bar
        /// </summary>
        [Description("Font of the text on ProgressBar")]
        [Category("Additional Options")]
        public Font TextFont { get; set; }
        
        
        [Category("Additional Options")]
        public Color TextColor
        {
            get => _textColourBrush.Color;
            set
            {
                _textColourBrush.Dispose();
                _textColourBrush = new SolidBrush(value);
            }
        }
        
        [Category("Additional Options")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public Color ProgressColor
        {
            get => _progressColourBrush.Color;
            set
            {
                _progressColourBrush.Dispose();
                _progressColourBrush = new SolidBrush(value);
            }
        }
        
        /// <summary>
        ///  The text to display
        /// </summary>
        [Category("Additional Options")]
        [Browsable(true)]
        public ProgressBarDisplayMode VisualMode
        {
            get => _visualMode;
            set
            {
                _visualMode = value;
                Invalidate(); //redraw component after change value from VS Properties section
            }
        }
        
        [Description("If it's empty, % will be shown")]
        [Category("Additional Options")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public string CustomText
        {
            get => _text;
            set
            {
                _text = value;
                Invalidate(); //redraw component after change value from VS Properties section
            }
        }
        
        /// <summary>
        ///  The text to display
        /// </summary>
        private string _textToDraw
        {
            get
            {
                var text = CustomText;

                switch (VisualMode)
                {
                    case ProgressBarDisplayMode.Percentage:
                        text = _percentageStr;
                        break;
                    case ProgressBarDisplayMode.CurrProgress:
                        text = _currProgressStr;
                        break;
                    case ProgressBarDisplayMode.TextAndCurrProgress:
                        text = $"{CustomText}: {_currProgressStr}";
                        break;
                    case ProgressBarDisplayMode.TextAndPercentage:
                        text = $"{CustomText}: {_percentageStr}";
                        break;
                }

                return text;
            }
            set { }
        }

        private string _percentageStr => $"{(int) ((float) Value - Minimum) / ((float) Maximum - Minimum) * 100} %";

        private string _currProgressStr => $"{Value}/{Maximum}";

        
        private void FixComponentBlinking()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer,
                true);
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;

            DrawProgressBar(g);

            DrawStringIfNeeded(g);
        }

        private void DrawProgressBar(Graphics g)
        {
            var rect = ClientRectangle;

            ProgressBarRenderer.DrawHorizontalBar(g, rect);

            rect.Inflate(-3, -3);

            if (Value > 0)
            {
                var clip = new Rectangle(rect.X, rect.Y, (int) Math.Round((float) Value / Maximum * rect.Width),
                    rect.Height);

                g.FillRectangle(_progressColourBrush, clip);
            }
        }
        /// <summary>
        ///  Draws the text if needed
        /// </summary>
        /// <param name="g"></param>
        private void DrawStringIfNeeded(Graphics g)
        {
            if (VisualMode != ProgressBarDisplayMode.NoText)
            {
                var text = _textToDraw;

                var len = g.MeasureString(text, TextFont);

                var location = new Point(Width / 2 - (int) len.Width / 2, Height / 2 - (int) len.Height / 2);

                g.DrawString(text, TextFont, _textColourBrush, location);
            }
        }
        /// <summary>
        ///  Dispose all resources
        /// </summary>
        public new void Dispose()
        {
            _textColourBrush.Dispose();
            _progressColourBrush.Dispose();
            base.Dispose();
        }
    }
}
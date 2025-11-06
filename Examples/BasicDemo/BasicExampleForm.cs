using System;
using System.Drawing;
using System.Windows.Forms;

namespace Windows11Effects.Examples
{
    public partial class BasicExampleForm : Form
    {
        private Windows11Effects effects;
        
        public BasicExampleForm()
        {
            InitializeComponent();
            InitializeWindows11Effects();
            SetupModernUI();
        }
        
        private void InitializeWindows11Effects()
        {
            effects = new Windows11Effects(this);
            
            // Apply Windows 11 effects if available
            if (Windows11Effects.IsWindows11OrGreater())
            {
                effects.ApplyFullWindows11Theme();
            }
            else
            {
                // Fallback styling for older Windows versions
                this.BackColor = Color.FromArgb(45, 45, 48);
                this.ForeColor = Color.White;
            }
        }
        
        private void SetupModernUI()
        {
            this.Text = "Windows 11 Effects Demo";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            
            // Create modern controls
            CreateModernControls();
        }
        
        private void CreateModernControls()
        {
            // Title label
            var titleLabel = new Label()
            {
                Text = "Windows 11 Visual Effects Demo",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(50, 50),
                AutoSize = true
            };
            
            // Description label
            var descLabel = new Label()
            {
                Text = "Experience Mica, Acrylic, and Dark Mode effects",
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.LightGray,
                Location = new Point(50, 90),
                AutoSize = true
            };
            
            // Effect buttons
            var micaButton = new Button()
            {
                Text = "Enable Mica",
                Font = new Font("Segoe UI", 9),
                BackColor = Color.FromArgb(0, 120, 215),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(120, 35),
                Location = new Point(50, 150)
            };
            micaButton.Click += (s, e) => effects.EnableMicaEffect();
            
            var acrylicButton = new Button()
            {
                Text = "Enable Acrylic",
                Font = new Font("Segoe UI", 9),
                BackColor = Color.FromArgb(0, 120, 215),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(120, 35),
                Location = new Point(180, 150)
            };
            acrylicButton.Click += (s, e) => effects.EnableAcrylicEffect();
            
            var darkModeButton = new Button()
            {
                Text = "Toggle Dark Mode",
                Font = new Font("Segoe UI", 9),
                BackColor = Color.FromArgb(0, 120, 215),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(120, 35),
                Location = new Point(310, 150)
            };
            darkModeButton.Click += (s, e) => 
            {
                effects.SetDarkMode(this.BackColor != Color.Black);
            };
            
            // Add controls to form
            this.Controls.AddRange(new Control[] 
            { 
                titleLabel, 
                descLabel, 
                micaButton, 
                acrylicButton, 
                darkModeButton 
            });
        }
    }
}

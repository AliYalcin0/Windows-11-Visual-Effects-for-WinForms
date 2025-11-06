using System;
using System.Drawing;
using System.Windows.Forms;

namespace Windows11Effects.Examples
{
    public partial class AdvancedExampleForm : Form
    {
        private Windows11Effects effects;
        private Panel sidebar;
        private Panel contentPanel;
        
        public AdvancedExampleForm()
        {
            InitializeComponent();
            InitializeAdvancedEffects();
            CreateModernLayout();
        }
        
        private void InitializeAdvancedEffects()
        {
            effects = new Windows11Effects(this);
            
            if (Windows11Effects.IsWindows11OrGreater())
            {
                // Use Mica for main window
                effects.EnableMicaEffect();
                effects.SetDarkMode(true);
                
                // Additional Windows 11 optimizations
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.MinimumSize = new Size(1000, 700);
            }
        }
        
        private void CreateModernLayout()
        {
            this.Size = new Size(1200, 800);
            this.Text = "Advanced Windows 11 Demo";
            
            CreateSidebar();
            CreateContentArea();
            CreateNavigation();
        }
        
        private void CreateSidebar()
        {
            sidebar = new Panel()
            {
                BackColor = Color.FromArgb(33, 33, 33),
                Size = new Size(250, this.ClientSize.Height),
                Location = new Point(0, 0)
            };
            
            var sidebarTitle = new Label()
            {
                Text = "Navigation",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(20, 20),
                AutoSize = true
            };
            
            sidebar.Controls.Add(sidebarTitle);
            this.Controls.Add(sidebar);
        }
        
        private void CreateContentArea()
        {
            contentPanel = new Panel()
            {
                BackColor = Color.Transparent,
                Size = new Size(this.ClientSize.Width - 250, this.ClientSize.Height),
                Location = new Point(250, 0)
            };
            
            var welcomeLabel = new Label()
            {
                Text = "Welcome to Modern UI",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(50, 50),
                AutoSize = true
            };
            
            contentPanel.Controls.Add(welcomeLabel);
            this.Controls.Add(contentPanel);
        }
        
        private void CreateNavigation()
        {
            string[] menuItems = { "Dashboard", "Settings", "Profile", "Help" };
            
            for (int i = 0; i < menuItems.Length; i++)
            {
                var menuButton = new Button()
                {
                    Text = menuItems[i],
                    Font = new Font("Segoe UI", 10),
                    BackColor = Color.Transparent,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Size = new Size(210, 40),
                    Location = new Point(20, 70 + (i * 50)),
                    TextAlign = ContentAlignment.MiddleLeft
                };
                
                menuButton.FlatAppearance.BorderSize = 0;
                menuButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(68, 68, 68);
                
                sidebar.Controls.Add(menuButton);
            }
        }
    }
}

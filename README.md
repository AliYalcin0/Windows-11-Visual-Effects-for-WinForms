<div align="center">

# 🪟 Windows 11 Visual Effects for WinForms

![Windows 11](https://img.shields.io/badge/Windows%2011-0078D4?style=for-the-badge&logo=windows&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)

**Transform your legacy WinForms apps into modern Windows 11 masterpieces! ✨**

<img src="https://raw.githubusercontent.com/microsoft/fluentui-system-icons/main/assets/WindowAppsRegular.svg" width="120" alt="Windows 11 Icon" />

</div>

---

## 🚀 Quick Start

### ⚡ 1-Minute Setup

```csharp
using Windows11Effects;

public partial class MainForm : Form
{
    private Windows11Effects effects;

    public MainForm()
    {
        InitializeComponent();

        // Apply Windows 11 effects
        effects = new Windows11Effects(this);
        if (Windows11Effects.IsWindows11OrGreater())
        {
            effects.EnableMicaEffect();
            effects.SetDarkMode(true);
        }
    }
}
csharp
Kodu kopyala
// 🎯 One-Liner Magic
new Windows11Effects(this).ApplyFullWindows11Theme();
📦 Installation
🔧 Method 1: Manual Installation
bash
Kodu kopyala
# 1. Create a new file in your project
Windows11Effects.cs

# 2. Copy the Windows11Effects class code

# 3. Add using statement
using Windows11Effects;
📦 Method 2: NuGet Package
bash
Kodu kopyala
# Package Manager Console
Install-Package Win11Effects.Fluent

# .NET CLI
dotnet add package Win11Effects.Fluent

# PackageReference
<PackageReference Include="Win11Effects.Fluent" Version="1.0.0" />
🐙 Method 3: Clone Repository
bash
Kodu kopyala
git clone https://github.com/yourrepo/winforms-win11-effects.git
cp Windows11Effects.cs YourProject/
💫 Features
🎨 Visual Effects
Feature	Icon	Windows 11	Windows 10	Description
Mica Effect	🎨	✅ Full	❌ No Support	Windows 11 signature material design
Acrylic Effect	🔮	✅ Full	⚠️ Limited	Semi-transparent blur background
Dark Mode	🌙	✅ Full	✅ Full	System-level dark theme integration
Auto Detection	🔍	✅	✅	Smart OS version checking

⚡ Performance & Compatibility
Aspect	Rating	Details
Performance	⭐⭐⭐⭐⭐	Hardware accelerated
Memory Usage	⭐⭐⭐⭐	Lightweight implementation
Compatibility	⭐⭐⭐⭐	Windows 10/11 support
Ease of Use	⭐⭐⭐⭐⭐	Simple API

🛠️ Usage Examples
🏁 Basic Implementation
csharp
Kodu kopyala
public class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();

        // Initialize effects
        var effects = new Windows11Effects(this);

        // Apply if Windows 11
        if (Windows11Effects.IsWindows11OrGreater())
        {
            effects.EnableMicaEffect();
            effects.SetDarkMode(true);
        }

        // Modern styling
        this.BackColor = Color.FromArgb(32, 32, 32);
        this.ForeColor = Color.White;
    }
}
🚀 Advanced Implementation
csharp
Kodu kopyala
public class DashboardForm : Form
{
    private Windows11Effects effects;
    private bool isDarkMode = true;

    public DashboardForm()
    {
        // Apply all effects
        effects = new Windows11Effects(this);
        effects.ApplyFullWindows11Theme();

        SetupModernInterface();
    }

    private void SetupModernInterface()
    {
        // Modern color scheme
        this.BackColor = Color.FromArgb(28, 28, 30);
        this.ForeColor = Color.White;

        // Modern controls
        CreateNavigation();
        CreateContent();
    }

    // Toggle effects at runtime
    private void ToggleDarkMode()
    {
        isDarkMode = !isDarkMode;
        effects.SetDarkMode(isDarkMode);
    }
}
🎮 Real-Time Control
csharp
Kodu kopyala
// Dynamic effect switching
private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
{
    switch (comboBox1.SelectedIndex)
    {
        case 0: effects.EnableMicaEffect(); break;
        case 1: effects.EnableAcrylicEffect(); break;
        case 2: effects.DisableEffects(); break;
    }
}

// Theme toggling
private void themeButton_Click(object sender, EventArgs e)
{
    effects.SetDarkMode(!effects.IsDarkModeEnabled());
}
📚 API Reference
🏗️ Constructor
csharp
Kodu kopyala
Windows11Effects effects = new Windows11Effects(targetForm);
⚡ Core Methods
Method	Parameters	Returns	Description
EnableMicaEffect()	None	void	Applies Mica material effect
EnableAcrylicEffect()	None	void	Applies Acrylic blur effect
SetDarkMode(bool enable)	enable	void	Toggles dark mode
DisableEffects()	None	void	Removes all effects

🎯 Utility Methods
Method	Parameters	Returns	Description
IsWindows11OrGreater()	None	bool	Checks OS compatibility
ApplyFullWindows11Theme()	None	void	Applies all effects

🎨 Customization Guide
🌈 Color Schemes
csharp
Kodu kopyala
// Dark Theme
this.BackColor = Color.FromArgb(32, 32, 32);
this.ForeColor = Color.White;
button.BackColor = Color.FromArgb(0, 120, 215);

// Light Theme
this.BackColor = Color.White;
this.ForeColor = Color.Black;
button.BackColor = Color.FromArgb(0, 102, 204);
⚙️ Recommended Form Settings
csharp
Kodu kopyala
// For best results
this.FormBorderStyle = FormBorderStyle.Sizable;
this.DoubleBuffered = true;
this.MinimumSize = new Size(800, 600);
this.StartPosition = FormStartPosition.CenterScreen;
⚡ Performance Tips
✅ Best Practices
csharp
Kodu kopyala
// ✅ Enable double buffering
this.DoubleBuffered = true;

// ✅ Check OS before applying effects
if (Windows11Effects.IsWindows11OrGreater())
{
    effects.EnableMicaEffect();
}

// ✅ Use modern fonts
this.Font = new Font("Segoe UI", 9);
❌ Common Mistakes
csharp
Kodu kopyala
// ❌ Don't forget OS check
effects.EnableMicaEffect(); // Crashes on Windows 10

// ❌ Avoid solid colors
this.BackColor = Color.Black; // Overrides effects

// ❌ Wrong border style
this.FormBorderStyle = FormBorderStyle.FixedDialog; // Limits effects
🐛 Troubleshooting
Problem	Solution	Example
Effects not showing	Check Windows version	Windows11Effects.IsWindows11OrGreater()
Performance issues	Enable double buffering	this.DoubleBuffered = true;
Compilation errors	Add DLL import	using System.Runtime.InteropServices;

🧩 Debug Mode
csharp
Kodu kopyala
public void EnableEffectsWithLogging()
{
    try
    {
        if (Windows11Effects.IsWindows11OrGreater())
        {
            effects.EnableMicaEffect();
            Console.WriteLine("✅ Mica effect applied");
        }
        else
        {
            Console.WriteLine("⚠️ Windows 11 required for Mica");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"❌ Error: {ex.Message}");
    }
}

<div align="center">
⭐ Don’t forget to star this repo if you found it helpful!
Made with ❤️ for the WinForms community.

Happy Coding! 🎉

</div> ```

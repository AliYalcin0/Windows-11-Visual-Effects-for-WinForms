<div align="center">

# 🪟 Windows 11 Visual Effects for WinForms

![Windows 11](https://img.shields.io/badge/Windows%2011-0078D4?style=for-the-badge&logo=windows&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![NuGet](https://img.shields.io/nuget/v/Win11Effects.Fluent?style=for-the-badge&logo=nuget)

**Transform your legacy WinForms apps into modern Windows 11 masterpieces! ✨**

<img src="https://raw.githubusercontent.com/microsoft/fluentui-emoji/main/assets/Window/SVG/ic_fluent_window_24_regular.svg" width="120" alt="Windows 11 Icon">

</div>

---

## 🚀 Quick Start

### ⚡ 1-Minute Setup

```csharp
using Win11Effects.Fluent;

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
```

### 🎯 One-Liner Magic

```csharp
new Windows11Effects(this).ApplyFullWindows11Theme();
```

## 📦 Installation
<img src="https://placehold.co/700x200/2D2D30/FFFFFF/png?text=3+Easy+Ways+to+Get+Started" width="80%" alt="Installation Methods">

> 🔧 Method 1: NuGet Package (Recommended)
```csharp
# Package Manager Console
Install-Package Win11Effects.Fluent

# .NET CLI
dotnet add package Win11Effects.Fluent

# PackageReference
<PackageReference Include="Win11Effects.Fluent" Version="1.0.0" />
```
> 📋 Method 2: Manual Installation

```csharp
# 1. Create a new file in your project
Windows11Effects.cs

# 2. Copy the Windows11Effects class code from GitHub

# 3. Add using statement
using Win11Effects.Fluent;

```
> 🐙 Method 3: Clone Repository
```csharp
git clone https://github.com/AliYalcin0/Windows-11-Visual-Effects-for-WinForms.git
cp Windows11Effects.cs YourProject/
```

### 💫 Features
<img src="https://placehold.co/800x400/1E1E1E/FFFFFF/png?text=Stunning+Visual+Effects+Gallery" width="90%" alt="Features Showcase">

### 🎨 Visual Effects

| Feature | Icon | Windows 11 | Windows 10 | Description |
|---------|------|------------|------------|-------------|
| **Mica Effect** | 🎨 | ✅ Full Support | ❌ No Support | Windows 11's signature material design with dynamic texture |
| **Acrylic Effect** | 🔮 | ✅ Full Support | ⚠️ Limited | Beautiful semi-transparent blur background effects |
| **Dark Mode** | 🌙 | ✅ Full Support | ✅ Full Support | Seamless system-level dark theme integration |
| **Auto Detection** | 🔍 | ✅ Smart | ✅ Smart | Intelligent OS version checking and fallbacks |

### ⚡ Performance & Compatibility

| Aspect | Rating | Details |
|--------|--------|---------|
| **Performance** | ⭐⭐⭐⭐⭐ | Hardware accelerated, minimal CPU usage |
| **Memory Usage** | ⭐⭐⭐⭐ | Lightweight, efficient implementation |
| **Compatibility** | ⭐⭐⭐⭐ | Windows 10/11 with smart fallbacks |
| **Easy of Use** | ⭐⭐⭐⭐⭐ | Simple API, just one line of code |

### 🛠️ Usage Examples
<img src="https://placehold.co/700x200/0078D4/FFFFFF/png?text=Practical+Code+Examples+for+Every+Scenario" width="80%" alt="Usage Examples">

```csharp
public class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
        
        // 🎨 Initialize Windows 11 effects
        var effects = new Windows11Effects(this);
        
        // 🔍 Apply only if Windows 11
        if (Windows11Effects.IsWindows11OrGreater())
        {
            effects.EnableMicaEffect();
            effects.SetDarkMode(true);
        }
        
        // 🎯 Modern styling for all Windows versions
        this.BackColor = Color.FromArgb(32, 32, 32);
        this.ForeColor = Color.White;
        this.Font = new Font("Segoe UI", 9);
    }
}
```
```csharp
public class DashboardForm : Form
{
    private Windows11Effects effects;
    private bool isDarkMode = true;
    
    public DashboardForm()
    {
        // ✨ Apply ALL Windows 11 effects automatically
        effects = new Windows11Effects(this);
        effects.ApplyFullWindows11Theme();
        
        // 🎨 Setup modern interface
        SetupModernInterface();
    }
    
    private void SetupModernInterface()
    {
        // 🌙 Modern dark color scheme
        this.BackColor = Color.FromArgb(28, 28, 30);
        this.ForeColor = Color.White;
        
        // 🎯 Create modern UI components
        CreateNavigation();
        CreateContent();
        CreateStatusBar();
    }
    
    // 🔄 Toggle effects at runtime
    private void ToggleDarkMode()
    {
        isDarkMode = !isDarkMode;
        effects.SetDarkMode(isDarkMode);
    }
}
```
```csharp
// Dynamic effect switching
private void comboBoxEffects_SelectedIndexChanged(object sender, EventArgs e)
{
    switch (comboBoxEffects.SelectedIndex)
    {
        case 0: 
            effects.EnableMicaEffect(); 
            statusLabel.Text = "🎨 Mica Effect Enabled";
            break;
        case 1: 
            effects.EnableAcrylicEffect(); 
            statusLabel.Text = "🔮 Acrylic Effect Enabled";
            break;
        case 2: 
            effects.DisableEffects(); 
            statusLabel.Text = "⚫ Effects Disabled";
            break;
    }
}

// Theme toggling with visual feedback
private void themeButton_Click(object sender, EventArgs e)
{
    bool newDarkMode = !effects.IsDarkModeEnabled();
    effects.SetDarkMode(newDarkMode);
    themeButton.Text = newDarkMode ? "☀️ Light Mode" : "🌙 Dark Mode";
}
```

### 📚 API Reference
<img src="https://placehold.co/700x200/2D2D30/FFFFFF/png?text=Comprehensive+API+Reference+Guide" width="80%" alt="API Reference">


```csharp
// 🏗️ Constructor
// 📝 Creates a new Windows 11 effects controller
Windows11Effects effects = new Windows11Effects(targetForm);
```

### ⚡ Core Methods

| Method | Parameters | Returns | Description |
|--------|------------|---------|-------------|
| `EnableMicaEffect()` | `None` | `void` | 🎨 Applies beautiful Mica material effect |
| `EnableAcrylicEffect()` | `None` | `void` | 🔮 Applies semi-transparent Acrylic blur |
| `SetDarkMode(bool)` | `enable` | `void` | 🌙 Toggles dark/light mode seamlessly |
| `DisableEffects()` | `None` | `void` | ⚫ Removes all visual effects |

### 🎨 Customization Guide
<img src="https://placehold.co/700x200/0078D4/FFFFFF/png?text=Custom+Themes+%26+Color+Schemes" width="80%" alt="Customization">

```csharp
// 🌈 Color Schemes

// 🌙 Dark Theme (Recommended)
this.BackColor = Color.FromArgb(32, 32, 32);    // Deep dark background
this.ForeColor = Color.White;                   // Crisp white text
button.BackColor = Color.FromArgb(0, 120, 215); // Modern blue accents
```
```csharp
// 🌙 Dark Theme (Recommended)
this.BackColor = Color.FromArgb(32, 32, 32);    // Deep dark background
this.ForeColor = Color.White;                   // Crisp white text
button.BackColor = Color.FromArgb(0, 120, 215); // Modern blue accents
```
```csharp
// 🎨 Custom Theme
this.BackColor = Color.FromArgb(43, 43, 43);    // Custom dark gray
this.ForeColor = Color.FromArgb(220, 220, 220); // Soft white text
```

### ⚙️ Recommended Form Settings

```csharp
// 🎯 For the best Windows 11 experience
this.FormBorderStyle = FormBorderStyle.Sizable;  // Required for effects
this.DoubleBuffered = true;                      // Smooth rendering
this.MinimumSize = new Size(800, 600);           // Responsive design
this.StartPosition = FormStartPosition.CenterScreen; // Professional placement
this.Font = new Font("Segoe UI", 9);             // Modern Windows font
```

### ⚡ Performance Tips
<img src="https://placehold.co/700x200/107C10/FFFFFF/png?text=Best+Practices+for+Optimal+Performance" width="80%" alt="Performance Tips">

```csharp
// ✅ Always enable double buffering for smoothness
this.DoubleBuffered = true;

// ✅ Check OS compatibility before applying effects
if (Windows11Effects.IsWindows11OrGreater())
{
    effects.EnableMicaEffect(); // Safe to apply
}

// ✅ Use modern Windows fonts
this.Font = new Font("Segoe UI", 9);

// ✅ Set proper form border style
this.FormBorderStyle = FormBorderStyle.Sizable;
```

```csharp
// ❌ Never apply effects without checking OS first
effects.EnableMicaEffect(); // ❌ Crashes on Windows 10!

// ❌ Avoid solid colors that override effects
this.BackColor = Color.Black; // ❌ Overrides Mica/Acrylic

// ❌ Wrong border style limits effects
this.FormBorderStyle = FormBorderStyle.FixedDialog; // ❌ No effects!

// ❌ Don't forget to enable double buffering
// Missing: this.DoubleBuffered = true; // ❌ Causes flickering
```

### 🐛 Troubleshooting
<img src="https://placehold.co/700x200/D83B01/FFFFFF/png?text=Quick+Solutions+for+Common+Problems" width="80%" alt="Troubleshooting">

### 🔧 Common Issues & Solutions

| Problem | Solution | Code Example |
|---------|----------|--------------|
| **Effects not showing** | Check Windows version first | `Windows11Effects.IsWindows11OrGreater()` |
| **Performance issues** | Enable double buffering | `this.DoubleBuffered = true` |
| **Compilation errors** | Add required DLL import | `using System.Runtime.InteropServices` |
| **Effects look wrong** | Set proper border style | `FormBorderStyle.Sizable` |

```csharp
public void EnableEffectsWithLogging()
{
    try
    {
        if (Windows11Effects.IsWindows11OrGreater())
        {
            effects.EnableMicaEffect();
            Console.WriteLine("✅ Mica effect applied successfully!");
            statusLabel.Text = "🎨 Mica Effect Active";
        }
        else
        {
            Console.WriteLine("⚠️ Windows 11 required for Mica effect");
            statusLabel.Text = "⚠️ Upgrade to Windows 11 for effects";
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"❌ Error applying effects: {ex.Message}");
        statusLabel.Text = "❌ Error applying effects";
    }
}
```

<div align="center">
⭐ Love This Project?
If this library made your WinForms app look amazing, give it a star! ⭐

<img src="https://placehold.co/400x100/FFB900/000000/png?text=⭐+Star+This+Repository+⭐" width="50%" alt="Star Repository">
Made with ❤️ for the WinForms community
<img src="https://placehold.co/300x80/0078D4/FFFFFF/png?text=Happy+Coding+!+🎉" width="40%" alt="Happy Coding"> ```


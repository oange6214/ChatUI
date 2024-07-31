using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ChatUI.CustomControls;

/// <summary>
/// Interaction logic for RoundProfileButton.xaml
/// </summary>
public partial class RoundProfileButton : UserControl
{
    public static readonly DependencyProperty ImageSourceProperty =
        DependencyProperty.Register(nameof(ProfileImageSource), typeof(ImageSource), typeof(RoundProfileButton));

    public static readonly DependencyProperty IsOnlineProperty =
        DependencyProperty.Register(nameof(IsOnline), typeof(bool), typeof(RoundProfileButton));

    public static readonly DependencyProperty StrokeBrushProperty =
        DependencyProperty.Register(nameof(StrokeBrush), typeof(SolidColorBrush), typeof(RoundProfileButton));

    public RoundProfileButton()
    {
        InitializeComponent();
    }

    public bool IsOnline
    {
        get { return (bool)GetValue(IsOnlineProperty); }
        set { SetValue(IsOnlineProperty, value); }
    }

    public ImageSource ProfileImageSource
    {
        get { return (ImageSource)GetValue(ImageSourceProperty); }
        set { SetValue(ImageSourceProperty, value); }
    }

    public SolidColorBrush StrokeBrush
    {
        get { return (SolidColorBrush)GetValue(StrokeBrushProperty); }
        set { SetValue(StrokeBrushProperty, value); }
    }
}
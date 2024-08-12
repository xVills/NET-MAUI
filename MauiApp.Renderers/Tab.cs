namespace MauiApp.Renderers;

public class Tab
{
    public static readonly BindableProperty BadgeIsVisibleProperty =
        BindableProperty.CreateAttached("BadgeIsVisible", typeof(bool), typeof(Tab), false);

    public static readonly BindableProperty BadgeColorProperty =
        BindableProperty.CreateAttached("BadgeColor", typeof(Color), typeof(Tab), Colors.Red);

    public static bool GetBadgeIsVisible(BindableObject view) => (bool)view.GetValue(BadgeIsVisibleProperty);

    public static void SetBadgeIsVisible(BindableObject view, bool value) => view.SetValue(BadgeIsVisibleProperty, value);

    public static Color GetBadgeColor(BindableObject view) => (Color)view.GetValue(BadgeColorProperty);

    public static void SetBadgeColor(BindableObject view, Color value) => view.SetValue(BadgeColorProperty, value);
}

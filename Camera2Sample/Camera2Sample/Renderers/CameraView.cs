using Xamarin.Forms;

namespace Camera2Sample.Renderers
{
    public class CameraView : View
    {
        public static readonly BindableProperty CameraProperty = BindableProperty.Create(
            "Camera",
            typeof(CameraOptions),
            typeof(CameraView),
            CameraOptions.Rear);
        public static readonly BindableProperty FlashProperty = BindableProperty.Create(
            "Flash",
            typeof(bool),
            typeof(CameraView),
            false);

        public CameraOptions Camera
        {
            get => (CameraOptions)GetValue(CameraProperty);
            set => SetValue(CameraProperty, value);
        }

        public bool Flash
        {
            get => (bool)GetValue(FlashProperty);
            set => SetValue(FlashProperty, value);
        }
    }
}

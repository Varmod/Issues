using CommunityToolkit.Maui.Views;

namespace ShouldMute
{
    public partial class MainPage : ContentPage
    {
        bool _flip = false;

        public MainPage()
        {
            InitializeComponent();
        }

        void OnPlayPauseButtonClicked(object sender, EventArgs e)
        {
            if (video2.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Playing)
            {
                video2.Pause();
            }
            else if (video2.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Paused)
            {
                video2.Play();
            }
            else if (video2.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Stopped)
            {
                video2.Stop();
                video2.Play();
            }
        }

        private void NextVideo_Clicked(object sender, EventArgs e)
        {
            if (_flip)
            {
                video2.Source = new ResourceMediaSource() { Path = "Sample.mp4" }; 
            }
            else
            {
                video2.Source = new ResourceMediaSource() { Path = "Sample2.mp4" };
            }
            _flip = !_flip;
        }
    }
}
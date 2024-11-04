using system;

public class AudioSystem{
    public void turnOn()
    {Console.Writeline("")}

    public void setVolume(int level)
    {console.Writeline("")}

    public void turnOff()
    {console.Writeline("")}
}

public class VideoProjector{
    public void turnOn()
    {Console.Writeline("")}

    public void setResolution(string resolution)
    {console.Writeline("")}

    public void turnOff()
    {console.Writeline("")}
}

public class LightingSystem{
    public void turnOn()
    {Console.Writeline("")}

    public void setBrightness(int level)
    {console.Writeline("")}

    public void turnOff()
    {console.Writeline("")}
}
 
public class HomeTheaterFacade
{
    private AudioSystem _audioSystem;
    private VideoProjector _videoProjector;
    private LightingSystem _lightingSystem;

public HomeTheaterFacade(AudioSystem audioSystem, VideoProjector videoProjector, LightingSystem lightingSystem)
{
_audioSystem = audioSystem;
_videoProjector = videoProjector;
_lightingSystem = lightingSystem;
}
public void StartMovie()
{
Console.WriteLine("Preparing to start the movie...");
_lightingSystem.TurnOn();
_lightingSystem.SetBrightness(5);
_audioSystem.TurnOn();
_audioSystem.SetVolume(8);
_videoProjector.TurnOn();
_videoProjector.SetResolution("HD");
Console.WriteLine("Movie started.");
}
public void EndMovie()
{
Console.WriteLine("Shutting down movie...");
_videoProjector.TurnOff();
_audioSystem.TurnOff();
_lightingSystem.TurnOff();
Console.WriteLime("");
}
}

class Program
{
static void Main(string[] args)
AudioSystem audio = new AudioSystem();
VideoProjector video = new VideoProjector();
LightingSystem lights = new LightingSystem();
HomeTheaterFacade homeTheater = new HomeTheaterFacade(audio, video, lights);

homeTheater.StartMovie();
Console.WriteLine();
homeTheater.EndMovie();
}

namespace Train
{
    internal class RailWagon
    {
        internal bool LightIsActive { get; private set; }

        internal RailWagon(bool lightIsActive)
        {
            LightIsActive = lightIsActive;
        }

        internal void SwitchLighting()
        {
            LightIsActive = !LightIsActive;
        }
    }
}

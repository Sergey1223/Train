namespace Train
{
    internal class Observer
    {
        internal static int CountWagons(Train train)
        {
            int count = 0;

            while (true)
            {
                // Move left to last counted wagon
                for (int i = count; i > 0; i--)
                {
                    train.MoveToPreviewWagon();
                }

                // Turn off light of last counted wagon
                RailWagon current = train.CurrentWagon;
                if (current.LightIsActive)
                {
                    current.SwitchLighting();
                }

                // Move left to preview wagon regarding last counted wagon
                train.MoveToPreviewWagon();

                // Turn on light of preview wagon regarding last counted wagon
                RailWagon preview = train.CurrentWagon;
                if (!preview.LightIsActive)
                {
                    train.CurrentWagon.SwitchLighting();
                }

                count++;

                // Return back to pivot wagon and chek for change light status
                for (int i = count; i > 0; i--)
                {
                    train.MoveToNextWagon();
                }

                if (train.CurrentWagon.LightIsActive)
                {
                    break;
                }
            }

            return count;
        }
    }
}

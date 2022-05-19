namespace Train
{
    internal class Train
    {
        private const int MINIMUM_WAGONS_COUNT = 1;
        private const int MAXIMUM_WAGONS_COUNT = 1000;

        private RailWagon[] wagons;
        private int pointer;

        internal RailWagon CurrentWagon
        {
            get
            {
                return wagons[pointer];
            }
        }

        internal Train()
        {
            CreateWagons();
        }

        internal void MoveToPreviewWagon()
        {
            pointer--;

            if (pointer < 0)
            {
                pointer = wagons.Length - 1;
            }
        }

        internal void MoveToNextWagon()
        {
            pointer++;

            if (pointer == wagons.Length)
            {
                pointer = 0;
            }
        }

        private void CreateWagons()
        {
            Random random = new Random();

            wagons = new RailWagon[random.Next(MINIMUM_WAGONS_COUNT, MAXIMUM_WAGONS_COUNT + 1)];

            pointer = random.Next(wagons.Length);

            for (int i = 0; i < wagons.Length; i++)
            {
                wagons[i] = new RailWagon(random.Next(2) == 1);
            }
        }
    }
}

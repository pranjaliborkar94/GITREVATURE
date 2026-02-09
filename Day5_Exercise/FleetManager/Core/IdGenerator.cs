namespace FleetManager.Core
{
    public static class IdGenerator
    {
        private static int _currentId = 0;

        public static int GenerateId()
        {
            return ++_currentId;
        }
    }
}

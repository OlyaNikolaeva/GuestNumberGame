namespace GuestNumberGame
{
    internal class Program
    {
        private readonly ISettingsInput _settingsInput;

        public Program(ISettingsInput settingsInput)
        {
            _settingsInput = settingsInput;
        }

        static void Main(string[] args)
        {
            ISettingsInput settingsInput = new CustomSettingsInput();
            IRandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();
            IGame game = new GuessTheNumberGame(randomNumberGenerator, settingsInput);
            game.Start();
        }
    }
}

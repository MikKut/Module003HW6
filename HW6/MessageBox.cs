namespace HW6
{
    internal class MessageBox
    {
        public MessageBox()
        {
            WindowIsClosed = WtiteInConcoleResult;
        }
        public event Action<State> WindowIsClosed;
        public async Task Open()
        {
            Console.WriteLine("Opened");
            await Task.Delay(3000);
            Console.WriteLine("Closed");
            WindowIsClosed?.Invoke((State)(new Random().Next(0,2)));
        }
        private void WtiteInConcoleResult(State state)
        {
            switch(state)
            {
                case State.Cancel:
                    Console.WriteLine("Oперацiя була вiдхилена");
                    break;
                case State.Ok:
                    Console.WriteLine("Oперацiя була пiдтверджена");
                    break;
                default:
                    throw new NotImplementedException("There is no such state: " + state);
            }
        }
    }
}

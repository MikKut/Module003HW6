using HW6;

public static class Starter
{
    public static async Task StartAsync()
    { 
        for (int i = 10; i > 0; i--)
        {
            var x = new MessageBox();
            await x.Open();
        }
    }
}

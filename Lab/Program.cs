using System;

class Playlist
{
    private Stack<string> history = new Stack<string>(); // for rewinding
    private Queue<string> queue = new Queue<string>(); // the playlist queue

    public void AddSong(string songName)
    {
        queue.Enqueue(songName);
        Console.WriteLine($"\"{songName}\" added to your playlist.");
    }

    public void PlayNextSong()
    {
        if (queue.Count == 0)
        {
            Console.WriteLine("No songs queued.");
            return;
        }

        string songName = queue.Dequeue();
        history.Push(songName);
        Console.WriteLine($"Now playing \"{songName}\".");
        if (queue.Count == 0)
        {
            Console.WriteLine("No songs queued.");
        }
        else
        {
            Console.WriteLine($"Next song: \"{queue.Peek()}\"");
        }
    }

    public void SkipSong()
    {
        if (queue.Count == 0)
        {
            Console.WriteLine("No songs queued.");
            return;
        }

        string songName = queue.Dequeue();
        Console.WriteLine($"Skipping \"{songName}\"...");
        if (queue.Count == 0)
        {
            Console.WriteLine("No songs queued.");
        }
        else
        {
            Console.WriteLine($"Next song: \"{queue.Peek()}\"");
        }
    }

    public void RewindOneSong()
    {
        if (history.Count < 2)
        {
            Console.WriteLine("No previous song to rewind to.");
            return;
        }

        string songName = history.Pop();
        Console.WriteLine($"Rewinding to \"{history.Peek()}\"...");
        queue.Enqueue(songName);
        Console.WriteLine($"\"{songName}\" re-queued.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Playlist playlist = new Playlist();
        while (true)
        {
            Console.WriteLine("Choose an option:\n1. Add a song to your playlist\n2. Play the next song in your playlist\n3. Skip the next song\n4. Rewind one song\n5. Exit");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Enter song name: ");
                    string songName = Console.ReadLine();
                    playlist.AddSong(songName);
                    break;
                case "2":
                    playlist.PlayNextSong();
                    break;
                case "3":
                    playlist.SkipSong();
                    break;
                case "4":
                    playlist.RewindOneSong();
                    break;
                case "5":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
            Console.WriteLine();
        }
    }
}
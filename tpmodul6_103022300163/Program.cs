// See https://aka.ms/new-console-template for more information
class SayaTubeVideo {
  private int id;
  private string title;
  private int playCount;

  public SayaTubeVideo(string title) {
    this.title = title;
    id = (new Random()).Next(5);
    playCount = 0;
  }
  public void IncreasePlayCount(int count) {
    playCount += count;
  }
  public void PrintVideoDetails() {
    Console.WriteLine("Detail Video");
    Console.WriteLine("ID Video: " + id);
    Console.WriteLine("Judul Video: " + title);
    Console.WriteLine("Jumlah Pemutaran Video: " + playCount);
  }
}

class Program {
  static void Main(string[] args) {
    SayaTubeVideo sayaVideo = new SayaTubeVideo("Tutorial Design By Contract - Hafidz Naufal Pradana");
    sayaVideo.IncreasePlayCount(42);
    sayaVideo.PrintVideoDetails();
  }
}

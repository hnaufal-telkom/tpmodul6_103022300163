// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;

class SayaTubeVideo {
  private int id;
  private string title;
  private int playCount;

  public SayaTubeVideo(string title) {
    Contract.Requires(title.Length <= 100 && title != null);
    // Saya buat if statement soalnya contract nya gabisa dipake di project saya entah kenapa, ngga tau gimana setting nya
    if (title.Length > 100 || title == null) {
      throw new ArgumentException("Judul tidak boleh kosong dan tidak lebih dari 100 karakter");
    }

    this.title = title;
    id = (new Random()).Next(5);
    playCount = 0;
  }
  public void IncreasePlayCount(int count) {
    Contract.Requires(count <= 10000000);
    if (count > 10000000) {
      throw new ArgumentException("Tidak dapat menambah PlayCount lebih dari 10000000 dalam sekali pemanggilan");
    }

    try {
      checked {
        playCount += count;
      }
    } catch (OverflowException e) {
      Console.WriteLine(e.Message);
    }
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
    for (int i = 0; i < 215; i++) {
      sayaVideo.IncreasePlayCount(10000000);
    }
    sayaVideo.PrintVideoDetails();
  }
}

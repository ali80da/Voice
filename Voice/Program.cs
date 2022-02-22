// Use Voice
using System.Speech.Synthesis;

/*Console.OutputEncoding = System.Text.Encoding.Unicode;*/

string? TypeAnything;

SpeechSynthesizer Sound = new SpeechSynthesizer();
Sound.SetOutputToDefaultAudioDevice();


Console.WriteLine("START THE PROGRAM");
Console.WriteLine("For Use   PROGRAM Please Type Anything\n");


for (string? Say = ""; Say != null;)
{
    Console.Write("You Want The PROGRAM To Say: ");
    TypeAnything = Console.ReadLine();
    Sound.Speak(TypeAnything);
    Console.Write("PROGRAM Say: " + TypeAnything);
    Console.WriteLine("\n------------------------------------");
}


Console.WriteLine("Press Any Key To Close Program");
Console.ReadKey();
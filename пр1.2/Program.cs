string text = "Це довгий текст, який потрібно вивести у рамці фіксованої ширини. " +
              "Програма повинна розбити текст на рядки, довжина яких не перевищує 200 символів. " +
              "Також програма повинна підтримувати вирівнювання по лівому та правому краю.";

var left = new LeftAlignedTextFrame();
left.Text = text;
left.PrintFrame();

Console.WriteLine();

var right = new RightAlignedTextFrame();
right.Text = text;
right.PrintFrame();
public abstract class TextFrame
{
    protected const int Width = 200;

    public string Text { get; set; }

    public void PrintFrame()
    {
        PrintBorder();

        List<string> lines = PrepareLines();

        foreach (string line in lines)
        {
            PrintLine(line);
        }

        PrintBorder();
    }

    protected void PrintBorder()
    {
        Console.WriteLine(new string('-', Width + 2));
    }

    protected List<string> PrepareLines()
    {
        List<string> lines = new List<string>();
        string line = "";

        foreach (char c in Text)
        {
            if (line.Length == Width)
            {
                lines.Add(line);
                line = "";
            }

            line += c;
        }

        if (line.Length > 0)
        {
            lines.Add(line);
        }

        return lines;
    }

    protected abstract void PrintLine(string line);
}

public class LeftAlignedTextFrame : TextFrame
{
    protected override void PrintLine(string line)
    {
        Console.WriteLine("|" + line.PadRight(Width) + "|");
    }
}

public class RightAlignedTextFrame : TextFrame
{
    protected override void PrintLine(string line)
    {
        Console.WriteLine("|" + line.PadLeft(Width) + "|");
    }
}
using System;
using System.Drawing;
using System.Windows.Forms;

public class CForm : Form
{
    public CForm()
    {
        this.Text = "Ein Paint-Ereginis";
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics gra = e.Graphics;

        gra.DrawString("Hallo Forms",
            this.Font,
            Brushes.Black,
            100,
            100);

        // Linie
        gra.DrawLine(new Pen(Color.Blue, 5), 10, 10, 100, 100);

        // Rechteck
        gra.DrawRectangle(new Pen(Color.Black, 5), 100, 100, 200, 200);

        // Ellipse
        gra.DrawEllipse(new Pen(Color.Black, 3), 100, 100, 200, 200);

        // Bild
        Image bild = Image.FromFile("C:\\Users\\Public\\Pictures\\Papierstapel.jpg");
    }
}

public class Program
{
    public static void Main()
    {
        CForm zweiteForm = new CForm();
        Application.Run(zweiteForm);
    }
}
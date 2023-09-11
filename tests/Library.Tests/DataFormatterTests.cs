using Microsoft.VisualBasic;
using Ucu.Poo.TestDateFormat;

namespace Library.Tests;

public class DateFormatterTests
{
    private DateFormatter dateFormatter;
    [SetUp]
    public void Setup()
    {
        dateFormatter = new DateFormatter();
    }

    [Test]
    public void Test1(){
        string fecha = "12/05/2023";
        bool esValida = dateFormatter.ValidarFecha(fecha);

        Assert.IsFalse(esValida);
    }
    public void Test2(){
        string fecha = "2023-05-12";
        bool esValida = dateFormatter.ValidarFecha(fecha);

        Assert.IsTrue(esValida);
    }
    public void Test3(){
        string fecha = " ";
        bool esValida = dateFormatter.ValidarFecha(fecha);

        Assert.IsFalse(esValida);
    }
}
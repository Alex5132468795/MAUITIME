using MauiApp1.Model;
using System.Collections.ObjectModel;
namespace MauiApp1;

public partial class MainPage : ContentPage{

    public ObservableCollection<Messager> Mess { get; set; }
	public MainPage()
	{
		Mess=new ObservableCollection<Messager>();
		BindingContext = this;
		InitializeComponent();
		//DateTime d = DateTime.Now;
		//DateTime d2 = DateTime.Now;
		//L.Text = d.ToLocalTime().ToString();
		//L1.Text = d.ToString("D");
		//L.Text = d.Subtract(DateTime.Now).ToString();
		//TimeSpan s = d-DateTime.Now;
		//DatePicker qw;

	}
	private void DateSwitch(object sender, ToggledEventArgs e)
	{
		if(e.Value == false)
		{
			dates.Format = "yyyy dd MMMM";
		}
		else
		{
			dates.Format = "yy dd MMMM";
		}
	}

	private void TimeSwitch(object sender, ToggledEventArgs e)
	{
        if (e.Value == false)
        {
            times.Format = "hh:m";
        }
        else
        {
            times.Format = "HH:mm";
        }
    }

	private void SetMes(object sender, EventArgs e)
	{
		Messager qwerty = new Messager();
		qwerty.date = dates.Date.ToString(dates.Format.ToString());
		qwerty.time = times.Time.ToString();
		qwerty.text = Messange.Text;
		Mess.Add(qwerty);
	}
}


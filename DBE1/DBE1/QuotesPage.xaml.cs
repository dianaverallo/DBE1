using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DBE1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuotesPage : ContentPage
	{
	    private int _index = 0;
	    private string[] _arrquotes = new string[]
	    {
            "You can't blame gravity for falling in love.",
	        "Next quote.",
	        "Last quote."
	    };

	    public QuotesPage()
	    {
	        InitializeComponent();
	        myQuote.Text = _arrquotes[_index];
	    }

	    void Handle_Clicked(object sender, System.EventArgs e)
	    {
	        _index++;
	        if (_index >= _arrquotes.Length)
	            _index = 0;

	        myQuote.Text = _arrquotes[_index];
	    }
    }
}
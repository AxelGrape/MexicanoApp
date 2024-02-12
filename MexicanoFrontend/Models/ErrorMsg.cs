namespace MexicanoFrontend.Models
{
	public class ErrorMsg(String type, String msg)
	{
		public String Msg { get; set; } = msg;

		public String Type { get; set; } = type;
	}
}

namespace PetShop.Web.Controls
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;

	/// <summary>
	///		Summary description for NavBar.
	/// </summary>
	public abstract class NavBarNoMenu : System.Web.UI.UserControl
	{
		protected System.Web.UI.HtmlControls.HtmlImage lizard1;
		protected System.Web.UI.HtmlControls.HtmlImage lizard5;
		protected System.Web.UI.HtmlControls.HtmlGenericControl areaLoggedIn;
		protected System.Web.UI.HtmlControls.HtmlGenericControl areaLoggedOut;
		protected System.Web.UI.HtmlControls.HtmlGenericControl areaMenu;
		protected System.Web.UI.HtmlControls.HtmlGenericControl areaNoMenu;
		protected System.Web.UI.HtmlControls.HtmlImage lizard4;

		// properties
	

		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			
			ShowLoggedInArea();
			
		}

		// display different items if person is logged in or not
		private void ShowLoggedInArea() {

			if (Request.IsAuthenticated != true) {

				areaLoggedIn.Visible = false;
				areaLoggedOut.Visible = true;

			} else {

				areaLoggedIn.Visible = true;
				areaLoggedOut.Visible = false;

			}
		}

				#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		///		Required method for Designer support - do not modify
		///		the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}

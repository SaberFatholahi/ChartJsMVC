namespace Chart.Js.MVC.Component 
{   
    public enum ComponentState
    {
		Default,
		Primary,
		Success,
		Info,
		Warning,
        Danger  
    }

	public enum BootstrapVersion
	{
		V3 = 3,
		V4 = 4
	}


	public enum ComponentSize
	{
		/// <summary>
		/// -xs
		/// </summary>
		ExtraSmall,
		/// <summary>
		/// -sm
		/// </summary>
		Small,
		/// <summary>
		/// -md
		/// </summary>
		Medium,
		/// <summary>
		/// -lg
		/// </summary>
		Larg,
	}
}

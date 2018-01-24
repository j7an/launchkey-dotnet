namespace iovation.LaunchKey.Sdk.Error
{
	/// <summary>
	/// Thrown when an HTTP 404 has occurred.
	/// </summary>
	public class EntityNotFound : CommunicationErrorException
	{
		public EntityNotFound(string message) : base(message)
		{
		}
	}
}
using Plugin.DeviceInfo;
using System.Threading.Tasks;

namespace Auth0.SDK
{
	public class DeviceIdProvider : IDeviceIdProvider
	{
		public Task<string> GetDeviceId ()
		{
			return Task.FromResult<string>(CrossDeviceInfo.Current.Id);
		}
	}
}


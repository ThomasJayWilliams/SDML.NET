using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SDML.NET
{
	public static class SdmlExporter
	{
		public static bool Save(string path, string content)
		{
			var sdmlPath = Path.ChangeExtension(path, ".sdml");

			using (var stream = new FileStream(sdmlPath, FileMode.OpenOrCreate, FileAccess.Write))
			{
				var bytes = Encoding.Default.GetBytes(content);
				stream.Write(bytes, 0, bytes.Length);
			}

			if (File.Exists(sdmlPath))
				return true;

			return false;
		}

		public async static Task<bool> SaveAsync(string path, string content)
		{
			var sdmlPath = Path.ChangeExtension(path, ".sdml");

			using (var stream = new FileStream(sdmlPath, FileMode.OpenOrCreate, FileAccess.Write))
			{
				var bytes = Encoding.Default.GetBytes(content);
				await stream.WriteAsync(bytes, 0, bytes.Length);
			}

			if (File.Exists(sdmlPath))
				return true;

			return false;
		}
	}
}


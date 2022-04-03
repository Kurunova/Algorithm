using System.IO;
using System.Reflection;

namespace Algorithm.Tests
{
	public abstract class BaseTest
	{
		private string _directoryName;
		protected string DirectoryName => _directoryName ??= Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Source", FolderName);
		
		protected virtual string FolderName => GetType().Name.Replace("Test","");
	}
}
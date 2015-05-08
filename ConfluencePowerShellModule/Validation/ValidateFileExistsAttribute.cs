using System.IO;
using System.Management.Automation;

namespace ConfluenceShell.Validation
{
    class ValidateFileExistsAttribute : ValidateArgumentsAttribute
    {
        protected override void Validate(object argument, EngineIntrinsics engineIntrinsics)
        {
            var filePath = (string) argument;

            if (!File.Exists(filePath))
            {
                throw new ParameterBindingException(string.Format("The provided filepath '{0}', does not exist.", filePath));
            }
        }
    }
}

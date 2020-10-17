
namespace otus_architecture_lab_8
{
    public class FileParserCsv : FileParcerBase
    {
        #region Methods

        protected override bool CanParce(string path)
        {
            return path.EndsWith(".csv");
        }


        protected override void Parce(string path)
        {
            SimpleServiceLocator.Instance.GetService<ILogger>().Log($"FileParserCsv parce: {path}");
        }

        #endregion
    }
}

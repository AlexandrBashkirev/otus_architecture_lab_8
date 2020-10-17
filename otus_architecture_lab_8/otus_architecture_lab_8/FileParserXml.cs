
namespace otus_architecture_lab_8
{
    public class FileParserXml : FileParcerBase
    {
        #region Methods

        protected override bool CanParce(string path)
        {
            return path.EndsWith(".xml");
        }


        protected override void Parce(string path)
        {
            SimpleServiceLocator.Instance.GetService<ILogger>().Log($"FileParserXml parce: {path}");
        }

        #endregion
    }
}

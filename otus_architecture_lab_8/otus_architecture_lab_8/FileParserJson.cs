
namespace otus_architecture_lab_8
{
    public class FileParserJson : FileParcerBase
    {
        #region Methods

        protected override bool CanParce(string path)
        {
            return path.EndsWith(".json");
        }


        protected override void Parce(string path)
        {
            SimpleServiceLocator.Instance.GetService<ILogger>().Log($"FileParserJson parce: {path}");
        }

        #endregion
    }
}


namespace otus_architecture_lab_8
{
    public class FileParserTxt : FileParcerBase
    {
        #region Methods

        protected override bool CanParce(string path)
        {
            return path.EndsWith(".txt");
        }


        protected override void Parce(string path)
        {
            SimpleServiceLocator.Instance.GetService<ILogger>().Log($"FileParserTxt parce: {path}");
        }

        #endregion
    }
}

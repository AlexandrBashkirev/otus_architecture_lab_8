
namespace otus_architecture_lab_8
{
    public abstract class FileParcerBase : HandlerBase
    {
        #region Methods

        protected abstract bool CanParce(string path);


        protected abstract void Parce(string path);


        public override void Handle(object request)
        {
            if (request is string path &&
                CanParce(path))
            {
                Parce(path);
            }
            else if (parent != null)
            {
                parent.Handle(request);
            }
            else
            {
                SimpleServiceLocator.Instance.GetService<ILogger>().Log($"Can't parce file: {request.ToString()}");
            }
        }

        #endregion
    }
}

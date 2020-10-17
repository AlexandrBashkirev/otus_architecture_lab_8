

namespace otus_architecture_lab_8
{
    public abstract class HandlerBase : IHandler
    {
        #region Variables

        protected IHandler parent = null;

        #endregion



        #region Methods

        public abstract void Handle(object request);


        public void SetParent(IHandler parent)
        {
            this.parent = parent;
        }

        #endregion
    }
}

namespace Adapters.Presenters.Interfaces
{
    public interface IPresenter<FormatDataType>
    {
        public FormatDataType Content { get; }
    }
}
